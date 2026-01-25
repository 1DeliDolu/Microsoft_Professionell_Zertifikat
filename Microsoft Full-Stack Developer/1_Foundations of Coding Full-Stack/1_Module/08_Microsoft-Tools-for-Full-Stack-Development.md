
## 🧰 Full-Stack Geliştirme için Microsoft Araçları

Bu program boyunca  *C#* ,  *Blazor* ,  *GitHub* , *GitHub Copilot* ve *Microsoft Copilot* ile *Visual Studio Code* dahil olmak üzere Microsoft araçlarını kullanacağız.

---

## 💡 Full-Stack Geliştirme için Neden C# Kullanılır?

 *C#* , ön yüz ( *front-end* ) için *Blazor* ve arka uç ( *back-end* ) için *ASP.NET Core* ile eşleştirildiğinde full-stack geliştirme için idealdir. İşte nedenleri:

* **Tek Dil ile Geliştirme:**  *C#* , *JavaScript* gibi diller arasında geçiş yapma ihtiyacını ortadan kaldırarak iş akışlarını basitleştirir.
* **Kod Yeniden Kullanılabilirliği:**  *C#* , ön yüz ve arka uç arasında mantık paylaşımını mümkün kılar; tekrarları azaltır ve geliştirmeyi hızlandırır.
* **.NET Ekosistemi:** Ölçeklenebilir, güvenli uygulamalar geliştirmek için güçlü kütüphaneler sunar (ör.  *LINQ* ,  *dependency injection* ).
* **Çapraz Platform Esnekliği:** *.NET Core* ile  *C#* ,  *Windows* , *Linux* ve *macOS* üzerinde çalışır; bulut tabanlı çözümleri destekler.
* **Modern Özellikler:** Güçlü tür sistemi ( *strong typing* ) ve *async/await* kod kalitesini ve performansı artırır.
* **Web için Blazor:**  *Blazor* , *C#* ile web uygulamaları oluşturmayı sağlar; *WebAssembly* ve gerçek zamanlı sunucu tarafı render ( *real-time server-side rendering* ) desteği sunar.
* **Araç Desteği:** *Visual Studio* ve  *VS Code* , güçlü hata ayıklama ( *debugging* ) ve *GitHub* ile *Azure* entegrasyonu sağlar.
* **Güvenlik ve Performans:**  *C#* , *.NET runtime* üzerinden güçlü güvenlik ve optimize performans sunar.

 *C#* , tüm katman boyunca güvenli ve ölçeklenebilir uygulamalar geliştirmek için birleşik ve verimli bir yaklaşım sunar.

---

## 🧩 Blazor’a Giriş

 *Blazor* , Microsoft’un web çatısı ( *web framework* ) olup geliştiricilerin *JavaScript* yerine *C#* kullanarak etkileşimli web uygulamaları oluşturmasına olanak tanır. Hem ön yüz hem de arka uç için *C#* kullanarak full-stack geliştirmeyi mümkün kılar ve iki ana barındırma ( *hosting* ) modeli sunar:

* **Blazor WebAssembly:** *WebAssembly* üzerinden tarayıcıda istemci tarafında çalışır; *C#* kodunun *JavaScript* olmadan doğrudan tarayıcıda çalışmasını sağlar.
* **Blazor Server:** Bileşenleri sunucu tarafında render eder ve istemciyi gerçek zamanlı bağlantılarla günceller; hafif bir ön yüz deneyimi sunar.

 *Blazor* , *.NET* ekosisteminden yararlanır; istemci ve sunucu arasında kod paylaşımına izin vererek tekrarları azaltır ve birleşik bir geliştirme ortamı sağlar.  *C#* ’a aşina olup  *JavaScript* ’e geçmeden modern, etkileşimli web arayüzleri geliştirmek isteyen geliştiriciler için idealdir.

---

## 🗂️ GitHub’a Giriş

 *GitHub* , geliştiricilerin kodu etkili şekilde yönetmesine ve paylaşmasına olanak tanıyan, sürüm kontrolü ve iş birliği platformudur. Bir sürüm kontrol sistemi olan  *Git* ’i kullanarak değişiklikleri takip eder, gerçek zamanlı iş birliğini destekler ve projedeki tüm değişikliklerin geçmişini korur.

