## 🧱 Entity Sınıflarını Oluşturma ve Yapılandırma

EF Core’daki entity sınıfları güçlü araçlardır. .NET’te veritabanlarıyla çalışmanın yapı taşlarıdır. Bu videoda, EF Core’da entity sınıflarını oluşturmayı ve yapılandırmayı açıklayacağız.

Entity sınıflarını nasıl oluşturup yapılandıracağımızı göstermek için, employee, department ve project entity’lerine odaklanan bir şirket veritabanı örneğini kullanacağız.

---

## 🗂️ İlk Adım: Entity Sınıflarını Kurma

Süreçteki ilk adımımız entity sınıflarını kurmaktır. Başlamak için entity sınıflarımızı saklayacağımız bir yere ihtiyacımız var.

Projemizin içinde entity’leri saklamak için yeni bir klasör oluşturacağız. Çoğu geliştirici bu klasöre **Models** adını verir.

Bu klasör, EF Core veritabanı tablolarınızı temsil eden tüm model sınıflarınızı saklayacaktır.

Klasör hazır olduğunda ilk entity’mizi tanımlayabiliriz.

---

## 👤 Employee Entity’sini Tanımlama

**Models** klasöründe **Employee.cs** adlı yeni bir C-sharp dosyası oluşturun.

Önce **Employee** adlı public bir class tanımlayarak başlayın. Employee class’ı veritabanındaki employee tablosunu temsil edecektir.

Class’ı public olarak işaretlemek, uygulamanın diğer bölümlerinin ona erişebilmesini sağlar.

Şimdi Employee class’ı içinde entity’nin özelliklerini ( *properties* ) tanımlayalım.

EmployeeId, FirstName, LastName ve HireDate için properties tanımlayacağız.

İlk property  **EmployeeId** . Bu bir integer, yani `int`.

`get`/`set` ve süslü parantezleri kullanırız. Bu, EmployeeId değerini okumamızı ve değiştirmemizi sağlar.

Sonra, çalışanın **FirstName** ve **LastName** özelliklerini tanımlarız; ikisi de `string` türündedir.

EmployeeId’de olduğu gibi, `get`/`set` ve süslü parantez söz dizimi bu değerleri okumamıza ve değiştirmemize izin verir.

Son olarak **HireDate** property’si var; bu `DateTime` türündedir.

Yine, `get`/`set` ve süslü parantez söz dizimi HireDate’e ihtiyaç duyduğumuzda erişmemizi ve değiştirmemizi sağlar.

Bu property’lerin her biri Employee tablosunda bir sütun oluşturur ve uygulamamızda employee verisiyle etkileşim kurmamızı sağlar.

---

## 🧠 EF Core Conventions

EF Core’un özellikle properties ile çalışırken sağladığı avantajlardan biri **conventions** kullanımıdır.

EF Core’da conventions, belirli yapılandırma değişikliklerini otomatik olarak yapan bir kural setidir; geliştiricilere zaman ve efor kazandırır.

Örneğin, EF Core adlandırma kuralına göre primary key’leri otomatik olarak belirleyebilir.

EmployeeId’nin primary key olmasını istediğimizi düşünelim.

**EmployeeId** adlandırma kuralını kullanarak, EF Core otomatik olarak EmployeeId’yi primary key yapar.

Bunun çalışma şekli şudur: EF Core’un primary key adlandırma kuralı, ya entity’yi **Id** olarak adlandırmanızı ya da bu örnekte yaptığımız gibi entity adını ( **Employee** ) alıp hemen arkasına boşluksuz şekilde **Id** eklemenizi gerektirir.

FirstName, LastName ve HireDate gibi diğer özellikler de otomatik olarak çalışanın bilgilerini saklayan tablo sütunlarına eşlenir.

---

## 🔗 Entity’ler Arasında İlişki Kurma

Properties tanımlandıktan sonra bir sonraki adım, entity’ler arasında ilişkiler kurmaktır.

Her çalışanın bir departmanda çalıştığını varsayalım.

Employee ile Department arasındaki ilişkiyi tanımlamak için, `int` türünde bir **DepartmentId** property’si ekleyeceğiz.

Diğerlerinde olduğu gibi, süslü parantez `get`/`set` söz dizimi bu değerleri okumamıza ve değiştirmemize izin verir.

Employee ile Department arasındaki ilişkiyi tanımlamak için bir de **navigation property** eklememiz gerekir.

Navigation property, bir entity içinde başka bir entity ile ilişki kuran ve ilgili veriyi almaya ( *retrieval* ) izin veren bir property’dir.

Örneğimizde, property’yi `public` yazarak ve ilgili entity türünü belirterek tanımlarız; bu tür  **Department** ’tır.

