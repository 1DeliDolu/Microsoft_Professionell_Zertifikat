## 🧪 You Try It! Setting Up a Full-Stack Development Environment

### 🎯 Objective

Bu etkinliğin sonunda, Visual Studio Code kullanarak bir full-stack geliştirme ortamı kurabilecek, Blazor ve Minimal APIs ile front-end ve back-end projeleri oluşturabilecek ve bu projeleri sorunsuz biçimde birlikte çalışacak şekilde yapılandırabileceksiniz.

---

## 🧰 Step 1: Prepare for the Application

Daha önce yapılandırdığınız Visual Studio Code konsolunu kullanarak küçük bir uygulama oluşturacaksınız. Uygulamanız bir front-end Blazor projesi ve bir back-end Minimal API projesinden oluşacaktır.

### 📝 Instructions

Visual Studio Code’u açın ve projelerinizi kurmak istediğiniz bir klasöre gidin.

VS Code’da terminali **Ctrl + ~** ile açın.

Yeni bir front-end projesi oluşturmak için şunu çalıştırın:

```bash
dotnet new blazorwasm -o frontend
```

Bu komut, **"frontend"** adlı bir klasör içinde bir Blazor WebAssembly projesi oluşturur.

Yeni bir back-end projesi oluşturmak için şunu çalıştırın:

```bash
dotnet new webapi -o backend
```

Bu komut, **"backend"** adlı bir klasör içinde bir Minimal API projesi kurar.

Her iki klasörü de ayrı VS Code pencerelerinde açın:

```bash
code frontend
code backend
```

---

## 🧩 Step 2: Install and Verify deependencies

Projeleriniz için gerekli bağımlılıkları (dependencies) kurun ve doğrulayın.

### 📝 Instructions

.NET SDK’nın yüklü olduğundan emin olmak için şunu çalıştırın:

```bash
dotnet --version
```

Sürüm numarası görüntülenmiyorsa, .NET SDK kurulum sürecini tekrar gözden geçirin.

Gerekli VS Code eklentilerini yükleyin:

* **C# Dev Kit:** Gelişmiş C# desteği için
* **REST Client:** VS Code içinde doğrudan HTTP istekleri yapmak için
* **CSharpier:** Otomatik kod biçimlendirme için

Blazor ve Minimal API projelerinin başarıyla oluşturulduğunu doğrulayın:

Terminalde her proje klasörüne gidin.

Projelerin hatasız derlendiğini doğrulamak için `dotnet build` çalıştırın.

```bash
cd frontend
dotnet build
```

```bash
cd ../backend
dotnet build
```

---

## 🖥️ Step 3: Configure the Frontend Project

Front-end Blazor projesini, back-end API’den alınan veriyi görüntüleyecek şekilde hazırlayın.

### 📝 Instructions

Frontend projesini VS Code’da açın.

**Program.cs** dosyasını bulun ve ileride back-end API ile entegrasyon için hazırlayın.

Front-end uygulamayı başlatın:

```bash
dotnet watch
```

Bu komut uygulamayı servis eder ve tarayıcıda açar. Varsayılan Blazor uygulamasının düzgün yüklendiğini doğrulayın.

---

## 🧠 Step 4: Configure the Backend project

Back-end projesini API isteklerini karşılayacak şekilde ayarlayın.

### 📝 Instructions

Backend projesini VS Code’da açın.

**Program.cs** dosyasını bulun.

Program.cs içinde örnek veri döndüren basit bir API endpoint’i tanımlayın; örneğin bir ürün listesi.

Back-end uygulamayı başlatın:

```bash
dotnet watch
```

Uygulamanın çalıştığını doğrulayın ve API’nin servis edildiği URL’yi not alın.

---

## 🔗 Step 5: Integre the Frontend and backend and Backen project

Blazor front-end’i Minimal API back-end’e bağlayın.

### 📝 Instructions

Front-end Blazor uygulamasını, back-end API’ye HTTP isteği yapacak şekilde güncelleyin.

Blazor’da **HttpClient** nesnesini kullanarak API endpoint’ini çağırın ve örnek veriyi alın.

Alınan veriyi basit bir Blazor component içinde görüntüleyin.
