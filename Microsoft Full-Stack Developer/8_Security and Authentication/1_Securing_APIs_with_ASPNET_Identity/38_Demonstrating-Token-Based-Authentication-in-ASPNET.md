## 🍪 ASP.NET’te Token Tabanlı Kimlik Doğrulamayı Gösterme

Cookie’ler, arka uç güvenliğiyle çalışırken büyük ölçüde altın standart olarak kabul edilir. Tarayıcı ortamlarında ve cookie’leri destekleyebilen her türlü ön yüzde inanılmaz derecede güçlüdürler. Ancak tüm ön yüzler cookie’leri destekleyemez ve bazen sizin yerinize cookie üretemeyen bir tür üçüncü taraf servisle çalışmanız gerekir; bu durumlarda genellikle güvenlik token’ları veya session token’ları ile çalışmanız gerekir.

En yaygın token türlerinden biri  **JWT** ’lerdir ve .NET’in JWT üretmek için yerleşik desteği yoktur. İsterseniz bir API’ye kendiniz entegre edebilirsiniz. Ancak .NET’in, JWT’ye çok benzeyen kendi *proprietary* session token’ı vardır; bu yüzden session token’larıyla çalışmaya giriş için bence oldukça iyi bir başlangıçtır. Çünkü burada öğreneceğiniz her şey, ileride JWT’lere biraz daha derinlemesine girdiğimizde de geçerli olacak.

---

## 🧩 Uygulamadaki Mevcut Kurulum

Bu uygulamada Identity kurulu, birkaç policy var, roller var, kullanıcılar var, farklı policy’ler arkasında güvenceye alınmış rotalar var, kullanıcıların log out olabilmesi var, ayrıca kullanıcılara rol ekleyebiliyor ve claim ekleyebiliyoruz.

Session almak aslında nispeten basit; çünkü Identity ile kutudan çıktığı hâliyle session üretmek üzere ayarlanmış durumdayız.

---

## ▶️ Cookie ile Oturum: Varsayılan Akış

Uygulamayı başlatalım. Akışımıza gelirsek, root rotaya herhangi bir kimlik doğrulama olmadan erişebiliriz, fakat bu secure route’a erişemeyiz.

Şimdi bir kullanıcı kaydedelim; ardından sign in olabiliriz ve bir cookie geri alabiliriz.

Bu, editörümüzde bir cookie set eder; tıpkı bir tarayıcının yapacağı gibi. Bu cookie’yi otomatik olarak saklıyor ve gelecekteki tüm isteklerde login sağlamak için otomatik olarak gönderiyoruz.

Her şey arka planda gerçekleşiyor; bununla ilgili bir şey yapmamıza gerek yok. Secure route’a tıklıyorum ve bir anda çalışıyor.

---

## 🔓 Cookie’den Token’a Geçiş

Şimdi bu kullanıcıyı log out edeceğim ve bir session token’ın nasıl çalıştığını göstereceğim.

Burada bir flag var: `use cookies = true`. Bunu `false` yaparsam, login olduğumuzda farklı bir şey göreceğiz.

Şimdi cookie yerine, bir **access token** içeren bir payload görüyoruz. Bu bir  **session token** .

Artık login oldum; burada secure route’a erişebileceğimi düşünebilirsiniz ama erişemiyorum. Çünkü söylediğim gibi token’lar cookie’ler gibi davranmaz. İstemci tarafından otomatik olarak saklanmazlar.

Bunları nasıl kullanacağınızı manuel olarak uygulamanız gerekir.

---

## 🪙 Access Token, Refresh Token ve Expiration

Burada iki token var:

* **access token**
* **refresh token**

Ve burada bir de `expires in` değeri var.

Bunların neden böyle olduğuna birazdan geleceğiz; ama şimdilik bunun alacağınız payload olduğunu bilin.

---

## 🧷 Bearer Token Olarak Token Kullanımı

Bu token’ı nasıl kullanırız?

Bu bir  **bearer token** .

Bearer token’ları kullanma şeklimiz şudur: bir header ekleriz ve bu header bir **authorization header** olur.

Sonra `bearer` kelimesini ekleriz, ardından bir boşluk, ardından token’ımız.

Böylece isteği gönderdiğimde, artık erişebiliyorum.

