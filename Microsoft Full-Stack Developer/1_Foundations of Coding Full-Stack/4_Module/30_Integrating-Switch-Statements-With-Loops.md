## 🔁 Döngülerle *If-Else* Entegrasyonu

Bir çözüme ulaşmak için çeşitli seçenekleri sıralamanız gereken zorlu bir bulmacayla karşılaştığınızı hayal edin. Şimdi buna, birbirine bağlı birden fazla seçim katmanında gezinme karmaşıklığını ekleyin. Kulağa zor geliyor, değil mi? İşte burada *if-else* ifadelerini döngülerle birleştirmenin gücü devreye girer. Bu, karmaşık programlama zorlukları üzerinde başarılı şekilde çalışmanızı sağlayan güçlü bir araca sahip olmak gibidir.

Bu videoda, *if-else* ifadelerini döngüler ve kodlama alıştırmalarıyla birleştireceğiz. *If-else* ifadelerini döngülerle birleştirmenin verimli bir çözüm sağladığı birkaç programlama senaryosunu inceleyelim.

---

## ✅ Örnek 1: Kullanıcı Girdisini Doğrulama

İlk örneğimizde kullanıcı girdisini doğrulayacağız. Diyelim ki bir uygulamada kullanıcının girdiği bir sayıyı doğrulamamız gerekiyor. Bir döngüyü *if-else* ifadesiyle birlikte kullanacağız.

Döngü, kullanıcıdan bir sayı girmesini isteyecek ve *if-else* yapısı sayının bir ile on arasında olup olmadığını kontrol edecek. Koşul sağlanana kadar döngü kullanıcıdan girdi istemeye devam edecektir.

Bunu **C#** ile bir örnek üzerinden parçalayalım.

Öncelikle, kullanıcının konsoldan girdiği sayıyı saklamak için `input` adlı bir tamsayı değişkeni tanımlarız.

Bu örnek için bir *do while* döngüsü kullanacağız. Bu döngü, belirli bir koşul sağlanana kadar süslü parantezlerin içindeki kod bloğunu tekrar tekrar çalıştırır. Döngü koşulu, kullanıcının bir tahmin girmesi gibi kullanıcı tarafından yapılan bir eyleme bağlı olduğundan, koşulu önceden kontrol edemeyiz. Bu yüzden *do while* döngüsü kullanırız.

Diğer döngülerden farklı olarak *do while* döngüsü, koşuldan bağımsız olarak içindeki kodun her zaman en az bir kez çalışmasını garanti eder.

Ardından kullanıcıdan bir ile on arasında bir sayı girmesini istemek için `Console.Writeline` kullanırız. Kullanıcının girdisini okumak için `Console.Readline` kullanırız ve sonra girdiyi string’den tamsayıya dönüştürmek için `int.Parse` kullanırız; bu değer `input` değişkeninde saklanır.

Girdiyi bir *if-else* ifadesiyle doğrularız. *If-else* ifadesi, kullanıcının bir ile on arasında bir sayı girip girmediğini kontrol eder. Girdi bir ile on arasında değilse, bu durumu bir *else* ifadesiyle ele alırız.

*Else* bloğunun gövdesi, kullanıcıdan tekrar denemesini isteyen bir hata mesajını `Console.Writeline` ile görüntüler.

Kullanıcı bir ile on arasında bir sayı girdiğinde, `Console.Writeline` kullanarak girdinin geçerli olduğunu belirten bir mesajı ve `input` değişkeninde saklanan kullanıcının girdiği sayıyı görüntüleriz. Bundan sonra, kullanıcı geçerli bir girdi sağladığı ve döngü artık gerekli olmadığı için *do while* döngüsünden çıkmak amacıyla `break` ifadesini ekleriz.

`while` ifadesi, döngünün ne zaman çıkacağını belirleyen bir koşul ayarlar.

Örneğin `input` değeri beşe eşit olduğunda çıkılacak bir koşul belirleyebiliriz. Bu koşulda, kullanıcı 5 girdiğinde döngü sona erer. Ancak koşul olarak `true` kullanarak, `true` her zaman doğru olduğu için döngünün belirsiz süre devam etmesini açıkça belirtmiş oluruz.

Bu, yalnızca kullanıcı bir ile on arasında bir sayı girdikten sonra `break` ifadesine ulaşıldığında duracak olan sonsuz bir döngü oluşturur.

---

## 🎓 Örnek 2: Öğrenci Notlarını Gezip Geçti/Kaldı Belirleme

Şimdi, **C#** ile gerçek dünyadan bir örneği inceleyelim: bir *for* döngüsü kullanarak öğrenci notları listesinin üzerinden geçeceğiz. Ardından her notun geçer mi kalır mı olduğunu belirlemek için bir *if-else* ifadesi kullanacağız.

Önce öğrenci notları listesini saklamak için bir dizi oluştururuz. Bu, `grades` adlı sabit bir tamsayı dizisi olacaktır.

Sonra `grades` dizimizdeki her eleman üzerinde yineleme yapmak için bir *for* döngüsü ekleriz. Her yinelemede, dizideki mevcut öğe `grade` değişkenine atanır.

Şimdi `result` adlı bir string değişkeni tanımlarız. Bu değişken, her yinelemede `grade` değerine bağlı olarak *if-else* ifademizde **pass** veya **fail** olacaktır.

Ardından öğrencinin geçip geçmediğini doğrulamak için bir *if-else* ifadesi kullanırız. `grade` değeri 65’e eşit veya büyükse, `result` değişkeninin değeri **pass** olur.

Aksi halde not 65’in altında olacaktır ve `result` değişkeninin değeri **fail** olur.

Son olarak `result` değişkeninin değerini görüntülemek için `Console.writeLine(result)` kodunu kullanırız.

Bu kodu çalıştırdığınızda, ilk üç not 65’ten büyük olduğu için kod **pass** yazdırır. Döngü dizideki 64 değerine geldiğinde, 64 65’ten küçük olduğu için kod **fail** yazdırır. Kod dizideki son değere, yani 89’a ulaştığında ise **pass** yazdırır.

---

## ✅ Kapanış

Bu videoda, programlama senaryolarını kullanarak *if-else* ifadelerini döngülerle nasıl birleştireceğinizi öğrendiniz. Bu kavramlarda ustalaşmak, daha karmaşık programlama zorluklarını üstlenirken size yardımcı olacaktır.
