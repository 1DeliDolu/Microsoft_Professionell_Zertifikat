## 🏗️ ASP.NET Identity Mimarisi

Uygulamanıza erişimi kontrol etmek, hem güvenlik hem de kullanıcı deneyimi açısından kritik öneme sahiptir.  **ASP.NET Identity** ’nin temel bileşenlerini anlayarak, herhangi bir uygulama içinde kullanıcıları, rolleri ve kimlik doğrulamayı güvenli şekilde yönetmek için gereken becerileri kazanacaksınız.

Bu videoda,  **ASP.NET Identity** ’nin temel bileşenlerini ve kullanıcıları, rolleri ve kimlik doğrulamayı yönetmek için nasıl birlikte çalıştıklarını açıklayacağız.

Her bir bileşeni incelemeden önce, bu araçların **eksiksiz bir ekosistem** oluşturmak için birlikte çalıştığını anlamak önemlidir. Her bileşen, kullanıcıları yönetmede ve uygulamanın güvenliğini artırmada belirli bir role sahiptir.

Şimdi,  **ASP.NET Identity** ’nin temel bileşenlerinin bu genel yapıya nasıl katkıda bulunduğunu inceleyelim; **User Manager** ile başlayalım.

---

## 👤 User Manager

 **User Manager** , **ASP.NET Identity** içinde uygulamanızdaki kullanıcı hesaplarıyla çalışmaktan sorumlu bir bileşendir.

 **User Manager** , kullanıcı oluşturma, silme ve güncelleme, parola ayarlama ve kullanıcı  *claim* ’lerini yönetme gibi işlemleri yürütür.

Bir hesap oluşturabildiğiniz bir uygulamayı düşünün. Bunu mümkün kılan  **User Manager** ’dır. Profilinizi oluşturmayı ve güncellemeyi yönetir ve gerekirse hesabınızı kaldırmayı sağlar.

---

## 🔑 Sign-in Manager

**User Manager** hesap oluşturmayı yönettiği için, kullanıcıların iddia ettikleri kişi olduklarını doğrulayacak bir yönteme de ihtiyacımız vardır. Bunun için **Sign-in Manager** kullanırız.

 **Sign-in Manager** , kullanıcı kimlik doğrulamasını yönetme sorumluluğunu üstlenen, giriş ve çıkış işlemlerini gerçekleştiren ve yalnızca geçerli kimlik bilgilerine sahip kullanıcıların oturum açabilmesini sağlayan bir **ASP.NET Identity** bileşenidir.

Bir uygulamaya kullanıcı adınız ve parolanızla giriş yaptığınız bir anı düşünün.  **Sign-in Manager** , kimlik bilgilerinizi kontrol eden ve sizi güvenli şekilde oturum açtıran sistem parçasıdır.

---

## 🧑‍⚖️ Role Manager

Kullanıcıları sisteme giriş yaptırdıktan sonra, uygulama içinde nereye erişebileceklerini kontrol etmemiz gerekir. Bunu, **Role Manager** adlı **ASP.NET Identity** bileşenini kullanarak kullanıcılara farklı roller atayarak yaparız.

 **Role Manager** , roller oluşturarak ve kullanıcıları bu rollere atayarak, uygulama içinde farklı kullanıcıların neler yapabileceğini tanımlamaya yardımcı olur.

Bir uygulamada, **Role Manager** bazı kullanıcılara sistemi yönetebilmeleri için *admin* rolünü atayabilir; diğerlerine ise yalnızca belirli özelliklere erişmelerini sağlayan roller verilebilir.

Örneğin, bir şirketin dahili sisteminde her çalışanın aynı izinlere sahip olmasını istemezsiniz. Yöneticiler hassas verileri yönetebilmeliyken, normal çalışanlar yalnızca belirli bilgilere erişebilmelidir.

**Role Manager** bunu mümkün kılar.

---

## 🗄️ IdentityDB Context

Son olarak, tüm bu kullanıcı rolü bilgilerini bir veritabanında güvenli şekilde saklamamız gerekir. Bunu, **IdentityDB Context** bileşeniyle yaparız.

 **IdentityDB Context** , kullanıcılar, roller ve  *claim* ’lerle ilgili bilgilerin güvenli biçimde depolanmasını yönetir.

 **IdentityDB Context** , bir uygulamayı bir veritabanına bağlar ve kullanıcı ayrıntılarını, rolleri,  *claim* ’leri ve izinleri güvenli şekilde depolayıp geri alır.

Örneğin, **IdentityDB Context** kullanıcı kimlik bilgileri veya erişim seviyesi gibi bilgileri, gelecekte kullanılmak üzere güvenli bir veritabanında saklar. Bu kurulum, kullanıcı verilerinin gelecekteki oturum açmalar için erişilebilir kalmasını sağlar.

---

## ✅ Özet

Bu videoda, **ASP.NET Identity** bileşenlerini ve bir uygulama içinde kullanıcıları, rolleri ve kimlik doğrulamayı yönetmek için nasıl birlikte çalıştıklarını öğrendiniz.

Girişleri kimlik doğrulayarak, roller atayarak ve kullanıcı verilerini güvenle depolayarak, **ASP.NET Identity** her şeyin sorunsuz biçimde çalışmasını sağlayan araçları sunar.
