## 🗺️ Proje Planlama ve Tasarım

Başarılı yazılım geliştirmenin anahtarı, dikkatli planlama ve tasarımdır. Sağlam bir proje planıyla, kodunuzun düzenli, verimli ve karmaşık görevler üzerinde çalışmaya hazır olmasını sağlayabilirsiniz. Bu videoda, kapsamlı bir kod projesini planlayıp tasarlayacağız.

Bir kodlama projesini planlamak ve tasarlamak; proje gereksinimlerini tanımlamayı, hedefleri belirlemeyi ve temel kodlama kavramlarını içeren bir tasarım taslağı oluşturmayı kapsar. Bu adımları bir örnek üzerinden inceleyelim.

İş arkadaşlarınızın görevlerini takip etmelerine yardımcı olacak bir görev yönetimi uygulaması yapmak istiyorsunuz. İlk olarak proje gereksinimlerini tanımlayarak başlayın.

---

## 📋 Proje Gereksinimlerini Tanımlama

Bir projenin gereksinimleri; başarısını sağlamak ve zamanında tamamlamak için karşılanması gereken çıktılar ile tamamlanması gereken görevlerdir. Proje gereksinimleri iki ana kategoriye ayrılır: *functional* ve  *non-functional* .

---

## ⚙️ Functional Requirements

Functional requirements, uygulamanın ne yapması gerektiğini, uygulamayı çalışır kılan temel işlevleri tanımlar. Şu sorulara yanıt verir: uygulama neyi başarmalı?

Görev yönetimi uygulamamız için functional requirements oldukça nettir. Uygulama, kullanıcıların görev eklemesine, görevleri gözden geçirmesine ve görevleri tamamlamasına izin vermelidir.

Bunlar uygulamayı kullanışlı kılan temel eylemlerdir.

---

## 🧩 Non-Functional Requirements

Non-functional requirements, uygulamanın nasıl performans göstermesi gerektiğini kapsar. Bunlar kullanılabilirlik, performans ve güvenlik gibi konulardır.

Uygulamanın sadece işlevsel değil, aynı zamanda güvenilir ve kullanması keyifli olmasını sağlarlar.

Görev uygulaması için non-functional requirements, kullanılabilirlik ve performans üzerine odaklanır.

Uygulamanın sezgisel bir arayüzü olmalı ve kullanıcıların görev oluşturmasını, düzenlemesini ve silmesini en fazla üç seçimle yapabilmesine imkân vermelidir.

Uygulama ayrıca görev listesini iki saniye içinde yükleyebilmeli ve performans düşüşü olmadan 10.000 göreve kadar işleyebilmelidir.

---

## 🎯 Proje Hedeflerini Belirleme

Gereksinimlerimiz belirlendikten sonra, bir sonraki adım net proje hedefleri koymaktır.

Hedefler, bir kişinin veya sürecin belirli bir zaman dilimi içinde ulaşmayı amaçladığı somut sonuçlardır.

Uygulamamız için hedefler şunları içerebilir:

* Üç ay içinde görev ekleme, gözden geçirme ve tamamlama için kod tabanını oluşturmak
* Dört ay içinde görev depolama için veri entegrasyonunu uygulamak
* Yayın öncesinde test ve debugging’i tamamlamak, kritik bug’ların yüzde 95’ini çözmek

Bu hedefler ölçülebilirdir. Uygulamayı geliştirirken, hedefleri karşılayıp karşılamadığını her zaman kontrol edebiliriz.

Net hedefler yön sağlar ve proje takvimini korumaya yardımcı olur. Sürece dahil olan herkesin tam olarak neyin başarılması gerektiğini bilmesini sağlar.

İyi tanımlanmış hedeflerle, zaman, emek ve bütçe gibi kaynakları daha etkili şekilde dağıtabiliriz; bu da tüm süreci daha akıcı hâle getirir.

---

## 🧱 Tasarım Taslağı Oluşturma

Şimdi tasarım taslağı oluşturmaya geçelim.

Bu, gereksinimlerimizi ve hedeflerimizi uygulamanın nasıl çalışacağına dair bir plana dönüştürdüğümüz aşamadır.

Bir tasarım taslağı, uygulamayı inşa etmek için adım adım bir rehber görevi görür.

Görev yönetimi uygulamamızı tasarlamak için projeyi daha küçük ve yönetilebilir modüllere böleceğiz ve bunları uygulamak için kullanacağımız kod bileşenlerini planlayacağız.

Görev uygulamamız için:

* Görevleri görüntüleme modülüne ihtiyacımız var; bu modül kullanıcıların görev listesini istedikleri zaman gözden geçirebileceği basit bir arayüz sağlayacak.
* Görev ekleme modülüne ihtiyacımız var; bu modül yeni görevleri girmek için doğrudan bir yöntem sunacak.
* Görevleri tamamlandı olarak işaretleme modülüne ihtiyacımız var; bu modül seçilebilen checkbox arayüz öğeleri sağlayacak.

