## 🧰 Pratik Asenkron Programlama Çözümleri Kullanma

Online bir satın alma işlemini tamamlamak üzere olduğunuzu ve *tam “satın al”a tıkladığınız anda* uygulamanın donduğunu hayal edin. Şimdi. Beklerken sinirleniyorsunuz; siparişinizin geçip geçmediğinden emin değilsiniz. Bunun neden olduğunu ve geliştiricilerin bunu nasıl önleyebileceğini hiç merak ettiniz mi?

Bu tür can sıkıcı anlar sadece rahatsız edici değildir; aynı zamanda uygulamada verimsiz görev yönetiminin bir işaretidir. Uygulamaların daha akıcı çalışmasını sağlamak için geliştiriciler güçlü bir çözüme yönelir:  **asenkron programlama** . Bu yaklaşım, karmaşık veya zaman alan işlemler yürütülürken bile uygulamaların duyarlı ve verimli kalmasına olanak tanır.

Bu videoda, pratik asenkron programlama çözümleri geliştirmeyi öğreneceksiniz.

---

## 🏗️ Groupeco Senaryosu: Konsol Uygulamasıyla Veri Çekme Simülasyonu

Groupeco adlı, çevre dostu ürünler sunan bir şirket için veri çekme senaryosunu simüle eden temel bir C# konsol uygulaması kurarak başlayalım.

Önce **FetchProductsAsync** adlı bir asenkron metot tanımlarsınız. Dönüş türünden önce gelen **async** anahtar sözcüğü, metodun asenkron olduğunu belirtir.

Sonra metodun içinde `Task.Delay 2000`, bir API çağrısını taklit eden iki saniyelik bir gecikmeyi simüle eder.

Son olarak, gecikmeden sonra metot, **eco bag** ve **reusable straw** dahil olmak üzere bir ürün listesi döndürür. **await** anahtar sözcüğü, gecikme tamamlanana kadar metodun yürütmesini duraklatır ve ana iş parçacığının ( *main thread* ) engellenmemesini sağlar.

---

## ▶️ `await` ile Asenkron Metodu Çağırma

Asenkron metodu oluşturduğumuza göre, devam etmeden önce metodun tamamlanması için **await** anahtar sözcüğüyle nasıl çağrılacağını inceleyelim.

Öncelikle, **display productsasync** adlı bir metot oluşturun; bu metot da **async** anahtar sözcüğünü kullanır.

Metodun içinde **FetchProductsAsync** metodunu **await** ile çağırın. **await** kullanarak metot, devam etmeden önce ürünlerin getirilmesini bekler.

Ardından ürün listesinin üzerinde döner ve her ürün adını konsola yazdırır.

Bu yaklaşımı kullanarak, veri arka planda getirilirken UI duyarlı kalır.

---

## 🧯 Hata Yönetimi Ekleme

**async** metotlar hazırken, bir şeyler ters giderse uygulamanın kararlı kalması için hata yönetimi ekleyeceğiz.

Öncelikle, **fetch products async** metodunu **try-catch** bloğu ekleyerek güncelleyin.

API çağrısı simülasyonu sırasında bir istisna oluşursa, **catch** bloğu `Console.WriteLine` kullanarak bir hata mesajı görüntüler.

Metot daha sonra boş bir liste döndürür; böylece uygulama çökmemiş olur.

Bu yaklaşım, kodunuzu daha sağlam hâle getirir ve gerçek dünya senaryolarına daha hazır yapar.

---

## 🔀 Birden Fazla Asenkron Görevi Eşzamanlı Çalıştırma

Hataları ele aldığımıza göre, şimdi birden fazla asenkron görevi eşzamanlı çalıştıracak kod ekleyelim.

Ürün verilerini ve yorumları aynı anda çekerek bu uygulamayı iyileştirebiliriz ve bunu gerçekleştirmek için C#’taki **async** fonksiyonlarını kullanacağız.

**FetchDataAsync** adlı bir metot oluşturun; bu metot  **FetchProductsAsync** ’i çağırır. Ayrıca, ürün yorumlarını bir veritabanından alan yeni bir metot olan  **FetchReviewsAsync** ’i oluşturun.

Bu metotların dönüş değerleri değişkenlerde saklanır.

Ardından, bir sonraki kod bloğuna geçmeden önce her iki görevin de tamamlanmasını beklemek için **task when all** fonksiyonunu kullanırsınız.

Bu yaklaşım, görevlerin paralel çalışmasını sağlayarak uygulamanın verimliliğini artırır.

---

## ✅ Kapanış

Bu videoda, C# kullanarak pratik asenkron programlama çözümleri geliştirmeyi öğrendiniz. Groupeco’nun ürün web sitesi için çözümümüzde, uygulamayı duyarlı tutmak amacıyla ürün verilerini asenkron şekilde çektik.

Bir **async** metot oluşturduk, hataları ele aldık ve birden fazla görevi aynı anda çalıştırdık; böylece uygulamanın verimli kalmasını sağladık.
