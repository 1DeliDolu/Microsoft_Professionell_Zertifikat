## 🧩 Etkinlik: Kullanıcı Kaydı – Cevap Anahtarı

---

## ✅ Görev 1 için Cevap Anahtarı

### 🧾 HTML Çözümü

```html
<label for="confirmPassword">Confirm Password:</label>

<input
  type="password"
  id="confirmPassword"
  name="confirmPassword"
  required
  pattern=".{6,}"
  title="Must match the password"
>

<br><br>
```

### 🧠 Sayfaya Eklenen JavaScript

> Not: Bu kod sayfada formun altına eklenmelidir. Her input’tan sonra hata mesajları için `<span>` etiketleri ekleyebilirdik; ancak bu alıştırmada, öğe için mesaj göstermek amacıyla `"setCustomValidity"` kullanacağız.

```html
<script>
document.getElementById('registrationForm').addEventListener('submit', function(event) {
  event.preventDefault(); // this prevents normal form submission

  const password = document.getElementById('password').value;
  const confirmPassword = document.getElementById('confirmPassword').value;

  if (password !== confirmPassword) {
    document.getElementById('confirmPassword').setCustomValidity("Password doesn't match");
    return false;
  } else {
    document.getElementById('confirmPassword').setCustomValidity("");
    return true;
  }
});
</script>
```

### 📝 Açıklama

**Confirm Password** alanı, `pattern` kullanarak parolanın minimum uzunluk gereksinimiyle eşleşir ve `required` ile girilmesini zorunlu kılar.

JavaScript, form gönderildiğinde çalışır. Ardından `"password"` ve `"confirmPassword"` alanlarının değerlerini karşılaştırır. Eğer eşleşmiyorlarsa, `"confirmPassword"` alanının yanında bir mesaj gösterir ve formun gönderilmesini engeller.

---

## ✅ Görev 2 için Cevap Anahtarı

### 🧾 HTML Çözümü

```html
<label for="username">Username:</label>

<input
  type="text"
  id="username"
  name="username"
  required
  pattern="[a-zA-Z0-9]{4,12}"
  title="Must be 4-12 characters long and alphanumeric"
>

<br><br>
```

### 📝 Açıklama

**Username** alanı, yalnızca alfanümerik karakterlere izin vermek ve uzunluğu 4 ile 12 karakter arasında tutmak için `pattern` kullanır.

`title` niteliği, kullanıcılara gereksinimler hakkında geri bildirim sağlar.
