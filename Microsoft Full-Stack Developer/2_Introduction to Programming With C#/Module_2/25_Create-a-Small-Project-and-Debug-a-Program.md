## 🗂️ Küçük Bir Proje Oluşturma ve Bir Programı Debug Etme

Basit bir yapılacaklar listesini yönetmeye olanak tanıyan küçük bir konsol uygulaması oluşturacağız. Program, kullanıcıların görev eklemesine, görev listesini görüntülemesine ve görevleri tamamlandı olarak işaretlemesine izin verecek. Bu, kullanıcı girdisi toplamayı, verileri bir dizi ( *array* ) içinde saklamayı ve listeyle etkileşim kurmak için döngüler kullanmayı içerecek.

Bir program oluştururken, onu daha küçük görevlere bölmek faydalıdır; bu, yazmayı ve anlamayı kolaylaştırır. Bu programda, listeye görev ekleyeceğiz, listede neler olduğunu görmek için görevleri görüntüleyeceğiz, bittiğinde görevleri tamamlandı olarak işaretleyeceğiz. Bunu yapmak için  *metotlar* , *döngüler* ve *diziler* kullanacağız. Programın her parçasının kendi yapacağı işler olacak; bu da onunla çalışmayı daha kolay hâle getirecek.

Diziler, birden fazla görevi saklamamıza izin verdikleri için kullanışlıdır; döngüler ise kullanıcının sırada ne yapmak istediğini tekrar tekrar kontrol etmemizi sağlar. Son olarak, yapabileceğimiz hataları yakalamak ve düzeltmek için hata ayıklama ( *debugging* ) tekniklerini kullanacağız.

---

## 📦 Görevleri Saklayacak Bir Yer

Öncelikle görevleri saklayacak bir yere ihtiyacımız var. Bir dizi ( *array* ) kullanacağız; dizi, birden fazla veri parçasını saklayabilen özel bir değişken türüdür. Diziler, aynı türden birden fazla şeyi saklamak istediğimizde faydalıdır.

C#’ta bir dizi, aynı türden birden çok değeri tutan bir kapsayıcı gibidir. Bizim durumumuzda dizi, görevleri temsil eden metin parçaları olan *string* değerlerini tutacak.

Dizilerin boyutu sabittir; bu örnekte 10 görevdir, yani dizide en fazla 10 görev saklayabiliriz. Her görev, *index* denen ayrı bir konumda saklanır. Dizideki her göreve, 0’dan başlayan bir indeks ile erişiriz.

Ayrıca listede kaç görev olduğunu takip etmek için `taskCount` adlı bir sayaç değişkenine ihtiyacımız var. Bu değişken 0’dan başlar; çünkü liste ilk başta boştur. Her görev eklendiğinde `taskCount` değeri 1 artırılır; böylece bir sonraki görev, dizideki bir sonraki boş konuma kaydedilir.

---

## ➕ Görev Ekleme Metodu

Sonra, kullanıcının listeye görev eklemesine izin veren bir metot oluşturacağız.

Kullanıcı yeni bir görev yazdığında, bunu `taskCount` değişkenini kullanarak dizide doğru konuma kaydedeceğiz.

Kullanıcıdan görev girmesini istemek için `AddTask` adlı bir metot kullanacağız. Metot, kullanıcının yazdığını yakalayan `Console.ReadLine` kullanarak bu görevi dizide saklayacak. Görev, dizide bir sonraki uygun konuma kaydedilecek; bu konum `taskCount` tarafından belirlenir.

Unutmayın, diziler 0 indeksinden başlar; bu yüzden ilk görev `tasks[0]` içine, ikinci görev `tasks[1]` içine kaydedilir ve bu şekilde devam eder.

Her görev eklendikten sonra, bir sonraki görevin bir sonraki boş konuma gitmesini sağlamak için `taskCount` değerini 1 artırırız. Bu, her yeni görevin doğru yere eklenmesini ve var olan görevlerin üzerine yazılmamasını sağlar.

`taskCount` değişkeni, kaç görev eklendiğini ve bir sonraki görevin nereye yerleştirilmesi gerektiğini takip etmemize yardımcı olur.

---

## 👀 Görevleri Görüntüleme Metodu

Şimdi, kullanıcının şu ana kadar eklediği tüm görevleri görüntülemek için bir metot oluşturacağız. Bu metot, `tasks` dizisi üzerinde döngüyle ilerleyip her görevi yazdıracak.

