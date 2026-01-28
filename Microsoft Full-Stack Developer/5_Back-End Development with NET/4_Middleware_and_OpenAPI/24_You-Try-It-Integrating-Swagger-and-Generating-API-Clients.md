## 🧩 Step 1: Yeni Bir Console Application Kurulumu

Bu adımda, bu lab için ihtiyaç duyacağınız klasörleri ve başlangıç yapısını kurarak yeni bir ASP.NET Core console application oluşturacaksınız.

1. Visual Studio Code’u açın ve yeni bir terminal seçin.
2. Yeni bir console application oluşturmak için komutu çalıştırın:

```bash
dotnet new console -o SwaggerApiClientLab
```

3. Proje klasörüne gidin:

```bash
cd SwaggerApiClientLab
```

4. Swagger ve NSwag ile çalışmak için gerekli paketleri eklemek üzere şunları çalıştırın:

```bash
dotnet add package Swashbuckle.AspNetCore
dotnet add package NSwag.Core
dotnet add package NSwag.CodeGeneration.CSharp
dotnet add package NSwag.ApiDescription.Client
```

5. Proje klasörünüzün içinde API controller’ınızı tutmak için **Controllers** adlı bir klasör oluşturun.
6. Proje yapınızın aşağıdaki gibi göründüğünü doğrulayın:

```text
SwaggerApiClientLab
├── Controllers
├── Program.cs
└── SwaggerApiClientLab.csproj
```

---

## 🧩 Step 2: Uygulamada Swagger’ı Yapılandırma

Sonraki adımda uygulamaya Swagger yapılandırması ekleyeceksiniz. Bu adım, API dokümantasyonunun erişilebilir olmasını ve client generation için hazır olmasını sağlayacak Swagger middleware kurulumunu içerir.

1. **Program.cs** dosyasını açın ve Swagger yapılandırmasını eklemek için uygun bölümü bulun.
2. Swagger’ı API dokümantasyonunu JSON formatında sunacak şekilde yapılandırın. Swagger UI path’i olarak **`/swagger/v1/swagger.json`** kullanın.
3. Sunucuyu başlatın. **`app.Run();`** kullanın.
4. Uygulamayı **`dotnet run`** ile çalıştırın ve Swagger kurulumunu doğrulamak için tarayıcınızda Swagger UI endpoint’ine gidin.

---

## 🧩 Step 3: API Specification Oluşturma

Şimdi, client code generation için işlevsellik sağlayacak bir API endpoint tanımlayacaksınız. Bu specification, API route’larını, parametrelerini ve response type’larını dokümante edecektir.

1. **Controllers** klasörü içinde **UserController.cs** adında yeni bir dosya oluşturun.
2. **Id** ve **Name** özelliklerine sahip temel bir **User** class’ı oluşturun.
3. Bir user ID kabul eden ve örnek JSON **User** detayını döndüren basit bir **GetUser** endpoint’i kurun.
4. Uygulamayı tekrar çalıştırın ve endpoint’in dokümantasyonda doğru göründüğünü doğrulamak için tarayıcınızda Swagger dokümantasyonunu görüntüleyin.

---

## 🧩 Step 4: NSwag ile Client Code Üretme

Bu adımda, Swagger dokümantasyonundan client code üretmek için NSwag kullanacaksınız; bu, client-side kodun server endpoint’leriyle otomatik olarak etkileşime girmesini sağlayacaktır.

1. Proje root’unda **ClientGenerator.cs** adında yeni bir dosya oluşturun.
2. Swagger JSON’u çekmek ve client code üretmek için aşağıdaki kodu **ClientGenerator.cs** içine yerleştirin. Bu kod NSwag kütüphanesini kullanır ve üretilen client için özel bir namespace ve class name ayarlar.

```csharp
public class ClientGenerator
{
    public async Task GenerateClient()
    {
        using var httpClient = new HttpClient();
        var swaggerJson = await httpClient.GetStringAsync("http://localhost:<port>/swagger/v1/swagger.json");
        var document = await OpenApiDocument.FromJsonAsync(swaggerJson);

        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = "GeneratedApiClient",
            CSharpGeneratorSettings = { Namespace = "MyApiClientNamespace" }
        };

        var generator = new CSharpClientGenerator(document, settings);
        var code = generator.GenerateFile();

        await File.WriteAllTextAsync("GeneratedApiClient.cs", code);
    }
}
```

3. **Program.cs** içinde, üretilen client code’un proje dizininde oluşturulduğunu doğrulayarak, client generator’ı çalıştırıp generated client code dosyasını üretin. Client code oluşturmak için şu adımları izleyin:

* **`app.Run();`** satırını **`Task.Run(() => app.RunAsync());`** ile değiştirin. Bu, sunucuyu asenkron olarak çalıştıracaktır.
* Sunucuyu başlatan kodun altına, sunucunun başlamasına zaman tanımak için 3 saniye veya daha fazla **awaited delay** ekleyin.
* Bu delay’in altına, **ClientGenerator** class’ındaki **GenerateClient** metoduna **awaited call** ekleyin.

4. Client code’u üretmek için uygulamayı tekrar çalıştırın.

---

## 🧩 Step 5: Üretilen Client Code’u Özelleştirme

Bu adımda, namespace ve class name gibi üretilen client ayarlarında düzenlemeler yapacaksınız.

1. **ClientGenerator.cs** dosyasını açın ve class name ile namespace için yapılandırma ayarlarını bulun.
2. Ayarları özel tercihlerinize göre değiştirin; örneğin class name’i **CustomApiClient** ve namespace’i **CustomNamespace** olarak ayarlayın.
3. Özelleştirdiğiniz ayarların üretilen client code’a yansıdığını doğrulamak için client generator’ı tekrar çalıştırın.
4. **Program.cs** içinde, **GenerateClient** çağrısını comment out edin veya kaldırın.

---

## 🧩 Step 6: Client Code’u Uygulamaya Entegre Etme

Bu son adımda, uygulamanızdan API’ye istek atmak için üretilen client’ı kullanacaksınız.

1. **Program.cs** dosyasını açın ve üretilen client class’ını instantiate edin; API base URL’i ve **HttpClient** instance’ını geçin.
2. **GetUser** endpoint’ini çağırmak için client metodlarını kullanın; user verisini alıp görüntüleyin.
3. API client entegrasyonunun beklendiği gibi çalıştığını doğrulamak için uygulamayı çalıştırın.
