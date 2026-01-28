## 🧭 Routing, Attribute Routing ve Dependency Injection

Bu laboratuvarda, temel bir *ASP.NET Core web API* oluşturuyoruz ve API çağrılarımızın içinde kullanabileceğimiz bazı middleware’ler oluşturmak için *dependency injection* kullanacağız. Bu lab’in ilk adımı, temelde template’lenmiş bir proje kurmaktır. Projeyi `DI project` olarak adlandırıyoruz ve bunun için temel template’i `dotnet new webapi` komutunu kullanarak oluşturuyoruz.

---

## 🧩 Adım 1: Template Projeyi Oluşturma

Bu lab’deki ilk adım, `DI project` adlı templated bir proje kurmak.

Bunu yapmak için temel template’i kullanıyoruz ve komut olarak `dotnet new webapi` çalıştırıyoruz.

---

## 🧾 Adım 2: Interface ve Service Class’ını Kurma

İkinci adımda interface’i ve service class’ını kuruyoruz.

Bunu yapmak için API projesinin root’unda `imiservice.cs` adlı bir dosya oluşturdum.

Bu dosyada çok basit bir method var: `log creation`.

Bu method bir mesajı log file’a logluyor.

Bu sadece interface.

Bu interface, onu implement eden herhangi bir şeyin hangi method’u sağlayabilmesi gerektiğini tanımlıyor; yani interface’i implement eden herkesin `log creation` method’unu çağırabilmesini garanti ediyor.

Adım 2’nin alt adım 2’sinde `miservice.cs` dosyasını oluşturuyoruz.

Burada biraz daha iş yapıyoruz.

`imiservice` interface’ini implement eden `miservice` adlı public bir class oluşturuyoruz.

`underscore service ID` adlı private read-only bir variable oluşturuyorum; bu, random bir ID number üretecek.

İki method’umuz var.

Birincisi, `public miservice` method’u; bu `service ID`’yi oluşturuyor.

İkincisi ise interface’i implement ettiğimiz kısım: `imiservice` interface’indeki `log creation`.

Bu method, method’a verdiğimiz mesajı ve oluşturduğumuz `service ID`’yi yazar.

Bu, dependency injection kullanarak API call’larının nasıl çalıştığını göstermek için birkaç şey yapan çok basit bir class.

---

## 🧷 Adım 3: Service’i Program.cs İçinde Register Etme

Üçüncü adımda, service’i main program içinde register edeceğiz.

Builder options’larımızın hepsi burada.

Şimdi singleton interface ekleyeceğiz.

Bunun için `builder services add singleton` kullanıyoruz.

Burada `imiservice` interface’ine ve `miservice` class’ına referans verdiğimizi görebilirsiniz.

Ve bunu singleton instance olarak oluşturacağız.

Singleton instance kullanarak, middleware üzerinden yapılan tüm çağrılarda tek bir interface instance kullanmış oluyoruz.

Dolayısıyla ID number asla değişmez; çünkü her çağrıda aynı ID number kullanılır.

---

## 🧱 Adım 4: Service Lifecycle’ını Loglamak İçin Middleware Eklemek

Dördüncü adımda, service lifecycle’ını loglamak için middleware ekliyoruz.

Burada aslında şunu gösteriyoruz:

Web application’ımızın builder object’inde service’leri kullanarak yaptığınız her farklı call türü, aynı ID number’ı kullanabilir ya da yaptığınız call türüne göre değişebilir.

Ama singleton için, şu ana kadar yalnızca singleton eklediğimiz için, her zaman aynı ID number kullanılacaktır; çünkü her call için değişmez.

İlk eklediğimiz şey `use statements`.

İlk `app.use` statement’ımız var; bu birinci middleware.

Ne yapıyor?

`my service` adında bir değişken oluşturuyor ve `get required service` ile `imiservice` interface’ini kullanıyor.

`get required service`, bu middleware’in mutlaka kullanması gereken service.

Sonra log file’a “first middleware” çağrıldığını logluyor.

`await next`, bir sonraki middleware’e geçmeden önce bunun tamamlanmasını beklemesini söyler.

En üstte `async context next` yazdığını görürsünüz; bu da uygulamaya şunu söyler:

“Bu middleware’i bitirdiğinde, çağrıları yaptığında ve işini tamamladığında, listedeki bir sonraki middleware’e geç.”

Ve bu da ikinci `app.use` statement’ı.

O da `get required service` çağırıyor; type olarak `imiservice` interface’ini veriyor.

Sonra log interface üzerinden log file’a “second middleware” çalıştırıldığını logluyor ve sonra yine `await` ediyor.

Bunların her birinde, singleton bir service oluşturduğumuz için, `get required services` çağrısı her zaman aynı ID’yi korumalı.

ID artmayacak veya değişmeyecek; aynı ID kullanılacak.

İki tane `app.use` çağrısı yapsak bile.

---

## 🛣️ Adım 5: Service’i Kullanmak İçin Route Oluşturma

Beşinci adımda, service’i kullanabilmek için bir path, bir route oluşturacağız.

Bunun için `app.mapget` komutunu kullanıyoruz.

Bu komut, uygulamaya şunu söyler:

“API’nin root’una geldiğimizde `imiservice` ve `miservice` variable’ını kullanarak bir call yapacağız.”

Root’ta olduğumuzu log file’a logluyoruz.

Ve sonra `results are okay` yani web response olarak `200` döndürüyoruz.

Bu, uygulamamıza şunu söylüyor:

Tek bir route kullanacağız.

Bu route API’nin root’unda olacak.

Ve application bu path’e geldiğinde middleware’i çağıracak.

Ve bu,  *ASP.NET Core* ’da dependency injection ve middleware kullanımını göstermek için çok basit bir yoldur.
