## 🏗️ Algoritmaları C#’a Çevirme

Bir algoritmayı, bir binayı inşa etmek için kullanılan plan ( *blueprint* ) gibi hayal edin; plan inşa sürecine nasıl rehberlik ediyorsa, bir algoritma da bir problemi kod kullanarak çözmek için gereken adımları ana hatlarıyla belirler. Programlamada bu planlar, mantıksal tasarımları işlevsel koda dönüştürmek için kritik öneme sahiptir.

Bu videoda, tasarlanmış bir algoritmanın C# koduna nasıl çevrileceğini inceleyeceğiz.

Bir algoritmayı C#’a çevirmek, adım adım bir süreci (algoritmayı) bilgisayarın anlayabileceği kod hâline yazmak anlamına gelir. Basit bir algoritma oluşturarak başlayacağız ve ardından bunu uygulamak için karşılık gelen C# kodunu yazacağız. Bu yöntem, önce çözümü planlamanıza yardımcı olur; böylece hatasız ve verimli kod yazmak daha kolay hâle gelir.

Önce algoritmamızı düz bir dille, yani sözde kod ( *pseudocode* ) olarak yazalım. Bu şekilde, henüz koda takılmadan adımları kolayca anlayabiliriz.

Örneğimiz için, üç sayıyı toplama algoritması oluşturalım. Süreç şöyle:

İlk sayıyı tanımlayarak başlayın.
Sonra ikinci sayıyı tanımlayın.
Ardından üçüncü sayıyı tanımlayın.
Bundan sonra üç sayının toplamını hesaplayın.
Son olarak toplam sonucunu görüntüleyin.

Bu adım adım yaklaşım, daha sonra koda çevirmeyi kolaylaştırır.

Artık adımları bildiğimize göre, her bir algoritma parçasının nasıl koda dönüştüğünü inceleyerek bunları C#’a çevirelim.

---

## 🔢 Üç Sayıyı Tanımlama

C#’ta üç sayıyı bildirerek başlayacağız. Tam sayıları tanımlamak için C#’ta **int** türünü kullanacağız.

İlk değişkeni **"number1"** olarak tanımlayalım ve değerini beş olarak atayalım.
İkinci değişkenin adı **"number2"** ve değerini on olarak atayalım.
Üçüncü değişkenin adı **"number3"** ve değerini on beş olarak atayalım.

Şimdi bu üç sayıyı toplayalım.

Sonucu, *integer* veri türüne sahip **sum** adlı yeni bir değişkende saklayacağız.

---

## 🖥️ Sonucu Yazdırma

Artık toplamı hesapladığımıza göre, bunu görüntülememiz gerekir.

C#’ta şunu yazarız:

```csharp
Console.WriteLine(sum);
```

**Console.WriteLine()** fonksiyonu, ekrana bilgi yazdırmak için kullanılır.

Bunu nasıl ve neden kullandığımızı parçalayalım:

Konsola (programımızın çalıştığı pencere) bir şey yazdırmak istediğimizde **Console.WriteLine()** fonksiyonunu kullanırız.  **"Console"** , çıktının görüntülendiği alanı ifade eder ve  **"WriteLine"** , bir satır metin verisi yazdırmak istediğimiz anlamına gelir.

**Console.WriteLine()** fonksiyonu bir argüman alır—yazdırmak istediğimiz değer—ve bunu görüntüler.

Örneğimizde, **"sum"** değişkeninin değerini yazdırmak istiyoruz; bu yüzden argüman olarak  **sum** ’u geçiriyoruz.

Bu, kullanıcıyla nasıl iletişim kurduğumuz ve sonuçları nasıl gösterdiğimizdir.

Bu satır, bilgisayara **sum** içinde saklanan değeri (30 olacak) konsola yazdırmasını söyler. Program çalıştığında sonuç yazdırılır ve çıktıyı görebiliriz.

---

## ✅ Kapanış

Bu videoda, tasarlanmış bir algoritmayı C# koduna nasıl çevireceğinizi öğrendiniz.

Bir algoritmayı C#’a çevirmek, önce adım adım planı (algoritmayı) oluşturmayı, sonra bu planı koda dönüştürmeyi içerir. Mantığı önce anlayarak, daha güvenilir ve daha etkili programlar yazabiliriz.
