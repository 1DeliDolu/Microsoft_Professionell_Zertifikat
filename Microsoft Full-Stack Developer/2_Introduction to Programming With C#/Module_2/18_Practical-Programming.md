## 🧪 Pratik Programlama

Programlamayı anlamanın en etkili yollarından biri, kod yazmak ve çalıştırmaktır. Bu derste, basit programlar oluşturmaya dalarken C#’ın nasıl bir araya geldiğini göreceksiniz. Kendi C# kodunuzu yazıp çalıştırmak için gerekli temel adımları ele alacağız; böylece programlama dünyasındaki yolculuğunuza devam ederken üzerine inşa edebileceğiniz sağlam bir temel elde edeceksiniz.

Haydi başlayalım ve bu kavramların pratikte nasıl hayat bulduğunu görelim.

Bu videoda, basit C# programları yazıp çalıştıracağız. Öğrendiğimiz kavramları uygulamak için basit C# programları yazacak ve çalıştıracağız. Bu programlar; temel bir hesap makinesi, sayıları görüntülemek için bir döngü ve kullanıcı girdisini işleyen bir metot içerir.

---

## 🧮 Temel Hesap Makinesi

Basit bir şeyle başlayalım: temel bir hesap makinesi. Bu programı toplama ve çıkarma gibi basit aritmetik işlemleri yapmak için kullanacağız. Hazır mısınız? Başlayalım.

Başlamak için `calculator` adlı bir sınıf tanımlamamız gerekiyor. Toplama ve çıkarma işlemlerini gerçekleştiren metotları burada barındıracağız. Haydi bunu kuralım.

Bunun için `public class calculator` ile bir sınıf oluşturup süslü parantezleri ekleyerek başlayacağız; bu parantezlerin içinde toplama ve çıkarma için metotlar olacak.

Sınıfımız hazır olduğuna göre, sonraki adım bazı değişkenler tanımlamak. Bunlar, üzerinde işlem yapacağımız sayıları tutacak. Şimdi onları ekleyelim.

Şimdilik hesap makinemiz iki sayı üzerinde çalışacak; bu yüzden onları şöyle tanımlarız. `int` olacaklar çünkü tamsayı kullanacağız. Basitleştirmek için değişken adı olarak `number1` kullanırız.

Sistem bunu otomatik olarak `0` değeriyle başlatır. Aynısını `number2` adlı ikinci değişken için de yaparız.

Değişkenlerimiz hazır olduğuna göre, asıl matematiği yapan bir metot yazma zamanı. İki sayıyı girdi olarak alan ve toplamlarını döndüren bir metot oluşturacağız.

Bunun için `add` adlı bir metot oluşturduk; bu metot `number1` ve `number2` değerlerini toplar ve sonucu döndürür.

Metodumuz hazır olduğuna göre, artık onu çalışırken görme zamanı. Bunun için `calculator` sınıfımızın içinde `Main` metodunu yazmamız gerekiyor.

Burası her şeyin bir araya geldiği yer. Nasıl çalıştığına bakalım.

`Main` metodunu yazdık; unutmayın, bu metot programın başlangıç noktasıdır. Bu metot oldukça basit.

Bu metotta, `number1` değişkenine `5`, `number2` değişkenine `10` atadım. Ardından `add` metodunun döndürdüğü değeri saklamak için `result` adlı bir değişken oluşturdum.

Metodu hemen `add` diyerek ve bu parantezleri kullanarak çağırdım.

Sonra şu ifadeyi kullandım: `Console.WriteLine`; bu ifadeye `sum` ile `add` metodundan gelen sonucun birleştirilmiş hâlini ( *concatenation* ) geçirdim.

Sonuç olarak `15` göstermesini bekleriz. Bu kod sizde varsa, terminalde şöyle bir şey yazmalıdır: `sum: 15`, bu da beklenen sonuçtur.

Şimdi başka sayı çiftleri eklemeyi deneyin ve sonucun beklediğiniz gibi olup olmadığına bakın. Aynı şekilde bir çıkarma metodu da oluşturmaya çalışabilirsiniz.

---

## 🧷 static Anahtar Sözcüğü

Devam etmeden önce, değişkenlerde ve metotlarda kullandığımız `static` anahtar sözcüğünü konuşalım.

`static`, bir değişkene veya metoda, sınıfın bir örneğini ( *instance* ) oluşturmaya gerek kalmadan programın her yerinden erişilebilmesini sağlar.

