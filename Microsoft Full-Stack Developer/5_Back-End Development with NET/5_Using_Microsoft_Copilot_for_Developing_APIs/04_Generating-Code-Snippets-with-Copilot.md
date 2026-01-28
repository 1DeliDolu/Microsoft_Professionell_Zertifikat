## 🧩 Generating Code Snippets with Copilot

Copilot ile çalışmanın birçok yolu var. Copilot’u Excel ve Word gibi favori uygulamalarınızda kullanabilirsiniz; ayrıca Copilot’u doğrudan kod editörünüze getiren bir Visual Studio Code eklentisi de vardır. Ancak bu kursun amacı için, masaüstü ya da dizüstü bilgisayarınızdan chat tabanlı Copilot sürümlerini nasıl kullanacağımıza odaklanacağız.

Bu videoda, Microsoft Copilot’u API code snippet’leri üretmek için kullanıyoruz. Bu arayüzleri kullanmanın üç yolu vardır.

---

## 🖥️ Desktop Üzerinden Kullanım

Birinci yol, doğrudan masaüstünden kullanmaktır. Burada Copilot uygulamasını kullanabilirsiniz ve karşınıza şık bir chat arayüzü çıkar.

Buradan küçük saat ikonuna tıklayıp “new” seçeneğine basarak yeni bir chat başlatabilirsiniz ya da eski konuşmalarınızdan birini açabilirsiniz.

Örneğin yeni bir konuşma başlatıp şunu sorabilirsiniz:

“`.NET`’te minimal API’ler ile controller-based API’ler arasındaki fark nedir?”

Copilot bunun üzerine size; yapı ( *structure* ), esneklik ( *flexibility* ), kullanım senaryosu ( *use case* ), performans ( *performance* ) ve sadelik ( *simplicity* ) gibi farklı başlıklarda cevap verir.

Bu yerleşik masaüstü arayüzü bu şekilde kullanılabilir.

---

## 🌐 copilot.microsoft.com Üzerinden Kullanım

İkinci yol, `copilot.microsoft.com` adresinden kullanmaktır. Eğer Windows 11 kullanıyorsanız buradan da hızlıca erişebilirsiniz.

Bu arayüz size çok tanıdık gelir çünkü aslında masaüstündekiyle aynı arayüzdür. Örneğin az önce yaptığınız konuşmayı burada da görebilirsiniz.

---

## 🧷 Sidebar Üzerinden Kullanım

Copilot’u kullanmanın en sevilen yolu ise sidebar’dır.

Sağ üst köşedeki Copilot ikonuna tıklarsınız ve gördüğünüz gibi, bu arayüz az önce bulunduğunuz sayfadan bağımsızdır.

Bu çok kullanışlıdır çünkü hangi sayfada olursanız olun Copilot’u açıp o sayfa hakkında soru sorabilirsiniz.

Burada birkaç önemli fark vardır:

* Yanıtları daha  *creative* , *precise* veya *balanced* yapmasını isteyebilirsiniz.
* “Compose” özelliğiyle email taslakları, fikirler, blog yazısı, paragraflar gibi içerikler üretebilirsiniz.
* Lorem Ipsum gibi araçlar yerine hızlıca placeholder içerik üretebilirsiniz.
* Chat geçmişi daha güçlüdür. (Silme gibi seçenekler de vardır.)
* Yeni bir konuşma başlatmak için altta “new topic” kullanılır.
* Extensions kısmından farklı eklentiler açılabilir (Instacart, Kayak, Klarna, Shop, Suno vb.). Kod açısından çok gerekli olmasa da arama seçeneği işe yarayabilir.
* “Search” seçeneği web araması yaparak ek bilgi getirebilir. Bazen faydalı, bazen değil. İstenmeyen bilgi çekiyorsa chat başlamadan önce kapatmak gerekir.

---

## 🛠️ Copilot ile CRUD API Üretme Denemesi

Şimdi chat arayüzünü kullanarak .NET ile user’lar üzerinde çalışan yeni bir CRUD API oluşturmaya çalışalım.

