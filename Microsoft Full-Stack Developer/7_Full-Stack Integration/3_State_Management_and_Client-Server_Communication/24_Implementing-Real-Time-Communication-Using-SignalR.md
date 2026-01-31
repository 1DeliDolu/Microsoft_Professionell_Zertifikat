## ⚡ SignalR Kullanarak Gerçek Zamanlı İletişimi Uygulamak

Bu laboratuvarda, mesaj gönderip almak için SignalR kullanarak bir Blazor server uygulamasında gerçek zamanlı iletişimi uygulamayı öğreneceksiniz.

---

## 🧱 Adım 1: SignalR Uygulamasını Kurma

Birinci adımda Blazor şablonunu kullanarak SignalR uygulamasını kuruyorsunuz.

Uygulamanın adını `RealtimeApp` koyacaksınız.

Ardından `RealtimeApp` klasörüne geçeceksiniz.

Sonra terminalde `Microsoft.ASP.NETCore.SignalR` paketini ekleyeceksiniz.

Bu, istemci ile sunucunun gerçek zamanlı olarak iletişim kurabilmesi için SignalR kullanmamıza olanak tanıyacak.

```bash
cd RealtimeApp
```

```bash
dotnet add package Microsoft.ASP.NETCore.SignalR
```

---

## 🧩 Adım 2: SignalR Hub’ını Yapılandırma

Sonraki adımda SignalR hub’ını yapılandıracaksınız.

Bunun için bir `Hubs` klasörüm ve `ChatHub.cs` dosyam var.

Buraya sadece `SendAsync` metodunu ekleyeceğiz.

`Clients.All.SendAsync` metodunu çağıracağız ve bu da istemci tarafında `Receive` metodunu çağıracak.

Dolayısıyla bu `ChatHub` içinde metot çağrılarının katmanlı bir yapısı var.

Bu, mesajları belirli bir istemciye gönderebilmemiz için; ancak burada mesajı tüm istemcilere gönderiyoruz, bu yüzden `Clients.All.SendAsync` kullanıyoruz.

Hub’a bağlı olan herhangi bir istemciye, istemcinin `ReceiveMessage` metoduna mesaj gönderilecek.

Bu `SendAsync` metodunda iki farklı veri parçası göndereceğiz.

Birincisi `username`, ikincisi ise `SendMessage` metoduna parametre olarak gelen `message`.

Bunları istemci tarafındaki `ReceiveMessage` metoduna ileteceğiz.

---

## 🧵 Adım 3: SignalR’ı Uygulama Pipeline’ına Eklemek

Üçüncü adımda SignalR’ı uygulama pipeline’ına ekleyeceğiz.

Bunun için `Program.cs` dosyasına gideceğiz.

En üstte SignalR’ı ekliyoruz; yani SignalR servislerini kullanacağız.

Sonra burada hub’ı map edeceğiz.

Daha önce oluşturduğumuz `ChatHub`’a map edeceğiz.

Ve istemcilerin sunucuya bağlanırken hangi servise gideceğini bilmesi için route olarak `chathub` kullanacağız.

İstemci bu route üzerinden bağlanabilir.

---

## 🧑‍💻 Adım 4: İstemci Tarafını Kurma

Dördüncü adımda istemci tarafını kuracağız.

Bu uygulamada istemci tarafı tek bir uygulamanın içinde.

Gerçek dünyada bunu ayrı bir uygulama yapardık, fakat demo amacıyla ve bu laboratuvarın amacı için hepsi aynı uygulamanın içinde.

Bu sayfanın `OnInitializedAsync` metodunda, hub için gezintiyi `"/chathub"` olarak ayarlayacaksınız.

Bu route’u `Program.cs` içinde ayarlamıştık; böylece istemci hub’a nasıl gideceğini bilir.

Bu bizim URL’imiz, kullanacağımız route’umuz.

Ve `hubConnectionOn`, bir istemci SignalR hub’ına bağlandığında olan şeydir.

Ve `ReceiveMessage`’ı tekrar kullandığımızı fark edin; bu, hub’ın istemci uygulamalarına mesaj gönderirken iletişim kuracağı metottur.

Orada tekrar `user` (kullanıcı adı) ve `message` (mesaj gövdesi) geçiriyoruz.

Sonra üstte oluşturduğumuz `messages` listesine, `user` ve `message`’ı ekleyeceğiz.

Bu, farklı istemcilerden gelen mesajların bir listesini oluşturmamıza ve hub’a kim bağlıysa ona göre diğer istemcilere gönderilmesine olanak tanır.

Ve `hubConnectionClosed` içinde, eğer hub bağlantısı kapanırsa, 5 saniye bekleyeceğiz.

`Task.Delay` kullanacağız; `5,000` yani 5 saniye.

Ve sonra bağlantıyı tekrar kuracağız.

Yani bağlantı kapanırsa, `hubConnection` kullanarak tekrar başlatacağız ve istemcilerle yeniden senkronize edeceğiz.

Bu, bir şeyler ters giderse diye bir  *fail-safe* .

---

## ✅ Kapanış

Ve bunlar, bu laboratuvarın adımlarıdır.
