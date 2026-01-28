## Copilot-Assisted Debugging Techniques (Özet + Uygulanabilir Şablonlar)

Bu derste anlatılan “Copilot ile debug” yaklaşımı temelde **doğru context’i doğru sırayla vermek** üzerine kurulu. Copilot çoğu zaman problemi parçalamadan da çözebilir; ama takıldığı yerde context’i kademe kademe artırmak en verimli yöntem.

---

## 1) Context Kademesi: En Hızlıdan En Güçlüye

### A) En hızlı deneme: “Tüm dosyayı yapıştır + bug’ı fix et”

* Program.cs / ilgili dosyanın tamamı
* Prompt: **“Bu kodda bug var, düzelt. Hangi satırda, neden ve nasıl düzeldiğini de söyle.”**

Genellikle list/dictionary bounds, null ref, yanlış route, yanlış async gibi sorunları direkt yakalar.

### B) Daha odaklı: “Sadece problemli blok + ilgili veri yapısı”

Tek bir handler’a bakıyorsan bile Copilot’un anlayabilmesi için:

* **Route handler**
* **Kullandığın koleksiyon/model** (List blogs gibi)
* Varsa **ilgili endpoint tanımı**

Örn: `app.MapGet("/blogs/{id}", ...)` + `List<Blog> blogs = ...`

### C) En güçlü: “Kod + exception message + stack trace”

Copilot’un “neden”i kesinleştirmesi için en iyi kombinasyon:

* Kod
* Exception text (örn.  *IndexOutOfRangeException…* )
* Stack trace (hangi satırda patladı)

Bu, özellikle runtime hatalarda teşhisi netleştirir.

---

## 2) “Index out of range” gibi tipik bug için Copilot’a doğru paket

### Örnek prompt (etkili)

* “Aşağıdaki minimal API’de `/blogs/{id}` çağrısı bazen `IndexOutOfRangeException` atıyor. Beklenen davranış: id yoksa 404 dönmek. Hata mesajı/stack trace aşağıda. Kodu düzelt ve nedenini açıkla.”

Copilot’un beklenen fix’i:

* `id` için bounds check (`id < 0 || id >= blogs.Count`)
* Sonra `Results.NotFound()` / `TypedResults.NotFound()`

---

## 3) Server çalıştırıp “kanıt topla” yaklaşımı

Videodaki gibi:

1. Uygulamayı çalıştır (`dotnet run` / `dotnet watch run`)
2. Hatalı isteği tetikle (requests.http / Postman / browser)
3. Terminaldeki hatayı al:
   * **satır numarası**
   * **exception + stack trace**
4. Copilot’a **bu çıktıyı** da ver

Bu, “ne olduğunu” tahmin etmek yerine, “gerçekte ne oldu” üzerinden çözüm üretir.

---

## 4) “Copilot’u yanlış yönlendirme” riski (Anchoring)

Videoda geçen çok kritik nokta:

* “Bence bug şu satırda” diye yazarsan Copilot **buna fazla tutunabilir** ve yanlış teşhis üretebilir.

Daha iyi:

* “Şu satırdan şüpheleniyorum ama emin değilim; stack trace aşağıda. Sebebi doğrula.”

---

## 5) Copy/Paste yoksa: Screenshot ile debug

Bazen stack trace kopyalanamaz.

* Ekran görüntüsüne **hem hatayı** hem **ilgili kod parçasını** al
* Copilot bunu OCR gibi okuyup teşhis edebilir

Bu yöntem:

* Edge case ama gerçekten işe yarar
* Özellikle IDE pop-up hatalarında

---

## 6) Pratik Debug “Playbook” (Senin için hazır akış)

1. **Tüm dosya + “fix bug”**
2. Çözmezse → **sadece ilgili endpoint + model/koleksiyon**
3. Çözmezse → **exception + stack trace ekle**
4. Çözmezse → **repro steps** ekle (hangi URL, hangi payload)
5. Copy/paste yoksa → **screenshot**

---

## 7) Kopyala-yapıştır için 3 hazır prompt şablonu

### Şablon 1: Genel

* “Aşağıdaki kodda bug var. Hangi durumda ortaya çıkıyor, root cause nedir, en minimal düzeltme nedir? (Kod:) …”

### Şablon 2: Exception odaklı

* “Bu exception’ı alıyorum: (exception + stack trace). Kodu düzelt: (kod). Beklenen davranış: …”

### Şablon 3: Repro odaklı

* “Bu URL/payload ile hata alıyorum: … Beklenen: … Gerçek: … Kodu analiz edip fix öner.”

---

İstersen, senin Blog CRUD API’ndeki `/blogs/{id}` route’unu **“id bounds check + typed results + swagger uyumlu response”** şeklinde düzgün hale getirecek örnek minimal API kodunu da direkt çıkarabilirim (liste mi dictionary mi kullandığını söylemen yeterli).
