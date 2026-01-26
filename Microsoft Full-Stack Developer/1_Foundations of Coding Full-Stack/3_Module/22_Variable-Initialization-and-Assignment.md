## 🧩 Değişken Başlatma ve Atama

Her C# programında değişkenler, veriyi saklamak için temeldir; ancak onları nasıl bildirdiğiniz ve yönettiğiniz, kodunuzun nasıl davrandığını etkiler. Bir oyundaki oyuncu puanı gibi bazı değerler zaman içinde değişebilirken, matematiksel sabitler gibi diğerleri sabit kalmalıdır.

Bu videoda, farklı veri türleri için anahtar kelimeleri kullanarak değişkenleri bildirecek ve atayacağız. *Mutable* ve *immutable* değişkenleri inceleyeceğiz, atamaların nasıl çalıştığını göstereceğiz ve değiştirilemezliğin etkilerini ele alacağız. Son olarak, yanlış bir veri türü atamaya çalıştığınızda ne olduğuna bakacağız.

---

## 🔁 Mutable Değişkenler

Önce *mutable* değişkenleri inceleyelim. Bunlar, bildirildikten sonra yeniden atanabilen değişkenlerdir.

Bu esneklik, programın çalışması sırasında değişkenin değerinin değişeceği dinamik senaryolarda faydalıdır; örneğin bir oyunun skorunu takip eden bir programda olduğu gibi.

Örneğin, *"score"* adlı *mutable* bir değişken bildirebilir ve değerini 10 olarak atayabiliriz. Bu değişken  *mutable* ’dır; çünkü programın değiştirilmemesi gerektiğini belirten herhangi bir değiştirici ( *modifier* ) içermez. Bu değiştiricileri birazdan inceleyeceğiz.

Bir *mutable* değişkeni bildirdikten sonra, değerini herhangi bir noktada değiştirebilirsiniz. Örneğin, *"score"* değerini 20 olarak yeniden atayabiliriz.

Bu esneklik, güncelleme gerektiren değişkenlerle çalışırken kritik öneme sahiptir.

---

## 🔒 Immutable Değişkenler

Şimdi *immutable* değişkenleri inceleyelim. Bunlar, bir kez atandıktan sonra değiştirilemeyen değişkenlerdir.

*Immutable* değişkenler, program çalışırken tutarlı bir değeri koruması gereken bir değişkene ihtiyaç duyduğunuz senaryolar için uygundur.

C#’ta *immutable* değişkenleri **const** anahtar kelimesiyle bildiririz. *"pi"* adlı bir değişken bildirebilir ve değerini 3.14159 olarak atayabiliriz.

Eğer bir *immutable* değişkene yeni bir değer atamaya çalışırsanız, C# derleme zamanında ( *compile-time* ) hata üretir.

Bu örnekte, *pi* değerini 3.14 yapmak bir hatayla sonuçlanır.

Değiştirilemezlik, önemli değerlerin programınız boyunca sabit kalmasına yardımcı olur.

---

## 🧾 Bildirim Anında Atama

Önceki örneklerde, bir değişkeni bildirirken aynı anda ona bir değer atadık. İşte başka bir örnek:  *"Age"* , başlangıç değeri 25 olan *mutable* bir *integer* olarak bildirilirken, *"name"* değişkeni değeri *"Alice"* olan *immutable* bir *string* olarak bildirilir.

Bildirim anında atama, değişkenlerin bildirildikleri andan itibaren başlatılmış ( *initialized* ) veya bir değere sahip olduğundan emin olmak için C#’ta yaygın bir uygulamadır.

---

## 🧪 Veri Türlerinin Önemi ve Hatalı Atamalar

Şimdi, veri türlerinin önemini ve değişkenlerin bildirilirken nasıl atandığını konuşalım.

C#’ta yanlış veri türünde bir değer atamak, derleme zamanında hata ile sonuçlanır. Bu, yazdığınız kod bilgisayarın anlayabileceği koda dönüştürülürken, kullandığınız aracın dönüşümü doğru yapamayacağınızı size söylemesi anlamına gelir.

Örneğin, bir *integer* değişkene bir *string* atayamazsınız.

*"score"* adlı bir değişkeni *int* olarak bildirdiyseniz, ona **"ten"** metin değerini atamaya çalışmak türler uyuşmadığı için hataya neden olur.

Şimdi bu konuyu bir örnek üzerinden daha ayrıntılı inceleyelim.

---

## 🏃 Fitness Takip Uygulaması Örneği

Bir fitness takip uygulaması geliştirdiğinizi hayal edin. *"userName"* değişkenini *immutable* bir *string* olarak bildirir ve adım sayısını takip etmek için *"steps"* adlı *mutable* bir *integer* değişken tanımlarsınız.

Kullanıcı yürüdükçe, adım sayısını güncelleyebilirsiniz.

*steps* değeri *mutable* olduğu için kullanıcının ilerlemesini yansıtacak şekilde güncellenebilir.

Buna karşılık, *username* değişkeni program boyunca sabit kalır; bu da kullanıcı verilerinde tutarlılık sağlar.

---

## ✅ Kapanış

Bu videoda, farklı veri türleri için anahtar kelimeleri kullanarak değişkenleri bildirdik ve atadık. *Mutable* ve *immutable* değişkenleri, yeniden atamanın nasıl çalıştığını ve veri türleriyle ilgili hatalardan nasıl kaçınacağınızı inceledik.

Bu araçları kullanarak, değişkenleriniz beklediğiniz gibi davranır ve yaygın kodlama hatalarından kaçınmış olursunuz.