Bu taslak, uygulama yapısını incelememize yardımcı olur ve herhangi bir temel özelliği kaçırmadığımızdan emin olmamızı sağlar.

---

## 🧠 Modülleri Uygulamak İçin Kod Bileşenlerini Planlama

Şimdi, modülleri uygulamak için kullanacağımız kod bileşenlerini planlayalım.

Bu modülleri uygulamak için  *variables* ,  *methods* , *if/else statements* ve *loops* kullanmamız gerekir.

---

## 🧾 Variables ile Veri Saklama

Variables bilgi sakladığı için, proje boyunca nerelerde veri tutmamız gerektiğini önceden taslaklandırmalıyız.

Örneğin yapılacaklar listesi uygulamamızda, her görev için bir `string` değişkenine ihtiyacımız vardır.

Kullanıcı her görev eklediğinde, görev bir diziye veya değişkenlerden oluşan bir listeye kaydedilir.

---

## 🛠️ Methods ile İşlevleri Gruplama

Sonra methods tasarlamalıyız. Bunlar, ilgili görevleri yeniden kullanılabilir tek bir kod birimi altında toplamamızı sağlar.

Yapılacaklar listesi uygulamasında, her modül için bir metot olmalıdır; `view task`, `add task` ve `mark task complete` dahil.

---

## 🔀 If/Else ile Karar Noktalarını Yönetme

Ardından, uygulamada kararların nerede verileceğini planlarız.

Koşullara bağlı farklı senaryoları yönetmek için if/else statements kullanacağız.

Örneğin, kullanıcının bir görev girip girmediğini kontrol etmek için bir if/else statement kullanmayı planlarız.

Eğer giriş alanı boşsa, kullanıcıdan görev girmesini isteyen bir mesaj göstereceğiz.

Aksi halde, görevi listeye eklemek için bir mesaj göstereceğiz.

---

## 🔁 Loops ile Tekrarlayan İşlemler

Son olarak, modüllerimizin herhangi birinde koşullara bağlı olarak kodun tekrar etmesi gerekip gerekmediğini belirlemeliyiz.

Tekrarlamanın gerekli olduğu yerleri tespit eder ve bu durumları yönetmek için loops kullanmayı planlarız.

Yapılacaklar listesi uygulamasında, kullanıcı uygulamayı her açtığında eklenmiş tüm görevleri ekranda göstermek için bir loop kullanacağız.

---

## ✅ Kapanış

Bu videoda, kapsamlı bir kod projesini planlamayı ve tasarlamayı öğrendiniz.

Görev yönetimi uygulamamızın her yönünü; gereksinimleri ve hedefleri tanımlamaktan bir tasarım oluşturmaya kadar dikkatle planlayıp tasarlayarak, uygulamanın kullanıcı dostu, verimli ve geliştirmeye hazır olmasını sağlarız.



## 🏗️ Proje Uygulaması

Görev yönetimi uygulamasını planladığımıza göre, artık C# ve Visual Studio Code kullanarak inşa etme zamanı. Bu videoda, öğrenilmiş kodlama kavramlarını kullanarak planlanan projeyi uygulayacağız. Kodu satır satır ele alıp nasıl çalıştığını açıklayacağım; böylece her adımın arkasındaki mantığı anlayabilirsiniz.

Hatırladığınız gibi, uygulama kullanıcıların görev eklemesine, görevleri tamamlandı olarak işaretlemesine ve görevleri görüntülemesine izin verecek. Hadi oluşturmaya başlayalım.

---

## 🧩 TaskManager Sınıfını Tanımlama

Önce `TaskManager` adında bir sınıf tanımlayacağım. Görevleri yönetmekle ilgili tüm mantığı burada saklayacağım.

Şimdi iki adet `static` liste tanımladım: biri görev açıklamalarını saklamak için `tasks`, diğeri her görevin tamamlanıp tamamlanmadığını izlemek için `taskStatus`.

`List<string>`, görev açıklamalarının metin değerlerini tutar. `List<bool>` ise Boolean değerler tutar; burada `false` bekleyen görevleri, `true` ise tamamlanmış görevleri temsil eder.

---

## 📋 Menü ile Kullanıcı Etkileşimini Yönetme

Bir sonraki adım, kullanıcı etkileşimini bir menü aracılığıyla yönetmektir. Kullanıcıdan sürekli bir eylem seçmesini isteyen bir `Main` metodu oluşturacağım.

`Main` metodu uygulamanın giriş noktasıdır. Bu durumda `static` bir modifiye ediciye sahiptir; yani sınıfın kendisine aittir, sınıfın örneklerine değil.

Metot `void` döndürür; yani herhangi bir değer döndürmez.

Parametre olarak bir `string` dizisi alır; bu, program başlarken kullanıcıların argüman geçebilmesine imkân tanır.

Metodun içinde, kullanıcı çıkmayı seçene kadar menüyü sürekli göstermek için bir `while` döngüsü oluştururum.

Menü dört seçenek sunar: görev ekle, görevi tamamlandı olarak işaretle, görevleri görüntüle ve çıkış.

Bu dört seçenek için `Console.WriteLine` fonksiyonunu kullanırım.

