## 🔐 JWT Oluşturma ve Çözümleme

JWT’ler, kimlik doğrulamayı desteklemek için internette stateless, token’laştırılmış bilgiyi göndermenin altın standartlarından biridir. Peki aslında bir JWT nedir? Bu videoda, *ASP.NET Core* uygulamasında JWT’lerin oluşturulmasını ve çözümlemesini açıklayacağız.

Şimdi burada koddan biraz geri adım atıp *JWT.io* adlı küçük bir aracı göstereceğim. Bu, ham veriden JWT üretmenize ve veriyi ileri geri oynayarak denemenize olanak tanıyan gerçekten kullanışlı bir web sitesidir. Bu videoda gerçekten kod yazıp geliştirmeyeceğiz, ancak bir JWT’nin nasıl göründüğünü, nasıl üretildiğini göstermek istiyorum; ardından bunun daha sonra doğrudan .NET kodunda nasıl kullanıldığından biraz bahsedeceğiz.

---

## 🧱 JWT’nin Bölümleri

Sağ tarafta üç parça bilgi göreceksiniz. Bir header, bir payload ve bu doğrulama imzası ( *verification signature* ). Burada bir JSON nesnesi var, burada bir JSON nesnesi var ve burada da özel kodlanmış bir imza var. Token’larımızı aslında böyle imzalıyoruz.

Ama bir adım geri çekilip header ve payload’dan bahsedelim. Token içinde gördüğünüz şu iki nokta (“.”), farklı bölümleri birbirinden ayıran şeydir. Soldaki renkler, sağdaki bölümlerle eşleşir.

Ve eğer bir nedenle renklerle ilgili sorun olursa: birinci kısım header, ikinci kısım payload ve üçüncü kısım signature’dır.

Şimdi buna bakıp “Bunu okuyamıyorum. Bu şifrelenmiş.” diye düşünebilirsiniz. Ama aslında değil; en azından header ve payload değil. Header ve payload sadece *base64 URL encoding* kullanılarak URL encode edilmiştir.

---

## 🧾 Base64 URL Encoding Ne İşe Yarar?

Bu, veriyi internetin farklı bölümlerinde metin olarak daha güvenli taşınabilecek bir şeye dönüştürmenin bir yoludur; çünkü farklı URL encoding kullanıyorsanız bazı karakterler metin içinde sorun yaratabilir. Bu yüzden, internette taşınmasını daha güvenli hâle getirmek için base64 encode ediyoruz.

Bu, veriyi daha güvenli yapmaz; sadece farklı yöntemlerle iletilirken yanlış yorumlanma olasılığını azaltır.

Ve bunun nasıl çalıştığını biraz göstermek istiyorum. Eğer buradaki bu veriyi alır ve şu küçük çevrim içi aracı kullanıp veriyi yapıştırırsam, yaptığımız tek şey bu veriyi alıp boşlukları kaldırmak ve size bunun URL encode edildiğinde nasıl göründüğünü göstermektir.

Burada dikkat edin: burada bir secret key yok. Şifreleme yapmıyoruz. Sadece bu verinin temsil edilme şeklini değiştiriyoruz.

Bu düğmeye bastığımda, verinin base64 URL encoded hâlini görüyorsunuz. *EYJ* ile başlıyor ve *CJ9* ile bitiyor. Buraya gelirsek, *EYJ* ve  *CJ9* ’yi göreceksiniz. Yani bu, diğer tarafta üretilen aynı metin parçasıdır.

Eğer bunun JSON versiyonunu almak istiyorsanız, sadece bu base64 URL encoding’i tersine çevirirsiniz. Encode etmek isterseniz de tam tersini yaparsınız. Payload için de aynı şey geçerlidir. Yani token içindeyken bunlar sadece encoded veridir.

---

## ✨ Asıl “Sihir”: Signature

Bu, gerçek JWT’dir. Ve bu token’ın üçüncü kısmı, işin asıl sihrinin olduğu yerdir: signature.

URL encode edilmiş veri internette taşınabilir. Onu bir header içinde gönderebiliriz. Bir URL içinde gönderebiliriz. URL encoding’in amacı biraz da budur.

Ama bu onu güvenli yapmaz. Onu güvenli yapan şey signature’dır.

Şöyle düşünebilirsiniz: “Belki sadece gizli bir parola kullanırım ve JWT’leri üreten sunucum, her mesajın sonuna bu gizli parolayı ekler. Sonra sunucum geri aldığında doğru gizli parola varsa bu verinin doğru olduğunu anlarız.”

Buradaki problem şu: Eğer biri bunu ele geçirirse, bu veriyi manipüle edebilir. Payload içine aslında orada olmaması gereken ekstra şeyler ekleyebilir.

Signature’ın sihri, mevcut signature’ı geçersiz kılmasıdır. Çünkü signature, URL encoded header, URL encoded payload ve aşağıda belirlediğim bir secret key’e bağlı olan bir fonksiyonla oluşturulur.

Dolayısıyla bu signature, yalnızca gönderen bizim secret key’imizle imzaladıysa ve tam olarak bu veriyi içeriyorsa kabul edilir. İletim sırasında biri bu veriyi değiştirmeye çalışırsa, aşağıdaki signing key’e sahip olmadıkları için bu veriye uygun yeni bir signature üretemezler.

Bu veriyi değiştirdiğimde bunun da değiştiğini izlerseniz göreceksiniz. Burada *BWJ* görüyorsunuz; payload’a bir karakter daha eklersem şimdi *4SS* oluyor. Payload verisi değiştikçe signature değişir.

İşte JWT’leri bu kadar güvenli yapan şey budur. .NET uygulamanız, payload’un ve secret key’in bu signature ile eşleşip eşleşmediğini kontrol edecektir.

Aşağıda “signature verified” bilgisini görebilirsiniz. Eğer ben burada bir şeyi değiştirirsem, örneğin bunu manipüle edersem, artık reddedilecektir. Yani .NET, JWT uygulamasını eklediğimizde bunu reddeder.

Aynı şekilde şunu değiştirirsem de artık geçerli değildir. Signature aynı kaldı ama veri değişti. Ve bu ikisinden herhangi biri değişirse token geçersiz olur; onları güvenli yapan da budur.

---

## ✅ Kapanış

Umarım artık bir JWT’nin aslında ne olduğunu, onu özel yapan şeyi, verinin farklı parçalarının ne olduğunu ve bu imzalama yönteminin neden onları bu kadar güvenli ve kurcalamaya karşı dayanıklı hâle getirdiğini daha iyi anlıyorsunuz.
