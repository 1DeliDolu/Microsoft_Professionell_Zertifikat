## 🧪 Rehberli Laboratuvar Videosu: JWT Güvenlik En İyi Uygulamalarını Uygulama

Bu laboratuvarda, *ASP.NET Core* uygulamasında JWT kimlik doğrulaması için güvenlik en iyi uygulamalarını uygulayacağız.

---

## ✅ Adım 1: Uygulamayı Kurma

İlk adımda uygulamayı kuruyoruz. Burada temel bir ASP.NET web uygulamam var ve **Program.cs** dosyasındayım. İlk yapmak istediğimiz şey, `builder.Services` nesnesi üzerinde **AddControllers** metodunu kullanmak; böylece uygulamada oluşturacağımız tüm controller’ları dahil edebileceğimizden emin oluyoruz.

---

## ✅ Adım 2: JWT Authentication’ı Yapılandırma

İkinci adımda JWT authentication’ı yapılandıracağız. Yine `builder.Services` nesnesini kullanacağız ve bu nesne üzerinde **AddAuthentication** metodunu çağıracağız. Hangi token türünü istediğimizi belirtmek için `Bearer` parametresini geçeceğiz, ardından token için options ekleyeceğiz.

Burada token ayarları için `TokenValidationParameters` nesnesini kullanarak token seçeneklerini oluşturduğumuzu görebilirsiniz.

Aşağıdaki değerlerin hepsinin **true** olmasını istiyoruz:

* `ValidateIssuer`
* `ValidateAudience`
* `ValidateLifetime`
* `ValidateIssuerSigningKey`

Şimdi burada bir hata görüyorum; onu düzelteceğim. Onu da `true` yapacağız. Bu değerlerin hepsinin `true` olması, token oluştururken ve doğrularken ihtiyaç duyduğumuz tüm validasyonları yaptığımızdan emin olmamızı sağlar.

Bu seçenekler ayarlanacak ve parametreleri oluştururken bunları geçeceğiz.

Sonrasında `ClockSkew` ayarlıyoruz. Bu, token’ın ne kadar süre “yaşıyor” sayılacağını belirlemek için kullanılan bir ayardır.

`ClockSkew`, sunucu zamanı ile istemci zamanı arasındaki farklara tolerans tanır. Burada bunu **0** olarak ayarlıyoruz; yani expiration gerçekleştiğinde saatlerin tam olarak eşleşmesi gerekir.

Varsayılan değer burada **5 dakika**dır; biz bunu **0** yaptığımız için güvenlik daha sıkı olabilir ama saatlerde kayma varsa bazı sorunlara da yol açabilir.

Son olarak yine `builder.Services` üzerinden bir singleton ekliyoruz ve `TokenService` için singleton ekliyoruz. `TokenService`, bu uygulamada token’ları daha kolay yönetebilmemiz için oluşturduğum bir servistir.

Bu singleton’ı `builder.Services` üzerinden ekleyerek, token service’i uygulamanın her yerinde kullanabiliriz.

---

## ✅ Adım 3: Korunan Endpoint’leri Oluşturma

Üçüncü adımda korunan endpoint’leri oluşturacağız. Bunun için  **AuthorizedController** ’a gidiyorum. Bu controller, güvenli endpoint’leri çağırmak için kullanılacak.

Burada `GetSecureData` adında bir metodumuz var ve bu metodun üzerinde hem **policy** hem de **role** property’si var. Policy’nin burada nasıl ayarlandığını görebilirsiniz.

Bu metod yalnızca admin olanlar tarafından çağrılabilir ve role da **admin** olmak zorundadır.

Policy, metodun hangi tür kullanıcılar tarafından erişilebileceğini sınırlar; roles ise bu kısıtlı policy içinde hangi rollerin geçerli olduğunu belirtir.

Policy ve roles birlikte kullanıldığında, yalnızca yetkili kullanıcıların bu metodu çağırabilmesini garanti ederiz.

Burada tabii ki sadece `"success"` mesajı ve admin role tanımıyla **OK** dönüyoruz; ama bu metodda istediğimiz her şeyi yapabiliriz.

Açıkça söylemek gerekirse, `GetSecureData` büyük ihtimalle gizli verileri döndüren bir metod olurdu ve bu yüzden yalnızca admin’lerin erişmesini istersiniz.

Bu `Authorize` özellikleri de bize bu kısıtlamaları sağlar.
