## 📚 Temel Programlama Kavramlarını Gözden Geçirme

### 🧾 Giriş

Bu okuma, C#’ta temel programlama kavramlarına kapsamlı bir genel bakış sunar;  *Boolean mantığı* ,  *koşullu ifadeler* ,  *döngüler* , *metotlar* ve *sözde kod (pseudocode)* ile bunların verimli ve bakımı kolay programlar oluşturmaktaki rollerine odaklanır.

---

## 🧠 Boolean Mantığı ve Kontrol Yapıları

Boolean mantığı, programlamada karar verme süreçlerinin temelidir. Üç ana işlemi içerir:

* **AND** , yalnızca tüm koşullar `true` ise `true` döndürür.
* **OR** , en az bir koşul `true` ise `true` döndürür.
* **NOT** , bir Boolean değeri tersine çevirir; `true` değerini `false` yapar ve tam tersini de gerçekleştirir.

 *if* , *else* ve *switch* gibi kontrol yapıları, bir programın akışını yönlendirmek için Boolean mantığını kullanır. Örneğin bir *if* ifadesi, belirli bir koşul sağlandığında bir kod bloğunu çalıştırır; tıpkı bir oyunda oyuncu anahtara sahipse bir kapının açılması gibi.

*else* ifadesi, *if* koşulu sağlanmadığında alternatif bir eylem sunar; *switch* ifadesi ise birden fazla olası durumun (case) etkili biçimde ele alınmasını sağlar.

---

## 🔁 Tekrarlama İçin Döngüleri Kullanma

Döngüler, belirli bir koşul değişene kadar kodun tekrar tekrar çalıştırılmasını sağlar.

* **for** döngüleri, bir kod bloğunu belirli sayıda tekrar etmek için idealdir; örneğin bir listedeki öğelerin üzerinden geçmek gibi.
* **while** döngüleri, belirtilen koşul `true` kaldığı sürece çalışmaya devam eder; örneğin bir oyunda düşmanlar ortaya çıkmayı bırakana kadar sürekli saldırmak gibi.

Bu döngüler, tekrarlayan görevleri otomatikleştirmeye, manuel kod yazımını azaltmaya ve hataları en aza indirmeye yardımcı olur.

---

## 🧩 Metotlarla Kodu Düzenleme

Metotlar, belirli görevleri yerine getirmek için tasarlanmış yeniden kullanılabilir kod bloklarıdır; bu da karmaşık programları düzenlemeye ve yönetmeye yardımcı olur. Bir metot; bir  *ad* , *parametreler* (girdiler), bir *dönüş türü* (çıktı) ve çalıştırılacak koddan oluşur.

Örneğin, bir arabayı hızlandıran bir metot şöyle görünebilir:

```csharp
public static int Accelerate(int gas) {
    // Code to increase car velocity
    return velocity;
}
```

Metotlar, karmaşık problemleri daha küçük ve yönetilebilir parçalara ayırarak kodun daha kolay anlaşılmasını, bakımının yapılmasını ve test edilmesini sağlar.

---

## 📝 Sözde Kod ile Planlama

 *Sözde kod (pseudocode)* , sözdizimine odaklanmadan programın mantığını düz bir dille taslak hâline getirmeye yardımcı olan bir planlama aracıdır. Geliştiricilerin bir algoritmanın adımlarını haritalandırmasına olanak tanır; böylece kodlamaya başlamadan önce mantıksal akışın doğru olduğundan emin olunur.

Örneğin, bir araba hızlandırma fonksiyonu için sözde kod şu adımları içerebilir:

* Arabayı Başlat
* Gaz Seviyesini Kontrol Et
* Gaz > 0 ise Hızı Artır
* Güncellenmiş Durumu Göster

Sözde kod, özellikle programın yapısını netleştirmek ve geliştirme sürecinin erken aşamalarında mantıksal hatalardan kaçınmak için faydalıdır.

---

## ✅ Sonuç

C#’ta verimli ve bakımı kolay programlar yazmak için  *Boolean mantığı* ,  *kontrol yapıları* ,  *döngüler* , *metotlar* ve *sözde kod* hakkında sağlam bir anlayış kritik öneme sahiptir. Bu kavramlar ve uygulamalar, geliştiricilerin karmaşık uygulamalar için uygun, düzenli, ölçeklenebilir ve güvenilir kod üretmesine yardımcı olur.
