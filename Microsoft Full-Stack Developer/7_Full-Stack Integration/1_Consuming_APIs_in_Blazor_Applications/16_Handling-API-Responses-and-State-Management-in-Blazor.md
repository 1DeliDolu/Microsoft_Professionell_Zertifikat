## 🧪 Blazor’da API Yanıtlarını İşleme ve Durum Yönetimi

Bu laboratuvarda, basit bir Blazor uygulaması oluşturacağız ve bir API’ye istek atarak veri çekmeyi, ardından da yönetilen bir state (durum) eklemeyi göstereceğiz.

---

## 🛠️ 1. Adım: Yeni Blazor Wasm Uygulaması Oluşturma

1. adımda yeni Blazor Wasm uygulamasını oluşturuyoruz; ben bunu zaten yaptım,  *dynamic app* . Bunu bir kök klasörden (root folder) yapıyorum ve ardından uygulamaya geçmek için:

```cli
code .
```

yazıp Enter’a basıyorum. Bu, uygulamayı burada gördüğünüz gibi ayrı bir pencerede, kendi penceresinde açar.

---

## 📄 2. Adım: `userfetch.razor` Sayfasını Oluşturma

2. adımda `userfetch.razor` sayfasını oluşturuyoruz; bende açık.

Kodu kopyalayıp yapıştırırsanız, aynısını elde edersiniz. Burada önemli olan, bu route’un doğru olduğundan emin olmak: `userfetch`. Böylece sayfaya daha sonra erişebiliriz.

Sonra API’den veri çekebilmek için HTTP client’ı inject edeceğiz; burada. Burada bir `await` ve ardından `GetFromJsonAsync` metoduyla bu API’den veriyi alacağımız HTTP çağrısı olduğundan emin olmamız gerekiyor.

Bunun nasıl çalıştığını hızlıca göstereceğim ki birazdan bir sonraki adıma geçebilelim.

Sayfaya gideceğim ve nasıl göründüğünü göstermek için o sayfaya geçeceğim; sonra `fetch/userfetch` adresine gidiyoruz ve bu da bu açık kaynak API’den tüm isimleri getiriyor; yani çalışma şekli bu.

---

## 🧠 3. Adım: Durum Yönetimi Eklemek

Son adım durum yönetimi. Uygulamayı durduracağım. `Control + C` uygulamayı durdurur.

Bu son adımda, 3. adımda, yeni bir class olan state management ekliyoruz. O class’ı alıp bu razor dosyasına yapıştırabilirim; `user` class’ının altına yapıştıracağım.

Şimdi bir state service class’ımız var.

Lab dokümanı state class’ının nasıl kullanılacağını göstermiyor; yani şu an yukarıdaki kod bunu hiç kullanmıyor.

State yönetimi yapmıyor. Bu bir servis; state’i yönetmeye yardımcı olacak bir servis, ama laboratuvarda nedense uygulanmamış. Ancak eğer demoda göstermek gerekse, bunu kolayca uygulayabiliriz.

Buraya birkaç property ekleyeceğim ve `task uninitialized`’ı değiştireceğim; bunların hepsi lab dokümanında var.

Bunu yeni bir metodla değiştireceğim.

`state service` ekledim; böylece kullanabileceğimiz yeni bir nesnemiz var. Hâlâ `uninitialized` async metodumuz var ve onun içinde `state unchanged` var.

Ve sadece `fetched users` atayıp geri döndürmek yerine, `state.update users` kullanıyoruz ve API’den aldığımız kullanıcı verisini yönetmek için o state nesnesini kullanıyoruz.

Gerçek dünyada bu değişkeni aslında böyle kullanırız. Ve tekrar söylüyorum, bunu çalıştırabilirim.

Şimdi `userfetch`’e gidersek, hâlâ tüm veriyi döndürüyor, ama bunu artık state’i kullanarak yapıyor.

Aynı veriyi kullanmak isteyen başka sayfalarımız olsaydı, state manager bunun yapılmasına yardımcı olurdu.

Bu şekilde kurulumunu yaparsınız.
