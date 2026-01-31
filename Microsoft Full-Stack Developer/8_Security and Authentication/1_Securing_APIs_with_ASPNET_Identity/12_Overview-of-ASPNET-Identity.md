## 🧾 ASP.NET Identity’ye Genel Bakış

 **ASP.NET** , Microsoft tarafından geliştirilen, dinamik web uygulamaları ve servisleri oluşturmak için yaygın olarak kullanılan bir web geliştirme çatısıdır. Geliştiricilerin, temel olarak **C Sharp** kullanarak güçlü, ölçeklenebilir ve güvenli web uygulamaları oluşturmasına olanak tanır.

 **ASP.NET Identity** , **ASP.NET** çatısı içinde yer alan bir üyelik sistemidir; kullanıcı kimlik doğrulamasını ( *authentication* ), yetkilendirmeyi ( *authorization* ) ve rolleri yöneterek web uygulamalarına güvenli erişim sağlar.

Bu videoda,  **ASP.NET Identity** ’nin temel özelliklerini ve bir ASP.NET uygulamasında kullanıcı kimlik doğrulaması, yetkilendirme ve kullanıcı rollerini yönetmedeki rolünü belirleyeceğiz.

---

## 🔐 Kullanıcı Kimlik Doğrulama

Şimdi  **ASP.NET Identity** ’nin ilk temel özelliğini, yani *kullanıcı kimlik doğrulamayı* inceleyerek başlayalım.

Kullanıcı kimlik doğrulama, her güvenli sistemin temelidir. Kimlik doğrulama, yani  **AuthN** , bir kullanıcıya bir sisteme veya uygulamaya erişim izni verilmeden önce kullanıcının kimliğini doğrular.

Örneğin bir web sitesine giriş yaptığınızda kullanıcı adınızı ve parolanızı girersiniz. Sistem daha sonra, bilgilerin mevcut bir hesapla eşleşip eşleşmediğini kontrol ederek gerçekten siz olup olmadığınızı doğrular.

Kimlik doğrulama, kimliğinizi doğrular ve yalnızca yetkili kullanıcıların uygulama içindeki kişisel verilerinize veya güvenli özelliklere erişebilmesini sağlar.

---

## 🧑‍⚖️ Yetkilendirme

Sistem, kimlik doğrulama yoluyla kullanıcıyı belirledikten sonra, kullanıcının hangi eylemleri yapmasına izin verildiğine karar vermelidir. İşte bu noktada *yetkilendirme* devreye girer.

Yetkilendirme, diğer adıyla  **AuthZ** , bir kullanıcı kimliği doğrulandıktan sonra kullanıcının ne yapabileceğini kontrol eder. Başka bir deyişle, rolüne veya izinlerine göre erişimini yönetir.

Örneğin bir iş yeri uygulamasında, bir çalışan yalnızca kendi kişisel bilgilerini görüntüleyebilirken, bir yönetici tüm ekip için izin taleplerini onaylayabilir.

---

## 👥 Kullanıcı Rolleri

Şimdi  **ASP.NET Identity** ’de kullanıcı rollerinin nasıl çalıştığını inceleyelim.

Her kullanıcıya tek tek izin atamak yerine, roller aynı izinlere sahip kullanıcıları gruplamanızı sağlar ve yönetimi kolaylaştırır.

Kullanıcı rolleri, kullanıcı gruplarına atanan önceden tanımlanmış bir izin kümesidir. İzinleri tek tek vermek yerine, rollere atarsınız.

Bir çevrim içi mağazayı düşünün: satıcılar envantere ürün ekleyebilirken, müşteriler ürünlere göz atıp satın alma işlemi yapabilir. Her rolün farklı yetenekleri vardır.

---

## 🧷 Kimlik Doğrulamayı Geliştiren Özellikler

