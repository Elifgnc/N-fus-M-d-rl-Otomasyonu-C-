namespace _202503071_nüfus_müdürlüğü_otomosyonu
{
    partial class SifreDegistir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_eskisifre = new System.Windows.Forms.TextBox();
            this.textBox_yenisifre = new System.Windows.Forms.TextBox();
            this.textBox_yenisifreonay = new System.Windows.Forms.TextBox();
            this.textBox_Captcha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Captcha = new System.Windows.Forms.Label();
            this.label_Mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_eskisifre
            // 
            this.textBox_eskisifre.Location = new System.Drawing.Point(313, 50);
            this.textBox_eskisifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_eskisifre.Name = "textBox_eskisifre";
            this.textBox_eskisifre.Size = new System.Drawing.Size(153, 27);
            this.textBox_eskisifre.TabIndex = 0;
            // 
            // textBox_yenisifre
            // 
            this.textBox_yenisifre.Location = new System.Drawing.Point(313, 115);
            this.textBox_yenisifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_yenisifre.Name = "textBox_yenisifre";
            this.textBox_yenisifre.Size = new System.Drawing.Size(153, 27);
            this.textBox_yenisifre.TabIndex = 1;
            // 
            // textBox_yenisifreonay
            // 
            this.textBox_yenisifreonay.Location = new System.Drawing.Point(313, 186);
            this.textBox_yenisifreonay.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_yenisifreonay.Name = "textBox_yenisifreonay";
            this.textBox_yenisifreonay.Size = new System.Drawing.Size(153, 27);
            this.textBox_yenisifreonay.TabIndex = 2;
            // 
            // textBox_Captcha
            // 
            this.textBox_Captcha.Location = new System.Drawing.Point(313, 259);
            this.textBox_Captcha.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Captcha.Name = "textBox_Captcha";
            this.textBox_Captcha.Size = new System.Drawing.Size(153, 27);
            this.textBox_Captcha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(102, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eski Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(102, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(102, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre (Tekrar):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(313, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Captcha
            // 
            this.label_Captcha.AutoSize = true;
            this.label_Captcha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_Captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Captcha.Location = new System.Drawing.Point(101, 258);
            this.label_Captcha.Name = "label_Captcha";
            this.label_Captcha.Size = new System.Drawing.Size(178, 25);
            this.label_Captcha.TabIndex = 8;
            this.label_Captcha.Text = "Yeni Şifre (Tekrar):";
            // 
            // label_Mesaj
            // 
            this.label_Mesaj.AutoSize = true;
            this.label_Mesaj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_Mesaj.Location = new System.Drawing.Point(102, 346);
            this.label_Mesaj.Name = "label_Mesaj";
            this.label_Mesaj.Size = new System.Drawing.Size(53, 20);
            this.label_Mesaj.TabIndex = 9;
            this.label_Mesaj.Text = "label5";
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 420);
            this.Controls.Add(this.label_Mesaj);
            this.Controls.Add(this.label_Captcha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Captcha);
            this.Controls.Add(this.textBox_yenisifreonay);
            this.Controls.Add(this.textBox_yenisifre);
            this.Controls.Add(this.textBox_eskisifre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SifreDegistir";
            this.Text = "Sifre Degistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_eskisifre;
        private System.Windows.Forms.TextBox textBox_yenisifre;
        private System.Windows.Forms.TextBox textBox_yenisifreonay;
        private System.Windows.Forms.TextBox textBox_Captcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Captcha;
        private System.Windows.Forms.Label label_Mesaj;
    }
}