## 🧳 Değişken Bildirim Anahtar Kelimeleri

Önemli bir yolculuk için valiz hazırladığınızı hayal edin. Pasaportunuz gibi bazı şeylerin tam olarak aynı kalması gerekirken, kıyafetler gibi diğer eşyalar hava durumuna göre değiştirilebilir ya da yer değiştirilebilir. Programlamada değişkenler de buna benzer şekilde çalışır. Bazılarının esnek olması ve ayarlamalara izin vermesi gerekirken, diğerlerinin programınızın sorunsuz ve öngörülebilir şekilde çalışması için sabit kalması gerekir.

Bu videoda, C#’ta değişken bildirim anahtar kelimelerini kullanacağız.

C# ve JavaScript’te değişken bildirim anahtar kelimeleri, değişkenlerin nasıl bildirileceğini ve yönetileceğini belirleyen kelimelerdir; kapsamı ( *scope* ), değiştirilebilirliği ( *mutability* ) ve bazen de değişkenin türünü tanımlar.

Bir değişkenin  *mutability* ’si, oluşturulduktan sonra değiştirilebilme veya değiştirilebilme yeteneğidir.

Bir değişken, değiştirilebiliyorsa  *mutable* ; oluşturulduktan sonra değiştirilemiyorsa  *immutable* ’dır.

C#’ta yaygın veri türleri  *integer* ,  *double* ,  *string* , *boolean* ve  *array* ’dir. Bu tür anahtar kelimelerini ( *int* , *double* veya *string* gibi) herhangi bir ek değiştirici ( *modifier* ) uygulamadan kullanarak bir değişken bildirdiğinizde, değişken *mutable* olur. Bu, değişken başlatıldıktan sonra programın çalışması sırasında değerinin değiştirilebileceği veya yeniden atanabileceği anlamına gelir.

Örneğin,  **myNumber** ’ı bir *int* olarak bildirir ve başlangıç değerini 10 yaparız. Bu, *mutable* bir değişkendir; çünkü bildirildikten ve bir değer atandıktan sonra değerini değiştirebilirsiniz.  *Mutability* ’yi göstermek için hemen değerini 20’ye değiştirebiliriz.

JavaScript’te değişkenler herhangi bir türde değer tutabilir ve varsayılan olarak  *mutable* ’dır. Ek değiştiriciler olmadan, *mutable* bir değişken bildirmek için **var** anahtar kelimesini kullanabilirsiniz; bu da değerinin kodun herhangi bir noktasında değiştirilebileceği anlamına gelir.

Şimdi, C# ve JavaScript programlama dillerinde *immutable* değişkenlerin nasıl oluşturulacağını inceleyelim. C#’ta **const** ve **readonly** gibi değişken bildirim anahtar kelimeleri, tür anahtar kelimesinden önce kullanıldığında bir değişkeni *immutable* yapar. JavaScript’te benzer kavramlar **let** ve **const** ile yönetilir.

Şimdi bu ifadelerin C#’ta *mutable* ve *immutable* değişkenleri bildirmek için nasıl çalıştığını inceleyelim.

---

## 🔒 const

C#’ta  **const** , başlatıldıktan sonra değiştirilemeyen bir değeri tutan değişkenleri bildirmek için kullanılır. Uygulamanın çalışması boyunca sabit bir değere sahiptirler.

Örneğin, en yüksek olası puanı 100 olan bir oyun programı oluşturduğunuzu varsayalım. Bu maksimum değeri her zaman tutacağını bildiğiniz bir değişkene ihtiyacınız var.

C#’ta **const** kullanarak bir değeri şu şekilde bildirirsiniz:

```csharp
const int MaxValue = 100;
```

Bu,  **MaxValue** ’nun değeri 100 olarak belirlenen ve program boyunca değiştirilemeyen sabit bir *integer* değişken olduğu anlamına gelir.

**const** anahtar kelimesi, **MaxValue** değişkeninin *immutable* kalmasını sağlar; yani değeri sabittir ve bildirildikten sonra değiştirilemez.

JavaScript’te, yeniden atanamayan bir değişken bildirmek için **const** kullanırsınız; yani değişkenin değeri yeniden atanamaz.

Örneğin, **const MaxValue = 100** ifadesinde, **MaxValue** değişkenine başka bir değer verilemez.

Ancak önemli bir istisna vardır. **const** ile bildirilen bir değişken bir nesne ( *object* ) veya dizi ( *array* ) tutuyorsa, içeriğini değiştirebilirsiniz; ancak yine de değişkeni yeni bir nesneye veya diziye yeniden atayamazsınız.

Bu, nesne veya diziye üye ekleyip çıkarabileceğiniz, ancak eşittir işareti kullanarak onu yeniden atayamayacağınız anlamına gelir.

Şimdi, *immutable* değişkenler oluşturan başka bir değişken bildirim anahtar kelimesini inceleyelim:  **readonly** .

---

## 🧱 readonly

C#’ta  **readonly** , yalnızca bir kez atanabilen değişkenleri bildirmek için kullanılır; bu atama ya bildirim sırasında ya da değişkenin bildirildiği aynı kod grubunda çalışan **constructor** adı verilen özel bir kod bloğunda yapılabilir.

Örneğin, C#’ta **MaxAttempts** adlı bir **readonly** değişken bildirebilirsiniz.

**setmaxAttempts** adlı bir constructor içinde, **MaxAttempts** değişkenini beşe eşitlersiniz ve ardından maksimum deneme sayısını konsola yazdırırsınız.

**readonly** anahtar kelimesinin kullanımı nedeniyle, **MaxValue** değişkeni yalnızca constructor sırasında bir kez atanabilir.

JavaScript’te, değişkenleri değiştirilemez yapmak için **readonly** gibi bir anahtar kelime yoktur. Ancak sayılar veya string’ler gibi basit değerlerle **const** kullandığınızda, benzer şekilde çalışır; çünkü değer bir kez ayarlandıktan sonra değiştirilemez.

Programlarınızda veriyi doğru şekilde yönetmek, onları yönetmeyi daha kolay hâle getirir, daha güvenli kılar ve daha az hataya neden olur. *Mutable* veya *immutable* değişkenlere ihtiyacınız olup olmaması bağlama bağlıdır; ancak programlama becerileriniz geliştikçe her ikisini de kullanacaksınız.

Bu videoda, C#’ta değişken bildirim anahtar kelimelerini nasıl kullanacağınızı öğrendiniz ve bunları JavaScript ile karşılaştırdınız.

Örnekler üzerinde çalışarak, **const** ve **readonly** anahtar kelimelerinin bir değişkenin *mutability* ve *immutability* durumunu yönetmeye nasıl yardımcı olabileceğini gördünüz.

Bu anahtar kelimelerin nasıl kullanılacağını anlamak, sağlam ve sürdürülebilir kod yazmak için gereklidir ve bir geliştirici olarak işinizin büyük bir parçası olacaktır.
