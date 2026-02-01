## 🧪 You Try It! Harici Kimlik Doğrulama Sağlayıcılarını Entegre Etme

## 🎯 Amaç

OAuth 2.0 kullanarak **ASP.NET Identity** içinde harici kimlik doğrulama sağlayıcılarını uygulamak.

Bu etkinliğin sonunda, yerel bir **OAuth Server** (authorization server) ve **OAuth Client** (consumer) oluşturarak harici bir OAuth 2.0 akışını simüle edeceksiniz. Bir  **authorization code** ’un bir **token** ile nasıl değiş tokuş edildiğini gözlemleyecek ve OAuth sürecinin bileşenlerini anlayacaksınız.

---

## 🛠️ Adım 1: OAuth Server’ı Hazırlayın

Harici bir authorization server’ı simüle edecek ve authorization code ile token üretecek OAuth server’ı oluşturacaksınız.

### Talimatlar

Yeni bir ASP.NET Core Web API projesi oluşturun:

```bash
dotnet new webapi -o OAuthServer
cd OAuthServer
```

Token üretmek için JWT kütüphanesini ekleyin:

```bash
dotnet add package System.IdentityModel.Tokens.Jwt
```

`Controllers` klasörü içinde `OAuthController.cs` adlı bir controller oluşturun.

İki endpoint uygulayın:

* `/authorize`: Girişi simüle eder ve bir authorization code döndürür.
* `/token`: Authorization code’u bir access token ile değiştirir.

---

## 🧑‍💻 Adım 2: OUth Client ' Hazırlayın

Authorization code ve token isteyen bir client uygulamasını simüle edecek OAuth client’ı oluşturacaksınız.

### Talimatlar

Yeni bir ASP.NET Core Razor Pages projesi oluşturun:

```bash
dotnet new webapp -o OAuthClient
cd OAuthClient
```

Ana sayfaya kullanıcıları OAuth Server’ın `/authorize` endpoint’ine yönlendiren bir buton ekleyin.

Authorization code’u karşılayıp token ile değiştirmek için bir callback endpoint’i ekleyin.

---

## ✅ Adım 3: OUth Akışını Test Edin

inLabInstructionsPart~MK6tENRUEe-ZNgr_yCIU3Q

### Talimatlar

Her iki uygulamayı başlatın:

OAuth Server’ı çalıştırın:

```bash
dotnet run --project OAuthServer
```

OAuth Client’ı çalıştırın:

```bash
dotnet run --project OAuthClient
```

Tarayıcınızda OAuth Client uygulamasını açın.

**"Login with OAuth"** butonuna tıklayın ve akışı takip edin.

Server’dan alınan access token’ı görüntüleyin.
