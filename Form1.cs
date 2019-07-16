using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;



namespace SudokuYeni
{
    public partial class formSudoku : Form
    {

        public Sudoku suankiSudoku;


        public formSudoku()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)    //Timer aracı
        {
            suankiSudoku.SureArttir();
            suankiSudoku.SureGoster();
        }


        private void SayiGirisi(object sender, EventArgs e)     //Textbox aracı
        {
            TextBox txt = (TextBox)sender;
            if (suankiSudoku != null && txt.Text != "")
            {
                
            }
                
        }

        private void ButonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == "btnYeniOyun")
            { 
                suankiSudoku.YeniOyun();  //Yeni Oyun butonunda gerçekleştirilecek fonsksiyon
            }
            else if(btn.Name == "btnPuan")
            {
                suankiSudoku.PuanHesapla();
                MessageBox.Show("Puan : " + suankiSudoku.PuanSoyle());  //Puan butonunda gerçekleştirilecek fonsksiyon
            }

            else if(btn.Name == "btnCozum")  
            {
                suankiSudoku.CozumGoster();  //Çözüm Göster butonunda gerçekleştirilecek fonsksiyon
            }
            else if(btn.Name == "btnKontrol")
            {
                suankiSudoku.HatalariGoster();  //Kontrol için gerçekleştirilecek fonsksiyon
            }
        }

        

        private void Form1_Shown(object sender, EventArgs e) //Form açıldığında new Sudoku fonksiyonu çalışmış olacak
        {
            suankiSudoku = new Sudoku();  //suankiSudoku Sudoku nesnesi

        }

        private void zorlukComboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {

        }
    }

    public class Hata  // hata sınıfı
    {
        TextBox textbox; 
        Timer hataSayacı;

        public Hata(object _textbox)  //hata yapıcı fonksiyonu
        {
            textbox = (TextBox)_textbox;
            textbox.BackColor = Color.Red; // Hataları kırmızı renkte gösterecek
            hataSayacı = new Timer();
            hataSayacı.Interval = 1000;
            hataSayacı.Tick += HataSayacı_ZamanVurusu;
            hataSayacı.Enabled = true;
        }

        private void HataSayacı_ZamanVurusu(object sender, EventArgs e)
        {
            textbox.BackColor = SystemColors.Window;
            hataSayacı.Enabled = false;
        }
    }

    public class Sudoku //sudoku sınıfı
    {
        string zorluk;
        int puan;
        TextBox[,] kutucuklar = new TextBox[10, 10];   //kutucukları belirtiyoruz
        int[,] sayilar = new int[10, 10];
        int sure;
        public int doldurulanKutucukSayisi;
        formSudoku aktifForm;



        public Sudoku()  //Sudoku yapıcı fonksiyonu
        {
            aktifForm = (formSudoku)Form.ActiveForm;
            puan = 0;
            sure = 0;
            doldurulanKutucukSayisi = 0;
            zorluk = aktifForm.zorlukComboBox.Text;
            for (int i = 1; i <= 9; i++)
                for (int j = 1; j <= 9; j++)
                {
                    sayilar[i, j] = -1;
                    kutucuklar[i, j] = aktifForm.Controls.Find("textBox" + i.ToString() + j.ToString(), true).FirstOrDefault() as TextBox; 
                    kutucuklar[i, j].Text = "";
                    kutucuklar[i, j].ReadOnly = false;
                    kutucuklar[i, j].ForeColor = SystemColors.WindowText; ;  //oyunda doldurulacak kutucukları gösteriyoruz
                }
            RastgeleOlustur();
            EkranaYaz();
        }

       

    

        public void RastgeleOlustur() // RastgeleOlustur fonksiyonu
        {
            Random r = new Random();  //rastgele sayı almak için 
            string[] sudoku = File.ReadAllLines("sudoku.txt");
            int rastgele = r.Next(0, sudoku.Length);

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    sayilar[i, j] = Convert.ToInt32(sudoku[rastgele][(i - 1) * 9 + (j - 1)]-48); 
                }
            }

            for (int i = 1; i <= 3; i++)
            {

                int sayi1 = r.Next(1, 4), sayi2 = r.Next(1, 4);

                while (sayi1 == sayi2)
                {
                    sayi2 = r.Next(1, 4);
                }

                for (int j = 1; j <= 9; j++)
                {
                    int yedek = sayilar[(i - 1) * 3 + sayi2, j];
                    sayilar[(i - 1) * 3 + sayi2, j] = sayilar[(i - 1) * 3 + sayi1, j];
                    sayilar[(i - 1) * 3 + sayi1, j] = yedek;

                }
            }

            for (int i = 1; i <= 3; i++)
            {

                int sayi1 = r.Next(1, 4), sayi2 = r.Next(1, 4);

                while (sayi1 == sayi2)
                {
                    sayi2 = r.Next(1, 4);
                }

                for (int j = 1; j <= 9; j++)
                {
                    int yedek = sayilar[j, (i - 1) * 3 + sayi2];
                     sayilar[j, (i - 1) * 3 + sayi2] = sayilar[j, (i - 1) * 3 + sayi1];
                     sayilar[j, (i - 1) * 3 + sayi1] = yedek;
                                       
                }

            }
        }

        public void EkranaYaz()    //EkranaYaz fonsiyonu
        {
            int ipucuSayisi, adet = 0;
            Random r = new Random();    // İpucuSayısını random seçiyoruz

            for (int i = 1; i <= 9; i++)
            {
                if (zorluk == "Kolay")
                {
                    ipucuSayisi = r.Next(3, 6);  //Kolay seviye için random 3-4-5 ipucu seçiliyor
                }

                else if (zorluk == "Orta")
                {
                    ipucuSayisi = r.Next(3, 5);  //orta seviye için random 3-4 ipucu seçiliyor
                }
                else
                {
                    ipucuSayisi = r.Next(2, 4);  //Zor seviye için random 2-3 ipucu seçiliyor
                }
               
               
                while (adet < ipucuSayisi)
                {
                    int indeks = r.Next(1, 10);
                    if (kutucuklar[i, indeks].Text == "")
                    {
                        kutucuklar[i, indeks].Text = sayilar[i, indeks].ToString();  // Burada İpucuSayisi adedi kontrol ediliyor                       
                        kutucuklar[i, indeks].ReadOnly = true;

                        adet++; 
                    }
                }
                adet = 0;
            }
        }

        public void SureArttir()    //SureArttir fonksiyounu
        {
            sure++;

        }

        public int SureSoyle()   //SureSoyle fonksiyounu
        {
            return sure;
        }

        public void SureGoster()  //SureGoster fonksiyounu
        {
            aktifForm.dakikaLabel.Text = string.Format("{0:00}", (sure / 60));
            aktifForm.saniyeLabel.Text = string.Format("{0:00}", (sure % 60));
        }

        public void PuanHesapla() //PuanHesapla fonksiyonu
        {
            if (zorluk == "Kolay")
            {
            
                puan = 900 - ((sure / 60) * 30)+doldurulanKutucukSayisi*1; //Kolay seviye için puan hesabı
            }

            else if (zorluk == "Orta")
            {
                puan = 1800 - ((sure / 60) * 30)+doldurulanKutucukSayisi*2; //Orta seviye için puan hesabı

            }

            else if (zorluk == "Zor")
            {
                puan = 2700 - ((sure / 60) * 30 )+ doldurulanKutucukSayisi * 3; //Zor seviye için puan hesabı
            }
        }

        public int PuanSoyle()     //PuanSoyle fonksiyounu
        {
            return puan;
        }

        public void CozumGoster()    // CozumGoster fonksiyonu
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    
                    kutucuklar[i, j].Text = sayilar[i, j].ToString();
                    
                }
            }
            PuanHesapla();
            MessageBox.Show("Oyunun Çözümü" + Environment.NewLine + "Puan : " + puan);
            YeniOyun();
        }

        public void HatalariGoster()    //HatalariGoster fonksiyonu
        {
            int hataSayisi = 0;
            int bosKutucukSayisi = 0;
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    if(kutucuklar[i,j].Text!="" && kutucuklar[i, j].Text != sayilar[i, j].ToString())
                    {
                        Hata hata = new Hata(kutucuklar[i, j]);  //hata Hata sınıfının nesnesi
                        hataSayisi++;
                    }
                    else if (kutucuklar[i, j].Text == "")
                    {
                        bosKutucukSayisi++;
                    }
                }
            }
            if (hataSayisi == 0 && bosKutucukSayisi==0)
            {
                PuanHesapla();
                MessageBox.Show("Tebrikler oyunu tamamladınız. " + Environment.NewLine + "Puan : " + puan);
                YeniOyun();
            }
        }

        

        public void ZorlukAyarla(string ayarlanacakZorluk)    //ZorlukAyarla fonksiyonu
        {
            zorluk = ayarlanacakZorluk;
        }

        public string ZorlukSoyle()      //ZorlukSoyle fonksiyonu
        {
            return zorluk;
        }


        public void YeniOyun()       //YeniOyun fonksiyonu
        {

            Sudoku yeniSudoku = new Sudoku();       // yeniSudoku Sudoku sınıfının nesnesi
            aktifForm.suankiSudoku = yeniSudoku;

        }



    }



}
