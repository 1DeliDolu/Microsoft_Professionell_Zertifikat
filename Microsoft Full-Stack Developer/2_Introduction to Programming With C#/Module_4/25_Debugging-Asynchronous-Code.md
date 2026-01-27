## 🐞 Asenkron Kodda Hata Ayıklama

Asenkron kod başarısız olduğunda, yalnızca küçük sorunlara yol açmaz; projenizi tamamen raydan çıkarabilir. Hatalar hiç beklemediğiniz yerlerde saklanabilir, en kötü zamanda ortaya çıkabilir ve neyin yanlış gittiğini anlamaya çalışırken sizi telaşa sürükleyebilir.

Asenkron işlemlerin öngörülemez doğası, özellikle teslim tarihleri yaklaşırken, hata ayıklamayı ustalaşılması gereken kritik bir beceri hâline getirir. Doğru araçları ve stratejileri kullanarak kodunuzdaki sorunları verimli şekilde tespit edip düzeltebilirsiniz. Şimdi asenkron kodu etkili biçimde hata ayıklamak için gerekli temel teknikleri ve araçları inceleyelim.

Bu videoda, asenkron kodda hata ayıklama becerileri geliştirmeyi öğreneceksiniz. Önce asenkron kodun ne olduğunu gözden geçirelim.

Asenkron kod, ana program akışından bağımsız çalışır ve programın **task** adı verilen yeni işlemler başlatmasına olanak tanır.  **Task** ’ler, önceki işlemlerin tamamlanmasını beklemek zorunda kalmadan çalışır. Görevler bağımsız çalıştığı için, hata ayıklamak da belirli teknikler gerektirir; böylece yalnızca hataların nerede olduğunu değil, ne zaman oluştuğunu da belirleyebilirsiniz.

---

## ⚠️ Asenkron Kodda Hata Ayıklamanın Zorlukları

Şimdi geliştiricilerin asenkron kodu hata ayıklarken karşılaştığı zorlukları ve bunların nasıl aşılacağını inceleyelim. İlk olarak *doğrusal olmayan yürütme (nonlinear execution)* ile başlayacağız.

### 🔀 1) Doğrusal Olmayan Yürütme

Asenkron kod belirli bir sırayla çalışmadığı için, doğrusal olmayan yürütme; hangi görevlerin çalıştığını ve ne zaman biteceklerini izlemeyi zorlaştırır.

### 🤫 2) Sessiz Hatalar ( *Silent Failures* )

Asenkron koddaki hatalar hemen görünmeyebilir ve sessiz başarısızlıklara yol açabilir. Asenkron kod arka planda çalıştığı için ana program çalışmaya devam eder ve her şey normalmiş gibi görünebilir.

Asenkron görev başarısız olduğunda ancak bir semptomla karşılaştığınızda bir şeylerin ters gittiğini fark edersiniz.

### 🏁 3) Eşzamanlı Çalışan Görevlerde Sorunlar ( *Race Condition* )

Görevler aynı anda çalıştığında ortaya çıkan sorunları hata ayıklamak özellikle zordur. Buna örnek olarak **race condition** verilebilir; iki veya daha fazla görev aynı anda paylaştıkları kaynaklara erişmeye çalıştığında oluşur.

Bu, öngörülemez sonuçlara yol açabilir. Ayrıca sorunun nerede olduğunu izlemeyi zorlaştırır; çünkü yürütme sırası program her çalıştığında değişebilir. Sonuç olarak hatalar her zaman aynı şekilde ortaya çıkmaz; bu da neyin neden olduğunu ve nasıl düzeltileceğini bulmayı güçleştirir.

---

## 🧰 Asenkron Kodda Yaygın Hata Ayıklama Teknikleri

Şimdi geliştiricilerin asenkron kodda sorunları bulmak için kullandığı yaygın teknikleri inceleyelim.

### 🧷 1) Breakpoint Kullanarak Kodu İnceleme

Asenkron kodu hata ayıklamak için, belirli satırlarda kod yürütmesini durdurmak amacıyla **breakpoint** kullanabilirsiniz. Program durdurulduğunda o anki uygulama durumunu inceleyebilirsiniz.

