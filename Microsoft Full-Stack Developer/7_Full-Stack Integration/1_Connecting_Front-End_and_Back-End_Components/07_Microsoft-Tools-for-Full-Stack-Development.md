## 🧰 Microsoft Tools for Full-Stack Development

Bu program boyunca,  **C#** ,  **Blazor** ,  **GitHub** , **GitHub Copilot** ve **Microsoft Copilot** ile **Visual Studio Code** dâhil olmak üzere Microsoft araçlarını kullanacağız.

---

## 💡 Why Use C# for Full-Stack Development

C#, front-end için Blazor ve back-end için ASP.NET Core ile eşleştirildiğinde full-stack geliştirme için idealdir. İşte nedenleri:

### 🧩 Single-Language Development

C#, JavaScript gibi diller arasında geçiş yapma ihtiyacını ortadan kaldırarak iş akışlarını basitleştirir.

### ♻️ Code Reusability

C#, front-end ve back-end arasında mantık paylaşımını mümkün kılar; tekrarları azaltır ve geliştirmeyi hızlandırır.

### 🧱 .NET Ecosystem

Ölçeklenebilir ve güvenli uygulamalar geliştirmek için güçlü kütüphaneler sunar (ör.  *LINQ* ,  *dependency injection* ).

### 🌍 Cross-Platform Flexibility

.NET Core ile C#, Windows, Linux ve macOS üzerinde çalışır; bulut tabanlı çözümleri destekler.

### ✨ Modern Features

Güçlü tip sistemi (strong typing) ve  *async/await* , kod kalitesini ve performansı artırır.

### 🌐 Blazor for Web

Blazor, C# ile web uygulamaları oluşturmayı sağlar; *WebAssembly* ve gerçek zamanlı sunucu tarafı render’ı destekler.

### 🛠️ Tooling Support

Visual Studio ve VS Code; güçlü hata ayıklama ve GitHub ile Azure entegrasyonu sunar.

### 🔒 Security and Performance

C#, .NET runtime üzerinden sağlam güvenlik ve optimize performans sağlar.

C#, full stack boyunca güvenli ve ölçeklenebilir uygulamalar inşa etmek için birleşik ve verimli bir yaklaşım sunar.

---

## 🌐 Introduction to Blazor

Blazor, Microsoft’un geliştiricilerin JavaScript yerine C# kullanarak etkileşimli web uygulamaları oluşturmasına olanak tanıyan bir web framework’üdür. Hem front-end hem de back-end için C# kullanarak full-stack geliştirmeyi mümkün kılar ve iki ana barındırma modeline sahiptir:

### 🧩 Blazor WebAssembly

C# kodunun JavaScript olmadan doğrudan tarayıcıda çalıştırılmasını sağlayan *WebAssembly* aracılığıyla, istemci tarafında (client-side) tarayıcı içinde çalışır.

### 🖥️ Blazor Server

Bileşenleri sunucu tarafında (server-side) render eder ve istemciyi gerçek zamanlı bağlantılar üzerinden günceller; hafif bir front-end deneyimi sunar.

Blazor, .NET ekosisteminden yararlanır; istemci ve sunucu arasında kod paylaşımına izin vererek tekrarları azaltır ve birleşik bir geliştirme ortamı sağlar. C#’a aşina geliştiriciler için JavaScript’e geçmeden modern, etkileşimli web UI’ları oluşturmak adına idealdir.

---

## 🧑‍🤝‍🧑 Introduction to GitHub

GitHub, geliştiricilerin kodu etkili şekilde yönetmesini ve paylaşmasını sağlayan bir sürüm kontrolü ve iş birliği platformudur. Bir sürüm kontrol sistemi olan Git’i kullanarak değişiklikleri takip eder, gerçek zamanlı iş birliğini destekler ve bir projede yapılan tüm değişikliklerin geçmişini korur.

Başlıca özellikler şunlardır:

### 🗂️ Version Control

Kodunuzdaki her değişikliği takip eder; önceki sürümlere dönmeyi kolaylaştırır ve birden fazla katkıcısı olan projeleri yönetmeyi sağlar.

### 🤝 Collaboration

Pull request’ler ve issue’lar üzerinden ekip çalışmasını kolaylaştırır; kod inceleme, tartışma ve proje yönetimini destekler.

### 🔗 Integration

Visual Studio Code gibi araçlarla ve bulut platformlarıyla sorunsuz entegre olur; geliştirme ve dağıtım iş akışlarını kolaylaştırır.

### 🌱 Open Source

Milyonlarca açık kaynak projeye ev sahipliği yapar; geliştiricilerin katkı verebileceği veya kullanabileceği geniş bir kod ve kütüphane ekosistemi sunar.

GitHub, modern yazılım geliştirmede kodu yönetmek, iş birliğini güçlendirmek ve düzenli iş akışlarını sürdürmek için vazgeçilmezdir.

---

## 🤖 Why We’re Using AI in This Program

Yapay zekâ, tekrarlayan görevleri otomatikleştirerek, üretkenliği artırarak ve problem çözme için gelişmiş araçlar sağlayarak yazılım geliştirmeyi dönüştürüyor. Bu programda, kodlamaya yardımcı olmak, gerçek zamanlı kod önerileri sunmak ve karmaşık görevlere odaklanmanıza destek olmak için **GitHub Copilot** ve **Microsoft Copilot** gibi AI destekli araçlar kullanıyoruz.

Bu AI entegrasyonu verimliliğinizi artıracak ve ileri kavramları daha hızlı öğrenmenize yardımcı olacak.

---

## 🆚 GitHub Copilot vs. Microsoft Copilot

### 🧠 GitHub Copilot

Visual Studio Code içine gömülü olan GitHub Copilot, bağlama göre gerçek zamanlı kod önerileri sağlar. Kodun arkasındaki mantığı anlamanıza yardımcı olur ve satır içi hata ayıklama desteği sunar. Bu, yalnızca kod yazmanıza yardımcı olmakla kalmaz; C# öğrenirken problem çözme becerilerinizi de geliştirir.

### 🗒️ Microsoft Copilot

Programın ilerleyen aşamalarında, Microsoft 365 ile entegre bir araç olan Microsoft Copilot’u kullanacağız. Bu araç; kod iyileştirme, özetleme ve açıklama için tasarlanmıştır. Microsoft Copilot, kodunuzu belgelemenize, olası sorunları belirlemenize ve çözümlerinizi rafine etmenize yardımcı olur—çalışmanızı daha derinlemesine anlamanızı sağlarken erişilebilir ve kullanımı kolay kalır.

---

## 🧑‍💻 Introduction to Visual Studio Code

Bu programda, Microsoft’un hafif, esnek ve hızlı kod editörü olan  **Visual Studio Code (VS Code)** ’u kullanacağız. VS Code, full-stack geliştirme ve hızlı iterasyonlar için idealdir. C#, HTML ve JavaScript gibi birden fazla programlama dilini desteklediği için full-stack projeler için mükemmeldir.

VS Code’u kullanmamızın nedenleri:

### 🧩 Customization

Editörü ihtiyaçlara göre özelleştirmek için geniş bir eklenti (extension) pazarı sunar.

### 🌍 Cross-Platform Support

Windows, macOS ve Linux’ta sorunsuz çalışır.

### 🔄 Version Control

Kolay iş birliği için yerleşik Git ve GitHub entegrasyonu sağlar.

VS Code’un sadeliği ve güçlü özellikleri, hızlı ve verimli geliştirme için onu ideal hâle getirir.
