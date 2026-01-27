## 🧭 Genel Bakış

### 🎯 Amaç

Bu laboratuvarın sonunda, C#’ta sınıflar ve nesneler oluşturup uygulayabileceksiniz. Ayrıca bir sınıf içinde özellikleri ( *properties* ) ve metotları ( *methods* ) nasıl tanımlayacağınızı ve bu metotları nesnelerle eylem gerçekleştirmek için nasıl kullanacağınızı öğreneceksiniz.

---

## 🧱 Sınıfları ve Nesneleri Uygulamak

### 🧩 Adım 1: Uygulamaya Hazırlık

Kursun başında oluşturduğunuz Visual Studio Code konsol uygulamasını kullanarak küçük bir uygulama oluşturacaksınız. Uygulamanız, kullanıcıların basit bir yapılacaklar listesi ( *to-do list* ) yönetmesine olanak tanır. Program, kullanıcıların bir uygulama için bir selamlama ( *greeting* ) metodu oluşturmasına izin verecektir.

Konsol uygulamanızdaki **Program.cs** dosyasında bulunan mevcut kodları kaldırın ve her adımda verilen tüm kodları bu dosyada oluşturun.

---

## 👤 Adım 2: Temel Bir Sınıf Oluşturma

**Person.cs** dosyasında, bir kişinin karakteristiklerini temsil eden özellikleri içeren *Person* adlı bir sınıf tanımlayın.

**Talimatlar:**

* *Person* adlı bir sınıf tanımlayın.
* İki özellik oluşturun: *Name* (string) ve *Age* (integer).

---

## 🧍 Adım 3: Nesneler Oluşturma

*Person* sınıfından nesneler oluşturun ve özelliklerine değer atayın.

**Talimatlar:**

* *Person* sınıfından iki nesne oluşturun.
* Bu nesnelerin *Name* ve *Age* özelliklerine farklı değerler atayın.

---

## ⚙️ Adım 4: Metot Oluşturma

*Person* sınıfına bir eylem gerçekleştiren bir metot ekleyin; örneğin bir selamlama yazdırmak gibi.

**Talimatlar:**

* *Person* sınıfını, *Greet* adlı bir metot yazarak güncelleyin.
* Bu metodun, kişinin adını içeren bir mesaj yazdırmasını sağlayın.

---

## 🔗 Adım 5: Nesnelerde Metot Kullanma

Her *Person* nesnesinde metodu çağırarak bir eylem gerçekleştirin.

**Talimatlar:**

* *Main* metodunu, her *Person* nesnesinde *Greet* metodunu çağıracak şekilde güncelleyin ve kişiselleştirilmiş bir selamlama yazdırın.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## 👥 Adım 6: Birden Fazla Nesne ile Pratik

Aynı sınıftan ek nesneler oluşturun ve her birinin bağımsız şekilde nasıl davrandığını görmek için metotları kullanın.

**Talimatlar:**

* *Main* metodunu, üçüncü bir *Person* nesnesi oluşturarak güncelleyin.
* Bu nesneye farklı bir ad ve yaş atayın.
* Bu yeni nesne üzerinde *Greet* metodunu çağırın.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.
