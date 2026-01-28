## 🧪 .NET’te Serialization Tekniklerini Uygulamak

Bu laboratuvarda, veriyi üç farklı format türüne serialize etmeyi pratik edebilmemiz için çok basit bir console uygulaması oluşturuyoruz.

---

## 🧱 Adım 1: Temel Projeyi Kurmak

Birinci adımda, temel projeyi kuruyoruz. Bu, `dotnet new console` kullanarak *SerializationDemo* adlı temel bir console uygulaması oluşturmak.

Bunu ben zaten oluşturdum ve buraya biraz kod ekledim; ancak orijinal projede şablon (templated) kod vardır ve onu çalıştırsaydınız “hello world” yazardı.

Adım 1’in üçüncü adımında, console uygulamamıza bir sınıf (class) ekliyoruz. Proje sınıfı içinde, iki özelliğe (property) sahip *Person* adlı *public class* oluşturuyoruz: *username* ve  *userAge* .

*Username* bir string değişkendir ve *userAge* bir int değişkendir; ve bu nesneyi, serialization işlemini yaptığımızda veriyi tutmak için kullanacağız.

Yani sınıfı oluşturacağız, sınıfın instance’ını oluşturacağız, sonra bu sınıfa veri ekleyeceğiz ve ardından farklı yöntemlerle serialize edeceğiz.

---

## 🗃️ Adım 2: Binary Serialization Uygulamak

İkinci adımda, binary serialization ile başlayacağız. Bu, bir *DAT* dosyası olan binary bir dosyaya yazmamızı sağlayacak.

Binary serialization kullanmak için dosyamızın en üstünde `using System.IO` tanımlamamız gerekiyor. Bu, dosya sistemindeki (file system) dosyalardan okuma ve yazma yapmamızı sağlar. Yani bunu oluşturuyoruz, bu işi yapmamızı sağlayan kütüphaneyi referans ediyoruz.

Sonra `static void Main` içinde, yani bu uygulamanın ana metodunda, *SamplePerson* adlı bir *Person* sınıfı instance’ı oluşturacağız ve bir *username* atayacağız.

Username *Alice* olacak ve userAge *30* olacak. Bu, main metodumuzun ilk satırı.

Şimdi `System.IO` kütüphanesini kullanacağız; bu yüzden *fs* adlı yeni bir *FileStream* nesnesi oluşturacağız ve buna *person.dat* dosyasını vereceğiz.

Yani *SamplePerson* nesnemizi bir dosyaya serialize ettiğimizde, bunu *person.dat* adlı bu binary dosyaya yazacağız.

Bu statement için kullanacağımız mod *Create* modu olacak.

Sonra, binary dosyalara yazmamıza olanak tanıyan yeni bir *BinaryWriter* instance’ı oluşturuyoruz ve bunun içine *FileStream* nesnemizi geçiriyoruz.

*FileStream* nesnesi, yazmak istediğimiz ham (raw) veridir ve *BinaryWriter* ise aslında *person.dat* nesnesine yazan fonksiyondur.

Şimdi `new BinaryWriter` kullanarak oluşturduğumuz *BinaryWriter* nesnesine sahip olduğumuza göre, *SamplePerson* verimizi yazacağız.

Yani ilk satırda tanımladığımız *SamplePerson.username* ve *SamplePerson.userAge* değerlerini yazacağız.

Veri yazıldıktan sonra, console’a serialization’ın tamamlandığını yazdıracağız.

Bu, C Sharp’ta bir nesneden binary bir dosyaya yazmak için gereken her şey.

---

## 🧾 Adım 3: XML Serialization Uygulamak

Üçüncü adımda, XML serialization uygulayacağız; bu, bir text dosyasına, yani XML dosyasına yazmamızı sağlar.

Uygulamamızın en üstünde `System.Xml.Serialization` kütüphanesini referans etmemiz gerekiyor; yani uygulamamıza bu kütüphaneyi kullanmasını söylüyoruz.

Bunu dosyanın üst kısmında yaptık.

Sonra burada, binary serialization’ın altında, *XmlSerializer* kullanarak başka bir serialization türü ekledim; *XmlSerializer* tipini kullanarak.

Ve *Person* sınıfını kullanarak bunun yeni bir instance’ını oluşturacağız.

*SamplePerson* nesnesini zaten yukarıda tanımladığımız için, zaten *Person* sınıfında.  *SamplePerson* ’ı burada tanımladık.

Bu yüzden, yukarıda oluşturduğumuza benzer bir *writer* ile `xmlSerializer.Serialize` çağırabiliriz.

Bu nesneye *Person.xml* diyeceğiz ve içine *SamplePerson* verimizi geçeceğiz.

Sonra *XmlSerializer* geri kalan her şeyi bizim için halleder.

Yani nesneyi alacak, XML’e dönüştürecek ve *Person.xml* dosyasına yazacak.

---

## 🧩 Adım 4: JSON Dosyasına Yazmak

Son olarak, dördüncü adımda bir JSON dosyasına yazacağız.

Burada, dosyamızın en üstünde `System.Text.Json` referans edeceğiz. Bu, .NET’in dahili (internal) JSON serializer’ıdır. Bu uygulama için bu sürümü kullanacağız.

Sonra, diğer serialization’larda yaptığımıza benzer şekilde, JSON serializer’a bir referans oluşturuyoruz.

Burada ilk satır şu: `string jsonData = JsonSerializer.Serialize(...)`

Ve *SamplePerson* verimizi geçiriyoruz.

Diğer serializer’lara benzer şekilde bu metot, oluşturduğumuz nesneyi parçalayacak ve JSON formatına koyacak.

Sonra `File.WriteAllText` kullanıyoruz; bu, *File* kütüphanesinin bize sunduğu bir şey.

Tüm metni *Person.json* adlı bir dosyaya yazıyoruz ve veriyi de JSON string’imiz olarak veriyoruz.

Ve sonra console’a JSON serialization’ın tamamlandığını yazdırıyoruz.

---

## 📄 Çalıştırma Sonuçları

Bu işlemlerin her birinde, programı çalıştırdığımızda sonucun nasıl göründüğünü görebiliriz.

*Person.xml* bir XML dosyasıdır ve burada *username* Alice, *userAge* 30 görürsünüz; XML dosyası olarak formatlanmıştır.

JSON’da da aynı şekilde; *Person.json* bir JSON dosyası olarak formatlanmıştır ve aynı verileri içerir: *username* ve  *userAge* .

*Person.dat* dosyasına ise bakamayacağız çünkü bu binary’dir.

Visual Studio Code bunun editor tarafından okunabilir bir dosya olmadığını söyler.

Yani bunun bir binary dosya olduğunu biliyoruz.

Ve .NET’teki serialization fonksiyonlarını kullanarak farklı nesne türlerine nasıl serialize edeceğiniz de bu şekildedir.
