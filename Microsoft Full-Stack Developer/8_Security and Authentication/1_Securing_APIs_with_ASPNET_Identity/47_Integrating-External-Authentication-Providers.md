## 🌐 ASP.NET Identity’de Harici Kimlik Doğrulama Sağlayıcılarını Entegre Etme

Bu laboratuvarda, **OAuth 2.0** kullanarak **ASP.NET Identity** içinde harici kimlik doğrulama sağlayıcılarını uygulayacağız. İlk adımda uygulamayı kuracağız. Elimde basit bir ASP.NET web uygulaması var ve `Program.cs` içinde `builder.Services.AddControllers` satırını ekliyorum; bu, uygulamanın eklediğimiz controller’ları bulup keşfetmesini sağlar.

---

## 🧩 Adım 1: Uygulamayı Kurma

Basit bir ASP.NET web uygulaması üzerinde çalışacağız.

`Program.cs` içinde şu satırı ekliyoruz:

`builder.Services.AddControllers`

Bu sayede uygulama, daha sonra ekleyeceğimiz controller’ları keşfedebilir ve route’larını çalıştırabilir.

---

## 🔐 Adım 2: Google Client ve Authentication Akışını Yapılandırma

Şimdi Google Client ve authentication akışını yapılandıracağız.

Dosyanın en üstünde şunları görüyorsunuz:

* `google.apis.auth`
* `google.apis.util`

Bu kütüphaneler uygulamaya zaten eklenmiş durumda; böylece laboratuvarın geri kalanında bunları kullanabiliriz.

Bu adımda yapacağımız ilk şey, `ClientSecrets` adlı yeni bir değişken oluşturmak.

Bu değişken, yapılandırma dosyamızda sakladığımız secret’ları tutmak için kullanılacak.

Elimizde:

* `ClientID`
* `ClientSecret`

bulunuyor ve bunlar ayrı bir dosyada tutuluyor.

Bu değerleri çekip `ClientID` ve `ClientSecrets` içinde saklıyoruz; böylece Google’a kimlik doğrulama isteği yaparken kullanabiliyoruz.

---

## 🧾 Scope Ayarlama

Scope’u şuna ayarlıyoruz:

`googleapis.com/auth/userinfo.profile`

Bu değişkeni authorization claim oluştururken kullanacağız ve burada `userinfo.profile` scope’unu kullanmak istiyoruz.

---

## 💾 Data Store Path Ayarlama

Şimdi **data store path** ayarlanıyor.

Data store, Google’ın döndürdüğü credential bilgilerini yerel cihazda sakladığı konumdur.

Bunu şu özel klasöre ayarlıyoruz:

`SpecialFolder.ApplicationData`

Bu, sistemde “Application Data” adıyla (işletim sistemine göre değişebilen) bir klasörü arar ve authorization/credential bilgilerini burada saklar.

---

## ✅ Credential Değişkeni Oluşturma

Son olarak bir `credential` değişkeni oluşturuyoruz.

Burada, daha önce eklediğimiz kütüphanelerden biriyle gelen **Google Web Authorization Broker** kullanılarak authorization yapılıyor.

Buraya şunları veriyoruz:

* `ClientSecrets`
* `scopes` değişkeni
* `"user"` string değeri
* cancellation token olarak `None`
* `data store path` (Google’ın credential’ı nereye yazacağını bilmesi için)

Böylece Google’dan credential bilgisi döndüğünde, bunu nereye kaydedeceğini bilir.

---

## 🔗 Adım 3: Login Endpoint Oluşturma

Üçüncü adımda bir login endpoint’i oluşturacağız.

Bu bir API route ve `"/login"` adresinde bulunuyor.

Bu endpoint’e istek attığımızda:

* authentication sonucu response olarak yazdırılacak
* `WriteAsyncAuthentication` string’i, bu yanıtın nereye yazılacağını belirleyecek
* burada değer `"authentication"`

Bu şekilde, Google’ı harici sağlayıcı olarak kullanarak çok basit bir external authentication akışı kurmuş oluyoruz: Google’dan authentication/authorization alıp bunu uygulamamızdaki endpoint üzerinden kullanabiliyoruz.
