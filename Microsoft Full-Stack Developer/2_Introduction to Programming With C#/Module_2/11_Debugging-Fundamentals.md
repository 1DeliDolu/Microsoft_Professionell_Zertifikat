## 🐞 Hata Ayıklama Temelleri

Her programcı, deneyimi ne olursa olsun, hataların çözülmesi imkânsız göründüğü anlarda hayal kırıklığı yaşar. Hatta bilgisayar biliminin öncülerinden efsanevi *Grace Hopper* bile bu tür zorluklarla karşılaşmıştır.

1947’de, *Harvard Mark II* bilgisayarında çalışırken Hopper ve ekibi, bir rölenin içine sıkışmış bir güve (moth) bulmuş ve bunun sistemin hatalı çalışmasına neden olduğunu keşfetmiştir. Bu keşif, *debugging (hata ayıklama)* teriminin ortaya çıkmasına yol açmıştır.

Bu hikâye yalnızca tarihsel bir anekdot değildir. Hata ayıklamanın evrensel ve zamansız mücadelesini simgeler; ve etkili programcıları diğerlerinden ayıran temel bir beceridir.

Bu videoda, hata ayıklamanın temel ilkelerini açıklayacağız.

---

## 🧩 Debugging Nedir?

 *Debugging* , bir bilgisayar programındaki hataları veya  *bug* ’ları tespit etme ve giderme sürecidir.

Unutulmaması gereken şey şudur: hiçbir kod tamamen hatasız değildir. Hatalar programlamanın doğal bir parçasıdır ve en deneyimli geliştiriciler bile düzenli olarak hatalarla karşılaşır.

Şimdi, karşılaşabileceğiniz ilk hata türü olan *sözdizimi (syntax) hatalarıyla* başlayalım.

---

## ✍️ Sözdizimi Hataları

Sözdizimi hataları, programlama dilinin kurallarını ihlal eden kod hatalarıdır. Sözdizimi hataları, kodu dilin sözdizimi kurallarına uygun yazmadığınızda oluşur. Bunlar genellikle derleyici ( *compiler* ) veya yorumlayıcı ( *interpreter* ) tarafından yakalanır.

C#’ta sözdizimi hatasının ortaya çıkabileceği bir örneğe bakalım.

Diyelim ki `Start` adlı bir metodunuz var ve başlangıç değeri “welcome to my web application” olan `welcomeMessage` adlı bir string’iniz var. Ancak string’i düzgün kapatmayı unutuyorsunuz ve son tırnak işaretlerini eklemiyorsunuz.

Bu kodu derlemeye çalıştığınızda derleyici size şuna benzer bir hata verecektir:  **error CS1002, semicolon expected** ,  **error CS1513, bracket expected** .

Bunun nedeni, derleyicinin açılan tırnak işaretlerinin kapanmasını ve kapanış parantezlerinin de gelmesini beklemesidir. Derleyici kafası karışır ve bu nedenle kodun hata ayıklanması gerekir.

Neyse ki sözdizimi hataları genellikle en az endişe edilmesi gereken hatalardır; çünkü çoğunlukla derleyici tarafından yakalanırlar. Modern kod editörleri de çoğu zaman bunları nasıl düzelteceğinize dair öneriler sunar.

*Visual Studio Code* gibi araçlar, sözdizimi hatasının bulunduğu satır numarasını gösterebilir ve derleme yapmadan önce bile hataya neden olduğunu düşündüğü kodun altını kırmızıyla çizebilir.

Ayrıca artık çoğu editör, hataları görsel olarak fark etmenize yardımcı olan renk kodlaması kullanır. Bir hata olduğunda çoğu zaman bir şey “tuhaf” görünür. Zamanla ve pratik yaptıkça, derleme düğmesine basmadan önce bile bu hataları tanımaya başlayacaksınız.

Şimdi sözdizimi hatalarını ele aldık; sırada ele alması biraz daha bilgi ve uzmanlık gerektiren *çalışma zamanı (runtime) hataları* var.

---

## ⏱️ Çalışma Zamanı Hataları

Sözdizimi hataları derleme aşamasında ortaya çıkarken, çalışma zamanı hataları program çalışırken meydana gelir. Bu hatalar çoğu zaman programın çökmesine veya beklenmedik davranmasına neden olur.

Çalışma zamanı hataları, program çalışırken gerçekleştiremeyeceği bir işlemle karşılaştığında oluşur. Genellikle geçersiz işlemler veya bellek sorunlarından kaynaklanırlar.

Bunu göstermek için, doğru şekilde ele alınmadığında bir bölme işleminin çalışma zamanı hatasına yol açabileceği bir örneği düşünelim.

Burada, pay ( *numerator* ) ve payda ( *denominator* ) olmak üzere iki parametre alan `divideNumbers` adlı bir metodumuz var. Sorun şuradan kaynaklanır: programcı temel bir bölme işlemi kullanmıştır.

Kod, iki sayıyı uygun hata yönetimi olmadan bölmeye çalışırsa, bir kullanıcı sıfıra bölmeyi deneyebilir; bunun imkânsız olduğunu biliyoruz ve bu bir hataya yol açar.

Bu tür hatalar genellikle *.NET framework* gibi çalışma zamanı ortamı tarafından yönetilir. Ancak bu ortamlar her zaman bu hataları etkili şekilde ele alamaz; çoğu zaman programın aniden çökmesine sebep olurlar.

