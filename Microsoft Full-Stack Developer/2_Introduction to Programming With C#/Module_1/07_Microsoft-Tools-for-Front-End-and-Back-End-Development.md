## 🧰 Front-End ve Back-End Geliştirme için Microsoft Araçları

Bu program boyunca  *C#* ,  *Blazor* ,  *GitHub* ,  *GitHub Copilot* , *Microsoft Copilot* ve *Visual Studio Code* dâhil olmak üzere Microsoft araçlarını kullanacağız.

---

## 🖥️ Neden Front-End Geliştirme için C# Kullanılır?

Geleneksel olarak *back-end* geliştirmede kullanılan  *C#* , artık *Blazor* gibi çerçeveler aracılığıyla *front-end* geliştirmede de uygulanabilir. İşte bunun harika bir seçenek olmasının nedenleri:

* **Kod Yeniden Kullanımı:**  *C#* , *front-end* ve *back-end* arasında paylaşılabilir; tekrarları azaltır ve verimliliği artırır.
* **.NET Ekosistemi:** Tutarlı bir geliştirme deneyimi için güçlü kütüphanelere, araçlara ve performans optimizasyonlarına erişim sağlar.
* **Modern Özellikler:** Güçlü tür sistemi (strong typing), *async/await* ve *LINQ* kodu daha sağlam ve sürdürülebilir hâle getirir.
* **WebAssembly:**  *Blazor WebAssembly* , tarayıcıda *C#* çalıştırır; zengin istemci tarafı uygulamalarda *JavaScript* ihtiyacını ortadan kaldırır.
* **Tek Dilli Full-Stack:** Hem *front-end* hem de *back-end* için *C#* kullanmak, *full-stack* geliştirmede iş akışlarını ve öğrenme eğrilerini basitleştirir.

*Blazor* ile *C#* kullanarak geliştiriciler,  *JavaScript* ’e güvenmeden verimli ve sürdürülebilir uygulamalar oluşturabilir.

---

## 🗄️ Neden Back-End Geliştirme için C# Kullanılır?

* **Performans ve Ölçeklenebilirlik:**  *C#* ,  *.NET runtime* ’ı sayesinde yüksek performanslı, ölçeklenebilir *back-end* sistemleri geliştirmek için optimize edilmiştir.
* **.NET Entegrasyonu:** *ASP.NET Core* ve diğer *.NET* kütüphaneleriyle sıkı entegrasyon sayesinde güvenli ve sağlam *back-end* servisleri oluşturmayı kolaylaştırır.
* **Çapraz Platform:** *.NET Core* ile  *C#* , Windows, macOS ve Linux üzerinde geliştirmeyi destekler; modern bulut tabanlı çözümler için idealdir.
* **Güçlü Tür Sistemi ve OOP:**  *C#* ’ın güçlü tür sistemi ve nesne yönelimli tasarımı, yapılandırılmış ve sürdürülebilir kod üretir; çalışma zamanı hatalarını azaltır.
* **Geniş Ekosistem:** Büyük bir ekosistem ve topluluk desteğiyle desteklenen  *C#* , geliştirme ve dağıtımı basitleştiren araçlar ve çerçeveler sunar.

---

## 🧩 Blazor’a Giriş

 *Blazor* , Microsoft tarafından geliştirilen ve geliştiricilerin *JavaScript* yerine *C#* kullanarak etkileşimli web uygulamaları oluşturmasına olanak tanıyan bir web çerçevesidir. Hem *front-end* hem de *back-end* için *C#* kullanarak *full-stack* geliştirmeyi mümkün kılar ve iki ana barındırma modeline sahiptir:

* **Blazor WebAssembly:** *WebAssembly* aracılığıyla tarayıcıda istemci tarafında çalışır; *JavaScript* olmadan *C#* kodunun doğrudan tarayıcıda yürütülmesini sağlar.
* **Blazor Server:** Bileşenleri sunucu tarafında işler (render eder) ve istemciyi gerçek zamanlı bağlantılar üzerinden günceller; hafif bir *front-end* deneyimi sunar.

 *Blazor* , *.NET ekosisteminden* yararlanır; istemci ve sunucu arasında kod paylaşımına imkân vererek tekrarları azaltır ve birleşik bir geliştirme ortamı sağlar.  *C#* ’a aşina olup  *JavaScript* ’e geçmeden modern, etkileşimli web arayüzleri geliştirmek isteyen geliştiriciler için idealdir.

