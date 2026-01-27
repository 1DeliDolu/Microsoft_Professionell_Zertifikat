## 🧭 Genel Bakış

### 🎯 Amaç

Bu etkinliğin sonunda, katılımcılar C# programlarında *kalıtım (inheritance)* ve *çok biçimlilik (polymorphism)* uygulayabilecektir. Taban ve türetilmiş sınıfların nasıl oluşturulacağını, *virtual* ve *override* anahtar sözcüklerinin nasıl kullanılacağını, interface’lerin nasıl uygulanacağını ve nesnelerle birleşik bir şekilde etkileşim kurmak için çok biçimliliğin nasıl kullanılacağını anlayacaklardır.

---

## 🧬 C#’ta Kalıtım ve Çok Biçimlilik

### 🧩 Adım 1: Uygulamayı Hazırlama

Kursun başında oluşturduğunuz Visual Studio Code konsol uygulamasını kullanarak küçük bir uygulama oluşturacaksınız.

Konsol uygulamanızın **Program.cs** dosyasındaki mevcut kodları kaldırın ve her adımda verilen tüm kodları bu dosyada oluşturun.

---

## 🐾 Adım 2: Taban Sınıf ve Türetilmiş Sınıflar Oluşturma

*Animal* adlı bir taban sınıf ve *Dog* ile *Cat* adlı iki türetilmiş sınıf oluşturun. Bu, *Dog* ve  *Cat* ’in  *Animal* ’dan özellikleri ve metotları miras aldığı kalıtım kavramını size tanıtır.

**Talimatlar:**

* *MakeSound* adlı *virtual* bir metodu olan bir taban sınıf *Animal* tanımlayın.
* *Animal* ’dan miras alan iki türetilmiş sınıf *Dog* ve *Cat* oluşturun.
* Her türetilmiş sınıfta *MakeSound* metodunu *override* edin.

---

## 🧠 Adım 3: Virtual ve Override Anahtar Sözcüklerini Kullanma

Oluşturduğunuz taban sınıftaki metotları *virtual* ve *override* anahtar sözcükleriyle nasıl çağıracağınızı keşfedin.

**Talimatlar:**

* **Program.cs** içindeki mevcut sınıfların  **üstüne** , bir *Program* sınıfı oluşturun.
* *Program* sınıfında bir *Main* metodu oluşturun.
* *Main* metodunda, *Dog* ve *Cat* sınıflarından örnekler oluşturun ve ardından *Dog* ve *Cat* örneklerinden *MakeSound* metodunu çağırın.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## 🧾 Adım 4: Interface’leri Uygulama

Sınıfların uygulayabileceği bir sözleşme ( *contract* ) tanımlamak için interface’leri tanıtın. Interface’ler, farklı sınıfların sahip olması gereken metotlar kümesini belirtmemize olanak tanır.

**Talimatlar:**

* **Program.cs** içindeki mevcut sınıfların  **üstüne** , *Eat* adlı bir metodu olan *IAnimal* adlı bir interface tanımlayın.
* Bu interface’i *Animal* sınıfında uygulayın ve *Dog* ile *Cat* sınıflarında bir uygulama sağlayın.

---

## 🍽️ Adım 5: Interface’i Kullanma

Ana programınızdan interface metotlarını nasıl çağıracağınızı keşfedin.

**Talimatlar:**

* *Main* metodunda, mevcut metot çağrılarının altına, *Dog* ve *Cat* örneklerinden *Eat* metodunu çağırın.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## 🧩 Adım 6: Taban Tür ve Interface Listeleri ile Çok Biçimlilik

Farklı sınıflardaki nesnelerle ortak bir taban tür ( *base type* ) veya interface üzerinden etkileşim kurmak için çok biçimliliği kullanın. Bu, farklı nesneler üzerinde metotları birleşik bir şekilde çağırmamızı sağlar.

**Talimatlar:**

* *Main* metodunu, *Dog* ve *Cat* örneklerini içeren bir *Animal* nesneleri listesi oluşturarak güncelleyin.
* Listede dolaşmak için bir döngü kullanın ve listedeki her nesne üzerinde *MakeSound* metodunu çağırın.

Cevabınızı kontrol etmek için Visual Studio Code konsol uygulamasını çalıştırın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.
