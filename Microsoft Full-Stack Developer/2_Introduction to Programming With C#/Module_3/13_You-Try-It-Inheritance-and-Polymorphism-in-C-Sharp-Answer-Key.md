## 🗝️ You Try It! C#’ta Kalıtım ve Çok Biçimlilik - Cevap Anahtarı

---

## 🐾 Adım 2: Taban Sınıf ve Türetilmiş Sınıflar Oluşturma

```csharp
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
```

---

## 🧠 Adım 3: Virtual ve Override Anahtar Sözcüklerini Kullanma

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();
      
        myDog.MakeSound(); // Should print "Bark"
        myCat.MakeSound(); // Should print "Meow"
    }
}
```

---

## 🧾 Adım 4: Interface’leri Uygulama

```csharp
public interface IAnimal
{
    void Eat();
}

public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }

    public void Eat()
    {
        Console.WriteLine("Some generic animal food");
    }
}

public class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Kibble");
    }

    public override void MakeSound(){
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public void Eat()
    {
        Console.WriteLine("Tuna");
    }

    public override void MakeSound(){
        Console.WriteLine("Meow");
    }
}
```

---

## 🍽️ Adım 5: Interface’i Kullanma

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();
      
        myDog.MakeSound(); // Should print "Bark"
        myCat.MakeSound(); // Should print "Meow"

        myDog.Eat(); // Should print "Kibble"
        myCat.Eat(); // Should print "Tuna"

    }
}
```

---

## 🧩 Adım 6: Taban Tür ve Interface Listeleri ile Çok Biçimlilik

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}
```
