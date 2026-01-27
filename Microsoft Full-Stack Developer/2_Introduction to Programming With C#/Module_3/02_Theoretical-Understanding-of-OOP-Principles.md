
## 🧠 OOP İlkelerinin Teorik Anlaşılması

Tıpkı bir postanenin hizmetlerini kullanmak için onun iç işleyişini anlamanıza gerek olmadığı gibi, geliştiricilerin de bir sınıfla etkileşim kurmak için sınıfın iç detaylarını bilmesine gerek yoktur.

Geliştiriciler, kodlarının nasıl kullanıldığını basitleştirmek için *kapsülleme (encapsulation)* ve *soyutlama (abstraction)* ilkelerini kullanır. Bu videoda, nesne yönelimli programlamada kapsülleme ve soyutlama ilkelerini nasıl açıklayacağınızı ve bunların bir nesnenin iç durumunu nasıl koruduğunu ve kullanımını nasıl basitleştirdiğini öğreneceksiniz.

Önce kapsülleme ile başlayalım.

---

## 🔒 Kapsülleme

Kapsülleme, metotları ve verileri bir sınıf içinde bir araya getirme ve sınıfın bazı bileşenlerine erişimi kısıtlama ilkesidir.

Bu, sınıfın verilerine erişilebileceği ve bu verilerin değiştirilebileceği arayüzlerin yönetilmesiyle yapılır. Geliştiriciler bu ilkeyi uyguladığında, bir nesnenin iç durumunu dış koddan gizli tutar ve yalnızca gerekli olanı dışarıya açar.

---

## 🧰 Kapsülleme ile Sınıf Oluşturma

Kapsülleme, bir nesnenin iç durumunu; özniteliklerine ve metotlarına erişimi yöneterek korur.

Geliştiriciler, diğer kodun hangi verilere ve metotlara erişebileceğini ve verilerin nasıl değiştirilebileceğini yönetmek için  *private* , *protected* ve *public* gibi erişim belirleyicilerini ( *access modifiers* ) kullanır.

Örneğin, bir bankanın bir uygulama geliştirdiğini ve kodun, bir müşterinin hesabıyla ilgili verileri yönetmek için veri ve metotlar içeren bir *bank account* sınıfına sahip olduğunu varsayalım.

*balance* özniteliği, müşterinin hesap bakiyesi verisini saklar. Geliştirici, diğer kodların bu özniteliği okumasına izin veren herkese açık ( *public* ) bir *GetBalance* metodu sağlayabilir, ancak özniteliğe yazmayı sağlayan hiçbir metot sunmayabilir.

Kapsülleme, geliştiricilerin nesnenin bazı kısımlarını *public* metotlar aracılığıyla uygulamanın herhangi bir koduna açmasına olanak tanır.

---

## 🛡️ Public ve Protected ile Erişim Kontrolü

Geliştiriciler ayrıca bazı kısımları yalnızca sınıftan miras alan ( *inherit* ) uygulama bölümlerine *protected* metotlar aracılığıyla açabilir.

Bu ilkeler, geliştiriciye sınıfın hangi bölümlerinin açığa çıkarılacağı ve ne kadar geniş bir şekilde açığa çıkarılacağı konusunda ince ayarlı kontrol sağlar.

Banka hesabı sınıfının, bankanın hesaba uyguladığı mevcut faiz oranını saklayan bir *interest rate* özniteliğine sahip olduğunu varsayalım. Geliştirici, *interest rate* özniteliğinin açığa çıkmasını istemez; bu yüzden ona erişim sağlayan hiçbir metot oluşturmaz.

Ancak insanların para yatırma ve para çekme işlemleri yapabilmesini ister; bu yüzden bu faaliyetleri mümkün kılan *public* metotlar sağlar.

Kapsülleme, sınıfın verilerini ve metotlarını yönetmeye odaklanan bir ilkedir. Geliştiricilerin güvenli tutmak istedikleri sınıf bölümlerini korumasına ve uygulamanın geri kalanının kullanabileceği bölümü açığa çıkarmasına yardımcı olur.

---

## 🧩 Soyutlama

Nesne yönelimli programlamanın bir diğer ilkesi olan  *soyutlama (abstraction)* , bir sınıfın hangi metotları uygulaması gerektiğini tanımlar; ancak belirli uygulama ( *implementation* ) ayrıntılarını sağlamaz.

