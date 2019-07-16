namespace SudokuYeni
{
    partial class formSudoku
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btnPuan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dakikaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saniyeLabel = new System.Windows.Forms.Label();
            this.zorlukComboBox = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnCozum = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Location = new System.Drawing.Point(397, 18);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(81, 42);
            this.btnYeniOyun.TabIndex = 199;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.ButonClick);
            // 
            // btnPuan
            // 
            this.btnPuan.Location = new System.Drawing.Point(397, 76);
            this.btnPuan.Name = "btnPuan";
            this.btnPuan.Size = new System.Drawing.Size(81, 42);
            this.btnPuan.TabIndex = 201;
            this.btnPuan.Text = "Puan";
            this.btnPuan.UseVisualStyleBackColor = true;
            this.btnPuan.Click += new System.EventHandler(this.ButonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(386, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 202;
            this.label1.Text = "Geçen Zaman ";
            // 
            // dakikaLabel
            // 
            this.dakikaLabel.AutoSize = true;
            this.dakikaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakikaLabel.Location = new System.Drawing.Point(409, 321);
            this.dakikaLabel.Name = "dakikaLabel";
            this.dakikaLabel.Size = new System.Drawing.Size(27, 20);
            this.dakikaLabel.TabIndex = 203;
            this.dakikaLabel.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(435, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 204;
            this.label2.Text = ":";
            // 
            // saniyeLabel
            // 
            this.saniyeLabel.AutoSize = true;
            this.saniyeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniyeLabel.Location = new System.Drawing.Point(451, 321);
            this.saniyeLabel.Name = "saniyeLabel";
            this.saniyeLabel.Size = new System.Drawing.Size(27, 20);
            this.saniyeLabel.TabIndex = 205;
            this.saniyeLabel.Text = "00";
            // 
            // zorlukComboBox
            // 
            this.zorlukComboBox.AccessibleName = "";
            this.zorlukComboBox.FormattingEnabled = true;
            this.zorlukComboBox.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.zorlukComboBox.Location = new System.Drawing.Point(397, 253);
            this.zorlukComboBox.Name = "zorlukComboBox";
            this.zorlukComboBox.Size = new System.Drawing.Size(81, 21);
            this.zorlukComboBox.TabIndex = 206;
            this.zorlukComboBox.Text = "Kolay";
            this.zorlukComboBox.SelectedIndexChanged += new System.EventHandler(this.zorlukComboBox_SelectedIndexChanged);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Window;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox11.Location = new System.Drawing.Point(12, 8);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(30, 30);
            this.textBox11.TabIndex = 0;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox21
            // 
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox21.Location = new System.Drawing.Point(48, 8);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(30, 30);
            this.textBox21.TabIndex = 1;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox21.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox31
            // 
            this.textBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox31.Location = new System.Drawing.Point(83, 9);
            this.textBox31.Multiline = true;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(30, 30);
            this.textBox31.TabIndex = 2;
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox31.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox12.Location = new System.Drawing.Point(12, 44);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(30, 30);
            this.textBox12.TabIndex = 3;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox22.Location = new System.Drawing.Point(48, 44);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(30, 30);
            this.textBox22.TabIndex = 4;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox32
            // 
            this.textBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox32.Location = new System.Drawing.Point(84, 44);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(30, 30);
            this.textBox32.TabIndex = 5;
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox32.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox13.Location = new System.Drawing.Point(12, 80);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(30, 30);
            this.textBox13.TabIndex = 6;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox23
            // 
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox23.Location = new System.Drawing.Point(48, 80);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(30, 30);
            this.textBox23.TabIndex = 7;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox23.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox33
            // 
            this.textBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox33.Location = new System.Drawing.Point(84, 80);
            this.textBox33.Multiline = true;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(30, 30);
            this.textBox33.TabIndex = 8;
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox33.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox102
            // 
            this.textBox102.BackColor = System.Drawing.Color.Black;
            this.textBox102.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox102.Location = new System.Drawing.Point(117, 8);
            this.textBox102.Multiline = true;
            this.textBox102.Name = "textBox102";
            this.textBox102.Size = new System.Drawing.Size(6, 327);
            this.textBox102.TabIndex = 45;
            // 
            // textBox100
            // 
            this.textBox100.BackColor = System.Drawing.Color.Black;
            this.textBox100.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox100.Location = new System.Drawing.Point(11, 112);
            this.textBox100.Multiline = true;
            this.textBox100.Name = "textBox100";
            this.textBox100.Size = new System.Drawing.Size(332, 6);
            this.textBox100.TabIndex = 110;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox14.Location = new System.Drawing.Point(11, 120);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(30, 30);
            this.textBox14.TabIndex = 124;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox24
            // 
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox24.Location = new System.Drawing.Point(47, 120);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(30, 30);
            this.textBox24.TabIndex = 125;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox24.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox34
            // 
            this.textBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox34.Location = new System.Drawing.Point(83, 120);
            this.textBox34.Multiline = true;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(30, 30);
            this.textBox34.TabIndex = 126;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox34.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox15.Location = new System.Drawing.Point(11, 156);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(30, 30);
            this.textBox15.TabIndex = 127;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox15.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox25
            // 
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox25.Location = new System.Drawing.Point(47, 156);
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(30, 30);
            this.textBox25.TabIndex = 128;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox25.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox35
            // 
            this.textBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox35.Location = new System.Drawing.Point(83, 156);
            this.textBox35.Multiline = true;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(30, 30);
            this.textBox35.TabIndex = 129;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox35.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox16.Location = new System.Drawing.Point(11, 192);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(30, 30);
            this.textBox16.TabIndex = 130;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox16.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox26
            // 
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox26.Location = new System.Drawing.Point(47, 192);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(30, 30);
            this.textBox26.TabIndex = 131;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox26.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox36
            // 
            this.textBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox36.Location = new System.Drawing.Point(83, 192);
            this.textBox36.Multiline = true;
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(30, 30);
            this.textBox36.TabIndex = 132;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox36.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox101
            // 
            this.textBox101.BackColor = System.Drawing.Color.Black;
            this.textBox101.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox101.Location = new System.Drawing.Point(12, 225);
            this.textBox101.Multiline = true;
            this.textBox101.Name = "textBox101";
            this.textBox101.Size = new System.Drawing.Size(332, 6);
            this.textBox101.TabIndex = 133;
            // 
            // textBox41
            // 
            this.textBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox41.Location = new System.Drawing.Point(126, 8);
            this.textBox41.Multiline = true;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(30, 30);
            this.textBox41.TabIndex = 134;
            this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox41.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox51
            // 
            this.textBox51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox51.Location = new System.Drawing.Point(162, 8);
            this.textBox51.Multiline = true;
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(30, 30);
            this.textBox51.TabIndex = 135;
            this.textBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox51.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox61
            // 
            this.textBox61.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox61.Location = new System.Drawing.Point(198, 8);
            this.textBox61.Multiline = true;
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(30, 30);
            this.textBox61.TabIndex = 136;
            this.textBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox61.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox42
            // 
            this.textBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox42.Location = new System.Drawing.Point(126, 44);
            this.textBox42.Multiline = true;
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(30, 30);
            this.textBox42.TabIndex = 137;
            this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox42.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox52
            // 
            this.textBox52.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox52.Location = new System.Drawing.Point(162, 44);
            this.textBox52.Multiline = true;
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(30, 30);
            this.textBox52.TabIndex = 138;
            this.textBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox52.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox62
            // 
            this.textBox62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox62.Location = new System.Drawing.Point(198, 44);
            this.textBox62.Multiline = true;
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(30, 30);
            this.textBox62.TabIndex = 139;
            this.textBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox62.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox43
            // 
            this.textBox43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox43.Location = new System.Drawing.Point(126, 80);
            this.textBox43.Multiline = true;
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(30, 30);
            this.textBox43.TabIndex = 140;
            this.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox43.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox53
            // 
            this.textBox53.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox53.Location = new System.Drawing.Point(162, 80);
            this.textBox53.Multiline = true;
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(30, 30);
            this.textBox53.TabIndex = 141;
            this.textBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox53.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox63
            // 
            this.textBox63.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox63.Location = new System.Drawing.Point(198, 80);
            this.textBox63.Multiline = true;
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(30, 30);
            this.textBox63.TabIndex = 142;
            this.textBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox63.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox44
            // 
            this.textBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox44.Location = new System.Drawing.Point(126, 120);
            this.textBox44.Multiline = true;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(30, 30);
            this.textBox44.TabIndex = 143;
            this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox44.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox54
            // 
            this.textBox54.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox54.Location = new System.Drawing.Point(162, 120);
            this.textBox54.Multiline = true;
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(30, 30);
            this.textBox54.TabIndex = 144;
            this.textBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox54.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox64
            // 
            this.textBox64.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox64.Location = new System.Drawing.Point(198, 120);
            this.textBox64.Multiline = true;
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(30, 30);
            this.textBox64.TabIndex = 145;
            this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox64.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox45
            // 
            this.textBox45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox45.Location = new System.Drawing.Point(126, 156);
            this.textBox45.Multiline = true;
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(30, 30);
            this.textBox45.TabIndex = 146;
            this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox45.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox55
            // 
            this.textBox55.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox55.Location = new System.Drawing.Point(162, 156);
            this.textBox55.Multiline = true;
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(30, 30);
            this.textBox55.TabIndex = 147;
            this.textBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox55.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox65
            // 
            this.textBox65.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox65.Location = new System.Drawing.Point(198, 156);
            this.textBox65.Multiline = true;
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(30, 30);
            this.textBox65.TabIndex = 148;
            this.textBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox65.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox46
            // 
            this.textBox46.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox46.Location = new System.Drawing.Point(126, 192);
            this.textBox46.Multiline = true;
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(30, 30);
            this.textBox46.TabIndex = 149;
            this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox46.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox56
            // 
            this.textBox56.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox56.Location = new System.Drawing.Point(162, 192);
            this.textBox56.Multiline = true;
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(30, 30);
            this.textBox56.TabIndex = 150;
            this.textBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox56.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox66
            // 
            this.textBox66.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox66.Location = new System.Drawing.Point(198, 192);
            this.textBox66.Multiline = true;
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(30, 30);
            this.textBox66.TabIndex = 151;
            this.textBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox66.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox103
            // 
            this.textBox103.BackColor = System.Drawing.Color.Black;
            this.textBox103.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox103.Location = new System.Drawing.Point(231, 8);
            this.textBox103.Multiline = true;
            this.textBox103.Name = "textBox103";
            this.textBox103.Size = new System.Drawing.Size(6, 327);
            this.textBox103.TabIndex = 152;
            // 
            // textBox71
            // 
            this.textBox71.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox71.Location = new System.Drawing.Point(240, 8);
            this.textBox71.Multiline = true;
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(30, 30);
            this.textBox71.TabIndex = 153;
            this.textBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox71.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox81
            // 
            this.textBox81.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox81.Location = new System.Drawing.Point(276, 8);
            this.textBox81.Multiline = true;
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(30, 30);
            this.textBox81.TabIndex = 154;
            this.textBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox81.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox91
            // 
            this.textBox91.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox91.Location = new System.Drawing.Point(312, 8);
            this.textBox91.Multiline = true;
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(30, 30);
            this.textBox91.TabIndex = 155;
            this.textBox91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox91.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox72
            // 
            this.textBox72.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox72.Location = new System.Drawing.Point(240, 44);
            this.textBox72.Multiline = true;
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(30, 30);
            this.textBox72.TabIndex = 156;
            this.textBox72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox72.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox82
            // 
            this.textBox82.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox82.Location = new System.Drawing.Point(276, 44);
            this.textBox82.Multiline = true;
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(30, 30);
            this.textBox82.TabIndex = 157;
            this.textBox82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox82.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox92
            // 
            this.textBox92.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox92.Location = new System.Drawing.Point(312, 44);
            this.textBox92.Multiline = true;
            this.textBox92.Name = "textBox92";
            this.textBox92.Size = new System.Drawing.Size(30, 30);
            this.textBox92.TabIndex = 158;
            this.textBox92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox92.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox73
            // 
            this.textBox73.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox73.Location = new System.Drawing.Point(240, 80);
            this.textBox73.Multiline = true;
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(30, 30);
            this.textBox73.TabIndex = 159;
            this.textBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox73.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox83
            // 
            this.textBox83.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox83.Location = new System.Drawing.Point(276, 80);
            this.textBox83.Multiline = true;
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(30, 30);
            this.textBox83.TabIndex = 160;
            this.textBox83.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox83.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox93
            // 
            this.textBox93.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox93.Location = new System.Drawing.Point(312, 80);
            this.textBox93.Multiline = true;
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(30, 30);
            this.textBox93.TabIndex = 161;
            this.textBox93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox93.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox74
            // 
            this.textBox74.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox74.Location = new System.Drawing.Point(240, 120);
            this.textBox74.Multiline = true;
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(30, 30);
            this.textBox74.TabIndex = 162;
            this.textBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox74.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox84
            // 
            this.textBox84.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox84.Location = new System.Drawing.Point(276, 120);
            this.textBox84.Multiline = true;
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(30, 30);
            this.textBox84.TabIndex = 163;
            this.textBox84.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox84.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox94
            // 
            this.textBox94.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox94.Location = new System.Drawing.Point(312, 120);
            this.textBox94.Multiline = true;
            this.textBox94.Name = "textBox94";
            this.textBox94.Size = new System.Drawing.Size(30, 30);
            this.textBox94.TabIndex = 164;
            this.textBox94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox94.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox75
            // 
            this.textBox75.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox75.Location = new System.Drawing.Point(238, 156);
            this.textBox75.Multiline = true;
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(30, 30);
            this.textBox75.TabIndex = 165;
            this.textBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox75.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox85
            // 
            this.textBox85.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox85.Location = new System.Drawing.Point(276, 156);
            this.textBox85.Multiline = true;
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(30, 30);
            this.textBox85.TabIndex = 166;
            this.textBox85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox85.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox95
            // 
            this.textBox95.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox95.Location = new System.Drawing.Point(312, 156);
            this.textBox95.Multiline = true;
            this.textBox95.Name = "textBox95";
            this.textBox95.Size = new System.Drawing.Size(30, 30);
            this.textBox95.TabIndex = 167;
            this.textBox95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox95.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox76
            // 
            this.textBox76.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox76.Location = new System.Drawing.Point(240, 192);
            this.textBox76.Multiline = true;
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(30, 30);
            this.textBox76.TabIndex = 168;
            this.textBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox76.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox86
            // 
            this.textBox86.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox86.Location = new System.Drawing.Point(276, 192);
            this.textBox86.Multiline = true;
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(30, 30);
            this.textBox86.TabIndex = 169;
            this.textBox86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox86.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox96
            // 
            this.textBox96.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox96.Location = new System.Drawing.Point(312, 192);
            this.textBox96.Multiline = true;
            this.textBox96.Name = "textBox96";
            this.textBox96.Size = new System.Drawing.Size(30, 30);
            this.textBox96.TabIndex = 170;
            this.textBox96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox96.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox77
            // 
            this.textBox77.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox77.Location = new System.Drawing.Point(240, 233);
            this.textBox77.Multiline = true;
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(30, 30);
            this.textBox77.TabIndex = 171;
            this.textBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox77.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox87
            // 
            this.textBox87.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox87.Location = new System.Drawing.Point(276, 233);
            this.textBox87.Multiline = true;
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(30, 30);
            this.textBox87.TabIndex = 172;
            this.textBox87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox87.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox97
            // 
            this.textBox97.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox97.Location = new System.Drawing.Point(312, 233);
            this.textBox97.Multiline = true;
            this.textBox97.Name = "textBox97";
            this.textBox97.Size = new System.Drawing.Size(30, 30);
            this.textBox97.TabIndex = 173;
            this.textBox97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox97.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox78
            // 
            this.textBox78.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox78.Location = new System.Drawing.Point(240, 269);
            this.textBox78.Multiline = true;
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(30, 30);
            this.textBox78.TabIndex = 174;
            this.textBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox78.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox88
            // 
            this.textBox88.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox88.Location = new System.Drawing.Point(276, 269);
            this.textBox88.Multiline = true;
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(30, 30);
            this.textBox88.TabIndex = 175;
            this.textBox88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox88.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox98
            // 
            this.textBox98.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox98.Location = new System.Drawing.Point(312, 269);
            this.textBox98.Multiline = true;
            this.textBox98.Name = "textBox98";
            this.textBox98.Size = new System.Drawing.Size(30, 30);
            this.textBox98.TabIndex = 176;
            this.textBox98.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox98.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox79
            // 
            this.textBox79.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox79.Location = new System.Drawing.Point(240, 305);
            this.textBox79.Multiline = true;
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(30, 30);
            this.textBox79.TabIndex = 177;
            this.textBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox79.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox89
            // 
            this.textBox89.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox89.Location = new System.Drawing.Point(276, 305);
            this.textBox89.Multiline = true;
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(30, 30);
            this.textBox89.TabIndex = 178;
            this.textBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox89.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox99
            // 
            this.textBox99.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox99.Location = new System.Drawing.Point(312, 305);
            this.textBox99.Multiline = true;
            this.textBox99.Name = "textBox99";
            this.textBox99.Size = new System.Drawing.Size(30, 30);
            this.textBox99.TabIndex = 179;
            this.textBox99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox99.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox47
            // 
            this.textBox47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox47.Location = new System.Drawing.Point(126, 233);
            this.textBox47.Multiline = true;
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(30, 30);
            this.textBox47.TabIndex = 180;
            this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox47.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox57
            // 
            this.textBox57.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox57.Location = new System.Drawing.Point(162, 233);
            this.textBox57.Multiline = true;
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(30, 30);
            this.textBox57.TabIndex = 181;
            this.textBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox57.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox67
            // 
            this.textBox67.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox67.Location = new System.Drawing.Point(198, 233);
            this.textBox67.Multiline = true;
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(30, 30);
            this.textBox67.TabIndex = 182;
            this.textBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox67.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox48
            // 
            this.textBox48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox48.Location = new System.Drawing.Point(126, 269);
            this.textBox48.Multiline = true;
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(30, 30);
            this.textBox48.TabIndex = 183;
            this.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox48.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox58
            // 
            this.textBox58.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox58.Location = new System.Drawing.Point(162, 269);
            this.textBox58.Multiline = true;
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(30, 30);
            this.textBox58.TabIndex = 184;
            this.textBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox58.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox68
            // 
            this.textBox68.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox68.Location = new System.Drawing.Point(198, 269);
            this.textBox68.Multiline = true;
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(30, 30);
            this.textBox68.TabIndex = 185;
            this.textBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox68.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox49
            // 
            this.textBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox49.Location = new System.Drawing.Point(126, 305);
            this.textBox49.Multiline = true;
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(30, 30);
            this.textBox49.TabIndex = 186;
            this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox49.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox59
            // 
            this.textBox59.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox59.Location = new System.Drawing.Point(162, 305);
            this.textBox59.Multiline = true;
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(30, 30);
            this.textBox59.TabIndex = 187;
            this.textBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox59.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox69
            // 
            this.textBox69.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox69.Location = new System.Drawing.Point(198, 305);
            this.textBox69.Multiline = true;
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(30, 30);
            this.textBox69.TabIndex = 188;
            this.textBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox69.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox17.Location = new System.Drawing.Point(12, 233);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(30, 30);
            this.textBox17.TabIndex = 189;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox17.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox27
            // 
            this.textBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox27.Location = new System.Drawing.Point(48, 233);
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(30, 30);
            this.textBox27.TabIndex = 190;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox27.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox37
            // 
            this.textBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox37.Location = new System.Drawing.Point(84, 233);
            this.textBox37.Multiline = true;
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(30, 30);
            this.textBox37.TabIndex = 191;
            this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox37.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox18.Location = new System.Drawing.Point(12, 269);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(30, 30);
            this.textBox18.TabIndex = 192;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox18.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox28
            // 
            this.textBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox28.Location = new System.Drawing.Point(48, 269);
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(30, 30);
            this.textBox28.TabIndex = 193;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox28.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox38
            // 
            this.textBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox38.Location = new System.Drawing.Point(84, 269);
            this.textBox38.Multiline = true;
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(30, 30);
            this.textBox38.TabIndex = 194;
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox38.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox19.Location = new System.Drawing.Point(12, 305);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(30, 30);
            this.textBox19.TabIndex = 195;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox19.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox29
            // 
            this.textBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox29.Location = new System.Drawing.Point(48, 305);
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(30, 30);
            this.textBox29.TabIndex = 196;
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox29.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // textBox39
            // 
            this.textBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox39.Location = new System.Drawing.Point(84, 305);
            this.textBox39.Multiline = true;
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(30, 30);
            this.textBox39.TabIndex = 197;
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox39.TextChanged += new System.EventHandler(this.SayiGirisi);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorTimer
            // 
            this.errorTimer.Interval = 1000;
            // 
            // btnCozum
            // 
            this.btnCozum.Location = new System.Drawing.Point(397, 133);
            this.btnCozum.Name = "btnCozum";
            this.btnCozum.Size = new System.Drawing.Size(81, 42);
            this.btnCozum.TabIndex = 207;
            this.btnCozum.Text = "Çözümü Göster";
            this.btnCozum.UseVisualStyleBackColor = true;
            this.btnCozum.Click += new System.EventHandler(this.ButonClick);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(397, 188);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(81, 42);
            this.btnKontrol.TabIndex = 208;
            this.btnKontrol.Text = "Hataları Göster";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.ButonClick);
            // 
            // formSudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 354);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnCozum);
            this.Controls.Add(this.textBox39);
            this.Controls.Add(this.zorlukComboBox);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.saniyeLabel);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox38);
            this.Controls.Add(this.dakikaLabel);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.btnPuan);
            this.Controls.Add(this.textBox37);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox98);
            this.Controls.Add(this.textBox69);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox59);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox49);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox68);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox58);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox48);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox67);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox57);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox47);
            this.Controls.Add(this.textBox33);
            this.Controls.Add(this.textBox99);
            this.Controls.Add(this.textBox102);
            this.Controls.Add(this.textBox89);
            this.Controls.Add(this.textBox100);
            this.Controls.Add(this.textBox79);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox88);
            this.Controls.Add(this.textBox34);
            this.Controls.Add(this.textBox78);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox97);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox87);
            this.Controls.Add(this.textBox35);
            this.Controls.Add(this.textBox77);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox96);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox86);
            this.Controls.Add(this.textBox36);
            this.Controls.Add(this.textBox76);
            this.Controls.Add(this.textBox101);
            this.Controls.Add(this.textBox95);
            this.Controls.Add(this.textBox41);
            this.Controls.Add(this.textBox85);
            this.Controls.Add(this.textBox51);
            this.Controls.Add(this.textBox75);
            this.Controls.Add(this.textBox61);
            this.Controls.Add(this.textBox94);
            this.Controls.Add(this.textBox42);
            this.Controls.Add(this.textBox84);
            this.Controls.Add(this.textBox52);
            this.Controls.Add(this.textBox74);
            this.Controls.Add(this.textBox62);
            this.Controls.Add(this.textBox93);
            this.Controls.Add(this.textBox43);
            this.Controls.Add(this.textBox83);
            this.Controls.Add(this.textBox53);
            this.Controls.Add(this.textBox73);
            this.Controls.Add(this.textBox63);
            this.Controls.Add(this.textBox92);
            this.Controls.Add(this.textBox44);
            this.Controls.Add(this.textBox82);
            this.Controls.Add(this.textBox54);
            this.Controls.Add(this.textBox72);
            this.Controls.Add(this.textBox64);
            this.Controls.Add(this.textBox91);
            this.Controls.Add(this.textBox45);
            this.Controls.Add(this.textBox81);
            this.Controls.Add(this.textBox55);
            this.Controls.Add(this.textBox71);
            this.Controls.Add(this.textBox65);
            this.Controls.Add(this.textBox103);
            this.Controls.Add(this.textBox46);
            this.Controls.Add(this.textBox66);
            this.Controls.Add(this.textBox56);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formSudoku";
            this.Text = "Sudoku";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox zorlukComboBox;
        public System.Windows.Forms.Button btnYeniOyun;
        public System.Windows.Forms.Button btnPuan;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label dakikaLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label saniyeLabel;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox102;
        private System.Windows.Forms.TextBox textBox100;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox101;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox103;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.TextBox textBox81;
        private System.Windows.Forms.TextBox textBox91;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.TextBox textBox82;
        private System.Windows.Forms.TextBox textBox92;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.TextBox textBox83;
        private System.Windows.Forms.TextBox textBox93;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox84;
        private System.Windows.Forms.TextBox textBox94;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.TextBox textBox85;
        private System.Windows.Forms.TextBox textBox95;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox86;
        private System.Windows.Forms.TextBox textBox96;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox87;
        private System.Windows.Forms.TextBox textBox97;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.TextBox textBox88;
        private System.Windows.Forms.TextBox textBox98;
        private System.Windows.Forms.TextBox textBox79;
        private System.Windows.Forms.TextBox textBox89;
        private System.Windows.Forms.TextBox textBox99;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer errorTimer;
        public System.Windows.Forms.Button btnCozum;
        private System.Windows.Forms.TextBox textBox11;
        public System.Windows.Forms.Button btnKontrol;
    }
}

