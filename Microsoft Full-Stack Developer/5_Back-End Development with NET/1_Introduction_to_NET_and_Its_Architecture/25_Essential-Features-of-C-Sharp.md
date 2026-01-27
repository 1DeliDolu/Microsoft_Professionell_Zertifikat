## 🧱 C#’ın Temel Özellikleri

C#’ta  **Object Oriented Programming (OOP)** ’i anlamak, iyi yapılandırılmış ve sürdürülebilir kod yazmak için kritiktir. C#’ta OOP, tuğlalarla ev inşa etmeye benzer. Her class benzersiz bir tuğladır ve bir araya geldiklerinde karmaşık yapılar oluştururlar. Bu parçaların nasıl bir araya gelerek sağlam C# uygulamalarının temelini oluşturduğunu inceleyelim.

Bu videoda, .NET geliştirmede yaygın olarak kullanılan C#’ın temel özelliklerini açıklayacağız.

---

## 🧩 Class’lar ve OOP’nin Temeli

C#’ta OOP’nin merkezinde, object oluşturmak için blueprint görevi gören  **class** ’lar vardır.

Bir class, ondan oluşturulan object’lerin sahip olacağı **özellikleri (attributes)** ve **davranışları (behaviors)** tanımlar. Bu özellikler ve davranışlar class’ın  **members** ’ları olarak adlandırılır ve birkaç farklı biçimde bulunur.

---

## 📦 Field ve Property

**Fields** ve  **properties** , C#’ta temel class member’larıdır.

* **Field** ’lar veriyi doğrudan saklar ve genellikle encapsulation sağlamak için private olur. Field’lar iç veri saklama için daha uygundur.
* **Property** ’ler ise güvenli dış erişim sağlar. Property’ler, bir class’ın verisini veya özelliklerini temsil eder ve çoğu zaman kontrollü erişim için field’ları sarar.

Örneğin bir `Car` class’ı; `Color`, `Model` ve `YearOfManufactured` gibi property’lere sahip olabilir.

Property’ler değerlerin nasıl alınıp değiştirildiğini yönetir. Bu, field değerleri get edilirken veya set edilirken doğrulama gibi ek mantık eklemeyi sağlar.

Property’ler ayrıca doğrudan bir field kullanmadan değer hesaplayabilir.

Property kullanmak veriyi korumaya yardımcı olur ve programın diğer bölümlerinin object’in bilgileriyle çalışmasını kolaylaştırır.

---

## 🛠️ Method’lar

 **Methods** , bir diğer temel class member türüdür.

Method’lar, object’lerin ve class’ların gerçekleştirebileceği eylemleri veya davranışları tanımlar. Method’lar, gerektiğinde çağrılabilen bir dizi talimatı gruplandırmanıza olanak tanır; böylece kodunuz daha modüler ve daha kolay sürdürülebilir olur.

C#’ta method’lar ikiye ayrılabilir: **static** ve **instance** method’lar.

* **Static method’lar** , class’ın kendisine aittir ve class’tan bir object oluşturulmadan çağrılabilir. Instance’a özgü veriye erişmeye ihtiyaç duymayan utility fonksiyonlar için uygundur.
* **Instance method’lar** ise class’ın belirli instance’larıyla ilişkilidir ve object’in verisine erişebilir ve onu manipüle edebilir.

Örneğin bir `Car` class’ının `getAvailableColors` gibi bir static method’u ve `StartEngine` veya `Accelerate` gibi instance method’ları olabilir.

`getAvailableColors` bir utility fonksiyonudur; herhangi bir car state’ine bağlı olmadığı için static method olmaya uygundur. `StartEngine` ve `Accelerate` ise tek tek car instance’larının yaptığı aksiyonlardır.

---

## 🧬 Inheritance ve Polymorphism

Farklı class’lar arasında method’ları yeniden kullanmak veya genişletmek istiyorsanız, **inheritance** ile işlevselliği paylaşabilir ve **polymorphism** ile davranışı özelleştirebilir ya da override edebilirsiniz.

---

## 🧬 Inheritance

 **Inheritance** , bir class’ın başka bir class’tan özellikler miras almasını sağlar. Bu, derived class’ın base class’ın property ve method’larını kullanabileceği ve gerektiğinde onları genişletebileceği veya değiştirebileceği anlamına gelir.

Bu, ortak işlevselliğin birden çok class arasında paylaşılmasını sağlayarak tekrarları azaltır ve class’lar arasında hiyerarşik bir ilişki kurar.

