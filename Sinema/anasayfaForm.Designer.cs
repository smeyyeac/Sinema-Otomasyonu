namespace Sinema
{
    partial class anasayfaForm
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
            this.components = new System.ComponentModel.Container();
            this.sinemaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaDBDataSet = new Sinema.SinemaDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinemaDBDataSet1 = new Sinema.SinemaDBDataSet1();
            this.sinemaDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.seansGoster = new System.Windows.Forms.Button();
            this.salonagec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cıkıs = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.filmsec = new System.Windows.Forms.Button();
            this.tarihsec = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.biletduzenle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sinemaDBDataSetBindingSource
            // 
            this.sinemaDBDataSetBindingSource.DataSource = this.sinemaDBDataSet;
            this.sinemaDBDataSetBindingSource.Position = 0;
            // 
            // sinemaDBDataSet
            // 
            this.sinemaDBDataSet.DataSetName = "SinemaDBDataSet";
            this.sinemaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(759, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(204, 260);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // sinemaDBDataSet1
            // 
            this.sinemaDBDataSet1.DataSetName = "SinemaDBDataSet1";
            this.sinemaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinemaDBDataSet1BindingSource
            // 
            this.sinemaDBDataSet1BindingSource.DataSource = this.sinemaDBDataSet1;
            this.sinemaDBDataSet1BindingSource.Position = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "kullaniciad";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(275, 150);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 260);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // seansGoster
            // 
            this.seansGoster.BackColor = System.Drawing.Color.Silver;
            this.seansGoster.Enabled = false;
            this.seansGoster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seansGoster.Location = new System.Drawing.Point(807, 104);
            this.seansGoster.Name = "seansGoster";
            this.seansGoster.Size = new System.Drawing.Size(75, 23);
            this.seansGoster.TabIndex = 8;
            this.seansGoster.Text = "seans seç";
            this.seansGoster.UseVisualStyleBackColor = false;
            this.seansGoster.Click += new System.EventHandler(this.seancSec_Click);
            // 
            // salonagec
            // 
            this.salonagec.BackColor = System.Drawing.Color.Silver;
            this.salonagec.Location = new System.Drawing.Point(430, 440);
            this.salonagec.Name = "salonagec";
            this.salonagec.Size = new System.Drawing.Size(180, 23);
            this.salonagec.TabIndex = 10;
            this.salonagec.Text = "salon sayfasına git";
            this.salonagec.UseVisualStyleBackColor = false;
            this.salonagec.Visible = false;
            this.salonagec.Click += new System.EventHandler(this.salonaGit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(902, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "gun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(902, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "saat";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            // 
            // cıkıs
            // 
            this.cıkıs.Location = new System.Drawing.Point(22, 43);
            this.cıkıs.Name = "cıkıs";
            this.cıkıs.Size = new System.Drawing.Size(54, 23);
            this.cıkıs.TabIndex = 16;
            this.cıkıs.Text = "çıkış";
            this.cıkıs.UseVisualStyleBackColor = true;
            this.cıkıs.Click += new System.EventHandler(this.cıkıs_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listView2.Location = new System.Drawing.Point(22, 150);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(218, 260);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 150);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 12, 12, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 11, 12, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2018, 12, 3, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // filmsec
            // 
            this.filmsec.BackColor = System.Drawing.Color.Silver;
            this.filmsec.Location = new System.Drawing.Point(224, 104);
            this.filmsec.Name = "filmsec";
            this.filmsec.Size = new System.Drawing.Size(75, 23);
            this.filmsec.TabIndex = 19;
            this.filmsec.Text = "film seç";
            this.filmsec.UseVisualStyleBackColor = false;
            this.filmsec.Click += new System.EventHandler(this.filmsec_Click);
            // 
            // tarihsec
            // 
            this.tarihsec.BackColor = System.Drawing.Color.Silver;
            this.tarihsec.Enabled = false;
            this.tarihsec.Location = new System.Drawing.Point(578, 104);
            this.tarihsec.Name = "tarihsec";
            this.tarihsec.Size = new System.Drawing.Size(75, 23);
            this.tarihsec.TabIndex = 20;
            this.tarihsec.Text = "tarih seç";
            this.tarihsec.UseVisualStyleBackColor = false;
            this.tarihsec.Click += new System.EventHandler(this.tarihsec_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // biletduzenle
            // 
            this.biletduzenle.Location = new System.Drawing.Point(69, 440);
            this.biletduzenle.Name = "biletduzenle";
            this.biletduzenle.Size = new System.Drawing.Size(75, 23);
            this.biletduzenle.TabIndex = 23;
            this.biletduzenle.Text = "bilet düzenle";
            this.biletduzenle.UseVisualStyleBackColor = true;
            this.biletduzenle.Click += new System.EventHandler(this.biletDuzenle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sinema.Properties.Resources._1471;
            this.pictureBox2.Location = new System.Drawing.Point(412, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinema.Properties.Resources._77226875_cinema_time_vector_logo_symbol_or_emblem;
            this.pictureBox1.Location = new System.Drawing.Point(567, 251);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // anasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(987, 491);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.biletduzenle);
            this.Controls.Add(this.tarihsec);
            this.Controls.Add(this.filmsec);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.cıkıs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salonagec);
            this.Controls.Add(this.seansGoster);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "anasayfaForm";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sinemaDBDataSetBindingSource;
        private SinemaDBDataSet sinemaDBDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SinemaDBDataSet1 sinemaDBDataSet1;
        private System.Windows.Forms.BindingSource sinemaDBDataSet1BindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button seansGoster;
        private System.Windows.Forms.Button salonagec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button cıkıs;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button filmsec;
        private System.Windows.Forms.Button tarihsec;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button biletduzenle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}