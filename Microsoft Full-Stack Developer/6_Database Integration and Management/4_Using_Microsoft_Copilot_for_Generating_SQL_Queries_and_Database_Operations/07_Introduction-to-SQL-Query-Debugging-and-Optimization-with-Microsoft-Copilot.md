## 🧰 Microsoft Copilot ile SQL Sorgusu Hata Ayıklama ve Optimizasyona Giriş

SQL’deki hatalar veya verimsizlikler, yavaş performansa ya da yanlış veri çekmeye neden olabilir; bunları manuel olarak tespit edip çözmek zor olabilir. Microsoft Copilot, SQL sorgularını hata ayıklamak ( *debugging* ) ve optimize etmek ( *optimization* ) için güçlü bir araçtır. Sorunları belirlemeyi ve sorgu performansını iyileştirmeyi kolaylaştırır.

Bu videoda, Microsoft Copilot’un SQL sorgularını hata ayıklama ve optimize etme işlevselliğini açıklayacağım. Hadi başlayalım.

---

## 🪟 Yeni Copilot Penceresi ile Başlama

Burada Copilot’un yeni açılmış bir penceresini görebilirsiniz. Yine, önceki bir konuşmayı kullanmak yerine yeni bir pencere açmanızı her zaman öneririm; böylece o bağlam ( *context* ) karışmamış olur.

---

## 🐞 SQL Hatalarını Tespit Etme

Şimdi Copilot’u SQL sorgularındaki hataları tespit etmek gibi şeyler için kullanabiliriz. Basitçe bir sorguyu alabiliriz; mesela içinde hata olan şu sorgu gibi.

Ve belki Copilot’tan önce siz fark edebilirsiniz.

“Bu SQL sorgusunu debug et” diyeceğim.

Ve burada, `ON` ifadesinin eksik olduğunu yakalıyor. Bu, sorgu yazarken bazen yorgun olduğunuzda ya da yanlışlıkla bir şey eklediğinizde bulması zor olabilecek bir hataya güzel bir örnek.

Bu tür durumlarda Copilot hatayı hızlıca bulmak için gerçekten faydalı bir araç.

Bu nispeten basit bir örnek, ama yüzlerce satırlık bir SQL sorgusu yazdığınızı hayal edin. Bu, eksik bir noktalama işareti ya da yanlış yerde tek bir karakter gibi şeyleri tespit etmeyi çok zorlaştırabilir.

Copilot bu tür şeyleri çok hızlı yakalayabilir.

---

## ✍️ Yazım Hatalarını Yakalama

Copilot’un çok iyi yaptığı bir başka şey de yazım hatalarını tespit etmektir.

Bazen kodlama araçlarınız bunu yakalamaz. Bir kelimeyi yazmak isterken yanlışlıkla farklı bir kelime yazmış ya da yanlış yazmış olabilirsiniz.

Burada bir typo içeren bir örnek var.

Yine “lütfen bu kodu debug et” diyebiliriz ve bakalım siz Copilot’tan önce sorunu yakalayabilecek misiniz.

Copilot, *salaries* kelimesini yanlış yazdığımızı yakalıyor.

Bu, kodlama aracınızın yakalamayabileceği ama Copilot’un yakalayabileceği bir şeye çok iyi bir örnek.

---

## 🧠 Mantıksal Hataları Bulma

Copilot, yanlış filtreleme veya yanlış gruplama gibi mantıksal hatalarda da yardımcı olabilir.

Diyelim ki bir sorgum var ve departmana göre çalışanları getirmesi gerekiyor ama doğru sonuçları döndürmüyor.

Bu sorgu burada.

Tekrar “bu sorguyu debug et” diyebilirim.

Ve burada, basit bir işlem yaptığımız ve herhangi bir toplulaştırma ( *aggregation* ) yapmadığımız hâlde `HAVING` kullandığımızı yakalıyor; bunun yerine filtreleme için uygun yere göre sorgu yapısını düzeltmemiz gerektiğini söylüyor.

`HAVING`, aggregate fonksiyonlarla birlikte kullanılır; burada ise herhangi bir aggregation yok.

Bu, Copilot’u SQL sorgularını debug etmek için kullanacağınız temel durumları kapsıyor.

Yine, bunlar küçük örnekler; hızlı bir videoda anlaşılması için. Ama çok büyük kod bloklarını da rahatça gönderebilir ve yardımcı olup olamayacağını görebilirsiniz.

Her zaman geri dönen sonucu test etmenizi öneririm, ama çoğu zaman sorunu çözmenize yardımcı olacaktır.

---

## ⚙️ SQL Sorgularını Optimize Etme

