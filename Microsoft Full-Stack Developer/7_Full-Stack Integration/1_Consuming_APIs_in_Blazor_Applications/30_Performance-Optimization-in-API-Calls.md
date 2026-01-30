## 🚀 API Çağrılarında Performans Optimizasyonu

Verimli uygulamalar sadece daha hızlı değildir. Kullanıcıları bağlı tutan sorunsuz bir deneyim sağlarlar. Uygulamanızın sunucuyla iletişimini optimize etmek, performansı ve güvenilirliği dönüştürebilir ve Blazor uygulamanızın öne çıkmasını sağlar.

Bu videoda, Blazor uygulamalarının performansını artırmak için API çağrılarını optimize etme stratejilerini açıklayacağız. Önce bazı yaygın performans optimizasyon stratejilerini inceleyelim.

---

## 🧠 API Yanıtlarını Cache’lemek

API yanıtlarını cache’lemek, sunucu için gereksiz işi azaltarak uygulamanızın performansını artırmanın basit bir yoludur.

API yanıtlarını cache’lemek; bir API’nin döndürdüğü veriyi, tekrarlanan istek ihtiyacını azaltmak için geçici olarak depolamak anlamına gelir.

Yanıtların yerel bir kopyasını tutarak, uygulamanız sunucuya tekrar çağrı yapmadan veriyi hızlıca geri alabilir. Bu yaklaşım:

* tekrar eden istekleri minimize eder,
* performansı artırır,
* sunucu yükünü azaltır,
* kullanıcılar için daha hızlı ve tepkisel deneyimler sağlar.

Cache kullanmaya başlamak için önce hangi verilerin yerel olarak saklanacağını belirlemeniz gerekir.

Kullanıcıların sık talep ettiği verileri belirleyin; örneğin ürün listeleri gibi, ve bunları yerelde saklayın. Örneğin, hava durumu verisini cache’lemek aynı tahmini tekrar tekrar indirmeyi engeller.

Veri depolandıktan sonra, ne sıklıkla yenilenmesi gerektiğini tanımlamak önemlidir. Cache’lenen verinin ne zaman güncelleneceğine dair kurallar belirleyebilirsiniz.

Örneğin, canlı spor skorlarını her dakika güncelleyin; ama ürün kategorilerini tüm oturum boyunca cache’te tutun.

Blazor uygulamaları cache’i shared service’ler veya local storage kullanarak uygulayabilir.

---

## 📄 Büyük Veri Setlerini Yönetmek için Pagination

Cache, gereksiz tekrar istekleri azaltır; ama büyük veri setlerini verimli yönetmek için **pagination** yardımcı olur.

Pagination, büyük veri setlerini daha küçük, yönetilebilir parçalara bölme sürecidir.

Her istekle sınırlı sayıda öğe taşınmasını sağlayarak, uygulamanızın tek seferde aşırı veri yüklemesini engeller. Bu yaklaşım:

* yükleme sürelerini ciddi şekilde iyileştirir,
* bant genişliği kullanımını azaltır,
* veriyi daha düzenli ve sindirilebilir biçimde sunarak kullanıcı deneyimini artırır.

Bu stratejiyi uygulamak için, aynı anda verinin yalnızca bir kısmını gösterin; örneğin sayfa başına 10 öğe.

Örneğin, ilk etapta 10 ürün yorumunu yükleyin ve gerekirse daha fazlasını yükleme seçeneği sunun.

Pagination, Blazor’da API’den sayfalı veri isteyen data grid’ler veya listeler ile uygulanabilir.

Pagination’i uygulamanın bir başka yolu da kullanıcıların butonlarla (*next* /  *previous* ) veya kaydırarak ek verilere geçmesini sağlamaktır.

Örneğin, bir fotoğraf galerisinde kullanıcılar *next* seçerek bir sonraki görsel setine geçebilir.

---

## ⛔ Sık İsteklerden Kaynaklı Yük için Rate Limiting

Pagination büyük veri setlerini yönetir; ancak sık API istekleri sunucuyu zorlayabileceği için bir **rate limiting** stratejisi de uygulanabilir.

Rate limiting, API istek sıklığını kontrol etmek için kullanılan bir tekniktir. Belirli bir zaman aralığında bir istemcinin kaç istek yapabileceğine limit koyar.

İstek oranlarını düzenleyerek rate limiting:

* sunucu aşırı yüklenmesini önler,
* sistemin stabil ve tepkisel kalmasını sağlar,
* adil kullanım sağlar; yani tek bir istemcinin kaynakları tek başına tüketmesini engeller.

Bu stratejiyi uygulamak için, istek sıklığını azaltın ve yalnızca gerektiğinde istek yapın; istekleri birleştirerek veya geciktirerek.

Örneğin, profil görsellerini tek tek almak yerine batch hâlinde yükleyin.

Ayrıca, API sağlayıcısının istek limitlerini izleyip buna göre ayarlayarak rate limiting uygulayabilirsiniz.

Örneğin, API dakikada 100 isteğe izin veriyorsa; gecikmeler ekleyin veya limite ulaşıldığında kullanıcıya bir mesaj gösterip daha sonra tekrar denemesini isteyin.

---

## ✅ Özet

Bu videoda, Blazor uygulamalarında performansı artırmak için API çağrılarını optimize etme stratejilerini öğrendiniz.

Bu stratejiler birbirini tamamlayarak:

* gereksiz tekrar çağrıları,
* büyük veri setleri,
* sunucu aşırı yüklenmesi

gibi sorunları etkili biçimde yönetmenizi sağlar.