Temel kullanıcı yönetimini ele aldığımıza göre,  **ASP.NET Identity** ’nin kimlik doğrulamayı belirli özelliklerle nasıl geliştirdiğini inceleyebiliriz.

Örneğin  **çok faktörlü kimlik doğrulama (MFA)** , parolanıza ek olarak cihazınıza gönderilen bir kodu girmeniz gibi ikinci bir adım gerektirerek ekstra bir güvenlik katmanı ekler.

**ASP.NET Identity** ayrıca bir **parola kurtarma** özelliği sağlar. Bu özellik, parolanızı unuttuğunuzda genellikle e-postanıza gönderilen bir bağlantı aracılığıyla parolanızı sıfırlamanıza izin verir.

Son olarak, kayıt sırasında gerçekten kaydolduğunuzu doğrulamak için bir **onay e-postası** alırsınız.

---

## 🧩 Modüler Entegrasyonlar

 **ASP.NET Identity** ’nin bir diğer özelliği de  *modüler entegrasyonlardır* .

**MFA** ve parola kurtarma gibi güvenlik özelliklerini kurduktan sonra,  **ASP.NET Identity** ’nin ASP.NET Core gibi daha geniş bir çatıya nasıl uyduğunu incelemek önemlidir.

ASP.NET Core,  **ASP.NET Identity** ’yi destekleyen temel çatıdır ve güvenli, çapraz platform uygulamaları oluşturmak için gereken yapıyı sağlar.

Bir uygulama büyüdükçe, kullanıcıların Google veya Facebook hesaplarıyla oturum açmasına izin verebilirsiniz; bu, uygulamanızı güvenli tutarken kullanıcılar için süreci kolaylaştırır.

ASP.NET Core entegrasyonu, herhangi bir ASP.NET Core uygulamasında güvenli ve özelleştirilebilir kimlik yönetimini sağlar.

---

## 🗄️ Veri Depolama

Çapraz platform yeteneklerinin yanı sıra, **ASP.NET Identity** veri depolama açısından da değerlidir.

 **ASP.NET Identity** , parolalar ve roller gibi kullanıcı bilgilerini bir veritabanında güvenli biçimde depolamak için  **Entity Framework** ’ü kullanır.

 **Entity Framework (EF)** , .NET ekosisteminde geliştiricilerin veritabanlarıyla nasıl etkileşime geçtiğini basitleştiren bir çatıdır.

 **ASP.NET Identity** , veritabanında parolalar ve roller gibi kullanıcı verilerini güvenli şekilde depolamak için  **Entity Framework** ’ü kullanır. Bu kurulum, karmaşık SQL sorguları yazmadan veritabanı etkileşimlerini kolayca yönetmeyi sağlar; böylece veri yönetimi süreci daha akıcı hâle gelir.

Örneğin, bir kullanıcı bir e-ticaret sitesine kayıt olduğunda; e-posta ve parola gibi bilgileri **Entity Framework** kullanılarak güvenli şekilde saklanır ve daha sonra bu bilgiler kolayca geri alınabilir.

 **Entity Framework** , geliştiricilerin veritabanlarıyla nesneler üzerinden çalışmasına izin vererek veri kaydetme ve geri getirme gibi işlemleri çok daha kolaylaştırır.

SQL sorguları yazmak yerine, kullanıcı verilerini **C-sharp** kodu kullanarak yönetebilir, böylece geliştirme sürecini daha akıcı hâle getirebilirsiniz.

---

## ✅ Özet

Bu videoda,  **ASP.NET Identity** ’nin temel özelliklerini ve bir ASP.NET uygulamasında kullanıcı kimlik doğrulaması, yetkilendirme ve kullanıcı rollerini yönetmedeki rolünü öğrendiniz.

**ASP.NET Identity** kullanarak, uygulamalarınızın güvenli ve kullanıcı dostu olmasını sağlayabilir; gelecekte daha karmaşık özellikler için bir temel oluşturabilirsiniz.
