
## 🤝 İş Birlikçi Arka Uç Geliştirme için GitHub Kullanımı

Son teknoloji bir tele-tıp ( *telemedicine* ) uygulaması geliştirmekle görevli bir ekibe katıldığınızı hayal edin. Sanal görüşmeler ( *virtual consultations* ), hasta kayıt yönetimi ( *patient record management* ) ve randevu planlama ( *appointment scheduling* ) gibi özellikleri hayata geçirmekten siz sorumlusunuz. Birlikte, yenilikçi fikirleri sağlık hizmetlerini dönüştürebilecek tam işlevli bir platforma dönüştüreceksiniz.

Herkesin aynı sayfada kalmasını sağlamak için ekibiniz, sorunsuz iş birliği, değişiklik takibi ve verimli akran incelemeleri ( *peer reviews* ) sağlayan güçlü bir sürüm kontrol sistemi olan GitHub’a güvenir.

Bu videoda, iş birlikçi arka uç geliştirme için GitHub’ın nasıl kullanılacağını açıklayacağız.

GitHub, yalnızca kod saklanan bir yerden daha fazlasıdır. Projenin yaşam döngüsü ( *life cycle* ) boyunca iş birliğini mümkün kılar ve herkesin katkısının sorunsuz biçimde bir araya gelmesini sağlar.

Geliştiricilerin izole şekilde çalışıp işlerini en sonda birleştirmeye çalıştığı ve çatışma ( *conflict* ) ile hatalara açık olan bir süreç yerine, GitHub geliştiricilerin katkılarının ekibin çalışmasıyla nasıl uyumlandığını sürekli gözlemlemesine olanak tanır; böylece sorunsuz entegrasyon sağlanır.

Ayrıca verimliliği ve proje genelinde tutarlılığı artırmak için ortak kütüphaneler ( *common libraries* ), araçlar ( *tools* ) ve kod parçacıkları ( *code snippets* ) gibi kaynakların paylaşılmasını sağlar ve kodlama, inceleme, test ve build süreçleri için net iş akışlarının takip edilmesine yardımcı olur.

GitHub’ın iş birliği için neden bu kadar güçlü bir araç olduğunu ele aldığımıza göre, şimdi geliştiricilerin gerçekten nasıl birlikte çalışabileceğini inceleyelim.

GitHub kullanarak hem iş birliği yapabilir hem de proje yönetebilirsiniz; bunun için bir depo ( *repository* ) oluşturur, dalları ( *branches* ) yönetir, *pull request* gönderir ve kod incelemeleri ( *code reviews* ) gerçekleştirirsiniz.

---

## 🗂️ Depo Oluşturma ( *Creating a Repository* )

Projeniz nerede başlar? Her şey bir depo ( *repository* ) oluşturarak başlar; bu, tüm kodunuz ve iş birliğiniz için ana merkezdir ( *home base* ).

Bir depo oluşturmak, GitHub’a giriş yapmayı, depo bölümüne ( *repository section* ) gitmeyi ve *new* düğmesine tıklamayı içerir.

Deponuz için bir isim, isteğe bağlı ( *optional* ) bir açıklama ( *description* ) sağlamanız ve deponun herkese açık ( *public* ) mı yoksa özel ( *private* ) mi olacağını seçmeniz gerekir.

Örneğin, yeni bir projeye GitHub’da *Telemedicine App* adlı bir depo oluşturarak başlayabilir ve hassas hasta verisini korumak için deponuzu *private* yapabilirsiniz.

Depo hazır olduğunda, ekibiniz geliştirmeye başlamaya hazırdır. Peki birden fazla kişi, birbirinin kodunu ezmeden ( *overwriting* ) projenin farklı bölümleri üzerinde nasıl çalışır?

---

## 🌿 Dalları Yönetme ( *Managing Branches* )

İşte burada dal yönetimi devreye girer.

Bir dal ( *branch* ) oluşturmak için deponuza GitHub’da gidin ve *branch* açılır menüsünü ( *branch drop-down menu* ) kullanarak yeni bir dal oluşturun.

İsimlendirme kuralları ( *naming conventions* ) genellikle üzerinde çalışılan özellik ( *feature* ) veya düzeltmeyi ( *fix* ) içerir.

Tele-tıp uygulamanız için, ana dalın ( *main branch* ) kararlı ve üretime hazır ( *production-ready* ) kalmasını sağlamak üzere yeni özellik olan *virtual consultations* için bir dal oluşturabilirsiniz.

---

## 🔀 Pull Request Gönderme ( *Submitting a Pull Request* )

Dalınızda ilerleme kaydettikten sonra, artık değişikliklerinizi ana projeye geri birleştirmenin ( *merge* ) zamanı gelir.

Bunu sorunsuz ve denetimli ( *with oversight* ) biçimde yapmak için bir *pull request* gönderirsiniz.

Bir dala değişiklikleri *commit* ettikten sonra, deponuzdaki *pull request* sekmesine gidin ve **"New Pull Request"** seçeneğine tıklayın.

Ardından iki dal arasındaki değişiklikleri karşılaştırabilir ( *compare changes* ) ve önerilen değişikliklerin açıklamasını ( *description* ) sağlayabilirsiniz.

Örneğin, uyguladığınız yeni sanal görüşme işlevselliğini açıklayarak *virtual consultations* dalınızı ana dala birleştirmek için bir *pull request* gönderirsiniz.

---

## 🔎 Kod İncelemesi Yapma ( *Conducting Code Reviews* )

Son olarak, bir meslektaşınızın çalışmanızı incelemesi gerekir.

Bir kod incelemesi ( *code review* ), yeni bir  *pull request* ’te önerilen değişikliklerin bir ekip üyesi tarafından incelenmesini içerir; amaç, birleştirmeden önce kod kalitesini ve işlevselliğini ( *functionality* ) güvence altına almaktır.

Bir  *pull request* ’i incelemek; kodu hatalara karşı kontrol etmeyi, kodlama standartlarına ( *coding standards* ) uyumu değerlendirmeyi ve genel işlevselliği incelemeyi içerir.

İnceleyen kişiler belirli satırlara yorum yapabilir, değişiklik önerebilir ve memnun kaldıklarında  *pull request* ’i onaylayabilir ( *approve* ).

Ekip üyeleriniz sizin *virtual consultations*  *pull request* ’inizi incelerken, siz de hasta kayıt yönetimi özelliği üzerinde çalışan başka bir ekip üyesinden bir kod inceleme isteği alırsınız.

Kodun hassas hasta verisi için şifreleme ( *encryption* ) içermediğini fark edersiniz. Bunu incelemenizde bir yorum olarak eklersiniz.

Bu kod incelemesi, yüksek kaliteli bir kod tabanını ( *high-quality code base* ) sürdürmeye yardımcı olur ve uygulamanın veri koruma standartlarına ( *data protection standards* ) uygun olmasını sağlar.

---

## ✅ Kapanış

Bu videoda, iş birlikçi arka uç geliştirme için GitHub’ı nasıl kullanacağımızı açıkladık; depo oluşturma, dalları yönetme, *pull request* gönderme ve kod incelemeleri gerçekleştirme dahil.

GitHub depolarını kurup kullanarak geliştirme ekipleri, etkili biçimde iş birliği yapabilir, kod değişikliklerini yönetebilir ve yüksek kaliteli bir kod tabanını sürdürebilir.

Bu, üretkenliği artırır ve başarılı proje çıktıları elde edilmesini sağlar.
