## 🧩 Tasarım Desenlerini Tanıma

### 🎯 Amaç

Nesne yönelimli programlamada yaygın tasarım desenlerini tanımak ve açıklamak.

---

## 📝 Açıklama

Bu etkinlik, katılımcıların  *Singleton* ,  *Factory* , *Adapter* ve *Observer* gibi yaygın tasarım desenlerini belirlemesi gereken kod örnekleri sunar. Örnekler, bu desenlerin yazılım tasarımında belirli problemleri nasıl çözdüğünü gösterecektir. Örneklerden sonra, öğrenciler ek kod parçacıklarını analiz ederek kullanılan desenleri tanıyacaktır.

---

## 🧱 Örnek 1: Singleton Deseni

### 💻 Kod Örneği

Aşağıdaki kod, bir sınıfın yalnızca tek bir örneğe sahip olmasını sağlar ve global bir erişim noktası sunar.

```csharp
public class Database
{
    private static Database instance;
    private static readonly object lockObject = new object();

    // Private constructor prevents instantiation from other classes
    private Database() { }

    public static Database GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Database();
                }
            }
        }
        return instance;
    }

    public void Connect()
    {
        Console.WriteLine("Database connected.");
    }
}

public class Program
{
    public static void Main()
    {
        Database db1 = Database.GetInstance();
        Database db2 = Database.GetInstance();

        db1.Connect();
        Console.WriteLine(object.ReferenceEquals(db1, db2)); // Outputs: True
    }
}
```

### ✅ Deseni Belirle

**Desen:** Singleton

**Açıklama:** Singleton deseni, bir sınıfın örneklenmesini tek bir “tekil” ( *single* ) örnek ile sınırlar ve bu örneğe global erişim noktası sağlar.

**Açıklama Detayları:**

*Database* sınıfı, birden fazla örnek oluşturulmasını engellemek için *private static instance* değişkeni ve *private constructor* içerir.

*GetInstance()* metodu, *double-check locking* mekanizmasını kullanarak yalnızca tek bir *Database* örneği oluşturulmasını sağlar.

Bu desen, yalnızca tek bir örneğin var olması gereken paylaşılan kaynakları (ör. veritabanı bağlantıları) yönetmek için kullanışlıdır.

---

## 🔌 Örnek 2: Adapter Deseni

### 💻 Kod Örneği

Bu kod, bir sınıfın arayüzünü, istemcilerin beklediği başka bir arayüze dönüştürmeyi gösterir.

```csharp
// Target interface
public interface ITarget
{
    void Request();
}

// Adaptee class
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request is called.");
    }
}

// Adapter class
public class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        // Convert the interface of Adaptee to the Target interface
        adaptee.SpecificRequest();
    }
}

public class Program
{
    public static void Main()
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        target.Request(); // Outputs: Specific request is called.
    }
}
```

### ✅ Deseni Belirle

**Desen:** Adapter

**Açıklama:** Adapter deseni, uyumsuz arayüzlerin birlikte çalışmasına olanak tanır; mevcut bir sınıfı yeni bir arayüzle sararak ( *wrapping* ) köprü görevi görür.

**Açıklama Detayları:**

*Adapter* sınıfı, *ITarget* interface’ini uygular ve *Adaptee* sınıfının bir örneğini içerir.

*Request()* metodu, gelen çağrıları *Adaptee* içindeki *SpecificRequest()* metoduna dönüştürür.

Bu desen, beklenen arayüzle uyuşmayan üçüncü parti kütüphaneleri entegre ederken kullanışlıdır.

---

# 🧪 Problem 1

## 💻 Kod Örneği

Aşağıdaki kodda kullanılan tasarım desenini belirleyin:

```csharp
public abstract class Animal
{
    public abstract void Speak();
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

public class AnimalFactory
{
    public static Animal CreateAnimal(string type)
    {
        if (type == "Dog")
        {
            return new Dog();
        }
        else if (type == "Cat")
        {
            return new Cat();
        }
        else
        {
            throw new ArgumentException("Invalid animal type");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Animal dog = AnimalFactory.CreateAnimal("Dog");
        dog.Speak(); // Outputs: Woof!

        Animal cat = AnimalFactory.CreateAnimal("Cat");
        cat.Speak(); // Outputs: Meow!
    }
}
```

## ✅ Talimatlar

### 🏭 Deseni Belirle

**Desen:** Factory (Factory Method yaklaşımı)

### 🧠 Bu Desen Problemi Nasıl Çözer?

Bu desen, nesne oluşturma ( *object creation* ) mantığını, nesneyi kullanan koddan ayırır.

Program, *Dog* veya *Cat* nesnesini doğrudan `new Dog()` ya da `new Cat()` ile oluşturmak yerine, `AnimalFactory.CreateAnimal(...)` metodunu çağırır.

Bu, kodun daha esnek olmasını sağlar; çünkü yeni bir hayvan türü eklendiğinde, yalnızca Factory güncellenir ve nesneleri kullanan ana program kodu değiştirilmek zorunda kalmaz.

---

# 🧪 Problem 2

## 💻 Kod Örneği

Aşağıdaki kodda kullanılan tasarım desenini belirleyin:

```csharp
public interface IObserver
{
    void Update(string message);
}

public class ConcreteObserver : IObserver
{
    private string name;

    public ConcreteObserver(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} received message: {message}");
    }
}

public class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Subject subject = new Subject();

        IObserver observer1 = new ConcreteObserver("Observer 1");
        IObserver observer2 = new ConcreteObserver("Observer 2");

        subject.Attach(observer1);
        subject.Attach(observer2);

        subject.Notify("Hello, Observers!"); // Outputs: "Observer 1 received message: Hello, Observers!"
                                            //          "Observer 2 received message: Hello, Observers!"
    }
}
```

## ✅ Talimatlar

### 👀 Deseni Belirle

**Desen:** Observer

### 🌍 Gerçek Dünya Senaryolarında Neden Kullanışlıdır?

Observer deseni, bir nesnenin ( *Subject* ) durumundaki değişiklikleri, kendisine abone olan ( *Observers* ) birden fazla nesneye otomatik olarak iletmesini sağlar.

Bu, özellikle olay tabanlı ( *event-driven* ) sistemlerde çok kullanışlıdır; örneğin:

* UI bileşenlerinin, veri değiştiğinde otomatik güncellenmesi
* Bildirim sistemleri (push notifications)
* Pub/Sub mimarileri
* Sensör verileri değiştiğinde birden fazla servisin tetiklenmesi

Bu sayede sistem, sıkı bağlı ( *tightly coupled* ) olmadan genişletilebilir ve yeni gözlemciler eklenip çıkarılabilir.
