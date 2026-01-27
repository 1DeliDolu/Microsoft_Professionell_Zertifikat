## 🧬 Kalıtım

Hiç, eski bir şeyi sıfırdan başlamadan alıp daha iyi hâle getirmeyi dilediniz mi? Nesne yönelimli programlama, bunu *kalıtım (inheritance)* kavramı üzerinden ele alır; bu kavram geliştiricilerin kodu yeniden kullanmasını, ancak yalnızca gerektiği kadar değiştirmesini ve genişletmesini sağlar.

Bu videoda, nesne yönelimli programlamada kalıtım kavramını açıklayacağız. Kalıtımın tanımıyla başlayalım.

---

## 🧠 Kalıtımın Tanımı

Kalıtım, nesne yönelimli programlamada geliştiricilerin mevcut sınıflara dayalı yeni sınıflar oluşturmasını sağlayan temel bir kavramdır.

Biyolojideki kalıtıma benzer şekilde, kod kalıtımı da sınıfların başka sınıflardan özellikleri miras almasını sağlar. *Türetilmiş sınıf (derived class)* olarak bilinen yeni bir sınıfın, mevcut sınıftan öznitelikleri ( *attributes* ) ve metotları ( *methods* ) miras almasına imkân verir.

Bu mevcut sınıfa *üst sınıf (super class)* veya *taban sınıf (base class)* denir.

---

## 🏗️ Türetilmiş Sınıfın Genişletilmesi

Bir geliştirici türetilmiş bir sınıf oluşturduğunda, taban sınıfın özniteliklerini ve metotlarını elde eder; ancak sınıfını kendi özniteliklerini ve metotlarını ekleyerek de genişletebilir.

Bu, geliştiricinin taban sınıftaki kodu yeniden üretmek zorunda kalmadan yeniden kullanmasını sağlar. Ayrıca sınıfa daha fazla özellik ekleyebilir ve gerekirse orijinal öznitelikleri ve metotları bile değiştirebilir.

Yeni ve değiştirilmiş özellikler türetilmiş sınıfa özgüdür ve taban sınıfı etkilemez.

---

## 👨‍👩‍👧 Ebeveyn–Çocuk Benzerliği

Türetilmiş sınıf ile taban sınıf arasındaki ilişki, bir çocuk ile ebeveyn arasındaki ilişkiye benzer.

Çocuk, cilt rengi, burun şekli ve boy gibi ebeveynlerin birçok benzer özelliğine sahip olabilir; ancak saç rengi ve kişilik gibi kendine özgü özellikler geliştirir.

---

## 🌳 Kodda Hiyerarşi ve Ağaç Yapısı

Bu ilişki, kodda yeniden kullanımı teşvik eden bir hiyerarşi oluşturur. Ayrıca geliştiricilerin kodu daha verimli biçimde organize etmesine ve yönetmesine olanak tanır.

Kalıtım, sınıflar arasında ağaç benzeri bir yapı oluşturur. Örneğin, bir *bird* sınıfı, *eagle* ve *parrot* gibi türetilmiş sınıflar için bir taban sınıf olabilir.

Hem *eagle* hem de  *parrot* , *fly* gibi ortak öznitelik ve metotları *bird* sınıfından miras alır; ancak kendi benzersiz özelliklerine de sahip olabilir.

* *Eagle* türetilmiş sınıfı *hunt* metodunu içerebilir.
* *Parrot* türetilmiş sınıfı ise *speak* metodunu içerebilir.

Bu ek metotlar taban sınıfın bir parçası hâline gelmez; türetilmiş sınıflara özgü kalır.

---

## ✅ Sonuç

Kalıtımı kullanarak geliştiriciler mevcut kodu yeniden kullanabilir ve ek işlevsellikle genişletebilir. Bu, kod yeniden kullanımını teşvik eder ve tekrarları azaltır.

Bu videoda, nesne yönelimli programlamada kalıtım kavramını tanımlamayı öğrendiniz. Kalıtım, geliştiricilerin mevcut sınıflardan özellikleri ve metotları miras almasına ve hiyerarşik ilişkiler oluşturmasına olanak tanır.

Bu kavramı uygulamalarına uygulayan geliştiriciler, mevcut işlevleri yeniden kullanmayı ve genişletmeyi teşvik ederek verimli ve düzenli kod yazabilirler.
