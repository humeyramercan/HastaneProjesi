namespace HastaneProjesi
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.bilgileriGuncelleButton = new System.Windows.Forms.Button();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TCmasked = new System.Windows.Forms.MaskedTextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.bransComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bilgileriGuncelleButton
            // 
            this.bilgileriGuncelleButton.Location = new System.Drawing.Point(206, 306);
            this.bilgileriGuncelleButton.Name = "bilgileriGuncelleButton";
            this.bilgileriGuncelleButton.Size = new System.Drawing.Size(186, 50);
            this.bilgileriGuncelleButton.TabIndex = 6;
            this.bilgileriGuncelleButton.Text = "Güncelle";
            this.bilgileriGuncelleButton.UseVisualStyleBackColor = true;
            this.bilgileriGuncelleButton.Click += new System.EventHandler(this.bilgileriGuncelleButton_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(206, 26);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(186, 35);
            this.adTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ad:";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(206, 87);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(186, 35);
            this.soyadTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Branş:";
            // 
            // TCmasked
            // 
            this.TCmasked.Enabled = false;
            this.TCmasked.Location = new System.Drawing.Point(206, 148);
            this.TCmasked.Name = "TCmasked";
            this.TCmasked.Size = new System.Drawing.Size(186, 35);
            this.TCmasked.TabIndex = 3;
            this.TCmasked.ValidatingType = typeof(int);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(206, 256);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(186, 35);
            this.sifreTextBox.TabIndex = 5;
            // 
            // bransComboBox
            // 
            this.bransComboBox.FormattingEnabled = true;
            this.bransComboBox.Location = new System.Drawing.Point(206, 201);
            this.bransComboBox.Name = "bransComboBox";
            this.bransComboBox.Size = new System.Drawing.Size(186, 37);
            this.bransComboBox.TabIndex = 4;
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AcceptButton = this.bilgileriGuncelleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(546, 396);
            this.Controls.Add(this.bransComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bilgileriGuncelleButton);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCmasked);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bilgileriGuncelleButton;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TCmasked;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.ComboBox bransComboBox;
    }
}