## 🧪 ASP.NET Uygulamasında Rolleri ve Claim’leri Yönetme

Bu laboratuvarda, **ASP.NET Identity** kullanarak bir **ASP.NET** uygulamasında rol ve claim yönetimini uygulayacağız.

---

## 1️⃣ Adım 1: Çekirdek Uygulamada Rolleri Yapılandırma

İlk adımda, rolleri çekirdek uygulamada yapılandıracağız ve bunu `program.cs` içinde yapacağız.

Uygulama başladığında çalışan program bölümüne bu kodun tamamını doğrudan ekleyeceğiz.

İlk olarak, **RoleManager** nesnesini `RoleManager<IdentityRole>` tipiyle oluşturacağız ve bunu yapmak için **ASP.NET Core Identity** kütüphanesini kullanacağız.

Bu kütüphanede, `services.getService` metodunu kullanarak bu RoleManager nesnesini oluşturacağız.

RoleManager nesnesi oluşturulduktan sonra, rolleri (**admin** ve  **user** ) yoksa oluşturmak için `CreateAsync` kullanacağız.

İlk yaptığımız şey, RoleManager nesnesi içinde bu rollerin var olup olmadığını kontrol etmektir.

Eğer yoklarsa, yeni olarak oluşturacağız; bunu hem **admin** hem de **user** nesnesi için yapacağız.

---

## 2️⃣ Adım 2: Rollere Claim Atama

İkinci adımda, claim’leri rollere atayacağız.

Burada ilk yapacağımız şey, `Claim` tipiyle bir claim nesnesi oluşturmak ve bunun için **permission** ile **manage employee records** özniteliklerini kullanmaktır.

Bu nesneyi oluştururken, claim metoduna göndereceğiz.

Sonrasında, RoleManager nesnesi içinde belirli bir rolü bulmaya çalışacağız.

Bu örnekte, adı **HR** olan rolü bulacağız ve eğer RoleManager nesnesinde bu rolü bulursak, `claims` içinde tanımlanan claim’i ekleyeceğiz; yani **permissions** ve  **manage employee records** .

Bu, RoleManager içindeki belirli role eklediğimiz claim’dir.

Bunu, Claim nesnesini kullanarak yaparız.

---

## 3️⃣ Adım 3: RouteController.cs İçinde Route Ekleme

Son olarak üçüncü adımda, `route controller.cs` dosyasında route’umuzu ekleyeceğiz.

Bu, `RoleManager` içindeki rollerle  **GET** , **POST** ve **DELETE** metodlarını kullanarak etkileşime girmemizi sağlar.

İlk maddede, **GET** metodunu **HR** rolü olarak authorize etmek için kullanacağız.

İlki, bu belirli **HR** rolü kullanılarak isteğin yetkilendirilmesiyle tüm çalışan kayıtlarını döndürecek.

Yani `get all`, tüm çalışan kayıtlarını döndürür ve istek, rolün **HR** tipinde olması durumunda yetkilendirilir.

---

## ➕ POST: Çalışan Ekleme

Sonraki olarak bir **POST** metodu ekleyeceğiz ve bu, çalışan eklememize izin verecek.

Burada gerekli olan policy,  **manage employee records** .

Bu POST isteği, isteği yapan tarafın **manage employee records** policy’sinin bir parçasına sahip olması durumunda yetkilendirilecek ve çalışan ekleyip “çalışan kaydı eklendi” şeklinde **OK** döndürecek.

Bu kodda, aslında bir veritabanına bir şey eklenmiyor; yalnızca **bu policy’yi kullanarak çalışan kayıtlarını ekleyeceğiniz kodu nereye koyacağınızı** gösteriyor.

---

## 🗑️ DELETE: Çalışan Silme

Benzer şekilde, son olarak **DELETE** metodunu ekleyeceğiz.

Bu, belirli bir çalışanın `ID` değerini alır ve policy yine **manage employee records** olmalıdır.

Eğer isteği yapan taraf bu policy’yi kullanmaya yetkiliyse, `remove employee` metodu çalışır; sonra elbette çalışanı silmek için kod ekleriz ve çağıran uygulamanın çalışanın silindiğini bilmesi için **OK** durumunu döndürürüz.

---

## ✅ Özet

Ve bunlar, bir ASP.NET uygulamasına rol ve claim eklemek için bu laboratuvarın adımlarıdır.
