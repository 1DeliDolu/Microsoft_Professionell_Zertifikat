## 🧪 Genel Bakış

### 🎯 Amaç

Bu laboratuvarın sonunda, C#’ta **async** ve **await** anahtar sözcüklerini kullanarak asenkron metotlar oluşturabilecek ve uygulayabileceksiniz. Uygulamalarınızın performansını artırmak için kodu asenkron çalıştırma pratiği yapacaksınız.

---

## 🧵 C#’ta `async` ve `await` Kullanımı

### 1️⃣ Asenkron Programlamayı Anlamak

Asenkron programlama, uygulamanızın diğer görevlerin tamamlanmasını beklemeden görevleri yerine getirmesine olanak tanır ve programın duyarlı kalmasını sağlar. Kursun başında oluşturduğunuz Visual Studio Code konsol uygulamasını kullanarak küçük bir uygulama geliştireceksiniz. Uygulamanız birden fazla asenkron metot çalıştıracak.

Konsol uygulamanızın **Program.cs** dosyasındaki mevcut tüm kodları kaldırın ve her adımda verilen tüm kodu bu dosyada oluşturun.

---

### 2️⃣ Asenkron Bir Metot Oluşturma

Veri indirme gibi tamamlanması zaman alan bir görevi simüle eden basit bir asenkron metot oluşturun.

**Talimatlar:**

* **Program.cs** dosyasında **Program** adlı bir sınıf oluşturun.
* **Program** sınıfının içinde **DownloadDataAsync** adlı bir metot oluşturun.
* Metodu asenkron yapmak için **async** anahtar sözcüğünü kullanın.
* Metodun içinde gecikmeyi simüle etmek için `await Task.Delay` kullanın.
* Metodun ne zaman başladığını ve bittiğini göstermek için gecikmeden önce ve sonra bir mesaj yazdırın.

---

### 3️⃣ Bir Asenkron Metodu Çalıştırma

Bir **Main** metodu oluşturun ve indirme gecikmesini simüle etmek için asenkron metoda atanan bir değişken oluşturun.

**Talimatlar:**

* **DownloadDataAsync** metodunun altına bir **Main** metodu oluşturun.
* **Main** metodunda **Program** sınıfından bir örnek ( *instance* ) oluşturun.
* **DownloadDataAsync** metodunu **await** kullanarak çağırın.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırırken bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

### 4️⃣ Birden Fazla Asenkron Metodu Çalıştırma

Birden fazla asenkron metodu paralel çalıştırarak aynı anda nasıl yürütülebildiklerini gözlemleyin.

**Talimatlar:**

* **DownloadDataAsync** metodunun altına **DownloadDataAsync2** adlı ikinci bir metot oluşturun.
* **Main** metodunu, **DownloadDataAsync** ve **DownloadDataAsync2** metotlarını paralel çalıştırmak için **Task.WhenAll** kullanacak şekilde güncelleyin.
* Her iki metodun aynı anda çalıştığını gözlemleyin.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırırken bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

### 5️⃣ Asenkron Metotlarda İstisna Yönetimi

**try-catch** bloğu kullanarak asenkron metotlara hata yönetimi ekleyin.

**Talimatlar:**

* **DownloadDataAsync** metodunu, bir **try-catch** bloğu içerecek şekilde değiştirin.
* Bir istisna fırlatan kod ekleyerek bir hatayı simüle edin.
* İstisnayı yakalayın ve bir hata mesajı görüntüleyin.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırırken bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.