Başlıca özellikleri şunlardır:

* **Sürüm Kontrolü:** Kodunuzdaki her değişikliği izler; önceki sürümlere dönmeyi ve birden çok katkı sağlayanla çalışmayı kolaylaştırır.
* **İş Birliği:** *Pull request* ve  *issue* ’lar aracılığıyla ekip çalışmasını kolaylaştırır; kod inceleme, tartışma ve proje yönetimini destekler.
* **Entegrasyon:** *Visual Studio Code* gibi araçlar ve bulut platformlarıyla sorunsuz şekilde entegre olur; geliştirme ve dağıtım iş akışlarını kolaylaştırır.
* **Açık Kaynak:** Milyonlarca açık kaynak projeyi barındırır; geliştiricilerin katkı sunabileceği veya kullanabileceği geniş bir kod ve kütüphane ekosistemi sağlar.

 *GitHub* , modern yazılım geliştirmede kodu yönetmek, iş birliğini güçlendirmek ve düzenli iş akışlarını sürdürmek için temel bir araçtır.

---

## 🤖 Bu Programda Neden Yapay Zekâ Kullanıyoruz?

Yapay zekâ, tekrarlayan görevleri otomatikleştirerek, üretkenliği artırarak ve problem çözmeye yönelik gelişmiş araçlar sunarak yazılım geliştirmeyi dönüştürüyor. Bu programda, kodlamaya yardımcı olmak, gerçek zamanlı kod önerileri sunmak ve karmaşık görevlere odaklanmanıza destek olmak için *GitHub Copilot* ve *Microsoft Copilot* gibi yapay zekâ destekli araçlar kullanıyoruz.

Bu yapay zekâ entegrasyonu, verimliliğinizi artıracak ve ileri düzey kavramları daha hızlı öğrenmenize yardımcı olacaktır.

---

## ⚖️ GitHub Copilot ve Microsoft Copilot Karşılaştırması

* **GitHub Copilot:** *Visual Studio Code* içine gömülüdür ve bağlama göre gerçek zamanlı kod önerileri sunar. Kodun arkasındaki mantığı anlamanıza yardımcı olur ve satır içi hata ayıklama desteği sağlar. Bu, yalnızca kod yazmanıza yardımcı olmakla kalmaz; *C#* öğrenirken problem çözme becerilerinizi de geliştirir.
* **Microsoft Copilot:** Programın ilerleyen aşamalarında, *Microsoft 365* ile entegre bir araç olan  *Microsoft Copilot* ’u kullanacağız. Kod iyileştirme, özetleme ve açıklama için tasarlanmıştır.  *Microsoft Copilot* , kodunuzu belgelemenize, olası sorunları belirlemenize ve çözümlerinizi rafine etmenize yardımcı olur; böylece çalışmanızı daha derinlemesine anlarken aynı zamanda erişilebilir ve kullanımı kolay kalır.

---

## 🧑‍💻 Visual Studio Code’a Giriş

Bu programda, Microsoft’un hafif, esnek ve hızlı kod düzenleyicisi olan  *Visual Studio Code (VS Code)* ’u kullanacağız.  *VS Code* , full-stack geliştirme ve hızlı iterasyonlar için idealdir.  *C#* , *HTML* ve *JavaScript* gibi birden fazla programlama dilini destekleyerek full-stack projeler için mükemmel bir seçenek sunar.

 *VS Code* ’u kullanıyoruz çünkü şu özellikleri sağlar:

* **Özelleştirme:** Editörü belirli ihtiyaçlara göre uyarlamak için geniş bir eklenti pazarı ( *extension marketplace* ).
* **Çapraz Platform Desteği:**  *Windows* , *macOS* ve *Linux* üzerinde sorunsuz çalışır.
* **Sürüm Kontrolü:** Kolay iş birliği için yerleşik *Git* ve *GitHub* entegrasyonu.

 *VS Code* ’un sadeliği ve güçlü özellikleri, hızlı ve verimli geliştirme için onu ideal kılar.
