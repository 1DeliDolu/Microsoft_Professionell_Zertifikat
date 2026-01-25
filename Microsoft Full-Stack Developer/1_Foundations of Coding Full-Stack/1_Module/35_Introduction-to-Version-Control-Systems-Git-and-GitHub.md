
## 🧰 Sürüm Kontrol Sistemlerine Giriş (Git ve GitHub)

## 📝 Arka Uç Geliştirme için Git ve GitHub’a Giriş

 *Git* , geliştiricilerin kod değişikliklerini yönetmesine, ekip üyeleriyle iş birliği yapmasına ve çalışmalarının geçmişini tutmasına olanak tanıyan güçlü bir sürüm kontrol sistemidir.  *GitHub* , Git’in üzerine inşa edilmiştir ve iş birliğine dayalı geliştirme için ek araçlar sunarak ekiplerin arka uç projelerinde etkili biçimde birlikte çalışmasını kolaylaştırır.

---

## ⌨️ Temel Git Komutları

### 📥 Clone

*clone* komutu, uzak ( *remote* ) bir sunucudaki mevcut bir deponun ( *repository* ) yerel ( *local* ) bir kopyasını oluşturur. Bu komut, geliştiricilerin bir projenin tüm dosyalarını, *commit* geçmişini ve dallarını ( *branches* ) kendi bilgisayarına indirmesini sağlar. Klonlama, mevcut bir projede çalışmaya başlarken ilk adımdır. Örneğin, bir geliştirici projeyi değiştirmek veya proje yapısını anlamak için bir depoyu klonlayabilir.

### 🌿 Branch

Git’te dallanma ( *branching* ), geliştiricilerin ayrı geliştirme çizgileri oluşturmasına olanak tanır; böylece ana kod tabanını ( *main codebase* ) etkilemeden yeni özellikler veya hata düzeltmeleri üzerinde çalışabilirler. Bir dal, değişikliklerin izole biçimde yapılabildiği paralel bir depo sürümü gibidir. Geliştiriciler dalları genellikle özellik geliştirmek, hataları düzeltmek veya ana projeyi bozmadan denemeler yapmak için kullanır. Değişiklikler incelenip onaylandıktan sonra ana dala birleştirilir ( *merged* ).

### 🧾 Commit

*commit* komutu, projedeki değişiklikleri takip etmek için kritiktir. Her  *commit* , depoyu belirli bir zamanda alınmış bir anlık görüntü ( *snapshot* ) olarak kaydeder ve yapılan değişiklikleri açıklayan bir mesajla birlikte saklar.  *Commit* ’ler, geliştiricilerin çalışmalarını belgelemesine, ilerlemeyi takip etmesine ve gerekirse önceki durumlara geri dönmesine ( *revert* ) olanak veren kontrol noktaları ( *checkpoints* ) gibidir. Anlamlı bir  *commit message* , ekibin hangi değişikliklerin yapıldığını ve neden yapıldığını anlamasına yardımcı olur; bu da daha iyi iş birliğini destekler.

### 📤 Push

Yerelde ( *locally* ) *commit* edilen değişikliklerden sonra, *push* komutu bu değişiklikleri GitHub’daki uzak depoya yükler. Bu komut, geliştiricinin yerel  *commit* ’lerini ekibin geri kalanıyla paylaşır; böylece diğerleri bu değişiklikleri inceleyebilir, test edebilir ve kullanabilir. Değişiklikleri sık *push* etmek, uzak deponun güncel kalmasını sağlar ve birden fazla ekip üyesi aynı kod tabanı üzerinde çalışırken çatışmaları ( *conflicts* ) azaltır.

### 📥 Pull

*pull* komutu, uzak depodaki değişiklikleri yerel depoya getirir ( *fetches* ) ve birleştirir ( *merges* ). Bu, geliştiricinin yerel kod kopyasının ekipten gelen en son güncellemelerle senkronize olmasını sağlar. Birden fazla geliştiricinin aynı anda değişiklik yaptığı iş birliğine dayalı ortamlarda bu önemlidir. Düzenli olarak *pull* yapmak, birleştirme çatışmalarını ( *merge conflicts* ) önlemeye yardımcı olur ve herkesin en güncel kodla çalışmasını sağlar.

---

## 🤝 İş Birlikçi Arka Uç Geliştirme için GitHub Kullanımı

### 🗂️ Repository Oluşturma ( *Creating a Repository* )

Bir GitHub deposu ( *repository* ), projenin kodunun saklandığı merkezi konumdur. İş birliğine başlamak için geliştiriciler GitHub’da oturum açarak, depolar bölümüne giderek ve **“New Repository”** seçeneğini seçerek bir depo oluşturur. Depolar, projenin ihtiyaçlarına bağlı olarak *public* veya *private* olabilir. Bu depo, tüm dosyalar,  *commit* ’ler ve iş birliğine dayalı aktiviteler için ana merkez ( *home base* ) hâline gelir.

### 🌿 Dalları Yönetme ( *Managing Branches* )

Dallar, paralel geliştirme çabalarını yönetmek için gereklidir. GitHub’da dallar, ekiplerin ana kod tabanını etkilemeden farklı özellikler veya düzeltmeler üzerinde aynı anda çalışmasına olanak tanır. Geliştiriciler ana projeden dallar oluşturabilir, bağımsız çalışabilir ve hazır olduklarında değişikliklerini birleştirebilir. Etkili dal yönetimi; isimlendirme kurallarını ( *naming conventions* ) ve sorunsuz entegrasyon için düzenli güncellemeleri içerir.

### 🔀 Pull Request Gönderme ( *Submitting Pull Requests* )

 *Pull request* ’ler, GitHub üzerinde iş birlikçi çalışmanın temel özelliklerinden biridir. Geliştiricilerin kod tabanında değişiklik önermesine, inceleme talep etmesine ve değişiklikler ana dala birleştirilmeden önce ekiple birlikte tartışmasına olanak tanır. Bir  *pull request* , değişikliklerin net bir geçmişini oluşturur, hesap verebilirliği ( *accountability* ) destekler ve kodun kalite standartlarını karşılamasını sağlar. Bu süreç hataları azaltır ve ana dalın kararlılığını ( *stability* ) korur.

### 🔎 Kod İncelemesi Yapma ( *Conducting Code Reviews* )

Kod incelemeleri ( *code reviews* ), yüksek kaliteli bir kod tabanını sürdürmenin kritik bir parçasıdır. GitHub’da ekip üyeleri, bir  *pull request* ’te önerilen değişiklikleri inceleyebilir; hataları kontrol edebilir, kodlama standartlarına uyumu sağlayabilir ve iyileştirmeler önerebilir. Kod incelemeleri, bilgi paylaşımını teşvik eder, hataları azaltır ve kod kalitesini artırır. İnceleme süreci genellikle kodun belirli satırlarına yorum yapmayı, değişiklik istemeyi ve  *pull request* ’i birleştirme için onaylamayı ( *approving* ) içerir.

---

## ✅ Sonuç

Git komutlarını ve GitHub’ı etkili biçimde kullanarak arka uç geliştiriciler kodlarını yönetebilir, verimli iş birliği yapabilir ve sağlam ve kararlı bir proje sürdürebilir.

Bu araçlar; değişiklikleri takip etmeye, ekip çalışmasını mümkün kılmaya ve kod tabanının geliştirme boyunca temiz ve işlevsel kalmasını sağlamaya yardımcı olur.
