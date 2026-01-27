## 📦 NuGet ve Paket Yönetimine Giriş

Modern yazılım geliştirmede verimlilik kritik öneme sahiptir. Harici kütüphaneleri ve bağımlılıkları nasıl yönettiğiniz ya zaman kazandırır ya da gereksiz karmaşıklık yaratır. NuGet gibi araçları anlamak ve kullanmak, kodunuzu yönetmenize ve projelerinizi hızlandırarak yaygın tuzaklardan kaçınmanıza yardımcı olur.

Bu videoda, NuGet’in .NET’te kütüphaneleri ve paketleri yönetmek için nasıl kullanıldığını açıklayacağız. Önce “paket” kavramının ne olduğunu ve geliştirmeye nasıl katkı sağladığını inceleyelim.

---

## 🧩 Paket Nedir?

Bir  **paket** , kütüphaneler, yapılandırma dosyaları ve metadata dahil olmak üzere yazılım bileşenlerinden oluşan bir pakettir. Bağımlılıkları projede dağıtmak, yüklemek ve yönetmek için standart bir yol sunarak kod paylaşımını ve yeniden kullanımı kolaylaştırır.

Örneğin, uygulamanızda logging ve error tracking’i yönetmek için bir paket kullanabilirsiniz. Bu paket, gerekli kütüphaneleri ve yapılandırma dosyalarını içerir; böylece bu bileşenleri kendiniz inşa etmek zorunda kalmazsınız.

---

## ✅ Paket Kullanmanın Faydaları

Paketlerin sağladığı faydaları biraz daha inceleyelim:

* Bu paketleri sıfırdan inşa etmek zorunda olmamak, geliştiriciye zaman kazandırır; bu zaman başka özelliklere ayrılabilir.
* Birçok paket, endüstri best practice’lerini takip eder ve performans ile güvenlik açısından optimize edilmiştir. Bu nedenle paket yüklemek, projelerinize yüksek kaliteli ve güvenilir kodu entegre etmenizi sağlar.
* Paketler genellikle bir topluluk ya da organizasyon tarafından bakım görür; bu da güncellemeler ve patch’ler sunulduğu anlamına gelir. Geliştiriciler en güncel sürüme kolayca geçebilir ve iyileştirmelerden ve bug fix’lerden yararlanabilir.

---

## 🧰 NuGet Nedir?

Geliştiricilerin paketleri neden kullandığını gördüğümüze göre, şimdi bu paketleri projeye nasıl dahil edeceğimizi anlamamız gerekiyor. Şimdi NuGet’in .NET’te kütüphane ve paket yönetimini nasıl sağladığına bakalım.

 **NuGet** , .NET ekosistemi için geliştirilmiş paket yöneticisidir. Harici kütüphaneleri projelere ekleme sürecini, önceden hazırlanmış paketlerin bulunduğu büyük bir repository sunarak kolaylaştırır.

.NET topluluğu bu paketleri paylaşır ve geliştiriciler uygulamalarını geliştirmek için bunları kullanabilir.

Örneğin, veri serialization için bir kütüphaneyi hızlıca bulup kurabilirsiniz; böylece bu özelliği kendiniz yazmak zorunda kalmazsınız.

---

## 🧱 Paket Yönetimi Neleri Kapsar?

Paket yönetimi şunları içerir:

* paketleri install etmek
* update etmek
* remove etmek
* projede configure etmek

Ayrıca harici kütüphanelerin veya araçların code base’inize doğru şekilde entegre edilmesini sağlar ve farklı paketler arasındaki dependency ilişkilerini yönetir.

---

## 🧑‍💻 VS Code ile NuGet Paketi Yükleme

Visual Studio Code’da NuGet paketlerini yüklemek için şu adımları izleyin:

* VS Code’u açın ve projenizi yükleyin.
* Command Palette’i açın ve **add-nuget-package** komutunu arayın.
* Arama çubuğuna eklemek istediğiniz paketin adını yazın; bu örnekte `Newtonsoft.json`.
* Paketi bulduktan sonra projenizi seçin.
* Son olarak istediğiniz paket sürümünü seçin; genellikle en güncel sürüm olur, bu örnekte  **13.0.3** .

---

## 🖥️ .NET CLI ile Paket Yükleme

Komut satırını tercih ediyorsanız, .NET CLI ile paket yükleme şöyle yapılır:

* Terminal veya command prompt’u açın.
* `cd` komutu ile proje klasörünüze gidin (tam path ile).
* Ardından `.NET add-package` komutunu ve yüklemek istediğiniz paket adını yazın; yine bu örnekte `Newtonsoft.json`.

Kurulumdan sonra paket, solution manager’da dependencies altında listelendiği için projenizin bir parçası olur.

---

## 🔄 Paket Güncelleme ve Kaldırma

VS Code veya .NET CLI kullanıyor olsanız da, bazen paketleri update etmek veya remove etmek gerekir.

---

## 🔼 Paket Güncelleme

VS Code’ta:

* Command Palette’i açın ve **update NuGet package** komutunu seçin.
* Güncellemek istediğiniz paketi seçin. Örneğin eski bir `Newtonsoft.json` sürümünü seçebilirsiniz.
* Sonra güncellemek istediğiniz sürümü sorar. Bu örnekte `Newtonsoft.json`’u  **12.0.1** ’den  **13.0.3** ’e güncelleyelim.

