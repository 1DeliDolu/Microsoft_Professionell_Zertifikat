## ✍️ `SELECT` İfadeleri Yazma

Bu laboratuvarda, bir MySQL veritabanıyla etkileşim kurmak için SQL ifadelerini kullanacağız. Bilgisayarımda **SampleDB** adlı bir MySQL veritabanı var ve içinde örnek veriler bulunan **Employees** adlı tek bir tablo bulunuyor. Bu tabloyla etkileşim kurmak için tek tek SQL ifadeleri yazacağız.

---

## 1️⃣ Adım 1: `Employees` Tablosundaki Tüm Kayıtları Getirme

İlk adım olarak, **Employees** tablosundaki tüm kayıtları seçmek için bir `SELECT` ifadesi kullanacağız. Tablodaki tüm kayıtları getirmesi için SQL’e yıldız (`*`) kullanacağım.

Bu sayede kayıtların getirildiğini görebilirsiniz. `first name`, `last name`, `department`, `salary` ve `years of experience` sütunları var. Ve işte bu veritabanındaki tüm kayıtlar.

---

## 2️⃣ Adım 2: Belirli Sütunları Getirme

İkinci adımda, veritabanından belirli sütunları alacağız. Diyelim ki **Employees** tablosundan yalnızca ad ve soyadı istiyoruz. Bunun için başka bir `SELECT` ifadesi kullanabiliriz.

Bu durumda, almak istediğimiz sütunları belirteceğiz. Şu komutu kullanacağım: `SELECT firstname, comma, lastname`. Eğer `department` seçmek isteseydik, `comma, department` ekleyebilirdik. Ancak bu alıştırmada sadece `firstname` ve `lastname` kullanacağız.

Bunu çalıştırdığımda, tablodan yalnızca `firstname` ve `lastname` sütunlarını vermelidir.

---

## 3️⃣ Adım 3: `SELECT` İfadesini Filtreleme

Üçüncü adımda, `SELECT` ifademizi filtreleyip yalnızca belirli satırları geri alacağız. Sadece departmanı **HR** olan kayıtları istiyoruz.

Bu ifade için `WHERE` yan tümcesini kullanacağız. `WHERE` yan tümcesi, SQL Server’ın tablodan ne döndüreceğini kısıtlar. Burada `department` değerini **HR** olarak belirttiğimi görüyorsunuz ve bunu `WHERE` yan tümcesiyle yapıyorum.

Böylece iki kayıt döndürülüyor. Tüm sütunları döndürüyor, ancak sadece departmanı HR olan kayıtları getiriyor.

---

## 4️⃣ Adım 4: `ORDER BY` ile Sıralama

Dördüncü adımda, `ORDER BY` yan tümcesini kullanacağım. Bu, döndürülen değerleri sıralamamızı sağlar.

Bu örnekte `salary` alanına göre sıralayacağım ve maaşları azalan sırada sıralamak istiyorum. Bu, `ORDER BY` ile en yüksek maaşın en üstte, en düşük maaşın en altta olmasını sağlamalıdır.

Burada en üstte **$95,000** ile en yüksek maaşı ve en altta **$42,000** ile en düşük maaşı görüyoruz.

---

## 5️⃣ Adım 5: `WHERE` ve `ORDER BY` Birleştirme

Beşinci adımda, `WHERE` ve `ORDER BY`’ı birleştireceğiz.

**Engineering** departmanındaki kayıtları seçeceğiz ve bu kez **years of experience** alanına göre sıralayacağız. Yine azalan sırada sıralayacağız.

`WHERE department equals engineering` yazıyoruz. Bu iki fikri bu şekilde birleştiriyoruz. `Years of experience is greater than three.`

Şimdi bileşik bir `WHERE` yan tümcemiz var. Yalnızca engineering’de olan ve deneyim yılı 3’ten büyük olan kişileri istiyoruz. Ayrıca `years of experience` alanına göre azalan sırada `ORDER BY` uygulayacağız.

Böylece üç kayıt geri alıyoruz. Maaşların en yüksekten en düşüğe doğru sıralandığını görebilirsiniz. Ve tüm `years of experience` değerleri 3’ten büyük görünüyor.

---

## 📊 `SELECT` İçinde Veri Toplama ve Gruplama

SQL kullanarak, veriyi komut içinde doğrudan toplayabilir ve gruplayabiliriz. Bu verinin tabloda hazır olmasına gerek yok; bunu `SELECT` ifadesinin içinde yapabiliriz.

İlk yapacağım işlem, departmana göre toplam maaşları almak.

SQL’den istediğim şey: departmanı seçmek, sonra maaşları toplayıp toplam maaş olarak göstermek; bunu **employees** tablosundan almak ve departmana göre gruplamak.

Sonuç olarak, her departmanı ve o departmanın toplam maaşlarının ne kadar olduğunu veriyor. Departmanlara göre toplam harcamanızı görmek ve hangi departmanın en fazla ya da en az maliyete sahip olduğunu belirlemek istediğiniz bir senaryo düşünebilirsiniz. Bu sorgu bunu çok kolay ve çok hızlı şekilde yapar.

---

## 🔢 Departman Başına Çalışan Sayısını Sayma

Bir sonraki yapacağım şey, her departmandaki çalışan sayısını saymak.

`SUM` yerine bu kez `COUNT` anahtar kelimesini kullanacağım. Buradaki dönüşü görebilirsiniz. Departmanı seçiyor, `star` kullanarak sayıyor. Böylece tüm çalışanları `employee count` olarak sayacak.

Bu işlem, **employees** tablosundan aldığım çıktı üzerinde yeni bir sütun oluşturdu ve veritabanındaki veriye bakarken bu sayımı bize sunuyor. Böylece engineering’de üç çalışan, human resources’da bir çalışan ve finance’da iki çalışan olduğunu görebiliyoruz.

---

## ✅ Kapanış

SQL ifadelerini kullanarak veritabanınızla etkileşim kurabilirsiniz. Burada yalnızca `SELECT` ifadelerini gösteriyoruz; yani veritabanından veri alıyoruz. Ancak SQL ifadeleriyle veritabanına veri yazmak, kayıtları silmek ve benzeri başka işlemler de yapabilirsiniz.
