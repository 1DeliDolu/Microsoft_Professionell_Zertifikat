
## 🧱 Sınıfları ve Nesneleri Uygulamak

C#’ta bir sınıf, nesneler oluşturmak için bir plan ( *blueprint* ) gibidir. Bu, sınıftan oluşturulan nesnelerin hangi özelliklere ( *properties* ), özniteliklere ( *attributes* ) ve metotlara ( *methods* ), yani eylemlere sahip olacağını tanımlar.

Örneğin *person* adlı bir sınıfımız varsa, oluşturduğumuz her *person* nesnesi bu sınıfta tanımlanan özelliklere ve metotlara sahip olacaktır.

Özellikler, sınıfın karakteristikleri gibidir. Bu durumda her kişinin bir *name* ve bir *age* değerine sahip olmasını isteriz; bunlar bir kişiyi tanımlar.

Bir sınıf bu özellikleri kapsüller ( *encapsulates* ); böylece gerçek veri tutan belirli nesneler oluşturmak için kullanılabilirler.

*Person* sınıfımızı kullanmak için, ondan bir nesne oluşturmamız gerekir.

---

## 🧩 Nesne ve Örnekleme

Bir nesne, bir sınıfın örneğidir ( *instance* ); yani program içinde üzerinde çalışabileceğimiz sınıfın gerçek bir temsilidir.

Bir nesne oluşturmak için, *new* anahtar sözcüğünü ve ardından sınıf adını ve parantezleri kullanırız. Bu sürece *örnekleme (instantiation)* denir.

Bir sınıfı örneklediğimizde, kendi özellik ve metot setine sahip yeni bir nesne oluştururuz.

Her nesne, aynı sınıftan oluşturulmuş olsa bile özellikleri için farklı değerlere sahip olabilir.

---

## ⚙️ Metotlar ve Davranışlar

Bir sınıftaki metotlar, bir nesnenin gerçekleştirebileceği davranışları veya eylemleri tanımlar.

Özellikler nesne hakkında bilgi saklarken, metotlar nesnenin bir şey yapmasını sağlar.

*Person* sınıfımızda, kişinin adını içeren bir mesaj yazdıran *greet* adlı bir metot oluşturacağız.

Metotları, bir nesnenin gerçekleştirebileceği eylemler gibi düşünün.

Bu metot, selamlamayı kişiselleştirmek için *name* özelliğini kullanacaktır.

---

## 🔗 Dot Notation ile Metot Çağırma

Bir nesnenin bir eylemi gerçekleştirmesi için, dot notation kullanarak üzerinde bir metot çağırırız.

Bu, nesnenin adını, ardından bir nokta ( *dot* ) ve sonra metot adını yazmak anlamına gelir.

Örneğin,  *friend dot greet* , *friend* nesnesi üzerinde *greet* metodunu çağırır.

Bu metodu çağırdığımızda, içindeki kod çalışır ve bu örnekte kişinin adını içeren bir selamlama yazdırır.

Bu, nesnelerle nasıl etkileşim kurabileceğimizi ve metotları kullanarak onların eylem gerçekleştirmesini nasıl sağlayabileceğimizi gösterir.

---

## 👥 Aynı Sınıftan Birden Fazla Nesne Oluşturma

Aynı sınıftan birden fazla nesne oluşturabilirsiniz ve her nesne kendi özellik setine sahip olur.

*Friend* ve *colleague* her ikisi de *person* sınıfının örnekleri olsa bile, birbirlerinden bağımsızdır ve özellikleri için farklı değerlere sahip olabilirler.

Bu, bir sınıfın benzer karakteristiklere sahip ancak farklı veriler içeren çeşitli nesneler oluşturmak için bir şablon görevi görebileceğini gösterir.

Şimdi, her nesnenin bağımsız şekilde davrandığını görmek için bir *person* nesnesi daha oluşturalım.
