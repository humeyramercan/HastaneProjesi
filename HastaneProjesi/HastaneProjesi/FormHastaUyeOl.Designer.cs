namespace HastaneProjesi
{
    partial class FormHastaUyeOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaUyeOl));
            this.TCmasked = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonMasked = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cinsiyetComboBox = new System.Windows.Forms.ComboBox();
            this.uyeOlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TCmasked
            // 
            this.TCmasked.Location = new System.Drawing.Point(208, 153);
            this.TCmasked.Mask = "00000000000";
            this.TCmasked.Name = "TCmasked";
            this.TCmasked.Size = new System.Drawing.Size(186, 42);
            this.TCmasked.TabIndex = 3;
            this.TCmasked.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No:";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(208, 300);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(186, 42);
            this.sifreTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Şifre:";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(208, 92);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(186, 42);
            this.soyadTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Soyad:";
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(208, 31);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(186, 42);
            this.adTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ad:";
            // 
            // telefonMasked
            // 
            this.telefonMasked.Location = new System.Drawing.Point(208, 233);
            this.telefonMasked.Mask = "(999) 000-0000";
            this.telefonMasked.Name = "telefonMasked";
            this.telefonMasked.Size = new System.Drawing.Size(186, 42);
            this.telefonMasked.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 35);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cinsiyet:";
            // 
            // cinsiyetComboBox
            // 
            this.cinsiyetComboBox.FormattingEnabled = true;
            this.cinsiyetComboBox.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cinsiyetComboBox.Location = new System.Drawing.Point(208, 369);
            this.cinsiyetComboBox.Name = "cinsiyetComboBox";
            this.cinsiyetComboBox.Size = new System.Drawing.Size(186, 43);
            this.cinsiyetComboBox.TabIndex = 7;
            // 
            // uyeOlButton
            // 
            this.uyeOlButton.Location = new System.Drawing.Point(208, 439);
            this.uyeOlButton.Name = "uyeOlButton";
            this.uyeOlButton.Size = new System.Drawing.Size(186, 50);
            this.uyeOlButton.TabIndex = 7;
            this.uyeOlButton.Text = "Üye Ol";
            this.uyeOlButton.UseVisualStyleBackColor = true;
            this.uyeOlButton.Click += new System.EventHandler(this.uyeOlButton_Click);
            // 
            // FormHastaUyeOl
            // 
            this.AcceptButton = this.uyeOlButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(522, 534);
            this.Controls.Add(this.uyeOlButton);
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
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormHastaUyeOl";
            this.Text = "Üye Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TCmasked;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox telefonMasked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cinsiyetComboBox;
        private System.Windows.Forms.Button uyeOlButton;
    }
}