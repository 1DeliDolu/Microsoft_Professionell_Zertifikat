## 🔄 While Loops

 *For döngüleri* , tekrarlayan görevler için kod yazmanız gerektiğinde ve kaç tekrar (loop) gerektiğini zaten bildiğinizde işe yarar. Peki ya kaç tekrar gerektiğini bilmiyorsanız? Ya bir koşul doğru kaldığı sürece görevlerin tekrar edilmesi gerekiyorsa? Bu, *while döngülerinin* işidir.

Bu videoda, while döngülerinin amacını ve sözdizimini (syntax) açıklayacağız.

 *While döngüsü* , bir koşula bağlı olarak kodun tekrar tekrar çalıştırılmasına izin veren bir kontrol akışı (control flow) ifadesidir. Her yinelemeden (iteration) önce koşulu kontrol eder ve koşul doğru olduğu sürece döngüyü çalıştırır.

---

## 🎯 While Loops’un Amacı

Programlamada while döngülerinin amacı, kaç döngü gerekeceğini bilmediğiniz durumlarda tekrarlanan eylemleri yönetmeyi mümkün kılmaktır. Tanımlı bir tekrar sayısına göre çalışmak yerine koşulları sürekli izleyerek çalışırlar.

While döngülerini daha iyi anlamak için onları for döngüleriyle karşılaştıralım.

---

## 🏀 For Loop vs While Loop Örneği

Örneğin, basketbol şutunuzu çalıştığınızı ve antrenmanınızın sonuna yaklaştığınızı hayal edin. Antrenmanı bitirmek için 10 şut daha atmaya karar verirsiniz ve sonra antrenmanı bitirirsiniz.

Bu, bir *for döngüsü* gibidir. Her şut bir döngüdür; döngüyü 10 kez (10 şut) yaparsınız ve sonra biter.

Bu sefer, 10 şut atmak yerine, tek bir şutu sayıya soktuğunuz anda antrenmanın biteceğine karar veriyorsunuz. Bir şut atarsınız; eğer sokarsanız antrenman biter. Ya da birini sokana kadar 20 şut atmanız gerekebilir ve sonra antrenman biter.

Bu, bir *while döngüsü* gibidir. Antrenmanı bitirmek için kaç şut (kaç döngü) gerekeceğini bilmiyorsunuz.

---

## 🧩 While Loop Yapısı ve C# Sözdizimi

Artık while döngüsünün ne olduğunu ve for döngüsünden nasıl farklılaştığını anladığınıza göre, C# kullanarak birkaç örnek üzerinden yapısını ve sözdizimini inceleyelim.

C#’ta while döngüsünün sözdizimi ve yapısı, `while` anahtar sözcüğü, ardından bir koşul ve çalıştırılacak kod bloğundan oluşur.

Koşul doğru olduğu sürece döngü kod bloğunu çalıştırır.

---

## 🔢 Örnek 1: Sayaç ile While Loop

Şimdi, basit bir while döngüsü örneğiyle bunu koda dökelim.

Bu örnekte `"counter"` adlı bir değişken tanımlarız; bu değişken tamsayı (integer) veri tipindedir ve sıfıra eşitlenir.

Ardından `while` anahtar sözcüğünü kullanarak, `"counter"` değişkeninin 10’dan küçük olması koşuluyla while döngüsünü kurarız.

Bu koşul sağlanırsa yapılacak işlem:

* `"Console.WriteLine(counter)"` ile sayaç değerini yazdırmak
* `"counter++"` ile sayacı 1 artırmak

Bu, `"counter"` değişkeninin 0’dan başladığı ve 10’dan küçük olduğu sürece mevcut değerini konsola yazdıracağı, 1 artıracağı ve koşulu yeniden kontrol edeceği anlamına gelir.

Bu süreç, 0’dan 9’a kadar her sayıyı yazdırarak devam eder ve 9 yazdırıldıktan sonra döngü biter; çünkü 9, 10’dan küçük olan son tamsayıdır.

---

## ⌨️ Örnek 2: Kullanıcı “exit” Yazana Kadar Girdi Okuma

While döngülerinin tipik bir diğer örneği, kullanıcı belirli bir komutu girene kadar kullanıcı girdisini okumaktır.

Önce `input` adlı bir string değişken tanımlarız ve bunu iki tırnakla boş bir string olarak başlatırız. Bu, döngünün başlangıç koşulunu kurar.

Sonra while döngüsünü ekleriz; `input` değişkeni `"exit"` değerinden farklı olduğu sürece döngü çalışır. Bunun için `"!="` operatörünü kullanırız.

Bu, kullanıcının `"exit"` kelimesini girene kadar döngünün devam edeceği anlamına gelir.

Döngünün içinde:

* `"Console.WriteLine("Enter a command:")"` satırı kullanıcıdan komut girmesini ister.
* `"Console.Writeline();"` satırı kullanıcının yazdığı şeyi yakalar ve `input` değişkeninde saklar.

Girdi alındıktan sonra döngü koşulu tekrar kontrol edilir: Eğer `input`, `"exit"` değerine eşit değilse döngü tekrar eder ve kullanıcıdan yeni bir komut ister.

Eğer kullanıcı `"exit"` yazarsa, koşul yanlış olur ve döngü durur.

---

## ✅ Video Özeti

Bu videoda, while döngülerinin amacını ve sözdizimini açıklamayı öğrendiniz; yinelemeli (iterative) süreçlerdeki rollerini incelediniz ve for döngülerinden nasıl farklılaştıklarını vurguladınız.

Kod örnekleri aracılığıyla, while döngülerinin belirli bir koşul sağlanana kadar tekrar eden kontroller gerektiren görevleri verimli şekilde yönettiğini gösterdik.
