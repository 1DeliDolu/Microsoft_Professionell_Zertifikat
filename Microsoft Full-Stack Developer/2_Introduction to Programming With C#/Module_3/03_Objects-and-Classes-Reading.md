
## 🧱 Nesneler ve Sınıflar

### 🧩 Giriş

Bu içerik, nesne yönelimli programlamanın ( *object-oriented programming – OOP* ) temel kavramlarını inceler ve nesneler, sınıflar, *kapsülleme (encapsulation)* ve *soyutlama (abstraction)* kavramlarının C#’ta kodlamaya nasıl yapılandırılmış ve sürdürülebilir bir yaklaşım kazandırdığını ele alır. Bu kavramları anlamak, güvenli ve verimli yazılımlar geliştirmek için kritik öneme sahiptir.

---

## 🧱 OOP’de Nesneler ve Sınıflar

OOP’de nesneler ve sınıflar, birincil yapı taşları olarak hizmet eder. Bir sınıf, bir grup varlık için paylaşılan özellikler ve davranışlar kümesini tanımlayan bir plan ( *blueprint* ) veya şablondur ( *template* ).

Örneğin, bir kütüphane sisteminde bir *book* sınıfı;  *title* , *author* ve *ISBN* gibi özellikleri, ayrıca *borrowing* ve *returning* gibi metotları tanımlayabilir. Kütüphanedeki her kitap, *Book* sınıfının bir örneği ( *instance* ) olan bir nesneyi temsil eder.

Nesneler, ait oldukları sınıf tarafından tanımlanan benzersiz özelliklere ve davranışlara sahiptir. Özellikler (bir kitabın  *title* ’ı gibi) ve metotlar (bir kitabı ödünç alabilme gibi) bu nesnelerin durumunu ( *state* ) ve davranışını ( *behavior* ) tanımlar.

Sınıflar kodu düzenlemek için kullanıldığında, geliştiriciler yeniden kullanılabilir ve ölçeklenebilir çözümler oluşturabilir.

---

## 🔒 Kapsülleme: İç Durumu Koruma

Kapsülleme, verileri ( *attributes* ) ve metotları bir sınıf içinde bir araya getirmeyi ve sınıfın bazı bileşenlerine erişimi kısıtlamayı içeren OOP’nin temel bir ilkesidir.

Bu ilke, veriye nasıl erişildiğini ve verinin nasıl değiştirildiğini yöneterek bir nesnenin iç durumunu korur. Geliştiriciler, erişim seviyelerini kontrol etmek için  *private* , *protected* ve *public* gibi erişim belirleyicilerini ( *access modifiers* ) kullanarak kapsüllemeyi sağlar:

* *Private:* Erişimi sınıfla sınırlar; verinin sınıf dışından doğrudan değiştirilememesini sağlar.
* *Protected:* Sınıfa ve alt sınıflarına erişime izin verir; miras alan sınıfların veri ve metotları kullanmasını ve genişletmesini mümkün kılar.
* *Public:* Veri ve metotları uygulamanın herhangi bir bölümüne açar; daha geniş erişime izin verir.

Örneğin, bir *BankAccount* sınıfında, hesap bakiyesi gibi hassas veriler *private* bir öznitelikle korunabilirken, iç durumu doğrudan açığa çıkarmadan hesapla etkileşim kurmak için *deposit* ve *withdrawal* gibi *public* metotlar sağlanır.

---

## 🧠 Soyutlama: Karmaşıklığı Basitleştirme

OOP’de soyutlama, bir nesnenin ne yaptığını tanımlamak; ancak bunu nasıl yaptığını belirtmemektir.

Bu ilke, geliştiricilerin basitleştirilmiş arayüzler oluşturmasına ve alttaki karmaşıklığı gizlemesine olanak tanır. Soyutlama genellikle  *abstract class* ’lar ve  *interface* ’ler kullanılarak uygulanır:

* *Abstract Classes:* Bazı standart metotları uygulama ayrıntılarıyla birlikte içeren ortak bir kod tabanı tanımlar ve ayrıca uygulaması olmayan bazı  *abstract method* ’ları barındırır.
* *Interfaces:* Bir sınıfın hangi metotları uygulaması gerektiğini belirten bir sözleşme ( *contract* ) tanımlar; ancak ayrıntı sağlamaz.

Örneğin, bir bankacılık uygulaması *deposit* ve *withdrawal* gibi ortak işlevleri ele almak için bir *abstract class* kullanabilir. Daha sonra *CheckingAccount* ve *SavingsAccount* sınıfları bu soyut sınıftan miras alarak, her hesap türü için özel ayrıntıları uygular.

Bu yaklaşım, uygulamanın diğer bölümlerinin bu metotları iç işleyişi anlamadan kullanabilmesini sağlar.

---

## ✅ Sonuç

Nesneler, sınıflar, kapsülleme ve soyutlama ilkeleri, C#’ta OOP’yi ustalıkla öğrenmek için gereklidir.

Kapsülleme, bir nesnenin verisinin bütünlüğünü korur; soyutlama ise kod etkileşimlerinin karmaşıklığını basitleştirir. Bu ilkeler birlikte, geliştiricilerin daha güvenli, sürdürülebilir ve anlaşılması daha kolay kod yazmasını sağlar ve daha verimli ve etkili yazılım geliştirme için yolu açar.
