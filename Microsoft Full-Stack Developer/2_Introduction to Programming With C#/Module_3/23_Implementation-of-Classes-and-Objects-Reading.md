## 🧱 Sınıflar ve Nesnelerin Uygulanması

### 🧩 Giriş

Bu okuma, C#’ta sınıf ve nesne oluşturmanın temellerini tanıtır; bunlar nesne yönelimli programlamanın ( *OOP* ) temel bileşenleridir. Bir sınıf tanımlamayı, nesneleri örneklemeyi ( *instantiate* ) ve nesne özellikleri ile metotlarını kullanmayı öğreneceksiniz.

---

## 🧠 Sınıfları Anlamak

C#’ta bir sınıf, nesnelerin yapısını ve davranışını tanımlayan bir plan ( *blueprint* ) görevi görür. Birkaç temel bileşen içerir:

* *Properties:* Nesnenin tuttuğu öznitelikler veya veriler; örneğin bir kişinin adı veya yaşı.
* *Methods:* Nesnenin gerçekleştirebileceği davranışları veya eylemleri tanımlayan fonksiyonlar.
* *Constructors:* Nesneler oluşturulurken onları başlatmak için kullanılan özel metotlar.

Örneğin, bir *Person* sınıfı *name* ve *age* özelliklerine, bir nesne oluşturulduğunda bu değerleri ayarlayan bir constructor’a ve kişinin bilgilerini görüntüleyen bir metoda sahip olabilir.

---

## 🧩 C#’ta Sınıf Tanımlama

C#’ta bir sınıf tanımlamak için belirli bir söz dizimini ( *syntax* ) takip edersiniz:

* *Access Modifier* — Sınıfın görünürlüğünü belirtir (ör.  *public* ).
* *Class Keyword* — Sınıf bildirmek için *class* anahtar sözcüğü kullanılır.
* *Class Name* — Sınıf için bir tanımlayıcıdır ( *identifier* ).

Aşağıda C#’ta bir *Person* sınıfı örneği verilmiştir:

```csharp
public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
    public void DisplayInfo() {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
```

---

## 📝 Bu Örnekte

 *Public* , sınıfın başka herhangi bir kod tarafından kullanılabilmesini sağlayan erişim belirleyicisidir.

 *Person* , sınıfın adıdır.

Sınıfın içinde özellikleri (*Name* ve  *Age* ), bir constructor’ı ve bir metodu ( *DisplayInfo* ) tanımlarız.

---

## 🏗️ Nesne Oluşturma (Örnekleme)

Bir sınıfı kullanmak için, onun bir örneğini oluşturmanız gerekir; buna nesne ( *object* ) denir. Bu süreç *örnekleme (instantiation)* olarak adlandırılır.

Bir nesne, bir sınıfın belirli bir örneğidir; kurabiye kalıbından çıkan bir kurabiye gibi.

Bir nesne oluşturmak için, sınıf constructor’ı ile birlikte *new* anahtar sözcüğünü kullanın:

```csharp
Person neighbor = new Person("John Doe", 30);
```

---

## 📝 Bu Satırda

 *Person* , nesnenin türüdür.

 *neighbor* , nesnenin adıdır.

 *new Person("John Doe", 30);* , constructor’ı kullanarak yeni bir *Person* nesnesi oluşturur.

---

## 🔗 Dot Notation Kullanımı

Bir nesne örneklendikten sonra, dot notation kullanarak özelliklerine erişebilir, onları değiştirebilir veya metotlarını çağırabilirsiniz. Dot notation, bir üyesine erişmek için nokta (`.`) kullanmayı ifade eder.

### Örnek

Özelliklere erişme: `neighbor.Age = 31;` ifadesi, *neighbor* nesnesinin *Age* özelliğini 31 olarak değiştirir.

Metot çağırma: `neighbor.DisplayInfo();` ifadesi, nesnenin bilgisini göstermek için *DisplayInfo* metodunu çalıştırır.

---

## ✅ Sonuç

Sınıfları ve nesneleri anlamak, C#’ta uygulama geliştirmenin temelidir. Geliştiricilerin modüler ve yeniden kullanılabilir kod yazmasına olanak tanır; yazılım projelerini yönetmeyi ve genişletmeyi kolaylaştırır.

Bu kavramlarda ustalaşmak, sağlam nesne yönelimli programlar geliştirmeye giden yolda kritik bir adımdır.
