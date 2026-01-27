
## 📚 .NET Kütüphaneleri

---

## 🧭 Giriş

Bu özet, .NET ortamlarında geliştirmeyi kolaylaştıran temel araçları ve kütüphaneleri kapsar. Konular; **NuGet paket yönetimine** genel bakışı ve .NET’te yaygın kullanılan  **Newtonsoft.Json** , **Dapper** ve **Serilog** gibi kütüphaneleri içerir. Bu araçların her biri, paket yönetimi, veri işleme ve uygulama logging’i gibi alanlarda farklı işlevler sunar.

---

## 📦 NuGet ve Paket Yönetimi

---

## 🧰 NuGet Genel Bakış

NuGet, .NET için özel olarak tasarlanmış paket yöneticisidir. Dependency yönetimini basitleştirir ve kütüphaneleri eklemeyi, güncellemeyi ve kaldırmayı kolaylaştırır. Bu, topluluk tarafından bakımı yapılan geniş bir pre-built paket deposuna erişim sağlayarak geliştirmeyi hızlandırır.

---

## ✅ Paketlerin Faydaları

* **Zaman verimliliği:** Pre-built paketler, yaygın özellikleri sıfırdan geliştirme ihtiyacını ortadan kaldırarak geliştiricilere zaman kazandırır.
* **Best practice:** Birçok paket performans ve güvenlik için endüstri standartlarını takip eder; projelere yüksek kaliteli ve güvenilir kod entegre edilmesini sağlar.
* **Bakım:** Çoğu paket, maintainers tarafından düzenli güncellemeler alır; bug fix ve iyileştirmelerin projeye kolay entegrasyonunu sağlar.

---

## 🧩 Paketleri Yönetme

* **Kurulum:** Paketler Visual Studio üzerinden veya .NET CLI ile paket adları ve sürümleri belirtilerek yüklenebilir.
* **Güncelleme:** Güncellemeler, sürüm numaralarını belirten komutlarla uygulanır; CLI ve VS Code araçları dependency ayarlarını gerektiğinde kolayca düzenlemeyi sağlar.
* **Kaldırma:** Bir paketi kaldırmak, proje dependencies listesinden seçmeyi ve CLI veya VS Code üzerinden remove komutunu çalıştırmayı içerir.

---

## 🧱 Yaygın .NET Kütüphaneleri

---

## 🔄 Newtonsoft.Json

.NET’te JSON işleme için popüler bir kütüphanedir ve web uygulamalarında JSON verisini yönetmek için yaygın olarak kullanılır.

### 🧩 Temel Özellikler

* **Parsing:** JSON verisini C# object’lerine dönüştürür; web API’lerden gelen verilerle çalışmak için gereklidir.
* **Serialization ve deserialization:** C# object’lerini JSON formatına ve tersine dönüştürür; API’ler üzerinden veri gönderip almak için kritiktir.

---

## 🗄️ Dapper

Veritabanı etkileşimlerini verimli hâle getiren hafif bir micro-ORM (Object-Relational Mapper) kütüphanesidir.

### ⚡ Temel Özellikler

* **Veri sorgulama:** SQL sorgu sonuçlarını doğrudan C# object’lerine map ederek sorgulamayı sadeleştirir.
* **Yüksek performans:** Hızlı veritabanı erişimi için tasarlanmıştır; performansın öncelikli olduğu uygulamalar için idealdir.
* **Kullanım kolaylığı:** Yalnızca temel veri erişimine ihtiyaç duyan basit uygulamalar için uygundur.

---

## 🧾 Serilog

Esnek logging yapılandırmaları ve output hedefleri destekleyen structured bir logging kütüphanesidir.

### 🛠️ Temel Özellikler

* **Hata takibi:** Detaylı error log’ları kaydeder; troubleshooting sürecini destekler.
* **Kullanıcı aktivitesi izleme:** User interaction’ları takip ederek kullanıcı deneyiminin optimize edilmesine yardımcı olur.
* **Log yönlendirme:** Cloud storage gibi birden fazla hedefi destekler; dağıtık sistemlerde log’ları merkezileştirir.

---

## 🧠 Kütüphaneleri Öğrenme ve Uygulamada Best Practice’ler

* **Online dokümantasyon:** Her kütüphane genellikle kullanım yönergeleri ve entegrasyon örnekleri içeren detaylı dokümantasyona sahiptir.
* **Örnek kod:** Dokümantasyon çoğu zaman tipik use case’leri göstermek için sample implementation’lar içerir.
* **Topluluk desteği:** Stack Overflow ve GitHub Discussions gibi forumlar, benzer problemlerle karşılaşmış diğer geliştiricilerden destek sunar.

---

## ✅ Sonuç

NuGet ile birlikte Newtonsoft.Json, Dapper ve Serilog gibi temel .NET kütüphanelerini kullanmak; geliştirme verimliliğini artırabilir, dependency yönetimini sadeleştirebilir ve uygulama güvenilirliğini iyileştirebilir. Paketleri nasıl yöneteceğini ve temel kütüphaneleri nasıl uygulayacağını anlamak, .NET projelerinde daha akıcı iş akışları ve daha iyi performans sağlar.

---
