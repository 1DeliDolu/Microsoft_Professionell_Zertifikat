
## ⚡ Deneyin! SignalR Kullanarak Gerçek Zamanlı İletişimi Uygulamak

## 🎯 Amaç

Bu laboratuvarın sonunda, SignalR kullanarak bir full-stack uygulamada gerçek zamanlı iletişimi uygulayabileceksiniz. SignalR’ı yapılandıracak, iletişim için bir hub oluşturacak ve istemci-sunucu ortamında gerçek zamanlı güncellemeleri test edeceksiniz.

---

## 🧱 Adım 1: Uygulama İçin Hazırlık

*inLabInstructionsPart~JDY2VtnnEe-C8w7X8PU7hQ*

Visual Studio Code kullanarak gerçek zamanlı bir sohbet uygulaması oluşturacaksınız. Bu kurulum, sonraki adımlar için gerekli sunucu, istemci ve paylaşılan bileşenleri hazırlayacaktır.

### ✅ Talimatlar

#### 📦 Çözümü Oluşturun

Visual Studio Code’da terminali açın.

`RealTimeChatApp` adında yeni bir çözüm oluşturun:

```bash
mkdir RealTimeChatApp
cd RealTimeChatApp
dotnet new sln
```

#### 🖥️ Sunucu Projesini Oluşturun

Bir Blazor Server projesi oluşturun:

```bash
dotnet new blazor -n Server
```

Projeyi çözüme ekleyin:

```bash
dotnet sln add Server/Server.csproj
```

#### 🌐 İstemci Projesini Oluşturun

Bir Blazor WebAssembly projesi oluşturun:

```bash
dotnet new blazorwasm -n Client
```

Projeyi çözüme ekleyin:

```bash
dotnet sln add Client/Client.csproj
```

#### 📚 Shared Projesini Oluşturun

Paylaşılan modeller için bir class library oluşturun:

```bash
dotnet new classlib -n Shared
```

Projeyi çözüme ekleyin:

```bash
dotnet sln add Shared/Shared.csproj
```

#### 🔗 Shared Projesini Referanslayın

Hem sunucu hem istemci projelerinde Shared projesine referans ekleyin:

```bash
dotnet add Server/Server.csproj reference Shared/Shared.csproj
dotnet add Client/Client.csproj reference Shared/Shared.csproj
```

#### 📡 Sunucu Projesine SignalR Kurun

Sunucu projesinde SignalR paketini yükleyin:

```bash
dotnet add Server/Server.csproj package Microsoft.AspNetCore.SignalR
```

#### 🧩 İstemci Projesine SignalR Client Kurun

İstemci projesinde SignalR client paketini yükleyin:

```bash
dotnet add Client/Client.csproj package Microsoft.AspNetCore.SignalR.Client
```

#### ✅ Kurulumu Doğrulayın

Tüm projelerin doğru yapılandırıldığını doğrulamak için çözümü derleyin:

```bash
dotnet build
```

---

## 🧾 Adım 2: Paylaşılan Modeli Uygulama

İstemci ve sunucu arasında tutarlı veri yönetimi için paylaşılan bir model oluşturun.

### ✅ Talimatlar

* `Shared` projesinde `Models` adlı bir klasör oluşturun.
* `Models` klasörünün içine `ChatMessage.cs` adlı yeni bir dosya ekleyin.
* `ChatMessage` sınıfını `User`, `Message` ve `Timestamp` özellikleriyle tanımlayın.

---

## 🧩 Adım 3: SignalR Hub Oluşturma

*inLabInstructionsPart~o9hRK9nnEe-C8w7X8PU7hQ*

Sunucu ile bağlı istemciler arasında gerçek zamanlı iletişimi yönetmek için bir SignalR hub’ı oluşturun.

### ✅ Talimatlar

* `Server` projesinde `Hubs` adlı bir klasör oluşturun.
* `Hubs` klasörünün içine `ChatHub.cs` adlı yeni bir dosya ekleyin.
* Tüm bağlı istemcilere mesaj yayınlayacak bir `ChatHub` sınıfı tanımlayın.

---

## 🛠️ Adım 4: Sunucuyu Yapılandırma

İstemci ve sunucu arasında iletişime izin vermek için sunucuda SignalR hub’ını kurun.

### ✅ Talimatlar

* `Server` projesindeki `Program.cs` dosyasını açın.
* CORS’u etkinleştirmek ve SignalR hub’ını yapılandırmak için middleware ekleyin.

---

## 💬 Adım 5: İstemci Arayüzünü Oluşturma

İstemci projesinde mesaj gönderip almak için basit bir sohbet arayüzü oluşturacaksınız. Ayrıca DI (dependency injection) için `ChatService`’i DI container’a kaydedeceksiniz.

### ✅ Talimatlar

#### 📄 ChatService Oluşturun

* `Client` projesinin kök dizininde `ChatService.cs` adlı yeni bir dosya oluşturun.
* UI’ı SignalR hub’ına bağlamak için bir `ChatService` uygulayın.

#### 🧷 ChatService’i DI Container’a Kaydedin

* `Client` projesindeki `Program.cs` dosyasını açın.
* `ChatService`’i singleton olarak kaydetmek için aşağıdaki satırı ekleyin:

```csharp
builder.Services.AddSingleton<ChatService>();
```

#### 🧑‍💻 Chat Arayüzünü Oluşturun

* `Client` projesinde `Pages` klasörüne gidin ve `Chat.razor` adlı yeni bir Razor bileşeni oluşturun.
* Kullanıcı girdisi alacak ve mesajları dinamik olarak gösterecek UI’ı tanımlayın.

#### 🔌 Arayüzü ChatService’e Bağlayın

* `Chat.razor` içinde `@inject` yönergesiyle `ChatService`’i enjekte edin ve gerçek zamanlı iletişimi yönetin.

---

## ✅ Adım 6: Gerçek Zamanlı İletişimi Test Etme

Mesajların tüm istemciler arasında senkronize olduğundan emin olmak için uygulamayı çalıştırın ve test edin.

### ✅ Talimatlar

Sunucu projesini başlatın:

```bash
dotnet run --project Server/Server.csproj
```

İstemci projesini başlatın:

```bash
dotnet run --project Client/Client.csproj
```

* İstemci uygulamasını iki farklı tarayıcı sekmesinde açın.
* Bir sekmeden mesaj gönderin ve mesajın diğer sekmede gerçek zamanlı olarak göründüğünü doğrulayın.