Örneğin `Vehicle` adlı bir base class düşünün; `Speed` gibi ortak property’lere ve `StartEngine` gibi method’lara sahip olabilir. `Car` gibi bir derived class bu property ve method’ları miras alır; ayrıca `WheelCountProperty` ve `OpenWindowMethod` gibi arabalara özgü yeni özellikler ekler.

Bu hiyerarşi, paylaşılan işlevselliğin base class’ta bir kez yazılmasını ve derived class’larda yeniden kullanılmasını sağlar; böylece kod daha düzenli ve daha kolay bakım yapılabilir olur.

---

## 🔀 Polymorphism

 **Polymorphism** , inheritance ile yakından ilişkili bir diğer temel kavramdır.

Polymorphism, method’ların “birden fazla biçim” almasını sağlar; yani bir method, onu çağıran object’e bağlı olarak farklı davranabilir.

Polymorphism, farklı türlerdeki object’lerin ortak bir base type’ın object’leri olarak ele alınmasını sağlar; bu genellikle base class’lar veya interface’ler üzerinden yapılır.

Bu yaklaşım, daha dinamik ve esnek kod yazmanıza yardımcı olur; hangi method’un çağrılacağı, object’in gerçek türüne bağlı olarak runtime’da belirlenir.

Bu kavramları temel alarak, C# polymorphism’i sağlamak için **abstract methods** ve **virtual methods** sunar.

---

## 🧩 Abstract Method ve Virtual Method

* **Abstract methods** , abstract class içinde tanımlanır ve diğer class’lar için bir template görevi görür. Abstract method’un bir gövdesi yoktur ve her derived class’ta override edilmesi gerekir; böylece her subclass kendi özel implementasyonunu sağlar.
* **Virtual methods** ise base class içinde bulunur; derived class override edebilir, ama base class içinde varsayılan bir implementasyon da vardır. Derived class isterse override eder; override etmek zorunda değildir.

Bu esneklik, method davranışının onu çağıran object türüne göre dinamik biçimde değişmesini sağlar.

---

## 🔐 Member Access Modifiers

Bir class içinde member tanımlarken, **member access modifiers** kavramını da anlamak önemlidir.

Bu anahtar kelimeler, class member’larının görünürlüğünü ve erişilebilirliğini belirler. En yaygın access modifier’lar  **public** , **private** ve  **protected** ’dır; ancak özel senaryolarda kullanılan başka modifier’lar da vardır.

* **public** üyeler, uygulamadaki herhangi bir kod tarafından erişilebilir.
* **private** üyeler, yalnızca tanımlandıkları class içinde erişilebilir.
* **protected** üyeler, class içinde ve derived class’lar tarafından erişilebilir.

Doğru access modifier’ı seçmek kritiktir. Programınızın bölümlerinin nasıl birlikte çalışacağını kontrol etmeye ve gerektiğinde önemli bilgileri gizli tutmaya yardımcı olur.

---

## 🚗 Vehicle–Car Örneği ve Erişim Seviyeleri

`Car` class’ının `Vehicle` base class’ından türediği örneğe tekrar bakalım.

Vehicle class’ında üç member olduğunu varsayalım: private bir `speed` property’si, bu private `speed` değerini değiştirebilen public bir `set speed` method’u ve protected bir `start engine` method’u.

Bu üyelerin neden belirli modifier’lara sahip olduğuna fazla anlam yüklemeyin. Bu, araçlar hakkında bir “mutlak doğru”dan ziyade kodumuzda bu işlevselliği nasıl uyguladığımızla ilgilidir.

Bu üyelerden bazılarına vehicle class içinde erişilebilir, bazılarına car class içinde erişilebilir ve bazılarına ise class hiyerarşisinin dışındaki koddan erişilebilir.

* `vehicle set speed` method’u, vehicle class içinden, car class içinden veya programımızdaki başka herhangi bir koddan çağrılabilir.
* `start engine` method’u protected olduğu için, vehicle class içinden veya car class içinden çağrılabilir; ama kodun başka bir yerinden çağrılamaz.
* private `speed` property’si ise yalnızca vehicle class tanımı içinden çağrılabilir. Car class içinden veya kodun geri kalanından set etmeye ya da get etmeye çalışırsak çalışmaz.

---

## ✅ Özet

Özetle, C#’ta nesne yönelimli programlamada ustalaşmak; class’ları, member’ları ve interface’leri etkili biçimde nasıl tanımlayıp kullanacağınızı anlamayı gerektirir.

Bu kavramları, member access modifier’larla birlikte kavradığınızda; iyi organize edilmiş, sürdürülebilir, sağlam ve ölçeklenebilir uygulamalar oluşturabilirsiniz.
