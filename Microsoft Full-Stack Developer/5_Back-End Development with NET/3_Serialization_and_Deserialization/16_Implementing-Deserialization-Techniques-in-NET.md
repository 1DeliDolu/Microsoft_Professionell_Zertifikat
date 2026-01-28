## 🧪 .NET’te Deserialization Tekniklerini Uygulamak

Bu laboratuvarda, çeşitli dosya formatlarından veriyi deserialize edecek ve bunu daha sonra kullanıp üzerinde işlem yapabileceğimiz bir C# nesnesine yerleştirecek çok basit bir console uygulaması oluşturuyoruz.

---

## 🧱 Adım 1: Projeyi Oluşturmak ve Person Sınıfını Eklemek

Bu laboratuvarın birinci adımında, `.NET new console` kullanarak yeni bir console uygulaması oluşturuyoruz ve buna *deserialization demo* adını veriyoruz.

Ardından, deserialize ettiğimiz veriyi `Program.cs` dosyasında saklamak için kullanacağımız bir sınıf ekleyeceğiz.

*Program* sınıfı içinde *Person* adlı bir sınıf oluşturacağız ve bunun iki özelliği olacak: *username* ve  *userAge* .

*Username* bir string, *userAge* ise bir int.

Çeşitli dosya formatlarından veriyi deserialize ettiğimizde, bu veriyi saklamak için bu nesneyi kullanacağız.

---

## 🗃️ Adım 2: Binary Dosyayı Deserialize Etmek

İkinci adımda, bir binary dosyayı deserialize ederek başlayacağız.

`static void Main` içinde, yani uygulamanın çalıştığında çalışan ana metodunda, *person.dat* adlı bir dosyayı alacağız, deserialize edeceğiz ve sonra bunu *Person* nesnemizin içine koyacağız.

Binary deserialization kullanmak için `System.IO` kütüphanesini kullanmamız gerekir.

Bu yüzden dosyanın en üstüne `using System.IO` ekleriz; bu, uygulamamızda dosya verisini ve binary veriyi okumamıza ve yazmamıza izin verir.

Burada en üstte, uygulamanın başında çalışacak basit bir *stopwatch* oluşturacağız; bu, bu işlemlerin ne kadar hızlı gerçekleştiğini göstermek için.

Uygulamayı çalıştırdığınızda, binary serialization’ın XML veya JSON’a göre ne kadar sürede çalıştığına dair farklı süreleri görebilirsiniz.

Bunun gibi küçük bir uygulamada büyük bir fark görmezsiniz; ancak dosyalar büyüdükçe, operasyonun çalışma süresinin binary işlemler için anlamlı derecede farklı olduğunu, metin tabanlı işlemler (JSON veya XML) için ise daha kısa olduğunu fark edersiniz.

Bu, hız farkını göstermek için.

En üstte, *person.dat* dosyamızı açacağız.

`using` statement ile `new FileStream("person.dat", FileMode.Open)` kullanıyoruz.

Uygulamanın root dizininde *person.dat* adlı binary bir dosyamız olduğunu göreceksiniz; bu, uygulamaya bu dosyanın bir file stream’ini açmasını ve operasyonlar için hazır hâle getirmesini, kullanılmaya hazır etmesini söyler.

Sonraki satır: `using var reader = new BinaryReader(...)`.

Yani şimdi *FileStream* nesnesinden, `System.IO` kütüphanesini kullanarak yeni bir binary dosya okuyucu oluşturuyoruz.

Artık *person.dat* dosyasından oluşturulmuş bir *FileStream* nesnemiz olduğuna göre, bu binary veriyi okuyacağız.

Bu deserialization operasyonunun sonuçlarını, *deserializedPerson* adlı bir değişkene koyacağız; bunu yeni bir *Person* nesnesi olarak tanımladığımızı görüyorsunuz.

Binary reader işini yaparken, bu binary dosyada ne varsa parçalayacak ve veriyi, sonraki iki satırda göreceğiniz şekilde referans edebileceğimiz bir *Person* nesnesinin içine koyacak.

Yani *Person* nesnesinin içine şunu koyacağız:

`person.username`, `reader.ReadString()` sonucunu alacak.

Şu an içeride sadece bir string var ve o da  *username* ; yani hangi string varsa onu  *username* ’e koyacak.

Sonra `reader.ReadInt32()` var; bu da binary dosyadaki age değerini *userAge* içine koyacak.

Artık nesnemiz oluşturulduğuna göre, bu nesnenin property’lerini referans edebiliriz.

Önce stopwatch’u durduracağız.

Sonra console’a şunu yazacağız: `deserializedPerson.username` username’dir ve `deserializedPerson.userAge` userAge’dir.

Ayrıca operasyonu tamamlamanın ne kadar sürdüğünü de yazacağız.

