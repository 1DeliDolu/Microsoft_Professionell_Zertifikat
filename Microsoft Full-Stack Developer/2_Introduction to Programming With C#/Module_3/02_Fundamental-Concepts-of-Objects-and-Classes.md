
## 🧱 Nesneler ve Sınıfların Temel Kavramları

Biyolojideki disiplinlerden biri sınıflandırmadır. Bilim insanları, hayvanları belirli özelliklere göre gruplandırarak zebra, pelikan ve insan gibi sınıflar oluştururlar. Bu sınıfların içinde, çizgiler, gagalar ve karşıt başparmaklar gibi sınıftaki diğer üyelerin özelliklerini paylaşan bireysel zebralar, pelikanlar ve insanlar bulunur.

Sınıflandırma, bilim insanlarının araştırmalarını yönetmesine, hayvanların nasıl benzer ve farklı olduğunu anlamasına ve hatta davranışlarından ne bekleyeceklerini bilmesine yardımcı olur. Bilgisayar bilimcileri, bu kavramların birçoğunu *nesne yönelimli programlama* ya da *OOP (object-oriented programming)* adı verilen bir programlama modeline uyarlamıştır.

Bu videoda, OOP’deki nesneler ve sınıfların temel kavramlarını açıklayacağız. Nesneler ve sınıflar, nesne yönelimli programlamanın temel kod yapı taşlarıdır.

---

## 🧬 Sınıf–Nesne İlişkisi

Kod tabanlı sınıflar ve nesneler, bir hayvanın ait olduğu sınıfla ilişkisine benzer şekilde ilişkilidir. Bir nesneyi, belirli bir zebra gibi sınıfın bireysel bir şeyi ya da bir örneği ( *instance* ) olarak düşünün.

Sınıf ise bir tür tanımdır. Ortalama bir zebranın sahip olduğu tüm özellikleri ve yetenekleri açıklar.

Bu kavramları, bir sınıfın tanımından başlayarak daha ayrıntılı inceleyelim.

---

## 🧩 Sınıf Tanımı

Sınıf, bir grup şey için paylaşılan özellikler ve davranışlar kümesini tanımlayan bir plan ( *blueprint* ) veya şablondur ( *template* ).

Kod sınıfları, biyoloji ya da botanikteki sınıflara benzer; çünkü bireysel kod nesnelerinin özelliklerini ve neler yapabileceklerini tanımlar.

---

## 🧰 Sınıfların Özellikleri

Nesne yönelimli programlamada sınıflar, tek başlarına çok fazla iş yapamaz. Bir programcı veri işleyemez, kullanıcıyla etkileşime giremez veya API çağrıları gönderemez; ancak bir sınıf, tüm bunların nasıl yapılacağına dair bir şablon sağlar.

Özellikle, bir sınıfı tanımlayan üç ana özellik vardır.

---

## 🧾 Özellikler

Geliştiricilerin sınıflarda tanımladığı ilk özellik  *özelliklerdir (properties)* . Bunlar, bir nesnenin sakladığı veya ayarladığı bireysel veri öğeleridir.

Örneğin bir kimlik doğrulama sınıfı, *username* ve *password* gibi özellikler tanımlayabilir.

---

## ⚙️ Metotlar

Sınıflar ayrıca *metotları (methods)* tanımlar; bunlara davranışlar ( *behaviors* ) veya fonksiyonlar ( *functions* ) da denir.

Metotlar, sınıfın gerçekleştirebileceği davranışlardır. Örneğin, *login* sınıfı, kullanıcının kimlik bilgilerini kontrol eden *validate* gibi metotlar ve kullanıcıya sisteme erişim sağlayan *login* gibi metotlar tanımlayabilir.

---

## 🧬 Kalıtım

Son olarak, *kalıtım (inheritance)* adı verilen bir özellik aracılığıyla sınıflar genişletilerek, ebeveyn sınıftan özellikleri ve davranışları miras alan alt sınıflar ( *subclasses* ) oluşturulabilir; tıpkı biyolojideki yavrular gibi.

