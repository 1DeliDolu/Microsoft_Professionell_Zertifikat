
## 🛡️ Serialization ve Deserialization Süreçlerini Güvenli Hâle Getirmek

Bu laboratuvarda, .NET framework kullanarak serialization operasyonlarını korumayı pratik edebileceğimiz bir console uygulaması kuracağız. İlk adımda, adım birde, yeni bir .NET console uygulaması oluşturarak projeyi kuracağız; buna bir *serialization security app* diyeceğiz ve bu temel şablonu (template) güvenlik becerilerini pratik etmek için değiştireceğiz.

---

## 🧱 Adım 1: Projeyi Kurmak ve User Sınıfını Oluşturmak

Adım birin üçüncü alt adımında, `Program.cs` dosyamızı bir *User* sınıfı oluşturarak değiştireceğiz.

Şimdilik sadece bu *User* sınıfının ilk üç satırına odaklanın.

Yani *Program* sınıfı içinde *User* adlı bir *public class* var ve bunun üç property’si var:  *Name* , *Email* ve  *Password* .

Şimdilik adım birde yapacağımız tek şey, bu property’lere sahip *User* nesnesini oluşturmak.

Bu nesnenin *Password* içerdiğini fark edeceksiniz.

Dolayısıyla ileride bunu korumak isteyebiliriz; parolanın güvenli kalması için.

---

## 🧾 Adım 2: Serialization Operasyonlarını Eklemek

İkinci adımda, oluşturduğumuz bu nesneyi kullanabilmek için bazı operasyonlar eklemeye başlayacağız.

*SerializeUserData* adlı bir metot oluşturacağız.

Bu metot bir string döndürecek ve metoda bir *User* nesnesi geçirilecek.

Bu metot için, adım iki başlangıcında çok basit bir şey yapacağız.

Bu *SerializeUserData* metodu sadece bir JSON string döndürecek.

Bu metodun son satırına odaklanın: `return JsonSerializer.Serialize(user);`

Bu metot, o *User* nesnesini—yani C# nesnesini—alıp JSON’a serialize edecek.

Bu metot çağrıldığında, çağıran metoda sadece bir JSON döndürür.

Adım iki içinde ayrıca, *Main* metodumuzu bu JSON serializer metodunu çağıracak şekilde değiştireceğiz.

Yani artık *Main* içinde *SerializeUserData* metoduna çağrı yapabiliriz.

Şu satıra odaklanın: `string serializedData = SerializeUserData(user);`

Şimdilik diğer satırları göz ardı edin. Birazdan geri döneceğiz.

İlk yaptığımız şey bir *User* nesnesi oluşturmak ve property’lerini tanımlamak.

Name  *Alice* , email *[alice@example.com](mailto:alice@example.com)* ve sonra bir *Password* var.

Bu user nesnesini *SerializeUserData* metoduna verdiğimizde, geri aldığımız şey JSON; yani düz metin (plain text).

Dolayısıyla bunu internet üzerinden taşımaya kalkarsak, bu JSON içindeki veri güvenli olmaz.

Password düz metin olarak durur.

Ve eğer bu önemli bir sisteme erişmek için kullanılıyorsa, bu veri JSON dosyasını okuyan herkes için açığa çıkmış olur.

Ardından console’a bu  *serializedData* ’nın ne olduğunu yazdıracağız.

Burada “generated hash” gösteriyoruz; ama adım iki içinde o seçenek için sadece *serializedData* döndüreceksiniz.

---

## ✅ Adım 3: Validation Ekleyerek SerializeUserData’yı İyileştirmek

Üçüncü adımda, *SerializeUserData* metodumuzu validation ekleyerek geliştireceğiz.

Bu kod bloğunda bir `if` statement ekliyoruz.

Bu `if` statement,  *UserName* , *UserEmail* ve *User.Password* değerlerinin *null* olup olmadığını veya sadece whitespace içerip içermediğini doğruluyor.

Eğer *null* iseler, eğer değerleri yoksa veya whitespace varsa, veriyi serialize etmeyeceğiz.

Bu bir hack’i gösterebilir, bir problemi gösterebilir.

