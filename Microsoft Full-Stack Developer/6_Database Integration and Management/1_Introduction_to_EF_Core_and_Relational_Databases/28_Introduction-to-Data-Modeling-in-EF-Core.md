## 🧩 EF Core’da Veri Modellemeye Giriş

Bir uygulamanın veri yapısını oluştururken amaç, veritabanının veriyi verimli biçimde saklamasını, yönetmesini ve geri almasını sağlamaktır. Bunun gerçekleşmesine yardımcı olan sürece **veri modelleme** denir.

Bu videoda, veri modelleme kavramını ve EF Core’daki önemini tanımlayacağız.

---

## 🧠 Veri Modelleme Nedir ve Neden Önemlidir?

Veri modelleme, bir veritabanı sisteminin yapısının görsel bir temsilini oluşturma sürecidir. Bu görsel temsil, veritabanlarını anlamaya, analiz etmeye ve tasarlamaya yardımcı olur.

Bu, bir veritabanı için bir plan ( *blueprint* ) tasarlamak gibidir; veri öğelerinin yapısını ve organizasyonunu ana hatlarıyla belirtir.

Bir kütüphane veritabanı sistemi hayal edelim. Kitaplar, yazarlar ve ödünç alanlar hakkında bilgi saklaması gerekir. Bir veri modeli, bu varlıkları ( *entities* ) tablolara organize eden şemayı tanımlamanızı sağlar.

Bu kütüphane veritabanında, kitap kimliği, başlık ve yazar kimliği gibi bilgileri içeren kitaplar için bir tablo bulunması gerekir.

Yazar kimliği ve yazar adını içeren yazarlar için başka bir tablo bulunur.

Her birinin başlık veya yazar adı gibi kendi satır kümeleri vardır.

Ve ödünç alan kimliği ve ödünç alan adı gibi bilgileri içeren kitap ödünç alanlar için başka bir tablo bulunur.

İyi tanımlanmış bir veri modeli, uygulamanızın verimli çalışmasını ve veritabanınızın organizasyonunuzun ihtiyaçlarını doğru şekilde yansıtmasını sağlar.

---

## ⚙️ EF Core’da Veri Modelleme Nasıl Çalışır?

Şimdi veri modellemenin **Entity Framework Core** (EF Core) içinde nasıl çalıştığını inceleyelim.

Önce  **entity** ’lere ve verinizi yapılandırmadaki rollerine bakalım.

---

## 🧱 Entity ve Veri Yapısını Kurma

Bir  **entity** , bir veri modelinde gerçek dünyadaki bir kavramı veya nesneyi temsil eden ayrı bir nesnedir.

EF Core’da geliştiriciler, veritabanındaki bir tabloya karşılık gelen bir entity’yi tanımlamak için bir C-sharp sınıfı kullanabilir; sınıftaki her özellik ( *property* ) bir sütuna karşılık gelir.

Örneğin, **Book** adlı public bir class düşünün. Kitabın benzersiz tanımlayıcısı için *ID* ve adı için *title* gibi özellikler içerebilir.

Bu özelliklerin her biri, veritabanınızdaki book tablosundaki bir sütuna doğrudan eşlenir ( *maps* ).

---

## 🌉 DB Context ve Veritabanı ile İletişim

Şimdi uygulamanızın veritabanıyla nasıl iletişim kurduğuna odaklanalım.

Bunun için **DB Context** adı verilen bir şey kullanırız.

Entity’ler verinizi organize ederken, **DB Context** uygulamanız ile veritabanı arasındaki bağlantıları ve etkileşimleri yönetir; veritabanı ile kodunuz arasında bir köprü görevi görür.

Şimdi DB Context’in veri modelleme açısından neler yaptığına bakalım.

---

## 🔌 DB Context Ne Yapar?

### 1) 🔗 Bağlantıları Açma ve Yönetme

DB Context, veritabanına bağlantıları açmaktan ve yönetmekten sorumludur.

Uygulamanızın ihtiyaç duyduğunda veritabanına erişebilmesini sağlar ve bu bağlantıların düzgün şekilde yönetildiğinden emin olur.

### 2) 🔄 Veri İşlemleri (CRUD)

DB Context ayrıca veri işlemlerini gerçekleştirmek için yöntemler sağlar.

Bu işlemler **CRUD** işlemleri olarak da adlandırılır; bu, veriyi oluşturma ( *create* ), okuma ( *read* ), güncelleme ( *update* ) ve silme ( *delete* ) anlamına gelir.

Bu işlemler, modelinizdeki entity’leri doğrudan değiştirir ve veritabanına yansır.

### 3) 🧾 Değişiklikleri İzleme

Son olarak DB Context, entity’lerinizde yapılan değişiklikleri izler.

Bir entity eklendiğinde, değiştirildiğinde veya silindiğinde, DB Context bu değişiklikleri takip eder ve veritabanına değişiklikleri kaydederken hangi veritabanı işlemlerinin yapılması gerektiğini belirler.

DB Context, veritabanı iletişiminin karmaşıklığını yönetir; böylece C-sharp içinde entity’lerle çalışabilir ve bunları otomatik olarak veritabanı sorgularına dönüştürebilirsiniz.

---

## 🧾 Kapanış

Bu videoda, veri modelleme kavramını ve EF-Core’daki önemini öğrendiniz.

Veri modellemeyi anlamak, uygulamanızın verisini verimli biçimde yönetmenize ve uygulama mantığınız ile veritabanı arasında sorunsuz entegrasyon sağlamanıza yardımcı olabilir.
