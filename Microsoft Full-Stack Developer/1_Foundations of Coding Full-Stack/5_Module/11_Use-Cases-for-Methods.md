## 🧩 Use Cases for Methods

Herhangi bir talimat olmadan bir mobilya parçası yapmaya çalıştığınızı hayal edin. Her seferinde her adımı kendi başınıza çözmeniz gerekirdi; bu da sinir bozucu ve yavaş olurdu. Programlamadaki metotlar, kullanışlı talimat kılavuzları gibidir. Görevleri, karmaşık problemler üzerinde çalışmayı çok daha kolay hâle getiren basit, yeniden kullanılabilir adımlara bölerler.

Bu videoda, C#’ta metotlar için pratik kullanım senaryolarını açıklayacağız. Metotların bazı yaygın kullanım alanları; hesaplamalar yapmak, olayları ( *events* ) ele almak ve veriyi manipüle etmektir. Şimdi bunların her birini inceleyelim ve birkaç örnek keşfedelim.

---

## 🧮 Hesaplamalar Yapma

Metotlar; sayıları toplamak, ortalama hesaplamak veya denklemleri çözmek gibi hesaplamaları gerçekleştirmek için sıkça kullanılır.

Metotlar sayesinde geliştiriciler, hesaplamayı yapan bir kod bloğunu bir kez oluşturup ihtiyaç duyulan her yerde yeniden kullanabilir.

Örneğin, **"Add"** metodu iki adet integer parametre **a** ve **b** alır ve toplamlarını döndürür.

---

## 🖱️ Olayları Yönetme

Metotlar, buton tıklamaları veya fare hareketleri gibi olayları ele alacak şekilde yazılabilir; bu da uygulamalara etkileşim kazandırır.

Bunu, bir kumandadaki düğmeye basıp belirli bir eylemi tetiklemek gibi düşünebilirsiniz.

Örneğin, uygulamanın kullanıcı arayüzüyle etkileşimleri yönetmek için **Button_Click** adlı bir metot oluşturabiliriz. Kullanıcı uygulamada bir butona tıkladığında, **Button_Click** metodunun içindeki kod yürütülür.

Bu örnekte metot, konsola **button clicked** yazdıracaktır.

---

## 🧩 Veriyi Manipüle Etme

Geliştiriciler; dizileri sıralamak, string’leri değiştirmek ve koleksiyonları işlemek için metotları kullanır.

Örneğin, **SortList** metodu giriş parametresi olarak bir dizi alır, onu sıralar ve sıralanmış listeyi döndürür.

---

## 🛍️ Gerçek Dünya Örneği: E-Ticarette Sepet Toplamı Hesaplama

Şimdi metotların gerçek dünyada nasıl çalıştığına ve C#’ta nasıl uygulanacağına, sözdizimini adım adım parçalayarak bakalım.

Bir e-ticaret uygulamasında, metot alışveriş sepetindeki ürünlerin toplam fiyatını hesaplayabilir. İlk olarak, tüm öğeleriyle birlikte metot yapısını ekleriz.

Metodu **public** olarak, dönüş türü **decimal** olacak şekilde tanımlarız. Metot, giriş parametresi olarak alışveriş sepetindeki fiyatların bir listesini kabul eder.

Ardından, metodun gövdesinde, listedeki tüm fiyatların toplamını biriktirmek için **total** adlı bir değişken tanımlar ve başlatırız.

Şimdi **prices** listesindeki her fiyat üzerinde dolaşmak için bir **for loop** ekleriz. Döngünün içinde, her bir fiyat **total** değişkenine eklenir; böylece listedeki tüm fiyatların toplamı birikerek hesaplanır.

Döngü tüm fiyatları işledikten sonra, metot **total** değerini döndürür; bu değer artık **prices** listesindeki tüm değerlerin toplamını içerir.

Metotlar, veri işlemek için son derece uygundur.

---

## 🎮 Gerçek Dünya Örneği: Oyunlarda Event Yönetimi

Şimdi, C# metodunun olayları nasıl ele aldığını gösteren bir örneği inceleyeceğiz.

Bir oyunda metotlar; oyuncu hareketleri veya aksiyonlar gibi olayları yöneterek oyun deneyimini geliştirir.

**OnPlayerMove** metodunu **private** olarak tanımlarız; bu, yalnızca kendi sınıfı içinde erişilebileceği anlamına gelir. Ayrıca bu metodun bir dönüş değeri yoktur.

Bu metot, oyuncu oyunda konum değiştirdiğinde tetiklenecektir.

Veriyi **e** parametresiyle geçiririz; bu parametre **EventArgs** veri türünü kullanır. **EventArgs** veri türü, C#’ın olaylar hakkında bilgi yakalamak için kullandığı veri türüdür.

Sonraki adımda, metodun gövdesi **sender** adlı bir değişkeni kabul eder; bu değişkenin genel türü  **object** ’tir.

 **sender** ’ı **avatar** adlı bir değişkene atarız; bu değişken **player** türündedir.  **sender** ’ı **avatar** değişkenine atadığımızda, C#’a  **sender** ’ın player türünde olduğunu söyleriz.

Şimdi, atamanın başarılı olup olmadığını kontrol etmek için **avatar** değişkeninin **null** olmadığını doğrulayan bir **if statement** ekleriz. Bu durumda metot, oyuncunun konumunu güncellemeye devam eder.

Son olarak, metoda geçirilen olayın parametresi **e** içindeki **position** değerini kullanarak oyuncunun konumunu konsola yazdırırız.

Bu bilgi, hata ayıklamaya yardımcı olabilir veya oyun içinde geri bildirim sağlayabilir.

---

## 🌦️ Gerçek Dünya Örneği: Hava Durumu Verisi İşleme

Son örnek olarak, veriyi işlemek için bir metodun kullanımını inceleyeceğiz.

Bir hava durumu uygulamasında, bir metot hava durumu verisini işler ve görüntüler; bu da kullanıcılara değerli bilgiler sunar.

Bu metodun yapısını tanımlayalım.

**DisplayWeatherData** metodu **public void** bir metottur; yani herhangi bir sınıftan erişilebilir ve bir değer döndürmez.

Ayrıca metot, hava durumu bilgisini işlemek ve görüntülemek için giriş olarak hava durumu verisi nesnelerinden oluşan bir liste alır.

Şimdi, **data** listesindeki her öğe üzerinde dolaşmak için bir **for loop** ekleriz. Her döngü iterasyonunda **weather** değişkeni, mevcut hava durumu veri nesnesini temsil eder.

Döngünün her iterasyonunda kod, hava durumu verisini **report** adlı okunabilir bir string’e biçimlendirerek işler.

**report** string’ini üretmek için hava durumu veri sınıfının özelliklerinden yararlanırız. Bu örnekte, tarihi ve sıcaklığı yazdıracağız.

Son olarak, biçimlendirilmiş **report** string’ini konsolda görüntüleriz.

---

## 🎯 Özet

Bu videoda, C#’ta metotların bazı pratik kullanım senaryolarını öğrendiniz.

Metotların; hesaplamalar yapma, olayları yönetme ve veriyi manipüle etme süreçlerindeki kullanımını gerçek dünya örnekleriyle inceledik.

Metotları etkili şekilde kullanmak, uygulamalarınızda daha düzenli ve daha verimli kod yazmanızı sağlar.
