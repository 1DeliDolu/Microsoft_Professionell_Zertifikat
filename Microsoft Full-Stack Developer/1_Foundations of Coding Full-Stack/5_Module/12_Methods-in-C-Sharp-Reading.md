## 🧩 Methods in C#

### 📝 Introduction

C#’ta metotlar, bir *class* ile ilişkilendirilmiş yeniden kullanılabilir kod bloklarıdır ve geliştiricilerin görevleri organize etmesine olanak tanır. Nesne Yönelimli Programlama’da ( *OOP* ), nesneler içindeki veri ve davranışlarla etkileşim kurulmasını sağladıkları için kritik bir rol oynarlar.

---

## 📌 Definition of Methods

Metotlar fonksiyonlara benzer, ancak nesnelerle olan ilişkileri bakımından ayrışırlar. Bir fonksiyon bağımsız olarak var olabilirken, bir metot her zaman bir  *class* ’ın parçasıdır ve sınıfın verisine erişebilir ve bu veriyi değiştirebilir. Bu, metotları *OOP* için ayrılmaz hâle getirir; çünkü metotlar nesnelerin davranışını tanımlamak için kullanılır.

Örneğin, bir **Product** sınıfı metodu, o ürünün stok sayısını güncellemeyi ele alabilir. Buna karşılık fonksiyonlar daha genel amaçlıdır ve nesnelere ya da sınıflara bağlı değildir.

---

## 🧱 Syntax of Methods

C#’ta metot yazımı birkaç temel bileşenden oluşur. Bu öğeler, metodun ne yapacağını, erişilebilirliğini ve hangi verilerle çalıştığını bildirmek ve tanımlamak için kullanılır.

### 🔐 Access modifiers

Metodun görünürlüğünü belirler. Örnekler:

* **public:** Diğer sınıflardan erişilebilir.
* **private:** Yalnızca tanımlandığı sınıf içinde erişilebilir.

### ↩️ Return type

Metodun döndürdüğü verinin türünü tanımlar. Eğer metot hiçbir şey döndürmüyorsa dönüş türü **void** olur.

### 🏷️ Method name

Metodu tanımlayan açıklayıcı bir isimdir. En iyi uygulama, metot adlarının amacını yansıtmasıdır (örn.  **AddNumbers** ,  **CalculateDiscount** ).

### 📥 Parameters

Metoda giriş verisi sağlamak için metot içine geçirilen değişkenlerdir; metot adından sonra parantez içinde bulunur. Birden fazla parametre virgülle ayrılır (örn.  **int a, int b** ).

### 🧩 Method body

İstenen görevi gerçekleştiren kod bloğudur. C#’ta bir metodun temel yapısı şöyledir:

```csharp
public int AddNumbers(int a, int b) {
   return a + b;
}
```

Yukarıdaki metot iki sayıyı toplar ve sonucu *integer* olarak döndürür.

---

## 🛠️ Common Use Cases

Metotlar, C# programlamada tekrarlayan görevleri kapsüllemek ve basitleştirmek için bir yol sunar. En yaygın kullanım alanlarından bazıları şunlardır:

---

## 🧮 Performing Calculations

Metotlar, değerleri toplama/çıkarma veya ortalama hesaplama gibi tekrarlanan matematiksel işlemleri yürütmek için sıklıkla kullanılır. Mantığı bir metot içine koymak, aynı işlemi kodunuzun farklı bölümlerinde yeniden kullanmanıza olanak tanır.

**Example**

```csharp
public int Add(int a, int b) {
   return a + b;
}
```

---

## 🖱️ Handling Events

Metotlar, etkileşimli uygulamalar geliştirmek için kritiktir. Fare tıklamaları veya tuş basımları gibi kullanıcı eylemlerine yanıt vererek uygulamanızı duyarlı hâle getirir.

**Example**

```csharp
private void Button_Click(object sender, EventArgs e) {
   Console.WriteLine("Button clicked");
}
```

---

## 🧩 Manipulating Data

Geliştiriciler, dizileri sıralama veya koleksiyonları değiştirme gibi veri işleme metotlarını sıkça kullanır. Metotlar, bu işlemlerin tutarlı ve verimli şekilde yürütülmesine yardımcı olur.

**Example**

```csharp
public List<int> SortList(List<int> numbers) {
   numbers.Sort();
   return numbers;
}
```

---

## 🏁 Conclusion

C#’ta metotlar, kodu yeniden kullanılabilir ve sürdürülebilir şekilde organize etmek ve yapılandırmak için temeldir. *OOP* içindeki rolleri, onları sınıflara bağlayarak nesnelerin içindeki verilere erişim sağlar. Metotları nasıl tanımlayacağınızı ve kullanacağınızı anlayarak; hesaplamalar, olay yönetimi ve veri manipülasyonu gibi görevleri daha akıcı hâle getirebilir, sonuç olarak uygulamalarınızı daha verimli ve ölçeklenebilir yapabilirsiniz.
