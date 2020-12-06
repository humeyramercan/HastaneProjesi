namespace HastaneProjesi
{
    partial class FrmHastaBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiDuzenle));
            this.bilgileriGuncelleButton = new System.Windows.Forms.Button();
            this.cinsiyetComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonMasked = new System.Windows.Forms.MaskedTextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TCmasked = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bilgileriGuncelleButton
            // 
            this.bilgileriGuncelleButton.Location = new System.Drawing.Point(200, 417);
            this.bilgileriGuncelleButton.Name = "bilgileriGuncelleButton";
            this.bilgileriGuncelleButton.Size = new System.Drawing.Size(186, 50);
            this.bilgileriGuncelleButton.TabIndex = 7;
            this.bilgileriGuncelleButton.Text = "Güncelle";
            this.bilgileriGuncelleButton.UseVisualStyleBackColor = true;
            this.bilgileriGuncelleButton.Click += new System.EventHandler(this.bilgileriGuncelleButton_Click);
            // 
            // cinsiyetComboBox
            // 
            this.cinsiyetComboBox.FormattingEnabled = true;
            this.cinsiyetComboBox.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cinsiyetComboBox.Location = new System.Drawing.Point(200, 350);
            this.cinsiyetComboBox.Name = "cinsiyetComboBox";
            this.cinsiyetComboBox.Size = new System.Drawing.Size(186, 40);
            this.cinsiyetComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 32);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cinsiyet:";
            // 
            // telefonMasked
            // 
            this.telefonMasked.Location = new System.Drawing.Point(200, 214);
            this.telefonMasked.Mask = "(999) 000-0000";
            this.telefonMasked.Name = "telefonMasked";
            this.telefonMasked.Size = new System.Drawing.Size(186, 39);
            this.telefonMasked.TabIndex = 4;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(200, 12);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(186, 39);
            this.adTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ad:";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(200, 73);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(186, 39);
            this.soyadTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Soyad:";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(200, 281);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(186, 39);
            this.sifreTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Şifre:";
            // 
            // TCmasked
            // 
            this.TCmasked.Location = new System.Drawing.Point(200, 134);
            this.TCmasked.Mask = "00000000000";
            this.TCmasked.Name = "TCmasked";
            this.TCmasked.Size = new System.Drawing.Size(186, 39);
            this.TCmasked.TabIndex = 3;
            this.TCmasked.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Telefon No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmHastaBilgiDuzenle
            // 
            this.AcceptButton = this.bilgileriGuncelleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(542, 497);
            this.Controls.Add(this.bilgileriGuncelleButton);
            this.Controls.Add(this.cinsiyetComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefonMasked);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCmasked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBilgiDuzenle";
            this.Text = "Hasta Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmHastaBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bilgileriGuncelleButton;
        private System.Windows.Forms.ComboBox cinsiyetComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox telefonMasked;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TCmasked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}