## 🧪 You Try It! Implementing API Consumption in React

---

## 🧩 Step 1: Prepare for the Application

Visual Studio Code konsolunu kullanarak basit bir Blazor uygulaması oluşturacaksınız. Uygulama bir RESTful API’den veri çekip görüntüleyecek.

### 📝 Instructions

Visual Studio Code’u açın ve yeni bir Blazor WebAssembly uygulaması oluşturun.

Uygulamayı başlatın.

Varsayılan uygulamanın tarayıcıda başarılı şekilde çalıştığından emin olun.

---

## 🔌 Step 2: Set Up APi Consuption with HttpCLIENT

Uygulamayı, HttpClient kullanarak harici bir RESTful API’den veri tüketecek şekilde yapılandıracaksınız.

### 📝 Instructions

`Program.cs` dosyasını açın ve HttpClient’ın dependency injection için register edildiğinden emin olun.

Yeni bir Razor component oluşturun.

HTTP isteklerini etkinleştirmek için `@inject` directive’i ile `FetchData.razor` içine HttpClient inject edin.

API’den çekilen response’u tutmak için bir `Posts` değişkeni tanımlayın.

API response’unu yönetmek için bir data model ( **Post** ) tanımlayın:

* API yapısıyla eşleşecek şekilde `Id`, `Title`, `Body` gibi property’ler ekleyin.

---

## 📥 Step 3: Make the API call

RESTful API’den veri çekip component’e bind edeceksiniz.

### 📝 Instructions

`FetchData.razor` içinde `HttpClient` kullanarak şu endpoint’i çağırın:

`https://jsonplaceholder.typicode.com/posts`

`GetFromJsonAsync` ile API çağrısı yapın.

API isteğini yönetmek için lifecycle method olan `OnInitializedAsync` içinde `async Task` kullanın.

Gelen response verisini Step 2’de oluşturduğunuz `<Post>` değişkenine kaydedin.

---

## 🧾 Step 4: Display Data in a User-Friendly Way

Çekilen veriyi UI’de tablo formatında render edin.

### 📝 Instructions

`FetchData.razor` içinde bir HTML `<table>` yapısı tanımlayın.

API response’u üzerinde gezinmek için `foreach` döngüsü kullanın ve satırları dinamik biçimde Post verisiyle doldurun.

`Post ID`, `Title` ve `Body` için tablo başlıkları ekleyin.

---

## 🧯 Step 5: Implement Basic Error Handling

API hatalarını düzgün şekilde yönetmek için uygulamayı geliştirin.

### 📝 Instructions

API çağrısını bir `try-catch` bloğu içine alın.

Exception’ları loglayın ve istek başarısız olursa bir fallback mesajı gösterin.

API çağrısı durumuna göre `"Loading..."` veya `"Error fetching data"` mesajlarını render etmek için conditional statement kullanın.
