
## 🧩 Arka Uç Geliştirme için Git Temelleri

Kalabalık bir mutfakta çalışan bir şef olduğunuzu ve ekibinizle birlikte karmaşık bir tarifi mükemmelleştirmeye çalıştığınızı hayal edin. Her biriniz, benzersiz tekniklerinizle katkı sağlıyor; malzemeleri ayarlıyor ve farklı yaklaşımlar deniyorsunuz. Peki ya herhangi bir anda, kimin ne eklediğini görebilseydiniz ve aynı zamanda birden fazla şef, orijinal yemeği etkilemeden aynı anda farklı varyasyonlar deneyebilseydi?

Git, arka uç geliştirmede tam olarak bunu yapmanıza imkân tanır: değişiklikleri takip etmek, gerçek zamanlı iş birliği yapmak ve yeni fikirler denemek; üstelik kod tabanınızın bütünlüğünü koruyarak.

Bu videoda, temel Git komutlarını ve arka uç geliştirmede kullanım amaçlarını açıklayacağız.

Sürüm kontrolü ( *version control* ) kritiktir; çünkü koda yapılan tüm değişiklikleri takip eder, birden fazla geliştiricinin aynı anda birlikte çalışmasını sağlar, önceki sürümlere kolay geri dönüş ( *reversion* ) imkânı verir ve geliştiricilerin ana kod tabanını ( *main code base* ) etkilemeden yeni özellikler veya düzeltmeler üzerinde çalışmasına olanak tanır.

---

## 🧰 Git ve GitHub

Başka sürüm kontrol sistemleri olsa da, çoğu geliştirici sürüm kontrolü için Git kullanır.

Git, geliştiricilerin değişiklikleri takip etmesine, iş birliği yapmasına ve kodun geçmişini ( *history* ) korumasına yardımcı olan dağıtık ( *distributed* ) bir sürüm kontrol sistemidir. Git’i, her şefin ihtiyaç duyduğu bıçak ve kesme tahtaları gibi temel mutfak araçları olarak düşünün; bu araçlar, tariflerin farklı sürümlerini oluşturmayı ve yönetmeyi sağlar.

GitHub ise merkezi bir mutfak gibidir; tüm şefler tariflerini ve araçlarını burada saklar, yemeklerini sergiler ve diğer uzmanlarla iş birliği yapar.

Peki Git, geliştiricilerin kod geçmişini korumasını, değişiklikleri takip etmesini ve birlikte çalışmasını nasıl sağlar?

Git, depolar ( *repositories* ) ve dallanma ( *branching* ) kullanımına dayanır.

---

## 🗂️ Repository (Depo) Nedir?

Git’te bir depo ( *repository* ), bir projeyle ilgili tüm dosyaların, bu dosyaların tüm değişiklik geçmişiyle birlikte saklandığı depolama alanıdır.

Bu depolar, kodun tüm sürümlerinin anlık görüntülerini ( *snapshots* ) tutar; geliştiricilerin değişiklikleri izlemesine, geçmişi korumasına ve gerekirse önceki bir sürüme geri dönmesine ( *rollback* ) olanak sağlar.

---

## 🌿 Branching (Dallanma) Nedir?

Şimdi dallanmayı ( *branching* ) inceleyelim.

Ana kodu ana dal ( *main branch* ) olarak düşünürsek, geliştiriciler yeni kod eklemeleri veya mevcut kodda değişiklik yapmaları gerektiğinde başka dallar oluşturur.

Dallanmayı, bir klasörün kopyasını oluşturmak gibi düşünün; yeni bir dal oluşturulduğunda, bu bir kopya oluşturmak gibidir. Geliştiriciler, bu kopyadaki belgeleri orijinali etkilemeden ekleyebilir, değiştirebilir ve test edebilir.

Düzenlemelerin doğru ve kararlı ( *stable* ) olduğundan emin olduktan sonra, değişiklikleri tekrar ana dala birleştirebilir ( *merge* ), ana dalı tüm yeni değişikliklerle güncelleyebilirler.

Geliştiriciler, Git ve GitHub yardımıyla depoları ve dallanmayı kullanarak kodlarını yönetir.

---

## ⌨️ Git ile Nasıl Çalışılır? Komutlar

Peki geliştiriciler bu araçlarla nasıl etkileşime girer?

Komut çalıştırırlar. Geliştiriciler komutları komut satırından ( *command line* ) veya GitHub gibi bir uygulama üzerinden çalıştırır.

Bu komutlar şunları içerir:  *clone* ,  *branch* ,  *commit* , *push* ve  *pull* .

