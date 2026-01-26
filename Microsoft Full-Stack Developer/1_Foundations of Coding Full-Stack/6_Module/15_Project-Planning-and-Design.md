## 🗺️ Proje Planlama ve Tasarım

Başarılı yazılım geliştirmenin anahtarı, dikkatli planlama ve tasarımdır. Sağlam bir proje planıyla, kodunuzun düzenli, verimli ve karmaşık görevler üzerinde çalışmaya hazır olmasını sağlayabilirsiniz. Bu videoda, kapsamlı bir kod projesini planlayıp tasarlayacağız.

Bir kodlama projesini planlamak ve tasarlamak; proje gereksinimlerini tanımlamayı, hedefleri belirlemeyi ve temel kodlama kavramlarını içeren bir tasarım taslağı oluşturmayı kapsar. Bu adımları bir örnek üzerinden inceleyelim.

İş arkadaşlarınızın görevlerini takip etmelerine yardımcı olacak bir görev yönetimi uygulaması yapmak istiyorsunuz. İlk olarak proje gereksinimlerini tanımlayarak başlayın.

---

## 📋 Proje Gereksinimlerini Tanımlama

Bir projenin gereksinimleri; başarısını sağlamak ve zamanında tamamlamak için karşılanması gereken çıktılar ile tamamlanması gereken görevlerdir. Proje gereksinimleri iki ana kategoriye ayrılır: *functional* ve  *non-functional* .

---

## ⚙️ Functional Requirements

Functional requirements, uygulamanın ne yapması gerektiğini, uygulamayı çalışır kılan temel işlevleri tanımlar. Şu sorulara yanıt verir: uygulama neyi başarmalı?

Görev yönetimi uygulamamız için functional requirements oldukça nettir. Uygulama, kullanıcıların görev eklemesine, görevleri gözden geçirmesine ve görevleri tamamlamasına izin vermelidir.

Bunlar uygulamayı kullanışlı kılan temel eylemlerdir.

---

## 🧩 Non-Functional Requirements

Non-functional requirements, uygulamanın nasıl performans göstermesi gerektiğini kapsar. Bunlar kullanılabilirlik, performans ve güvenlik gibi konulardır.

Uygulamanın sadece işlevsel değil, aynı zamanda güvenilir ve kullanması keyifli olmasını sağlarlar.

Görev uygulaması için non-functional requirements, kullanılabilirlik ve performans üzerine odaklanır.

Uygulamanın sezgisel bir arayüzü olmalı ve kullanıcıların görev oluşturmasını, düzenlemesini ve silmesini en fazla üç seçimle yapabilmesine imkân vermelidir.

Uygulama ayrıca görev listesini iki saniye içinde yükleyebilmeli ve performans düşüşü olmadan 10.000 göreve kadar işleyebilmelidir.

---

## 🎯 Proje Hedeflerini Belirleme

Gereksinimlerimiz belirlendikten sonra, bir sonraki adım net proje hedefleri koymaktır.

Hedefler, bir kişinin veya sürecin belirli bir zaman dilimi içinde ulaşmayı amaçladığı somut sonuçlardır.

Uygulamamız için hedefler şunları içerebilir:

* Üç ay içinde görev ekleme, gözden geçirme ve tamamlama için kod tabanını oluşturmak
* Dört ay içinde görev depolama için veri entegrasyonunu uygulamak
* Yayın öncesinde test ve debugging’i tamamlamak, kritik bug’ların yüzde 95’ini çözmek

Bu hedefler ölçülebilirdir. Uygulamayı geliştirirken, hedefleri karşılayıp karşılamadığını her zaman kontrol edebiliriz.

Net hedefler yön sağlar ve proje takvimini korumaya yardımcı olur. Sürece dahil olan herkesin tam olarak neyin başarılması gerektiğini bilmesini sağlar.

İyi tanımlanmış hedeflerle, zaman, emek ve bütçe gibi kaynakları daha etkili şekilde dağıtabiliriz; bu da tüm süreci daha akıcı hâle getirir.

