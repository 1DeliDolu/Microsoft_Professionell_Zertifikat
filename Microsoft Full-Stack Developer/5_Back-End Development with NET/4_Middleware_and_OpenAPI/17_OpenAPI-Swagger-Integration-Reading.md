## 🧩 OpenAPI (Swagger) Integration

---

## 📌 Introduction

Swagger’ı ASP.NET Core ile entegre etmek, güncel API dokümantasyonunu otomatik üretmek ve sürdürmek için sadeleştirilmiş bir yol sağlar; bu da geliştiricilerin API’leri anlamasını, test etmesini ve API’lerle etkileşime girmesini kolaylaştırır. Bu entegrasyon, bir ASP.NET Core uygulaması içinde doğrudan etkileşimli dokümantasyonu etkinleştirmek için *Swashbuckle* kütüphanesini kullanır.

---

## 🧩 Key Steps for Integration

---

## 📦 Install Packages

**`Swashbuckle.AspNetCore`** ve **`Microsoft.AspNetCore.OpenApi`** paketlerini ekleyin. Bu paketler, Swagger dokümantasyonunun kurulumu ve üretilmesini sağlar.

---

## 🧰 Configure Services

API endpoint’lerini kaydetmek için:

* **`builder.Services.AddEndpointsApiExplorer()`** kullanın.

OpenAPI formatında Swagger dokümantasyonu üretmek için:

* **`builder.Services.AddSwaggerGen()`** kullanın.

---

## 🧪 Enable Middleware for Swagger in Development

Sadece development ortamında çalışacak bir **if** bloğu içinde şunları ekleyin ( **`app.Environment.IsDevelopment()`** ):

* **`app.UseSwagger()`** : Swagger JSON dokümanını üretir.
* **`app.UseSwaggerUI()`** : endpoint’leri taramak ve test etmek için görsel bir arayüz oluşturur.

---

## ✨ Enhance Documentation with Custom Descriptions

Endpoint’lere daha net *summary* ve *description* eklemek için **`.WithOpenApi()`** kullanın.

Response türlerini tanımlayarak doğruluğu ve okunabilirliği artırmak için **`.Produces<StatusCode>`** kullanın.

---

## 🧭 Test API Routes with Swagger UI

Endpoint’leri test etmek için Swagger UI’a **`/swagger`** üzerinden erişin.

İç route’ları gizleyip dokümantasyonu sadece gerekli endpoint’lere odaklamak için **`.ExcludeFromDescription()`** kullanın.

---

## ✅ Conclusion

Bu adımları izleyerek Swagger, ASP.NET Core uygulamalarına entegre edilerek dinamik, etkileşimli ve kolay erişilebilir API dokümantasyonu sağlar. Bu entegrasyon geliştirme sürecini basitleştirir, zaman kazandırır ve dokümantasyonun API işlevselliğiyle uyumlu kalmasına yardımcı olur.
