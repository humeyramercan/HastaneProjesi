namespace HastaneProjesi
{
    partial class FrmRandevuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.doktorComboBox = new System.Windows.Forms.ComboBox();
            this.bransComboBox = new System.Windows.Forms.ComboBox();
            this.saatMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tarihMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevular";
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(747, 430);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(196, 38);
            this.guncelleButton.TabIndex = 21;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // doktorComboBox
            // 
            this.doktorComboBox.FormattingEnabled = true;
            this.doktorComboBox.Location = new System.Drawing.Point(477, 474);
            this.doktorComboBox.Name = "doktorComboBox";
            this.doktorComboBox.Size = new System.Drawing.Size(196, 37);
            this.doktorComboBox.TabIndex = 19;
            // 
            // bransComboBox
            // 
            this.bransComboBox.FormattingEnabled = true;
            this.bransComboBox.Location = new System.Drawing.Point(477, 431);
            this.bransComboBox.Name = "bransComboBox";
            this.bransComboBox.Size = new System.Drawing.Size(196, 37);
            this.bransComboBox.TabIndex = 17;
            // 
            // saatMaskedTextBox
            // 
            this.saatMaskedTextBox.Location = new System.Drawing.Point(172, 477);
            this.saatMaskedTextBox.Mask = "00:00";
            this.saatMaskedTextBox.Name = "saatMaskedTextBox";
            this.saatMaskedTextBox.Size = new System.Drawing.Size(196, 35);
            this.saatMaskedTextBox.TabIndex = 15;
            this.saatMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // tarihMaskedTextBox
            // 
            this.tarihMaskedTextBox.Location = new System.Drawing.Point(172, 436);
            this.tarihMaskedTextBox.Mask = "00/00/0000";
            this.tarihMaskedTextBox.Name = "tarihMaskedTextBox";
            this.tarihMaskedTextBox.Size = new System.Drawing.Size(196, 35);
            this.tarihMaskedTextBox.TabIndex = 13;
            this.tarihMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tarih:";
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(747, 484);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(196, 38);
            this.silButton.TabIndex = 22;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1070, 556);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.doktorComboBox);
            this.Controls.Add(this.bransComboBox);
            this.Controls.Add(this.saatMaskedTextBox);
            this.Controls.Add(this.tarihMaskedTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmRandevuListesi";
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button guncelleButton;
        public System.Windows.Forms.ComboBox doktorComboBox;
        public System.Windows.Forms.ComboBox bransComboBox;
        public System.Windows.Forms.MaskedTextBox saatMaskedTextBox;
        public System.Windows.Forms.MaskedTextBox tarihMaskedTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button silButton;
    }
}