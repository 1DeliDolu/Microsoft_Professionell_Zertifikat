## 🧵 `async` ve `await` Sözdizimi ve Kullanımı

### 🧩 Giriş

C#’ta asenkron programlama, uygulamaların ana iş parçacığını ( *main thread* ) dondurmadan arka planda görevleri yürütebilmesine olanak tanıyarak performansı artırmaya yardımcı olur. Bu rehber, verimli görev yönetimi için **async** ve **await** ile asenkron metotların nasıl oluşturulacağını ve kullanılacağını gösterir.

---

## 🪜 Adım Adım Talimatlar

### 1) 🧱 Asenkron Bir Metot Tanımlayın

**a.** Bir metodu asenkron olarak işaretlemek için **async** anahtar sözcüğünü kullanın.
**b. Nasıl yapılır:** Metodun dönüş türünden önce **async** ekleyin.

```csharp
public async Task GetDataAsync()
{
    // Method logic here
}
```

---

### 2) ⏳ `await` Anahtar Sözcüğünü Kullanın

**a.** **await** anahtar sözcüğü, arka plan görevi bitene kadar yürütmeyi duraklatır.
**b. Nasıl yapılır:** **Task** döndüren metotların önüne **await** koyun.

```csharp
var data = await GetDataFromApi();
```

---

### 3) 🎯 Doğru Dönüş Türünü Ayarlayın

**a.** Değer döndüren metotlar için  **Task** , değer döndürmeyen metotlar için **Task** kullanın.
**b. Nasıl yapılır:**

```csharp
public async Task<string> GetDataAsync()
{
    var data = await GetDataFromApi();
    return data;
}
```

---

### 4) 🧯 Hataları Yönetin

**a.** Asenkron metotlarda istisnaları ( *exception* ) **try-catch** bloklarıyla yönetin.
**b. Nasıl yapılır:**

```csharp
try
{
    var data = await GetDataFromApi();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

---

## ✅ Sonuç

**async** ve **await** kullanmak, görevleri arka planda verimli şekilde çalıştırmanıza olanak tanır; böylece ana program akışı kesintiye uğramadan uygulama yanıt verebilirliği artar.
