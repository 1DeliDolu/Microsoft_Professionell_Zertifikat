## 🧩 Passing Data into Methods

En sevdiğiniz uygulamada en son arama çubuğunu kullandığınız zamanı düşünün. Belki bir tarif bulmak ya da hava durumunu kontrol etmek için kullandınız. Peki girdinizin nasıl olup da istediğiniz tam bilgiye dönüştüğünü hiç merak ettiniz mi? Sır, bu verinin perde arkasında metotlara nasıl aktarıldığında yatıyor. Bu temel programlama kavramı, uygulamalarla etkileşimlerinizi akıcı ve duyarlı hâle getirir.

Bu videoda, parametreleri kullanarak metotlara nasıl veri geçirileceğini açıklayacağız. Bir metodun yapısını gözden geçirerek başlayalım.

---

## 🧱 Bir Metodun Yapısı: Parameters ve Arguments

Bir metodun, bir nesneyle ilişkilendirilmiş ve nesnenin içindeki veri üzerinde çalışan bir fonksiyon olduğunu hatırlayın.

Metot tanımında listelenen değişkenler olan  *parameters* , metot çağrıldığında geçirilecek değerler için yer tutucu ( *placeholder* ) görevi görür.

Bu değerler *arguments* olarak adlandırılır; yani metot işlemlerini gerçekleştirmek için kullandığı veri girdileridir.

Bir metot çağrıldığında, argümanların sayısı ve türü, metotta tanımlanan parametrelerin sayısı ve türüyle eşleşmelidir.

Argümanlar ve parametreler, metoda veri sağlayarak metotların anlamlı işler yapmasını mümkün kılar.

Argüman alabilmesi için metodun, argümanları kabul edebilecek şekilde parametrelerle bildirilmiş olması gerekir.

Parametreleri metot bildiriminin parantezleri içine ekleriz ve metodun hangi türde veri kabul edeceğini bilmek için parametreleri veri türleriyle birlikte tanımlarız.

---

## 👋 Tek Parametre ile Gerçek Dünya Örneği: GreetUser

Yapının gerçek dünyada nasıl uygulandığını inceleyelim. Diyelim ki bir kullanıcı bir web sitesine giriş yaptığında ona bir karşılama mesajı gösterecek bir metot oluşturmak istiyoruz.

Önce metodu tanımlar ve kabul edeceğimiz parametreleri belirtiriz.

**GreetUser** metodu, kullanıcının adını **user name** parametresinde alır ve geçirilen kullanıcı adını kullanarak **hello** artı kullanıcı adı şeklinde bir selamlama gösterir.

**user name** parametresinin **string** veri türü olarak bildirildiğine dikkat edin. Bu, metodun argüman olarak yalnızca **string** veri kabul edeceği anlamına gelir.

Ardından **GreetUser** metodunu çağırır ve gerekli argümanları geçiririz.

Bu örnekte argüman, kullanıcının adıdır.

**Alice** adlı bir kullanıcıyı selamlamak için, metodu çağırır ve parantez içinde kullanıcının adını string veri olarak geçiririz.

Son olarak, metot, geçirdiğimiz parametreyi kullanarak kodunu yürütür.

Örneğimizde metot, mesaj olarak **hello Alice** içeren bir mesaj kutusu gösterir.

---

## 🧾 Birden Fazla Parametre Geçme

Şimdi bu temelin üzerine, metoda birden fazla parametre geçirerek inşa edelim.

Metotlar, metot tanımına birden fazla parametre ekleyerek ve bunları virgülle ayırarak birden fazla parametre kabul edebilir.

Örneğin, **GreetUser** metodunu, kullanıcının en son ne zaman giriş yaptığından beri geçen gün sayısını da gösterecek şekilde genişleteceğiz.

**lastLogin** adlı yeni bir parametre ekleriz ve veri türünü **int** olarak belirleriz.

Bu parametreyi mevcut **user name** parametresinden virgülle ayırırız.

Ardından metot gövdesini, kullanıcıya orijinal **hello** mesajını içeren bir mesaj kutusu gösterecek şekilde güncelleriz.

Ayrıca **it's been** artı **lastLogin** artı **days since you last logged in** şeklinde ek bir satır ekleriz.

Bu metot, mesajı oluştururken **lastLogin** parametresinin değerini kullanacaktır.

Son olarak metodu çağırır ve iki argümanı da geçiririz.

**user name** argümanı olarak  **Alice** ’i geçirmenin yanı sıra, **last log in** argümanı olarak **two** integer değerini geçiririz.

Kullanıcı şu mesajı alır:  **hello Alice, it's been two days since you last logged in** .

---

## 🔗 Parametreleri Metot İçinde İşleme: JoinStrings

Argümanları geçirmenin ve göstermenin yanında, parametreler metot içinde çeşitli görevleri yapmak üzere manipüle edilebilir.

Bunun nasıl yapıldığını göstermek için, argüman olarak verdiğimiz iki string’i birleştiren (*combine* veya  *concatenate* ) ve sonucu döndüren **JoinStrings** adlı bir metot oluşturalım.

Metot bildiriminde, iki adet string parametre ekleriz: **first name** ve  **last name** .

Ayrıca metot dönüş türünü tanımlamak için **string** anahtar kelimesini kullanırız.

Metot gövdesi, **first name** ve **last name** değerlerini birleştirerek, araya bir boşluk ekleyip sonucu döndürür.

Metodu çağırırken, **fullName** adlı yeni bir string değişken oluşturur ve **JoinStrings** metodunun sonucunu bu değişkene atarız.

**first name** argümanı olarak  **Alice** ’i ve **last name** argümanı olarak  **Martinez** ’i geçiririz.

Sonra, **fullName** değişkeninin değerini konsola yazdırmak için bir kod satırı ekleriz.

Sonuç olarak, metodu çağırıp string’leri birleştirdiğimizde, konsola **Alice Martinez** tam ad değeri yazdırılır.

---

## 🎯 Özet

Bu videoda, parametreler ve argümanlar kullanarak metotlara etkili şekilde veri geçirmeyi öğrendiniz.

Tek ve çoklu parametreli metotları tanımlamanın ve çağırmanın sözdizimini incelediniz ve farklı veri türlerinin metotların beklenen girdileri almasını nasıl sağladığını gördünüz.

Bu kavramları anlayarak, artık çeşitli girdilerle çalışabilen ve belirli görevleri yeterli şekilde gerçekleştirebilen daha dinamik ve esnek kod oluşturmak için gerekli araçlara sahipsiniz.

Bu temel bilgi, herhangi bir programlama dilinde düzenli, sürdürülebilir ve yeniden kullanılabilir kod yazmak için kritiktir.
