## 🧩 Temel Algoritma Yapıları

Algoritmalar, bilgisayarların problemleri nasıl çözdüğünün temelini oluşturur. İster veri işleme, ister karar verme, ister bir programın akışını kontrol etme olsun, algoritmalar her adımı hassasiyet ve mantıkla yönlendirir. Bu yapıları anlamak, verimli ve etkili kod yazan herkes için gereklidir.

Bu videoda, algoritmaların temel yapılarını açıklayacağız.

---

## 🧠 Algoritma Nedir?

Bir algoritmanın ne olduğunu tanımlayarak başlayalım. Algoritma, bir problemi çözmek veya bir görevi yerine getirmek için kullanılan adım adım talimatlar kümesidir.

Bir labirentte olduğunuzu ve çıkışı bulmanız gerektiğini hayal edin.

Labirentin girişinde konumlanmışsınız ve içinde gezinmeye hazırsınız. Kodlama terimleriyle bu, algoritmanızın çalışmaya başladığı yerdir. Sözde kodunuz şöyle der:

***“Konumu başlangıca ayarla”***

Hareket etmeye başladığınızda, hangi yöne gideceğinize karar vermeniz gerekir. Bu, algoritmanızda karar vermeye benzer. Başlangıç noktasını geçtiniz ve labirente doğru bir sonraki hamlenizi yapıyorsunuz; algoritma bir sonraki konuma ilerler. Sözde kodda şunları yazabilirsiniz:

***“Sağda bir yol varsa, onu seç”*** veya ***“Önünde bir duvar varsa, sola dön”***

Bu kararlar, kodunuzdaki koşullu ifadeler gibidir; belirli koşullara bağlı olarak hareketlerinizi yönlendirir.

Kaybolmamak için yolunuzu tebeşirle işaretleyebilirsiniz; böylece aynı yolu iki kez seçmezsiniz. Algoritmalarda bu, döngülerden kaçınmak için ziyaret edilen düğümleri takip etmeye benzer ve sözde kodda şöyle gösterilebilir:

***“Konumu ziyaret edildi olarak işaretle”***

İlerledikçe çıkmaz sokaklarla karşılaşırsınız. Bu olduğunda, son karar noktasına geri dönüp farklı bir yol denemeniz gerekir. Bu geri izleme süreci birçok algoritmanın kritik bir parçasıdır. Sözde kodda şunu yazabilirsiniz:

***“Ziyaret edilmemiş yol yoksa, önceki konuma dön”***

Sonunda çıkışı bulursunuz. Bu, algoritmanızın hedefidir: bir çözüme ulaşmak. Sözde kodunuz şu şekilde sonuçlanır:

***“Çıkış bulunursa, dur ve başarı döndür”***

Bu örnekle, labirentte yolumuzu bulmaya yardımcı olan bir algoritma, yani adım adım talimatlar kümesi oluşturmuş olduk.

---

## 🧾 Sözde Kod Örneği

Sözde kodda algoritmamız şöyle görünür:

```text
Konumu başlangıca ayarla, konumu ziyaret edildi olarak işaretle.
Konum çıkış değilken,
  Sağda bir yol varsa ve ziyaret edilmemişse, sağa git.
  Aksi halde ileriye doğru bir yol varsa ve ziyaret edilmemişse, ileri git.
  Aksi halde solda bir yol varsa ve ziyaret edilmemişse, sola git.
  Aksi halde geriye doğru bir yol varsa ve ziyaret edilmemişse, geriye git.
  Aksi halde, önceki konuma geri izle.
  Yeni konumu ziyaret edildi olarak işaretle.
Çıkış bulunursa, başarı döndür.
Aksi halde, başarısızlık döndür.
```

Algoritmaların ne olduğuna dair sağlam bir anlayışla, şimdi onların nasıl karar verdiğini inceleyelim.

---

## 🧭 Koşullu İfadeler

Bu kararların yapı taşları ifadelerdir ve bunlar en temel türlerden biriyle başlar: koşullu ifadeler.