Şimdi bunu inceleyelim.

Soyutlama, bir nesnenin ne yaptığını tanımlama, ancak bunu nasıl yaptığını belirtmeme ilkesidir.

Geliştiriciler bunu  *abstract class* ’lar ve  *interface* ’ler oluşturarak gerçekleştirir. Geliştiriciler bu ilkeyi uyguladığında, bir nesnenin temel özelliklerini ve davranışlarını tanımlar; ancak bu nesnelerin içindeki metotların nasıl uygulanacağına geliştiricilerin karar vermesine olanak tanır.

---

## 🏗️ Soyutlama ile Nesne Oluşturma

Geliştiriciler, soyutlama ilkesini iki temel şekilde uygulayabilir.

Ortak bir kod tabanını, uygulama kodunu içeren somut ( *concrete* ) metotlarla paylaşmak istediklerinde bir *abstract class* kullanabilirler. Ancak ayrıca, yalnızca arayüzü tanımlayan fakat hiçbir uygulama ayrıntısı sunmayan *abstract methods* da içerebilirler.

Geliştiriciler ayrıca somut metotlar içermeyen  *interface* ’ler de oluşturabilir.

Bir  *interface* ’i, miras alan bir sınıfın uygulamak zorunda olduğu metotlar kümesini tanımlayan bir sözleşme ( *contract* ) gibi düşünebilirsiniz.

Interface’ler genellikle yalnızca miras alan sınıfın hangi metotları uygulaması gerektiğini içerir; ancak uygulama kodunu içermez.

---

## 🏦 Bankacılık Uygulaması Örneği

Bankacılık uygulamasında, geliştirme ekibinin para yatırma ve para çekme işlemlerini ele almak için bir *abstract class* oluşturduğunu varsayalım.

Bu sınıf bir *amount* özniteliği tanımlar ve para yatırma ile para çekme için  *abstract method* ’ları bildirir ( *declares* ).

*Tasarruf hesabı (savings account)* işlevselliği bu soyut sınıftan miras alır ve para yatırma ile para çekmenin nasıl ele alınacağına dair özel mantığı sağlar.

*Vadesiz hesap (checking account)* kodu da aynı şeyi yapar.

Bu hesaplarla etkileşime giren uygulamanın herhangi bir bölümü, hem tasarruf hem de vadesiz hesabın para yatırma ve para çekme metotlarına sahip olacağını bilir; bunların uygulama ayrıntılarıyla ilgilenmesine gerek kalmaz.

---

## 🤝 Kapsülleme ve Soyutlamanın Birlikte Çalışması

Şimdi kapsülleme ve soyutlama ilkelerinin birlikte nasıl çalıştığına bakalım.

Bir kütüphanenin envanterini yönetmek için yazılım oluşturduğunu varsayalım.

Yazılımın programcıları, kitaplar ve *Patreons* hakkında verileri kapsülleyen bir *library* sınıfı oluşturur. Özel ( *private* ) öznitelikler kullanarak iç veri yapılarını gizler ve *addBook* ve *borrowBook* gibi *public* metotlar sağlar.

Bu, kontrollü erişime izin verirken kütüphane verilerinin bütünlüğünü korur.

Ayrıca *catalog* adlı bir interface tanımlayarak soyutlamayı kullanır; bu interface *searchBook* ve *listAvailableBooks* gibi metotları açığa çıkarır.

 *Catalog* ’dan miras alan herhangi bir sınıf, onun metotlarını uygular ( *implements* ); bu da sistemi kullanmayı ve sürdürmeyi kolaylaştırır.

---

## ✅ Özet

Bu videoda, nesne yönelimli programlamada kapsülleme ve soyutlama ilkelerini nasıl açıklayacağınızı ve bunların bir nesnenin iç durumunu nasıl koruduğunu ve kullanımını nasıl basitleştirdiğini öğrendiniz.

Kapsülleme, verileri ve metotları bir sınıf içinde bir araya getirerek bir nesnenin iç durumunu korur.

Soyutlama, geliştiricilerin tutarlı, öngörülebilir ancak esnek sınıflar oluşturmasına yardımcı olur.

Bu ilkeleri uygulayan geliştiriciler, güvenli ve bakımı kolay kod yazabilirler.
