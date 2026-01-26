## 🧩 Etkinlik: Algoritma Yapıları - Cevap Anahtarı

### ✅ Cevap Anahtarı

#### 🧾 Problem 1: İndirim Uygunluğu

```text
Create a variable total_spending and set it to the value of the input for "Enter total spending amount:"
IF total_spending greater than or equal to 100 THEN
    Display to user "10% discount applied."
ELSE
    Display to user "No discount."
```

Bu sözde kod, toplam harcamanın 100$ veya daha fazla olup olmadığını kontrol etmek için koşullu bir ifade ( *if/then* ) kullanır. Eğer öyleyse indirim uygulanır; değilse indirim verilmez. Bu yapı, tek bir koşula dayalı doğrudan bir karar verme süreci sağlar.

---

#### 📚 Problem 2: Kitap Kategorilendirme

```text
SET genre = input("Enter the genre of the book:")
IF genre is "Fiction" THEN
    Display to user "Category: Fiction"
Otherwise IF genre is "Non-Fiction" THEN
    Display to user "Category: Non-Fiction"
Otherwise IF genre is "Science Fiction" THEN
    Display to user "Category: Science Fiction"
Otherwise
    Display to user "Category: Unknown"
```

Bu sözde kod, kitapları türlerine göre kategorize etmek için bir dizi koşullu ifade ( *if/else if/else* ) kullanır. Her koşul, türün belirli bir kategoriyle eşleşip eşleşmediğini kontrol eder ve uygun mesajı yazdırır. Koşullardan hiçbiri sağlanmazsa program **"Category: Unknown."** çıktısını verir.

---

#### 🔢 Problem 3: Çift mi Tek mi?

```text
Create a variable number and set it to the value of the input of "Enter a number:"
IF number divisible by 2 has a remainder of 0 THEN
    Display to user "Even number."
Otherwise
    Display to user "Odd number."
```

Bu sözde kod, bir sayının çift mi tek mi olduğunu belirlemek için ikili bir karar yapısı kullanır. **"number divisible by 2 has a remainder of 0"** koşulu, sayının 2’ye kalansız bölünüp bölünmediğini (çift olup olmadığını) kontrol eder. Doğruysa **"Even number"** yazdırır; aksi halde **"Odd number"** yazdırır. *If/else* yapısı, iki olası sonucu verimli şekilde yönetir.
