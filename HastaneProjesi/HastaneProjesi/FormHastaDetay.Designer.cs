namespace HastaneProjesi
{
    partial class FormHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adSoyadLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saatMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tarihMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bilgiDüzenleLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.doktorComboBox = new System.Windows.Forms.ComboBox();
            this.randevuAlButton = new System.Windows.Forms.Button();
            this.sikayetRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bransComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.randevuGecmisiDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.alinabilecekRandevularDataGrid = new System.Windows.Forms.DataGridView();
            this.mesajLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevuGecmisiDataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alinabilecekRandevularDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adSoyadLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tcLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.Location = new System.Drawing.Point(130, 99);
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(29, 35);
            this.adSoyadLabel.TabIndex = 5;
            this.adSoyadLabel.Text = "..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ad Soyad:";
            // 
            // tcLabel
            // 
            this.tcLabel.AutoSize = true;
            this.tcLabel.Location = new System.Drawing.Point(130, 48);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(169, 35);
            this.tcLabel.TabIndex = 2;
            this.tcLabel.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saatMaskedTextBox);
            this.groupBox2.Controls.Add(this.tarihMaskedTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bilgiDüzenleLink);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.doktorComboBox);
            this.groupBox2.Controls.Add(this.randevuAlButton);
            this.groupBox2.Controls.Add(this.sikayetRichTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bransComboBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu";
            // 
            // saatMaskedTextBox
            // 
            this.saatMaskedTextBox.Enabled = false;
            this.saatMaskedTextBox.Location = new System.Drawing.Point(119, 197);
            this.saatMaskedTextBox.Mask = "00:00";
            this.saatMaskedTextBox.Name = "saatMaskedTextBox";
            this.saatMaskedTextBox.Size = new System.Drawing.Size(230, 42);
            this.saatMaskedTextBox.TabIndex = 19;
            this.saatMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // tarihMaskedTextBox
            // 
            this.tarihMaskedTextBox.Enabled = false;
            this.tarihMaskedTextBox.Location = new System.Drawing.Point(119, 149);
            this.tarihMaskedTextBox.Mask = "00/00/0000";
            this.tarihMaskedTextBox.Name = "tarihMaskedTextBox";
            this.tarihMaskedTextBox.Size = new System.Drawing.Size(230, 42);
            this.tarihMaskedTextBox.TabIndex = 18;
            this.tarihMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "Saat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tarih:";
            // 
            // bilgiDüzenleLink
            // 
            this.bilgiDüzenleLink.AutoSize = true;
            this.bilgiDüzenleLink.Location = new System.Drawing.Point(123, 457);
            this.bilgiDüzenleLink.Name = "bilgiDüzenleLink";
            this.bilgiDüzenleLink.Size = new System.Drawing.Size(229, 35);
            this.bilgiDüzenleLink.TabIndex = 6;
            this.bilgiDüzenleLink.TabStop = true;
            this.bilgiDüzenleLink.Text = "Bilgilerini Düzenle";
            this.bilgiDüzenleLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bilgiDüzenleLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şikayet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doktor:";
            // 
            // doktorComboBox
            // 
            this.doktorComboBox.FormattingEnabled = true;
            this.doktorComboBox.Location = new System.Drawing.Point(119, 100);
            this.doktorComboBox.Name = "doktorComboBox";
            this.doktorComboBox.Size = new System.Drawing.Size(230, 43);
            this.doktorComboBox.TabIndex = 3;
            this.doktorComboBox.SelectedIndexChanged += new System.EventHandler(this.doktorComboBox_SelectedIndexChanged);
            // 
            // randevuAlButton
            // 
            this.randevuAlButton.Location = new System.Drawing.Point(114, 399);
            this.randevuAlButton.Name = "randevuAlButton";
            this.randevuAlButton.Size = new System.Drawing.Size(238, 41);
            this.randevuAlButton.TabIndex = 5;
            this.randevuAlButton.Text = "Randevu Al";
            this.randevuAlButton.UseVisualStyleBackColor = true;
            this.randevuAlButton.Click += new System.EventHandler(this.randevuAlButton_Click);
            // 
            // sikayetRichTextBox
            // 
            this.sikayetRichTextBox.Location = new System.Drawing.Point(119, 245);
            this.sikayetRichTextBox.Name = "sikayetRichTextBox";
            this.sikayetRichTextBox.Size = new System.Drawing.Size(293, 131);
            this.sikayetRichTextBox.TabIndex = 4;
            this.sikayetRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Branş:";
            // 
            // bransComboBox
            // 
            this.bransComboBox.FormattingEnabled = true;
            this.bransComboBox.Location = new System.Drawing.Point(119, 51);
            this.bransComboBox.Name = "bransComboBox";
            this.bransComboBox.Size = new System.Drawing.Size(230, 43);
            this.bransComboBox.TabIndex = 2;
            this.bransComboBox.SelectedIndexChanged += new System.EventHandler(this.bransComboBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.randevuGecmisiDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(455, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 268);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // randevuGecmisiDataGrid
            // 
            this.randevuGecmisiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuGecmisiDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randevuGecmisiDataGrid.Location = new System.Drawing.Point(3, 38);
            this.randevuGecmisiDataGrid.Name = "randevuGecmisiDataGrid";
            this.randevuGecmisiDataGrid.RowHeadersWidth = 62;
            this.randevuGecmisiDataGrid.RowTemplate.Height = 28;
            this.randevuGecmisiDataGrid.Size = new System.Drawing.Size(669, 227);
            this.randevuGecmisiDataGrid.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.alinabilecekRandevularDataGrid);
            this.groupBox4.Location = new System.Drawing.Point(455, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(678, 337);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alınabilecek Randevular";
            // 
            // alinabilecekRandevularDataGrid
            // 
            this.alinabilecekRandevularDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alinabilecekRandevularDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alinabilecekRandevularDataGrid.Location = new System.Drawing.Point(3, 38);
            this.alinabilecekRandevularDataGrid.Name = "alinabilecekRandevularDataGrid";
            this.alinabilecekRandevularDataGrid.RowHeadersWidth = 62;
            this.alinabilecekRandevularDataGrid.RowTemplate.Height = 28;
            this.alinabilecekRandevularDataGrid.Size = new System.Drawing.Size(672, 296);
            this.alinabilecekRandevularDataGrid.TabIndex = 0;
            this.alinabilecekRandevularDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alinabilecekRandevularDataGrid_CellDoubleClick);
            // 
            // mesajLabel
            // 
            this.mesajLabel.AutoSize = true;
            this.mesajLabel.Location = new System.Drawing.Point(467, 298);
            this.mesajLabel.Name = "mesajLabel";
            this.mesajLabel.Size = new System.Drawing.Size(648, 35);
            this.mesajLabel.TabIndex = 5;
            this.mesajLabel.Text = "Lütfen almak istediğiniz randevunun üstüne tıklayınız.";
            this.mesajLabel.Visible = false;
            // 
            // FormHastaDetay
            // 
            this.AcceptButton = this.randevuAlButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1156, 710);
            this.Controls.Add(this.mesajLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FormHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.randevuGecmisiDataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alinabilecekRandevularDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tcLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button randevuAlButton;
        private System.Windows.Forms.RichTextBox sikayetRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bransComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox doktorComboBox;
        private System.Windows.Forms.Label adSoyadLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView randevuGecmisiDataGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView alinabilecekRandevularDataGrid;
        private System.Windows.Forms.LinkLabel bilgiDüzenleLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox saatMaskedTextBox;
        public System.Windows.Forms.MaskedTextBox tarihMaskedTextBox;
        private System.Windows.Forms.Label mesajLabel;
    }
}