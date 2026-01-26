## 🧩 Practical Examples of Calling Methods

Metotları etkili şekilde çağırmayı anlamak her geliştirici için kritiktir. Bu, yalnızca sözdizimini bilmekle ilgili değildir; metotları gerçek dünya problemlerini çözmek ve verimli, işlevsel kod üretmek için kullanmakla ilgilidir. İster bir karşılama mesajı görüntülüyor olun, ister toplam hesaplıyor olun ya da kullanıcı girdilerini doğruluyor olun, bu görevlerin tamamı metotları doğru ve amaçlı şekilde çağırmaya dayanır.

Bu videoda, bir program içinde belirli görevleri yerine getirmek için metotları çağıracağız. Bir metodun, nesne yönelimli programlamada bir nesneyle ilişkilendirilmiş ve nesnenin verisi üzerinde çalışan bir fonksiyon olduğunu hatırlayın. Metotlar, metoda geçirilen veri olan argümanları kabul eder.

Şimdi geliştiricilerin uygulamalarda işi yaptırmak için metotları kullandığı bazı yaygın senaryoları inceleyelim.

---

## 🏢 Senaryo: Greenway Masaüstü Uygulaması

Greenway adlı kurgusal bir şirket için C# ile bir masaüstü uygulaması oluşturduğumuzu varsayalım. Greenway, çevre dostu teslimat çözümlerinde uzmanlaşmış bir taşımacılık şirketidir.

Uygulamanın, kullanıcı uygulamaya giriş yaptığında bir karşılama mesajı görüntülemek için bir C# metoduna ihtiyacı olacaktır. Bu amaçla **display welcome message** adlı bir metot oluşturalım.

Önce metot header’ını **public void display welcome message** olarak tanımlarız.

Ardından, kullanıcı uygulamaya giriş yaptığında bir mesaj kutusunda **welcome to greenway** metnini görüntüleyen metot gövdesini ekleriz.

Metodu çağırmak için, adını yazarız ve ardından bir çift parantez ekleriz.

Parametre olmadığı için parantezler boş kalır.

Bu, programın metot içindeki kodu yürütmesini ve kullanıcıya karşılama mesajını göstermesini söyler.

---

## ➕ İki Sayının Toplamını Hesaplama

Sonraki adımda, kullanıcının girdiği iki sayının toplamını hesaplamak için bir metot ekleyeceğiz. Bu amaçla **CalculateSum** adlı bir metot oluşturacağız.

Sözdizimini adım adım parçalayalım.

Önceki örnekte olduğu gibi, metot header’ını **public int CalculateSum** olarak tanımlar ve iki adet integer parametre **a** ve **b** ekleriz.

Metot gövdesinde, giriş parametrelerinin toplamını döndürürüz.

Bu metodu çağırmak için, sonucunu aynı türde bir değişkene atar ve ardından toplamı konsola yazdırırız.

Bu örnekte konsol, **sum is 15** ifadesini gösterecektir.

---

## 🔞 Kullanıcının Yaşını Doğrulama

Sonraki olarak, bir kullanıcının belirli özelliklere erişmek için yeterince büyük olup olmadığını doğrulamak için bir metot kullanacağız.

Kullanıcının yaşını doğrulamak ve kullanıcıya yeterince büyük olup olmadığını bildiren uygun bir mesaj göstermek için **IsUserOldEnough** adlı bir metot oluşturacağız.

Bunu C#’ta adım adım sözdizimini parçalayarak nasıl uygulayacağımızı inceleyelim.

İlk olarak metodu tanımlarız.

Metodun **true** ya da **false** bir değer döndürdüğünü belirtmek için **public** bir access modifier ve **bool** bir dönüş türü kullanırız.

Metot, kullanıcı yaşını girdi olarak alır ve **age** adını vereceğimiz bir integer argüman kabul eder.

Metot gövdesinde, metoda geçirilen **age** argüman değerinin **18** veya üzerinde olup olmadığını değerlendirmek için bir **if/else statement** kullanırız.

Eğer öyleyse metottan **true** döndürürüz; değilse **false** döndürürüz.

Ardından, kullanıcının girdiği yaşı argüman olarak kullanarak **IsUserOldEnough** metodunun çağrısının sonucunu kontrol eden bir **if/else statement** yazarız.

**if/else** ifadeleri **true** ve **false** değerlerini kontrol eder. Parantez içindeki değer **true** ise, **if** bölümündeki kod çalışır. **false** ise, **else** bölümü yürütülür.

Metodumuz boolean bir değer döndürdüğü için, dönüş değerini doğrudan **if/else** ifadesi içinde kontrol edebiliriz.

Son olarak, metot çağrısının sonucu **true** ise, bu kullanıcının içeriğe erişmek için yeterince büyük olduğu anlamına gelir.

Kullanıcıya **access granted** mesajını gösteririz; aksi hâlde **access denied** mesajını gösteririz.

---

## 🎯 Özet

Bu videoda, bir program içinde belirli görevleri yerine getirmek için metotların nasıl çağrılacağını öğrendiniz.

Metotlar ve parametrelerle ilgili temel kavramları anlayarak başladık ve bu kavramları gerçek dünya senaryolarına uyguladık.

Bu tekniklerde ustalaşarak, daha düzenli ve yeniden kullanılabilir kod yazmak için artık daha iyi donanımlısınız; bu da programlarınızı daha verimli ve yönetmesi daha kolay hâle getirir.
