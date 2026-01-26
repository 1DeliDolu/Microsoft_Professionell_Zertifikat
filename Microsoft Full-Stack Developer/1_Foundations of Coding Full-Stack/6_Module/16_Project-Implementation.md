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
