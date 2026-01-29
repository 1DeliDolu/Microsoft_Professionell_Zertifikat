## 🧩 Saklı Yordamları ve Fonksiyonları Oluşturma ve Yönetme

Saklı yordamların ( *stored procedures* ) ve fonksiyonların ( *functions* ) pratik tarafını inceleyelim: onları oluşturmak. Saklı yordamlar ve fonksiyonlara zaten aşina olduğumuza göre, kodun sürdürülebilir ( *maintainable* ) ve etkili olması için en iyi uygulamalar kapsamında onları yazmaya ve çalıştırmaya odaklanalım.

Bu videoda, SQL’de saklı yordamları ve fonksiyonları oluşturma ve çalıştırma sürecini açıklayacağız.

---

## 🧾 Saklı Yordam Oluşturma Adımları

Saklı yordam oluşturma adımlarını açıklayarak başlayacağız.

Önce `CREATE PROCEDURE` ifadesiyle başlarız ve ardından prosedür adını yazarız. Örneğin, yeni bir çalışan eklemek için bir saklı yordam oluşturduğunuzu varsayalım. `CREATE PROCEDURE` ifadesini kullanın ve ardından `ADD NEW EMPLOYEE` gibi benzersiz bir ad yazın.

Prosedür adından sonra, prosedürün alacağı parametreleri tanımlayın. Her parametreyi bir ad ve bir veri tipi ile listeleyin. `ADD NEW EMPLOYEE` için, eklenen kişiyi tanımlamak üzere çalışanın ID’si gibi bazı ayrıntılara ve bir telefon numarası ile e-posta adresine ihtiyacınız olacaktır.

SQL’de bu parametreleri, hangi girdilere ihtiyaç duyduğunu belirtmek için prosedürü adlandırdıktan sonra tanımlarsınız.

Sonra, prosedürün çalıştıracağı ana SQL mantığını ekleyin. Bu; `SELECT`, `INSERT` veya `UPDATE` gibi herhangi bir SQL komutu olabilir. `ADD NEW EMPLOYEE` prosedürünün ana eylemi, `INSERT` anahtar sözcüğünü kullanarak yeni çalışanın bilgilerini veritabanına eklemektir.

Ardından, bir değer döndürmek için veri tipinden sonra `OUTPUT` kullanarak bir çıktı parametresi ( *output parameter* ) tanımlayın. Prosedür içinde çıktı parametresine bir değer atayın.

Örneğin, yeni çalışanın ayrıntılarını ekledikten sonra, yeni çalışanın ID’sini döndürmek için bir output parametresi tanımlayabilirsiniz. Bu output parametresi, prosedür çalıştıktan sonra çalışana atanan benzersiz ID’nin görüntülenmesi gibi bir geri bildirim sağlar.

Prosedürü, tanımın tamamlandığını belirtmek için bir `END` ifadesi ekleyerek bitirin. Görev tamamen tanımlandıktan sonra, daha fazla değişikliğe ihtiyaç olmadığını belirtmek için `END` ile kapatırsınız.

Prosedür oluşturulduktan sonra, `EXEC` ifadesini kullanarak, prosedür adı ve gerekli parametrelerle birlikte çalıştırın.

Prosedürde output parametreleri varsa, çıktıyı saklamak için bir değişken tanımlayın ve bunu `EXEC` ifadesine geçin. Çalıştırma sonrasında, sonucu görmek için değişkeni kontrol edebiliriz.

Bu yaklaşım prosedürleri yeniden kullanılabilir hâle getirir ve tekrar eden görevlerde zaman kazandırır.

---

## 🧠 Fonksiyonlara Geçiş

Şimdi fonksiyonlara geçelim.

SQL fonksiyonları, saklı yordamlardan daha spesifiktir; sorgu içinde kullanılabilecek veri döndürmeye odaklanır.

Scalar veya table-valued olsun, fonksiyon oluşturma adımları benzer olduğu için süreci bu şekilde özetleyeceğiz.

`CREATE FUNCTION` ile başlayın ve ardından fonksiyon adını yazın.

Örneğin, satış vergisini hesaplamak için yeniden kullanılabilir bir formül kurduğunuzu düşünün. Fonksiyonun adı amacını belirtmek için `CALCULATE SALES TAX` gibi açıklayıcı olabilir.

Ardından, fonksiyonun giriş parametrelerini her birini ad ve veri tipiyle listeleyerek tanımlayın.

