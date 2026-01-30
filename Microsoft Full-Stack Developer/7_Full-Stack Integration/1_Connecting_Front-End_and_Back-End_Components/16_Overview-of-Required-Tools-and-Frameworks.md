## 🧰 Overview of Required Tools and Frameworks

Kullanıcıya dönük front-end ile güçlü back-end arasında sorunsuz biçimde bağlanan uygulamalar geliştirmek, ölçeklenebilir ve verimli sistemler oluşturmak için kritik önemdedir. Bunu başarmak için, full-stack geliştirmede doğru araçları ve framework’leri anlamak gerekir.

Bu videoda, framework seçimine odaklanarak full-stack geliştirme için gerekli front-end ve back-end araçlarını belirleyeceğiz.

---

## 🌐 Blazor: Kullanıcı Etkileşimini Sağlayan Front-End Framework’ü

Full-stack geliştirmede kullanılan bazı araç ve framework’leri, kullanıcıların uygulamayla etkileşim kurmasını sağlayan **Blazor** ile başlayarak inceleyelim.

Blazor, **C Sharp** ve **.NET** kullanarak etkileşimli web uygulamaları geliştirmenizi sağlayan bir framework’tür. Blazor ile geliştiriciler, veriyi dinamik olarak güncelleyen güçlü bir kullanıcı arayüzü oluşturabilir; böylece kullanıcılar etkileşimli bir UI deneyimi yaşar.

Örneğin Blazor, bir katalogda ürünleri filtreleme gibi özellikleri mümkün kılar. Bu, kullanıcıların ürünleri hızlıca bulmasına ve uygulamayla sorunsuz etkileşim kurmasına yardımcı olur.

---

## 🔌 Minimal APIs: Veri İşleme ve Uygulamanın “Motoru”

Şimdi, uygulamaları güçlendiren ve veri işlemeyi yöneten minimal API’leri inceleyelim.

 **Minimal APIs** , .NET’te API oluşturmanın hafif (lightweight) bir yoludur ve sunucu tarafı mantık (server-side logic) ile routing’i mümkün kılar. Back-end geliştirmeyi sadeleştirir ve Blazor gibi front-end araçlarıyla kolayca bağlanır.

Minimal API’ler, front-end ile back-end arasında birer bağlayıcı (connector) gibi çalışır.

Örneğin, ürün detayları gibi verileri verimli biçimde getirir (fetch) ve uygulamanızın güncel, doğru bilgi göstermesini sağlar.

---

## 🗄️ SQL Server (veya MySQL): Güvenli Veri Depolama

Minimal API’lerin yanında, uygulama verisini güvenli biçimde saklamak ve yönetmek için **MySQL** veya **SQL Server** gibi güvenilir bir veritabanı yönetim sistemine ihtiyaç vardır.

Microsoft’un  **SQL Server** ’ı, kalıcı veriyi (persistent data) saklamak için kullanılan ilişkisel bir veritabanı yönetim sistemidir ve .NET araçlarıyla sorunsuz biçimde entegre olur.

SQL Server; bankacılık sistemleri, e-ticaret platformları ve iş zekâsı (business intelligence) çözümleri gibi güvenilir, güvenli ve yüksek performanslı veri depolama gerektiren kurumsal ortamlarda yaygın olarak kullanılır.

SQL Server, müşteri detayları ve ürün envanterleri gibi verileri güvenli şekilde saklar ve erişilebilir kılar; ayrıca ürün araması gibi özellikleri de mümkün hâle getirir.

---

## 🧩 Entity Framework Core: ORM ile Veritabanı Etkileşimini Kolaylaştırma

Veritabanlarını yönetmek, **Entity Framework Core** gibi araçlarla daha da kolaylaşır.

Entity Framework Core, SQL Server gibi veritabanlarıyla .NET uygulamaları arasındaki etkileşimi basitleştiren bir  *object-relational mapper (ORM)* ’dır.

Entity Framework Core bir köprü (bridge) görevi görür; geliştiricilerin basit komutlarla veriyi almasına (retrieve) veya kaydetmesine (store) olanak tanır. Ayrıca, SQL sorguları yazmak yerine verilerle nesneler (objects) olarak çalışmayı sağlar.

---

## 🔄 Git: Sürüm Kontrolü ve Ekip İş Birliği

Son olarak, Git kullanarak kodunuzu nasıl takip edeceğinizi ve başkalarıyla nasıl etkili şekilde iş birliği yapacağınızı gözden geçirelim.

 **Git** , kod değişikliklerini takip eden ve ekiplerin birlikte çalışmasına yardımcı olan bir sürüm kontrol sistemidir. Geliştiricilerin kodu oluşturmasına, düzenlemesine ve birleştirmesine (merge) izin verirken; projede yapılan her değişikliğin tam bir geçmişini de saklar.

Git, iş birliğine dayalı yazılım geliştirmede yaygın biçimde kullanılır ve **GitHub** ile **GitLab** gibi platformların temelini oluşturur.

---

## 🔗 Bu Araçlar Birlikte Nasıl Çalışır?

Şimdi full-stack geliştirme için tanıttığımız bu araçların birlikte nasıl çalıştığını inceleyelim:

* **Blazor** , kullanıcı arayüzünü çalıştırır; müşterilerin öğeleri sorunsuz biçimde gezmesine ve filtrelemesine olanak tanır.
* **Minimal APIs** , filtrelenmiş veriyi sunucudan alır; böylece bilginin doğru ve güncel olmasını sağlar.
* **SQL Server** , ürün bilgisini güvenli şekilde depolar.
* **Entity Framework** , ihtiyaç duyulduğunda bu veriyi erişilebilir hâle getirir.
* **Git** , geliştirme ekibinin kod değişikliklerini yönetmesine yardımcı olur; birbirlerinin çalışmalarının üzerine yazma veya çatışma (conflict) oluşturma riskini azaltarak iş birliğini mümkün kılar.

---

## ✅ Kapanış

Bu videoda, framework seçimine odaklanarak full-stack geliştirme için gerekli front-end ve back-end araçlarını öğrendiniz.

Bu araçlar birlikte, güçlü bir client-server uygulaması oluşturmak için gereken temeli sağlar.
