## 🔐 JSON Web Token’lar (JWT) Nedir?

JSON Web Token’lar, bir istemci ile sunucu arasında hareket eden hassas bilgileri korumak için güçlü bir yol sunar ve yalnızca doğru kişilerin erişebilmesini sağlar. Bu videoda, JSON Web Token’ların yapısını ve verilerin güvenli biçimde iletilmesindeki kullanım alanlarını açıklayacağız. Hatırlayın: JSON Web Token’lar ya da  *JWT* ’ler, kullanıcı bilgilerini kompakt bir formda, çoğunlukla JSON nesneleri olarak güvenli şekilde saklayan belirli bir token türüdür.

Bu anlayışı temel alarak, JWT’lerin bazı temel kavramlarını, yapısıyla başlayarak inceleyeceğiz.

---

## 🧱 JWT Yapısı

### 🧾 JWT Header (Başlık)

Header, token türü ve onu imzalamak için kullanılan algoritma hakkında bilgi içerir. Örneğin, header içinde *HS256* gibi yaygın kullanılan bir algoritma belirtilirse, sistem token’ı doğrulamak için *HMAC SHA-256* algoritmasını kullanması gerektiğini bilir.

Bu, sistemin token’ın doğruluğunu doğrulamak için hangi yöntemi kullanacağını belirlemesinin yoludur.

### 📦 Payload (Yük)

Payload, iletilen *claims* (iddialar/veriler) bilgisini tutar ve kullanıcının ID’si veya uygulamadaki rolleri gibi ayrıntıları içerebilir. Örneğin, payload içinde *John Doe Admin* ifadesini içeren bir string varsa, sunucu bunun *John Doe* adlı kullanıcının yönetici ( *admin* ) ayrıcalıklarına sahip olduğunu anlar.

Bu, sunucunun payload verisine dayanarak kullanıcının kim olduğunu ve ne yapabileceğini kolayca belirlemesini sağlar.

### ⏳ EXP Claim (Süre Sonu / Geçerlilik Bitişi)

JWT’leri daha da güvenli hâle getirmek için, genellikle sona erme zamanını belirten özel bir *EXP* claim’i içerirler. Bu claim, token’ın yalnızca sınırlı bir süre boyunca geçerli olmasını sağlar.

Token süresi dolduğunda, imza geçerli olsa bile sunucu token’ı reddeder.

### 🖊️ Signature (İmza)

JWT’nin bir diğer parçası imzadır. İmza, header ve payload’un kodlanması ve bir gizli anahtar ( *secret key* ) ile birleştirilmesiyle oluşturulur. Örneğin, biri payload’u değiştirerek rolünü *admin* yapmaya çalışırsa, sunucu kontrol ettiğinde imza eşleşmez ve token reddedilir.

Bu, iletilen bilginin bütünlüğünü ( *integrity* ) garanti eder.

---

## ✅ JWT’lerin Kimlik Doğrulama ve Yetkilendirmede Kullanımı

JWT yapısını anladıktan sonra, web uygulamalarında kullanıcı kimlik doğrulama ( *authentication* ) ve yetkilendirme ( *authorization* ) yönetiminde nasıl kullanıldıklarına bakalım. JWT’ler, authentication ve authorization süreçlerinin merkezindedir.

Örneğin, bir kullanıcı başarıyla giriş yaptıktan sonra, kimliğini ve rolünü içeren bir JWT üretilir. JWT, kullanıcının *admin* olduğunu söylüyorsa, uygulama kullanıcı yönetimi gibi yönetimsel özelliklere erişmesine izin verir.

---

## 🔏 İmzalama ve Doğrulama

JWT oluşturulurken, bu verinin kimse tarafından değiştirilememesi sağlanmalıdır. Bu yüzden JWT’ler, bilgiyi güvenli şekilde kilitlemek için imzalanır. İmzalandıktan sonra, token’a güvenilip güvenilemeyeceği imza anahtarı kontrol edilerek doğrulanır.

Örneğin, kullanıcı giriş yaptıktan sonra sunucu bir JWT üretir, bunu güvenli bir anahtarla imzalar ve istemciye gönderir. Daha sonra istemci bu JWT ile bir istek yaptığında, sunucu imzayı kontrol ederek doğrulama yapabilir. İmza eşleşiyorsa, sunucu JWT’nin değiştirilmediğini bilir ve token’a güvenebilir.

---

## 🔄 Tipik JWT İş Akışı

İlk olarak, kullanıcı giriş yaptığında, kimlik doğrulama için kullanıcı adı ve parola gibi bilgilerini sunucuya gönderir. Bu bilgiler doğrulandıktan sonra sunucu bir JWT üretir. Bu token; kullanıcının ID’si, rolü ve sona erme süresi gibi claim’leri içerir ve değiştirilmesini önlemek için bir gizli anahtarla imzalanır.

Sonra, imzalı token kimlik doğrulamanın kanıtı olarak istemciye geri gönderilir. İstemci bu token’ı güvenli şekilde saklar; çoğunlukla *local storage* veya *cookies* içinde tutar ve korunan kaynaklara erişmek için yaptığı her isteğe ekler.

Son olarak, istemci JWT ile bir istek gönderdiğinde, sunucu aynı gizli anahtarı kullanarak imzayı doğrular. İmza geçerliyse ve token süresi dolmamışsa, sunucu kullanıcının rollerine ve claim’lerine göre erişim izni verir.

---

## 🧾 Sonuç

Bu videoda, JSON Web Token’ların güvenli veri iletimi için yapısını ve kullanım alanlarını öğrendiniz. Yapılarını anlayarak ve en iyi uygulamaları hayata geçirerek, sistemlerinizde hem veri bütünlüğünü hem de kullanıcı güvenini sağlayabilirsiniz.
