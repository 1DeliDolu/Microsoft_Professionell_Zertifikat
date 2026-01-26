## 🔁 Tekrarlayan Görevler için Döngü Tabanlı Programlama

### 🧩 1. Adım: *For* Döngüsü ile Koleksiyon Üzerinde Yineleme

Bu ilk adımda, bir *for* döngüsünün bir dizi ( *array* ) gibi öğe koleksiyonu üzerinde yineleme yapması gereken görevleri nasıl otomatikleştirmeye yardımcı olabileceğini inceleyeceğiz.

Bir dizi, sayılar gibi öğelerin tek bir değişkende birlikte saklandığı bir koleksiyondur. Diziler, aynı türden birden fazla değeri saklamanız gerektiğinde kullanışlıdır. Bu durumda, `"numbers"` adlı bir dizide beş sayı saklıyoruz.

C#’ta dizi indeksleme sıfırdan başlar; yani dizinin ilk elemanı 1. konumda değil,  **0. konumdadır** . Örneğin dizide, `numbers` **1, 2, 3, 4, 5** değerlerine eşittir. `numbers` indeks öğesi **0** değeri  **1** ’dir ve `numbers` indeks öğesi **4** değeri  **5** ’tir.

`numbers.length` ifadesini dizideki öğe sayısını almak için kullanırız. Bu durumda sayı  **beştir** . Döngü, `i` dizinin uzunluğundan küçük olduğu sürece çalışmaya devam eder; yani `i`, `numbers.length` değerinden küçük olduğu sürece.

Bu, mevcut olmayan bir indekse erişmememizi sağlar; aksi takdirde hata oluşur.

Bir *for* döngüsü, bir kod parçasını tam olarak kaç kez çalıştırmanız gerektiğini bildiğinizde idealdir. Üç bölümü vardır:

* Başlangıç noktası: `int i = 0;`
* Koşul: `i` değerinin `numbers length` değerinden küçük olması; döngünün çalışmaya devam etmesi için bunun doğru olması gerekir
* Güncelleme: `i++`, döngü her çalıştığında `i` değerini bir artırır

---

## 🔄 2. Adım: *While* Döngüsü Kullanımı

Bu adımda, bir *while* döngüsünü nasıl kullanacağımızı öğreneceğiz.

Bir *while* döngüsü, *for* döngüsünden farklıdır çünkü belirli bir tekrar sayısı yoktur. Bunun yerine, bir koşul doğru olduğu sürece çalışmaya devam eder.

1–10 arası sayı dizisi üretmek için bir *while* döngüsü kullanacağız. Döngü, `counter` değerinin 10’dan küçük veya eşit olduğu sürece çalışmaya devam edecektir. Döngü her çalıştığında `counter` değerini bir artıracağız.

*For* döngüsünün aksine, *while* döngüsü otomatik olarak kaç kez çalışması gerektiğini bilmez.

Ne kadar süre çalışacağını sizin belirlediğiniz koşul kontrol eder. Bu örnekte döngü, `counter` 10’dan küçük veya eşit olduğu sürece çalışır. `counter` 10’dan büyük olduğunda koşul artık doğru olmaz ve döngü durur.

`counter++` kullanarak `counter` değerini güncellemeyi unutmamalısınız; aksi halde koşul hiçbir zaman değişmeyeceği için döngü sonsuza kadar çalışır.

Bu, yeni başlayanlar için yaygın bir hatadır; bu yüzden bir *while* döngüsünde sayacınızı güncellediğinizi her zaman kontrol edin.

---

## 🧠 3. Adım: Döngüleri *If-Else* Yapısıyla Birleştirme

Şimdi döngüleri *if-else* yapısıyla birleştirerek her yineleme içinde karar verme ekleyeceğiz.

Bir dizideki her sayının tek mi çift mi olduğunu kontrol edeceğiz ve sonucu buna göre yazdıracağız.

Bunu yapmak için *modulo* operatörünü kullanacağız; yani yüzde işaretini (`%`). Bu operatör, bir bölme işleminin kalanını verir.

Bir sayıyı ikiye bölerken kalan yoksa, sayı çifttir. Kalan varsa, sayı tektir. *Modulo* operatörü, bir sayının başka bir sayıya bölünmesiyle oluşan kalanı bulmak için kullanılır.

Bir sayıyı ikiye böldüğümüzde kalan yoksa, yani sayının  **modulo 2’si sıfıra eşitse** , sayı çifttir.

Kalan varsa, yani sayının  **modulo 2’si sıfıra eşit değilse** , sayı tektir.

Bu kavramı programlamada, sayıların tek veya çift olması gibi belirli koşulları sağlayıp sağlamadığını kontrol etmek için kullanırız.

*Modulo* operatörünün nasıl çalıştığını unutursanız, bir bölme işleminin kalanını verdiğini hatırlayın. Örneğin, `5/2` işlemi 2 verir ve kalan 1’dir; bu yüzden 5 tektir.

---

## 🔀 4. Adım: Döngüleri *Switch* İfadesiyle Birleştirme

Bu son adımda, döngüleri bir *switch* ifadesiyle birlikte nasıl kullanacağımızı inceleyeceğiz.

Bir *switch* ifadesi, *if-else* ifadesine benzer; ancak bir değişkeni aynı anda birden fazla değer için kontrol etmenizi sağlar.

Birden fazla *if-else* koşulu kullanmak yerine — ki bu kodunuzu okumayı zorlaştırabilir — *switch* ifadesi farklı durumları daha temiz ve daha düzenli bir şekilde ele almanızı sağlar.

Her hava koşulu için, döngünün içinde *switch* ifadesini kullanarak farklı bir mesaj yazdıracağız.
