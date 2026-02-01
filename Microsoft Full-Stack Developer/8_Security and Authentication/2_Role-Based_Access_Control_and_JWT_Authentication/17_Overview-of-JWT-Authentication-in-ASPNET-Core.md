## 🔐 ASP.NET Core’ta JWT Kimlik Doğrulamasına Genel Bakış

Sorunsuz ve güvenli bir kullanıcı deneyimi, kullanıcıların bir kez giriş yapıp tüm uygulama boyunca güvenle gezinebilmesini sağlar. Bu düzeyde verimli güvenlik, hassas bilgileri korurken uygulama ölçeklenebilirliğini artıran güçlü bir yöntem olan *JSON Web Token* kimlik doğrulaması kullanılarak mümkündür. Bu videoda,  *ASP.NET Core* ’da JWT kimlik doğrulamasını uygulama sürecini açıklayacağız.

Önce JWT’lerin bir kimlik doğrulama akışında nasıl çalıştığını inceleyelim. İlk olarak kullanıcı, kimlik bilgileriyle giriş yapar ve sunucu bunları doğrular. Doğrulama tamamlandıktan sonra sunucu, belirli kaynaklara erişmek için bir geçiş kartı gibi davranan bir JWT token oluşturur ve bunu kullanıcıya geri gönderir. Kullanıcı her istek yaptığında, bu token’ı bir API isteğiyle birlikte kimliğinin kanıtı olarak isteğe dahil eder.

Son olarak sunucu, her istekle birlikte token’ı kontrol eder. Token geçerliyse erişim verilir; değilse reddedilir. Bu sayede kullanıcı yalnızca bir kez giriş yapmak zorunda kalır, ancak token’ın süresi dolana kadar güvenli alanlara erişmeye devam edebilir.

---

## 🧩 JWT Middleware’in Süreçteki Rolü

JWT kimlik doğrulama akışını anladığımıza göre, süreçte JWT middleware’in rolünü inceleyelim. Hatırlayın:  *middleware* , bir sistemin farklı parçaları arasında köprü görevi gören, onların iletişim kurmasına ve birlikte çalışmasına yardımcı olan kod veya yazılımdır.  *ASP.NET Core* ’da JWT middleware, her gelen istekte güvenli alanlara (API ve route’lar) erişim verilmeden önce token’ları doğrulayan bir kontrol noktası gibi çalışır.

Yalnızca geçerli token’a sahip kullanıcıların ilerleyebilmesini sağlar; böylece hassas kaynakları korurken uygulamanın bütünlüğünü sürdürür.

---

## 🪪 Bearer Schema ile Token Doğrulama

Bu doğrulamayı yapmak için middleware, *bearer schema* denen yapıya dayanır. Bearer schema, istemcinin kimliğini doğrulamak için bir HTTP isteğinin authorization header’ına genellikle bir JWT olmak üzere bir token eklediği bir kimlik doğrulama mekanizmasıdır.

Bearer schema’nın esnekliği, ayrıntılı erişim denetimi ve ölçeklenebilirlik sağlar; ancak riskleri azaltmak için *HTTPS* ve token sona erme süreleri gibi doğru güvenlik önlemleri kritik önemdedir.

---

## 🛡️ JWT Middleware ile API Route’larını Güvenceye Alma

Şimdi, JWT middleware ile API route’larını güvence altına almanın nasıl güvenli bir kimlik doğrulama düzeni oluşturduğunu inceleyelim ve API route’larını tanımlayarak başlayalım. API route’ları, kullanıcıları kişisel veriler veya sipariş detayları gibi uygulama kaynaklarına bağlayan yollardır. Bu route’lar, yalnızca geçerli token’a sahip kullanıcıların erişebilmesini sağlamak için JWT middleware ile korunur.

Bu yaklaşım, hassas bilgileri yetkisiz erişimden korur ve uygulama güvenliğini sürdürür. Bu mekanizma sayesinde sunucu, her istekte token’ı doğrular ve kullanıcının kimlik bilgileri ile izinlerine göre erişimi verir ya da reddeder. Böylece API route’ları güvenli kalır ve yalnızca yetkili kullanıcılar hassas kaynaklara erişebilir.

---

## 🔄 Örnek Akış: Giriş ve Route Güvenliği

JWT kimlik doğrulamasını nasıl uygulayacağımızı anladığımıza göre, bunun API route’larını nasıl güvenceye aldığına ve kullanıcının uygulamaya giriş yaptığı ana dair bir örneği inceleyelim. İlk olarak kullanıcı, kimlik bilgilerini gönderir ve sunucu bunları doğrular. Başarılı bir doğrulamanın ardından sunucu, encode edilmiş kullanıcı bilgisi ve izinleri içeren bir JWT üretir ve bunu istemciye gönderir.

Sonra middleware bir kapı bekçisi gibi çalışır. Bearer schema kullanarak istek header’ına eklenmiş JWT’yi doğrulayarak her gelen isteği işler. Bu doğrulama, token’ın gerçek olduğunu ve süresinin dolmadığını garanti eder. Son olarak token geçerliyse middleware, isteği ilgili API route’una iletir; yanıt da güvenli şekilde kullanıcıya geri döner.

Bu yöntem, API route’larını güvence altına alır ve yetkisiz erişime karşı korumayı sürdürür.

---

## ✅ Sonuç

Bu videoda,  *ASP.NET Core* ’da JWT kimlik doğrulamasını uygulama sürecini öğrendiniz. JWT kimlik doğrulamasını uygulayarak ölçeklenebilir ve güvenli bir temel oluşturur, uygulamanız büyüdükçe kullanıcılara güven veren bir güvenlik altyapısı sağlarsınız.
