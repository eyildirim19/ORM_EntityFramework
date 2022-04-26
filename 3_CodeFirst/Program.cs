// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Code first yaklaşımında c# tarafında yapılan işlemlerin veritabanına yansıması için migration işlemi yapılır...

// Eğer bir veritabanı yoksa ilk aşamada veritabanı oluşturulur, daha sonra veritabanı objeleri oluşturulur. Eğer veritabanı varsa sadece objeler oluşturulur veya silinir...

// Migration yapabilmek için projemize Microsoft.EntityFrameworkCore.Tools kütüphanesine dahil edilmelidir. 

// Migration yapabilmek için Package Manage Console Penceresi kullanılır;
 // add-migration migrationName => migration eklemek için kullanılır. Migration eklendiğinde projedeki değişiklikler migration dosyasına eklenir. (Migration dosyası oluşuturulur

 // remove-migration => son migrationı (dosyasını) siler...

 // update-database => son migration dosyasındaki güncellemeler veritabanına yansıtılır....

// eğer belli bir migrationa dönmek istiyorsanız;
// 1) update-database -migration DonulecekMigration
// 2) remove-migration en migration'i silmek için