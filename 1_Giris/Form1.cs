using _1_Giris.Models;

namespace _1_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Entity Framework Core Microsoft taraf�ndan geli�tirilen bir orm tooludur.

            // Veritaban� ile uygulama aras�nda ileti�im katman� g�revi �stlenen, varl�klar�m�z aras�nda (veritaban� ve c# objeleri) haritalnd�rmay� yapan yap�d�r..

            // EF Core nin temel olarak iki yakla��m� vard�r;
            // 1) Code First => �nce kod sonra veritaban�. KOda g�re veritaban� olu�tur

            // 2) DB First (Model yard�m�yla de�il) => �nce veritban� sonra kod. Veritaban�na g�re kodu olu�tur...

            // EF Core kullanmak i�in baz� k�t�phaneler ihtiya� vard�r...
            // EntityFramework.Core
            // EntityFramework.SqlServer
            // EntityFramework.Tools

            // DB-First yakla��m�n� uygulamak i�in Sccafold-DbContext y�ntemi ile haz�r bir veritaban�n�n yans�mas�n� uygulamam�za dahil edebiliriz..Bu y�ntemi uygulamak i�in Package Manager Console penceresini a�mam�z gerekir.  BU pencere�; Tools men�s� > Nuget Package Manager > Package Manager COnsole �eklinde a��l�r


            // BU pencerede Scaffold-DbContext "Server=localhost;Database=Northwind;uid=sa;pwd=123" Microsoft.EntityFrameworkCore.SqlServer -outputdir Models komutu ile veritaban�n�n yans�mas� al�n�r.

            // Models klas�r� i�erisinde Context uzantl� s�n�f veritaban� ba�lant�s�n� ve uygulama i�erisinde classlar�m�z�n veritaban� varl�klar�m�z ile ili�lilendirimesini sa�layan s�n�ft�r...


        }

        private void btnKategoriListesi_Click(object sender, EventArgs e)
        {
            // Ba�lant� dbContext nesine �zerinden yap�l�r
            NorthwindContext dbContext = new NorthwindContext();

            // katList nesnesi olu�utrulup, ba�l� ile veritaban�n categories kay�tlar� �ekilip katlist nesnesine atan�r...
            List<Category> katList = dbContext.Categories.ToList();

            foreach (var item in katList)
            {
                lstKategoriListesi.Items.Add(item.CategoryName);
            }
        }

        private void lstKategoriListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catName = lstKategoriListesi.SelectedItem.ToString(); // se�ili kategorinin ad�
            NorthwindContext dbContext = new NorthwindContext();

            Category category = dbContext.Categories.FirstOrDefault(c => c.CategoryName == catName);

            // Category'Nin �r�nlerinin say�s�..
            int count = dbContext.Products.Where(c => c.CategoryId == category.CategoryId).Count();

            lblUrunSayisi.Text = count.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtKategoriAdi.Text;
            category.Description = txtAciklama.Text;
            
            NorthwindContext dbContex = new NorthwindContext();
            dbContex.Categories.Add(category);

            dbContex.SaveChanges(); // de�i�ikli�i veritaban�na yans�t...
            txtAciklama.Clear();
            txtKategoriAdi.Clear();
        }
    }
}