## ⚡ Full-Stack Uygulamada SignalR’ı Uygulamak

İstemci-sunucu uygulamaları oluştururken bazen aynı anda birçok farklı istemciye mesaj yayınlamak önemli ve gerekli olabilir. .NET framework’te bunu yapmanıza olanak tanıyan SignalR adlı bir kütüphane vardır. Bu kütüphane yalnızca birden fazla istemciye yayın yapmakla kalmaz, aynı zamanda herkesi gerçek zamanlı olarak güncel tutar.

Bu ekran kaydında SignalR’ın nasıl çalıştığını göstereceğim ve uygulamalı olarak sergileyeceğim.

---

## 🧱 Çözüm Yapısı

Projede, bu çözüm içinde üç farklı proje kurulu olduğunu görebilirsiniz. Çözümün kök dizinindeyim ve bir istemci projem, bir sunucu projem ve bir de paylaşılan ( *shared* ) projem var.

Ve sunucunun SignalR kullanarak aynı anda birden fazla istemciye nasıl mesaj gönderdiğini size göstereceğim.

Paylaşılan servis hem istemci hem de sunucu tarafından kullanılıyor. Oldukça basit. Sadece bir modele sahip tek bir sınıf.

`ChatMessages.cs` dosyamız var; bu dosya hem istemcimizde hem de sunucumuzda bir sohbet mesajı nesnesi oluşturuyor.

Ve bu, mesaj göndermek için ve sonra bu mesajları sunucudan ve istemciden yayınlamak için kullanacağımız veri nesnesini kuruyor.

Paylaşılan kütüphane hem istemci hem de sunucu tarafından projeye dahil ediliyor ve uygulamada kullanılıyor.

---

## 🖥️ Sunucu Tarafı: Program.cs ve Hub Eşleme

Şimdi sunucu projesine gidelim. Bu projede SignalR’ı uyguladık.

`Program.cs` dosyasına gideceğim; böylece SignalR’ı nerede kullandığımızı görebilirsiniz.

`builder.Services.AddSignalR` içinde SignalR kütüphanesini ekledim; bu, uygulama boyunca kullanmamıza izin veriyor.

Ayrıca bir chat hub eşlemesi ( *mapping* ) da var; bu, sunucumuzda hub’ı kullanmamızı sağlıyor; böylece gerektiğinde mesajları yayınlayabiliyoruz.

Eklediğim son şey, bir CORS seçeneği. CORS, esasen bir izinler kütüphanesidir; mesajlar farklı kaynaklardan geldiğinde, istemcilerin bu kaynaklara güvenebilmesini sağlar.

Demo için bunu oldukça gevşek tuttum, ancak CORS’u yalnızca belirli sunuculara ve belirli kaynaklara kısıtlayacak şekilde ayarlayabilirsiniz.

Fakat bunu eklemek zorundayız ki istemciler sunucuya güvenebileceklerini bilsinler.

---

## 📡 ChatHub.cs: Mesajları Sunucudan Yayınlama

Şimdi `ChatHub.cs` dosyasına gireceğim.

Bu, sunucudan mesajları nasıl yayınladığımızın çekirdeği.

Chat hub, parametrelerinde gönderilen mesajı alan bir `SendMessage` metoduna sahip.

Mesaj için bir zaman damgası ( *timestamp* ) veriyor, dolayısıyla mesaja bir timestamp ayarlıyoruz.

Ve sonra şu `await` kısmını fark edeceksiniz.

Bu bir async metot, dolayısıyla `await` anahtar sözcüğünü görüyorsunuz.

Ardından `Clients.All.SendAsync`, SignalR kullanarak sunucu mesajlaşma sistemine abone olan tüm istemcilere mesajı gönderdiğimiz yerdir.

.NET kütüphanesi bunların hepsini sizin için paketler; yani çok fazla el ile kod yazmanız gerekmez.

Sadece bu mesajı, sunucuya abone olmuş herhangi bir istemciye yayınlar.

---

## 🧑‍💻 İstemci Tarafı: ChatService ve HubConnection

Şimdi istemci tarafına geçelim.

İstemci tarafında bir chat service sınıfı uyguladık.

Bu chat service sınıfı da SignalR kullanıyor.

