## 🍦 If-Else İfadelerine Giriş

Dondurmayı severim, severim, ama sevmediğim bir tat var ve o da çilek. Bu yüzden dondurma seçerken şartlarımdan biri çilek olmamasıdır. Çilek olmadığı sürece, başka herhangi bir dondurma tadını keyifle yiyebilirim.

Bir program yazdığınızı hayal edin ve bu program benim dondurma sipariş etmeme yardımcı olsun. Bunu yapmak için bir *if-else* ifadesi kullanabiliriz. Dondurma tadı çilek **DEĞİLSE** diğer her şeyi seçebilirim. Bu videoda, *if-else* ifadelerinin amacını ve sözdizimini açıklayacağız.

## 🧾 If-Else İfadesi Nedir?

Önce bir *if-else* ifadesinin ne olduğunu tanımlayarak başlayalım.

*If-else* ifadesi, bir koşulun doğru ( *true* ) ya da yanlış ( *false* ) olmasına bağlı olarak programın farklı eylemler gerçekleştirmesine olanak tanıyan koşullu bir yapıdır. *If-else* ifadeleri olmadan kodunuz, onu yönlendirecek herhangi bir koşul olmaksızın düz bir çizgi üzerinde çalışırdı.

Bir *if-else* ifadesini yol ayrımı gibi düşünebilirsiniz. Bir koşulun sağlanıp sağlanmamasına bağlı olarak kodunuzun bir yoldan ya da diğerinden devam etmesini sağlar. Koşul sağlanırsa sola gidersiniz, aksi hâlde sağa gidersiniz.

## 🧩 Sözde Kod ile Örnek

*If-else* ifadelerinin nasıl çalıştığını sözde kod ( *pseudocode* ) kullanan bir örnekle gösterelim.

Bir *if-else* ifadesini kullanmaya örnek olarak, belirli bir yaşın altındaki kullanıcılar için erişimi kontrol etmeyi verebiliriz; 18 yaşını kullanalım. Önce `"age"` adlı bir değişken tanımlarız ve veri türünü tamsayı ( *integer* ) olarak ayarlarız.

Sözde kod kullanarak, *if-else* ifadesi şu şekilde çalışır: önce kullanıcıdan yaşını girmesini isteriz. Yaş 18’den büyük ya da 18’e eşitse program `"Access Granted"` yazdırır. Aksi takdirde, yani `"else"` durumunda, kullanıcının yaşı 18’den küçük olduğu için web sitesine erişmesine izin verilmez ve program `"Access Denied."` yazdırır.

Şimdi aynı örnek üzerinde çalışalım, ancak bu kez C# kullanarak. Adım adım ilerleyeceğiz.

## 💻 C# ile Adım Adım Uygulama

Önce `age` değişkenini `"int age"` olarak tanımlayalım. `age` değişkeni, kullanıcının girdiği değeri tutar ve *if-else* ifademiz bu değeri kontrol eder.

Kullanıcının yaşını konsoldan almanız gerekir. Konsol, komutları girebileceğiniz ve çıktıları okuyabileceğiniz bir arayüzdür.

Kullanıcıdan yaşını girmesini istemek için `Console.Writeline` kullanır ve kullanıcıya gösterilecek istem metnini parantez içine yazarız. İstemimiz iki nokta üst üste ile birlikte `"Enter your age"` olacaktır. Kod, kullanıcıdan yaşını girmesini ister ve bu değeri `"age"` değişkeninde saklar.

## 🔢 Girdiyi Integer’a Dönüştürme

Sonraki adımda, kullanıcının girdisini `age` değişkenine atarız. Konsoldan alınan girdiler her zaman *string* formatındadır, bu nedenle `age` değişkeninin türüyle eşleşmesi için girdiyi tamsayıya dönüştürmemiz gerekir.

Bunu `int parse` kullanarak yapabiliriz; bu, *string* girdiyi tamsayıya dönüştürür. Bunu yapmak için şu kod satırını yazarız:

```csharp
int age = int.Parse(Console.ReadLine());
```

`if` anahtar sözcüğü, ardından parantez içinde bir koşul ile başlar. Bu koşul, `age` değerinin 18’den büyük ya da 18’e eşit olup olmadığını kontrol eder. Koşul doğruysa, süslü parantezlerin içindeki kod çalışır ve konsola `'Access granted'` yazdırır.

## 🔀 Else Bloğu

`else` anahtar sözcüğü, `if` bloğunun kapanış süslü parantezinden sonra gelir. Koşul yanlışsa çalıştırılacak alternatif bir kod bloğunu belirtir. Koşul yanlışsa, `else` bloğunun içindeki kod çalıştırılır ve konsola `"Access Denied"` yazdırılır.

## ✅ Video Özeti

Bu videoda, C#’ta *if-else* ifadelerinin amacını ve sözdizimini öğrendiniz. *If-else* ifadeleri, geliştiricilerin değişken koşullara ve kullanıcı girdilerine bağlı olarak karar vermesini ve programlarının akışını kontrol etmesini sağlar.

*If-else* ifadelerinde ustalaşmak, geliştirici olma yolculuğunuzun önemli bir parçasıdır.
