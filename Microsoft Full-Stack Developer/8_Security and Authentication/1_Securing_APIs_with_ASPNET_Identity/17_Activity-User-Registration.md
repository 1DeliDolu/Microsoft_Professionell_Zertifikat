
## 🧪 Etkinlik: Kullanıcı Kaydı

### 🧱 Ön Yüz Doğrulamasıyla Basit Bir Kullanıcı Kayıt Formu Oluşturma

## 🎯 Amaç

Öğrenenlerin temel bir kullanıcı kayıt formu oluşturmasını sağlamak ve kullanıcı girdisinin belirli ölçütleri karşıladığından emin olmak için **HTML5 yerleşik doğrulama** özelliklerini kullanmak.

---

## 🧾 Örnek 1: Temel Kayıt Formunu Oluşturma

**Amaç:** Zorunlu alanlar ve temel doğrulama ile basit bir kayıt formu tasarlamayı öğrenmek.

**Kod Örneği:**

```html
<form id="registrationForm">
    <label for="name">Name:</label>
    <input type="text" id="name" name="name" required><br><br>
    <label for="email">Email:</label>
    <input type="email" id="email" name="email" required><br><br>
    <label for="password">Password:</label>
    <input type="password" id="password" name="password" required minlength="6"><br><br>
    <button type="submit">Register</button>
</form>
```

**Kod Açıklaması:**

1. **Name Alanı:**
   * `required` niteliği, kullanıcının alanı boş bırakamamasını sağlar.
2. **Email Alanı:**
   * `type="email"` niteliği, girdinin `@` ve bir alan adı içermesi gibi geçerli bir e-posta formatını takip etmesini sağlar.
3. **Password Alanı:**
   * `type="password"` girdiyi gizleyerek gizlilik sağlar.
   * `minlength="6"` niteliği, parolanın en az 6 karakter uzunluğunda olmasını sağlar.
4. **Submit Düğmesi:**
   * Tüm alanlar doğrulamadan geçtiği sürece tıklandığında form gönderimini tetikler.

---

## 🧩 Örnek 2: Forma Yeni Alanlar Ekleyerek Genişletme

**Amaç:** Doğrulama ile Confirm Password ve Phone Number alanları eklemek.

**Kod Örneği:**

```html
<form id="registrationForm">
    <label for="name">Name:</label>
    <input type="text" id="name" name="name" required><br><br>
    <label for="email">Email:</label>
    <input type="email" id="email" name="email" required><br><br>
    <label for="password">Password:</label>
    <input type="password" id="password" name="password" required minlength="6"><br><br>
    <label for="confirmPassword">Confirm Password:</label>
    <input type="password" id="confirmPassword" name="confirmPassword" required 
           pattern=".{6,}" title="Must match the password"><br><br>
    <label for="phone">Phone Number:</label>
    <input type="tel" id="phone" name="phone" required 
           pattern="\d{10}" title="Must be 10 digits"><br><br>
    <button type="submit" id=”btnSubmit”>Register</button>
</form>
```

**Kod Açıklaması:**

1. **Confirm Password Alanı:**
   * `required` niteliği, bu alanın boş bırakılamamasını sağlar.
   * `pattern=".{6,}"` en az 6 karakter uzunluğu zorunlu kılar.
   * `title`, kullanıcı alanın üzerine geldiğinde veya doğrulama başarısız olduğunda yardımcı bir ipucu sağlar.
2. **Phone Number Alanı:**
   * `type="tel"` sayısal girdi kabul eder.
   * `pattern="\d{10}"` tam olarak 10 sayısal basamak girilmesini sağlar.
   * `title`, kullanıcıya format gereksinimini açıklar.

---

## ✅ Görev 1: Yeni Alanlar Ekleme

**Amaç:** Kayıt formunu şu alanı ekleyerek geliştirmek:

1. **Confirm Password:** Girdinin parola alanıyla eşleşmesini sağlar.

**Talimatlar:**

1. Örnek 2’ye başvurun.
2. Şunları içeren bir Confirm Password alanı ekleyin:
   * Zorunlu yapmak için `required` niteliği.
   * Minimum uzunluğu zorunlu kılmak için `pattern` niteliği.
   * Gereksinimi açıklamak için `title` niteliği.
3. Sayfaya, “password” alanının değeri ile “confirmPassword” alanının değerini karşılaştırmak için JavaScript ekleyin.

---

## 🧑‍💻 Görev 2: Username Alanı Ekleme

**Amaç:** Aşağıdaki doğrulama kurallarına sahip bir Username alanı eklemek:

1. Yalnızca alfanümerik karakterler.
2. Uzunluk 4 ile 12 karakter arasında.

**Talimatlar:**

1. Rehberlik için Örnek 1 ve Örnek 2’ye başvurun.
2. Forma bir Username alanı ekleyin ve şunları sağlayın:
   * Zorunlu yapmak için `required` niteliği.
   * Alfanümerik karakterleri ve uzunluğu zorunlu kılmak için `pattern="[a-zA-Z0-9]{4,12}"` niteliği.
   * Rehberlik sağlamak için `title` niteliği.
