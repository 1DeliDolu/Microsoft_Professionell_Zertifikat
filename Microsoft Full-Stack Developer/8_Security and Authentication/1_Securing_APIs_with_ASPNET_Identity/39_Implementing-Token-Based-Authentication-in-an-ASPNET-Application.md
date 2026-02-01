## 🔑 ASP.NET Uygulamasında Token Tabanlı Kimlik Doğrulamayı Uygulama

Bu laboratuvarda, bir **ASP.NET** uygulamasında **ASP.NET Identity** kullanarak token tabanlı kimlik doğrulama uygulayacağız. Elimizde bir ASP.NET web uygulaması var ve işe **Controllers** klasöründeki `AccountController.cs` dosyasına bakarak başlayacağız. Bu uygulamada kullanıcıların ve rollerin zaten ekli olduğunu varsayacağız ve kullanıcı claim’lerini ayarlamak ve geri almak için bu API endpoint’lerinde onları kullanacağız.

---

## 1️⃣ Adım 1: Kullanıcıya Rol Atama

İlk adımda, bir kullanıcıya rol atayacağız. Burada `Register` adlı bir task içeren bir **POST** route’um var. Bu işlemi gerçekleştirmek için bir **ViewModel** göndereceğiz.

İlk olarak `User` adlı yeni bir değişken oluşturacağız ve bu, yeni bir `IdentityUser` olacak.

Kullanıcı adını `TestUserAtExample.com`, e-postayı da aynı şekilde `TestUserAtExample.com` olarak ayarlayacağız. Birçok sistem e-postayı kullanıcı adı olarak kullanır.

Bu kullanıcıyı oluşturacağız ve ardından kullanıcıya **admin** rolünü atayacağız.

İlk yaptığımız şey, `CreateAsync` çağırarak kullanıcıyı sistemde oluşturmaktır. Sonra da `AddToRoleAsync` çağıracağız ve bu örnekte kullanıcıya **admin** rolünü atayacağız.

Gerçek bir senaryoda kullanıcı adı ve e-posta dışarıdan alınır. Ancak burada hard-coded bir örnek yapacağız: bu kullanıcıyı oluşturup **admin** rolünü atayacağız.

---

## 2️⃣ Adım 2: Kullanıcıya Claim Ekleme

İkinci adımda, bu kullanıcıya claim ekleyeceğiz. Bu da başka bir **POST** endpoint olacak.

Bu endpoint’in adı `SetClaim`.

Burada önce kullanıcıyı bulacağız. Kullanıcı eklendikten sonra claim eklemek için `User` değişkenini kullanıcıyı bularak dolduracağız.

Burada yine `TestUserAtExample.com` kullanılıyor.

Ardından `UserManager` nesnesi üzerinden `AddClaimAsync` metodunu kullanacağız.

İlk parametre olarak az önce bulduğumuz kullanıcıyı geçeceğiz. Sonra yeni bir claim ekleyeceğiz; claim’in tipi `department` olacak ve bu örnekte departman değeri `HR`.

Yani bu endpoint ile kullanıcıya bu claim eklenecek.

---

## 3️⃣ Adım 3: Claim’leri Test Etme

Üçüncü adımda claim’leri test edeceğiz. Bu son endpoint; **GET** endpoint’i.

Buna `GetClaim` diyoruz.

Yine ilk satırda kullanıcıyı buluyoruz (`findNameByNameAsync`) ve sonra claim’leri alacağız.

Az önce bulduğumuz kullanıcıyı geçeceğiz ve `claims` değişkenini `UserManager` üzerinden `GetClaimsAsync` çağırarak dolduracağız.

Şimdi kullanıcının claim’e sahip olup olmadığını kontrol edeceğiz.

Bu bir Boolean değer olacak: Yes/No, True/False.

`Claims.Any` metodunu kullanarak claim type’ının `department` ve claim value’sunun `HR` olup olmadığına bakacağız.

Eğer kullanıcı claim’e sahipse konsola `AccessGranted` yazdıracağız, değilse `AccessDenied`.

Bu, kullanıcıyı belirli bir adla bulmamızı ve ardından ihtiyaç duyduğumuz kaynağa erişebilmesi için doğru claim’e sahip olup olmadığını belirlememizi sağlar.

---

## ✅ Özet

Bu üç endpoint’i kullanarak:

* Sistemde bir kullanıcı oluşturabilir,
* Bu kullanıcıya bir claim atayabilir,
* Ve bu kullanıcının herhangi bir kaynağa erişim sağlamak için doğru claim’e sahip olup olmadığını kontrol edebiliriz.