Değişken değerlerini görebilir, hangi kodun az önce çalıştığını ve hangi kodun çalışmak üzere olduğunu inceleyebilirsiniz. Asenkron kod ana programdan bağımsız çalıştığı için, hem ana programda hem de asenkron kodda breakpoint’ler ayarlayarak hataya hangi kısmın neden olduğunu öğrenebilirsiniz.

### 📌 2) Task Durumunu Kontrol Etme

İkinci teknik, başlattığınız task’lerin durumunu kontrol etmektir: beklemede mi ( *pending* ), çalışıyor mu ( *running* ), tamamlandı mı ( *completed* ), yoksa işi tamamlayamayıp başarısız mı oldu ( *failed* )?

C#’ta task’leri, mevcut durumu gösteren **Status** özelliğini kontrol ederek inceleyebilirsiniz. Durumlarını loglayarak veya breakpoint’lerle task state’i inceleyerek, herhangi bir nedenle başarısız olup olmadığını belirleyebilirsiniz.

### 🧯 3) Olası Hataları Ele Alma

Üçüncü olarak, asenkron kodunuzdaki olası hataları ele alarak bug’ları bulabilirsiniz. Bu, asenkron kodu programınızın çökmesini önleyecek ifadelerle sarmalamayı içerir.

Hata, zarar vermeden önce yakalanır. Uygun hata yönetimi uyguladığınızda, asenkron görevlerdeki hatalar yakalanır ve ne olduğunu söyleyen bir log kaydı oluşturabilirsiniz.

Kod bu hataları otomatik olarak yakaladığı için, her seferinde breakpoint koyup kodu yakından analiz etmenize gerek kalmaz. Programın tuttuğu logları inceleyerek bir hata oluşup oluşmadığını kontrol edebilirsiniz.

---

## 🧩 Visual Studio Code Araçları

Visual Studio Code gibi modern araçlar, asenkron kodda hata ayıklamaya yardımcı olacak özellikler sunar. Şimdi bunlardan bazılarını inceleyelim; **Visual Studio Code debugger** ile başlayalım.

### 🧩 1) Visual Studio Code Debugger

Visual Studio Code’daki ilk özellik bir eklenti ( *extension* ) üzerinden kullanılabilir. Microsoft’un resmi  **C# extension** ’ı, asenkron kodu hata ayıklamanızı sağlar.

Eklentiyi yükledikten sonra, breakpoint ayarlayabilir, kod içinde adım adım ilerleyebilir, değişkenleri ve çalışan task’leri doğrudan editör içinde inceleyerek **async** metotları ve **Task** nesnelerini debug edebilirsiniz.

### 🧭 2) Task Explorer Extension

İkinci özellik olan  **Task Explorer extension** , kodunuzdaki task’leri izleyip yönetmenizi sağlar.

Task Explorer, asenkron task’lerin durumunu incelemenize yardımcı olur ve sorunları tespit edip gidermeyi kolaylaştırır.

### 🪵 3) Logpoints

Üçüncü özellik, breakpoint yerine kullanabileceğiniz  **logpoints** ’tir. Logpoints, programı durdurmadan değişken değerlerini ve mesajları konsola yazar.

Bu, asenkron task’ler çalışırken onların hakkında bilgi toplamanızı sağlar.

### 🧵 4) Call Stack Aracı

Dördüncü ve son özellik **call stack** aracıdır. Bu araç, asenkron olanlar dahil metot çağrılarının sırasını takip etmenizi sağlar.

Debugger içinde **call stack** panelini kullanarak programın nasıl çalıştığını izleyebilir ve asenkron metotların hangi sırayla çağrıldığını analiz edebilirsiniz.

Visual Studio Code araçlarını hata ayıklama teknikleriyle eşleştirmek, asenkron kodu debug etmenin zorluklarının üstesinden gelmenize yardımcı olabilir.

---

## ✅ Kapanış

Bu videoda, asenkron kodda hata ayıklama becerileri geliştirdiniz. Yaygın hata ayıklama tekniklerini inceledik, asenkron kodda hata ayıklamanın zorluklarını ve çözümlerini tartıştık ve Visual Studio Code’da bu sürece yardımcı olan araçlara baktık.

Bu tekniklere ve araçlara hâkim olarak, asenkron kodu verimli biçimde hata ayıklayabilir ve uygulamalarınızın sorunsuz çalışmasını sağlayabilirsiniz.
