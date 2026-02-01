## 🧾 ASP.NET Identity’de Claim Tabanlı Yetkilendirme

Uygulamalarda bilgiye erişim, güvenliği ve işlevselliği şekillendirir.  **ASP.NET Identity** ’de *claim tabanlı yetkilendirme* ile, kullanıcıların benzersiz niteliklerine göre hassas erişim atama esnekliği kazanırsınız; bu da daha güvenli ve daha özelleştirilmiş bir deneyim oluşturur.

Bu videoda,  **ASP.NET Identity** ’de claim tabanlı yetkilendirmenin nasıl çalıştığını ve claim’lerin kullanıcılara nasıl atandığını açıklayacağız.

---

## 🏷️ Claim Nedir?

Claim tabanlı yetkilendirmeyi ele almadan önce, bir  **claim** ’in ne olduğunu tanımlamalıyız.

Claim’ler, bir kullanıcıya veya varlığa ait bir özelliği ya da karakteristiği temsil eden **ad-değer (name-value)** çiftleridir.

Örneğin, insanları farklı alanlara özel bir bileklikle alan bir lunapark hayal edin. Bu bileklik; adınız, yaşınız ve hangi oyuncaklara binebileceğiniz gibi bilgiler içerir.

Sizinle ilgili bu bilgi parçaları claim’lere benzer. Örneğin yaş için ad-değer çifti, **age** ve **22** gibi sayısal bir değer olabilir. Bunlar, parkın ne yapmanıza izin verileceğine karar vermek için kullandığı sizinle ilgili gerçeklerdir.

---

## 🛡️ Claim Tabanlı Yetkilendirme Nedir?

Claim kavramını anladıktan sonra, şimdi claim tabanlı yetkilendirmenin ne olduğunu tanımlayalım.

 **Claim tabanlı yetkilendirme** , bir kaynağa veya uygulamaya erişimin, bir kullanıcının kimliğiyle ilişkili claim’lerin değerlendirilmesiyle belirlendiği bir güvenlik modelidir.

Önceden tanımlı rollere dayanan rol tabanlı kimlik doğrulamanın ( **RBAC** ) aksine, claim tabanlı yetkilendirme birden fazla özniteliğe dayalı izinler tanımlayabildiği için daha fazla esneklik sunar.

---

## 🧩 Claim Tabanlı Yetkilendirmenin Temel Unsurları

Şimdi claim tabanlı yetkilendirmeyi daha ayrıntılı inceleyelim; bunun için bazı temel öğelerini ele alacağız ve claim atama ile başlayacağız.

---

## ➕ Claim Atama

Claim’ler,  **ASP.NET Identity** ’de `UserManager` sınıfı kullanılarak atanır.

Claim atamak önemlidir çünkü bir kullanıcıya hangi seviyede erişim verileceğini belirlememizi sağlar.

Örneğin, IT departmanında çalışan Alex adlı bir kullanıcıya bir claim atayabilirsiniz. Alex’e **department: IT** gibi bir claim atanabilir.

Bunu yapmak, Alex’in yalnızca IT personeline açık olan IT destek paneli gibi uygulama içindeki IT ile ilgili kaynaklara erişmesine izin verir.

---

## 🗄️ Claim’lerin Veritabanında Saklanması

Claim’ler atandıktan sonra, sistemin claim’leri veritabanında nasıl sakladığını anlamamız gerekir.

 **ASP.NET Identity** ’de claim’ler veritabanında **ASP.NET User Claims** tablosunda saklanır.

Örneğin, Alex giriş yaptığında sistem Alex’in claim’lerini doğrudan **ASP.NET User Claims** tablosundan alır.

Bu claim saklandığı için Alex, izinleri tekrar talep etmek zorunda kalmadan IT kaynaklarına sorunsuz şekilde erişmeye devam edebilir.

Claim’leri veritabanında saklamak, izinlerin oturum açmalar arasında kalıcı olmasını sağlar ve kullanıcılara akıcı bir deneyim sunar.

Bu yaklaşım, çok sayıda kullanıcıyla çalışırken bile uygulamayı daha hızlı ve daha verimli hâle getirir. Ayrıca birden fazla sunucuda çalışan dağıtık sistemlerde özellikle tutarlılığı ve güvenliği korur.

Ek olarak, izin güncellemelerini basitleştirir. Değişiklikler bir sonraki kimlik doğrulamada anında uygulanır ve ekstra çaba gerektirmez.

---

## 📜 Yetkilendirme Politikaları

Claim’lerin nasıl atandığını ve saklandığını incelediğimize göre, sistemin belirli alanlarında claim’leri kontrol etmek için yetkilendirme politikalarının nasıl kullanıldığını incelememiz gerekir.

 **Yetkilendirme politikaları** , bir sistemin belirli alanlarına kimin erişebileceğine karar vermemize yardımcı olan kurallardır.

 **ASP.NET Identity** ’de bu politikalar, sistemin belirli bir alanına erişim izni vermeden önce kullanıcının claim’lerini kontrol eder.

Örneğin, Alex **Server Management** sayfası gibi güvenli bir alana erişmeye çalıştığında, politika Alex’in **Department** için IT claim’ine sahip olup olmadığını kontrol eder.

Alex bu claim’e sahipse erişim verilir. Değilse politika Alex’in içeri girmesini engeller.

---

## ✅ Özet

Bu videoda,  **ASP.NET Identity** ’de claim tabanlı yetkilendirmenin nasıl çalıştığını ve claim’lerin kullanıcılara nasıl atandığını öğrendiniz.

Claim’leri kullanarak, kullanıcıların belirli sorumluluklarına göre uyarlanmış erişim sağlayabilir ve hassas, güvenli erişim kontrolü elde edebilirsiniz.

Roller basit ve statik senaryolar için etkili olsa da, detaylı ve uyarlanabilir erişim yönetimi gerektiren dinamik ortamlarda claim’ler vazgeçilmezdir.
