## 🧾 Kullanıcı Kayıt Süreci

Bir web sitesinde hesap oluşturduğunuzda, çeşitli güvenlik adımları kişisel bilgilerinizi korumak için birlikte çalışır. Bu süreçler, kayıt formuna girdiğiniz verilerin güvenli kalmasını sağlar. Bu sistemlerin nasıl çalıştığını anlamak, güvenli ve kullanıcı dostu uygulamalar geliştirmek için önemlidir.

Bu videoda, **ASP.NET Identity** kullanarak kullanıcı kaydında yer alan adımları; form gönderimi, parola hash’leme ve e-posta doğrulaması dâhil olmak üzere açıklayacağız.

---

## 📨 Form Gönderimi

Bir web sayfasında hesap oluştururken bir kayıt formu gönderildiğinde tipik olarak neler olduğuna bakalım.

Örneğin, çevrim içi bir mağazaya kayıt olurken e-postanızı ve parolanızı girip formu göndermek için **Create** seçeneğini seçebilirsiniz. Form gönderildiğinde sistem, hesabın oluşturulması için işlemleri başlatır.

Bu bilgiler daha sonra güvenli şekilde sunucuya gönderilir; sistem burada ayrıntılarınızı işler ve bir sonraki adım için hazırlar.

---

## 🔐 Parolanın Hash’lenerek Güvenli Saklanması

Form gönderildikten sonraki adım, parolayı **parola hash’leme** kullanarak güvenli biçimde saklamaktır.

Parola hash’leme, düz metin bir parolayı bir algoritma kullanarak sabit uzunlukta bir karakter dizisine (hash) dönüştürür; bu da parolayı güvenli hâle getirir ve tersine mühendisliği zorlaştırır.

Parolanız sunucuya ulaştığında, onu düz metin olarak depolamak ciddi bir güvenlik riski olurdu; çünkü saldırganlar veya yetkisiz kullanıcılar sisteme erişim sağlarsa parolayı kolayca okuyabilirler.

Bunu önlemek için sistem, parolayı okunamaz bir formata dönüştüren parola hash’leme kullanır. Bu sayede birisi veritabanına erişim sağlasa bile gerçek parolanıza değil, yalnızca hash’lenmiş sürümüne erişebilir.

---

## ✉️ E-posta Doğrulaması

Parolanız güvence altına alındıktan sonra, bir sonraki adım girilen e-postanın geçerli olduğunun ve size ait olduğunun doğrulanmasıdır.

Bu aşamada sistem, hesabın gerçekten size ait olduğunu doğrulamak için bir **onay e-postası** gönderir. Bu adımı, e-postanıza gelen bir **Verify Account** bağlantısını gördüğünüzde tanıyabilirsiniz.

Bu bağlantıyı seçmek e-postanın size ait olduğunu kanıtlar; sahte hesapları engeller ve kaydı yapan kişinin gerçekten siz olduğunuzu doğrular.

---

## 🗄️ Doğrulanmış Verilerin Güvenli Şekilde Depolanması

Son adım, e-posta doğrulandıktan sonra e-posta verilerinin güvenli şekilde saklanmasıdır.

Bunu yapmak için  **ASP.NET Identity** , hash’lenmiş parola ve e-posta doğrulama durumu gibi bilgileri güvenli bir veritabanında düzenler ve depolar; böylece hesabınızın güvenliği sağlanmış olur.

---

## ✅ Özet

Bu videoda, **ASP.NET Identity** kullanarak kullanıcı kaydında yer alan adımları; form gönderimi, parola hash’leme ve e-posta doğrulaması dâhil olmak üzere öğrendiniz.

Kullanıcı kaydındaki her adım, parolaları güvence altına almaktan e-posta adreslerini doğrulamaya kadar, kullanıcı verilerini güvende tutmada hayati bir rol oynar.