Token’ı bozarsam, örneğin birkaç karakter silersem, artık unauthorized olurum.

Yani bu API’ye erişmek için ya token ya da cookie kullanabilirim; login sırasında hangisini alacağımı değiştirebilirim.

Cookie’ler, cookie kullanabilen bir ortamdaysanız genellikle kullanmak istediğiniz varsayılan yöntemdir. Token kullanma seçeneğiniz de var.

Ayrıca token’ları sizin için sağlayacak harici bir JWT sağlayıcısı da kullanabilirsiniz; bunu birazdan konuşacağız. Yerleşik Identity session token’ları yerine JWT’leri kabul edebilmek için birkaç ekstra adım gerekir. Ama kullanım şekilleri çok benzerdir.

---

## ⛔ Token’larda “Logout” Sorunu ve Kısa Ömür

Session token’larının bir özelliği şu: onları “revoke” etmenin gerçekten bir yolu yok.

Kullanıcıyı log out yapsam bile bu token’ı kullanmaya devam edebilirim. Token hâlâ bende. Cookie gibi değil; cookie’yi boş değerle overwrite edebiliriz.

Bu yüzden token’larla çalışmanın ana noktalarından biri şudur: genellikle **uzun süre geçerli olmamalarını** istersiniz.

Bu, biri istemcinin token’ını ele geçirirse, aslında erişmemesi gereken uygulamaya erişebileceği anlamına gelir. Ama erişebileceği süreyi sınırlarsınız. Mükemmel değil ama güvenliği bu şekilde kurmanın standartlarından biridir.

Token isterken gördüğünüz `expires in` de bununla ilgilidir.

Burada sanırım bir saatlik bir süre var. Muhtemelen saniye cinsinden. Yani **3,600 saniye** veya  **1 saat** .

---

## ♻️ Refresh Token ile Token Yenileme

Bu yüzden **refresh token** alıyoruz.

Refresh token, bu token’ı çok güvenli şekilde saklayıp belirli aralıklarla “hey, yeni bir token’a ihtiyacım var” diyebilmemizi sağlar.

Bunu token süresi dolmadan önce yapmamız gerekir.

Token’ı yenilemek için kullanacağımız refresh route, Identity’nin sağladığı rotalardan biridir.

Token’ı yenilemek istiyorsak, API’ye bir **POST** isteği atarız ve bu refresh route’a gider.

Ben token’ı yenilemek için bu refresh route’a vuracağım.

Bu route Identity tarafından otomatik oluşturulur ve bir payload ister. `Content-Type` olarak `application/json` vereceğiz ve bir payload göndereceğiz.

Payload içinde ne var?

Bir **refresh token** alır.

Buradan token’ı alıp kullanabiliriz.

Dikkat edin: bu header’larda gönderilmiyor. Payload üzerinden gönderiliyor.

Bunu çift tırnak içine koymayı unutmayın; sonra send yapabiliriz.

Ve şimdi geri yeni bir token alacağız.

Bunu tekrar tekrar yenileyebilirim ve sürekli yeni token’lar alırım.

Sonra bu token’ı alıp, az önce yaptığımız gibi bearer token olarak kullanabiliriz.

Ama dikkat edin: bu işlem önceki token’ımızı geçersiz kılmaz.

Sadece artık yeni bir token’ımız olduğu anlamına gelir.

Bu, bu session token’larından biriyle token yenilemenin nasıl yapıldığıdır.

---

## ✅ Kapanış

.NET’te session token kurmak için bilmeniz gerekenler temelde bunlar.

Tek yapmanız gereken, login olurken cookie yerine token istediğinizi belirtecek şekilde giriş yöntemini değiştirmek ve istemci/ön yüzde bu token’ı  **authorization header** ’ına **bearer token** olarak ekleyecek bir yöntem oluşturmak.

Ve şunu unutmayın: bir token ile kullanıcıyı log out yapamazsınız.

Bu yüzden token’ı periyodik olarak geçersiz kılacak güvenlik önlemleriniz olmalıdır.

Sonrasında kullanıcıların token’larını yenileyerek yeni token’lar almasına izin verebilirsiniz; böylece sürekli tekrar login olmaları gerekmez.
