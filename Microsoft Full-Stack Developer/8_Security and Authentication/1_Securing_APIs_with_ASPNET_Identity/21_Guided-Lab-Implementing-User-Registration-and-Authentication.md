## 🧭 Rehberli Laboratuvar: Kullanıcı Kaydı ve Kimlik Doğrulamayı Uygulama

---

## ℹ️ Arka Plan Bilgileri

**UserAuthInMemoryApp** adlı bir *Blazor* uygulamasında bir kullanıcı kimlik doğrulama sistemi oluşturmakla görevlendirildiniz.

1. Uygulama, kullanıcı yönetimini basitleştirmek için **ASP.NET Identity** kullanacaktır. Buna kullanıcı rolleri, hash’lenmiş parolalar ve kullanıcı adları ile roller gibi kullanıcı verilerinin yönetimi için önceden oluşturulmuş işlevsellik dahildir. **Entity Framework Core** kullanarak bir *in-memory* veritabanı kurarak başlayacaksınız.
2. Sonrasında, e-posta, parola ve parola doğrulaması için girdi toplayacak bir kullanıcı kayıt formu uygulayacaksınız. Kayıt formu, kullanıcı girdisini bir modele eşlemek için *data binding* ve tüm alanların doğru şekilde doldurulduğundan emin olmak için doğrulama özniteliklerini ( *validation attributes* ) kullanacaktır.

---

## 🗄️ Arka Plan Bilgileri

**UserAuthInMemoryApp** adlı *Blazor* uygulaması, kullanıcı kimlik doğrulamasını yönetmek için bir *in-memory* veritabanına ihtiyaç duyar. Bu veritabanı, **Entity Framework Core** kullanarak kullanıcı adları ve parolalar gibi kullanıcı bilgilerini depolayacaktır. Kullanıcı yönetimini basitleştirmek için uygulama, **IdentityDbContext** adlı önceden oluşturulmuş bir sınıf içeren **ASP.NET Identity** kullanır. Veritabanını `Program.cs` dosyasında **UserAuthInMemoryApp** adını kullanacak şekilde yapılandıracaksınız.

---

## 🧾 Arka Plan Bilgileri

**UserAuthInMemoryApp** uygulaması, e-posta, parola ve parola doğrulaması dâhil olmak üzere kullanıcı girdisi toplamak için bir kayıt formu gerektirir.

* Bir  **RegisterViewModel** , kullanıcı girdilerini forma bağlayacaktır.
* Doğrulama öznitelikleri ( *validation attributes* ), tüm girdilerin doğru biçimlendirildiğinden ve doldurulduğundan emin olacaktır:
  * `[Required]`, e-posta ve parola gibi alanların boş bırakılamamasını sağlar.
  * `[Compare("Password")]`, parola doğrulamasının parolayla eşleşmesini sağlar.

Bu form, kullanıcıların kimlik doğrulama ve kayıt için arka uca geçerli veriler göndermesine olanak tanıyacaktır.

---

## 💻 Kod

```csharp
public class RegisterViewModel
{
    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; }
}
```

İmlecinizi 8. satırdaki boşluğa yerleştirin. Ardından, parola doğrulama alanı için özellik adını tanımlamak üzere kodu girin. Sonra devam etmek için  **Enter** ’ı seçin.

---

## ✅ Tamamlandı

Bu rehberli laboratuvarı tamamladığınız için harika iş çıkardınız. Şimdi, **Implementing User Registration and Authentication** konusunda ustalığınızı bağımsız olarak göstermek için bu laboratuvarın **You Try It!** bölümünü tamamlayın.
