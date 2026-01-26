## 🔀 Döngülerle *Switch* İfadelerini Entegre Etme

Bir geliştirici olarak, karmaşık koşullar içeren problemleri çözmek için birden fazla programlama aracını birleştirmeniz gerekecektir. Bunun bir örneği, *switch* ifadelerini döngülerle entegre etmektir.

Bu videoda, kodlama alıştırmalarında *switch* ifadelerini döngülerle birleştireceğiz. Önce, *switch* ifadelerini döngülerle birleştirmenin verimli bir çözüm sağladığı bazı karmaşık programlama koşulu örneklerini inceleyelim.

---

## 🛒 Örnek 1: E-Ticaret Uygulamasında Sipariş Durumlarını İşleme

Örneğin bir e-ticaret uygulamasında, durumlarına göre birden fazla siparişi işlememiz gerekebilir. Her siparişi dolaşmak için bir döngü kullanabilir ve farklı durumları yönetmek için her siparişi bir *switch* yapısında ele alabiliriz.

Aşağıda **C#** ile bir kod örneği yer alıyor.

Öncelikle, işleyeceğimiz sipariş durumlarını içeren `orderStatuses` adlı diziyi oluştururuz. Bu örnek için, *stream* türünde sabit bir dizi kullanacağız.

Ardından koleksiyondaki elemanlar üzerinde yineleme yapmak için bir döngü ekleriz. Bu örnekte bir *for* döngüsü ekleriz ve her öğe `status` adlı değişkene atanır.

Sonra `status` değişkeninin değerini kontrol etmek için *switch* ifadesini ekleriz; böylece tanımlı  *case* ’lerle eşleştirebiliriz.

Daha sonra sistemdeki her durum için bir *case* ekleriz.

* Durum `pending` ise `"order is pending"` yazdırırız.
* Durum `shipped` ise `"order has been shipped"` yazdırırız.
* Durum `delivered` ise `"order has been delivered"` yazdırırız.
* Durum `canceled` ise `"the order has been canceled"` yazdırırız.

Şimdi, durum bu belirtilen  *case* ’lerin hiçbirine uymuyorsa, `default` bloğu çalıştırılır ve `"unknown status"` yazdırılır.

Beklenmeyen davranışları önlemek için her *case* için `break` anahtar sözcüğünü eklemeyi unutmayın.

Şimdi siparişleri duruma göre işleme sürecini bir *switch* ifadesini bir *for* döngüsüyle entegre ederek optimize ettiğimize göre, bir örnek daha üzerinde çalışalım.

---

## 🎓 Örnek 2: Öğrenci Notlarını *For* Döngüsü ve *Switch* ile Değerlendirme

Bu sefer bir *for* döngüsü ve bir *switch* ifadesiyle öğrenci notlarını değerlendireceğiz.

Bu örnekte, öğrenci notlarını değerlendirip geri bildirim sağlamamız gerekiyor. Her öğrencinin puanını gözden geçirmek için bir *for* döngüsü ve uygun geri bildirimi vermek için bir *switch case* kullanabiliriz.

Programımızı yazmak için **C#** kullanalım.

Önce, öğrenci notlarının listesini tamsayı olarak saklamak için `grades` adlı bir `int` dizisi oluştururuz.

Sonraki aşamada, dizideki her eleman üzerinde yineleme yapmak için bir *for* döngüsü ekleriz. Her yinelemede mevcut eleman `grade` değişkenine atanır.

Şimdi `grade` değerine göre bir harf notu atamak için *switch case* ekleriz.

*Switch* ifadesi `grade` değişkeninin değerini kontrol eder ve her biri `when` anahtar sözcüğüyle bir koşul tanımlanmış farklı  *case* ’lerle eşleştirir.

* Not 90 veya üzerindeyse, `"Grade A: Excellent!"` yazdırırız.
* Not 80 ile 89 arasındaysa, `"Grade: Good job!"` yazdırırız.
* Not 70 ile 79 arasındaysa, `"Grade C: Fair."` yazdırırız.
* Not 60 ile 69 arasındaysa, `"Grade D: Needs improvement."` yazdırırız.
* Not 60’ın altındaysa, yukarıdaki *case* koşullarının hiçbirine uymaz ve `default` bloğuna düşer; `"Grade F: Fail."` yazdırılır.

---

## ✅ Kapanış

Bu videoda, *switch* ifadelerini döngülerle birleştirmenin karmaşık programlama koşullarını nasıl ele alabileceğini öğrendiniz.

Bu şekilde farklı programlama araçlarını birleştirmek, bir geliştirici olarak sizin için önemli olacak ve karmaşık programlama zorluklarının üstesinden gelmenize yardımcı olacaktır.
