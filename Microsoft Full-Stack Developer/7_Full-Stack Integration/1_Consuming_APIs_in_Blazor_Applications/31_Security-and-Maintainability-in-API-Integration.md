## 🔐 API Entegrasyonunda Güvenlik ve Sürdürülebilirlik

API’lerle çalışırken güvenlik ve sürdürülebilirlik (maintainability) gerçekten önemlidir. Bir API’ye veriyi güvenli şekilde gönderdiğinizden ve veriyi geri alırken de güvenli bir yöntem kullandığınızdan emin olmak istersiniz.

Bu ekran kaydında, güvenliği uygulamanın ve API çağrılarınızı bakımı daha kolay hâle getirmenin iki yoluna bakacağız.

---

## 🧩 Uygulama Kurulumu ve Sayfalar

`.NET new Blazor Wasm` şablonunu kullanarak oluşturduğum basit bir Blazor uygulamam var.

API çağrılarımı yapmak için kullanacağım bir `FetchData.razor` sayfası oluşturdum ve iki sayfa daha oluşturdum.

Bir  **error logging service** ’im var; API çağrısı sırasında oluşan sorunları loglamak için kullanacağım. Bu, API çağrılarımızı ve API çağrılarını kullanan uygulamamızı biraz daha sürdürülebilir hâle getirecek.

Ardından bir **token service** ekleyeceğim; uzak bir API’ye güvenli şekilde veri gönderip almak için token üretmekte kullanacağım.

---

## 🖥️ UI’da Token ve API Mesajını Gösterme

Sayfanın üst kısmında, kullanıcıya token’ı ve uzak API çağrısını yaptığımızda geri gelen API mesajını göstermek için biraz HTML var.

Sonra `@code` bloğumuz var; bu, API çağrımız için yazdığımız tüm C# kodunu gösterecek.

Tüm işi `OnInitializedAsync` metodunda yapıyorum. Bu, sayfa yüklendiğinde çalışır.

Yani sayfa yüklendiğinde:

* token üreteceğiz,
* API çağrısı yapacağız,
* veriyi geri alacağız.

Herhangi bir buton falan yok; her şey sayfa açılır açılmaz gerçekleşiyor.

---

## 🪪 Token Üretme ve Neden Kullanıldığı

Bu metodda olan ilk şey token üretmek.

Token’lar, internet üzerinden veriyi güvenli şekilde göndermek için kullanılır.

Yani e-posta ve şifre gibi bilgileri doğrudan göndermek yerine, e-posta ve şifreden bir token üretebilirsiniz. Ardından alıcı API bu token’ı çözebilir (decrypt) ve token’ın içinden ihtiyacı olan bilgiyi çıkarabilir.

---

## 🧰 Token Service Nasıl Çalışıyor?

Token service’e bakalım.

Yaptığı şey sadece tek bir string döndürmek.

Burada sahte veri (fake data) kullanıyor; sahte e-posta ve şifreyle token üretiyoruz.

Bu token service içinde, yine sadece demo amaçlı `HttpClient` kullanıyoruz.

Bir JSON verisini serialize ediyorum; bu veride bir `email` alanı ve bir `password` alanı var. Yine, bu sahte veriyle bir demo API’ye gidiyoruz; bu API bu veriden bir token üretiyor.

E-posta ve şifre var, ama bunları query string’de göndermek istemeyiz.

Ham metin olarak da göndermek istemeyiz; çünkü biri bu veriyi yakalayıp okuyabilir.

Bu yüzden `reqres.in` servisini kullanıyoruz. Veriyi bu servise gönderip token alıyoruz.

Token’ı aldıktan sonra, başka bir API’ye giderken e-posta/şifre yerine bu token’ı kullanabiliriz.

Bu demo site yerine, bunun gerçek dünyada kendi iç sistemimiz olduğunu düşünebilirsiniz: token’ı içeride üretiriz ve uygulamanın dışına çıkarken e-posta/şifreyi plain text göndermek yerine token göndeririz.

Burada olan şey bu.

Servisi çağırıyoruz, token üretiyor, token’ı geri gönderiyor. Biz de token’ı okuyup API çağrısında kullanıyoruz.

---

## 🌐 Token’ı Header’a Ekleyip API Çağrısı Yapma

Sayfaya geri döndüğümüzde, oluşturduğumuz servisten token’ı alıyoruz.

Token’ı ekrana ve konsola yazdırıyoruz.

Ardından yine `HttpClient` kullanarak `jsonplaceholder.typico.com`’a çağrı yapıyoruz; bu da API’leri test etmek için kullanılan demo bir site.

Ve oluşturduğumuz token’ı API çağrısının header’ına ekliyoruz.

Bunu yapan şey:

`client.DefaultRequestHeaders.Authorization`

Token’ı alıyor, bunun bir *bearer token* olduğunu belirtiyor ve çağrının header’ına ekliyor.

Sonra API response’un ne olacağını tanımlıyoruz; sadece ihtiyacımız olan string’i alıyoruz.

