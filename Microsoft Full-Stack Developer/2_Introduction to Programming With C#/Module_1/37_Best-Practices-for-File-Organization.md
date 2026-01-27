## 🗃️ Dosya Organizasyonu İçin En İyi Uygulamalar

Kullanıcıların evcil hayvanlarının fotoğraflarını yükleyebildiği bir .Net projesi geliştirdiğinizi hayal edin. Proje büyüdükçe, net bir yapı olmadan kodu yönetmek zorlaşır. Tıpkı iyi organize edilmiş bir kütüphanenin kitap bulmayı kolaylaştırması gibi, kodunuzu yapılandırılmış dosya ve klasörlere ayırmak projenizi yönetilebilir ve verimli tutmaya yardımcı olur. Bu videoda, bir .NET projesinde dosyaları organize etmek için en iyi uygulamaları açıklayacağız. .NET’in derleme sürecini yönetmek için **bin** ve **obj** gibi klasörleri otomatik olarak oluşturduğunu söylemiştik; ancak bunun ötesinde, dosyalarınızı organize etme konusunda oldukça esneksiniz.

Bunu yapmanın birçok yolu vardır, ancak amaç kodu anlaması, üzerinde çalışması ve bakımını yapması kolay hâle getirmektir. İyi kod organizasyonu, siz dâhil ekibinizdeki herkesin neler olup bittiğini takip etmesine yardımcı olur. Bir kitap okumak gibi, kod da net olmalıdır; çünkü çoğu zaman yazılmaktan daha fazla okunur.

---

## 🧠 Sorumlulukların Ayrılması

Kodu ayırmanın bir yöntemi **separation of concerns** olarak adlandırılır. Yazılım geliştirmede bu tasarım ilkesi, bir programı her biri uygulamanın belirli bir yönünden veya işlevinden sorumlu olan ayrı bölümlere ayırmayı içerir. Proje büyüdükçe, her şeyi düzenli tutmak için klasörlere de ihtiyaç duyabilirsiniz. **Özelliklere (features) göre** veya **katmanlara (layers) göre** organize edebilirsiniz.

---

## 🐾 Özelliklere Göre mi, Katmanlara Göre mi?

Evcil hayvan fotoğraf projemize geri dönelim. Uygulamanın ana parçaları, kullanıcıların evcil hayvan fotoğrafları ve yorumlarıdır; bunlara **features** denebilir. Kodu her özellik için ayrı dosyalar oluşturarak organize edebilirsiniz. Ancak her özellik, veriyi bir veritabanında saklamak veya ekranda göstermek gibi farklı görevleri yerine getiren kodlar içerir. Bu yüzden her özellik için kodu; veritabanı işleri, görüntüleme işleri ve bunları birbirine bağlayan ara kod için dosyalara ayırabilirsiniz.

Örneğin, **özelliklere göre** organize etmek; kullanıcıyla ilgili tüm kodun (veritabanı, görüntüleme vb.) bir arada kalması anlamına gelir. **Katmanlara göre** organize etmek ise kodu rolüne göre gruplamaktır; tüm özellikler için veritabanı kodu, görüntüleme kodu vb. ayrı klasörlerde olur. Organize etmenin tek bir doğru yolu yoktur.

Genellikle başlangıç projelerinden veya topluluk projelerinden örnekleri takip etmek yardımcı olur. Ayrıca, kodu başka projelerde yeniden kullanmayı planlıyorsanız, onu kolayca kopyalanabilecek veya yeniden kullanılabilir bir modül olarak yüklenebilecek bir klasöre koymayı düşünebilirsiniz. **src** (source diye okunur), bir projede derlenmemiş kodun bulunduğu klasör için yaygın bir addır.

---

## 🏷️ İsimlendirme Kuralları

