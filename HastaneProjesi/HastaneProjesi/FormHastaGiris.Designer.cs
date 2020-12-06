namespace HastaneProjesi
{
    partial class FormHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uyeOlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.girisButton = new System.Windows.Forms.Button();
            this.TCmasked = new System.Windows.Forms.MaskedTextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.geriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // uyeOlLinkLabel
            // 
            this.uyeOlLinkLabel.AutoSize = true;
            this.uyeOlLinkLabel.Location = new System.Drawing.Point(315, 146);
            this.uyeOlLinkLabel.Name = "uyeOlLinkLabel";
            this.uyeOlLinkLabel.Size = new System.Drawing.Size(93, 35);
            this.uyeOlLinkLabel.TabIndex = 4;
            this.uyeOlLinkLabel.TabStop = true;
            this.uyeOlLinkLabel.Text = "Üye Ol";
            this.uyeOlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uyeOlLinkLabel_LinkClicked);
            // 
            // girisButton
            // 
            this.girisButton.Location = new System.Drawing.Point(126, 214);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(172, 45);
            this.girisButton.TabIndex = 3;
            this.girisButton.Text = "Giriş Yap";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // TCmasked
            // 
            this.TCmasked.Location = new System.Drawing.Point(126, 76);
            this.TCmasked.Mask = "00000000000";
            this.TCmasked.Name = "TCmasked";
            this.TCmasked.Size = new System.Drawing.Size(172, 42);
            this.TCmasked.TabIndex = 1;
            this.TCmasked.ValidatingType = typeof(int);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(126, 143);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(172, 42);
            this.sifreTextBox.TabIndex = 2;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // geriButton
            // 
            this.geriButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriButton.BackgroundImage")));
            this.geriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geriButton.Location = new System.Drawing.Point(12, 13);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(53, 45);
            this.geriButton.TabIndex = 19;
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // FormHastaGiris
            // 
            this.AcceptButton = this.girisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(440, 297);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.TCmasked);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.uyeOlLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormHastaGiris";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.FormHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel uyeOlLinkLabel;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.MaskedTextBox TCmasked;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button geriButton;
    }
}