Şimdi bir başka alanı inceleyebiliriz: SQL sorgularını optimize etmek.

Copilot, sorgu performansını artırmak için çeşitli optimizasyon önerileri sunabilir.

Bu sonraki sorguya bakalım; diyelim ki bu sorgu yavaş çalışıyor.

Şöyle bir şey söylemek istiyorum: “Bu yavaş çalışan sorguyu optimize etmeme yardım et.”

Copilot, muhtemelen buraya bir indeks eklemek isteyebileceğimizi yakalıyor.

Ayrıca, veri miktarını azaltmak için yalnızca gerekli kolonları seçmemizi söylüyor. Bu örnekte biz bunu zaten yapıyoruz.

Bu, sorgularda yaygın bir problemdir.

Burada görebileceğiniz gibi bazen kodunuzda olmayan bir şeyi varmış gibi varsayabilir. Bu, “hallucination” olarak bilinir.

Yani burada, sorgularda tipik olarak olan bir sorunu varsayıyor ama bizim sorgumuzda bu problem yok.

Bunun yanında, `EXISTS` veya `IN` kullanarak sorguyu daha verimli hâle getirmeye dair bir öneri de sunuyor.

Bu, test etmek isteyeceğim bir şey olurdu.

Normalde, bir sorguyu çok sık çalıştırmıyorsanız bu kadar ince ayar yapmak istemezsiniz; genellikle “yeterince iyi” çalışır.

Burada “sorgunun optimize edilmiş versiyonu” var diyor ve bir başka yaklaşım daha sunuyor.

Belki bunu bazı profiling araçlarıyla test etmek ve gerçekten sorunu iyileştirip iyileştirmediğini görmek isteyebilirsiniz.

---

## 🧱 Karmaşık Sorguları Yeniden Yapılandırma

Bunun gibi bir aracın bir diğer yaygın kullanımı da karmaşık sorguları yeniden yapılandırmaya yardımcı olmasıdır.

Bu, kodun daha kolay sürdürülebilir ( *maintainable* ) olmasını sağlar.

Şu diğer örneğe bakalım.

Hâlâ nispeten küçük, ama biraz daha karmaşıklaşmaya başlamış.

Kodumuz burada.

Şunu söylemek istiyoruz: “Bu sorguyu daha iyi verimlilik ve yönetilebilirlik için yeniden yapılandır.”

Burada, common table expressions ( *CTEs* ) kullanmamızı ve uygun indekslere sahip olduğumuzdan emin olmamızı öneriyor.

Ve burada bir sürü indeks oluşturmayı öneriyor.

Bunların hepsini gerçekten oluşturmak isteyeceğimizden emin değilim. Yine, bu biraz “ağır” bir yaklaşım olabilir.

Ama burada sorguyu oldukça bölüp parçalamış olduğunu görebilirsiniz.

Bu, süreci yönetmemizi ve düşünmemizi daha verimli hâle getirebilir.

Hızlıca şunu görebilirsiniz: farklı sorgular var ve bunlar daha büyük sorgu içinde yeniden sorgulanıyor.

Orijinale baktığınızda, burada neler olup bittiğini hızlıca görmek biraz daha zor.

---

## ✅ Kapanış

Böylece Copilot’u sorgularınızı debug etmek için nasıl kullanabileceğinizi ve aynı zamanda onları daha verimli hâle getirmeye nasıl yardımcı olabileceğini öğrendiniz.

Bunlar yine oldukça basit örnekler.

Ama ben her zaman şunu öneririm: emin değilseniz, kodunuzu Copilot’a atıp yardımcı olup olamayacağını deneyin.

Çünkü belirli bir durumda yardımcı olup olamayacağını çok hızlı öğrenirsiniz.

Bu, kodu kopyalayıp Copilot’a yapıştırıp istediğiniz şekilde yardım istemek dışında size birkaç saniyeden başka bir şeye mal olmaz.

Bu videoda, Microsoft Copilot’un SQL sorgularını hata ayıklama ve optimize etmede nasıl yardımcı olabileceğini öğrendiniz.

Copilot, sözdizimi ( *syntax* ) ve mantık ( *logical* ) hatalarını tespit edip çözmenize inanılmaz fayda sağlar.

Copilot, indeks ( *indices* ) gibi şeyleri bulmanıza yardımcı olarak performansı iyileştirebilir ve kodunuzu daha yönetilebilir hâle getirebilir.

Bu özellikler, SQL veritabanlarını yönetmeyi ve optimize etmeyi kolaylaştırır; size çok zaman kazandırır ve güvenilir, yüksek performanslı sorgular sağlar — programcılar olarak her zaman hedeflediğimiz şey de budur.
