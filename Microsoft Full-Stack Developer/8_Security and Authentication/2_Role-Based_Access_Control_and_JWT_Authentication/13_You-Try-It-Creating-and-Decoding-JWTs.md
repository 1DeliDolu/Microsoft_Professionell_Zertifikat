
# You Try It! JWT Oluşturma ve Çözümleme

#### 🎯 Amaç

Bir *ASP.NET Core* uygulamasında JWT’leri nasıl oluşturacağınızı ve çözeceğinizi öğreneceksiniz. Bu laboratuvar, JWT işlevselliğini daha kolay anlaşılması için ayrı sınıflara bölerek modülerleştirmeye odaklanır.

---

## ✅ Adım 1: Uygulama için Hazırlık

Visual Studio Code’da yeni bir console uygulaması kuracaksınız. Bu uygulama, JWT’leri oluşturmak ve çözümlemek için ayrı sınıflar kullanarak JWT üretip çözümleyecektir.

### Talimatlar:

1. Visual Studio Code’u açın ve yeni bir .NET Console App oluşturun:
   ```bash
   dotnet new console -n JwtDemo
   ```
2. Proje klasörüne gidin:
   ```bash
   cd JwtDemo
   ```
3. `Program.cs` dosyasını açın ve mevcut içeriği temizleyin.
4. Aşağıdaki bağımlılığı projeye ekleyin:
   1. `System.IdentityModel.Tokens.Jwt` NuGet paketini yükleyin:
      ```bash
      dotnet add package System.IdentityModel.Tokens.Jwt
      ```

---

## ✅ Adım 2: JwtCreator Sınıfı Oluşturma

Bu sınıf, JWT üretimini yönetecektir.

### Talimatlar:

1. `JwtCreator.cs` adlı yeni bir dosya oluşturun.
2. JWT üretmek için bir metoda sahip bir sınıf tanımlayın.

---

## ✅ Adım 3: JwtDecoder Sınıfı Oluşturma

Bu sınıf, JWT çözümlemeyi yönetecektir.

#### Talimatlar:

1. `JwtDecoder.cs` adlı yeni bir dosya oluşturun.
2. JWT’yi çözümlemek ve imzasını doğrulamak için bir metoda sahip bir sınıf tanımlayın.

Bu sınıf, JWT çözümlemeyi yönetecektir.

#### Talimatlar:

1. `JwtDecoder.cs` adlı yeni bir dosya oluşturun.
2. JWT’yi çözümlemek ve imzasını doğrulamak için bir metoda sahip bir sınıf tanımlayın.

---

## ✅ Adım 4: Main Metodunda Sınıfları Kullanma

Main metodunda, JWT üretmek ve çözümlemek için `JwtCreator` ve `JwtDecoder` sınıflarını kullanın.

#### Talimatlar:

1. `JwtCreator` sınıfından JWT oluşturma metodunu çağırın.
2. Üretilen token’ı çözümleme ve doğrulama için `JwtDecoder` sınıfına gönderin.
3. Uygulamayı çalıştırın:
   ```bash
   dotnet run
   ```
