## 🧪 Genel Bakış

### 🎯 Amaç

Bu laboratuvarın sonunda, C#’ta basit asenkron programlar oluşturabilecek ve hata ayıklayabileceksiniz. Asenkron işlemleri yönetmek için **async** ve **await** kullanmayı öğrenecek ve asenkron kodun nasıl çalıştığını anlamak için hata ayıklama tekniklerini pratik edeceksiniz.

---

## 🐞 Asenkron Programları Hata Ayıklama ve Oluşturma

### 1️⃣ `async` ve `await`’e Giriş

**async** ve **await** anahtar sözcüklerini ve görevlerin asenkron çalışmasına izin vererek programları duyarlı hâle getirmedeki rollerini anlayın. Kursun başında oluşturduğunuz Visual Studio Code konsol uygulamasını kullanarak küçük bir uygulama oluşturacaksınız. Uygulamanız bir asenkron metot çalıştıracak.

Konsol uygulamanızın **Program.cs** dosyasındaki mevcut tüm kodları kaldırın ve her adımda verilen tüm kodu bu dosyada oluşturun.

---

### 2️⃣ Asenkron Metodu Uygulama

**Task.Delay** kullanarak zaman alan bir işlemi simüle eden basit bir asenkron metot oluşturun.

**Talimatlar:**

* **Program.cs** dosyasında **Program** adlı bir sınıf oluşturun.
* **Program** sınıfının içinde **PerformLongOperationAsync** adlı bir metot oluşturun.
* Metodun içinde gecikmeyi simüle etmek için `await Task.Delay` kullanın.

---

### 3️⃣ `Main` İçinde Asenkron Metodu Çağırma

Program çıkmadan önce tamamlanmasını bekleyecek şekilde asenkron metodu **Main** metodundan çağırın.

**Talimatlar:**

* **PerformLongOperationAsync** metodunun altına bir **Main** metodu oluşturun.
* **Main** metodunda **PerformLongOperationAsync** metodunu **Task.Run** kullanarak çağırın.
* Programın asenkron metodun tamamlanmasını beklediğinden emin olun.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırırken bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

### 4️⃣ Konsol Çıktılarıyla Hata Ayıklamayı Simüle Etme

**Console.WriteLine** ifadelerini breakpoint gibi kullanarak programın akışını gözlemleyin.

**Talimatlar:**

* **PerformLongOperationAsync** metodunda **await** satırından sonra bir `Console.WriteLine` ifadesi ekleyin.
* Bu ifadeleri program akışını anlamak için kullanın.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırırken bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

### 5️⃣ Olası Hataları Ele Alma

Kodu daha sağlam hâle getirmek için asenkron metoda hata yönetimi ekleyin.

**Talimatlar:**

* **PerformLongOperationAsync** metodunu bir **try-catch** bloğu içerecek şekilde değiştirin.
* Çalışma sırasında oluşabilecek istisnaları yakalayın ve bir hata mesajı yazdırın.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırırken bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.
