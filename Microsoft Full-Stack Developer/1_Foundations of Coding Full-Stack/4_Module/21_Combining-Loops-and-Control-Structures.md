## 🔁 Döngüler ve Kontrol Yapılarını Birleştirme

Bir uygulama oluşturduğunuzu hayal edin; örneğin bir anket yanıtlarına göre kullanıcı girdisini işleyen ve buna göre bir yiyecek öneren bir sistem. Her yanıtı kontrol etmek için bir döngü ve sonrasında ne olacağına karar vermek için *If-Else* veya *switch* gibi bir kontrol yapısı kullanmanız gerekir.

Bu videoda, problemleri çözmek için döngüleri kontrol yapılarıyla birlikte kullanacağız.

---

## 🧩 Örnek 1: *For* Döngüsü + *If-Else* ile Tek/Çift Kontrolü

İlk olarak, bir döngüyü *If-Else* ifadesiyle kullanan bir örnekle başlayalım. Bu örnekte, bir sayı dizisini kontrol etmek ve her sayının çift mi tek mi olduğunu yazdırmak istiyoruz.

Bu örneği parça parça **C#** kullanarak oluşturacağız.

---

## 🧱 Adım 1: `numbers` Dizisini Tanımlama

Önce değerlendirmek istediğimiz tamsayı listesini tutacak `"numbers"` adlı bir dizi tanımlayalım.

Dizimiz şu sayıları içerir:  **1, 2, 3, 4 ve 5** . Bu, döngüyü eklemeden önceki başlangıç noktamızdır.

---

## 🔄 Adım 2: Diziyi Gezen *For* Döngüsü

`i = 0` (dizinin ilk indeksi) değerinden başlayıp `i < numbers.Length` (dizinin son indeksine kadar) koşuluyla ilerleyen bir *For* Döngüsü kullanacağız.

`i < numbers.Length` koşulu, `i` dizideki toplam eleman sayısından küçük olduğu sürece döngünün çalışmasını sağlar.

---

## 🧠 Adım 3: Döngü İçinde *If-Else* ile Tek/Çift Belirleme

Döngünün gövdesi içinde, mevcut sayının çift mi tek mi olduğunu kontrol etmek için bir *If-Else* ifadesi kullanırız. Bunu *Modulo* operatörünün yardımıyla yaparız.

Şimdi bu operatörün kullanımını daha ayrıntılı inceleyelim.

---

## ➗ Modulo Operatörü

*Modulo* operatörü, bir bölme işleminin **kalanını** hesaplar.

Bu örnekte, `numbers[i]` değerini ikiye böler ve kalanı döndürür:

* Kalan **0** ise, `"i"` indeksindeki değer **çifttir**
* Kalan  **0 değilse** , değer **tektir**

Örneğin `i = 3` olsun; bu, `numbers` dizisinin **dördüncü indeksi** demektir. Dizi indekslerini sıfırdan saydığımızı unutmayın; yani indeks üç, dizideki dördüncü öğedir.

İndeks üçte **4** sayısı vardır. *Modulo* operatörüyle, 4’ü 2’ye böldüğümüzde kalanını buluruz.

4’ün 2’ye bölümü 2’dir ve  **kalan yoktur** , bu yüzden bu sayı  **çifttir** .

---

## 🖥️ Sonuçları Konsola Yazdırma

Şimdi kod örneğimize geri dönelim.

*If* koşulu doğruysa, yani kalan yoksa, `console.writeline` kullanarak kontrol edilen değeri ve ardından `"is even"` ifadesini ekrana yazdırırız.

Koşul yanlışsa, bu bir kalan olduğu ve değerin tek olduğu anlamına gelir. Bunun için bir *Else* ifadesi kullanırız ve değeri konsola `"is odd"` ifadesiyle birlikte yazdırırız.

---

## 🔁 Örnek 2: *For* Döngüsü + *switch* ile Veri Değerlendirme

Artık döngülerin *If-Else* ifadeleriyle nasıl çalıştığını incelediğimize göre, şimdi de veriyi değerlendirmek için *switch* ifadeleriyle nasıl birleştirilebileceklerine geçelim.

Günün havasına göre nasıl hazırlanmanız gerektiğini söyleyen bir program oluşturduğunuzu hayal edin.

Havanın soğuk olması beklendiğinde `"dress warm today"` gibi bir mesaj gösterecek ve yağmurlu olacağı zaman `"bring your umbrella"` hatırlatmasını yapacaktır.

---

## 🌦️ `weatherForecasts` Dizisini Tanımlama

Farklı hava tahminlerini tutan diziyi tanımlayarak başlarız.

Dizimizin adı `"weatherForecasts"` ve üç string içerir:

* `"Sunny and warm"`
* `"Rainy with thunderstorms"`
* `"Cloudy and cold"`

---

## 🔄 Diziyi Gezen *For* Döngüsü

Ardından dizideki her bir öğe üzerinde yinelemek için bir *For* Döngüsü açarız.

---

## 🧾 Döngü İçinde *switch* ile Sınıflandırma

Sonra *For* Döngüsünün gövdesine bir *switch* ifadesi ekleyerek dizideki her elemanı sınıflandırırız.

*Switch* ifadesinin üç  *case* ’i olacaktır; her biri bir hava tahmini türü içindir.

Bir *case* eşleştiğinde, konsola bir mesaj yazdırılır.

---

## ☀️ Case 1: “Sunny and warm”

İlk  *case* , `"Sunny and warm"` hava tahminidir.

Bu eşleştiğinde ekranda şu mesaj görüntülenir:

“Today will be sunny and warm, so bring your sun glasses”.

---

## ⛈️ Case 2: “rainy with thunderstorms”

İkinci  *case* , `"rainy with thunderstorms"` tahminidir ve eşleşirse şu mesaj görüntülenir:

“Today will be rainy with thunderstorms, so bring your umbrella”.

---

## ☁️ Case 3: “Cloudy and cold”

Üçüncü  *case* , `"Cloudy and cold"` tahminini eşleştirir.

Tahmin buysa mesaj şu şekilde olur:

“Today will be cloudy and cold so wear warm clothes”.

---

## ✅ Kapanış

Bu videoda, problemleri çözmek için döngüleri kontrol yapılarıyla birlikte nasıl kullanacağınızı öğrendiniz.

Döngüleri kontrol yapılarıyla birleştirmeyi ustalaştırmak, bir geliştirici olarak çalışmalarınızın temel bir parçası olacaktır.