Bu özellik, geliştiricinin gömülü ve düzenli kodu yeniden kullanmasını sağlar. Örneğin bir geliştirici, *login* sınıfını miras alarak özelliklerini ve metotlarını yeniden kullanabilir; ancak kullanıcı oturum açtıktan sonra arayüzde gösterebileceği *display name* adlı yeni bir öznitelik ekleyebilir.

---

## 🏗️ Örnekleme

Sınıflar yalnızca tanım olduklarından, iş yapabilmeleri için geliştiricilerin onların çalışan bir sürümünü oluşturması gerekir.

Bu işleme *örnekleme (instantiation)* denir ve süreç, sınıfın bireysel nesnelerini ya da örneklerini ( *instances* ) oluşturur.

---

## 🧍 Nesne Tanımı

Bir nesne, karakteristiklerini ve eylemlerini tanımlayan benzersiz özelliklere ve davranışlara sahip ayrı bir şeydir.

Kod nesneleri, diğer tür nesneler gibi; özellikleri ve bir program içinde yapabildikleri şeylerle tanımlanır. Kod nesneleri, örneği oldukları sınıfın tüm özelliklerine ve metotlarına sahiptir.

Nesnenin özellikleri, sınıf içinde değişkenlerle tanımlanan, nesneyle ilişkili veri öğeleridir. Metotları ise nesnenin gerçekleştirebileceği işlemler ya da fonksiyonlardır; sınıftaki metotlarla tanımlanır.

---

## 🆔 Nesnenin Kimliği ve Durumu

Nesnelerin, onları ebeveyn sınıflardan ayıran birkaç başka özelliği daha vardır. Her nesnenin program içinde benzersiz bir kimliği bulunur; bu genellikle bellek adresi veya benzersiz bir tanımlayıcı ile temsil edilir.

Nesneler sınıfların örnekleri olduğu için geliştirici, ihtiyaç duyduğu kadar nesne oluşturabilir ve her biri uygulama içinde benzersiz şekilde tanımlanır.

Nesnenin durumu ( *state* ), özelliklerinin mevcut değerleri tarafından belirlenir. Örneğin bir *login* nesnesinin durumu, şu anda *username* ve *display name* için tuttuğu değerleri içerebilir.

---

## 🧬 Kalıtımın Nesnelere Etkisi

Bir nesne, geliştirici sınıfı kalıtımla genişletmedikçe, yalnızca ebeveyn sınıfında tanımlananları yapabilir. Ardından miras alınmış bir sınıfla oluşturulan bir nesne; yeni özellik ve metotların yanı sıra ebeveyn sınıftaki orijinal olanlara da sahip olur.

---

## 📚 Örnek: Kütüphane Sisteminde Book Sınıfı

Şimdi bu fikirleri, bir kütüphane sisteminde kullanılabilecek bir *book* sınıfı örneğiyle bir araya getirelim.

*Book* sınıfının  *title* , *author* ve *ISBN* gibi özellikleri olabilir.

Ayrıca *borrow* ve *return* gibi metotları da olabilir.

Bu özellikleri ve metotları tanımlayarak, kütüphanedeki belirli bir kitabı temsil eden, her birinin kendi  *title* , *author* ve *ISBN* değerleri olan özel *book* nesneleri oluşturabiliriz.

Bir kitap ödünç alındığında, *borrow* metodu kitabın durumunu güncelleyebilir; bu da OOP’de özelliklerin ve metotların nesnelerin durumunu ve davranışını yönetmek için birlikte nasıl çalıştığını gösterir.

---

## ✅ Sonuç

Nesne yönelimli programlama, verimli ve güçlü bir programlama modelidir. Sınıfları tanımlayarak ve nesneler oluşturarak, geliştiriciler daha kolay sürdürülebilir ve yeniden kullanılabilir kod yazabilirler.
