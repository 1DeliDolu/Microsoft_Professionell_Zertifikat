## 🧩 Basics of Calling Methods

Ürün indirimlerini yönetmek gibi bir projede çalışırken, her hesaplama için aynı kodu tekrar etmek hızla güncellenmesi ve yönetilmesi zor bir hâle gelebilir. Bu görevleri ihtiyaç duyduğunuz her an çağırabileceğiniz tek bir yeniden kullanılabilir kod bloğu hâline getirebilseydiniz harika olmaz mıydı? Metotlar programlamada tam olarak bu şekilde çalışır. Program içinde metot çağırmayı anlamak, kodunuzu daha verimli, hata yapma olasılığı daha düşük ve yönetmesi daha kolay hâle getirir.

Bu videoda, bir program içinde metotların nasıl çağrılacağını ve giriş parametrelerini kullanarak metotlara nasıl argüman geçirileceğini açıklayacağız.

---

## 🧠 Metot ve Argümanlar

Bir metot, belirli bir görevi yerine getirmek için tasarlanmış bir kod bloğudur. Nesne yönelimli programlamada, bir nesneyle ilişkilendirilmiş bir fonksiyondur.

Bir nesnenin içinde bulunan veri üzerinde çalışır.

Metotlar, argümanlar biçiminde veri kabul edebilir. Argümanlar, bir metodu veya fonksiyonu çağırdığınızda metoda geçirdiğiniz değerler veya verilerdir.

Metot, bu veriyi ve argümanları kullanarak işlemlerini gerçekleştirir.

---

## 🧱 Metot Tanımı: Header ve Body

Bir metodu çağırmadan önce, programınızda tanımlanmış olması gerekir. Bir metot tanımı iki temel bileşen içerir: *method header* ve  *method body* .

İlk olarak,  *method header* ; metot adını, dönüş türünü ( *return type* ) ve parametreleri belirtir.

Metot adı, sizin seçeceğiniz herhangi bir şey olabilir; ancak geliştiriciler genellikle metotları ne yaptıklarını açıklayan şekilde adlandırır.

Metodun dönüş türü, geçerli herhangi bir C# dönüş türü olabilir veya kodunuzun başka bir yerinde tanımladığınız bir nesne olabilir.

İkinci olarak,  *method body* ; metot çağrıldığında çalışan kodu içerir.

Bir metodun gövdesi çok karmaşık veya çok basit olabilir; ancak tüm işi yapan bölüm burasıdır. Hatta bir metot gövdesinden başka metotlar da çağırabilirsiniz.

Metot tanımlandıktan sonra, artık sizin için iş yapması amacıyla metodu çağırabilirsiniz. Bunun nasıl yapıldığını gözden geçirelim.

---

## 📞 Metot Nasıl Çağrılır?

Bir metodu çağırmak için, metot adını yazıp ardından parantez koyun.

Eğer metot parametre gerektiriyorsa, argümanları parantez içinde geçirirsiniz.

Eğer bir metodun dönüş türü varsa, metodun dönüş türü ile aynı türde bir değişken tanımlayın ve bu değişkene metodu atayın.

Bu değişken, metodun döndürdüğü değerle doldurulur.

Metot gövdesi, metot header’ında bildirdiğiniz türle aynı türde bir değer döndürmelidir; aksi hâlde hata oluşur.

---

## 🧪 Örnek: Parametresiz Metot Çağırma (greet user)

Şimdi bu tanımın bir örnekte nasıl hayat bulduğunu inceleyelim. Konsola **hello user** yazdıran bir **greet user** metodu oluşturacağız ve ardından çalıştırmak için metodu çağıracağız.

Önce metot header’ını **public void greet user** olarak tanımlarız.

**void** anahtar kelimesi, metodun çağırana bir değer döndürmediğini belirtir.

Ardından, mesajı konsola yazdıran metot gövdesini oluştururuz.

Metodu çağırmak için, metot adını yazıp ardından bir çift parantez ekleriz.

Parametre olmadığı için parantezler boş kalır.

Bu kod satırı, programın metot içindeki kodu yürütmesini söyler.

Bu örnekte, **greet user** metodunu çağırmak konsola **hello user** yazdıracaktır.

---

## ➕ Örnek: Parametreli Metot Çağırma (add numbers)

Artık metot tanımlamayı ve çağırmayı ele aldığımıza göre, argüman geçirerek metotları daha dinamik hâle getirmeyi inceleyelim.

Her adımı yine takip edeceğiz; ancak bu kez metot header’ında parametreler ve metodu çağıran kodda argümanlar olacak.

İki integer parametre alan ve toplamlarını döndüren **add numbers** adlı bir metot tanımlayalım.

İlk adım, metot header’ını **public int add Numbers** olarak tanımlamak ve integer parametreler **A** ve  **B** ’yi eklemektir.

Sonra, metot gövdesini tanımlarız; bu gövde **A** ile  **B** ’nin toplamını döndürür.

Bu yapıyla metot, hesaplama yapmak için hazırdır.

Son olarak, metodu çağırırken adını yazar ve argüman olarak **5** ve **10** değerlerini geçiririz.

Metot bir integer değer döndürdüğü için, sonucu aynı türde bir değişkene atarız.

Bu, programın metot içindeki kodu yürütmesini ve sonucu **result** değişkeninde saklamasını sağlar.

Bu örnekte, metot çağrıldıktan sonra **result** değişkeni **15** integer değerini içerir.

---

## 🎯 Özet

Bu videoda, bir program içinde metotların nasıl çağrılacağını öğrendiniz.

Bu beceriler; temiz, verimli ve yeniden kullanılabilir kod yazmak için kritiktir.

Bu konularda ustalaşmak, daha karmaşık programlama görevlerinde güvenle çalışabilmeniz için sizi donatacaktır.
