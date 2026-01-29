## 🤖 Microsoft Copilot ile SQL Sorgusu Yazmaya Giriş

SQL sorguları yazmak zaman alıcı ve hataya açık olabilir; işte bu noktada Microsoft Copilot web arayüzü gerçekten yardımcı olabilir. Daha hızlı, daha verimli ve daha doğru SQL sorguları için yapay zekâ destekli yardım sağlar.

Bu videoda, SQL sorguları üretmek için Microsoft Copilot’un temel işlevlerini açıklayacağım. Hadi başlayalım.

---

## 🌐 Microsoft Copilot’a Erişim

Önce Microsoft Copilot’a erişeceğim. Bunu yapmanın bir sürü farklı yolu var. `copilot.microsoft.com` var, ayrıca burada aşağıda Copilot simgesi de var.

Ama benim favori yolum aslında Edge üzerinden. Bence şu anda Copilot uygulamalarının en tam özellikli olanı bu. Burada Copilot’u açarsam, Copilot’u göreceksiniz.

Copilot bir yapay zekâ asistanıdır. Bir metin istemi ( *text prompt* ) girersiniz ve size metin olarak yanıt verir; yani farklı şeyler yapmasını isteyebilirsiniz. Genel bir soru sorabilirsiniz. Sizin için kod gibi bir şey üretmesini isteyebilirsiniz.

Bu durumda SQL kodu üreteceğiz.

---

## 🗂️ Geçmiş ve Yeni Sohbet Başlatma

Burada daha önce çalıştırdığım bazı sorgular var; yani geçmişinizi burada görebilirsiniz. Aşağıda, yeni bir sohbet başlatabileceğiniz bir buton da var.

Genellikle tek, büyük ve uzun süren bir sohbet istemezsiniz; çünkü bu modellerin “context” denilen bir şeyi vardır. Eğer orada bir sürü bilgi bırakırsanız, bir noktada kafası karışacaktır. Yani “az önce tavuk nugget’larından bahsediyorduk, şimdi SQL sorgularından konuşmak istiyorsun” gibi.

Bu yüzden her zaman yeni bir sohbet başlatmanızı öneririm.

---

## 🧱 İlk İstem: SQL Tabloları Üretme

İlk istemimizi Copilot’a soralım.

SQL tabloları oluşturmasını istiyoruz, bu yüzden şunu söyleyeceğim: “SQL tabloları üret.” İki tane istiyorum: biri  *employees* , biri de *departments* için.

*Employees* tablosunda sütunlar şunlar olmalı:  *employee ID* ,  *name* ,  *salary* , *hire date* ve  *department ID* .

Ve fark edeceksiniz, burada bir sürü yazım hatası ( *typo* ) var. Bu tür modeller için hiç sorun olmuyor. Metni olduğu gibi yazabilirsiniz ve gayet iyi çalışır.

Ben genelde büyük, uzun, akıp giden cümleler yazmayı seviyorum. Tamamen çalışıyor. Metni biçimlendirmek için çok fazla zaman harcamamanızı kesinlikle öneririm.

Sonra bir de şunu söyleyeceğiz: *departments* için bir *ID* ve bir *department name* olmalı.

Ve bunu çalıştıracağım.

---

## 🧠 Üretilen SQL’i Kontrol Etme ve “Hallucinating” Uyarısı

Burada biraz belirsizdim. “Sadece SQL tabloları üret” dedim; ama aslında benim için bu tabloları oluşturacak SQL ifadelerini oluşturacak kadar “akıllı”.

Her zaman “hallucinating” olarak bilinen şeyi yapıp yapmadığını kontrol etmek istersiniz. Yani istemediğiniz şeyleri uydurmuş olabilir. Garip bir şey koymuş olabilir.

Ama burada bir *departments* tablosu görüyoruz; şu *int primary key* ile. Bana mantıklı geliyor. *Department name* bir `VARCHAR(100)`. Bence bu bizim için çalışır.

*Employees* tarafında bir ID var. *Name* bir `VARCHAR`. *Salary* bir `decimal`. *Hire date* bir `date`. *Department ID* bir `int`. Ve bir  *foreign key* . Harika.

Bu çok iyi görünüyor.

---

## 🧩 SQL “Flavor” Bağlamını Belirtme

Burada isteyebileceğiniz bir şey de, hangi SQL çeşidini ( *flavor* ) kullandığınızı belirtmek.

Belki Postgres kullanıyorsunuz. Belki SQLite kullanıyorsunuz. Belki Microsoft SQL Server kullanıyorsunuz. Veri tiplerinde ve çalışabildikleri bazı şeylerde küçük farklılıklar var. Bu da farkında olunması gereken bir şey.

İhtiyaç duyduğu bağlamı vermezseniz, tam olarak kullanamayacağınız bir kod üretebilir.

Bu örnekte genel gidiyoruz. Bu kodun Postgres gibi bir şeyde çalışabileceği görünüyor.

Ve tablolarımız burada.

---

## 📊 Ortalama Maaş Sorgusu ve HAVING

