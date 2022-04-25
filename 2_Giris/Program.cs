using _2_Giris.NorthwindEntity;

Console.WriteLine("Kaç NUmaralı Kategorinin adını değiştireceksin??? . 1 ile 8 arası");

int catId = Convert.ToInt32(Console.ReadLine());

NorthwindContext dbContext = new NorthwindContext();

// Find metodu paramettreyi pk'da arar. Eğer kayıt varsa satırı, yoksa nulll döner..pk değeri ile gönderilen parametreyi kar

//Category cat1 = dbContext.Categories.FirstOrDefault(c => c.CategoryId == catId);
Category cat = dbContext.Categories.Find(catId);

if (cat != null)
{
    Console.WriteLine($"Kategir Adı {cat.CategoryName}. Değiştirmek istediğiniz adı giriniz");
    cat.CategoryName = Console.ReadLine();

    dbContext.SaveChanges(); // değişikliği veritabanına kaydfet....
}
else
{
    Console.WriteLine("Üzgünüm kategori bulunamadı");
}

