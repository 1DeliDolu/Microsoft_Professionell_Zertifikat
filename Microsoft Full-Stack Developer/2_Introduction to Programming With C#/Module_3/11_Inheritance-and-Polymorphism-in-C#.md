## 🧬 C#’ta Kalıtım ve Çok Biçimlilik

İki türetilmiş sınıf olan *Dog* ve *Cat* ile birlikte *Animal* adlı bir taban sınıf oluşturarak başlayacağız. Bu, *Dog* ve  *Cat* ’in  *Animal* ’dan özellikleri ve metotları miras alacağı kalıtım ( *inheritance* ) kavramını size tanıtacaktır.

Kalıtım, daha spesifik sınıflar olan *Dog* ve *Cat* için temel olarak kullanılabilecek genel bir *Animal* sınıfı oluşturmanıza olanak tanır. Bu, ortak özellikler ve metotlar taban sınıfta tanımlandığı için kod tekrarını önlememize yardımcı olur.

Örneğin, tüm hayvanlar bir ses çıkarabilir; ancak her hayvan farklı bir ses çıkarır. Programımızda *Animal* sınıfı, her bir özel *Animal* sınıfının kendi sesini sağlamak üzere geçersiz kılabileceği ( *override* ) *MakeSound* adlı bir metoda sahip olacaktır.

---

## 🧩 Virtual ve Override

Taban sınıftaki bir metodun türetilmiş bir sınıfta geçersiz kılınmasına izin vermek istediğimizde *virtual* anahtar sözcüğünü kullanırız.

Bu, C#’a taban sınıftaki metodun onu miras alan herhangi bir sınıfta geçersiz kılınmak üzere tasarlandığını söyler.

Daha sonra türetilmiş sınıflar olan *Dog* ve  *Cat* , *MakeSound* metodunun kendi uygulamalarını sağlamak için *override* anahtar sözcüğünü kullanır. Bu, her türetilmiş sınıfın metodun davranışını özelleştirmesine olanak tanır.

 *Virtual* ’ı, taban sınıfta bir şeyin nasıl çalıştığını değiştirmek için izin vermek gibi;  *override* ’ı ise türetilmiş sınıfta bu değişikliği gerçekten yapmak gibi düşünebilirsiniz.

---

## 🏗️ Main Metodunda Nesne Oluşturma ve Metot Çağırma

Bu adımda, uygulamaya giriş noktası olarak *main* metodunu kullanarak türetilmiş sınıfları *program* sınıfımızdan çağıracağız.

*Main* metodunda, *new* anahtar sözcüğünü kullanarak bir *Dog* nesnesi ve bir *Cat* nesnesi örnekleriz ( *instantiate* ).

Nesneler örneklendikten sonra, sınıfta tanımladığımız herhangi bir *public* metodu bu nesneler üzerinde çağırabiliriz.

Daha sonra her nesnede *mMkeSound* metodunu çağırırız; bu metodun, ilişkili çıktıyı konsola yazdırması gerekir.

*MakeSound* metodu için giriş parametrelerine ihtiyacımız yoktur; çünkü çıktı, türetilmiş sınıfların kendilerinde tanımlanmıştır.

---

## 🧾 Interface’lere Giriş

Şimdi, sınıfların uygulayabileceği ( *implement* ) bir sözleşme ( *contract* ) tanımlamamıza olanak tanıyan interface’leri tanıtacağız.

Bu, kalıtımdan farklıdır; ancak onunla birlikte kullanılabilir.

Bir interface, sınıfların uymayı kabul edebileceği bir sözleşme gibidir. Interface’i uygulayan herhangi bir sınıf tarafından uygulanması gereken metotları tanımlar.

Sınıfların aksine interface’ler herhangi bir uygulama ayrıntısı ( *implementation details* ) sağlamaz; yalnızca hangi metotların sağlanması gerektiğini tanımlar.

Interface’ler kullanışlıdır; çünkü kalıtım yoluyla ilişkili olmasalar bile farklı sınıfların sahip olması gereken bir metot kümesini belirtmemize olanak tanır.

Örneğin, *eat* adlı bir metoda sahip *ianimal* interface’imiz varsa,  *IAnimal* ’ı uygulayan herhangi bir sınıf *Eat* için bir uygulama sağlamak zorundadır; bu da tüm hayvanların bu metoda sahip olmasını sağlar.

Interface’ler, onları uygulayan herhangi bir sınıfta belirli metotların var olacağını garanti etmenin bir yolunu sunar.

---

## 🧩 Çok Biçimlilik ile Ortak Tip Üzerinden Etkileşim

Bu adımda, farklı sınıflardaki nesnelerle ortak bir taban tür ( *base type* ) veya interface üzerinden etkileşim kurmak için çok biçimliliği ( *polymorphism* ) kullanacağız.

Bu, farklı nesneler üzerinde metotları birleşik bir şekilde çağırmamızı sağlar.

Çok biçimlilik, farklı nesnelere sanki aynı sınıfın veya interface’in örnekleriymiş gibi davranmamıza olanak tanır.

Bu güçlüdür; çünkü ortak bir taban sınıfı veya interface’i paylaşan herhangi bir sınıfla çalışabilecek kod yazmamızı sağlar.

Örneğin, *Dog* ve *Cat* örneklerini içeren bir *Animal* nesneleri listesi oluşturabiliriz.

Listedeki her nesne üzerinde *make sound* çağırdığımızda, her bir özel nesne için metodun doğru sürümü çağrılır.

Bu, hem *Dog* hem de  *Cat* ’in *Animal* taban sınıfından *MakeSound* metodunu geçersiz kılması sayesinde çalışır.

Çok biçimlilik, belirli türden bağımsız olarak farklı nesnelerle standart bir şekilde etkileşim kurmanızı sağlayan evrensel bir araç gibidir.

Bu, özellikle ortak bir interface veya taban sınıf paylaşan ama farklı davranan bir nesne grubuyla çalışmak istediğinizde çok kullanışlıdır.
