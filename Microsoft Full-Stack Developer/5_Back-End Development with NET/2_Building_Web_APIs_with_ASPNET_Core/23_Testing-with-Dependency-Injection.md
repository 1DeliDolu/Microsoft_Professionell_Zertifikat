## 🧪 Dependency Injection ile Test Etme

Kodunuzun veritabanları veya servisler gibi dış sistemlere bağlıyken iyi çalıştığından nasıl emin olursunuz? *Dependency Injection* ve *Mocking* kullanarak bileşenlerinizi izolasyon içinde test edebilir, kodunuzu daha esnek ve yönetimi daha kolay hâle getirebilirsiniz.

Bu videoda, *Dependency Injection* kullanan bileşenler için unit test’lerin nasıl yazılacağını açıklayacağız.

---

## 🧩 Unit Testing’e Giriş

Önce unit testing’i inceleyerek başlayalım.

 *Unit testing* , bir yazılım paketinin tek tek unit’lerinin veya bileşenlerinin, uygulamanın geri kalanından izole şekilde test edildiği bir yazılım test yöntemidir.

Bu, bug’ları erken yakalamaya yardımcı olur; yazılımın her parçasının sisteme entegre edilmeden önce doğru çalıştığından emin olmanızı sağlar ve genel kod kalitesini ve güvenilirliği artırır.

---

## 🎭 Mocking ile Dış Servislere Bağımlı Kodu Test Etmek

Unit testing’i tanımladığımıza göre, şimdi mocking’in dış servislere bağlı kodu test etmemize nasıl yardımcı olabileceğini inceleyelim.

 *Mocking* , gerçek servislerin davranışını taklit eden simüle edilmiş nesneler veya servisler oluşturmayı içerir; böylece belirli bileşenleri izole edip test edebilirsiniz.

Bu, testlerin daha hızlı, daha güvenilir olmasını ve yalnızca test edilen unit’in davranışına odaklanmasını sağlar.

Ayrıca her zaman erişilebilir olmayan veya pratik olmayan gerçek servisler olmadan sorunları bulmayı ve düzeltmeyi kolaylaştırır.

---

## 🧾 Bir Unit Test’i Tamamlama Adımları

Bir unit test’i tamamlamak için adımları inceleyelim.

İlk olarak, test ortamını ayarlayın: Bileşeninizi gerçek servisler yerine Mock servisleri kullanacak şekilde yapılandırın.

Bu, kodun izole şekilde test edilmesini sağlar.

Ardından, dış servisi simüle etmek için bir mocking framework’ü yapılandırın.

Mock servisler oluşturmak için framework’ü bir package manager ile yükleyin.

Sonra Mock servisi, testleriniz için gerekli spesifik verileri döndürecek şekilde yapılandırın.

Şimdi Mock’u, dış servisin davranışını simüle edecek şekilde ayarlayın ve test sırasında hangi verinin döneceğini tanımlayın.

Mock servisi bileşene inject edin ve gerçek dış servisin yerini almasını sağlayın.

Bu, testin izole edilmesini garanti eder.

Son olarak, bileşen Mock servis yerinde olacak şekilde çalışır; böylece test sırasında gerçek dünyadaki koşullar simüle edilir.

---

## ✅ Beklenen Davranışı Doğrulamak İçin Unit Test Yazma

Mock hazır olduğunda, Mock servis spesifik veri döndürdüğünde bileşenin beklenen şekilde davrandığını kontrol etmek için unit test’i yazalım.

Unit test’i yazmak için:

Önce testin input koşullarını tanımlayın ve Mock servisin bileşene ne sağlayacağını belirtin.

Sonra bileşen içinde input’u işleyen ve Mock servise bağlı olan metodu çağırın.

Son olarak, bileşenin output’unun Mock input’a göre beklenen sonuçla eşleştiğini doğrulamak için assertion’lar kullanın.

Testi yazdıktan sonra, unit test’i çalıştırmak ve testin geçip geçmediğini doğrulamak için bir test runner kullanın.

Test geçerse, bileşen Mock veriyle doğru davranıyordur.

Test başarısız olursa, hata mesajlarını inceleyerek sorunları tespit edin ve kodu düzeltin.

---

## 🛒 Örnek: Add to Cart Unit Test’i

Şimdi bir unit test’i tamamlama adımlarını göstermek için bir örnek inceleyelim.

Bir online alışveriş uygulaması üzerinde çalıştığınızı ve Add to Cart özelliği için bir unit test yazmak istediğinizi hayal edin.

Amaç, bir kullanıcı bir ürünü sepete eklediğinde farklı koşullar altında doğru davrandığından emin olmaktır.

Önce test için gereken her şeyi hazırlarsınız.

Bu örnekte bir test cart oluşturursunuz ve servislerin veya dependency’lerin yapılandırıldığından emin olursunuz.

Ayrıca test framework’ünüzün initialize edildiğini de doğrulayabilirsiniz.

Örneğin, boş bir cart object oluşturur ve ortamın cart’a item eklemeye izin verecek şekilde kurulduğundan emin olursunuz.

Sonra unit’in bağlı olduğu dış servisleri mock’larsınız; örneğin bir product database.

Bu mock, gerçek veritabanının davranışını simüle eder; böylece canlı sisteme erişmeden hangi veriyi döndüreceğini siz kontrol edebilirsiniz.

Örneğin, product database için bir mock oluşturursunuz ve sorgulandığında önceden tanımlanmış bir product döndürmesini sağlarsınız; örneğin product ID `101` ve product price `$20`.

Bu, gerçek veritabanına bağlanmayı önler.

Şimdi gerçek unit test’i yazarsınız.

Bu test mock object’leri kullanır ve Add to Cart fonksiyonunu çağırarak beklenen şekilde davranıp davranmadığını kontrol eder.

Doğru product’ın sepete eklendiğini ve artık doğru product detaylarını içerdiğini doğrularsınız.

Örneğin, mock product ID ile Add to Cart metodunu çağıran bir test yazarsınız.

Test, cart’ın artık doğru product ID, price ve quantity ile bir item içerip içermediğini kontrol eder.

Son olarak, test runner kullanarak testi çalıştırırsınız.

Test runner unit test’i execute eder, testin geçip geçmediğini raporlar ve geri bildirim sağlar.

Test başarısız olursa, neyin yanlış gittiğine dair detayları görürsünüz ve sorunları düzeltebilirsiniz.

Örneğin, bir test runner ile testi çalıştırırsınız ve Add to Cart işlevinin doğru çalışıp çalışmadığını veya bug olup olmadığını size söyler.

Dependency injection ve mocking framework’leri ile unit test kullanmak, kodunuzun dış servislere bağlı olsa bile beklendiği gibi çalıştığından emin olmanızı sağlar.

Bu yöntem, daha güvenilir ve sürdürülebilir yazılım geliştirmenize yardımcı olur.
