## 🧭 Durum Yönetimi Kavramlarına Genel Bakış

Alışveriş sepetinizi takip edemeyen, sizi beklenmedik şekilde oturumdan çıkaran veya filtrelerinizi sıfırlayan uygulamalar kullanmak sinir bozucu olabilir. Durum yönetimi, uygulamaların kullanıcı etkileşimlerine tutarlı biçimde uyum sağlamasına, hatırlamasına ve yanıt vermesine olanak tanıyarak bu sorunları önler ve sorunsuz kullanıcı deneyimlerinin temelini oluşturur.

Bu videoda, durum yönetiminin ne olduğunu ve full-stack sistemler içinde zamanla uygulama davranışını nasıl etkilediğini tanımlayacağız.

---

## 🧩 Durum Yönetimi Tanımı

Başlangıç olarak, durum yönetimini tanımlayalım. Durum yönetimi, bir uygulamanın zaman içinde değişen veriyi ya da *durumu (state)* nasıl ele aldığını ifade eder; uygulamanın farklı bölümlerinin aynı bilgiye erişmesini ve senkronize kalmasını sağlar.

Durumun, bir uygulamanın çalışması için belirli bir anda ihtiyaç duyduğu tüm verilerin bir anlık görüntüsü ( *snapshot* ) olduğunu hatırlayın.

Durum yönetimi, bir ofiste paylaşılan bir beyaz tahtayı düzenlemek gibidir. Eğer herkes koordinasyon olmadan yazar, siler ya da güncellerse, her şey kaotik hâle gelir. Ancak net kurallar olduğunda, yani durum yönetimi uygulandığında, herkes aynı güncel bilgiye erişebilir.

---

## 🔑 Durum Yönetimindeki Temel Kavramlar

Bir uygulama kullanıcı etkileşimlerine uyum sağlamak ve yanıt vermek için, uygulamanın durumunu bilmek zorundadır. *Durum (state)* kavramı, duyarlı ( *responsive* ) sistemler inşa etmede temel bir kavramdır.

Durum, herhangi bir anda bir uygulamanın içinde bulunduğu veri ya da mevcut koşuldur. Değişkenlerin, verilerin veya kullanıcı arayüzü bileşenlerinin mevcut durumunu temsil eder.

Durumu, bir uygulamanın hafızası gibi düşünün. Sistem, ne yaptığınızı takip etmesini sağlar ve davranışını buna göre ayarlar. Örneğin, çok adımlı bir form doldururken uygulama, daha önceki adımlarda girdiğiniz bilgileri hatırlar; böylece baştan başlamak zorunda kalmazsınız.

Durum, farklı türde bilgileri takip etmek için kullanılır ve yönetmeniz gereken veri türüne bağlı olarak üç türde organize edilir:  **local** , **session** ve  **global** .

---

## 🧱 Local State

Local state, bir uygulamanın belirli bölümleriyle sınırlı olan veridir; genellikle tek bir bileşen veya ilişkili küçük bir bileşen grubu içinde bulunur.

Bu durum, formlar gibi ön yüz özelliklerini çalıştırmak için kritik öneme sahiptir; bir bileşen, bir alana girilen metin ya da bir onay kutusunun işaretli olup olmadığı gibi giriş değerlerini kendi local state’inde tutabilir.

Örneğin, yalnızca açık mı kapalı mı olduğunu bilmesi gereken bir açılır menüyü ( *drop-down menu* ) düşünün. Bu tür local state hafiftir, odaklıdır ve uygulamanın diğer bölümlerini etkilemez. Bu da akıcı ve verimli etkileşimler sağlar.

---

## 🕒 Session State

Session state, bir kullanıcının bir uygulama veya web sitesiyle olan oturumu boyunca depolanan ve bu süre boyunca kalıcı olan veridir. Uygulamanın, bir formdaki ilerlemeyi birden fazla sayfa boyunca kaydetmek gibi kullanıcı etkinliklerini hatırlamasını sağlar.

Bu, kullanıcının site içinde gezinirken sorunsuz ve tutarlı bir deneyim yaşamasını sağlar.

Örneğin, session state alışveriş sepetindeki öğeleri takip eder. Yalnızca oturum süresince devam eder ve siteden ayrıldığınızda temizlenir.

Bazı web sitelerinde, belirli bir süre boyunca (genellikle sunucu yapılandırmasına bağlı olarak 20 ila 30 dakika) pasif kalırsanız oturum da temizlenebilir.

---

## 🌍 Global State

Global state, uygulamanın birden fazla bölümünde veya bileşeninde erişilebilir olması gereken veridir. Önemli verilerin—örneğin bir kullanıcının oturum açma durumu gibi—kullanıcı uygulamanın neresinde olursa olsun tutarlı ve erişilebilir kalmasını sağlar.

Örneğin, global state sayfalar arasında gezinirken oturumunuzun açık kalmasını sağlar ve tutarlı, sorunsuz bir kullanıcı deneyimi sunar.

---

## 🛒 Gerçek Dünya Örneği: E-Ticaret Platformu

Durum yönetimi için kavramları ve araçları ele aldığımıza göre, şimdi bunların gerçek dünyada nasıl birlikte çalıştığını inceleyelim.

Kullandığınız bir e-ticaret platformunu düşünün. Sorunsuz bir alışveriş deneyimi oluşturmak için tüm durum türlerine dayanır.

Örneğin, local state küçük görevleri yönetir; üzerine geldiğinizde ürün görselleri arasında geçiş yapmak gibi. Bu sırada session state, farklı sayfalarda gezinirken alışveriş sepetinizdeki ürünleri takip eder. Son olarak global state, oturumunuzun açık kalmasını ve tercihlerinizi site boyunca hatırlanır şekilde tutar.

Bu tür bir durum yönetimi, uygulamaların kullanıcılar için duyarlı, sezgisel ve keyifli kalmasını sağlar.

---

## ✅ Kapanış

Bu videoda, durum yönetiminin ne olduğunu ve full-stack sistemler içinde zamanla uygulama davranışını nasıl etkilediğini öğrendiniz.

Durum yönetimi, her modern uygulamanın temelidir; uygulamaların zaman içinde uyum sağlayabilmesini ve tutarlı kalmasını sağlar.