Bu, property’nin Department entity class’ına bir referans tutacağı anlamına gelir.

Sonra property’nin adını yazarız; buna da **Department** diyeceğiz.

Bu, her çalışanın bir departmana ait olduğu ve her departmanın birçok çalışanı olabildiği **one-to-many** bir ilişki oluşturur.

DepartmentId, Employee tablosunu Department tablosuna bağlayan bir foreign key olarak çalışır.

Department class’ındaki navigation property, belirli bir departmanla ilişkilendirilmiş çalışanları sorgulamanıza olanak tanır.

---

## 🛠️ Entity Davranışını Yapılandırma

İlişkiler kurulduktan sonra, entity’lerimizin davranışını uygulamanın ihtiyaçlarına uygun şekilde yapılandırmayı inceleyelim.

EF Core’da entity davranışını **Data Annotations** veya **Fluent API** kullanarak yapılandırabiliriz.

---

## 🏷️ Data Annotations

Data Annotations, belirli kuralları zorunlu kılmak için property’lere doğrudan uyguladığınız attribute’lerdir.

Bunlar; primary key’i açıkça belirtmek, bir alanı zorunlu yapmak veya string uzunluğunu sınırlamak gibi işlemleri içerebilir.

Data Annotations, etkiledikleri property’nin hemen önüne yazılır.

Örneğin EmployeeId’yi açıkça primary key olarak bildirmek isterseniz, EmployeeId’nin üstüne köşeli parantez içinde **Key** yazabilirsiniz.

Başka davranışlar da eklemeniz gerekebilir; örneğin bir alanı zorunlu yapmak veya string uzunluğunu sınırlamak.

Örneğin FirstName ve LastName’in zorunlu olmasını sağlamak için bu property’lerde köşeli parantez içinde **Required** kullanabilirsiniz.

Ayrıca FirstName gibi bir string property’nin uzunluğunu 50 karakterle sınırlamak için köşeli parantez içinde **StringLength 50** kullanabilirsiniz.

Bu annotation’lar, ekstra kod yazmadan veri bütünlüğünü sağlamaya yardımcı olur.

---

## 🧬 Fluent API

Data Annotations daha basit yapılandırmalar için faydalıdır; ancak daha ayrıntılı kurulumlar için **Fluent API** kullanırız.

Fluent API, EF Core’da entity davranışını ve ilişkileri kod üzerinden yapılandıran bir yöntemdir.

Data Annotations’a göre daha fazla esneklik ve kontrol sunar.

Fluent API, entity davranışını ayrıntılı biçimde yapılandırmanıza olanak tanıyan daha esnek bir yaklaşımdır.

Köşeli parantez içinde Required gibi attribute’ler kullanmak yerine, entity’ler için daha karmaşık davranışları tanımlamak üzere **OnModelCreating** metodunun içine kod yazarsınız.

Bunu yapmak için önce kalıtım alan bir class kurmanız gerekir; bu örnekte  **hrdbContext** , **dbContext** class’ından türetilir.

Sonra veritabanı tablosunu dbContext’e **dbSet** kullanarak eşlersiniz.

Bunu, Employee entity’sini **Employees** tablosuna eşlemek için `DbSet<Employee> Employees` ile yaparız.

Ardından Department entity’sini **Departments** tablosuna eşlemek için `DbSet<Department> Departments` kullanırız.

Sonra **OnModelCreating** metodunu oluşturursunuz; bu metod dbContext class’ının içinde bulunur ve EF Core’un kilit bir parçasıdır.

Uygulama başladığında, EF Core otomatik olarak bu metodu çağırır ve veritabanınızda zorunlu kılmak istediğiniz özel kuralları veya yapılandırmayı uygular.

OnModelCreating metodunu `protected` ile yalnızca class içinde erişilebilir yapın ve değer döndürmediğini `void` ile belirtin.

Son olarak, Employee tablosu için yapılandırmaları tanımlamak üzere `ModelBuilder.Entity`’i Employee türüyle kullanırsınız.

Sonra yapılandırmak istediğiniz entity property’lerini belirtmek için `Entity.Property` anahtar sözcüğünü kullanırsınız.

`.IsRequired` ile alanın zorunlu olmasını sağlarız ve `.HasMaxLength(50)` ile alan için maksimum uzunluğu 50 karakter olarak ayarlarız.

---

## 🧾 Kapanış

Bu videoda, EF Core’da entity sınıflarını nasıl tanımlayıp yapılandıracağınızı öğrendiniz; properties’i tablo sütunlarına eşlemeyi, ilişkileri kurmayı ve Data Annotations ile Fluent API kullanmayı.

Projenizde çalışırken, entity’lerinizi verimli ve mantıklı şekilde kurmak için bu teknikleri kullanın.
