
## 🌐 Temel Ön Yüz Teknolojileri

Dijital dünyada, ön yüz teknolojileri geliştiricilerin görsel olarak çekici ve ilgi çekici web siteleri ile uygulamalar oluşturmasına yardımcı olur; erişilebilir, kullanıcı dostu olmalarını ve sorunsuz çalışmasını sağlar. Bu videoda, full-stack geliştirmede kullanılan temel ön yüz teknolojilerini listeleyeceğiz.

Full-stack geliştirmede kullanılan ön yüz teknolojileri; kodlama dilleri, çatıları ( *frameworks* ) ve kütüphaneleri ( *libraries* ) içerir.

---

## 🧾 Kodlama Dilleri Nedir?

Kodlama dilleri, geliştiricilerin bilgisayarlara talimat vermek için kullandığı araçlardır. Bilgisayarların yalnızca ikili ( *binary* ) kodu anlayabildiğini anlamak önemlidir; bu da birler ve sıfırlardan oluşan bir dizidir.

Çoğu kodlama dili, insanların yazmasını daha basit hâle getirecek, aynı zamanda makinelerin yorumlamasını kolaylaştıracak şekilde tasarlanır. Bu şekilde, bilgisayar yazdığınız kodu alır ve anlayabileceği bir şeye, yani ikili koda çevirir.

Kodlama dillerinin ne olduğunu ve nasıl çalıştıklarını anladığımıza göre, ön yüz geliştirmenin temel dilleri olan  *HTML* , *CSS* ve  *JavaScript* ’e geçelim. Şimdi bu dillerin her birini daha ayrıntılı inceleyelim; *HTML* ile başlayarak.

---

## 🧱 HTML

 *HTML* , web sayfaları oluşturmak için kullanılan standart işaretleme dilidir ( *standard markup language* ). Metin, görseller veya etkileşimli özellikler olsun, tüm içeriği bir arada tutan yapıyı sağlar.

 *HTML* , öğeleri ( *elements* ) düzenler ve tarayıcıya, onları nasıl görüntülemesi gerektiğine dair tarayıcıya özgü talimatlar verir. Öğeler; paragraflar, bağlantılar ve medya dosyaları gibi web sayfası bileşenleridir.

 *HTML* , bu öğeleri etiketler ( *tags* ) sistemiyle tanımlar. Peki bu nasıl çalışır? Pratikte,  *HTML* ’deki her öğe, içeriğin başlangıcını ve bitişini işaretleyen etiketlerle sarılır. Bir öğe genellikle bir başlangıç etiketi, içerik ve bir bitiş etiketinden oluşur.

Örneğin,  *HTML* ’de bir paragraf oluşturmak için şöyle yazarsınız:

```html
<p>this paragraph</p>
```

*p* etiketi, tarayıcıya içindeki metnin bir paragraf olarak ele alınması gerektiğini söyler ve kapanış *p* etiketi paragrafın bittiğini belirtir.

Bazı öğeler bu örnekte olduğu gibi basitken, diğerleri ek seçeneklerle gelir; bunlara, ekstra ayrıntılar veya ayarlar sağlayan nitelikler ( *attributes* ) denir.

Nitelikler, bir görselin kaynağını ( *source* ), bir buton bağlantısını veya bir öğenin stilini ( *styling* ) belirtmek gibi şeylerde sıkça kullanılır. Bir bağlantı ( *link* ) öğesinde niteliklerin nasıl çalıştığına dair bir örnek inceleyelim.

Bir bağlantı öğesi, açılış etiketi *a* ile başlar. Bu etiket, köprü bağlantıları ( *hyperlinks* ) oluşturmak için kullanılan anchor anlamına gelir. Sonra bir nitelik ekleriz. Bu örnekte, *href* niteliği tıklandığında bağlantının gideceği URL’yi belirtir. Örneğin:

```text
href https www.example.com
```

Nitelikten sonra kullanıcıların tıklayacağı içerik gelir. Bu örnekte:

```text
visit example website
```

Son olarak, bağlantıyı bitiş etiketi *a* ile kapatırız. Bu, bağlantı öğesinin sonunu işaretler.

Artık bir web sayfasına öğeler eklemeyi biliyorsunuz. Peki ya onların boyutunu, yazı tipini veya rengini değiştirmek isterseniz?

 *HTML* ’in *style* niteliği yazı tipi stillerini ve renkleri değiştirebilir, ancak büyük web siteleri için verimsizdir. Her öğeyi tek tek stilize etmeniz gerekir; bu da güncellemeleri tekrarlı ve zaman alıcı hâle getirir.

---

## 🎨 CSS

