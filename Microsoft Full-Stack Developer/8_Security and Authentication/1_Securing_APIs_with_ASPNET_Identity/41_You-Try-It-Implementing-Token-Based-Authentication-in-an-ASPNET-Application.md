## 🧰 Adım 1: Uygulamaya Hazırlık

Temel bir token tabanlı kimlik doğrulama sistemi uygulamak için bir konsol uygulaması oluşturacaksınız. Program; kullanıcı yönetimi, token üretimi ve güvenli içerik erişimi için ayrı sınıflar içerecek.

1. **Visual Studio Code** ’u açın ve yeni bir konsol uygulaması projesi oluşturun:

```bash
dotnet new console -o SimpleTokenAuthApp
```

Proje klasörüne gidin:

```bash
cd SimpleTokenAuthApp
```

2. `Program.cs` dosyasını açın. Mevcut kodları temizleyin; çünkü tüm ana mantık ayrı dosyalara taşınacak.

---

## 👤 Adım 2: Bir Kullanıcı Sınıfı Oluşturma

Kullanıcı verilerini saklamak için basit bir `User` sınıfı tanımlayın.

**Talimatlar:**

1. Projeye `User.cs` adlı yeni bir dosya ekleyin.
2. `User` sınıfını aşağıdaki özelliklerle tanımlayın:
   * `Username` (string)
   * `Password` (string)
   * `Token` (string, basitlik için)

---

## 🧩 Adım 3: Token Yönetimini Uygulama

Token üretimini yönetmek için bir sınıf oluşturun.

**Talimatlar:**

1. `TokenManager.cs` adlı yeni bir dosya ekleyin.
2. Token olarak *base64 kodlanmış* bir string oluşturmak için bir `GenerateToken` metodu uygulayın.

---

## 🔐 Adım 4: Kullanıcı Kaydı ve Girişi Yönetme

Kullanıcı kaydı ve giriş işlemlerini yönetmek için bir sınıf oluşturun.

**Talimatlar:**

1. `AuthManager.cs` adlı yeni bir dosya ekleyin.
2. Kullanıcıları yönetmek ve token atamak için `Register` ve `Login` metotlarını uygulayın.

---

## 🛡️ Adım 5: Güvenli İçeriğe Erişim

Güvenli içerik erişimini yönetmek için bir sınıf oluşturun.

**Talimatlar:**

1. `SecureContentManager.cs` adlı yeni bir dosya ekleyin.
2. Token’ları kontrol edip içeriğe erişime izin vermek veya erişimi reddetmek için bir `ValidateToken` metodu uygulayın.

---

## ▶️ Adım 6: Uygulamayı Çalıştırma

Uygulamayı test etmek için ana programı `Program.cs` içinde yazın.

---

## 🎯 Sen Deneyin! ASP.NET Uygulamasında Token Tabanlı Kimlik Doğrulama Uygulama

### 🎯 Amaç:

Bu laboratuvarın sonunda, uygulamayı farklı sınıflara ayırarak basit bir token tabanlı kimlik doğrulama sistemi uygulayacaksınız. Kod basit ama modüler kalsın diye her sınıf minimal işlevsellik içerecek.
