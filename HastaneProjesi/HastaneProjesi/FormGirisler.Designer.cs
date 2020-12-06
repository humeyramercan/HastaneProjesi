namespace HastaneProjesi
{
    partial class FormGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisler));
            this.hastaGirisiButton = new System.Windows.Forms.Button();
            this.doktorGirisiButton = new System.Windows.Forms.Button();
            this.sekreterGirisiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaGirisiButton
            // 
            this.hastaGirisiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hastaGirisiButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hastaGirisiButton.BackgroundImage")));
            this.hastaGirisiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hastaGirisiButton.Location = new System.Drawing.Point(59, 172);
            this.hastaGirisiButton.Margin = new System.Windows.Forms.Padding(4);
            this.hastaGirisiButton.Name = "hastaGirisiButton";
            this.hastaGirisiButton.Size = new System.Drawing.Size(156, 170);
            this.hastaGirisiButton.TabIndex = 1;
            this.hastaGirisiButton.UseVisualStyleBackColor = true;
            this.hastaGirisiButton.Click += new System.EventHandler(this.hastaGirisiButton_Click);
            // 
            // doktorGirisiButton
            // 
            this.doktorGirisiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doktorGirisiButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doktorGirisiButton.BackgroundImage")));
            this.doktorGirisiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doktorGirisiButton.Location = new System.Drawing.Point(223, 172);
            this.doktorGirisiButton.Margin = new System.Windows.Forms.Padding(4);
            this.doktorGirisiButton.Name = "doktorGirisiButton";
            this.doktorGirisiButton.Size = new System.Drawing.Size(156, 170);
            this.doktorGirisiButton.TabIndex = 2;
            this.doktorGirisiButton.UseVisualStyleBackColor = true;
            this.doktorGirisiButton.Click += new System.EventHandler(this.doktorGirisiButton_Click);
            // 
            // sekreterGirisiButton
            // 
            this.sekreterGirisiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sekreterGirisiButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sekreterGirisiButton.BackgroundImage")));
            this.sekreterGirisiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sekreterGirisiButton.Location = new System.Drawing.Point(387, 172);
            this.sekreterGirisiButton.Margin = new System.Windows.Forms.Padding(4);
            this.sekreterGirisiButton.Name = "sekreterGirisiButton";
            this.sekreterGirisiButton.Size = new System.Drawing.Size(156, 170);
            this.sekreterGirisiButton.TabIndex = 3;
            this.sekreterGirisiButton.UseVisualStyleBackColor = true;
            this.sekreterGirisiButton.Click += new System.EventHandler(this.sekreterGirisiButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(259, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(423, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(89, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 66);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hoşgeldiniz...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sekreterGirisiButton);
            this.Controls.Add(this.doktorGirisiButton);
            this.Controls.Add(this.hastaGirisiButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(532, 417);
            this.Name = "FormGirisler";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Giriş Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hastaGirisiButton;
        private System.Windows.Forms.Button doktorGirisiButton;
        private System.Windows.Forms.Button sekreterGirisiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

