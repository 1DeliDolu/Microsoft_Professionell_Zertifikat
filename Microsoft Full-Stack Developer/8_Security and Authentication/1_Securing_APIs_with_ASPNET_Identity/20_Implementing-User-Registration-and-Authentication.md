## 🧪 Kullanıcı Kaydı ve Kimlik Doğrulamayı Uygulama

Bu laboratuvarda, bir **ASP.NET** uygulamasında **ASP.NET Identity** kullanarak kullanıcı kaydı ve kimlik doğrulama işlemlerini uygulayacaksınız.

---

## 🧱 Adım 1: In-Memory Veritabanını Kurma

İlk adımda, *in-memory* veritabanını kuracaksınız. Burada, **.NET new MVC** şablonu ile oluşturduğum bir **MVC** uygulaması var.

Adım 1’de,  **identity context** ’i oluşturacak ve veritabanını *in-memory* veritabanı kullanacak şekilde yapılandıracaksınız.

İlk yapmak istediğimiz şey veritabanı context’ini tanımlamak. Uygulamanızın **models** klasöründeki `dbcontext.cs` dosyasına gideceğiz ve veritabanı için context’i ekleyeceğiz.

Veritabanı bu laboratuvar için yalnızca bir *in-memory* veritabanı olacak ve bu, veritabanı context’ini tutacak; böylece uygulamanın diğer yönlerini kullanabileceğiz.

**Application dbcontext** sınıfını tanımladıktan sonra, `program.cs` dosyasına gidip ona referans verebildiğimizden emin olacağım.

`program.cs` içinde, uygulamanın herhangi bir yerinde bu singleton’a referans verebilmek için bir **dbcontext singleton** ekleyeceğiz.

Burada, bunu `program`’a eklerken adını **userAuthInMemoryApp** olarak çağıracağız.

---

## 🧾 Adım 2: Registration Sınıfını Oluşturma

Adım 2’de, **registration** sınıfını oluşturacaksınız. Bunun için **models** klasöründe `registerViewModel.cs` adlı yeni bir **cs** dosyası oluşturacağız.

Bu sınıfta yalnızca üç özellik ( *property* ) olacak:

* `email` özelliği: `string`
* `password` özelliği: `string`
* `confirmPassword` özelliği: `string`

Bu üç özelliğin tamamı burada olacak ve ilk ikisinde **required** niteliğini kullanıyoruz; sonuncusunda ise bir **compare** niteliği kullanacağız.

Son özellikte bu **compare** öğesini ekleyeceğinizi göreceksiniz ve bunun yaptığı şey şudur: alanlarımızdaki iki parola eşleşmezse, kullanıcı için bir hata mesajı üretir.

Ve hepsi bu.