---

## 🧷 GitHub’a Giriş

 *GitHub* , geliştiricilerin kodu etkili şekilde yönetmesine ve paylaşmasına olanak tanıyan bir sürüm kontrolü ve iş birliği platformudur. Projedeki değişiklikleri izlemek, gerçek zamanlı iş birliği yapmak ve tüm değişikliklerin geçmişini korumak için bir sürüm kontrol sistemi olan  *Git* ’i kullanır.

Başlıca özellikleri şunlardır:

* **Sürüm Kontrolü:** Kodunuzdaki her değişikliği izler; önceki sürümlere dönmeyi ve birden fazla katkı sağlayanı yönetmeyi kolaylaştırır.
* **İş Birliği:**  *Pull request* ’ler ve  *issue* ’lar üzerinden ekip çalışmasını kolaylaştırır; kod inceleme, tartışma ve proje yönetimini mümkün kılar.
* **Entegrasyon:** *Visual Studio Code* ve bulut platformları gibi araçlarla sorunsuz entegre olur; geliştirme ve dağıtım iş akışlarını sadeleştirir.
* **Açık Kaynak:** Milyonlarca açık kaynak projeye ev sahipliği yapar; geliştiricilerin katkı sunabileceği veya kullanabileceği geniş bir kod ve kütüphane ekosistemi sağlar.

 *GitHub* , modern yazılım geliştirmede kodu yönetmek, iş birliğini desteklemek ve düzenli iş akışlarını sürdürmek için gereklidir.

---

## 🤖 Bu Programda Neden Yapay Zekâ Kullanıyoruz?

Yapay zekâ, tekrarlayan görevleri otomatikleştirerek, üretkenliği artırarak ve problem çözme için gelişmiş araçlar sağlayarak yazılım geliştirmeyi dönüştürüyor. Bu programda, kodlamaya yardımcı olmak, gerçek zamanlı kod önerileri sunmak ve karmaşık görevlere odaklanmanıza destek olmak için *GitHub Copilot* ve *Microsoft Copilot* gibi yapay zekâ odaklı araçları kullanıyoruz. Bu yapay zekâ entegrasyonu, verimliliğinizi artıracak ve ileri seviye kavramları daha hızlı öğrenmenize yardımcı olacaktır.

---

## 🆚 GitHub Copilot ve Microsoft Copilot Karşılaştırması

* **GitHub Copilot:** *Visual Studio Code* içine gömülüdür ve bağlama göre gerçek zamanlı kod önerileri sunar. Kodun ardındaki mantığı anlamanıza yardımcı olur ve değerli satır içi (in-line) hata ayıklama desteği sağlar.  *GitHub Copilot* , *C#* öğrenirken kod yazmanıza destek olacak ve problem çözme becerilerinizi geliştirecektir.
* **Microsoft Copilot:** Programın ilerleyen aşamalarında, *Microsoft 365* ile entegre bir araç olan  *Microsoft Copilot* ’u kullanacağız. Kod iyileştirme, özetleme ve açıklama için tasarlanmıştır.  *Microsoft Copilot* , kodunuzu belgelemenize, olası sorunları belirlemenize ve çözümlerinizi rafine etmenize yardımcı olur—çalışmanızı daha derinlemesine anlamanızı sağlarken erişilebilir ve kullanımı kolay kalır.

---

## 🧑‍💻 Visual Studio Code’a Giriş

Bu programda, Microsoft’un hafif, esnek ve hızlı bir kod editörü olan  *Visual Studio Code (VS Code)* ’u kullanacağız.  *VS Code* , *front-end* geliştirme ve hızlı iterasyonlar için idealdir.  *C#* , *HTML* ve *JavaScript* gibi birden fazla programlama dilini destekler; bu da onu *front-end* projeleri için mükemmel kılar.

 *VS Code* ’u kullanmamızın nedenleri:

* **Özelleştirme:** Editörü belirli ihtiyaçlara göre uyarlamak için geniş bir eklenti (extension) pazaryeri sunar.
* **Çapraz Platform Desteği:** Windows, macOS ve Linux üzerinde sorunsuz çalışır.
* **Sürüm Kontrolü:** Kolay iş birliği için yerleşik *Git* ve *GitHub* entegrasyonu içerir.

 *VS Code* ’un sadeliği ve güçlü özellikleri, hızlı ve verimli geliştirme için onu ideal hâle getirir.
