## 🧩 Method Return Values

Bir hesap makinesi uygulamasının sonuçları anında nasıl gösterdiğini hiç merak ettiniz mi? Hepsi, birazdan ustalaşacağımız bir kavram sayesinde olur: metot dönüş değerleri ( *method return values* ). Bu beceri, programınızın işlevselliğini artırır ve daha dinamik, daha verimli çözümler üretmenizi sağlar. Metotların nasıl değer döndürdüğünü ve bu değerleri nasıl kullanacağınızı öğrenmek, programlamanızı bir üst seviyeye taşıyacak temel bir beceridir.

Bu videoda, metotların nasıl değer döndürdüğünü ve bu değerlerin nasıl kullanılacağını açıklayacağız.

---

## ↩️ Return Type Nedir?

Bir metodun  *return type* ’ı, metot çalışmasını tamamladıktan sonra döndüreceği değerin veri türünü belirtir. Bir metot, kullandığınız programlama dilinde geçerli olan herhangi bir türü döndürebilir.

C# gibi dillerde, siz tarafından oluşturulan özel nesneleri ( *custom objects* ) bile dönüş türü olarak kullanabilirsiniz.

Dönüş türü, metot tanımında belirtilir.

Şimdi, iki dönüş türünü ve bunların kodda nasıl kullanılabileceğini inceleyelim.

---

## 🚫 void Return Type

**void** dönüş türüne sahip bir metot hiçbir değer döndürmez. Sadece bir eylem gerçekleştirir.

Örneğin, **PrintMessage** metodu konsola bir mesaj yazdırır, ancak bir değer döndürmez.

---

## ✅ void Dışındaki Return Type’lar

**void** dışındaki dönüş türlerine sahip metotlar, metodu çağıran kod tarafından kullanılabilecek bir değer döndürür.

Örneğin, **GetNumber** metodu bir *integer* döndürür.

**void** olmayan bir metodu çağırırken, dönen değeri aynı türde bir değişkene atayabilir veya doğrudan koşulları değerlendirmek ya da işlemler yapmak için kullanabilirsiniz.

Örneğin, **int** veri türünde **number** adlı bir değişken tanımlayabilir ve bunu dönüş türü de **int** olan **GetNumber** metodunun sonucuna atayabiliriz.

Dönüş türleri, metodun döndüreceği değerin türünü tanımlar. Değerin kendisini tanımlamaz. Bu, metot gövdesindeki kodda **return** anahtar kelimesiyle yapılır.

Şimdi bunu inceleyelim.

---

## 🔁 return Statement

Bir **return** ifadesi, metot gövdesi içinde çağırana bir değer döndürmek için kullanılır. Bu, veriyi metodu çağıran program bölümüne geri göndermenizin yoludur.

Metot gövdesi yapması gereken işi tamamladıktan sonra, **return** ifadesi metot yürütmesini sonlandırır ve bir değer döndürür.

Metodun döndürdüğü değer, metot tanımında belirttiğiniz türle aynı türde olmalıdır.

Örneğin, **return 42** satırı **GetNumber** metodunu bitirir ve **42** değerini çağırana geri gönderir.

---

## 💎 Gerçek Dünya Senaryosu: Kişiselleştirilebilir Takı Fiyatı

Şimdi bu kavramları gerçek dünyadan bir senaryoya uygulayalım. Diyelim ki kişiselleştirilebilir takılarda uzmanlaşmış bir şirkette çalışıyorsunuz.

Kullanıcının seçtiği seçeneklere göre kişiselleştirilmiş bir takının fiyatını döndüren bir metot oluşturmanız gerekiyor.

İlk olarak **CalculatePrice** metodunu tanımlarız. Bu metot üç parametre alır:  **material** , **size** ve kazıma ( *engraving* ) ekleyip eklemediğimizi belirlemek için bir **Boolean** değişken.

Dönüş türü  **double** ’dır; çünkü fiyat hesaplaması nedeniyle metot bir **double** değer döndürecektir.

Ardından metot gövdesini yazarsınız.

Metot, $50 temel fiyatla başlar ve sonra seçilen malzemelere (altın veya gümüş gibi), parçanın boyutuna ve kullanıcının seçtiği isteğe bağlı kazıma özelliklerine göre ek maliyetler ekleyerek hesaplama yapar.

Metot gövdesi, nihai fiyatı belirten bir **double** değer döndürür.

Metodu çağırmak için, web sitesi kişiselleştirme seçeneklerini toplar ve müşteri seçimlerini metot için giriş parametreleri olarak kullanır.

Bu örnekte müşteri malzeme olarak  **gold** , boyut olarak **medium** ve kazıma için **true** belirtmiştir.

Bu değerler daha sonra **CalculatePrice** metoduna argüman olarak geçirilir.

Metot, nihai fiyatı **price** değişkeninde saklar.

Ardından **price** değişkenini ve diğer kodları kullanarak fiyatı müşteriye gösterebilir veya değeri daha sonra kullanmak üzere saklayabilirsiniz.

---

## 🎯 Özet

Bu videoda, metotların nasıl değer döndürdüğüne ve bu dönüş değerlerini programlarınızda nasıl etkili şekilde kullanabileceğinize dair temel kavramları öğrendik.

Bu dönüş türlerinde ustalaşarak, daha dinamik ve daha verimli kod yazmak için iyi bir şekilde donanmış olacaksınız.
