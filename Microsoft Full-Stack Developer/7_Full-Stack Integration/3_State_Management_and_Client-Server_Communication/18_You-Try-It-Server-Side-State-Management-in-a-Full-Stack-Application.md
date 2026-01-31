## 🎯 Deneyin! Full-Stack Uygulamada Sunucu Tarafı Durum Yönetimi

### 🧩 Amaç

Bu etkinliğin sonunda, bir Blazor Server uygulamasında sunucu tarafı durumu verimli şekilde sürdürmek için oturum yönetimi ( *session handling* ) ve önbellekleme ( *caching* ) tekniklerini uygulayabileceksiniz.

---

## 🧱 Adım 1: Uygulama İçin Hazırlık

Visual Studio Code içinde küçük bir Blazor Server uygulaması oluşturacaksınız. Uygulama, oturumlar ve önbellekleme kullanarak sunucu tarafı durum yönetimini gösterecek.

**Talimatlar:**

Visual Studio Code’u açın ve terminalin hazır olduğundan emin olun.

Yeni bir Blazor Server uygulaması oluşturmak için aşağıdaki komutu çalıştırın:

```bash
dotnet new blazor -o BlazorServerApp
```

Yeni proje dizinine gidin:

```bash
cd BlazorServerApp
```

Projeyi Visual Studio Code içinde açın:

```bash
code .
```

`Program.cs` içindeki herhangi bir yer tutucu içeriği silin.

---

## 🕒 Adım 2: Oturum Yönetimini Yapılandırma

Oturum yönetimini etkinleştirmek için uygulamaya middleware ekleyin.

**Talimatlar:**

`Program.cs` dosyasını açın.

Dağıtık bellek önbelleği ( *distributed memory cache* ) ve oturum yönetimini yapılandırmak için kod ekleyin.

Oturum zaman aşımını **30 dakika** olarak ayarlayın ve güvenli çerez ( *secure cookie* ) seçeneklerini yapılandırın.

Uygulama hattına ( *pipeline* ) `app.UseSession()` eklendiğinden emin olun.

---

## 🗃️ Adım 3: Caching Servisi Oluşturma

Önbelleğe alınan veriyi yönetmek için bir servis uygulayın.

**Talimatlar:**

Projenin kök dizininde `Services` adlı yeni bir klasör oluşturun.

`Services` klasörüne `CacheService.cs` adlı bir dosya ekleyin.

Sık erişilen verileri saklamak ve geri almak için `IMemoryCache` kullanan bir caching servis sınıfı tanımlayın.

---

## 🧩 Adım 4: Servisleri Kaydetme

Oturum yönetimi ve caching servisini uygulama içinde kullanılabilir hâle getirin.

**Talimatlar:**

`Program.cs` dosyasını, bağımlılık enjeksiyonu ( *dependency injection* ) kapsayıcısına caching servisini ve `MemoryCache`’i dahil edecek şekilde güncelleyin.

`CacheService`’i kaydedin ve bileşenlere enjekte edilebilecek durumda olduğunu doğrulayın.

---

## 🌦️ Adım 5: Önbellek Kullanan Bir Bileşen Oluşturma

Önbellekleme servisini kullanarak veri getiren ve görüntüleyen bir Blazor bileşeni uygulayın.

**Talimatlar:**

`Pages` adlı bir klasör oluşturun ve `Pages` içinde `FetchData.razor` adlı yeni bir dosya oluşturun.

Caching servisini bileşene enjekte edin.

Hava durumu verisini almak ve **5 dakika** boyunca önbelleğe almak için mantık ekleyin.

---

## 🧾 Adım 6: Gelişmiş Oturum Yönetimini Etkinleştirme

Oturum yönetimini, kalıcı veri yönetimini kullanıcı dostu biçimde içerecek şekilde genişletin.

**Talimatlar:**

Oturum depolamayı basitleştirmek için **Blazored.SessionStorage** NuGet paketini yükleyin:

```bash
dotnet add package Blazored.SessionStorage
```

`Program.cs` dosyasını, bağımlılık enjeksiyonu kapsayıcısına session storage servisini ekleyecek şekilde güncelleyin.

Session storage üzerinden veri saklamak ve geri almak için bir Blazor bileşeni (ör. `Counter.razor`) oluşturun veya güncelleyin.

---

## ✅ Adım 7: Uygulamanızı Test Edin

Oturum ve önbellek işlevlerinin doğru çalıştığını doğrulamak için uygulamayı çalıştırın ve test edin.

**Talimatlar:**

Terminali kullanarak uygulamayı çalıştırın:

```bash
dotnet run
```

Uygulamayı tarayıcıda açın ve oturum ile önbellek özellikleriyle etkileşime girerek beklenildiği gibi davrandıklarını doğrulayın.