Kullanıcının girdisini almak için `Console.ReadLine` fonksiyonunu kullanır ve girdiyi `choice` adlı bir `string` değişkende saklarım.

Seçimlere göre işlem yapmak için bir `switch` ifadesi kullanırım.

`switch` ifadesi, kullanıcının seçimine göre dört `case` ve bir `default case` içerir.

* Case 1’de, görev eklemek için ilgili metot olan `AddTask` çağrılır.
* Case 2’de, görevi tamamlandı olarak işaretlemek için `CompleteTask` metodu çağrılır.
* Case 3’te, görev listesini göstermek için `ViewTasks` metodu çağrılır.
* Case 4, programdan çıkmak için `return` kullanır.
* `default case`, giriş geçersizse kullanılır; bir hata mesajı yazdırır ve menüyü tekrar gösterir.

---

## ➕ Görev Ekleme İşlevini Uygulama

Şimdi görev ekleme işlevini uygulayalım.

Bir `AddTask` metodu oluştururum ve önce kullanıcıya bir görev açıklaması girmesini `Console.WriteLine` ile sorarım.

Açıklama, `Console.ReadLine` ile kullanıcıdan alınır ve `task` adlı `string` türünde bir değişkende saklanır.

Bu görevi `tasks.Add` kullanarak `tasks` listesine eklerim; metoda `task` parametresini geçiririm.

Ayrıca yeni görev başlangıçta tamamlanmadığı için `taskStatus` listesine `false` eklerim.

Son olarak, görevin başarıyla eklendiğini kullanıcıya bildiren bir onay mesajı yazdırırım.

---

## ✅ Görevleri Tamamlandı Olarak İşaretleme

Artık görev ekleyebildiğimize göre, görevleri tamamlandı olarak işaretleyelim.

Bunu yapmak için bir `CompleteTask` metodu oluştururum.

Önce `if-else` ifadesiyle `tasks` listesinde görev olup olmadığını kontrol ederim. Bunun için listenin `Count` özelliğini kullanırım.

`tasks.Count` değerini `0` ile `==` kullanarak karşılaştırırım.

Liste boşsa, “tamamlanacak görev yok” mesajı yazdırırım ve `return` ile metottan çıkarım.

Sonra kullanıcıdan tamamlandı olarak işaretlemek istediği görevin numarasını girmesini isterim.

Girdi, kullanıcı bir şey yazıp Enter’a basana kadar bekleyen `Console.ReadLine` ile alınır.

Girdi alındıktan sonra, `int.TryParse` ile bunu tamsayıya çevirmeyi denerim. Bu, girdinin geçerli bir sayı olup olmadığını kontrol eder.

Ardından görev numarasının geçerli olup olmadığını kontrol ederim: sıfırdan büyük olmalı ve listedeki toplam görev sayısından küçük veya eşit olmalıdır.

Bu kontrol, `taskNumber > 0` ve `taskNumber <= tasks.Count` koşullarıyla yapılır.

Eğer sayı bu aralıkta ise, ilgili görevi tamamlandı olarak işaretlerim.

Bunun için `taskStatus` listesindeki `taskNumber - 1` konumundaki değeri `true` yaparım. Bu, görevin tamamlandığını gösterir.

Sonrasında, görev açıklamasını da içeren bir onay mesajı gösteririm; yani görev numarasının tamamlandı olarak işaretlendiğini belirtirim.

Girdi geçersizse, yani sayı değilse veya görev aralığının dışındaysa, “geçersiz görev numarası” mesajı yazdırırım.

Bu, kullanıcının geçerli bir görev numarası girmesi gerektiğini anlamasını sağlar.

---

## 📋 Görevleri Görüntüleme

Şimdi kullanıcının görev listesini görüntülemesini sağlayan metoda geçelim.

Bir `ViewTasks` metodu oluştururum ve önce `tasks.Count` kontrolüyle görüntülenecek görev olup olmadığına bakarım.

Hiç görev yoksa, “görev yok” mesajı yazdırır ve metottan çıkarım.

Görevler varsa, `for` döngüsü ile `tasks` listesini dolaşır ve her görevi durumuyla birlikte yazdırırım.

Döngü `0`’dan `tasks.Count - 1`’e kadar çalışır ve her görev için `taskStatus` listesinden durumu alırım.

Durum `true` ise `Completed` yazdırırım. Aksi halde `Pending` yazdırırım.

Sonrasında `Console.WriteLine` ile görev numarasını, açıklamasını ve durumunu yazdırırım.

Görev numarası kullanıcı dostu olması için `i + 1` olarak gösterilir.

---

## ✅ Sonuç

Görev yönetimi uygulamasının çekirdek özelliklerini uyguladıktan sonra, görev ekleme, görüntüleme ve tamamlama için çalışan bir araca sahip oluruz.

Bunun gibi gerçek dünya örnekleriyle ne kadar çok çalışırsanız, C#’ı anlamada ve kodlama kavramlarını projelerinize uygulamada o kadar iyi olursunuz.
