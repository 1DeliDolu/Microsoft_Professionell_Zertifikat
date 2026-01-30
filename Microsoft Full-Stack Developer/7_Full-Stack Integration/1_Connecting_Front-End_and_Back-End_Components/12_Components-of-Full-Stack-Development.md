## 🧩 Components of Full-Stack Development

Eksiksiz bir uygulama geliştirmek, bir yapboz (puzzle) birleştirmeye benzer; her parça—front-end, back-end, veritabanı, API’ler ve sürüm kontrolü—birbirine sorunsuz şekilde oturur. Bu bileşenlerin rollerini anlamak, verimli ve gerçek dünyada kullanılan sistemler oluşturmanın temelidir.

Bu videoda, full-stack geliştirmenin bileşenlerini ve bir uygulama içindeki rollerini belirleyeceğiz.

---

## 🖥️ Front-End: Kullanıcının Deneyimlediği Katman

Full-stack geliştirmenin temel bileşenlerini, kullanıcıların deneyimlediği uygulama parçası olan front-end ile başlayarak inceleyelim.

Front-end, kullanıcıların uygulamayla etkileşime girdiği kısımdır. Düğmeler, metinler, görseller, animasyonlar ve düzenler (layouts) gibi gördüğünüz, tıkladığınız veya dokunduğunuz her şeyi içerir.

Front-end, C Sharp ile yazılmış zengin ve etkileşimli web uygulamaları oluşturmayı sağlayan **Blazor** gibi teknolojiler kullanılarak geliştirilir. Örneğin, bir formda “sign-up” seçtiğinizde anında bir başarı mesajının görüntülenmesi gibi.

Front-end etkileşimleri yönetirken, veriyi işlemek ve işlevselliği yürütmek için back-end’e ihtiyaç duyar.

---

## 🧠 Back-End: Sunucu Tarafı Mantık ve API’ler

Back-end, veri işleme ve API’leri yöneten sunucu tarafı (server-side) mantıktır.

Blazor uygulamalarında back-end, veri işleme yapmak ve front-end’in tüketmesi için endpoint’ler tanımlamak amacıyla **.NET Minimal APIs** gibi teknolojiler kullanır.

Örneğin bir kullanıcı uygulamaya giriş yaptığında, back-end veritabanında saklanan bilgileri kullanarak kullanıcı adı ve parolayı doğrular.

.NET’teki Minimal API’ler sunucu mantığını sadeleştirir ve hızlı, verimli işlemeyi mümkün kılar.

Front-end ve back-end, bilgiyi depolamak ve geri almak için veritabanlarıyla birlikte çalışır.

---

## 🗄️ Database: Kalıcı Veri Depolama ve Organizasyon

Şimdi full-stack geliştirmede veritabanının rolünü inceleyelim.

Veritabanı, bir uygulamanın verilerini uzun vadeli kullanım için depolayan ve düzenleyen bir yazılım sistemidir. Kullanıcı profilleri veya ürün detayları gibi kritik bilgileri saklar.

**SQL Server** gibi bir veritabanı .NET uygulamalarıyla entegre olur ve veriyi almayı (retrieve) kolaylaştırır.

Örneğin bir alışveriş uygulaması, uygulamayı kapattıktan sonra bile sepetinizde ne olduğunu hatırlamak için veritabanını kullanır.

---

## 🔌 API: Front-End ile Back-End Arasında Yapılandırılmış İletişim

Full-stack geliştiriciler, front-end ile veritabanını back-end üzerinden birbirine bağlayan API’lerle de çalışır.

 **API (Application Programming Interface)** , farklı yazılım uygulamalarının birbiriyle iletişim kurmasını sağlar. Front-end ile back-end arasında yapılandırılmış bir iletişim mekanizmasıdır.

Back-end, front-end’in tükettiği API endpoint’lerini sunar. API’ler, front-end’in back-end’den ürün detayları veya kullanıcı verisi gibi bilgileri istemesine olanak tanır.

Örneğin internette bir ürün aradığınızda, API’ler veritabanının doğru sonuçlarla yanıt vermesini sağlar.

---

## 🔄 Version Control: Değişiklik Takibi ve Ekip Çalışması

Tüm bu bileşenleri yönetmek; değişiklikleri izlemek ve ekipçe çalışmak için sürüm kontrol araçlarını gerektirir.

Sürüm kontrolü, bir dosyada veya dosya kümesinde zaman içinde yapılan değişiklikleri kaydeden bir sistemdir; böylece daha sonra belirli sürümlere geri dönebilirsiniz.

**Git** gibi araçlar, bir geliştirme ekibi genelinde kod değişikliklerini takip etmek ve yönetmek için kullanılır. Örneğin bir geliştirici back-end’i güncellerken, başka bir geliştirici front-end üzerinde çalışabilir.

Git, bu güncellemelerin çakışmamasını sağlar ve projenin sorunsuz çalışmasına yardımcı olur.

---

## ✅ Kapanış

Bu videoda, full-stack geliştirmenin bileşenlerini ve bir uygulama içindeki rollerini öğrendiniz.

Bu temel bileşenleri anlamak; dinamik, kullanıcı odaklı ve uyarlanabilir uygulamalar oluşturmanız için sizi gerekli bilgiyle donatır.