Çalışma zamanı hataları sinir bozucu olabilir, fakat genellikle açıktırlar; çünkü program başarısız olur ve sizi uyarır.

Asıl zorluk ise  *mantıksal hatalardadır* : çökme yaratmayan, ancak sessizce yanlış sonuç üreten gizli hatalar.

---

## 🧠 Mantıksal Hatalar

Mantıksal hatalar, programın mantığında yapılan ve yanlış sonuç üreten, ancak programın çökmesine neden olmayan hatalardır.

Mantıksal hataları bulmak genellikle en zordur; çünkü kodun sözdizimi doğrudur. Derleyici derler, hiçbir şey çökmez ve kod çalışıyor gibi görünür; fakat yanlış sonuç üretir.

Bir örneğe bakalım.

Burada `applyDiscount` adlı bir metodumuz var. İki parametresi var: `price` ve `discountPercentage`. Diyelim ki, bir indirim yüzdesini yanlışlıkla çarpma yerine çıkarma kullanarak uyguluyoruz.

Kod, sözdizimi hatası olmadan derlenir ve çalışma zamanı hatası da üretmez. Ancak yanlıştır; çünkü doğru sonuçları vermez.

Bu metodu $1.000 ve %50 indirim ile çağırmak size $850 vermelidir. Fakat programcı yanlışlıkla çıkarma içeren bir formül kullandığı için $985 sonucunu verir; bu bir hatadır.

Şimdi farklı hata türlerini belirlediğimize göre, hata ayıklama teknikleriyle bunları nasıl teşhis edip düzelteceğimize bakalım.

---

## 🧰 Hata Ayıklama Teknikleri

### ⛔ Breakpoint’ler

Hata ayıklama araç setinizdeki ilk araç  *breakpoint* ’lerdir. Breakpoint’ler, programın belirli noktalarda çalışmasını duraklatmanıza ve programın durumunu incelemenize olanak tanır.

Kodunuzda breakpoint’ler ayarlamak, kritik noktalarda yürütmeyi durdurmanıza ve programın farklı aşamalarında değişken değerlerini ve akışını incelemenize yardımcı olur.

*Visual Studio Code* gibi bir IDE’de breakpoint kullanmak için, bir şeylerin olduğundan şüphelendiğiniz ya da daha derin incelemek istediğiniz satıra breakpoint koyarsınız.

Breakpoint’lerin sözdizimi hataları için çalışmadığını unutmayın; çünkü breakpoint’ler program çalışırken yürütmeyi durdurur. Bu nedenle breakpoint’ler çalışma zamanı ve mantıksal hatalar için işe yarar.

### 🔎 Değişken Değerlerini İnceleme

Breakpoint’leri ayarlayıp kritik noktalarda kodu duraklattıktan sonraki adım, değişken değerlerini incelemektir.

Değişken değerlerini incelemek, kodunuzun farklı noktalarında değişkenlerin mevcut değerlerini kontrol etmenizi sağlar.

### 👣 Kodda Adım Adım İlerleme

Değişken değerlerini kontrol ettikten sonra, kod içinde adım adım ilerleyebilirsiniz.

Kodda adım adım ilerlemek, programınızı “satır satır” çalıştırmanıza ve davranışını yakından gözlemlemenize olanak tanır.

Kodun satır satır çalıştırılması, programın nasıl aktığını ve nerede yanlış gidebileceğini anlamanıza yardımcı olur.

### 🖨️ Mesaj Yazdırma

Bazen kodun çalışması ve mesajlar yazdırması gerekir; böylece içeriklerini inceleyebilirsiniz.

Bunun klasik yolu, çıktıya hata mesajları yazdırarak onları analiz etmektir.

Hiç bir uygulamada “bir şeyler başarısız oldu” deyip bir sürü teknik bilgi gösteren bir pencereyle karşılaştınız mı? Bu, bir programcının bir şekilde mesaj yazdırma eklemiş olmasından kaynaklanır.

Bunun en temel yolu, konsola yazdırmak için `Console.WightLine` ifadeleri eklemektir.

Bu, aynı anda birçok değişkeni incelemek istediğinizde veya kod akışını tek bir yazdırma içinde görmek istediğinizde faydalı olabilir.

Hata mesajlarını okumak ve anlamak, kodunuzun nerede ve neden başarısız olduğunu size söyleyebilir.

Mesaj yazdırırken, sorunları hızlıca bulmak ve düzeltmek için hata mesajlarındaki satır numaralarına ve açıklamalara dikkat edin.

Geleneksel yöntemler —hata mesajlarını okumak gibi— değerli olsa da, modern IDE’lerde daha da pratik bir yaklaşım vardır:  *debugger inspector* .

---

## ✅ Kapanış

Bu videoda, hata ayıklamanın temel ilkelerini inceledik.

 *Sözdizimi* , *çalışma zamanı* ve *mantıksal* hatalar gibi yaygın hata türlerini anlayarak, kodunuzda ortaya çıkan sorunları daha iyi öngörebilir ve ele alabilirsiniz.

Bu teknikleri uygulamaya ve pratik yapmaya devam ettikçe, karşınıza çıkan her türlü kodlama zorluğuyla başa çıkmak için gereken güveni ve becerileri kazanacaksınız.
