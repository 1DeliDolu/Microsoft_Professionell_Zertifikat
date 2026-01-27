## 🧪 Kalıtım ve Çok Biçimliliğin Pratik Uygulanması

### 🧩 Giriş

Bu okuma, C# programlamada kalıtım ve çok biçimliliği uygulamak için kısa bir rehber sunar. Taban ve türetilmiş sınıflar oluşturmayı ve metot geçersiz kılma ( *method overriding* ) ile interface’leri uygulamayı hedefler.

---

## 🧬 C#’ta Kalıtım

### 🧱 Taban Sınıf Tanımla

Bir erişim belirleyicisi kullanın ( *public* ,  *private* ,  *protected* ).

*class* anahtar sözcüğünü sınıf adıyla birlikte kullanın.

Veriyi tutmak için özellikleri ( *properties* ) ve eylemleri tanımlamak için metotları ( *methods* ) tanımlayın.

Örnek:

```csharp
public class Pool
{
    public int chlorineLevel;
    public int waterLevel;
    public Pool(int chlorine, int water)
    {
        chlorineLevel = chlorine;
        waterLevel = water;
    }
    public void PoolInfo()
    {
        Console.WriteLine($"Pool: {chlorineLevel}, {waterLevel}");
    }
}
```

---

### 🏗️ Türetilmiş Sınıf Oluştur

Bir taban sınıf gibi bildirin; ancak taban sınıf adından önce iki nokta üst üste ( *:* ) ve taban sınıf adını ekleyin.

Türetilmiş sınıf, taban sınıftan özellikleri ve metotları miras alır.

Örnek:

```csharp
public class Spa : Pool

{
    public int heatLevel;
    public Spa(int chlorine, int water, int heat)
        : base(chlorine, water)
    {
        heatLevel = heat;
    }
    public void SpaInfo()
    {
        Console.WriteLine($"Spa: {chlorineLevel}, {waterLevel}, {heatLevel}");
    }
}
```

---

## 🧩 C#’ta Çok Biçimlilik

### 🛠️ Metot Geçersiz Kılma

Geçersiz kılınabilen metotları bildirmek için taban sınıfta *virtual* anahtar sözcüğünü kullanın.

Türetilmiş sınıfta, belirli bir uygulama sağlamak için *override* anahtar sözcüğünü kullanın.

Örnek:

```csharp
public class Instrument
{
    public virtual void Play()
    {
        Console.WriteLine("Playing an instrument");
    }
}


public class Piano : Instrument
{
    public override void Play()
    {
        Console.WriteLine("The piano is playing");
    }
}
```

---

### 🧾 Interface Kullanımı

Türetilmiş sınıfların uygulamak zorunda olduğu metot imzalarını ( *method signatures* ) içeren bir interface tanımlayın.

Interface’i türetilmiş sınıflarda uygulayın ( *implement* ).

Örnek:

```csharp
public interface IPlayable

{
    void Play();
}


public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("The guitar is playing");
    }
}
```

---

## ✅ Sonuç

Yeniden kullanılabilir taban sınıflar oluşturmak ve işlevselliklerini türetilmiş sınıflarla genişletmek için kalıtımı kullanın.

Farklı sınıflar arasında metot uygulamalarında esneklik sağlamak için ise, metot geçersiz kılma ve interface’ler yoluyla çok biçimliliği kullanın.
