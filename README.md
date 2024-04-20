# SİNEMA OTOMASYONU

Bu proje, bir sinema otomasyon uygulamasını simüle eder. Kullanıcılar film seçebilir, seansları görebilir, koltuk seçimi yapabilir ve rezervasyon yapabilirler.

## KULLANIM KILAVUZU

1. Başlangıç Ekranı : Uygulama başladığında, kullanıcıya film seçme ekranı sunulur. Kullanıcı bir film seçtikten sonra "Onayla" butonuna tıklayarak devam eder.

2. Seans Seçme : Film seçimi yapıldıktan sonra, kullanıcı seansları görebileceği bir ekrana yönlendirilir. Kullanıcı buradan bir seans seçer ve devam eder.

3. Koltuk Seçimi : Seans seçimi yapıldıktan sonra, kullanıcı koltuk seçimi ekranına yönlendirilir. Kullanıcı buradan boş olan koltuklardan birini seçer ve devam eder.

4. Rezervasyon Onayı : Koltuk seçimi yapıldıktan sonra, kullanıcı rezervasyon bilgilerini görebileceği bir ekrana yönlendirilir. Kullanıcı buradan rezervasyonunu onaylayabilir.

5. Rezervasyon Tamamlandı : Rezervasyon onayı yapıldıktan sonra, kullanıcı rezervasyonunun tamamlandığına dair bir ekranla karşılaşır.

## Sınıflar 

Müşteri sınıfı, müşteriye ait bilgileri içerir. MusteriAdSoyad, Cinsiyet ve EngelDurumu gibi özellikleri gösterir.

Rezervasyon sınıfı, müşterinin yaptığı rezervasyonu temsil eder. Musteri sınıfından miras alır ve MusteriAdsoyad, BiletAdeti, KoltukNo, Seans gibi özellikleri gösterir .rezervasyon sınıfı musteri sınıfının özelliklerini almıştır.

Film sınıfı, sinema filmleri hakkında bilgi tutar. FilmAdi, FilmTürü ve VizyonTarihi gibi özellikleri gösterir.

Seans sınıfı, sinema seanslarını temsil eder. Seans suresi, salonNo, film gibi özellikleri gösterir.

Salon sınıfı,sinema salon numaralarını temsil eder. salon adi ve salon kapasitesi gibi özellikleri gösterir.