Görevleri görmek için, `tasks` dizisindeki her elemanın üzerinden geçmek üzere bir döngü kullanacağız. Döngü, dizinin başlangıcı olan indeks 0’dan başlayacak ve `taskCount` değerine ulaşınca duracak. Bu, yalnızca eklenmiş görevleri yazdırmamızı ve dizideki boş konumları yazdırmaktan kaçınmamızı sağlar.

Her görev, okunmayı kolaylaştırmak için 1’den başlayan bir numarayla yazdırılacak; her ne kadar dizi indeksleri 0’dan başlasa da. Bunu daha kullanıcı dostu yapmak için `i + 1` kullanılır.

---

## ✅ Görevi Tamamlandı Olarak İşaretleme Metodu

Şimdi, kullanıcının bir görevi tamamlandı olarak işaretlemesine izin veren bir metot oluşturacağız. Bu, kullanıcının dizideki bir görevi güncellemesini ve onun bittiğini göstermesini sağlar.

Kullanıcı, tamamlandı olarak işaretlemek istediği görevi, görev numarasını girerek seçecek.

C#’taki diziler 0’dan saymaya başlar, ancak kullanıcı 1’den başlayan bir numara gireceği için, doğru indeksi bulmak adına kullanıcının girdisinden 1 çıkarmamız gerekir. Örneğin, kullanıcı görev 1’i seçerse, `tasks[0]` güncellenmelidir.

Dizide doğru görevi bulduğumuzda, bitirildiğini göstermek için görev metnini “completed” metnini ekleyerek değiştireceğiz.

Bu, görevi günceller ve kullanıcıya görevin tamamlandı olarak işaretlendiğini açıkça gösterir.

---

## 🧭 Her Şeyi Birleştiren Main Metodu

Son olarak, her şeyi bir araya getiren `Main` metodunu yazacağız. Bu metot, kullanıcının görev eklemek mi, görevleri görüntülemek mi, yoksa bir görevi tamamlandı olarak işaretlemek mi istediğine karar vermesini sağlayacak.

Kullanıcı çıkmayı seçene kadar programın çalışmaya devam etmesi için bir `while` döngüsü kullanacağız. Döngü içinde program, seçeneklerden oluşan bir menü gösterecek. Kullanıcı, görev ekleme, görevleri görüntüleme veya görevi tamamlandı olarak işaretleme seçeneklerinden birini seçebilecek.

Kullanıcının girdisini ele almak için bir `switch` ifadesi kullanacağız ve seçime göre doğru metodu çağıracağız.

Kullanıcı programdan çıkma seçeneğini seçene kadar döngü devam edecek.

---

## 🐛 Hata Ayıklama: Yaygın Bir Hata ve Düzeltme Süreci

Bu adımda, programınızda meydana gelebilecek yaygın bir hatayı tanıtacağız ve onu bulup düzeltme sürecini adım adım ele alacağız.

Debugging, önemli bir beceridir ve kodunuzdaki problemleri tanımlamayı ve çözmeyi öğrenmek sizi daha iyi bir programcı yapar.

Diyelim ki kullanıcı bir görevi tamamlandı olarak işaretlemeye çalışıyor, ancak görev listesi aralığının dışında bir numara giriyor. Örneğin 12 giriyor ama yalnızca üç görev var. Bu durumda program, dizide var olmayan bir konuma erişmeye çalışacağı için *index out of range error* oluşur.

Bu problemi nasıl debug edip düzeltebileceğimizi inceleyelim.

 *Index out of range error* , programınız dizide var olmayan bir konuma erişmeye çalıştığında oluşur. Örneğin dizinizde üç görev varsa ve kullanıcı görev 4’ü tamamlandı olarak işaretlemeye çalışırsa, program çöker; çünkü o konumda bir görev yoktur.

Bunu önlemek için, kullanıcının girdisinin doğru aralıkta olduğundan emin olmak amacıyla hata kontrolü ( *error checking* ) kullanabiliriz.

Bu hatayı düzeltmek için, diziyi erişmeden önce görev numarasının değerini yazdıracağız; böylece doğru olup olmadığını kontrol edebiliriz. Ardından, kullanıcı görev aralığının dışında bir numara girerse bir hata mesajı gösterecek şekilde kodu güncelleyeceğiz.

Debug satırını ekleyip hatayı ele aldıktan sonra, kullanıcı geçersiz bir görev numarası girdiğinde program artık çökmemelidir. Bunun yerine şöyle bir hata mesajı göstermelidir: *invalid task number, please try again.*
