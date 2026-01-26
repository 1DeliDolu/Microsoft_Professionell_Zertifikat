## 🧱 Kontrol Yapılarının Temelleri

## 🎛️ Kontrol Yapılarına Giriş

*If-else* ifadeleri ve *switch* durumları gibi kontrol yapıları, programlamada hayati araçlardır. Geliştiricilerin kodları içinde karar vermesini sağlarlar. Bu yapılar, yürütme akışını belirli koşullara göre kontrol ederek programları daha dinamik ve daha duyarlı hâle getirir. Bu okuma, *if-else* ifadeleri ve *switch* durumlarının amacını, sözdizimini ve pratik uygulamalarını inceleyerek onları etkili biçimde nasıl kullanacağınızı anlamanıza yardımcı olur.

## ✅ If-Else İfadelerinin Amacı

Bir *if-else* ifadesi, bir programın belirli bir koşulun doğru ( *true* ) mu yoksa yanlış ( *false* ) mı olduğuna karar vermesini sağlayan koşullu bir yapıdır. Koşul sağlandığında (doğru), program bir kod bloğunu yürütür; sağlanmadığında (yanlış), alternatif bir bloğu yürütür. Bu yapı, ikili bir seçim yapılması gereken senaryolar için gereklidir.

## 🧪 Örnek Kullanım Senaryosu

Bir kullanıcının bir web sitesinin kısıtlı bir bölümüne erişmek için yeterince büyük olup olmadığını kontrol eden bir program yazdığınızı hayal edin. Program, kullanıcının yaşına bağlı olarak erişim izni verebilir veya reddedebilir. Kullanıcı 18 yaşında veya daha büyükse erişim verilir; aksi hâlde erişim reddedilir.

## 🧾 If-Else İfadelerinin Sözdizimi

C#’ta bir *if-else* ifadesinin sözdizimi şu şekildedir:

```csharp
if (condition) {
    // Code to execute if the condition is true
} else {
    // Code to execute if the condition is false

}
```

Örneğin:

```csharp
int age = 18;
if (age >= 18) {
    Console.WriteLine("Access granted.");
} else {
    Console.WriteLine("Access denied.");
}
```

Bu örnekte program, `age` değişkeninin 18 veya daha büyük olup olmadığını kontrol eder. Öyleyse `"Access granted."` yazdırır. Değilse `"Access denied."` yazdırır. Bu yaklaşım, tek bir koşula dayalı karar vermeyi yönetmek için basit bir yol sunar.

## 🔀 Switch Durumlarının Amacı

*If-else* ifadeleri ikili kararlar için etkili olsa da, *switch* durumları birden fazla koşulu ele almak için daha düzenli ve daha okunabilir bir yol sunar. Bir *switch* ifadesi bir değişkeni değerlendirir ve değerine bağlı olarak farklı eylemler yürütür. Bu, özellikle birkaç olası sonuç olduğunda faydalıdır.

## 🧪 Örnek Kullanım Senaryosu

Kullanıcının bastığı düğmeye göre farklı içecekler veren bir otomat programı düşünün. Birden fazla *if-else* ifadesi kullanmak yerine, bir *switch* durumu her düğmenin eylemini daha verimli biçimde yönetebilir.

## 🧾 Switch Durumlarının Sözdizimi

C#’ta bir *switch* durumunun sözdizimi şu şekildedir:

```csharp
switch (variable) {
    case value1:
        // Code to execute if variable == value1
        break;
    case value2:
        // Code to execute if variable == value2
        break;
    default:
        // Code to execute if variable matches none of the cases
        break;
}
```

Örneğin:

```csharp
string button = "Water";
switch (button) {
    case "Water":
        Console.WriteLine("Dispensing water");
        break;
    case "Soda":
        Console.WriteLine("Dispensing soda");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}
```

Bu örnekte program, `button` değişkeninin değerini kontrol eder. Değer `"Water"` ile eşleşirse `"Dispensing water"` yazdırır. `"Soda"` ile eşleşirse `"Dispensing soda"` yazdırır. Değer herhangi bir *case* ile eşleşmezse *default case* yürütülür ve `"Invalid option"` yazdırılır. Bu yapı, birden fazla *if-else* ifadesi kullanmaya kıyasla kodu daha okunabilir ve daha düzenli hâle getirir.

## 🧩 Problemleri Çözmek için If-Else İfadeleri ve Switch Durumlarını Uygulama

## 🎯 İkili Kararlar için If-Else İfadelerini Kullanma

*If-else* ifadeleri, yalnızca iki olası sonucun bulunduğu senaryolar için en uygundur. Örneğin, bir program bir öğrencinin notunun geçme barajının üstünde mi altında mı olduğunu kontrol edebilir. Bir öğrencinin geçip geçmediğini belirlemek ve yazdırmak için bir *if-else* ifadesi şu şekilde kullanılabilir:

```csharp
int grade = 55;
if (grade >= 50) {
    Console.WriteLine("Passed");
} else {
    Console.WriteLine("Failed");
}
```

Bu kodda program, `grade` değişkeninin 50 veya daha yüksek olup olmadığını değerlendirir. Öyleyse `"Passed"` yazdırılır; aksi hâlde `"Failed"` yazdırılır. Bu yaklaşım, tek bir koşula bağlı kararları yönetmek için doğrudan bir yöntem sunar.

## 🧠 Birden Fazla Koşul için Switch Durumlarını Kullanma

*Switch* durumları, bir değişkenin birkaç olası değere sahip olduğu ve her değerin farklı bir yanıt gerektirdiği durumları ele almak için idealdir. Örneğin, bir öğrencinin puanına göre harf notu atayan bir notlandırma sisteminde *switch* durumu karar verme sürecini basitleştirir:

```csharp
int score = 85;
switch (score / 10) {
    case 10:
    case 9:
        Console.WriteLine("A");
        break;
    case 8:
        Console.WriteLine("B");
        break;
    case 7:
        Console.WriteLine("C");
        break;
    default:
        Console.WriteLine("F");
        break;
}
```

Burada program, `score` değerinin 10’a bölünmesiyle elde edilen sonucu değerlendirir. Bu, puanın hangi aralığa düştüğünü belirlemeye yardımcı olur ve `"A"` ile `"F"` arasında uygun notu atar. `break` ifadelerinin kullanımı, doğru *case* eşleştikten sonra başka  *case* ’lerin kontrol edilmemesini sağlar. Bu yöntem verimli ve nettir; birden fazla olası sonucu yönetmeyi kolaylaştırır.

## ✅ Sonuç

*If-else* ifadeleri ve *switch* durumları, koşullara bağlı olarak program akışını kontrol etmek için temel araçlardır. *If-else* ifadeleri, doğru ya da yanlış koşullarına göre kod bloklarını çalıştırmanın basit bir yolunu sunarak ikili kararlar için idealdir. *Switch* durumları ise birden çok olası değeri yönetmek için güçlüdür; açıklık ve verimlilik sağlar. Bu kontrol yapılarını ustalıkla kullanarak geliştiriciler problem çözme becerilerini geliştirebilir ve daha etkili, daha okunabilir kod yazabilir.
