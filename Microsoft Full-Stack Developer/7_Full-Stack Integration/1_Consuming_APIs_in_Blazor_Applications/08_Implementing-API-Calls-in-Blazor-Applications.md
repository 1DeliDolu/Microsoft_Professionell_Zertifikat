## 🌦️ Blazor Uygulamalarında API Çağrılarını Uygulama

Tamam, bu laboratuvarda Blazor’da küçük bir hava durumu uygulaması geliştiriyoruz ve bunu bu API çağrılarını göstermek için kullanacağız. Aslında `api.weatherapi.com` adlı harici bir API kullanıyoruz ve bunu nasıl kullanacağınızı birazdan açıklayacağım. Ancak projeyi kurmak için birinci adım, şablonu kullanarak yeni bir Blazor uygulaması oluşturmak: `.NET new Blazor wasm-o` ve adı  **weather app** .

Ardından bunu cevap anahtarındaki yöntemle açabilirsiniz veya `code weather app` komutunu kullanabilirsiniz; bu şekilde kendi örneğinde açılır ve bu yöntemle çalışmak biraz daha kolay olur. Her iki yöntem de olur.

---

## 🧩 İlk Sayfayı ve Weather Fetch Bileşenini Kurma

İkinci adımda ilk sayfayı ve hava durumu çekme bileşenini kuracağız.

Bunu yapmak için Pages içine giriyorsunuz, Pages’e tıkladığınızdan emin oluyorsunuz, sonra **New** butonuna tıklıyorsunuz ve `weather.razor` yazıyorsunuz. Ben zaten oluşturduğum için yeni bir tane oluşturmayacağım, ama kodumuz zaten hazır. Sonra cevap anahtarındaki kodu yapıştıracaksınız; bu hava durumu bilgi sayfası, HTML’i ve bunun `weather` adlı bir route’ta olduğunu göreceksiniz: yani `/weather`, bunu daha sonra test ederken kullanacağız.

Pardon, bu yanlış olan. `weather.app` oluşturmak istemiyorsunuz, çünkü o zaten şablonda var. `weatherfetch.razor` oluşturmak istiyorsunuz ve bunun route’u  **weather fetch** . Şablon zaten bir `weather.razor` dosyası içeriyor; yani onu kullanmak istemiyorsunuz. Laboratuvardaki dosya bu.

Sonra ikinci adımdaki kodu alıp bu dosyanın içine yapıştıracaksınız. Daha önce bahsettiğim şey de buydu: buna bakmanız gerekecek.

---

## 🔑 API Key ile WeatherAPI Kullanımı

Bunu test etmek istiyorsanız, API’yi kullanabilmek için bir  **API key** ’e ihtiyacınız var ve `weatherapi.com` sitesine gidip kayıt olmanız gerekiyor. Ücretsiz bir deneme veriyorlar. Sanırım yedi ya da on gün gibi bir süre bu anahtarı kullanabiliyorsunuz, sonra anahtarı yapıştırıyorsunuz.

Şablonda `your API key` yazdığını görebilirsiniz. Eşittir işareti ile ampersand arasına `weatherapi.com`’dan aldığınız anahtarı yapıştırmanız gerekiyor.

Kayıt olduktan sonra bu ücretsiz bir hesap. Kayıt olup giriş yaptıktan sonra, ana sayfada API key’inizi gösterir ve onu buraya yapıştırırsınız; sonra veri çekebiliyor olursunuz.

Bu sayfanın yaptığı tek şey, bu API’den veri çekmek; bu da yönlendirmeli laboratuvarın amacını gösteriyor. Sonra aldığı verilerle bu sınıfları dolduruyor ve ardından sayfanın üst kısmında bu veriyi gösteriyor. Bu ikinci adım.

---

## 🧯 Hata Yönetimi ve Loading Mesajı Ekleme

Üçüncü adım hata yönetimi eklemekle ilgili.

Hata yönetiminin orijinal kodda zaten olduğunu göreceksiniz. Bir `try-catch` bloğu vardı ve bu, kopyalayıp yapıştırdığınız kodun içindeydi. Eğer orada değilse, laboratuvarı güncellersek, yeni kodu yapıştırmanız ve API key’inizi Weather app’ten aldığınız anahtarla değiştirmeniz gerekecek.

Ayrıca en altta şunu da ekleyebilirsiniz: `weather null` ise “loading” yazdırabilirsiniz. Hadi bunu ekleyelim. Bunu koymayı unutmuştum, o yüzden buraya aşağıya ekleyeceğim ve bu da `OnInitializedAsync` içine giriyor. Tamam, üçüncü adım; hata yönetimini ve loading mesajını eklemek.

---

## ▶️ Uygulamayı Çalıştırma ve Test Etme

Artık derleniyor. Ben doğrulamak için bir build de aldım. `NET run` yapacağız ve `localhost 5144` üzerinde çalışıyor; bunu ekranda zaten açmıştım. O pencereye geçip tarayıcıya gideceğim.

Gördüğünüz gibi bu sadece temel uygulama. Şimdi route’a gitmem gerekiyor; bu da  **WeatherFetch** . Oraya gittiğimizde API’ye çağrı yapıyor, hava durumu bilgisini alıyor ve HTML’i ihtiyacımız olan verilerle dolduruyor.

Uygulamada route içinde Phoenix kullandığımızı hatırlarsanız, Phoenix’i görebilirsiniz. Oraya istediğiniz herhangi bir şehri koyabilirsiniz; bu şehir değişir ve o şehrin verisini çekmelidir.

Temelde bu kadar. Üç adımın hepsini kapsıyor ve bunu bu şekilde kuruyorsunuz.