Bir koşullu ifade, bir programın bir koşulun doğru ya da yanlış olmasına bağlı olarak karar vermesine ve farklı eylemler gerçekleştirmesine olanak tanır. Bu, algoritmaların akışını kontrol eden ve hangi kod bölümlerinin çalıştırılacağını, atlanacağını veya tekrarlanacağını belirleyerek karmaşıklığı yöneten temel bir yapı taşıdır.

Koşullu ifadeleri, en yaygın türlerden biriyle daha ayrıntılı inceleyelim: *if/then* ifadesi. Bu ifade, kodunuzda basit ve doğrudan kararlar almak için kritik öneme sahiptir.

Bir *if/then* ifadesi, koşullu ifadenin belirli bir türüdür. Bir koşulu kontrol eder ve koşul doğruysa buna göre bir kod bloğunu çalıştırır.

Bir *if/then* ifadesi bir ışık anahtarı gibidir.

Karanlık bir odada olduğunuzu ve ışığı açmak istediğinizi hayal edin. Şimdi aydınlık odadan çıkıyorsunuz ve ışığı kapatmak istiyorsunuz. Sözde kodda, şöyle bir *if/then* ifadesi okuyabilirsiniz:

***“Eğer ışık anahtarı ‘kapalı’ ise, ışık anahtarını aç”*** veya ***“Eğer ışık anahtarı ‘açık’ ise, ışık anahtarını kapat”***

Önce, *if/then* ifadesi ışık anahtarının konumunu kontrol ederek algoritma için koşulları belirler. Anahtar ya açık konumdadır ya da kapalı konumdadır.

İkinci olarak, bir eylem oluşturur. Anahtar kapalıysa eylem onu açmaktır. Bu durumda anahtar açıksa eylem onu kapatmaktır.

*If/then* gibi koşullu ifadeler olmadan, algoritma karşılaştırma yapamaz ve buna bağlı kararlar veremezdi. Işık anahtarı benzetmesi, koşullu ifadelerin belirli koşullara göre karar verme süreçlerini nasıl yönlendirdiğini gösterir; tıpkı bir ışığın mevcut durumuna göre onu açıp kapatmaya karar vermemiz gibi.

---

## 🗂️ Switch İfadesi

*If/then* ifadelerine dair anlayışımızı geliştirerek, şimdi birden fazla koşulla çalışmak için daha esnek bir aracı inceleyelim: *switch* ifadesi. Bu, algoritmalarımızda daha karmaşık karar verme senaryolarını yönetmemize yardımcı olur.

Bir *switch* ifadesi, bir bilgisayarın çalıştıracağı birkaç kod bloğu arasından seçim yapmasına yardımcı olan bir programlama aracıdır. Çok sayıda olasılık olduğunda karar vermenin yapılandırılmış bir yoludur.

Bir *switch* ifadesi, haftanın her gününde ne yapacağınızı söyleyen haftalık bir planlayıcı gibidir. Her gün, planlayıcınıza bakar ve o gün için belirlenen etkinlik planını uygularsınız.

Haftalık planlayıcınızda her gün, kontrol edilecek belirli bir görev veya değere sahiptir. Haftanın her günü farklı bir durumdur. Planlayıcı, hangi gün olduğunu kontrol eder ve hangi görevi yapmanız gerektiğine karar verir. Eylem, güne göre gerçekleştirdiğiniz görevdir. Belirli bir gün listelenmemişse, “çamaşırları yıka” gibi varsayılan bir görev olabilir.

Haftalık planlayıcı örneğini kullanarak bir *switch* ifadesi için sözde kod örneği şu şekilde düzenlenir:

***“Haftanın günü ‘Pazartesi’ ise, ‘Ev projesine başla’”***
***“Haftanın günü ‘Salı’ ise, ‘Bowling’e git’”***
***“Haftanın günü ‘Pazartesi’ veya ‘Salı’ değilse, ‘çamaşırları yıka’”***

*Switch* ifadeleriyle, birden fazla koşulla verimli şekilde çalışabiliriz. Şimdi odağımızı, verileri mantıksal olarak düzenlememize ve sınıflandırmamıza yardımcı olacak kategorik ifadelere kaydıralım.

