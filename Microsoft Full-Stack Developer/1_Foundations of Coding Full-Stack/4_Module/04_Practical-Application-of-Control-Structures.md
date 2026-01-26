## 🧩 Kontrol Yapılarının Pratik Uygulaması

Hafta sonu aktivitelerinizi planladığınızı hayal edin. Hava durumuna göre karar verirsiniz: Hava güneşliyse yürüyüşe gidersiniz; yağmurluysa evde kalır ve kitap okursunuz. Bu karar verme süreci, programlamada *if-else* ve *switch* ifadelerinin nasıl çalıştığına benzer.

Bu videoda, problemleri çözmek için *if-else* ifadelerini ve *switch* ifadelerini uygulayacağız.

## 🧠 Günlük Hayatta Koşullara Göre Karar Verme

Günlük hayatta, *if-else* mantığına ve programlamaya benzer şekilde koşullara bağlı kararlar veririz. Bu kavramın, *if-else* mantığının kullanılabileceği günlük durumlara nasıl uygulandığını inceleyelim.

### 👕 Örnek 1: Hava Durumuna Göre Kıyafet Seçme

Hava soğuksa ceket giy. Aksi hâlde tişört giy.

### 🍔 Örnek 2: Beslenme Tercihine Göre Yemek Seçme

Vejetaryensen sebzeli burger seç. Aksi hâlde tavuklu sandviç seç.

Bu senaryolar, bir koşula bağlı olarak iki seçenek arasında karar vermek için *if-else* ifadelerini nasıl kullandığımıza benzer.

## 🧪 Alıştırma Problemi 1: If-Else Kullanımı

Bazı örnekleri gözden geçirdiğimize göre, şimdi bu kavramları bir alıştırma probleminde uygulama sırası sizde.

Alıştırma problemi 1 için senaryo şu: Code Master Institute için öğrencinin notunu kontrol eden ve bir mesaj yazdıran bir program oluşturuyorsunuz. Bu problemdeki göreviniz, not 50 veya üzerindeyse `"Passed"`, 50’nin altındaysa `"Failed"` yazdıran bir *if-else* ifadesi yazmaktır.

### 🧱 Adım 1: Değişkeni Oluşturma

İlk adım, *if-else* ifademizle kontrol edebileceğimiz bir değişken oluşturmaktır. Bu durumda değişkene `'grade'` adını vereceğiz ve türü *integer* olacaktır.

### 🖥️ Adım 2: Kullanıcıdan Notu Konsoldan Alma

İkinci olarak, kullanıcının not girdisini konsoldan almamız gerekir. Bu kod, kullanıcıdan bir öğrencinin notunu girmesini ister ve ardından girdiyi  *string* ’den  *integer* ’a dönüştürür.

### ✅ Adım 3: Koşulu Kontrol Etme

Şimdi, öğrencinin notuna göre geçip geçmediğini belirlemek için koşulu kontrol edeceğiz.

Bir öğrencinin, notu 50 veya üzerindeyse geçtiğini hatırlayın. Bunu yapmak için `'if'` anahtar sözcüğünü ve koşulu ekleyeceğiz. Koşulun içine, öğrencinin geçtiğini belirten mesajı yazdıran kodu ekleyeceğiz.

### ❌ Adım 4: Else Bloğunu Eklemek

Son olarak, *else* kısmını ve öğrencinin kaldığını belirten kodu ekleyeceğiz.

## 🔀 Birden Fazla Koşul için Switch Kullanımı

*If-else* ifadelerinin iki seçenek arasında karar vermeye nasıl yardımcı olduğunu incelediğimize göre, şimdi birden fazla koşulla çalışmak için *switch* ifadelerinin daha verimli bir yol sunabileceğini inceleyelim.

*Switch* ifadeleri *if-else* ifadelerine benzer, ancak birden fazla koşulu daha verimli şekilde yönetir.

### 🎁 Örnek: Sadakat Programı Seviyesine Göre Ödül Belirleme

Eğer `"Bronze"` ise: %5 indirim, eğer `"Silver"` ise: %10 indirim ve eğer `"Gold"` ise: %15 indirim.

Varsayılan ( *Default* ): İndirim Yok.

Bu senaryo, birden çok koşulu kategorilere ayırarak karmaşık karar verme süreçlerini *Switch* ifadelerinin nasıl basitleştirebileceğini gösterir.

## 🧪 Alıştırma Problemi 2: Switch Kullanımı

Şimdi başka bir alıştırma problemi üzerinde çalışalım; bu kez bir *switch* ifadesi kullanacağız.

Alıştırma Problemi 2 için, Code Master Institute için bir öğrencinin puanına göre harf notu atayan bir sistem geliştiriyorsunuz. Göreviniz, 90-100 puanlar için `"A"`, 80-89 için `"B"`, 70-79 için `"C"`, 60-69 için `"D"` ve 60’ın altı için `"F"` atayan bir *switch* ifadesi yazmaktır.

### 🧱 Adım 1: Değişkeni Oluşturma

Önce, *Switch* ifadesi ile kontrol edeceğimiz değişkeni oluşturacağız.

Bu problem için değişkene `'score'` adını vereceğiz ve türü *integer* olacaktır.

### 🖥️ Adım 2: Kullanıcıdan Puanı Konsoldan Alma

İkinci olarak, kullanıcı puan girdisini konsoldan almamız gerekir. Bu kod, kullanıcıdan bir öğrencinin notunu girmesini ister ve girdiyi  *string* ’den  *integer* ’a dönüştürür.

### ➗ Adım 3: Notu Belirlemek için Bölme Sonucunu Değerlendirme

Harf notu atamak için, kullanıcının notunu 10’a bölme işleminin sonucunu değerlendirmek üzere bir *switch* ifadesi kullanacağız. Not *integer* olduğu için bu bölme yalnızca tam sayı kısmını dikkate alır; bu da harf notu seviyesini belirlemeyi kolaylaştırır.

90-100 puanlar için `"A"` notunu atadığımızdan, bölme sonucunun 9-10 olduğu durum için bir *case* oluşturmamız gerekir. *Case 10* ve  *case 9* , `"A"` notunu yazdıracaktır.

`break` anahtar sözcüğünü eklemeyi unutmayın; aksi hâlde sistem bir sonraki  *case* ’leri yürütmeye devam eder.

### 🔤 Adım 4: B, C ve D Notları için Case’leri Eklemek

Sonra `"B"`, `"C"` ve `"D"` notları için  *case* ’leri ekleyeceğiz; bunlar sırasıyla bölme sonuçları 8, 7 ve 6 olan durumlara karşılık gelir.

Her *case* için notu yazdıran kodu ekleyin ve `break` anahtar sözcüğünü ekleyin.

### 🧾 Adım 5: Default ile F Notunu Yönetme

Son olarak, 60’ın altındaki herhangi bir değer `"F"` notuyla sonuçlanacaktır. Bunu yönetmek için *default case* kullanacağız; bu, *if-else* yapısındaki *else* ifadesinin nasıl çalıştığına benzer.

Belirtilen  *case* ’lerin hiçbiri eşleşmezse, *default* eyleminin uygulanmasını sağlayacağız.

## ✅ Video Özeti

Bu videoda, problemleri çözmek için *if-else* ve *switch* ifadelerini nasıl uygulayacağınızı öğrendiniz. Bu koşullu ifadeler, tıpkı gerçek hayattaki senaryolarda olduğu gibi programlamada da karar vermek için önemlidir.

Bu kavramları pratik ederek problem çözme becerilerinizi geliştirebilir ve daha verimli kod yazabilirsiniz.
