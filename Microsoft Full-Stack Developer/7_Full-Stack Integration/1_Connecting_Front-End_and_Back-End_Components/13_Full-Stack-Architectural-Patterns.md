## 🏛️ Full-Stack Architectural Patterns

Bir web uygulamasının nasıl iletişim kurduğu ve parçalarını nasıl organize ettiği; ne kadar verimli, ölçeklenebilir ve kullanıcı dostu olabileceğini belirler. Bu temel yapıları anlayarak geliştiriciler, hem güçlü hem de sürdürülebilir (maintainable) sistemler oluşturur.

Bu videoda, **MVC** ve **microservices** gibi full-stack uygulamalarda kullanılan farklı mimari desenleri (architectural patterns) açıklayacağız.

---

## 🧱 Monolithic Architecture

Full-stack uygulamalardaki yaygın mimari desenleri keşfetmeye monolithic architecture ile başlayacağız. Bu, bir uygulamanın tüm parçalarının—front-end, back-end ve mantığın—tek bir bütün olarak birlikte çalıştığı bütüncül bir yaklaşımdır.

Bu sadelik, uygulamaların nasıl yapılandırıldığını anlamak için mükemmel bir başlangıç noktasıdır.

Monolithic architecture programları, front-end ve back-end’in sıkı şekilde entegre olduğu tek bir kod tabanlı uygulamalardır.

Örneğin, her şeyin—görevler (tasks), UI ve mantık—tek bir birim olarak çalıştığı bir to-do list uygulamasını düşünün. Uygulamanın her parçası diğerleriyle sıkı biçimde bütünleşmiştir ve uygulamanın tek bir varlık olarak test edilip dağıtılması (deploy) gerekir.

Bu yaklaşım küçük projeler için harikadır, ancak uygulama büyüdükçe yönetmesi zorlaşır. Örneğin monolithic architecture kullanırken, uygulamanın yalnızca bir bölümünü (mesela front-end’i) güncellemek; tüm uygulamayı tamamen test etmeyi ve yeniden deploy etmeyi gerektirdiği için zordur.

---

## 🖥️ Client-Server Architecture

Monolithic architecture sıkı entegre bir yaklaşımı vurgularken, client-server modeli front-end ile back-end’i farklı rollere ayırmaya odaklanır.

Client-server architecture, bir front-end client ile bir back-end server arasında iletişimi mümkün kılar. Entegrasyon, çoğu web uygulamasının nasıl çalıştığının temel yapısını oluşturur ve geliştirme ile dağıtımda daha fazla esneklik sağlar.

Örneğin, bir kütüphane sisteminde bir kitap aradığınızda bilgisayarınız (client) kitap detaylarını ister. Kütüphane veritabanı (server) ise bilgiyi sağlayarak yanıt verir.

Client-server modelini anlamak, bileşenler arasında iletişim kurmanın temelini oluşturmak için gereklidir.

---

## 🧩 Model-View-Controller (MVC)

Ancak uygulamanın back-end mantığını verimli şekilde organize etmek için yapılandırılmış bir yaklaşım gerekir. İşte burada Model-View-Controller, yani  **MVC** , devreye girer.

Model-View-Controller, bir uygulamayı üç birbiriyle bağlantılı parçaya ayıran bir tasarım desenidir:  **model** , **view** ve  **controller** .

Bu yapı; uygulama mantığını, kullanıcı arayüzünü ve kontrol mantığını düzenlemeye yardımcı olur ve uygulamayı daha sürdürülebilir ve ölçeklenebilir hâle getirir.

Bu parçaların birlikte nasıl çalıştığını anlamak için onları ayrıştıralım:

* **Model** , uygulamanın verisini ve iş mantığını (business logic) yönetir.
* **View** , bu veriyi kullanıcılara sunmaktan sorumludur; örneğin ürün detaylarını veya bir alışveriş sepetini görüntülemek gibi.
* **Controller** , bir köprü görevi görür; kullanıcı girdisini işler, modeli günceller ve yapılan değişiklikleri yansıtmak için view’i yeniler.

Bir online mağazayı düşünün. Model, ürün bilgilerini (isimler ve fiyatlar gibi) tutar. View, bu detayları web sitesinde kullanıcılara sunar.

“Add to Cart” seçtiğinizde controller sepeti günceller ve hem modelin hem de view’in bu eylemi yansıtmasını sağlar.

Bu ayrım, sistemi yönetmeyi ve ölçeklendirmeyi kolaylaştırır.

---

## 🧩 Microservices Architecture

Daha büyük projelerde uygulamaları daha küçük, bağımsız parçalara bölmek; üzerinde çalışmayı kolaylaştırabilir. Burada microservices mimari deseni kullanılabilir.

Microservices, daha büyük bir sistem içinde belirli işlevleri yerine getirmek için API’ler üzerinden birbirleriyle iletişim kuran, küçük ve bağımsız şekilde deploy edilebilen servislerdir.

Örneğin, bir film izleme platformunda kullanıcı hesapları, yayın (streaming) ve ödemeler için ayrı servisler bulunabilir.

Bu yapı, her servisi bağımsız şekilde yönetmeyi ve ölçeklendirmeyi kolaylaştırır.

---

## ✅ Kapanış

Bu videoda, MVC ve microservices gibi full-stack uygulamalarda kullanılan farklı mimari desenleri öğrendiniz.

Bu desenleri anlamak, her proje için doğru yapıyı seçmenizi sağlar; böylece uygulamalarınız esnek, verimli ve gelecekteki ihtiyaçlarla birlikte büyümeye hazır kalır.
