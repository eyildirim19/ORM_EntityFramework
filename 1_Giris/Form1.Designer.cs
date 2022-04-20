namespace _1_Giris
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKategoriListesi = new System.Windows.Forms.Button();
            this.lstKategoriListesi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrunSayisi = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriListesi
            // 
            this.btnKategoriListesi.Location = new System.Drawing.Point(12, 12);
            this.btnKategoriListesi.Name = "btnKategoriListesi";
            this.btnKategoriListesi.Size = new System.Drawing.Size(146, 31);
            this.btnKategoriListesi.TabIndex = 0;
            this.btnKategoriListesi.Text = "Kategori Listesi";
            this.btnKategoriListesi.UseVisualStyleBackColor = true;
            this.btnKategoriListesi.Click += new System.EventHandler(this.btnKategoriListesi_Click);
            // 
            // lstKategoriListesi
            // 
            this.lstKategoriListesi.FormattingEnabled = true;
            this.lstKategoriListesi.ItemHeight = 15;
            this.lstKategoriListesi.Location = new System.Drawing.Point(11, 55);
            this.lstKategoriListesi.Name = "lstKategoriListesi";
            this.lstKategoriListesi.Size = new System.Drawing.Size(147, 139);
            this.lstKategoriListesi.TabIndex = 1;
            this.lstKategoriListesi.SelectedIndexChanged += new System.EventHandler(this.lstKategoriListesi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Sayısı:";
            // 
            // lblUrunSayisi
            // 
            this.lblUrunSayisi.AutoSize = true;
            this.lblUrunSayisi.Location = new System.Drawing.Point(257, 55);
            this.lblUrunSayisi.Name = "lblUrunSayisi";
            this.lblUrunSayisi.Size = new System.Drawing.Size(12, 15);
            this.lblUrunSayisi.TabIndex = 3;
            this.lblUrunSayisi.Text = "-";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(11, 236);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(146, 23);
            this.txtKategoriAdi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(11, 289);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(147, 54);
            this.txtAciklama.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(57, 349);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 399);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.lblUrunSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKategoriListesi);
            this.Controls.Add(this.btnKategoriListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnKategoriListesi;
        private ListBox lstKategoriListesi;
        private Label label1;
        private Label lblUrunSayisi;
        private TextBox txtKategoriAdi;
        private Label label2;
        private Label label3;
        private TextBox txtAciklama;
        private Button btnEkle;
    }
}