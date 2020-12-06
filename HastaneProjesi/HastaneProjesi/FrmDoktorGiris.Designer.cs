namespace HastaneProjesi
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
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
            this.sifreTextBox.Location = new System.Drawing.Point(138, 129);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(303, 39);
            this.sifreTextBox.TabIndex = 2;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // TCmasked
            // 
            this.TCmasked.Location = new System.Drawing.Point(138, 80);
            this.TCmasked.Margin = new System.Windows.Forms.Padding(5);
            this.TCmasked.Mask = "00000000000";
            this.TCmasked.Name = "TCmasked";
            this.TCmasked.Size = new System.Drawing.Size(303, 39);
            this.TCmasked.TabIndex = 1;
            this.TCmasked.ValidatingType = typeof(int);
            // 
            // girisButton
            // 
            this.girisButton.Location = new System.Drawing.Point(161, 195);
            this.girisButton.Margin = new System.Windows.Forms.Padding(5);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(255, 50);
            this.girisButton.TabIndex = 3;
            this.girisButton.Text = "Giriş Yap";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "TC No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 49);
            this.label1.TabIndex = 15;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // geriButton
            // 
            this.geriButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriButton.BackgroundImage")));
            this.geriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geriButton.Location = new System.Drawing.Point(13, 13);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(53, 45);
            this.geriButton.TabIndex = 18;
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.girisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 275);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.TCmasked);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGiris";
            this.Text = "Doktor Giriş";
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