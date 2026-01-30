## 🧪 You Try It! Building a RESTful API

### 🎯 Objective

Bu lab’in sonunda, back-end ortamında **Express.js** kullanarak RESTful API nasıl oluşturulacağını gösterebileceksiniz.

---

## 🧩 Step 1: Prepare for the Aplication

Visual Studio Code içinde **.NET Minimal API** kullanarak küçük bir RESTful API oluşturacaksınız. Bu API, kullanıcıların bir task listesini yönetmesine izin verecek. HTTP method’larını kullanarak task oluşturma, okuma, güncelleme ve silme işlemlerini yapacaksınız. Son olarak, API’yi **Postman** ile test edeceksiniz.

### 📝 Instructions

Visual Studio Code’u açın.

Yeni bir terminal penceresi açın.

Yeni bir .NET web uygulaması başlatın:

```bash
dotnet new web -o MinimalApiDemo
cd MinimalApiDemo
```

Temiz başlamak için `Program.cs` içindeki mevcut kodu kaldırın.

---

## 🧩 Setup 2: Setting Up the API

Şimdi, task listesini yönetmek için bir endpoint oluşturarak .NET’te temel bir Minimal API tanımlayacaksınız.

### 📝 Instructions

`Program.cs` dosyasını açın.

Web application builder’ı yapılandırın.

Veriyi saklamak için basit bir in-memory task list oluşturun.

Tüm task’leri almak için bir GET route tanımlayın.

---

## 🧩 Step 3: Creating Api Endpoints

Şimdi task’ler için gerekli CRUD endpoint’lerini tanımlayacaksınız.

### 📝 Instructions

Yeni bir task eklemek için bir POST endpoint’i tanımlayın.

Var olan bir task’i güncellemek için bir PUT endpoint’i tanımlayın.

Bir task’i silmek için bir DELETE endpoint’i tanımlayın.

Her endpoint’in  **200 OK** , **404 Not Found** ve **201 Created** gibi doğru HTTP status code’ları döndürdüğünden emin olun.

---

## 🧪 Step 4: testing the Api with Postman

API’yi uyguladıktan sonra, her endpoint’i Postman ile test edeceksiniz.

### 📝 Instructions

Postman’ı açın.

GET endpoint’ini test etmek için şu adrese GET isteği gönderin:

`http://localhost:5000/tasks`

POST endpoint’ini test etmek için JSON body ile POST isteği gönderin:

```json
{
   "id": 1,
   "name": "Learn .NET Minimal API",
   "isCompleted": false
}
```

PUT endpoint’ini, güncellenmiş bir task ile PUT isteği göndererek test edin.

DELETE endpoint’ini, bir task’i kaldırmak için DELETE isteği göndererek test edin.