Dosyalarımızı organize ettikten sonra, bir sonraki adım; dosyaların netliği ve sürdürülebilirliği artıracak şekilde adlandırıldığından emin olmaktır. İsimlendirme önemlidir; çünkü başkalarının ve gelecekteki sizin, kodun ne yaptığını anlamasına yardımcı olur. .NET’te yaygın bir uygulama, dosya adları ve değişkenler için **Pascal** ve **Camel case** kombinasyonunu kullanmaktır.  **Pascal case** ’te kelimeler birleştirilir, ancak her kelime büyük harfle başlar.

 **Camel case** , neredeyse aynıdır; tek fark ilk harfin küçük olmasıdır. C#’ta sınıf adları, metotlar ve özellikler gibi çoğu tanımlayıcı (identifier) **Pascal case** kullanır. **Camel case** ise genellikle private alanlar, metot parametreleri ve yerel değişkenler için kullanılır. Bu ayrım, C# kodu içinde netlik ve tutarlılık sağlamaya yardımcı olur. Ayrıca bunun C# sözdiziminin bir kuralı değil, bir **konvansiyon** olduğunu da belirtmek isterim. Bu isimlendirme konvansiyonları geliştirici forumlarında sık tartışılan bir konudur; ancak açık ve açıklayıcı isimler seçmek, belirli bir konvansiyonu takip etmekten daha önemlidir. İsimlendirme, düşünmeyi gerektiren bir beceridir.

Amaç, başka bir geliştiricinin yalnızca okuyarak kodunuzun ne yaptığını anlayabilmesidir. Örneğin `num` adlı bir değişken belirsiz ve net değildir. Hangi sayıyı ifade ediyor? Daha iyi bir isim `userAge` olabilir; bu hemen bunun bir kullanıcının yaşıyla ilgili olduğunu söyler. Daha kısa isimler yazmak daha hızlı olsa da, daha uzun ve açıklayıcı isimler kodunuzu anlamayı kolaylaştırır. Eğer değişken, kullanıcının gerçek yaşından ziyade hesabının yaşını temsil ediyorsa, `userAccountAge` gibi bir isim daha da kesin olur.

---

## 🧹 Refactoring

Projeniz büyüdükçe, kodu yeniden organize etmeniz veya iyileştirmeniz gerekebilir; buna **refactoring** denir. Refactoring, davranışını değiştirmeden mevcut kodun yapısını ve okunabilirliğini iyileştirmektir. Refactoring’in amacı kodu daha temiz, daha verimli ve bakımını daha kolay hâle getirmektir. Yaygın bir söz şudur: **make it work, make it right, make it fast.** Önce kodun basit bir sürümünü çalışır hâle getirmeye odaklanın, sonra zaman içinde geliştirin. En baştan mükemmel kod yazma konusunda endişelenmeyin; daha önemli olan, çalışan bir şeye sahip olmak ve onu daha sonra iyileştirebilmektir.

---

## 📝 Dokümantasyon

Kodunuz iyi bir dosya yapısı içine organize edildikten ve kod dosyalarının kendisi de iyi yazıldıktan sonra, dokümantasyonu düşünmek faydalıdır. Bunun bir yolu, projenize bir **README** dosyası eklemektir. Bu, projeye genel bir bakış sağlayan ve koda yeni başlayan herkes için değerli bir rehber olan harici bir dosyadır.

Kodu, **yorumlar (comments)** ekleyerek de belgeleyebilirsiniz. Bunlar dosya içinde yer alan, kod olarak yorumlanmayan satır içi metinlerdir. Bilgisayarlardan ziyade insanlar tarafından okunmaları için vardır. Dokümantasyona nasıl yaklaşılması gerektiği konusunda farklı görüşler vardır. Bazı geliştiriciler, kodun anlaşılmasını sağlamak için çok sayıda yorum kullanmayı savunur. Ancak kod değiştiğinde yorumlar güncelliğini yitirip kafa karışıklığına yol açabilir; çünkü yorumlar artık kodu doğru yansıtmayabilir.

Öte yandan bazı geliştiriciler, tamamen yorumsuz bir yaklaşımı benimser ve kendini açıklayan kadar net kod yazmaya odaklanır. Bu yaklaşım birçok durumda iyi çalışır, ancak bazen yalnızca kod, belirli kararların arkasındaki nedenleri tam olarak yansıtamaz. Genellikle dengeli bir yaklaşım en iyisidir. Kodunuzu mümkün olduğunca açık yazın, ancak özellikle önemli kararlar için ekstra açıklama gerektiğinde yorum eklemekten çekinmeyin.

Kodunuzu düzenli ve iyi belgelenmiş tutmak, başkalarının sizinle çalışmasını ve sizin de daha sonra geri dönüp bakmanızı kolaylaştırır. Net, anlaşılır kod, başarılı bir geliştirici olmak için kritiktir.
