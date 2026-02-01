## 🌐 Harici Kimlik Doğrulama Sağlayıcılarına Genel Bakış

Kullanıcılar uygulamalara hızlı ve güvenli erişim bekler; ancak birden fazla hesabı yönetmek zor olabilir. **ASP.NET Identity** kullanarak, kullanıcılarınızın hâlihazırda güvendiği servislerin kimlik bilgileriyle güvenli bir giriş deneyimi sunabilir ve kullanıcılarınız için daha iyi bir deneyim oluşturabilirsiniz. Bu videoda, **Harici Kimlik Doğrulama Sağlayıcılarının** ( *External Authentication Providers* ) faydalarını ve kullanım alanlarını ve **ASP.NET Identity** içindeki rollerini belirleyeceğiz.

Önce Harici Kimlik Doğrulama Sağlayıcılarının ne olduğunu tanımlayalım. Harici Kimlik Doğrulama Sağlayıcıları, bir uygulama için kimlik doğrulama sürecini yöneten, bir kullanıcının kimliğini doğrulayan ve güvenli protokoller kullanan üçüncü taraf servisler veya sistemlerdir. Güvenilir platformlardan yararlanarak uygulamalar, güvenli ve kullanıcı dostu bir deneyim sağlarken değer sunmaya odaklanabilir.

Harici Kimlik Doğrulama Sağlayıcılarının ne olduğunu bildiğimize göre, şimdi bazı faydalarını inceleyelim.

İlk olarak, kullanıcıların Microsoft veya Facebook hesapları gibi mevcut hesaplarıyla giriş yapmasına izin vererek girişleri basitleştirirler. Örneğin, birçok uygulama kullanıcıların yeni bir parola oluşturmadan giriş yapmasını sağlayan **Sign in with Microsoft** düğmesi sunar.

Bir diğer fayda, gelişmiş güvenliktir. Harici sağlayıcılar parola güvenliğini yönetir ve iki faktörlü doğrulama gibi ek özellikler sunabilir. Örneğin, bir Microsoft hesabıyla giriş yaparken kimliğinizi bir telefon bildirimi veya e-posta kodu ile doğrulamanız istenebilir.

Üçüncü fayda ise artan güvendir. Kullanıcılar, iyi bilinen sağlayıcılarla giriş yapmalarına izin veren uygulamalara daha çok güvenir.

Harici sağlayıcıların faydalarını ele aldık; peki kimlik doğrulama sürecini tam olarak nasıl yönetirler?

Öncelikle **OAuth 2.0** ve token’ların güvenli kimlik doğrulamada nasıl kullanıldığını konuşalım. OAuth 2.0, uygulamaların harici sağlayıcılar üzerinden kullanıcılara sınırlı erişim vermesine olanak tanıyan bir yetkilendirme protokolüdür. Bu protokol, kullanıcıların kimlik bilgilerini doğrudan paylaşmasını istemek yerine güvenli token’lar kullanır. Örneğin, bir uygulamaya Microsoft hesabınızla giriş yaptığınızda, OAuth 2.0 süreci token üreterek kimliğinizi doğrulamayı sağlar. Bu token, dijital bir geçiş kartı gibi çalışır; uygulamanın parolanızı saklamasına veya erişmesine gerek kalmadan kim olduğunuzu doğrulamasına olanak tanır. Bu da güvenliği artırır ve kimlik bilgilerinizi korur.

OAuth 2.0 yetkilendirmeyi yönetirken, kullanıcının kimliğini nasıl doğrularız?

İşte burada **OpenID Connect** devreye girer. OpenID Connect veya  **OIDC** , OAuth 2.0 protokolünün üzerine inşa edilmiş bir kimlik katmanıdır ve bir kullanıcının kimliğini doğrulamak ve kullanıcı hakkında bilgi (claim’ler) sağlamak için tasarlanmıştır. OpenID Connect ile bir kişi Microsoft hesabını kullanarak uygulamanıza giriş yaptığında, protokol bu kişinin gerçekten iddia ettiği kişi olduğunu doğrular; bu da doğru kimlik tespiti için ek bir güvenlik katmanı sağlar. Örneğin, bir web sitesinde **sign-in-with-Microsoft** özelliğini kullandığınızda, OpenID Connect Microsoft’un kimliğinizi doğrulamasını sağlar; böylece web sitesinin parolanızı saklaması gerekmez.

OAuth 2.0 kullanıcıların ne yapmaya yetkili olduğunu yönetirken, OpenID Connect onların kim olduğunu doğrular. Birlikte, hem kimlik doğrulamayı hem de erişim izinlerini güvenli şekilde yönetirler.

Bu videoda, harici kimlik doğrulama sağlayıcılarının faydalarını ve kullanım alanlarını ve ASP.NET Identity içindeki rollerini öğrendiniz. Harici kimlik doğrulama sağlayıcılarından yararlanarak kullanıcıların güvendiği sorunsuz bir giriş deneyimi sunabilir ve uygulamanızın güvenliğini artırabilirsiniz.