Yani bu deserializer’ı kullanarak, bir binary dosyanın içeriğini alıp bir C# nesnesinin içine koyabiliriz ve sonra bunu referans edebiliriz.

---

## 🧾 Adım 3: XML Dosyayı Deserialize Etmek

Üçüncü adımda, çok benzer bir şey yapacağız.

Bir XML dosyasını deserialize edeceğiz ve nesnemizin içine koyacağız.

XML deserialization kullanmak için dosyanın en üstünde `using System.Xml.Serialization` bildirmemiz gerekiyor; bu, uygulamaya bu kütüphaneye erişmek istediğimizi söyler.

Sonra XML bölümümüzde, bu demo için, bir XML dosyası oluşturacağız ve bunu yeni bir değişkene serialize edeceğiz.

XML dosyasından okuyabilirdik.

Bunu size farklı bir şekilde gösteriyorum; çünkü uygulamanın bir bölümünde XML verisi oluşturup serialize edebilir ve uygulamanın diğer bölümlerinde okuyabiliriz.

Burada, *xmlData* adlı bir XML dosyası oluşturacağız.

Bunu *XmlSerializer* kullanarak serialize edeceğiz.

Sonra stopwatch’un yeni bir instance’ını oluşturacağız ve ardından bu reader ile deserialize edeceğiz.

Bir sonraki satırda şunu görüyoruz: `using var reader = new StringReader(xmlData)`.

Bu, *StringReader* sınıfının bir instance’ını oluşturmamızı sağlar; yukarıda oluşturduğumuz XML data’nın sonuçlarını bu reader değişkenine koyar.

Sonra bunu bir *Person* nesnesine deserialize edeceğiz.

Bir sonraki satır, *deserializedPerson* adlı bir değişken oluşturmak ve bunu bir deserialize metod çağrısına set etmek; burada yukarıdaki using statement’te oluşturduğumuz reader nesnesinin verisini geçiriyoruz.

Ve bunu *Person* tipi olarak set ediyoruz; bu, yukarıda tanımladığımız XML verisini *deserializedPerson* değişkenine deserialize edecek.

Sonraki satırda stopwatch’u durduruyoruz.

Sonra binary serialization’da yaptığımız gibi console’a XML dosyasında olan property’leri yazdırıyoruz.

Yani `deserializedPerson.username` ve `deserializedPerson.userAge`, XML’de ne olduğunu bize söyler.

Ve yine, bunu uygulamanın içinde tanımladığımız verilerle de yapabiliriz ya da harici bir dosyadan da yapabiliriz.

Son olarak, bu operasyonun ne kadar sürdüğünü console’a yazdırıyoruz.

---

## 🧩 Adım 4: JSON Veriyi Deserialize Etmek

Dördüncü adımda, tamamen aynı şeyi yapacağız ama JSON verisi kullanacağız.

JSON serializer kullanmak için en üste `using System.Text.Json` ekledim; bu, uygulamaya JSON kütüphanesini kullanmak istediğimizi söyler.

Ve kodumuzun JSON bölümünde, XML serialization’da yaptığımıza benzer bir şey yapıyoruz.

Yani *jsonData* değişkenini tanımlıyoruz; bu, özünde bir JSON dosyası veya JSON verisi içeren bir değişken.

Stopwatch’u tanımlıyoruz ve yeni bir instance olarak başlatıyoruz.

Sonra JSON verimizi deserialize ediyoruz: *deserializedPerson* değişkenini tanımlayıp `JsonSerializer.Deserialize(...)` çağırıyoruz; JSON verisini geçiriyoruz ve bu işlem için *Person* tipini kullanıyoruz.

Sonra stopwatch’u durduruyoruz.

Ve XML ile binary serialization’da yaptığımız gibi, artık C# nesnesi üzerinde dot notation kullanarak JSON dosyasında olan veriyi referans edebiliyoruz.

Yani `deserializedPerson.username` ve `deserializedPerson.userAge` kullanabilirsiniz.

Ve bunun ne kadar sürdüğünü console’a yazdırıyoruz.

---

## ✅ Kapanış

Yani bunlar; çeşitli dosya türlerinden veya çeşitli veri yapı türlerinden veriyi deserialize edip bir C# nesnesinin içine koymanın, sonra da dot notation ile referans etmenin üç farklı yolu.

Bunların her birini art arda çalıştırsaydınız, sürelerdeki farkı ve her operasyonun ne kadar sürdüğünü görürdünüz.

Ve dosyalarınız büyüdükçe, farklı süreler görmeye başlayabilirsiniz; bu sayede her bir operasyonun ne kadar hızlı ve verimli olduğuna göre amacınız için hangisinin en iyi olduğunu seçebilirsiniz.