Şimdi her bir komutu ayrıntılı inceleyelim; *clone* ile başlayarak.

---

## 📥 `clone`

*clone* komutu, geliştiricinin üzerinde çalıştığı deponun yerel ( *local* ) bir kopyasını oluşturur. Bu, kod tabanı üzerinde kendi bilgisayarında çalışmaya başlamasını sağlar.

*clone* komutunu kullanmak için şunu yazarsınız:

```bash
git clone <repository-url>
```

Örneğin, kullanıcı kimlik doğrulaması için yeni bir özellik geliştiriyorsanız, önce mevcut projeyi makinenize klonlarsınız.

---

## 🌿 `branch`

*clone* komutuyla deponun yerel kopyasını aldıktan sonra, sonraki adım yeni bir dal oluşturmaktır.

Dallanma, ana kod tabanını etkilemeden belirli özellikler veya düzeltmeler üzerinde çalışmanızı sağlar; değişiklikler birleştirilmeye hazır olana kadar izole kalır.

Örneğin, kullanıcı kimlik doğrulama özelliğiniz için yeni bir dal oluşturmak üzere şunu yazarsınız:

```bash
git branch feature-authentication
```

Artık geliştirme çalışmalarına başlamaya hazırsınız.

---

## 🧾 `commit`

Kod yazdıktan veya mevcut kodda bazı değişiklikler yaptıktan sonra, kodunuzu *commit* edersiniz.

*commit* komutu, projedeki değişikliklerin bir anlık görüntüsünü ( *snapshot* ) yakalar. Bu, ilerlemenizi takip etmenize ve gerekirse önceki bir sürüme geri dönmenize olanak tanır.

*commit* komutunu kullanmak için şunu yazarsınız:

```bash
git commit -m "commit message"
```

*commit* komutları bir *commit message* içerir. Bu mesaj, geliştiricilerin kod tabanında hangi değişikliklerin yapıldığını açıklamak için anlamlı bir mesaj yazdığı bölümdür.

Örneğin, bir kayıt formunun temel yapısını oluşturduktan sonra şöyle bir mesajla *commit* edebilirsiniz:

```bash
git commit -m "Initialize user registration form"
```

---

## 📤 `push`

Tüm değişikliklerinizi tamamladıktan sonra *push* komutunu kullanabilirsiniz.

*push* komutu, yerel değişikliklerle uzak depoyu ( *remote repository* ) günceller; böylece diğerleri bu güncellemeleri görebilir ve kullanabilir.

*push* komutunu kullanmak için şunu yazarsınız:

```bash
git push <remote-name> <branch-name>
```

Yeni kullanıcı kayıt özelliğinizin geliştirilmesi ve test edilmesinden memnun kaldığınızda, işinizi GitHub’a göndermek için şöyle yazarsınız:

```bash
git push origin feature-authentication
```

Bu, *feature-authentication* dalındaki tüm  *commit* ’lerinizi yükler.

---

## 📥 `pull`

Ertesi gün bir sonraki özellik üzerinde çalışmaya hazırsınız; bu yüzden *pull* komutunu çalıştırırsınız.

*pull* komutu, uzak depodaki en son değişiklikleri yerel kod tabanınıza indirerek ( *updates your local codebase* ) en güncel sürüme sahip olmanızı sağlar.

*pull* komutunu kullanmak için şunu yazarsınız:

```bash
git pull <remote-name> <branch-name>
```

Depodaki kodun en son sürümünü almak için şöyle kullanırsınız:

```bash
git pull origin feature-authentication
```

En son güncellemeleri aldıktan sonra, güncellenmiş ana daldan yeni bir dal oluşturmak için tekrar *branch* komutunu kullanabilir ve bir sonraki özelliğiniz üzerinde çalışmaya başlayabilirsiniz.

Bu iş akışı, projenin bütünlüğünü ve sürekliliğini korur; tüm geliştiricilerin iş birliği içinde ve verimli şekilde çalışmasını sağlar.

---

## ✅ Kapanış

Bugün, arka uç geliştirmede temel Git komutlarını ve kullanım amaçlarını ele aldık;  *clone* ,  *branch* ,  *commit* , *push* ve *pull* dahil.

Bu komutları anlamak; değişiklikleri takip etmek, ekip üyeleriyle iş birliği yapmak ve güvenilir bir kod geçmişi sürdürmek için gereklidir.

Git’i geliştirme iş akışınıza entegre etmek, verimliliğinizi ve üretkenliğinizi önemli ölçüde artıracaktır.
