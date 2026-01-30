## 🎯 You Try It! Blazor Uygulamalarında Asenkron API Çağrılarını Uygulama

---

## 🧭 Amaç

Bu etkinliğin sonunda şunları yapabiliyor olacaksınız:

* Blazor’da **asenkron API çağrılarını** yönetmek (`Task` + `await`)
* **Loading state** göstermek
* Hataları **graceful** şekilde yakalamak ve kullanıcıya göstermek
* Çekilen veriyi **table** içinde göstermek ve **dinamik güncellemek**

---

## 🛠️ 1. Adım: VS Code’da Blazor Uygulaması Kurulumu

VS Code’u açın ve projeleri oluşturmak istediğiniz klasöre gidin.

Terminali açın:

```cli
Ctrl + ~
```

Yeni Blazor WebAssembly projesi oluşturun:

```cli
dotnet new blazor -n AsyncApi
```

Bu komut, `"AsyncAPI"` adlı bir klasörde Blazor projesi oluşturur.

VS Code’da projeyi açın:

```cli
code AsyncAPI
```

`Program.cs` dosyasını açın ve API çağrıları için `HttpClient` register edin:

```csharp
builder.Services.AddHttpClient();
```

Uygulamayı çalıştırın:

```cli
dotnet run
```

Tarayıcıda default Blazor uygulamasının doğru yüklendiğini doğrulayın.

Ardından `Pages` klasöründe yeni bir Razor bileşeni oluşturun:

* `FetchUsers.razor`

---

## 🧱 2. Adım: User Class Tanımlama

Proje kök dizininde bir klasör oluşturun:

* `Models`

`Models` içine bir dosya oluşturun:

* `User.cs`

Bu dosyada `Id`, `Name`, `Email`, `Address` alanlarını içerecek şekilde User modelini tanımlayın.

---

## 🔄 3. Adım: Asenkron API Çağrısını Uygulama

`FetchUsers.razor` içinde:

* `HttpClient` servisini inject edin.
* `https://jsonplaceholder.typicode.com/users` adresinden asenkron yöntemlerle veri çekin (`Task` ve `await`).
* Çekilen veriyi `List<User>` içinde saklayın.

---

## ⏳ 4. Adım: Loading ve Error State Eklemek

API çağrısı sırasında kullanıcıya durum bilgisini düzgün göstermek için:

* Loading için bir `bool` property ekleyin.
* Hata mesajı için bir `string` property ekleyin.

Fetch metodunu şöyle güncelleyin:

* Veri çekilirken **loading indicator** göster
* API çağrısı başarısız olursa **error message** göster

---

## 📊 5. Adım: Veriyi Table İçinde Gösterme

Arayüze şunları ekleyin:

* **Fetch New Users** adlı bir buton (API çağrısını tetikleyecek)
* Gelen kullanıcı listesini bir `<table>` içinde gösterin
* Yeni veri çekildiğinde table’ın dinamik güncellendiğinden emin olun

---

## ✅ 6. Adım: Uygulamayı Test Etme

Uygulamayı başlatın:

```cli
dotnet run
```

Tarayıcıda şu adrese gidin:

```text
http://localhost:5000/fetchusers
```

**Fetch New Users** butonuna basın:

* Veri çekilirken: bir loading mesajı görünmeli
* Başarılı olursa: kullanıcı verilerini içeren bir table görünmeli
* Hata olursa: hata mesajı görünmeli