`SignalR.Client` kütüphanesini kullanıyoruz ve bu kütüphane ile sunucu çalıştığında sunucuya bir bağlantı kuracağız.

`_hubConnection` adlı bir değişken oluşturuyoruz; bunu `HubConnection` türünü kullanarak yapıyoruz.

Bu `HubConnection`, SignalR kütüphanesinin bir parçasıdır ve sunucuya gerçek zamanlı bağlantı kurmamızı sağlar.

`HubConnection` ile ilgili ilginç olan şey, bunun gerçek zamanlı olmasıdır.

Sunucudan mesajlar gönderildikçe, yeni mesajları almak için sunucuyu sürekli yoklamanız ( *polling* ) gerekmez.

Bu hub connection, sunucuya gerçek zamanlı bir bağlantı sürdürür ve yayınlanan mesajların tamamını alır.

Sonra bir `Action` var.

Bu, bir mesaj alındığında bir şey olmasını sağlayan bir event handler.

Ve bu action’ın `ChatMessage` türünü kullandığını görebilirsiniz; böylece sohbet mesajı geldiğinde ne yapacağımızı biliyoruz.

Yazdığımız bir chat service metodumuz var.

Bunun içinde `hubConnection` var ve bağlantı sunucuya bağlanacak.

URL’nin sonunda `chat hub route` olduğunu göreceksiniz ve bu, sunucuda kurduğumuz route; istemci, gerçek zamanlı iletişim için hangi URL’ye bağlanacağını bilsin diye.

Bu `hubConnection`, SignalR gerçek zamanlı bağlantısını sunucuya kuruyor ve bu bağlantıyı sürdürüyor.

Sonra `WithAutomaticReconnect` parametresi var; bağlantı koparsa otomatik olarak yeniden bağlanacak.

Ve bunu bir araya getiren `Build` metodu var.

Sonra bir `hubConnection.On` event’i var; bir chat mesajı geldiğinde bu event tetikleniyor ve `ReceiveMessage` event handler’ını alıyoruz.

`ReceiveMessage` event handler’ı da `OnMessageReceived` event’ini invoke ediyor; böylece mesajları istemci uygulamamızda gerçekten görebiliyoruz.

`StartAsync` metodumuz var; bu metot chat sayfamızdan, yani birazdan bakacağımız `Chat.razor` sayfasından çağrılıyor.

Bu, bağlantıyı başlatıyor ve sunucuya bağlantıyı kuruyor.

Ve elbette, mesajı gerçekten göndermek için kullandığımız bir `SendMessage` metodumuz var.

İstemci uygulamamızdayken ve **Send** butonuna bastığımızda, mesajı parametre olarak geçirerek `SendMessage` metodunu çağıracak ve sonra onu hub connection üzerinden sunucuya gönderecek.

Sonra sunucu, SignalR kullanarak sunucuya bağlı diğer tüm istemcilere yayın yapacak.

---

## 💬 Chat.razor: Mesajlaşma Sayfası

Şimdi `Chat.razor` dosyasına gidelim.

Bu, gerçek mesajlaşma için kullandığımız sayfa.

Bazı input alanlarımız var: kullanıcı adı ( *username* ) ve göndereceğimiz mesaj.

Ve sonra bir **Send** butonu var; bu `onClick` butonu.

Bu buton, `@code` içinde `Send` metodunu çağıracak.

Ve `chatService.SendMessage` kullandığımızı görebilirsiniz; mesaj gövdesi o `message` içinde gönderiliyor.

Bu `SendMessage`, bazı değişkenleri kontrol ediyor; boş olmadıklarından emin olmak için.

Kullanıcı, mesaj ve timestamp ile yeni bir message nesnesi oluşturuyor, kuruyor.

Ve sonra bunu `ChatService.cs` dosyamızdaki `SendMessage` metodu üzerinden gönderiyor.

Sayfa başlatıldığında, yeni mesajları arayacak.

Gelen herhangi bir yeni mesaj, mesaj kütüphanemize eklenecek ve ardından `InvokeAsync(StateHasChanged)` çalışacak; yani bir şey olduğunu bize bildiriyor: yeni bir mesaj geldi.