---

## 🧱 Tasarım Taslağı Oluşturma

Şimdi tasarım taslağı oluşturmaya geçelim.

Bu, gereksinimlerimizi ve hedeflerimizi uygulamanın nasıl çalışacağına dair bir plana dönüştürdüğümüz aşamadır.

Bir tasarım taslağı, uygulamayı inşa etmek için adım adım bir rehber görevi görür.

Görev yönetimi uygulamamızı tasarlamak için projeyi daha küçük ve yönetilebilir modüllere böleceğiz ve bunları uygulamak için kullanacağımız kod bileşenlerini planlayacağız.

Görev uygulamamız için:

* Görevleri görüntüleme modülüne ihtiyacımız var; bu modül kullanıcıların görev listesini istedikleri zaman gözden geçirebileceği basit bir arayüz sağlayacak.
* Görev ekleme modülüne ihtiyacımız var; bu modül yeni görevleri girmek için doğrudan bir yöntem sunacak.
* Görevleri tamamlandı olarak işaretleme modülüne ihtiyacımız var; bu modül seçilebilen checkbox arayüz öğeleri sağlayacak.

Bu taslak, uygulama yapısını incelememize yardımcı olur ve herhangi bir temel özelliği kaçırmadığımızdan emin olmamızı sağlar.

---

## 🧠 Modülleri Uygulamak İçin Kod Bileşenlerini Planlama

Şimdi, modülleri uygulamak için kullanacağımız kod bileşenlerini planlayalım.

Bu modülleri uygulamak için  *variables* ,  *methods* , *if/else statements* ve *loops* kullanmamız gerekir.

---

## 🧾 Variables ile Veri Saklama

Variables bilgi sakladığı için, proje boyunca nerelerde veri tutmamız gerektiğini önceden taslaklandırmalıyız.

Örneğin yapılacaklar listesi uygulamamızda, her görev için bir `string` değişkenine ihtiyacımız vardır.

Kullanıcı her görev eklediğinde, görev bir diziye veya değişkenlerden oluşan bir listeye kaydedilir.

---

## 🛠️ Methods ile İşlevleri Gruplama

Sonra methods tasarlamalıyız. Bunlar, ilgili görevleri yeniden kullanılabilir tek bir kod birimi altında toplamamızı sağlar.

Yapılacaklar listesi uygulamasında, her modül için bir metot olmalıdır; `view task`, `add task` ve `mark task complete` dahil.

---

## 🔀 If/Else ile Karar Noktalarını Yönetme

Ardından, uygulamada kararların nerede verileceğini planlarız.

Koşullara bağlı farklı senaryoları yönetmek için if/else statements kullanacağız.

Örneğin, kullanıcının bir görev girip girmediğini kontrol etmek için bir if/else statement kullanmayı planlarız.

Eğer giriş alanı boşsa, kullanıcıdan görev girmesini isteyen bir mesaj göstereceğiz.

Aksi halde, görevi listeye eklemek için bir mesaj göstereceğiz.

---

## 🔁 Loops ile Tekrarlayan İşlemler

Son olarak, modüllerimizin herhangi birinde koşullara bağlı olarak kodun tekrar etmesi gerekip gerekmediğini belirlemeliyiz.

Tekrarlamanın gerekli olduğu yerleri tespit eder ve bu durumları yönetmek için loops kullanmayı planlarız.

Yapılacaklar listesi uygulamasında, kullanıcı uygulamayı her açtığında eklenmiş tüm görevleri ekranda göstermek için bir loop kullanacağız.

---

## ✅ Kapanış

Bu videoda, kapsamlı bir kod projesini planlamayı ve tasarlamayı öğrendiniz.

Görev yönetimi uygulamamızın her yönünü; gereksinimleri ve hedefleri tanımlamaktan bir tasarım oluşturmaya kadar dikkatle planlayıp tasarlayarak, uygulamanın kullanıcı dostu, verimli ve geliştirmeye hazır olmasını sağlarız.
