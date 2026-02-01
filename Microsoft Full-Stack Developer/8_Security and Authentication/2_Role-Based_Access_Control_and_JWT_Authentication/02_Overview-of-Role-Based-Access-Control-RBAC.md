## 🛡️ Rol Tabanlı Erişim Denetimi (RBAC) Rolüne Genel Bakış

Kaynaklara erişimi kontrol etmek, küçük ekiplerden büyük organizasyonlara kadar her sistemde hayati önem taşır. Rol tabanlı erişim denetimi ya da  *RBAC* , kullanıcıların rollerine göre uygun erişime sahip olmasını sağlayarak izinlerin verimli şekilde yönetilmesini sunar. Bu videoda, rol tabanlı erişim denetimini ve bir uygulamada izinleri ve kaynakları yönetmedeki rolünü tanımlayacağız.

Başlayalım: Rol tabanlı erişim denetiminin ne olduğunu ve kaynaklara erişimi yönetmeye nasıl yardımcı olduğunu tanımlayarak ilerleyelim.  *RBAC* , bir organizasyon içindeki bireysel kullanıcıların rollerine göre sistemlere, verilere veya kaynaklara erişimi kısıtlamak için kullanılan bir güvenlik modelidir. RBAC kullanırken, her kullanıcıya tek tek izinler atamak yerine, kullanıcıları *admin* veya *employee* ya da *users* gibi, her birinin önceden belirlenmiş izinlere sahip olduğu rollere atarsınız. Bu yaklaşım, özellikle çok sayıda kullanıcı yönetirken erişim yönetimini basitleştirir.

## 👥 Rollerle İzin Atama Mantığı

RBAC’in nasıl çalıştığını anladığımıza göre, rollerin bir uygulamaya izin atamak için nasıl kullanıldığına dair temel kavramları inceleyelim. RBAC kullanıldığında, kullanıcılara sistem içinde ne yapabileceklerini tanımlayan roller atanır. Her kullanıcıya tek tek izin vermek yerine, *admin* veya *employee* gibi benzer sorumluluklara sahip kullanıcıları rollerde gruplar ve izinleri rol seviyesinde atarsınız. Yeni bir kullanıcı katıldığında, ona yalnızca uygun rolü (*admin* ya da *author* gibi) atarsınız ve otomatik olarak doğru izinleri alır; bu da tutarlılık sağlar ve yanlış izin atamalarını önler.

## 🔐 JSON Web Token (JWT) ve RBAC

RBAC’i anlamaya yardımcı olan bir diğer temel kavram  *JSON Web Token* ’lardır. Hatırlayın: *JSON Web Token* ya da  *JWT* , kimliği doğrulamak için bir sunucu ile kullanıcı arasında değiş tokuş edilen, kompakt ve güvenli bir tokendır. Rol tabanlı erişim denetiminde JWT’ler, kimlik doğrulamasından sonra kullanıcı rollerini ve izinlerini güvenli şekilde iletir. Giriş yapıldığında sunucu, kullanıcının kimliğini ( *ID* ), rollerini ve diğer metaverileri içeren imzalı bir JWT üretir. Bu token istemci tarafında saklanır ve kullanıcının sonraki isteklerinde isteğe dahil edilir. RBAC’te JWT kullanmak sistemi hem daha hızlı hem de daha güvenli hâle getirir.

## 🧾 RBAC ve Claims-Tabanlı Erişim Denetiminin Karşılaştırılması

Şimdi RBAC’i *claims-based access control* ile karşılaştıralım. Claims tabanlı erişimin daha spesifik bir kontrol sunduğunu göreceksiniz. Claims kullanarak, RBAC’te olduğu gibi kullanıcıları rollere göre gruplamak yerine, kullanıcılara tek tek izinler atayarak sistem içinde daha ayrıntılı (granüler) izinler tanımlayabilirsiniz. Örneğin bir İK ( *HR* ) uygulamasında, bir kullanıcıya kişisel bilgileri düzenleme izni veren bir *claim* verilebilirken, başka bir kullanıcı yalnızca raporları görüntüleme  *claim* ’ine sahip olabilir. RBAC içinde ise kullanıcılara, zaten izinleri içeren roller atanır; bu, yönetimi daha basit hâle getirir ancak claims’e kıyasla daha az esnektir.

## 🧩 ASP.NET Core’da RoleManager ile Rol Yönetimi

Son olarak, *ASP.NET Core* içindeki  *RoleManager* ’ın rolleri yönetmeye ve kullanıcılara atamaya nasıl yardımcı olduğunu ele alalım. Hatırlayın:  *RoleManager* , rollerin oluşturulmasına ve yönetilmesine yardımcı olan *ASP.NET Core* sınıfıdır. Bir kullanıcı  *ASP.NET Core* ’da oturum açtığında, rolünü atamak için *RoleManager* kullanır ve bu rolü içeren bir JWT oluşturur. Örneğin, yeni bir kullanıcı *RoleManager* aracılığıyla *admin* rolüne atanırsa, o role bağlı tüm izinleri anında alır. JWT token’ı *admin* rolünü içerir; bu da giriş yaptığı anda sistemi yönetebilmesini sağlar. Bu süreç zaman kazandırır ve izin hatası riskini azaltır.

## 🧑‍💼 Yaygın Kullanıcı Rolleri: Admin, Manager, Customer

RBAC’in temel kavramlarını incelediğimize göre, şimdi bir sistemdeki birkaç yaygın kullanıcı rolüne bakalım.

İlk olarak *admin* rolüyle başlayalım. Admin’lerin sistem üzerinde tam kontrole ihtiyacı vardır; buna ürünleri, siparişleri ve kullanıcıları yönetme yeteneği de dahildir. Bir admin giriş yaptığında, JWT token’ı admin rolünü içerir ve bu da ona tüm temel özelliklere erişim sağlar.

Sonraki rol *manager* rolüdür. Manager’lar operasyonları denetlemekten ve iş akışlarının sorunsuz ilerlemesini sağlamaktan sorumludur. Etkin şekilde izlemek ve yönetmek için ürün listelerini görüntüleyebilir ve sipariş listelerine erişebilirler. Bir manager giriş yaptığında, JWT token’ı manager rolünü içerir ve tam admin erişimi olmadan yükseltilmiş izinler sağlar.

Son olarak *customer* rolü vardır. Customer’ların yalnızca ürün listesini gezme ve sipariş verme erişimine ihtiyacı vardır. Bir customer giriş yaptığında, sahip olduğu JWT token’ı onu ürünlere göz atma ve satın alma ile sınırlar.

## ✅ Özet

Bu videoda, rol tabanlı erişim denetimini ve bir uygulamada izinleri ve kaynakları yönetmedeki rolünü öğrendiniz. Sistemler, izinleri roller içinde gruplayarak ve bunları JWT token’ları aracılığıyla güvenli biçimde doğrulayarak erişimi verimli şekilde yönetebilir; böylece risk azalır ve operasyonlar kolaylaşır.