İşte burada *CSS* devreye girer.  *CSS* , içerikle tasarımı ayırır; birden fazla öğeyi tutarlı biçimde stilize etmenize izin verir ve kodunuzu sürdürmeyi ve güncellemeyi kolaylaştırır.

 *CSS* , *HTML* öğelerini stilize etmek için kullanılan dildir; görünümünü ve yerleşimini ( *layout* ) değiştirir. Örneğin, *CSS* kullanarak temel bir *HTML* butonunu; rengini ve kenarlığını değiştirip gölgeler ekleyerek şık ve etkileşimli bir öğeye dönüştürebilirsiniz.

*CSS* ile stil verirken seçiciler ( *selectors* ), özellikler ( *properties* ) ve değerlerin ( *values* ) bir kombinasyonunu kullanırsınız. Önce seçiciyi hedef olarak düşünün: stil vermek istediğiniz *HTML* öğesi (örneğin bir paragraf veya bağlantı). Ardından özellik, uygulamak istediğiniz belirli stildir; örneğin *color* veya  *font-size* . Son olarak değer, seçtiğiniz kesin ayardır; örneğin *blue* veya  *16 pixels* .

Bunu pratiğe dökelim. Web sitenizdeki tüm bağlantıları 15 piksel yazı boyutuyla mavi yapmak istiyorsanız, *CSS* kodunu şöyle yazardınız:

```css
a open bracket
color: blue
font-siz: 15px
close bracket
```

Burada  *a* , tüm bağlantıları hedefleyen seçicidir; *color* özelliktir ve *blue* uyguladığınız değerdir.

---

## ⚙️ JavaScript

*CSS* ile web sitenizin görsel yönlerini tasarladıktan sonra, sonraki adım onu etkileşimli hâle getirmektir. İşte burada *JavaScript* devreye girer.

 *JavaScript* , etkileşimli web sitelerini mümkün kılan bir programlama dilidir.  *JavaScript* ’in nasıl çalıştığını anlamak için, iki temel yapı taşına aşina olmak gerekir: ifadeler ( *statements* ) ve ifadeler ( *expressions* ).

 *Statements* , bilgisayara ne yapacağını söyleyen talimatlardır. Genellikle bir değişken tanımlamak veya bir fonksiyon çağırmak gibi bir eylem gerçekleştirirler. Örneğin, *alice* metnini ( *string* ) *name* adlı bir değişkende saklamak için şöyle yazarsınız:

```javascript
let name equal Alice
```

Bir *expression* ise, bilgisayarın bir sonuç üretmek için değerlendirebileceği bir kod parçasıdır; örneğin bir matematik denklemi veya mantıksal karşılaştırma. Örneğin, beşin üçten büyük olup olmadığını kontrol etmek için şöyle yazarsınız:

```text
five greater than symbol three
```

Çıktı *true* olur; çünkü beş gerçekten üçten büyüktür.

---

## 🧩 Frameworks

Bu üç dili öğrenmek yalnızca başlangıçtır. Ön yüz mühendisliğinde gerçekten başarılı olmak için, çatıları ( *frameworks* ) ve kütüphaneler ( *libraries* ) gibi temel teknolojilerde de yetkin olmanız gerekir. Önce çatıları ele alalım.

 *Frameworks* , kodu inşa etmek ve organize etmek için standart bir yol sunan, önceden yazılmış kod yapılarıdır. Uygulamalar oluşturmak için bir temel sağlar; geliştirmeyi daha hızlı ve daha verimli hâle getirir.

Popüler ön yüz çatıları arasında  *react* , *angular* ve *vue* bulunur.

---

## 📦 Libraries

Şimdi kütüphaneleri inceleyelim. Kütüphaneler, mühendislerin uygulamanın akışını ( *flow* ) ve özel kodunu ( *custom code* ) kontrol etmesine ve yalnızca ihtiyaç duydukları bileşenleri seçmesine olanak tanır.

 *Kütüphaneler* , yaygın görevleri gerçekleştirmek için kullanılan, önceden yazılmış kod koleksiyonlarıdır. Sıklıkla, belirli problemleri çözmek için tek tek kullanılan nesneler ( *objects* ) ve fonksiyonlar ( *functions* ) içerir.

Popüler kütüphaneler arasında  *Node.js* , *React.js* ve *Vue.js* bulunur.

---

## ✅ Kapanış

Bu ön yüz teknolojileri, uygulamaları işlevsel hâle getirir ve görsel olarak çekici ve kullanıcı dostu olmalarını sağlar; full-stack geliştiricilerin bütüncül ve ilgi çekici kullanıcı deneyimleri oluşturmasına olanak tanır.

Bu videoda, full-stack geliştirmede kullanılan temel ön yüz teknolojilerini listeledik. Bu teknolojileri anlamak ve kullanmak, etkili ve ilgi çekici kullanıcı arayüzleri oluşturmanın anahtarıdır.