Bu yüzden, *User* nesnesindeki her değerin dolu olduğundan ve whitespace olmadığından emin olmak için basit bir validation ekliyoruz.

Eğer sorun varsa, console’a verinin geçersiz olduğunu yazdırıyoruz ve boş string döndürüyoruz.

Aksi hâlde serialize edilmiş JSON’u döndürüyoruz.

---

## 🔐 Adım 4: Güvenli Serialization Kütüphaneleri ve Deserialization Kontrolü

Dördüncü adımda, bu veriyi güvenceye alma yaklaşımımızı iyileştirmek için güvenli serialization kütüphaneleri kullanacağız.

*DeserializeUserData* adlı başka bir metot oluşturacağız.

Bu metot bir *User* nesnesi türünde olacak.

JSON verisini alacağız ve verinin güvenilir olup olmadığını belirten bir *Boolean* değer geçeceğiz.

Sonra bir `if` statement var.

Eğer veri güvenilir değilse, deserialization’ı engelleyeceğiz ve bu veriyi “unpack” etmeyeceğiz.

Bu, metoda geçirdiğimiz *isTrustedSource* Boolean değerine bağlı.

Bu durumda *null* döndürüyoruz.

Aksi hâlde, JSON verisini deserialize edip bir *User* nesnesi döndürüyoruz; yani JSON verisini tekrar metoda geçiriyoruz ve bu, deserialize edilmiş JSON verisinden bir *User* nesnesi döndürüyor.

---

## 🔒 Adım 5: Encryption Eklemek

Beşinci adımda, uygulamamıza encryption ekleyeceğiz.

Password’ü şifreleyerek, eğer biri JSON verisini aktarım sırasında yakalarsa (snag), password’ü okuyamamasını sağlayacağız.

Encryption kullanabilmek için bir kütüphane eklememiz gerekir: `System.Security.Cryptography`.

Bu kütüphane, .NET framework içinde veriyi şifrelemek için özel fonksiyonları kullanmamıza izin verir.

Bunu yapmak için bir metot daha oluşturacağız.

Bu, altıncı adımın üçüncü alt adımı, adım altının üçüncü alt adımı.

*User* nesnesinin içine *EncryptData* adlı başka bir metot ekleyeceğiz.

Bu metodun içinde, çağırdığımızda password’ü base64 string’e dönüştürecek ve `GetBytes` metodunu kullanarak encode edecek.

Bu, password’ü temelde okunamaz bir string’e çevirir; yani yakalansa bile insanlar okuyamaz.

Bu metodun *User* nesnesinin içinde olduğuna dikkat edin; böylece password’ün ne olduğunu tanımladıktan sonra, bunu doğrudan `user.EncryptData()` diye çağırabiliriz.

---

## 🧾 Adım 7: Data Integrity Checks Eklemek

Yedinci adımda, veri bütünlüğü kontrolleri ekleyeceğiz.

Yine bunun için `System.Security.Cryptography` kütüphanesini kullanacağız.

Ve *User* sınıfımıza tekrar bir *GenerateHash* metodu ekleyeceğiz.

*User* sınıfımızın içinde *GenerateHash* adlı bir metot oluşturacağız ve bu metot string döndürecek.

Bu metot, cryptography library’nin bir parçası olan `SHA256.Create` metodunu kullanacak ve bir byte listesi oluşturacak.

Bunu `using` statement altında görebilirsiniz; *hashBytes* değişkenine koyacağız ve bu, *User* nesnesinin içindeki verinin bir hash’ini oluşturacak.

Sonra bunu base64 string olarak döndürecek.

Yani string olarak döndürüyor, ama bu hash’i oluşturuyor ki karşı tarafta biri hash’i hesaplamak isterse, hash’in eşleşmesi gerekir.

Bu metot bu hash’i üretmemizi sağlar; böylece insanlar verinin aktarım sırasında değiştirilmediğini doğrulayabilir.

---

## ✅ Kapanış

Bu basit güvenlik önlemlerini uygulayarak, *User* sınıfımızı koruduk, password’ümüzü koruduk ve bazı validation’lar yaptık.

Gerçek dünyadaki bir uygulamada, uygulamanızı daha da güvenli hâle getirmek için bu özellikleri genişletebilirsiniz.
