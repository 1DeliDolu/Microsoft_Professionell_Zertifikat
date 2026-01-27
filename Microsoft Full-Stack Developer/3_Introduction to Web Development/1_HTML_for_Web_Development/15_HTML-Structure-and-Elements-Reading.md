## 🧱 HTML Yapısı ve Öğeleri

### 📌 Giriş

Bu kılavuz, öğeler, öznitelikler ve sağlam bir yapı kullanarak temel bir HTML belgesi oluşturma sürecinde size rehberlik edecektir. Sonunda, HTML kullanarak web içeriğini etkili bir şekilde nasıl oluşturacağınızı ve düzenleyeceğinizi bileceksiniz.

---

## 🏗️ Adım 1: Temel HTML Yapısıyla Başlayın

### 1) `<!DOCTYPE html>` ile başlayın

Bu, tarayıcıya HTML5 ile yazdığınızı söyler.

```html
<!DOCTYPE html>
```

### 2) `<html>` etiketini oluşturun

Bu, tüm içeriğinizi saran kök (root) öğedir.

```html
<html>
```

### 3) `<head>` bölümünü ekleyin

`<html>` etiketinin içinde, sayfa başlığı ve CSS veya JavaScript dosyalarına bağlantılar gibi bilgiler için bir `<head>` bölümü ekleyin. `<head>` içindeki içerik web sayfasında görünmez.

```html
<head>
  <title>My First Webpage</title>
</head>
```

### 4) `<body>` bölümünü oluşturun

Bu bölüm, sayfanızdaki tüm görünür içeriği içerir; metin, görseller ve bağlantılar gibi. Kullanıcıların web sayfasında gördüğü her şey `<body>` etiketi içine yerleştirilir.

```html
<body>

  <!-- Your content goes here →

</body>
```

### 5) `<html>` etiketini kapatın

Kök `<html>` etiketini her zaman en sonda kapatmayı unutmayın.

```html
</html>
```

---

## 🧩 Adım 2: İçerik Oluşturmak için Öğeleri ve Etiketleri Kullanın

### 1) Başlıklar ve Paragraflar ekleyin

Metin içeriğini tanımlamak için başlıklarda `<h1>`, paragraflarda `<p>` gibi etiketleri kullanın.

**Örnek:**

```html
<h1>Welcome to My Website</h1>

<p>This is the first paragraph on my page.</p>
```

### 2) `<div>` ve `<section>` ile bölümler oluşturun

İçeriği gruplamak için `<div>`, web sayfanızın ilgili kısımlarını düzenlemek için `<section>` kullanın. Bu, farklı bölümleri görsel ve yapısal olarak ayırmaya yardımcı olur.

**Örnek:**

```html
<section>

  <h2>About Us</h2>

  <p>We build amazing web experiences.</p>

</section>
```

---

## 🏷️ Adım 3: Özelleştirme için Öznitelikleri Kullanın

### 1) Benzersiz ID’ler tanımlayın

Bir öğeyi stil vermek veya JavaScript fonksiyonlarında benzersiz şekilde tanımlamak için `id` özniteliğini kullanın. Bir ID, sayfa içinde benzersiz olmalıdır.

**Örnek:**

```html
<div id="header">This is the header area</div>
```

### 2) Sınıflar ile öğeleri gruplandırın

Birden fazla öğeye aynı stili uygulamak için `class` özniteliğini kullanın. Benzer bölümlere aynı tasarımı uygularken faydalıdır.

**Örnek:**

```html
<div class="highlight">Special Notice</div>
```

### 3) `href` ile bağlantılar oluşturun

Bağlantı etiketleri (`<a>`) için hedef URL’yi belirtmek üzere `href` özniteliğini kullanın.

**Örnek:**

```html
<a href="https://example.com">Visit Example</a>
```

### 4) `src` ve `alt` ile görselleri gösterin

Görseller için kaynak dosyayı tanımlamak üzere `src`, alternatif metin için `alt` kullanın.

**Örnek:**

```html
<img src="logo.png" alt="Company Logo">
```

---

## 🧠 Adım 4: Anlam ve Düzen için Semantik HTML Kullanın

### 1) Gezinme çubuğu ekleyin

Sitenizin gezinme bağlantılarını düzenlemek için `<nav>` öğesini kullanın.

**Örnek:**

```html
<nav>

  <a href="/home">Home</a>

  <a href="/about">About Us</a>

</nav>
```

### 2) Ana içeriği yapılandırın

Sayfanızın ana içeriğini tanımlamak için `<main>` etiketini kullanın; bu hem kullanıcılar hem de arama motorları için netlik sağlar.

**Örnek:**

```html
<main>

  <h2>Welcome to Our Company</h2>

  <p>We provide excellent services.</p>

</main>
```

### 3) Ek bilgiler için alt bilgi (footer)

Sayfanın alt kısmına telif hakkı bilgisi, iletişim detayları veya sosyal medya bağlantıları eklemek için `<footer>` etiketini kullanın.

**Örnek:**

```html
<footer>

  <p>© 2024 My Website. All Rights Reserved.</p>

</footer>
```

---

## 🧬 Adım 5: Doğru İç İçe Geçirme ile Düzenleyin

### 1) Öğeleri iç içe yerleştirme

Net bir hiyerarşi sağlamak için bir öğeyi diğerinin içine yerleştirin. Örneğin, bir `<section>` hem bir başlık hem de birden fazla paragraf içerebilir.

**Örnek:**

```html
<div class="container">

  <section>

    <h2>Our Services</h2>

    <p>We offer web development, design, and more.</p>

  </section>

</div>
```

### 2) Doğru iç içe geçirmenin faydaları

* Belgenizin yapısında netlik sağlar.
* Belirli bölümleri hedefleyerek stil vermeyi kolaylaştırır.
* Ekran okuyucular için erişilebilirliği artırır ve tüm kullanıcılar için deneyimi iyileştirir.

---

## ✅ Sonuç

Bu adım adım kılavuzu takip etmek, iyi yapılandırılmış, net ve işlevsel HTML belgeleri oluşturmanıza yardımcı olacaktır. Web sitenizin organizasyonunu, stilini ve erişilebilirliğini geliştirmek için öğeleri, öznitelikleri ve semantik etiketleri kullanın.
