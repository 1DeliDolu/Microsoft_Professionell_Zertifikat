## 🧠 Temel Programlama Kavramları

Programlama, bilgisayarlarla iletişim kurmamızı ve fikirlerimizi hayata geçirmemizi sağlayan yeni bir dil öğrenmek gibidir. Her dilde olduğu gibi, kendimizi etkili biçimde ifade edebilmek için anlamamız gereken temel öğeler vardır. Programlamada bu temel öğeler; bilgiyi depolayan  *değişkenler* , bu bilginin doğasını tanımlayan *veri türleri* ve bu bilginin nasıl kullanılacağını yöneten  *kontrol yapılarıdır* .

Bu temel kavramlarda ustalaşmak çok önemlidir. Bir geliştirici olarak üreteceğiniz her şeyin temelini oluştururlar. Bu videoda, temel programlama kavramlarını özetleyeceğiz.

Programlamadaki en önemli kavramlardan biri ve her şeyin başlangıcı olan kavram ise  *Boolean (mantıksal) değişkenlerdir* .

## ✅ 🔢 Boolean Değişkenler

Bu değişkenler, bilgisayar bilimcilerin bilgisayarların insanlar gibi mantıksal düşünmesini gerçekten mümkün kılmasına yardımcı oldu. C#’ta bir Boolean değişken, iki değerden birini tutabilen bir değişken türüdür: `true` veya `false`.

Bu değerler genellikle *ikili durumları* temsil etmek için kullanılır; örneğin  *evet veya hayır* ,  *açık veya kapalı* ,  *doğru veya yanlış* . İşte bu kadar: basit, ama temel ve güçlü.

Bir video oyunu geliştirdiğinizi ve bir oyuncunun hayatta olup olmadığını takip etmeniz gerektiğini hayal edin. Bir Boolean değişken, oyuncunun hayatta olup olmadığını gösterebilir.

Bunu yapmak için, bunun bir Boolean değişken olduğunu belirtmek üzere `bool` yazarız, ardından değişkenin adı olan `isPlayerAlive` gelir.

Değeri `true` olarak atamak için eşittir işaretini kullanır ve `true` yazarız.

## 🔁 🧩 Boolean Mantığı ve Operatörler

Programlamada Boolean mantığı,  *AND* , *OR* ve *NOT* gibi mantıksal işlemleri gerçekleştirmek için `true`-`false` değerlerini kullanır. Bu işlemler, programınızda kararlar almak için kritik öneme sahiptir.

Aşağıdakiler, Boolean mantığında gerçekleştirebileceğiniz temel işlemlerdir.

### 🔗 AND İşlemi

*AND* işlemi, yalnızca her iki koşul da doğruysa `true` döndürür. AND işlemi, birden fazla koşulu değerlendiren mantıksal bir işlemdir. Kontrol edilen her koşul da doğruysa yalnızca `true` sonucunu verir. Bu koşullardan herhangi biri `false` ise sonuç `false` olur.

AND işlemi, aynı anda birden fazla kriterin karşılandığını doğrulamanız gerektiğinde özellikle kullanışlıdır.

Örneğin, bir kullanıcının hem oturum açmış *hem de* uygun izinlere sahip olduğundan emin olmak istiyorsanız, ikisini birlikte kontrol etmek için AND işlemini kullanırsınız.

C# programlama dilinde AND işlemi iki adet “ampersand” ile gösterilir: `&&`. C#’ta iki koşul arasında `&&` kullandığınızda, her iki koşulun da doğru olup olmadığını kontrol eder ve yalnızca ikisi de doğruysa `true` döndürür.

Örneğin, oyunumuzda bir oyuncu, canı tamamen dolu olduğunda ve dayanıklılığı tamamen dolu olduğunda hazır sayılıyorsa; `isAtFullLife` ve `isAtFullStamina` değişkenleri arasına `&&` operatörünü koyarsınız. İşlem, yalnızca her iki koşul da karşılandığında `true` döndürür.

Diyelim ki bunlar oyuncunun can ve dayanıklılık çubukları. Burada her iki çubuk da tam dolunun altında, bu yüzden oyuncunun hazır olup olmadığını belirlemek için yapılan işlem `false` döndürür.

Çubuklardan biri tam doluya ulaşsa bile oyuncu hâlâ hazır değildir. İşlem `false` döndürmeye devam eder, çünkü değişkenlerden biri `false` durumundadır.

Ancak her iki koşul da karşılandığında, o zaman oynamaya hazır bir oyuncumuz olur.

## ➕ OR İşlemi

En az bir değerin `true` olup olmadığını hesaplamanıza yardımcı olan başka bir Boolean işlemi daha vardır. *OR* işlemi, birden fazla kriterden en az birinin sağlanıp sağlanmadığını belirlerken kullanışlıdır.

Örneğin, bir kullanıcı *admin* ise **VEYA** özel bir geçiş kartına sahipse erişime izin vermek istiyorsanız, bu koşullardan en az birinin `true` olup olmadığını kontrol etmek için OR işlemini kullanırsınız.

C# dilinde
