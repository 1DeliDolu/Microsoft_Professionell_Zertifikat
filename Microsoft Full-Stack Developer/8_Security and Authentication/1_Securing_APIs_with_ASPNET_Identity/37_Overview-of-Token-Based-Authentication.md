## 🔑 Token Tabanlı Kimlik Doğrulama Genel Bakış

Çevrim içi bir hizmete tekrar tekrar giriş yapmadan nasıl güvenli şekilde bağlı kalabildiğinizi hiç merak ettiniz mi? Token tabanlı kimlik doğrulama bunu mümkün kılar; hem kolaylık hem de güvenlik sağlar, çünkü hizmetlerin kimliğinizi tekrarlanan girişler yerine yeniden kullanılabilir token’larla doğrulamasına olanak tanır. Bu videoda, token tabanlı kimlik doğrulama kavramını ve API’leri güvence altına almaktaki rolünü açıklayacağız.

Token tabanlı kimlik doğrulamanın nasıl çalıştığını anlamak için önce token’ın ne olduğunu tanımlayalım. Token, bir sistem veya uygulama içinde bir kullanıcının kimliğini ve erişim haklarını doğrulamak için kimlik bilgisi ( *credential* ) görevi gören küçük bir veri parçasıdır. Bu token, güvenliği artırmak ve özgünlüğünü ( *authenticity* ) ve bütünlüğünü ( *integrity* ) sağlamak için genellikle şifrelenir veya dijital olarak imzalanır.

Token’ların ne olduğunu anladığımıza göre, token tabanlı kimlik doğrulamanın ne olduğuna bakalım.

Token tabanlı kimlik doğrulama, bir kullanıcının ek işlemleri yetkilendirmek için giriş yaptıktan sonra bir token aldığı bir güvenlik yöntemidir. Sonraki her istekte, kullanıcının kimliğini doğrulamak için token gönderilir. Örneğin, bir sosyal medya platformuna giriş yaptığınızda, her paylaşım yaptığınızda, beğendiğinizde veya yorum yaptığınızda kimlik bilgilerinizi yeniden girmeniz gerekmez. Bunun nedeni, her eylem için yetkilendirmeyi yönetmek üzere bir token’ın verilmiş olmasıdır.

Şimdi token tabanlı kimlik doğrulamanın farklı unsurlarını inceleyelim. En yaygın token türünü,  **JSON Web Tokens** ’ı inceleyerek başlayalım.

---

## 🧾 JSON Web Tokens (JWT)

JSON Web Tokens veya  **JWT** ’ler, kullanıcı bilgisini **JSON nesnesi** adı verilen kompakt bir formatta güvenli şekilde saklayan belirli bir token türüdür. Genellikle kullanıcının kimliği ve izinleri gibi kodlanmış ayrıntılar içerir. JWT’ler, verinin özgünlüğünü ve bütünlüğünü sağlamak ve yetkisiz değişiklikleri önlemek için imzalanır.

JWT’ler kompakt oldukları ve kullanıcı bilgisini güvenli biçimde taşıdıkları için yaygın şekilde kullanılır. Bu nedenle web uygulamalarında kimlik doğrulama ve yetkilendirme için sıkça tercih edilirler.

Örneğin, bir öğrencinin bir kursa başlamak için giriş yaptığını hayal edin. Platform, bu kullanıcının içeriklere, tartışmalara ve ödev gönderimlerine erişimi olan bir öğrenci olduğunu belirtmek için bir token verir. Öğrenci kursun farklı bölümlerinde gezinirken, platform ek girişler olmadan uygun izinlere sahip olduğunu doğrulamak için token’ı okur.

Öğrenci öğretmenlere kısıtlı alanlara erişmeye çalışırsa, platform token’ın ham verisine dayanarak erişimi otomatik olarak reddeder.

---

## 🧠 Stateless Authentication

Token’lar sorunsuz ve güvenli erişimi mümkün kıldığından,  *stateless authentication* ’ın merkezindedir. Stateless authentication, sunucunun herhangi bir oturum verisi tutmasını gerektirmeden kullanıcıların doğrulandığı bir yöntemdir. Bunun yerine, her kullanıcı isteği, kullanıcının kimliğini doğrulayan bir token içerir; bu da sunucunun her isteği bağımsız şekilde yönetmesini sağlar. Bu yaklaşım sistemleri daha hızlı ve daha verimli hâle getirir.

Örneğin, banka hesabınıza çevrim içi eriştiğinizi düşünün. Bakiye görüntüleme veya para transferi gibi bir işlem yaptığınız her seferde, sunucu isteğinizle gönderilen token’ı kontrol eder; böylece herhangi bir oturum verisini takip etmeden veya depolamadan sizi doğrulayabilir.

Bu stateless yaklaşım, sistemi hem verimli hem de güvenli tutar.

---

## 🛡️ Token’lar API’leri Nasıl Korur?

Stateless authentication’ı anladıktan sonra, token’ların API’leri nasıl koruduğunu inceleyebiliriz.

Token’lar, yalnızca kimliği doğrulanmış kullanıcıların erişebilmesini sağlayarak API endpoint’lerini güvence altına alır. API, her token’ı doğrulayarak kullanıcının kimliğini ve izinlerini onaylar.

Örneğin, bir fitness uygulamasında yalnızca geçerli bir token, kullanıcıların kişisel antrenman geçmişine erişim izni verir; böylece yetkisiz kişilerin o kullanıcıya ait verilere erişmesi engellenir.

---

## 🧩 Token Tabanlı Kimlik Doğrulama Nasıl Uygulanır?

Token tabanlı kimlik doğrulamayı neden kullanmak isteyebileceğinizi artık anladığınıza göre, bunun nasıl uygulanacağını inceleyelim.

Süreç, kullanıcının kimlik bilgileriyle giriş yapmasıyla başlar; bu, kimlik doğrulama sürecini başlatır.

Başarılı bir girişten sonra sunucu, genellikle kullanıcının kimliği ve izinleri hakkında temel bilgileri içeren bir token (çoğunlukla bir JWT) üretir. Token, sonraki her isteğe eklenir; bu sayede sunucu, kullanıcının kimliğini ve izinlerini belirleyebilir.

Sunucu daha sonra token’ı kontrol ederek geçerli ve özgün olduğundan emin olur. Token geçerliyse istek devam eder; aksi halde erişim reddedilir. Token doğrulamadan geçerse, kullanıcı kaynağa erişim hakkı kazanır.

Genellikle token’lar, istemcinin tarayıcısında güvenlik için cookie içinde veya local storage içinde saklanır.

---

## ✅ Özet

Bu videoda, token tabanlı kimlik doğrulama kavramını ve API’leri güvence altına almaktaki rolünü öğrendiniz.

Kullanıcıları tekrarlanan girişler yerine yeniden kullanılabilir token’larla doğrulayarak, token tabanlı kimlik doğrulama uygulamaları korumaya yardımcı olur.