`CALCULATE SALES TAX` içinde fonksiyon, satış tutarını giriş olarak alabilir ve bu değere göre vergiyi hesaplayabilir.

Sonra, `returns` kullanarak dönüş tipini belirtmeniz gerekir.

`CALCULATE SALES TAX` tek bir değer döndürdüğü için — satış vergisi tutarı — bunu `returns decimal` olarak tanımlarız.

Table-valued fonksiyonlar için `returns table` belirtin, ardından fonksiyonun mantığını ekleyin.

Scalar fonksiyonlar için, döndürmek istediğiniz hesaplamayı veya değeri belirtmek üzere `return` ifadesini kullanın; örneğin basit bir matematiksel işlem.

`CALCULATE SALES TAX`, vergi tutarını elde etmek için satış tutarını vergi oranı ile çarpmalıdır. Bu basit matematiksel işlem, fonksiyon mantığının çekirdeğini oluşturur.

Table-valued fonksiyonlar için `return` ifadesi, giriş parametrelerine göre bir satır kümesini getiren bir `SELECT` sorgusu içermelidir. Bu, fonksiyonun yalnızca tek bir değer yerine tüm bir tablo döndürmesine olanak tanır.

Fonksiyon tanımını tamamlamak için `END` ifadesiyle fonksiyonu bitirin.

Son olarak, fonksiyonu çalıştırın.

---

## ▶️ Fonksiyonları Çalıştırma

Tanımlandıktan sonra, scalar fonksiyonlar bir sorgu içinde hesaplanan bir değer döndürmek için kullanılabilir; örneğin bir `SELECT` ifadesinde.

Örneğin, bir raporda hesaplanmış vergi tutarına ihtiyacınız varsa, bu fonksiyonu `SELECT` ifadesinde kullanarak hesaplamayı sorgu sonucunun bir parçası olarak döndürebilirsiniz.

Table-valued fonksiyonlar için, fonksiyonu `FROM` bölümünde kullanabilir ve fonksiyonu bir tablo gibi ele alabilirsiniz; bu, yeniden kullanılabilir parametreli sorgular için özellikle faydalıdır.

---

## ✅ En İyi Uygulamalar

Saklı yordamlarınızın ve fonksiyonlarınızın güvenilirliğini ve sürdürülebilirliğini sağlamak için bazı en iyi uygulamaları tartışalım.

Öncelikle, parametrelerinizi her zaman doğrulayın. SQL’de bu, her girişin belirli kriterleri karşıladığını kontrol etmek anlamına gelir. Beklenmedik davranışları önlemek için, gerekli olduğunda girdileri geçerli değer aralıklarına göre kontrol edin.

Örneğin, bir parametre her zaman pozitif olmalıysa, işlemeye geçmeden önce bu şartı sağladığından emin olun.

Parametre doğrulamaya ek olarak, sorunları yönetmek için saklı yordamlarınıza ve fonksiyonlarınıza hata yönetimi ( *error handling* ) eklemek kritik öneme sahiptir. Böylece bir şeyler ters giderse sistem bozulmadan sorun yakalanır ve çözümlenebilir.

Hataları yakalamak, loglamak veya özel bir mesaj döndürmek için try-catch bloklarını kullanabilirsiniz; bu da hata ayıklamayı ve bakımı kolaylaştırır.

Son olarak, saklı yordamları ve fonksiyonları diğer kodlar gibi ele alın ve değişiklikleri takip etmek, önceki çalışmaları ezmemek için sürüm kontrolü ( *version control* ) kullanın.

Bu, özellikle birden fazla kişinin farklı veritabanı bölümleri üzerinde çalıştığı ekip ortamlarında çok değerlidir. İş birliği yapılan ortamlarda sürüm kontrolü, ekip üyelerine birbirlerinin ne yaptığını görme imkânı sağlar ve olası çakışmaların hızlıca çözülmesine yardımcı olur.

Bu da, birden fazla kişinin aynı anda ilişkili kodlar üzerinde çalıştığı durumlarda sorunları önler.

---

## 🏁 Kapanış

Bu videoda, SQL’de saklı yordamları ve fonksiyonları oluşturma ve çalıştırma sürecini öğrendiniz.

Bu uygulamalar ve saklı yordamları ile fonksiyonları oluşturup çalıştırma süreci sayesinde, artık SQL mantığınızı etkili biçimde yönetmek için gereken araçlara sahipsiniz.
