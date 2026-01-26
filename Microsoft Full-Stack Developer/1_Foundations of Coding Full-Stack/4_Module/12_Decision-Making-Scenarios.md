## 🧠 Decision-Making Scenarios

Bir geliştirici olarak, gerçek hayattaki günlük problemleri çözmek için *if-else ifadeleri* ve *switch ifadeleri* gibi kontrol yapıları kullanan programlar oluşturacaksınız.

Bu videoda, kontrol yapıları kullanarak karar verme senaryolarını nasıl çözeceğimizi öğreneceğiz. *If-else ifadeleri* ve *switch case’ler* gibi kontrol yapıları, belirli koşullara bağlı olarak kodun yürütülme akışını belirleyen ifadelerdir.

Şimdi, bunların nasıl çalıştığını inceleyelim. Bu koşullu ifadelerin kodumuzda kritik kararlar almamıza yardımcı olduğu birkaç gerçek dünya senaryosunu ele alacağız.

Bir teknoloji girişiminin envanteri yönetmek istediğini düşünün. Programın, mevcut stok seviyesine bağlı olarak bir ürünü yeniden sipariş edip etmeyeceğine karar vermesi gerekir.

Ardından, girişimin siparişleri işlemesi gerekir. Kargo yöntemi, müşterinin konumuna göre belirlenmelidir.

Son olarak, toplam satın alma tutarına ve müşterinin üyelik durumuna göre indirim oranlarını uygulayacağız.

Bu senaryoları çözmek için *if-else ifadeleri* ve *switch ifadeleri* kullanacağız.

---

## 📦 Senaryo 1: Stok Seviyesine Göre Yeniden Sipariş

İlk senaryoda, stok seviyesine bağlı olarak bir ürünü yeniden sipariş edip etmeyeceğimize karar vermemiz gerekiyor. Bunu bir if-else ifadesi kullanarak şöyle uygulayabiliriz.

Önce, stok seviyesinin yeniden sipariş eşiğinden düşük olup olmadığını değerlendirmeliyiz.

Eğer düşükse, ürünü yeniden sipariş etmeliyiz. Aksi takdirde, bir `"else"` ifadesi kullanarak mevcut stoğu koruruz.

---

## 🚚 Senaryo 2: Konuma Göre Kargo Yöntemi Belirleme

Envanter yönetimiyle çalıştıktan sonra, sıradaki zorluk siparişleri işlemektir. Kontrol yapılarının, müşterinin konumuna göre en iyi kargo yöntemini belirlememize nasıl yardımcı olabileceğini inceleyelim.

Bunu C# kullanarak bir switch ifadesiyle nasıl uygulayabileceğimizi adım adım ele alalım.

Öncelikle switch ifadesini oluştururuz ve ifade (expression) olarak `"location"` kullanırız.

Ardından, müşterinin konumu için olası değerleri değerlendirir ve her case için davranışı oluştururuz.

* Müşterinin konumu `"local"` ise, yerel kargo yöntemini uygulamalıyız.
* Konum `"domestic"` ise, ülke içi kargo yöntemini uygularız.
* Konum `"international"` ise, uluslararası kargo yöntemini uygularız.

Ayrıca bir *default case* de ekleyebiliriz. Bu, konum belirtilen konumlarla eşleşmezse yönetmek için bir eylem sağlar.

Bu örnekte, program default case olarak standart kargo yöntemini uygular.

---

## ✅ Video Özeti

Bu videoda, kontrol yapıları kullanarak karar verme senaryolarını nasıl çözeceğinizi öğrendiniz.

Değişken değerlerini ve program durumlarını değerlendirmek için if-else ifadelerini ve switch ifadelerini kullanmayı inceledik.

Kontrol yapıları, karmaşık karar verme süreçlerini yönetmek ve açık, verimli kod yazmak için gereklidir.
