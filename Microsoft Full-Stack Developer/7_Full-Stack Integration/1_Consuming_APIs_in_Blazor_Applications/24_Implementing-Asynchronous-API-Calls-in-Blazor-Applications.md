## 🧪 Blazor Uygulamalarında Asenkron API Çağrılarını Uygulama

Bu laboratuvarda çok basit bir senaryo var; yalnızca temel bir Blazor uygulamamız bulunuyor.

---

## 🛠️ 1. Adım: Blazor Uygulamasını Kurma

1. adımda Blazor uygulamasını kuruyoruz; ben bunu zaten yaptım. VS Code’da **Async API app** açık.

`.NET new Blazor WASM` komutunu çalıştırıyorsunuz; bu, yeni uygulamayı bir klasör içinde oluşturur. Ardından o klasöre geçmek için:

```cli
cd <klasor-adi>
```

kullanırsınız ve uygulamayı kendi instance’ında açmak için:

```cli
code .
```

yazarsınız. Ben de burada onu yaptım.

---

## 📄 2. Adım: `FetchUsers.razor` Sayfası

2. adımda `Pages` klasörünün içinde bulunan `FetchUsers.razor` dosyamız var.

Bu sayfa `FetchUsers` route endpoint’inde. Yani bunu doğru kurduğumuzdan emin oluyoruz: route’un `FetchUsers` olması gerekiyor.

Ayrıca `HttpClient` kullandığımızdan emin oluyoruz ve veri çekmek için yine aynı endpoint’i kullanıyoruz: `JSON placeholder, typico.com users endpoint` — yani veriyi aldığımız API.

---

## ⚡ Asenkron Metodları Kullanmanın Kritik Noktası

Bu lab’da öğrenen kişi için kritik olan şey, bunu *async* metodlarla yapmak.

Bu yüzden:

* `private async Task` metodunun olması gerekiyor.
* `await`’ten sonra `Http.GetFromJsonAsync` kullanılmalı.

Yani lab’ın vurguladığı asenkron çağrılar bunlar.

`await` anahtar kelimesi, *async* metod çağrısından önce olmalı; yoksa başarısız olur.

Bu lab’ın özü de bu.

---

## ▶️ Çalıştırma

İsterseniz çalıştırıp doğrulayabilirsiniz; ama ben kodun çalıştığını doğruladım.

Lab oldukça basit olduğu için burada bir sorun olmaması gerekiyor.