CLI ile:

* `.NET add-package` komutunu, paket adını, ardından `--version` ve hedef sürüm numarasını yazarak upgrade ya da downgrade yapabilirsiniz.

---

## 🗑️ Paket Kaldırma

VS Code’ta:

* Command Palette’i açın ve **NuGet package manager remove package** komutunu seçin.
* Kaldırmak istediğiniz paketi seçin; bu örnekte `Newtonsoft.json`.
* VS Code, paketin kaldırıldığını belirten bir onay mesajı gösterir.

CLI ile:

* `.NET remove package` komutu ve ardından paket adı yazılarak kaldırılır.

---

## 🧬 Dependency ve Versioning

Şimdi NuGet ile paket yönetiminin dependency ve versioning tarafının nasıl çalıştığına bakalım.

Bir  **dependency** , bir class’ın veya fonksiyonun görevlerini yerine getirmek için ihtiyaç duyduğu harici bir object veya servistir.

NuGet ile bir paket yüklediğinizde, o paket kodunuzun bir dependency’si olur ve kendisi de başka paketlere bağımlı olabilir. NuGet tüm bu bağımlılıkları arka planda otomatik olarak çözer; doğru sürümleri indirir ve kurar. Sizin düşünmeniz gereken tek şey, kodunuzun doğrudan bağımlı olduğu paketlerdir.

Kod evrildikçe, sık sık yeniden yazılması gerekir; bu da ona bağlı olan başka kodlar için problem yaratabilir. Bunu yönetmek için geliştiriciler **versioning** fikrini ortaya koymuştur.

Versioning, bir programın evrimindeki belirli bir “snapshot”a bir kimlik atar. Diğer bağlamlarda v1, v2, v3 gibi sürümler görmüş olabilirsiniz. Büyük numara genellikle daha yeni sürümü ifade eder.

Ancak basit versioning şemasının bir sınırlaması vardır: değişikliğin türünü belirtmez; küçük bir güncelleme mi, yoksa uyumluluğu kıran büyük bir değişiklik mi?

Uyumluluğu bozan sürümlere **major version** deriz. Non-breaking bir değişikliği belirtmek için ikinci bir sayı ekleriz; bu, mevcut işlevselliği bozmadan yeni özellikler ekleyen  **minor version** ’dır.

Son olarak, kodun çalışma biçimini değiştirmeyen ama stabiliteyi artıran patch veya bug fix’ler için üçüncü bir sayı ekleriz. Buna **patch** veya **fix version** denir.

Bu şema **semantic versioning (semver)** olarak adlandırılır ve NuGet’te gördüğümüz sürümlerin `number.number.number` formatında olmasının sebebidir.

* ilk sayı: **major**
* ikinci sayı: **minor**
* üçüncü sayı: **patch**

Bu, projelerimizi kırmadan güncel kod kullanmamıza yardımcı olur.

---

## 🔒 Sürüm Kilitleme ve Sürüm Aralığı

Versioning bilgisiyle birlikte, NuGet’in projelerinizde paket sürümlerini nasıl ele alacağını kontrol edebilirsiniz.

Örneğin, kodunuzun beklenmedik değişiklikler olmadan uyumlu kalmasını istiyorsanız, bir paketin belirli bir sürümünü kilitleyebilirsiniz; örneğin  **10.4.31** .

Bu, yalnızca tam olarak o sürümün kullanılacağını garanti eder ve güncellemelerin projenizi etkilemesini engeller. Siz açıkça söylemediğiniz sürece NuGet asla 10.4.32 veya başka bir sürümü kullanmaya çalışmaz; değişiklik ne kadar küçük olursa olsun.

Buna karşılık, minor güncellemeler veya bug fix’lere açıksanız ama breaking değişikliklerden kaçınmak istiyorsanız, bir sürüm aralığı belirleyebilirsiniz.

Örneğin `1.0,2.0` aralığını ayarlamak, 1.0.0’dan 2.0.0 dahil olmadan önceki sürümlere kadar güncellemelere izin verir. NuGet 1.0.0 veya 1.9.31 kullanabilir, ama 0.9.1 ya da 2.1.14 kullanamaz.

Bu, yeni özellikleri ve patch’leri alırken major breaking değişiklik riskini azaltır.

Birden fazla kütüphane aynı paketin farklı sürümlerine bağımlıysa, NuGet en uyumlu sürümü seçerek çakışmaları çözmeye çalışır.

Bu, projenizin stabil kalmasını ve amaçlandığı gibi çalışmasını sağlar.

---

## ✅ Videonun Özeti

Bu videoda, NuGet’in .NET’te paket yönetimini nasıl basitleştirdiğini ve harici kütüphaneler ile dependency’lerle çalışmayı nasıl kolaylaştırdığını öğrendiniz.

Bu süreçleri anlayarak artık .NET projelerinizde kütüphaneleri ve paketleri verimli biçimde yönetebilir, dependency conflict veya versioning problemleriyle uğraşmadan benzersiz özellikler geliştirmeye odaklanabilirsiniz.