---

## 🧾 Kategorik İfadeler

Kategorik bir ifade, “Tüm kediler hayvandır” veya “Bazı köpekler arkadaş canlısı değildir” gibi ifadeleri analiz etme ve sınıflandırma yöntemidir. Mantıksal kuralları kullanarak bu ifadelerin doğru olup olmadığını veya birbirleriyle nasıl ilişkili olduklarını belirler.

Kategorik ifadeler, bir şeyin doğru olup olmadığını veya başka bir şeyle nasıl ilişkili olduğunu belirlemek için olumlu ya da olumsuz ifadeler sistemini kullanır. Bu ifadeler, özne ile yüklem (ya da varsayım) arasındaki ilişkiye göre sınıflandırılır. Belirli ölçütlere göre verileri gruplar ve kategorize eder ve verileri verimli şekilde düzenlemek ve yönetmek için faydalıdır.

Kategorik ifadelerin farklı türlerini inceleyelim. İlki *Evrensel Olumlu* ifadedir. “S” özne veya kategori ve “P” öznenin ilişkilendirildiği yüklem veya kategori ise, *Evrensel Olumlu* ifade şöyle olabilir:

***“Tüm S’ler P’dir”***

Sözde kodda şunu yazabilirsiniz:

***“Tüm köpekler memelidir”***

Bir diğer tür *Evrensel Olumsuz* ifadedir; bu, şöyle olabilir:

***“Hiçbir S, P değildir”***

Sözde kodda şunu yazabilirsiniz:

***“Hiçbir kedi sürüngen değildir”***

Üçüncü tür kategorik ifade *Tikel Olumlu* ifadedir. Böyle bir ifade şöyle olabilir:

***“Bazı S’ler P’dir”***

Sözde kodda bu:

***“Bazı kuşlar uçabilir”***

Son olarak, *Tikel Olumsuz* ifade:

***“Bazı S’ler P değildir”***

Bu durumda sözde kod:

***“Bazı balıklar etçil değildir”***

Bu mantıksal yapıları kullanarak, farklı ifadeleri etkili şekilde analiz edip kategorize edebilir ve aralarındaki ilişkileri anlayabiliriz.

---

## ⚖️ İkili Yapılar

Verileri kategorize etmeyi anladıktan sonra, kararların yalnızca iki olası sonuca indirgendği ikili yapılara bakalım. Bu yaklaşım, kodunuzda hızlı ve verimli seçimler yapmanın temelidir.

İkili yapılar, kararların ve veri düzenlemenin iki olası sonuca dayandığı ikili sistem kavramına göre oluşturulmuş veri yapılarıdır (genellikle doğru/yanlış veya evet/hayır olarak temsil edilir).

İkili yapılar, iki olası sonuca göre karar vermeyi içerir. Bu, her karar noktasının veya düğümün iki sonraki yoldan birine yönlendirdiği ikili karar diyagramlarıyla temsil edilebilir.

Bir örnek düşünelim: Bir hayvanın kürkü olup olmamasına göre onun balık mı yoksa kedi mi olduğunu belirlemek istiyoruz.

Sözde kodda şöyle görünür:

Kök soru: ***“Hayvanda kürk var mı?”***
İkili karar fonksiyonu, kullanıcının yanıtlarına göre diyagram üzerinde bir yol izler.
Eğer ***“evet”*** ise, ***“Hayvan bir kedidir”*** sonucunu döndürür.

---

## ✅ Kapanış

Bu videoda, algoritmaların temel yapılarını öğrendiniz. Gösterdiğimiz gibi, koşullu ifadeler, kategorik ifadeler ve ikili yapılar gibi algoritmaların temel yapılarına hakim olmak; problemleri verimli biçimde çözmek ve daha etkili kod yazmak için sizi gerekli araçlarla donatır. Bu temel beceriler, giderek daha karmaşık programlama zorluklarına girişirken size iyi hizmet edecektir.