Ve son olarak, `OnInitializedAsync` içinde, sayfa yüklendiğinde o bağlantıyı gerçekten başlatıyoruz.

Sayfa yüklenene kadar hiçbir şey yapmıyoruz.

Sayfa yüklendiğinde, `chatService`’e gidiyoruz ve sunucuya olan bağlantıyı başlatıyoruz.

Ve `StartAsync` içinde, hub connection’da belirlediğimiz URL’de sunucuda çalışan hub’a bir bağlantı oluşturduğunu hatırlayın.

Dolayısıyla bunu `Chat.razor` sayfasında yapıyoruz.

Sayfa yüklendiğinde başlatıyoruz.

Böylece hazır hâle geliyoruz.

---

## ▶️ Sunucuyu ve İstemciyi Çalıştırma

Artık her şey kuruldu.

Şimdi sunucuyu çalıştırabiliriz ve sonra istemci üzerinden mesajlaşmayı çalıştırabiliriz.

İlk yapacağım şey sunucuya gitmek.

İki tane PowerShell terminal penceresi kurduğumu görebilirsiniz; biri sunucu için, biri istemci için.

Şu anda sunucu tarafındayım ve uygulamayı çalıştıracağım.

Artık sunucu çalışıyor.

`localhost` üzerinde `5137` port numarasıyla çalıştığını görebilirsiniz; bu da `chatServices` içinde ayarladığımız port numarasıyla aynı.

Ve `chat hub` konumuna route edecek ve mesajlar için orada dinleyecek.

Sunucu çalıştığına göre onu bırakabiliriz.

Arka planda çalışacak.

Ve şimdi istemciyi çalıştıracağız.

Tamam, istemci çalışıyor ve `5132` host’unda.

Şimdi onu tarayıcıda açacağım.

Sonra route’a gideceğim.

Mesaj uygulamamız orada.

Artık mesaj gönderebiliriz.

---

## 👥 Birden Fazla İstemciye Yayın Yapma

SignalR’ın nasıl çalıştığını göstermek için bir şey daha yapacağım.

Başka bir sekme açacağım; bunu başka bir istemci gibi varsayalım.

Bu herhangi bir bilgisayarda olabilir.

Başka bir kişinin bilgisayarında olabilir.

Mobil cihazımda olabilir.

İki sekmeyi, iki ayrı süreç, iki ayrı istemci olarak göstermek için kullanıyorum; sunucunun yayın yaptığı istemciler bunlar olacak.

İstersem üçüncüsünü de ekleyebilirim.

Hatta bunu yapalım ki nasıl çalıştığını görelim.

Ve üçüncü bir tane ekleyeceğim.

Şimdi ilk sekmemde bir mesaj göndereceğim.

Kullanıcı adım `user`.

`hello there` diye bir mesaj göndereceğim.

Mesajı gönderdiğimde, bu mesajın sadece bu pencerede değil, diğer iki istemci penceresinde de göründüğünü görmemiz gerekir; çünkü SignalR kullanarak sunucuya bağlı her istemciye yayın yapıyoruz.

`user` “hello there” dedi.

Bu zamanda gönderdi.

Ve sonra bu sekmelere geçtiğimde, görünürde bir şey değişmemiş gibi duruyor, ama aslında sekme değiştiriyorum.

Mesaj, SignalR kullanılarak her bir istemciye yayınlandı.

Üçüncü sekmeden başka bir mesaj göndereceğim; üçüncü sekmedeyiz çünkü.

`well, hi` diyeceğim.

Sonra o mesajı göndereceğim.

`user three` “well, hi” dedi.

Bu, `user two` sekmesinde ve `user one` sekmesinde de görünüyor.

Dolayısıyla SignalR kullanarak mesajları yayınlayabiliyoruz.

Sunucumuzu kurduk.

Sunucu mesajlar için dinliyor.

İstemciler sonra SignalR kullanarak mesajları sunucuya gönderiyor.

Ve sonra SignalR, bu sunucuya hub connection ile abone olan tüm istemcilere yayın yapıyor.

Bu, Blazor içinde gerçek zamanlı güncellemeler almak ve istemci uygulamalarının bilgiyi gerçek zamanlı olarak almasını sağlamak için harika bir yoldur.
