## 🧩 Tasarım Desenlerini Tanıma

### 🧭 Giriş

Tasarım desenleri, yazılım geliştirmede sık karşılaşılan problemlere yönelik yerleşik çözümlerdir. Verimli, sürdürülebilir ve ölçeklenebilir uygulamalar geliştirmek için standart bir yaklaşım sunarlar. Geliştiricilerin en iyi uygulamaları ( *best practices* ) takip etmesine yardımcı olur; böylece daha tutarlı ve anlaşılır kod ortaya çıkar.

---

## 🧠 Tasarım Desenleri Nedir?

Tasarım desenleri, yazılım tasarımında tekrarlayan problemlere çözüm üretmek için yeniden kullanılabilir şablonlardır ( *reusable templates* ). Geliştiricilerin kodu yapılandırmasına; okunabilirliği artırmasına, karmaşıklığı azaltmasına ve gelecekteki bakımı kolaylaştırmasına yardımcı olurlar.

Bu desenleri uygulayarak geliştiriciler, kodlarının endüstri standartlarına uygun olmasını sağlar; böylece iş birliği ve kod inceleme ( *code review* ) süreçleri daha kolay hâle gelir.

---

## 🗂️ Tasarım Desenlerinin Kategorileri

Tasarım desenleri genellikle üç ana kategoriye ayrılır:

---

## 🏗️ 1. Oluşturucu Desenler

 *Oluşturucu desenler (Creational Patterns)* , nesne oluşturma mekanizmalarına odaklanır ve esnekliği artıran, kodun yeniden kullanımını destekleyen çözümler sunar.

### 🧱 Singleton Deseni

Bu desen, bir sınıfın yalnızca tek bir örneğe ( *instance* ) sahip olmasını sağlar ve bu örneğe global bir erişim noktası ( *global point of access* ) sunar.

Uygulama içinde tek bir veritabanı bağlantısı gibi paylaşılan kaynakları yönetmek için kullanışlıdır.

### 🏭 Factory Deseni

*Factory* deseni, nesne oluşturma sürecini ayrı bir *factory* sınıfı veya metodu içinde kapsüller ( *encapsulates* ).

Geliştiricilerin, oluşturulacak nesnenin tam sınıfını belirtmeden nesneler oluşturmasına olanak tanır; böylece esneklik ve ölçeklenebilirlik desteklenir.

---

## 🧱 2. Yapısal Desenler

 *Yapısal desenler (Structural patterns)* , sınıfların veya nesnelerin bileşimine odaklanır; nesnelerin daha büyük yapılar oluşturmak üzere nasıl birbirine bağlandığını ele alır.

### 🔌 Adapter Deseni

Bu desen, uyumsuz arayüzlerin ( *incompatible interfaces* ) birlikte çalışmasına olanak tanır.

İki uyumsuz sınıf arasında köprü görevi gören bir *adapter* sınıfı oluşturmayı içerir; böylece uygulama içinde iletişim kurabilir ve birlikte uyumlu şekilde çalışabilirler.

---

## 🔁 3. Davranışsal Desenler

 *Davranışsal desenler (Behavioral patterns)* , nesnelerin nasıl etkileştiğini ve birbirleriyle nasıl iletişim kurduğunu tanımlar; nesneler arasında sorumlulukların nasıl dağıtıldığına odaklanır.

### 👀 Observer Deseni

Bu, bir nesnenin ( *subject* ), durumundaki değişiklikleri bir gözlemci nesneleri listesine ( *observers* ) bildirdiği bir tasarım desenidir.

Bu desen, temel veriler değiştiğinde otomatik olarak güncellenmesi gereken kullanıcı arayüzü ( *UI* ) gibi senaryolarda özellikle kullanışlıdır.

---

## ✅ Tasarım Desenlerini Kullanmanın Faydaları

Tasarım desenlerini kullanmak, yazılım geliştirmede çeşitli avantajlar sunar.

İlk olarak, yaygın problemlere net ve standart bir yaklaşım sağladığı için kodun okunabilirliğini artırır; bu da deseni bilen herkesin kodu daha kolay anlamasını sağlar.

İkinci olarak, kanıtlanmış çözümleri yeni projelere minimum değişiklikle uygulamaya imkân vererek kodun yeniden kullanımını ve ölçeklenebilirliği destekler.

Son olarak, kod tabanının en iyi uygulamalara uygun olmasına yardımcı olur; bu da hata olasılığını azaltır ve bakım sürecini basitleştirir.

---

## 🧪 Tasarım Desenlerine Pratik Örnekler

### 🧱 Singleton Deseni Örneği

C#’ta bir *Database* sınıfı, uygulama boyunca veritabanına yalnızca tek bir aktif bağlantı olmasını sağlamak için Singleton desenini uygulayabilir.

Bu desen, *private constructor* ve sınıfın tek örneğini döndüren bir *static* metot kullanır; böylece birden fazla bağlantı oluşturulması engellenir.

---

### 🏭 Factory Deseni Örneği

Factory deseni, bir bildirim sisteminde ( *notification system* ) e-posta veya SMS gibi farklı bildirim türlerini, giriş parametrelerine bağlı olarak oluşturmak için kullanılabilir.

Nesneleri oluşturmak için *factory method* kullanıldığında, bu nesnelere ihtiyaç duyan kod, nesneleri oluşturan koddan ayrı kalır; böylece değiştirme ve genişletme daha kolay olur.

---

### 👀 Observer Deseni Örneği

Bir hava durumu istasyonu ( *weather station* ) uygulamasında Observer deseni, sıcaklık değiştiğinde birden fazla ekran birimini (telefon ya da masaüstü ekranı gibi) bilgilendirmek için kullanılabilir.

Bu desen, subject’in durumu değiştiğinde kayıtlı tüm observer’ların otomatik olarak güncelleme almasını sağlar.

---

## 🏁 Sonuç

Tasarım desenleri, nesne yönelimli programlamada sağlam, verimli ve bakımı kolay kod oluşturmayı sağlayan temel araçlardır.

Bu desenleri anlayıp uygulayarak yazılım mühendisleri, karmaşık problemleri daha etkili biçimde çözebilir, kod kalitesini artırabilir ve ölçeklemesi ve değiştirmesi daha kolay sistemler inşa edebilir.
