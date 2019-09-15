namespace Sinema
{
    partial class biletDegisiklikForm
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
            this.kadSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biletSil = new System.Windows.Forms.Button();
            this.mAd = new System.Windows.Forms.TextBox();
            this.mSoyad = new System.Windows.Forms.TextBox();
            this.rezerveSil = new System.Windows.Forms.Button();
            this.biletListele = new System.Windows.Forms.Button();
            this.rezerveSat = new System.Windows.Forms.Button();
            this.odemeComb = new System.Windows.Forms.ComboBox();
            this.ucretComb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rezervesonsat = new System.Windows.Forms.Button();
            this.don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kadSoyad
            // 
            this.kadSoyad.AutoSize = true;
            this.kadSoyad.Location = new System.Drawing.Point(13, 13);
            this.kadSoyad.Name = "kadSoyad";
            this.kadSoyad.Size = new System.Drawing.Size(19, 13);
            this.kadSoyad.TabIndex = 0;
            this.kadSoyad.Text = "ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "seyirci ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "seyirci soyad :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(719, 304);
            this.dataGridView1.TabIndex = 3;
            // 
            // biletSil
            // 
            this.biletSil.Location = new System.Drawing.Point(26, 147);
            this.biletSil.Name = "biletSil";
            this.biletSil.Size = new System.Drawing.Size(176, 23);
            this.biletSil.TabIndex = 4;
            this.biletSil.Text = "bilet iptal  et";
            this.biletSil.UseVisualStyleBackColor = true;
            this.biletSil.Visible = false;
            this.biletSil.Click += new System.EventHandler(this.biletSil_Click);
            // 
            // mAd
            // 
            this.mAd.Location = new System.Drawing.Point(102, 41);
            this.mAd.Name = "mAd";
            this.mAd.Size = new System.Drawing.Size(100, 20);
            this.mAd.TabIndex = 5;
            // 
            // mSoyad
            // 
            this.mSoyad.Location = new System.Drawing.Point(102, 67);
            this.mSoyad.Name = "mSoyad";
            this.mSoyad.Size = new System.Drawing.Size(100, 20);
            this.mSoyad.TabIndex = 6;
            // 
            // rezerveSil
            // 
            this.rezerveSil.Location = new System.Drawing.Point(26, 190);
            this.rezerveSil.Name = "rezerveSil";
            this.rezerveSil.Size = new System.Drawing.Size(176, 23);
            this.rezerveSil.TabIndex = 7;
            this.rezerveSil.Text = "rezerve iptal et";
            this.rezerveSil.UseVisualStyleBackColor = true;
            this.rezerveSil.Visible = false;
            this.rezerveSil.Click += new System.EventHandler(this.rezerveSil_Click);
            // 
            // biletListele
            // 
            this.biletListele.Location = new System.Drawing.Point(26, 106);
            this.biletListele.Name = "biletListele";
            this.biletListele.Size = new System.Drawing.Size(176, 23);
            this.biletListele.TabIndex = 8;
            this.biletListele.Text = "bilet ara";
            this.biletListele.UseVisualStyleBackColor = true;
            this.biletListele.Click += new System.EventHandler(this.biletListele_Click);
            // 
            // rezerveSat
            // 
            this.rezerveSat.Location = new System.Drawing.Point(26, 233);
            this.rezerveSat.Name = "rezerveSat";
            this.rezerveSat.Size = new System.Drawing.Size(176, 23);
            this.rezerveSat.TabIndex = 9;
            this.rezerveSat.Text = "rezerve sat";
            this.rezerveSat.UseVisualStyleBackColor = true;
            this.rezerveSat.Visible = false;
            this.rezerveSat.Click += new System.EventHandler(this.rezerveSat_Click);
            // 
            // odemeComb
            // 
            this.odemeComb.FormattingEnabled = true;
            this.odemeComb.Location = new System.Drawing.Point(102, 324);
            this.odemeComb.Name = "odemeComb";
            this.odemeComb.Size = new System.Drawing.Size(100, 21);
            this.odemeComb.TabIndex = 10;
            this.odemeComb.Visible = false;
            // 
            // ucretComb
            // 
            this.ucretComb.FormattingEnabled = true;
            this.ucretComb.Location = new System.Drawing.Point(102, 283);
            this.ucretComb.Name = "ucretComb";
            this.ucretComb.Size = new System.Drawing.Size(100, 21);
            this.ucretComb.TabIndex = 11;
            this.ucretComb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ücret türü :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ödeme  türü :";
            this.label4.Visible = false;
            // 
            // rezervesonsat
            // 
            this.rezervesonsat.Location = new System.Drawing.Point(17, 369);
            this.rezervesonsat.Name = "rezervesonsat";
            this.rezervesonsat.Size = new System.Drawing.Size(185, 28);
            this.rezervesonsat.TabIndex = 14;
            this.rezervesonsat.Text = "rezerve satma işlemini onaylama";
            this.rezervesonsat.UseVisualStyleBackColor = true;
            this.rezervesonsat.Click += new System.EventHandler(this.rezervesonsat_Click);
            // 
            // don
            // 
            this.don.Location = new System.Drawing.Point(843, 374);
            this.don.Name = "don";
            this.don.Size = new System.Drawing.Size(121, 23);
            this.don.TabIndex = 15;
            this.don.Text = "ana sayfaya dön";
            this.don.UseVisualStyleBackColor = true;
            this.don.Click += new System.EventHandler(this.don_Click);
            // 
            // biletDegisiklikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(982, 409);
            this.Controls.Add(this.don);
            this.Controls.Add(this.rezervesonsat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucretComb);
            this.Controls.Add(this.odemeComb);
            this.Controls.Add(this.rezerveSat);
            this.Controls.Add(this.biletListele);
            this.Controls.Add(this.rezerveSil);
            this.Controls.Add(this.mSoyad);
            this.Controls.Add(this.mAd);
            this.Controls.Add(this.biletSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kadSoyad);
            this.Name = "biletDegisiklikForm";
            this.Text = "rezerveSat";
            this.Load += new System.EventHandler(this.rezerveSat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kadSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button biletSil;
        private System.Windows.Forms.TextBox mAd;
        private System.Windows.Forms.TextBox mSoyad;
        private System.Windows.Forms.Button rezerveSil;
        private System.Windows.Forms.Button biletListele;
        private System.Windows.Forms.Button rezerveSat;
        private System.Windows.Forms.ComboBox odemeComb;
        private System.Windows.Forms.ComboBox ucretComb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rezervesonsat;
        private System.Windows.Forms.Button don;
    }
}