Bunu `client` nesnesiyle yaptığımız için, token da `GetStringAsync` çağrısının header’ının bir parçası oluyor.

Böylece biri bu isteği yakalasa bile, kullanıcı adı ve şifreyi görmez. Token’ı görür; ama token’ı decode edemiyorsa bu token onlar için anlamsız olacaktır.

Sonrasında sadece API’den dönen JSON’u geri yazıyoruz.

---

## ▶️ Uygulamayı Çalıştırma

Uygulamayı çalıştırıyoruz.

Tarayıcıda açıyorum.

`FetchData` route’una gitmemiz gerekiyor.

Bu sayfayı açtığımızda token üretecek ve ardından API çağrısını yapacak.

Token’ın nasıl göründüğünü görebilirsiniz: e-posta ve şifreyi alıp belirsiz (ambiguous) karakterlerden oluşan bir string’e çevirdi.

Token, API’nin alıcı tarafında çözülür veya anlaşılır.

E-posta ve şifreyi “şifrelemek” için kullandığımız metodun aynısını çözmek için kullanır; böylece nasıl kullanacağını bilir.

Ve bu bilgiyi API’ye gönderdiğimizde, API bunu çözer, kullanıcıyı oturum açtırır ve veriyi geri döndürür.

Bu fake data, ama asıl nokta: veri geri geldi.

Kullanıcıyı oturum açtırabildi, ihtiyacı olan veriyi çekti ve çağıran metoda response döndü.

Uygulamamızda da API çağrısının çalıştığını görüyoruz; çünkü token’ı geçtik.

`jsonplaceholder.typico.com` aslında login istemiyor, ama gerçek dünyadaki kullanımı göstermek için token’ı ekleyerek örnekliyoruz.

---

## 🧾 Hataları Yakalamak için Error Logging Service

Son yapmak istediğimiz şey, hataları ele alabilmek; böylece API çağrılarımızı ve uygulamalarımızı daha iyi yönetebiliriz.

Burada bir **error logging service** entegre ettik; böylece oluşan sorunları yakalayabiliyoruz.

Error logging service çok basit:

Bir hata varsa konsola yazıyor.

Hata mesajını `LogError` metoduna gönderiyoruz.

Burada tabii ki daha fazlasını yapabileceğinizi düşünebilirsiniz:

* Bir şey ters giderse e-posta göndermek
* Ağ yoğunluğu varsa API çağrısını retry etmek

Yani hangi hata oluştuysa onu yakalayıp bu metod içinde (veya başka metodlarla) birçok işlem yapabiliriz.

Bu servisi `FetchData.razor` içinde çağırıyoruz.

API çağrısı `try-catch` içinde.

`try` bloğu API’ye mesajı göndermeyi dener.

Bir şey ters giderse, `catch` exception yakalar ve exception mesajını logError servisine gönderir. Şu an sadece konsola yazıyor; çok bir şey yapmıyor ama uygulamayı daha iyi yönetmemize yardımcı oluyor.

---

## 🧨 Geçersiz Endpoint ile Hata Üretme ve Debugger’da Görme

Uygulamayı durduracağım ve API çağrısını var olmayan bir endpoint’e göndereceğim.

Böylece çağrı başarısız olacak ve bunu debugger’da nasıl gördüğümüzü göstereceğim.

Uygulamayı debug edince burada bir breakpoint’e düşmemiz gerekiyor; hata oluştuğunda durmalı.

`FetchData` sayfasına geri dönüyoruz.

Breakpoint’e geldik.

Şimdi `LogError` metodundaki error logging service çağrılacak.

Bunu göstermek için `LogError` metoduna da breakpoint koydum.

Şimdi error logging service’in içindeyiz; burada yapmak istediğimiz işlemleri yapabiliriz.

Uygulamayı çalıştırmaya devam edeceğim.

Tarayıcıya geri dönelim ve DevTools’ta console’a bakalım.

“Status code did not indicate its success” ve 404 veriyor; yani ne olduğunu söyleyen bir hata görüyoruz.

Bu, oluşturduğumuz servis yaklaşımıyla gördüğümüz şey.

Ve yine burada, çağrıyı retry etmek veya kullanıcıya mesaj göstermek gibi birçok şey yapabiliriz.

---

## ✅ Kapanış

Bu ekran kaydı, Blazor uygulamalarında uygulamanızı daha sağlam (robust) hâle getirmek için çeşitli araçları nasıl kullanabileceğinizi gösterdi.

Token kullanarak uygulamayı güvenli hâle getirebilirsiniz.

Ve logging sistemi kullanarak, API çağrıları sırasında sorunlara daha iyi yanıt verebilir; hem kendinizin hem de kullanıcılarınızın neler olduğunu anlamasını sağlayabilirsiniz.

Bu video için bu kadar.

Umarım bu videoyu faydalı buldunuz; eğer bulduysanız videoyu beğenmeyi ve kanalımıza abone olmayı unutmayın. Bir sonraki videoda görüşürüz. İzlediğiniz için teşekkürler.