Şimdilik `static` kullanmaya devam edeceğiz; çünkü henüz nesneleri işlemedik. Ancak bunun kodu basit ve erişilebilir tutmak için yararlı bir araç olduğunu aklınızda bulundurun.

---

## 🔁 Döngü ile 1–10 Arası Sayıları Yazdırma

Şimdi biraz farklı bir şeye geçelim. Sıradaki görevimiz, bir döngü kullanarak `1–10` arası sayıları yazdıran bir program yazmak.

Bunu bir geri sayım sayacı kurmak veya bir süreçteki adımları listelemek gibi düşünün. Benzer eylemleri, sona ulaşana kadar tekrar tekrar yaparsınız. Bu, program akışını nasıl kontrol edeceğimizi gösterecek.

Haydi başlayalım.

Yine, `NumberDisplay` adlı bir sınıf tanımlayarak başlayın. Ardından sayıyı görüntülemek için döngü metodunu yazın.

Bu durumda, bir `for` kontrol yapısı kullanıyoruz. Bir indeks oluşturduk; `int i` ile başlıyor ve `1`’den başlatılıyor; `i` değeri `10`’a eşit veya küçük olduğu sürece döngü devam ediyor. Her adımda `++` ile bir artıyor.

`for` gövdesinde, `Console.WriteLine` ile yalnızca indeks numarasını yazdırıyoruz.

Önceki örnekte olduğu gibi, programın başlangıç noktası olarak bir `Main` metodu tanımlarız.

`Main` metodunu, sayıları görüntüleyen metodu çağıracak şekilde yazın.

Devam etmeden önce küçük bir detay: fark etmiş olabileceğiniz gibi `Main` metodu `int` döndürmez, `void` yazar.

`void`, C#’ta “hiçbir şey” anlamına gelen bir veri türüdür. Metot herhangi bir şey döndürmediğinde kullanılır.

Bu programı çalıştırdığınızda, `1–10` arası sayıların bir listesini elde edersiniz.

`DisplayNumbers` metodunun kaç kez döneceğini değiştirerek neler olduğunu görmeyi deneyin.

Sonuçlar, seçtiğiniz sayıya kadar `1`’den başlayan bir sayı listesi göstermelidir.

---

## ⌨️ Kullanıcı Girdisini İşleme

Şu ana kadar kullanıcıdan herhangi bir girdi almayan programlar çalıştırdık. Programlar, değişkenlerde değişiklik olmadan yazıldığı gibi çalıştı.

Ama bir anket veya bir oyun yaptığınızı ve kullanıcıların seçimlerini girdiğini hayal edin. İşte bu noktada kullanıcı girdisini işlemek kritik hâle gelir.

Bu, programlamanın en önemli parçalarından biridir; çünkü programınızın insanlarla gerçek zamanlı etkileşime girmesini sağlar.

Bunu nasıl yapabileceğimizi keşfedelim.

`UserInput` adlı bir sınıf tanımlayarak başlayın. `GreetUser` adlı bir metot yazdım; bu metot, kullanıcıdan adını girmesini istemek için `Console.WriteLine` ile başlar.

Sonra `string` veri türüyle bir değişken tanımlarız; bu değişken bir isim gibi karakter dizilerini tutabilir.

Ardından `Console.ReadLine` metodunu kullanırız; bu metot, kullanıcı Enter tuşuna basana kadar terminalden karakterleri okur.

Program daha sonra sizi “hello” diyerek ve ardından adınızı yazarak selamlar.

Her zamanki gibi, `GreetUser` metodunu çağırmak için bir `Main` metodu yazarız.

Bu programı çalıştırdığınızda, sizden adınızı ister ve sizi selamlar.

Diyelim ki buraya adımı yazıp Enter’a basıyorum; ardından program beni selamlıyor: `Hello, computer. Nice to meet you.`

---

## ✅ Kapanış

Bu videoda, basit C# programları yazdık ve çalıştırdık; böylece şu ana kadar ele aldığımız kavramları uygulama fırsatı buldunuz.

Temel bir hesap makinesi oluşturmak, bir döngü ile sayıları görüntülemek ve kullanıcı girdisini işlemek gibi örnekler, C# sözdizimini ve yapısını anlamak için uygulamalı bir yaklaşım sundu.

Pratik yapmaya devam ettikçe, kendi kodunuzu yazıp çalıştırmanın giderek daha sezgisel hâle geldiğini göreceksiniz; bu da daha ileri programlama görevleri için sağlam bir temel oluşturur.

Bu örneklerle denemeler yapmaya devam edin; yakında daha karmaşık ve daha dinamik C# uygulamalarını güvenle oluşturabileceksiniz.
