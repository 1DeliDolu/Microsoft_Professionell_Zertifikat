## 🔐 JWT Oluşturma ve Çözümleme

Bu laboratuvarda, *ASP.NET Core* uygulamasında JWT’leri oluşturmayı ve çözümlemeyi öğreneceğiz. Birinci adımda, uygulamayı kuruyoruz; bu yüzden **JWT Demo** adlı yeni bir console app oluşturacağız. JWT token kütüphanelerini kullanabilmek için **system.identitymodel.tokens.jwt** .NET paketini ekleyeceğiz.

## 🧪 Adım 2: JWT Oluşturucularını Kurma

İkinci adımda, JWT oluşturucularını kuracağız; token’ı gerçekten burada oluşturuyoruz. Creator sınıfında **createJWT** adlı bir metodumuz var. Yapmak istediğimiz ilk şey secret key’i tanımlamak.

Bu, JWT oluşturmakla ilgili herhangi bir şey olabilir; belirli bir uzunlukta olması gerekir, bu yüzden bu kadar uzundur, ancak uygulamayı geliştirirken buna secret key diyeceğiz. Ardından metotta, yapacağımız ilk şey key’i decode etmektir; oluşturduğumuz secret key’i encode ederek çözülemez hâle getirmek için simetrik bir güvenli anahtar oluşturacağız. **credentials** adlı bir değişken oluşturacağız ve bu değişken, identity model library’nin signing credentials’ını kullanacak. Key’i içeri aktaracağız ve ardından iletim sırasında key gizlensin, çözümlenebilir olmasın diye **HS256** encryption kullanacağız.

Sonra yeni bir **claims** değişkeni oluşturacağız. Claims içinde, o JWT claim’ini oluşturacağız. İlk öğe, claim adını kaydetmektir ve token’ı bir araya getirirken **.sub** kullanmak istiyoruz; bu da *subject* anlamına gelir. Ardından **.jti** olan JWT register claim names’i de kullanmak istiyoruz; bu da JWT token ID anlamına gelir. Burada bu çok spesifik claim’i veriyoruz; böylece token oluşturulduğunda token’ın kimliği ve kullanıcı, izin vermeye çalıştığımız her şeye izin alır.

Sonra token’ın kendisini oluşturacağız. Bir  **issuer** , bir **audience** olacak, claim burada, claim için claims nesnemizi kullanacağız. Ayrıca bir expiration vereceğiz; böylece token çok uzun sürmez ve çok sınırlı bir zamanın ötesinde kullanılamaz; bu sadece bir güvenlik önlemidir. Mevcut zamana beş dakika ekleyeceğiz ki token hızlıca süresi dolsun. Ardından bir token handler oluşturacağız ve sonra handler’ı token ile birlikte çağıran koda döndüreceğiz.

## 🔓 Adım 3: JWT Token’ı Çözümleme

Üçüncü adımda, bir JWT token’ı nasıl çözdüğümüze bakacağız. Encode etmeye benzer; burada sadece tersini yapıyoruz. **decodeJWT** metodunu görebilirsiniz ve diğer metottan oluşturduğumuz token’ı buraya geçiriyoruz. Burada yeni bir handler oluşturmak istiyoruz ve bu **JWT security token handler** olacak. Yine **IdentityModels.token** kütüphanesini kullanıyoruz. Bu yeni JWT security token handler nesnesini oluşturup **handler** değişkenine koyacağız.

Sonra tüm parametrelerimiz var; ancak aynı issuer’ı, aynı audience’ı kullandığımızı ve secret key’i kullandığımızı görebilirsiniz. Decode etmek için kullandığımız secret key, encode etmek için kullandığımız secret key ile aynıdır ve yalnızca key’i oluşturan kod ile onu çözen kod bu key’e erişebilmelidir. Key, iletim sırasında çözülemeyecek şekilde güvenli biçimde saklanmalıdır.

Ardından **JWT token** değişkenini, token’ı geçirerek **read token** metodunu kullanıp token’ı okuyarak dolduruyoruz. Böylece token, JWT token değişkenine açılacak ve sonra token’da az önce çözdüğümüz tüm claim’leri bir dictionary’ye açarak claim’leri doğrulayacağız; böylece token’dan claim’i, key’i ve value’yu gerçekten okuyabiliriz.

Token alıcı uygulamaya iletildiğinde, uygulama token’ı açabilir, claim’leri okuyabilir ve istemciden geldiğine göre claim ile ne yapacağına karar verebilir. İşte **identitymodels.tokens** ve **identitymodels.tokens.jwt** kütüphanelerini kullanarak bir JWT token’ı bu şekilde encode ve decode edersiniz.
