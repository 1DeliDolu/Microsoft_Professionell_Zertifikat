## 🧪 Rehberli Laboratuvar Videosu: JWT’lerle API Uç Noktalarını Güvenceye Alma

Bu laboratuvarda, *ASP.NET Core* uygulamasında JWT’ler kullanarak API endpoint’lerini güvenceye alacağız. Burada bir ASP.NET Web uygulamam var ve ekranda **Program.cs** açık.

---

## ✅ Adım 1: Uygulamayı Kurma

İlk olarak uygulamayı kuracağız. Oluşturacağımız tüm controller’ları uygulamanın kullanabildiğinden emin olmak istiyoruz; bu yüzden bunu builder’a ekleyeceğiz. `builder.services.addControllers` kullanacağız ve bu, uygulamayı oluşturacağımız tüm controller’ları bulması için kod tabanını taramaya zorlayacak.

---

## ✅ Adım 2: JWT Middleware’i Yapılandırma

İkinci adımda JWT middleware’i yapılandıracağız. Token’larımızı oluşturmak için gereken özellikleri burada ayarlıyoruz.

Token options’ları için ayarlayabileceğimiz birkaç seçenek var. `validate issuer`, `validate audience`, `lifetime` ve `issuer signing key` değerlerinin hepsini **true** yapacağız.

Aslında token oluşturucuya şunu söylemiş oluyoruz: issuer’ın, audience’ın, token’ın ne kadar süre geçerli olacağının ve geçerli bir issuer signing key’in olduğunun kontrol edilmesini istiyoruz. Token encode ve decode edilirken bunların hepsini kontrol etmek istiyoruz. Bunlar, bu serviste token oluşturma için ayarlayacağımız özelliklerdir.

Son olarak, uygulamanın herhangi bir yerinde token service’i kullanabildiğimizden emin olmak için builder’a bir singleton eklemek istiyoruz. Bu yüzden `builder.services.addSingletonToTokenService` ayarını yapıyoruz; bu da **Program.cs** dosyamızın başında yükleyip eklediğimiz token kütüphanesinden geliyor.

---

## ✅ Adım 3: API Uç Noktalarını Güvenceye Alma

Üçüncü adımda API endpoint’lerini güvenceye alacağız. Burada kurduğumuz  **AuthorizedController** ’a gideceğim. Bir **AuthorizedController** sınıfım var ve bu sınıfta, `getSecureData` metodunu kullanmak isteyen kullanıcıları yetkilendirmek için kullanacağımız bir `get` metodum var.

Burada `authorize` özelliğini, **admin policy** policy’si ile birlikte görebilirsiniz. Yani yalnızca admin’ler `getSecureData` metodunu çağırabilir; bunun da çağıran fonksiyona güvenli veri döndüreceğini düşünebiliriz.

Bu `authorize` anahtar kelimesi, oluşturduğumuz token policy’sini kullanmamıza izin verir ve istemcilerin kodun bu belirli metoduna erişebilmesini sağlar.

Dolayısıyla JWT token’ları kullanarak ve `authorize` policy ile güvence altına alınmış bir route kullanarak, web API’lerimizde güvenli kod oluşturmak için bu token’ları kullanabiliriz.
