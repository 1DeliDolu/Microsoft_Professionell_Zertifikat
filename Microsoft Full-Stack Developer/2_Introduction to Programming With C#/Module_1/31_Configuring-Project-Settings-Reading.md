## ⚙️ Giriş

Yeni bir .NET projesinin sorunsuz ve verimli çalışmasını sağlamak için başlangıç ayarlarını yapılandırmak üzere aşağıdaki adımları izleyin.

---

## 🛠️ Başlangıç Proje Ayarlarını Yapılandırma Adımları

### 📄 `.csproj` dosyasını bulun

Proje klasörünü açın ve `.csproj` dosyasını bulun. Bu dosya, projenin çalıştırma, test etme ve derleme işlemlerini nasıl yöneteceğini yapılandırır.

---

### 🧩 `.csproj` dosyasını anlayın

`.csproj` dosyası **XML** formatını kullanır. Etiketler, proje türü gibi ayarları (`<Project Sdk="Microsoft.NET.Sdk">`) ve hedef framework’ü (ör. `<TargetFramework>net8.0</TargetFramework>`) tanımlar.

```xml
<Project Sdk="Microsoft.NET.Sdk">
```

```xml
<TargetFramework>net8.0</TargetFramework>
```

---

### 📦 Proje bağımlılıklarını yönetin

Bağımlılıkları eklemek ve yönetmek için **NuGet Package Manager** kullanın. Komut paletini açın ve **"Add NuGet Package"** seçeneğini seçin, ardından istenen paketi arayın (ör.  **"Pastel"** ) ve en güncel sürümü seçin.

---

### ✅ Paket ekledikten sonra `.csproj` dosyasını doğrulayın

Yeni paketlerin `<PackageReference>` altında listelendiğini doğrulamak için `.csproj` dosyasını kontrol edin.

```xml
<PackageReference Include="Pastel" Version="5.1.0" />
```

---

### 🧠 Yeni paketleri kod içinde kullanın

Örneğin **"Pastel"** paketini kullanmak için kodunuza `using Pastel;` ekleyin. Ardından metin renklerini özelleştirmek için bunu uygulayın (ör. `color.Green`).

```csharp
using Pastel;
```

```csharp
color.Green
```

---

## ✅ Sonuç

Bu adımlar, .NET projenizi etkili şekilde kurmanıza yardımcı olacak ve tüm ayarların ve bağımlılıkların en baştan doğru biçimde yapılandırılmasını sağlayacaktır.
