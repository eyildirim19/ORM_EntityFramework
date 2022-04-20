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
            // Entity Framework Core Microsoft tarafýndan geliþtirilen bir orm tooludur.

            // Veritabaný ile uygulama arasýnda iletiþim katmaný görevi üstlenen, varlýklarýmýz arasýnda (veritabaný ve c# objeleri) haritalndýrmayý yapan yapýdýr..

            // EF Core nin temel olarak iki yaklaþýmý vardýr;
            // 1) Code First => Önce kod sonra veritabaný. KOda göre veritabaný oluþtur

            // 2) DB First (Model yardýmýyla deðil) => önce veritbaný sonra kod. Veritabanýna göre kodu oluþtur...

            // EF Core kullanmak için bazý kütüphaneler ihtiyaç vardýr...
            // EntityFramework.Core
            // EntityFramework.SqlServer
            // EntityFramework.Tools

            // DB-First yaklaþýmýný uygulamak için Sccafold-DbContext yöntemi ile hazýr bir veritabanýnýn yansýmasýný uygulamamýza dahil edebiliriz..Bu yöntemi uygulamak için Package Manager Console penceresini açmamýz gerekir.  BU pencereÝ; Tools menüsü > Nuget Package Manager > Package Manager COnsole þeklinde açýlýr


            // BU pencerede Scaffold-DbContext "Server=localhost;Database=Northwind;uid=sa;pwd=123" Microsoft.EntityFrameworkCore.SqlServer -outputdir Models komutu ile veritabanýnýn yansýmasý alýnýr.

            // Models klasörü içerisinde Context uzantlý sýnýf veritabaný baðlantýsýný ve uygulama içerisinde classlarýmýzýn veritabaný varlýklarýmýz ile iliþlilendirimesini saðlayan sýnýftýr...


        }

        private void btnKategoriListesi_Click(object sender, EventArgs e)
        {
            // Baðlantý dbContext nesine üzerinden yapýlýr
            NorthwindContext dbContext = new NorthwindContext();

            // katList nesnesi oluþutrulup, baðlý ile veritabanýn categories kayýtlarý çekilip katlist nesnesine atanýr...
            List<Category> katList = dbContext.Categories.ToList();

            foreach (var item in katList)
            {
                lstKategoriListesi.Items.Add(item.CategoryName);
            }
        }

        private void lstKategoriListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catName = lstKategoriListesi.SelectedItem.ToString(); // seçili kategorinin adý
            NorthwindContext dbContext = new NorthwindContext();

            Category category = dbContext.Categories.FirstOrDefault(c => c.CategoryName == catName);

            // Category'Nin ürünlerinin sayýsý..
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

            dbContex.SaveChanges(); // deðiþikliði veritabanýna yansýt...
            txtAciklama.Clear();
            txtKategoriAdi.Clear();
        }
    }
}