Copilot’a “CRUD API kodu ver” dediğinizde, bazen yanlış context ile cevap verebilir. Örneğin Node.js, Express ve MongoDB ile bir örnek üretirse bu tamamen JavaScript olur ve istediğiniz şey değildir.

Bu noktada **context** kavramı önemlidir.

Copilot dünyayla ilgili genel bir bağlama sahiptir ama sizin kafanızdakini bilemez. Bu yüzden, tıpkı bir insanla çalışır gibi, Copilot’a ihtiyacınız olan bilgileri açıkça vermelisiniz:

* Ne inşa ediyorsunuz?
* Gereksinimler neler?
* Tasarım parametreleri var mı?
* Ne kullanmak istiyorsunuz?
* Veritabanı var mı?
* Auth gerekli mi?

Hatta bazen Copilot’tan “clarifying questions” sormasını istemek bile faydalıdır.

---

## 🧾 Gerekli Context’i Vererek Doğru Sonuç Alma

Örneğin şöyle bir ek bilgi verirsiniz:

* C#
* ASP.NET Core
* Minimal APIs (controller yok)
* Database yok, list kullanılacak
* Endpoint’ler user objeleri üzerine kurulacak
* User: `UserName` ve `UserAge` içeriyor
* Authentication yok
* Ek özellik yok

Bu bilgilerle Copilot çok daha doğru bir cevap üretir.

Bu sefer:

* Proje oluşturma komutlarını verir
* Minimal API yapısını kullanır
* `builder` ve `app` ile pipeline kurar
* İçinde bir `List<User>` tanımlar (hatta pre-populate edebilir)
* Get all / Get by username / Post / Put / Delete endpoint’lerini üretir

Kod içinde `FirstOrDefault` veya ternary gibi yapılar görürseniz, o satırı Copilot’a sorup açıklatabilirsiniz.

---

## ⚠️ Kodları Çalıştırmadan Önce Okuma

Üretilen kodu Visual Studio’da veya VS Code’da projenize yapıştırmadan önce okumanız gerekir.

Anlamadığınız kodu çalıştırmamalısınız; bu tehlikeli olabilir.

Bu senaryoda kod genelde güvenlidir (file system erişimi vb. yok gibi görünür) ama yine de kontrol edilmelidir.

Bazı durumlarda Copilot modern pratikleri kaçırabilir. Örneğin `UserName` için `required` eklenmesi gerekebilir ve siz bunu düzeltirsiniz.

---

## 🧪 Test İçin requests.http Dosyası Ürettirme

API’yi test etmek için Copilot’tan bir `requests.http` dosyası oluşturmasını isteyebilirsiniz.

Copilot size örnek olarak şunları üretebilir:

* Get all users
* Get user by username
* Create user (POST)
* Update user (PUT)
* Delete user (DELETE)

Burada dikkat edilmesi gereken nokta: Copilot port numaranızı bilemez.

Örneğin `http://localhost:5000` yazdıysa, sizin uygulamanız `5183` gibi bir portta çalışıyor olabilir.

Bu yüzden VS Code’da çoklu seçim (ör. `Ctrl+D`) ile tüm portları kendi port numaranızla değiştirirsiniz.

---

## ✅ Sonuç

Bu şekilde:

* Copilot’tan kod ürettiniz,
* Kodunuzu kontrol edip küçük düzeltmeler yaptınız,
* API’yi ayağa kaldırdınız,
* HTTP istek dosyası ile endpoint’leri test ettiniz,
* CRUD akışının doğru çalıştığını gördünüz.

Küçük ve iyi tanımlanmış projelerde Copilot özellikle çok güçlüdür. Proje büyüyüp birçok dosyaya yayıldığında iş zorlaşabilir; bu durumda GitHub Copilot’un VS Code içindeki entegrasyonu daha faydalı olabilir.

Bu bölümün ana noktası: Copilot’a problemi çözebilmesi için her zaman gerekli  **context** ’i vermek gerekir.
