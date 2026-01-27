## 🧑‍💻 Bir Back-End Mühendisinin Günlük Hayatı

Merhaba, benim adım  **Avininder Parichuri** . Microsoft’ta  **Principal Engineering Manager** ’ım. **Microsoft Entra gateway** servisinin sorumluluğunu yürütüyorum. Bu, kimlik doğrulama yığınına (authentication stack) internete açık tüm trafiği alan gateway’dir. Daha önce bu **Azure Active Directory** olarak biliniyordu ve şu anda  **Microsoft Entra** .

.NET temelde çalıştırdığımız her servistir; benim ekibimin sahip olduğu servislerin tamamı .NET tabanlı servislerdir.

---

## 🧱 Kullandığımız .NET Sürümü ve Sunucu Seçimi

Özellikle **.NET 8** üzerinde çalışıyoruz; bu, en güncel **LTS (long-term support)** sürümüdür. **HTTP Sys Server** üzerinde çalışıyoruz.

.NET üzerinde çalıştığınızda temel olarak üç farklı sunucuda çalışabilirsiniz:  **Kestrel** , **HTTP Sys** ve  **IS** . Biz  **HTTP Sys Server** ’ı seçtik çünkü **TLS performansı** gerçekten çok iyi. Evet, kurulumumuz temelde bu şekilde.

---

## 🔐 Serialization / Deserialization İçin Kritik Tavsiye

Ana konulardan biri şu:  **kendi serializer ve deserializer’larınızı yazmayın** . Gerçekten ne yaptığınızı çok iyi bilmiyorsanız, her zaman standart kütüphaneleri kullanın ve kendiniz yazmaya çalışmayın. Bu şekilde, bu konularla uğraşırken güvenliği ve verimliliği sağlıyoruz.

Yine,  **input sanitization** ,  **boyut (sizing) limitleri** , belirli bir limitin ötesinde serialize/deserialize etmemek, **sınırsız recursion’a izin vermemek** gibi konular.

Ayrıca Microsoft’ta **Component Governance** adında bir araç setimiz var. Bu bir  **statik analizör** . Bilinen zafiyetleri olan şeyleri işaretliyor ve “şunu kullanma, bunu kullanma” diyor; biz düzeltip çözene kadar da bizi uyarıp duruyor ya da o bileşeni hiç kullanmamamızı söylüyor.

Buna yakın bir örnek: yakın zamanda  **.NET 6** ’da serialization için kullanılan **binary formatter** kullanımdan kaldırıldı (deprecated) ve Component Governance bize “bunu kullanma çünkü bilinen bir zafiyeti var” dedi.

---

## 🩹 Güvenlik İçin .NET Patch’lerini Güncel Tutma

Bir diğer önerim: her zaman, her zaman — .NET geliştirme bağlamında konuşuyorum — **en son .NET patch’ini** kullanın. .NET ekibi, bilinen zafiyetleri yamalama ve düzeltme konusunda gerçekten çok iyi.

Eğer zafiyetli olmak istemiyorsanız ve gerçekten güvenli olmak istiyorsanız, yalnızca serialization/deserialization bağlamında değil genel olarak da, **en güncel .NET patch’ini** (aylık patch) kullanmak servislerinizin güvenliği ve sağlamlığı açısından çok, çok faydalı olacaktır.

---

## 🐛 Karmaşık Bug’ları Çözmenin Anahtarı: Repro

Karmaşık bir bug’ı gerçekten çözmenin ana şeylerinden biri, o bug’ı **istek üzerine (on demand) yeniden üretebilme** becerisidir, değil mi? Müşterinin yeniden üretmesi değil; sizin o bug’ı istek üzerine yeniden üretebilmeniz.

Bu iki şeye yardımcı olur: birincisi, bug’ın iç dinamiklerini gerçekten anlayabilirsiniz; ikincisi, düzeltince gerçekten düzeldiğini doğrulayabilirsiniz. Yoksa, düzeldiğini nereden bileceksiniz?

Düzelttiğinizi düşünürsünüz ama aslında düzeltmemişsinizdir. Çoğu zaman mühendislerin, bir bug’ın belirli bir yerde olduğunu varsaydığını görüyorum çünkü öyle görünüyor; onu “düzeltiyoruz” ve birkaç hafta sonra aynı sorun tekrar oluyor çünkü gerçekte bug’ı düzeltmedik. Aslında repro etmedik. Bug’ın o olduğunu düşündük ve gerçek bug’ı düzeltmedik.

Bu yüzden insanlara her zaman, ne kadar zor olursa olsun, bug için **on-demand repro** oluşturmalarını söylerim. Bazen “sadece production’da oluyor” gibi şeyler duyuyorum ve bu doğru olabilir. Ama işte disiplin burada devreye giriyor. Aynı koşulları yaratmanız gerekir ve bunu yeniden üretmek çok zaman alabilir.

