## 🧩 Instructions

---

## 🛠️ Step 1: Uygulamayı Hazırlama

Komut satırı kullanarak küçük bir ASP.NET Core uygulaması oluşturacaksınız. Bu uygulama birkaç yerleşik ( *built-in* ) middleware bileşeni entegre edecek ve istekleri ile yanıt ayrıntılarını loglamak için custom middleware ekleyeceksiniz.

### ✅ Steps

1. Bir terminal açın ve istediğiniz dizine gidin.
2. Aşağıdaki komutla yeni bir ASP.NET Core empty project oluşturun:

```bash
dotnet new web -o MyAspNetCoreApp
```

3. Proje klasörüne gidin:

```bash
cd MyAspNetCoreApp
```

4. Projeyi kod editörünüzde açın (ör. Visual Studio Code):

```bash
code .
```

5. Root dizinde **`Program.cs`** dosyasını bulun. Bu dosya tüm middleware bileşenlerini yapılandırmak için kullanılacaktır.

---

## 🧰 Step 2: Built-In Middleware Bileşenlerini Yapılandırma

Bu adımda temel built-in middleware bileşenlerini yapılandıracaksınız:  *Exception Handling* ,  *Authentication* , *Authorization* ve  *Logging* . Authentication ve authorization’ı tamamen implemente etmek zorunda değilsiniz. Sadece middleware bileşenlerini dahil edin.

### ✅ Steps

1. **`Program.cs`** içinde production ve development ortamları için exception handling middleware’ini yapılandırın.
2. Kullanıcı kimliklerini doğrulamak için kullanılabilecek authentication middleware’ini ekleyin.
3. Kullanıcı izinlerini kontrol etmek için kullanılabilecek authorization middleware’ini ekleyin.
4. Request ve response detaylarını yakalamak için HTTP logging’i yapılandırın. **`builder.Services`** içine HTTP logging servisini ekleyin ve middleware’i uygulayın.

Her yapılandırmadan sonra değişikliklerinizi kaydedin; böylece her şeyin doğru kurulduğunu doğrulayabilirsiniz.

---

## 🧩 Step 3: Custom Middleware Geliştirme

Artık request path ve response status loglayan custom middleware’in yanı sıra request duration kaydeden middleware’i oluşturacaksınız.

### ✅ Steps

1. **`Program.cs`** içinde request path ve response status’u loglamak için custom middleware ekleyin.
2. Request duration’ı takip etmek için ikinci bir custom middleware ekleyin.

Tüm yapılandırmaları tamamladıktan sonra değişikliklerinizi kaydedin.

---

## 🧪 Step 4: Middleware Pipeline’ı Test Etme

Tüm middleware bileşenleri yerindeyken, isteklerin ve yanıtların nasıl işlendiğini gözlemlemek için uygulamayı test edin.

### ✅ Steps

1. Uygulamayı çalıştırın:

```bash
dotnet run
```

2. Bir tarayıcı açın ve uygulamaya istekler gönderin; örneğin:

`http://localhost:5000`

3. Terminaldeki log’ları gözlemleyin; custom middleware çıktısını, request timing’i ve built-in middleware davranışını doğrulayın.
4. Error handling’in production’da bir error sayfasına doğru yönlendirdiğini ve development’ta ayrıntılı hataları gösterdiğini doğrulayın.

---

## ✅ Step 4: Örnek Çıktı

```text
Request Path: /
Start Time: 10/29/2024 4:21:58 PM
Response Time: 8.319 ms
Response Status Code: 200
Request Path: /favicon.ico
Start Time: 10/29/2024 4:21:59 PM
Response Time: 0.084 ms
Response Status Code: 404
```
