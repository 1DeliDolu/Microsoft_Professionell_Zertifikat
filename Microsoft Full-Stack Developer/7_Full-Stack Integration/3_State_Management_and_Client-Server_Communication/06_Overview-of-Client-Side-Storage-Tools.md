## 🗂️ İstemci Tarafı Depolama Araçlarına Genel Bakış

Bir web sitesi tercihlerinizi hatırladığında veya oturumunuzu açık tuttuğunda, tarayıcınızda doğrudan veri yönetmek için istemci tarafı depolama araçlarını kullanıyordur. Bu araçları anlamak, daha akıcı ve daha kişiselleştirilmiş web deneyimleri oluşturmanızı sağlar.

Bu videoda, ön yüz ( *front-end* ) uygulamalarında durumu yönetmek için kullanılabilen istemci tarafı depolama mekanizmalarını tanımlayacağız.

---

## 💾 Yaygın İstemci Tarafı Depolama Mekanizmaları

Yaygın istemci tarafı depolama mekanizmalarını keşfetmeye *local storage* ile başlayalım; bu, tarayıcıda veriyi kalıcı olarak kaydetmeye yarayan bir mekanizmadır.

 *Local storage* , kullanıcının tarayıcısında kalıcı olarak saklanan ve kullanıcı veya uygulama tarafından açıkça kaldırılmadıkça erişilebilir kalan veriyi ifade eder.

Örneğin, bir web sitesini ziyaret edip görünümünü değiştirmek için koyu moda ( *dark mode* ) geçtiğinizi düşünün. *Local storage* bu tercihi kaydeder; böylece daha sonra geri döndüğünüzde seçiminizi hatırlar, çünkü tarayıcıyı kapatsanız bile veri tarayıcınızda saklı kalır.

---

## 🕒 Session Storage

 *Local storage* ’ı incelediğimize göre, şimdi veriyi geçici olarak saklamaya yarayan bir araç olan  *session storage* ’a geçelim.

 *Session storage* , tarayıcıda saklanan ancak tarayıcı sekmesi kapatılır kapanmaz otomatik olarak temizlenen veridir. Bazen *session ID* gibi bilgileri tutarak veritabanı sistemlerini tamamlayabilir.

Bu  *session ID* , uygulamaların kullanıcı kimlik doğrulama ( *authentication* ) ayrıntılarını veya diğer gerekli verileri almasını sağlar ve istemci ile veritabanı arasında akıcı bir etkileşim oluşturur.

Örneğin, bir web sitesinde çok adımlı bir form kullanırken  *session storage* , adımlar arasında gezinirken ilerlemenizi korur. Ancak oturum bittiğinde veri temizlenir; bu da onu mevcut gezinme oturumunun ötesinde kalıcı olması gerekmeyen geçici işler için ideal hâle getirir.

---

## 🍪 Cookies

Sırada, oturumlar ve cihazlar arasında kişiselleştirme ve izleme için veri yöneten *cookies* var.

 *Cookies* , tarayıcı tarafından saklanan küçük veri parçalarıdır. Genellikle kullanıcı davranışını izlemek veya bir web sitesindeki kullanıcı deneyimini kişiselleştirmek için kullanılır.

Web geliştirmede, istemci (tarayıcı) ile sunucu arasında durumu korumak için yaygın biçimde kullanılır.

Bazı web sitelerinin sizi oturum açık tutması veya cihazlar arasında tercih ettiğiniz dili hatırlaması gibi durumları düşünün.  *Cookies* , web sitelerinin istediği zaman erişebileceği küçük miktarda veriyi saklayarak bunu mümkün kılar.

---

## 🛒 Gerçek Dünya Örneği: Birlikte Nasıl Çalışırlar?

Şimdi  *local storage* , *session storage* ve  *cookies* ’in gerçek dünyada nasıl birlikte çalıştığına bakalım.

Bir çevrim içi alışveriş platformu; koyu mod ( *dark mode* ) gibi kullanıcı tercihlerini kaydetmek için *local storage* kullanabilir, gezinme oturumu sırasında alışveriş sepetindeki ürünler gibi verileri geçici olarak saklamak için *session storage* kullanabilir ve cihazlar arasında kişiselleştirmeyi mümkün kılmak için *session identifiers* saklayan *cookies* kullanabilir.

Bu araçlar birlikte, sorunsuz ve kişiselleştirilmiş bir alışveriş deneyimi oluşturur.

---

## ✅ Kapanış

Bu videoda, ön yüz uygulamalarında durumu korumak için kullanılabilen istemci tarafı depolama mekanizmalarını öğrendiniz.

İstemci tarafı depolama ile, duyarlı, kişiselleştirilmiş ve kullanıcı dostu hissi veren web uygulamaları geliştirebilirsiniz.