Bazen haftalar bile sürebilir ve bu da sorun değil; ama gerçekten iyi bir repro elde edene kadar uğraşmaya devam etmelisiniz. Bu, iyi bir root cause ve çözümün gerçekten anahtarıdır.

---

## 🗑️ Örnek Olay: GC Baskısı ve Allocation Problemi

Yakın zamanda, servisimizde ciddi garbage collector sorunlarına ve performans problemlerine neden olan karmaşık bir veri indirme (data download) problemi yaşadık; bu da request queuing, latency ve benzeri problemlere yol açıyordu.

Bu veri indirme problemi nedeniyle, allocation sayısının artması yüzünden çok fazla **Gen 2 garbage collection** (biz böyle adlandırıyoruz) çok sık tetikleniyordu. Allocation’lar da, veri indirmeyi düzgün yönetmiyorsanız ortaya çıkar, değil mi? Sonuç olarak sistemde çok fazla **generational promotion** oluyordu; bu da sistemde “kötülüğe” yol açar, değil mi?

Bunun için bulduğumuz çözüm şu: garbage collection problemleri her zaman allocation rate’lerinin yükselmesiyle birlikte gelir. Bu yüzden gerçekten **allocation-free code** yazmamız gerekiyordu; her seferinde bellek oluşturmak yerine **memory pooling** ile mevcut belleği havuzdan kullanmaya başladık.

Ve bu şekilde, şu noktada o problemden tamamen kurtulduk. Yine aynı şeyi yaptık: sistemin repro’sunu elde etmek zorundaydık, trace’ler almak zorundaydık; production’dan trace’ler aldık, sonra repro olduğunu düşündüğümüz yerden trace’ler aldık ve trace’leri eşleştirerek gerçekten düşündüğümüz bug’ı düzelttiğimizden emin olduk. Ve evet, bug’ların nasıl fix edildiği ve root cause edildiğinin yaşam döngüsü temelde böyle.

---

## 📚 Takip Ettiğim Kaynaklar

Örneğin engineering blog’ları; **Netflix engineering blog’ları** harika bir kaynak. Önceki cevapta garbage collection’dan bahsettim ve yakın zamanda Netflix engineering ekibinin yazdığı bir garbage collector makalesini okuyordum; pooling ve daha düşük allocation’lar konusunda bizim yaptığımız şeylerin aynısını anlatıyorlardı; bu da konulardan biri.

Diğer kaynaklar  **.NET blog’ları** . .NET çok sık harika blog’lar yayımlıyor ve bu da teknoloji anlayışınızı geliştiriyor.

Ayrıca  **David Fowler** ,  **Stephen Tobe** , **Mayoni Stephens** gibi kişileri oldukça düzenli takip ediyorum. Bunlar çok, çok üst düzey .NET mühendisleri ve sık sık blog yazıyorlar. Blog’larını ve makalelerini yer imlerine ekliyorum ve bir şey yazdıklarında aynı gün okumaya gidiyorum. Evet, en güncel ve en iyi şeyleri takip etme yollarımdan bazıları bunlar.

---

## 🤝 İş Birliği ve Geri Bildirim Döngüsü

İş birliği aynı. Front-end geliştirici ya da DevOps ekibi fark etmiyor. Tüm ekiplerle aynı şekilde iş birliği yapıyoruz.

Ortak, hizalanmış bir hedef ve vizyona sahip olduğumuzdan emin oluyoruz ve bunun üzerinde birlikte çalışıyoruz.

Büyük bir rol de, dediğim gibi, **forking** — bu temelde müşterilerden gelen geri bildirim, değil mi? Ayrıca birçok şeyi Kanada bölgelerinde pilotluyoruz. Müşteriler ve client’larla sıkı bir entegrasyon döngümüz var; böylece beklentilerimizle ilgili olarak her şeyin çalıştığından emin oluyoruz. Gerçekten müşterilerin ve client’ların hayatını beklediğimiz gibi mi iyileştiriyor? Yoksa “bu harika bir şey” diye düşündüğümüz şey sadece bizim kafamızda mı?

Bu bizim için çok değerli bir geri bildirim.

Aşamalı rollout’larımız (stage rollout) da geri bildirimi süreçlerimize hızlıca entegre etmemizi sağlıyor. Aslında .NET ekibi de bunu yapıyor. Çeşitli sürümlerini büyük first party müşterilerde pilotluyorlar; böylece yayımladıkları ürünlerin ya da iyileştirmelerin production’da gerçekten iyileşme sağlayıp sağlamadığını, kâğıt üzerinde kalıp kalmadığını doğruluyorlar.

Evet, bu aşırı derecede önemli.
