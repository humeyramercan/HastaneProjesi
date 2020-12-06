namespace HastaneProjesi
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.TCmasked = new System.Windows.Forms.MaskedTextBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.geriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(126, 152);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(172, 35);
            this.sifreTextBox.TabIndex = 2;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // TCmasked
            // 
            this.TCmasked.Location = new System.Drawing.Point(126, 85);
            this.TCmasked.Mask = "00000000000";
            this.TCmasked.Name = "TCmasked";
            this.TCmasked.Size = new System.Drawing.Size(172, 35);
            this.TCmasked.TabIndex = 1;
            this.TCmasked.ValidatingType = typeof(int);
            // 
            // girisButton
            // 
            this.girisButton.Location = new System.Drawing.Point(126, 223);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(172, 45);
            this.girisButton.TabIndex = 3;
            this.girisButton.Text = "Giriş Yap";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // geriButton
            // 
            this.geriButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriButton.BackgroundImage")));
            this.geriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geriButton.Location = new System.Drawing.Point(3, 12);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(53, 45);
            this.geriButton.TabIndex = 19;
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.girisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 288);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.TCmasked);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.Text = "Sekreter Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.MaskedTextBox TCmasked;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geriButton;
    }
}