## 🪟 Adım 2: Local Storage Uygulaması

Local storage kullanarak kullanıcının tema tercihini kaydetmek ve geri almak için bir özellik oluşturacaksınız.

**Talimatlar:**

**Blazored.LocalStorage** NuGet paketini yükleyin:

```bash
dotnet add package Blazored.LocalStorage
```

`Program.cs` dosyasını açın ve local storage servisini kaydedin.

`Pages` klasöründe, bir tema seçici UI oluşturmak için `Home.razor` dosyasını düzenleyin.

Kullanıcının tema tercihini local storage’a kaydetmek ve başlatma sırasında geri almak için gerekli mantığı ekleyin.v

---

## 🧺 Adım 3: Session Storage Kullanımı

Oturuma özel verileri yönetmek için session storage kullanan bir alışveriş sepeti sayfası oluşturacaksınız.

**Talimatlar:**

**Blazored.SessionStorage** NuGet paketini yükleyin:

```bash
dotnet add package Blazored.SessionStorage
```

`Program.cs` içinde session storage servisini kaydedin.

`Pages` klasöründe `Cart.razor` adlı yeni bir Razor bileşeni oluşturun.

Öğe eklemek için bir input alanı ve öğeleri görüntülemek için bir liste içeren alışveriş sepeti için basit bir UI tasarlayın.

Sepetin içeriğini kaydetmek ve başlatma sırasında geri almak için session storage kullanın.

---

## 🧹 Adım 4: Depolamayı Temizleme

Local ve session storage’daki tüm saklanan verileri temizlemek için işlevsellik ekleyeceksiniz.

**Talimatlar:**

`Home.razor` dosyasını açın ve bir **"Clear All Storage"** butonu ekleyin.

Butona tıklandığında hem local storage’ı hem de session storage’ı temizlemek için mantığı yazın.

Uygulamayla etkileşime girerek ve butona bastığınızda verilerin temizlendiğini doğrulayarak işlevselliği test edin.
