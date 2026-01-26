## 🧠 Psödokod Yazmak İçin Tümdengelimsel Akıl Yürütme Kullanımı

### 🎯 Amaç

Tümdengelimsel akıl yürütme ilkelerini uygulayarak bir programın mantıksal akışını *psödokod* ile taslak hâline getirmek. Bu süreç, problemleri öncüllere ayırarak, sonuçlar çıkararak ve bu sonuçları test ederek sistematik biçimde çözmeye yardımcı olur.

### 📝 Açıklama

Bu etkinlikte, tümdengelimsel akıl yürütmeyi kullanarak psödokod yazacaksınız. Önce süreci göstermek için iki yönlendirmeli örnekle başlayacağız. Ardından iki problemi bağımsız olarak çözecek, mantıksal akışı çıkaracak ve çözümünüzü uygulamak için psödokodu yazacaksınız.

---

## 📅 Örnek: Artık Yıl

### 🧩 Problem Tanımı

Verilen bir yılın artık yıl olup olmadığını kontrol eden bir program oluşturmanız isteniyor. Bir yıl 4’e bölünebiliyorsa artık yıldır; ancak 100’e bölünebilen her yıl artık yıl değildir, 400’e de bölünebiliyorsa artık yıldır.

### 🧠 Tümdengelimsel Akıl Yürütme Uygulaması

#### 1. Öncülleri Belirle

* Bir yıl 4’e bölünebiliyorsa artık yıldır.
* Yıl 100’e bölünüyorsa, 400’e de bölünmüyorsa artık yıl değildir.

#### 2. Öncülleri Analiz Et

* Yıl 400’e bölünüyorsa artık yıldır.
* Yıl 400’e bölünmüyor ama 100’e bölünüyorsa artık yıl değildir.
* Yıl 4’e bölünüyor ve 100’e bölünmüyorsa artık yıldır.

#### 3. Sonuç Çıkar

Analize göre, artık yıl kontrol koşulları tüm durumları kapsayacak biçimde mantıksal olarak yapılandırılabilir.

#### 4. Sonucu Test Et

Bilinen artık yıllar (ör. 2000, 1600) ve artık olmayan yıllar (ör. 1700, 1800) ile mantığı test edin.

#### 5. Açıklama

* **Girdi:** Kullanıcıdan bir yıl girmesi istenir.
* **Koşul Kontrolleri:** Öncülleri kullanarak:
  * Önce yılın 4’e bölünüp bölünmediğini kontrol et
  * Sonra 100’e bölünüp bölünmediğini kontrol et
  * En son 400’e bölünüp bölünmediğini kontrol et

#### 6. Psödokodu Yaz

```text
Start
Input year
If (year is divisible by 4)
  And (year not divisible by 100
       Or if year is divisible by 100 and also divisible by 400
      )
    Display to user "Leap year"
  Otherwise print “Not a leap year”
End
```

---

## 🏫 Örnek 2: Basit Not Sistemi

### 🧩 Problem Tanımı

Öğrencinin sayısal puanına göre harf notunu belirleyen bir program oluşturduğunuzu düşünün. Not sistemi şöyledir:

* 90 veya üzeri: "A"
* 80–89: "B"
* 70–79: "C"
* 60–69: "D"
* 60’ın altı: "F"

### 🧠 Tümdengelimsel Akıl Yürütme Uygulaması

#### 1. Öncülleri Belirle

* 90 veya üzeri "A" olarak sınıflandırılır.
* 80 ile 89 arası "B" olarak sınıflandırılır.
* 70 ile 79 arası "C" olarak sınıflandırılır.
* 60 ile 69 arası "D" olarak sınıflandırılır.
* 60’ın altı "F" olarak sınıflandırılır.

#### 2. Öncülleri Analiz Et

* Not aralıkları birbirini dışlar ve tüm olası puanları kapsar.
* Her aralık, koşullu kontroller dizisiyle doğrulanabilir.

#### 3. Sonuç Çıkar

En yüksekten en düşüğe doğru sıralı kontrol yaparak doğru harf notu atanabilir.

#### 4. Sonucu Test Et

Farklı puanlarla test edin (ör. 95 "A", 85 "B" olmalı).

#### 5. Açıklama

* **Girdi:** Kullanıcıdan sayısal puan girmesi istenir.
* **Koşul Kontrolleri:** Öncülleri kullanarak:
  * Puan 90 veya üzeriyse "A"
  * Puan 80 veya üzeriyse "B"
  * Aralıklar bitene kadar devam et
* **Çıktı:** Kontroller sonucuna göre uygun harf notu yazdırılır.

#### 6. Psödokodu Yaz

```text
Start 
Ask user for score 
If score is greater than or equal to 90
    Display to user "Grade A" 
Otherwise If score is greater than or equal to 80
    Display to user "Grade B" 
Otherwise If score is greater than or equal to 70
    Display to user "Grade C" 
Otherwise If score is greater than or equal to 60
    Display to user "Grade D" 
Otherwise
    Display to user "Grade F" 
End
```

---

## 🔢 Problem 1: Tamsayılar

### 🧩 Problem Tanımı

Bir sayının pozitif, negatif veya sıfır olduğunu belirleyen bir program oluşturmak için psödokod yazın. Programın mantıksal akışını kurmak için tümdengelimsel akıl yürütme kullanın.

### 🧠 Tümdengelimsel Akıl Yürütme

#### 1. Öncülleri Belirle

* Eğer sayı 0’dan büyükse pozitiftir.
* Eğer sayı 0’dan küçükse negatiftir.
* Eğer sayı 0’a eşitse sıfırdır.

#### 2. Öncülleri Analiz Et

* Bu koşullar birbirini dışlar ve tüm olası sayıları kapsar.
* Mantıksal kontrol sırası:
  * Önce 0’a eşit mi?
  * Değilse 0’dan büyük mü?
  * Aksi hâlde negatiftir.

#### 3. Sonuç Çıkar

Tüm durumları kapsamak için koşullar ardışık biçimde kontrol edilmelidir.

#### 4. Psödokodu Yaz

```text
Start
Input number
If number is equal to 0
    Display to user "Zero"
Otherwise If number is greater than 0
    Display to user "Positive"
Otherwise
    Display to user "Negative"
End
```

---

## 👵 Problem 2: Yaşlı İndirimi

### 🧩 Problem Tanımı

Bir kişinin yaşlı vatandaş indirimi için uygun olup olmadığını kontrol eden bir program oluşturmak için psödokod yazın. Program, kişinin yaşını girdi olarak almalıdır. Yaş 65 veya üzeriyse "Eligible for senior discount"; aksi hâlde "Not eligible for senior discount" yazdırmalıdır.

### 🧠 Tümdengelimsel Akıl Yürütme

#### 1. Öncülleri Belirle

* Yaş 65 veya üzeriyse indirim için uygundur.
* Yaş 65’in altındaysa indirim için uygun değildir.

#### 2. Öncülleri Analiz Et

* Tek bir eşik değer vardır: 65.
* Mantıksal kontrol:
  * Yaş ≥ 65 mi?
  * Evetse uygun, değilse uygun değil.

#### 3. Sonuç Çıkar

Program, tek bir koşul kontrolü ile sonucu üretebilir.

#### 4. Psödokodu Yaz

```text
Start
Input age
If age is greater than or equal to 65
    Print "Eligible for senior discount"
Otherwise
    Print "Not eligible for senior discount"
End
```
