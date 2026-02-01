## 🔐 ASP.NET’te JWT Kimlik Doğrulamasını Uygulama

Bu laboratuvarda, *ASP.NET Core* uygulamasında JWT kimlik doğrulamasını uygulayacağız. Elimde temel bir *ASP.NET MVC* uygulaması var ve **Program.cs** dosyasındayım. Birinci adımda, kimlik doğrulama için middleware’i kuracağız. *IdentityMetal.tokens* kütüphanesini ve *authentication.jwtbear* kütüphanesini de kullanıyorum. Bunları kurmak önemlidir; ardından **Program.cs** içinde middleware’imizi kurabiliriz.

İlk yapacağımız şey, authentication servisimizin eklenmesidir. `builder.services.addAuthentication` kullanıyoruz ve `jwt-bear-defaults.authentication scheme`’i kullanacağız; bu, *jwt-bear* kütüphanesinden gelen bir özelliktir. Önce bunu ekleyeceğiz, ardından bearer token’ımız için bilgileri ekleyeceğiz. İlk seçenek olarak `jwt-bear` kullanacağız ve sonra `option` anahtar kelimesini kullanarak bir dizi başka ayar belirleyeceğiz.

Options tarafında; issuer’larımız var, issuer’ı doğrulayıp doğrulamayacağımız var, audience’ı doğrulayıp doğrulamayacağımız var, lifetime’ı doğrulayıp doğrulamayacağımız var; bunların hepsi **true** olarak ayarlanmış. Ardından bir `valid issuer` var ve bu herhangi bir domain olabilir. Buradaki örnek için sadece *your domain* kullanıyoruz. Sonra `valid audience`, burada kullanmak istediğimiz audience API her neyse o olacak. Bir e-posta adresi kullanabiliriz, bir kullanıcı adı kullanabiliriz. Ben burada audience olarak kullanılacak API adı için *your API* yazıyorum.

`issuer signing key` özelliğini ayarlıyoruz ve bu bir *symmetric security key* olacak. Bunu UTF-8 ile encode edeceğiz; UTF-8 encoding kullanarak byte’a çeviriyoruz ve burada hem token’ı encode etmek hem de decode etmek için kullanılan bir anahtar kelimeyi geçiriyoruz. Bu herhangi bir şey olabilir; ama genellikle uzun, rastgele bir rakam dizisidir ve bu security key’i oluşturmak için bunu kullanırız.

Böylece token’ımız için gerekli options ayarlanmış olur ve sonra bu middleware ayarıyla bunu API’ye enjekte ediyoruz.

İkinci adımda endpoint’i güvenceye alacağız. Bunun için **Controllers** klasörüne gidip **ProductController** dosyasına bakacağım; route’u orada ayarlıyoruz. Burada `route API` ve sonra kullandığımız controller her neyse onu görebilirsiniz. Sonra **ProductController** adlı bir sınıf tanımladık.

Bu sınıfta, sağlamak istediğimiz ürün listesini döndürecek bir *get* metodumuz var. `getAll` fonksiyonu düzgün çalıştığında, metodun bir parçası olarak ürün listesini **OK** ile döndüreceğiz.

Ayrıca, uygulamanın yalnızca belirli bir ID için ürün alabileceği bir *get* metodu daha ekleyeceğiz. Bu da bir ürün döndürecek, ancak yalnızca ID’ye göre tek bir ürün döndürecek. **OK** döndürdüğümüzde, geçerli durum ( *valid status* ) döndürmek istiyoruz, fakat yalnızca parametre olarak verilen ID’ye göre bulduğumuz o tek ürünü sağlayacağız.

Token’ı bu şekilde oluştururuz ve controller içinde bu token’ı kullanarak API’ye gelen istekleri güvenceye alırız. Burada bir **authorized** etiketi ( *tag* ) olduğunu görebilirsiniz; böylece yalnızca geçerli bir token gönderen yetkili kullanıcılar veriyi alabilir.