Şimdi diyelim ki buna karşı bazı sorgular çalıştırmak istiyorum.

Her departmandaki çalışanlar için ortalama maaşı istiyorum, ama yalnızca beşten fazla çalışanı olan departmanları dahil ederek. Şunu söyleyeceğim:

“Beşten fazla çalışanı olan her departmanda çalışanlar için ortalama maaşı seçen bir SQL sorgusu yaz.”

Yukarı kaydırabilirsiniz. Arayüzlerinde çok belli değil ama bizi bir sonraki soruya doğru aşağıya attı.

Burada şunu görüyoruz: “beşten fazla çalışanı olan her departmanda çalışanlar için ortalama maaş.”

Ve sorgu şu şekilde kurulmuş:

```sql
select average salary for employees in each department with more than five employees.
the department name,
average salary as average salary
from employees,
join department,
group by department name,
having count employee ID is greater than five
```

Bu o kadar iyi bir örnek ki: `group by` var, `having` var. Bu, bu sorguları bir araç kullanmadan kolayca bozabileceğiniz türden şeylerden.

Burada bir hata olması mümkün. Bu kodu her zaman çalıştırmak, belki örnek veri koyup gerçekten çalıştığından emin olmak isterim.

Ama teorik olarak uygulamamızda kullanabileceğimiz bir kod üretiyor.

---

## 🗓️ 2020 Sonrası İşe Alınanları Dahil Etme

Şimdi diyelim ki sonuçlara 2020’den sonra işe alınan çalışanları dahil etmek istiyorum. Yani burada filtreleme yapmak istiyoruz.

Şunu söyleyeceğim: “Yalnızca 2020’den sonra işe alınan çalışanları dahil edecek bir koşul ekle.”

Ve şimdi burada şunu görebilirsiniz; bir yazım hatası olsa bile şu koşulu ekliyoruz:

```sql
WHERE E.hireDate is greater than 2020-01-01
```

Yine, bu çok iyi; çünkü sorgumun içine girip değiştirmem gereken yeri bulup değişiklik yapmak zorunda kalmıyorum.

Bu görece basit bir sorgu, ama 80–100 satırlık büyük bir “tuğla” üzerinde çalıştığınızı hayal edin; bu SQL sorgularında olur. Orada çok karmaşık bir mantık olabilir ve bu tür araçlar bunu ayrıştırmada gerçekten iyidir.

---

## 🧾 Çalışan Adı ve Departman Adı Raporu

Şimdi diyelim ki bir rapor istiyorum; her çalışanın adını ve ait olduğu departmanın adını içersin.

Şunu söyleyebilirim: “Çalışan adlarını ve departman adlarını gösteren bir SQL sorgusu yaz.”

Sonra da şunu ekleyeceğim: “Çalışan adına göre sırala.”

Ve burada şu sorgu var:

```sql
select E.name as employee name,
D.department name
from employee E,
join departments D on E.department ID equals D.department ID,
order by E.name
```

İstediğimiz her şeyi yakalamış gibi görünüyor.

---

## 🧠 Belirsiz ve Karmaşık Durumlarda Copilot’tan Yardım Alma

Şimdiye kadar, ne istediğimizi zaten bildiğimiz durumlarda sorgular ürettik.

Ama Copilot, örneğin nasıl yapılacağını bilmediğimiz karmaşık bir join ile karşılaşırsak da çok faydalı olabilir. Düz bir dille bir şey yapmasını isteyebilirsiniz.

Mesela şöyle diyebilirsiniz: “Join’lerimde tekrar eden sonuçlar ( *duplicate results* ) alıyorum ama tekil çalışanlar istiyorum. Bunu ele almak için bazı seçenekler neler?”

Bunu gönderebilirim ve bana seçenekler verir. Şunları söyleyebilir:

* `distinct` kelimesini kullan
* `group by` kullan
* alt sorgu ( *subquery* ) kullan
* pencere fonksiyonu ( *window function* ) kullan

Şimdi farklı seçenekler veriyor; ben de bunlara bakabilirim.

Sonra bir takip sorusu sorabilirim; “Bunlardan hangisi en performanslı? Bu farklı yöntemleri kullanmanın ödünleşimleri ( *trade-offs* ) neler?” gibi.

İşte bu araçlar burada gerçekten çok faydalı oluyor.

SQL gibi bir araç hakkında temel bilginiz varsa, Copilot gibi bir araç bunu genişletmenize izin verir.

Eğer okuyabiliyorsanız, anlayabiliyorsanız ve bunun mümkün olduğunu biliyorsanız; Copilot’u daha önce yapmadığınız, nasıl yapılacağını bilmediğiniz ya da rahat olmadığınız çok karmaşık şeyleri uygulamak için kullanabilirsiniz.

---

## ✅ Kapanış

Bu videoda, SQL sorguları üretmek için Microsoft Copilot’un bazı temel işlevlerini öğrendiniz.

Microsoft Copilot ile SQL veritabanlarını sorgulamak için güçlü bir asistana sahipsiniz.
