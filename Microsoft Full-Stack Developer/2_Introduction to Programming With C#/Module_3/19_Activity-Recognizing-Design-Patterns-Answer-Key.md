## 🧩 Etkinlik: Tasarım Desenlerini Tanıma - Cevap Anahtarı

---

## 🏭 Problem 1 için Cevap Anahtarı: Factory Deseni

**Desen:** Factory

**Açıklama:** *Factory* deseni, nesneleri oluşturmak için, oluşturulacak nesnenin tam sınıfını belirtmeden bir yol sağlar. Nesne örnekleme ( *instantiation* ) işlemini kapsülleyen ( *encapsulates* ) bir metot kullanır; bu da kodu daha esnek hâle getirir.

**Açıklama Detayları:**

*AnimalFactory* sınıfı, verilen string’e göre *Dog* veya *Cat* örneği döndüren *CreateAnimal()* adlı bir metot içerir.

Bu desen, istemci kodun ( *client code* ) somut sınıf örneklemesinden sorumlu olmaması gereken durumlar için kullanışlıdır.

---

## 👀 Problem 2 için Cevap Anahtarı: Observer Deseni

**Desen:** Observer

**Açıklama:** *Observer* deseni, nesneler arasında bire-çok ( *one-to-many* ) bir ilişki tanımlar. Bir nesne ( *subject* ) durum değiştirdiğinde, kayıtlı tüm gözlemcileri ( *observers* ) bilgilendirir.

**Açıklama Detayları:**

*Subject* sınıfı, *IObserver* örneklerinden oluşan bir listeyi yönetir ve değişiklikleri onlara bildirir ( *notifies* ).

Bu desen, bir olay ( *event* ) gerçekleştiğinde birden fazla nesnenin güncellenmesi gerektiği olay işleme ( *event handling* ) gibi senaryolarda faydalıdır.
