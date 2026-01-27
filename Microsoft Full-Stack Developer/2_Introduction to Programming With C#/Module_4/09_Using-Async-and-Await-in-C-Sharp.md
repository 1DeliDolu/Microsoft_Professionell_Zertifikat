## 🧵 C#’ta `async` ve `await` Kullanımı

### 🧩 Asenkron Programlamayı Anlamak

Asenkron programlamanın ne olduğunu anlayalım. Asenkron programlama, uygulamanızın diğer görevlerin tamamlanmasını beklemeden görevleri gerçekleştirmesine olanak tanır. Bu, bir dosyayı indirme veya bir veritabanına erişme gibi uzun süren işlemlerle çalışırken faydalıdır; programınızın duyarlı kalmasını ve aynı anda birden fazla görevi yönetebilmesini sağlar.

Senkron programlamada görevler teker teker gerçekleştirilir; yani program, bir sonraki göreve geçmeden önce her görevin bitmesini beklemek zorundadır. Bu, özellikle internetten veri indirme gibi bir görevi bekliyorsa programınızı yavaşlatabilir.

Buna karşılık asenkron programlama, programınızın bir görevi başlatmasına ve görevin tamamlanmasını beklerken diğer işleri yapmaya devam etmesine izin verir. Bu, C#’ta **async** ve **await** kullanılarak yapılır.

---

## 🧱 `async` ve `await` Anahtar Sözcükleri

Bir metodu asenkron olarak tanımlamak için **async** anahtar sözcüğünü kullanırız ve bu metodun içinde, programın duraklayıp bir görevin tamamlanmasını bekleyebileceği noktaları işaretlemek için **await** kullanırız.

Temel fayda şudur: Programınız duyarlı kalır ve görevlerin bitmesini beklerken diğer işlemleri gerçekleştirebilir.

Bu adımda basit bir asenkron metot oluşturacağız. Bu metot, veri indirmek gibi tamamlanması biraz zaman alan bir görevi simüle edecektir. Bu, **async** ve  **await** ’in nasıl çalıştığına dair size bir fikir verecektir.

---

## ⏬ Basit Bir Asenkron Metot Oluşturma

**DownloadDataAsync** adlı bir metot oluşturarak başlarız ve bunu **async** anahtar sözcüğüyle işaretleriz. Bu, metodun asenkron çalışacağını belirtir.

Bu metodun içinde, veri indirmeye harcanacak zamanı temsil eden bir gecikmeyi simüle etmek için **await** kullanırız. Bu gecikme, **await** anahtar sözcüğü sayesinde ana programın diğer görevleri çalıştırmasını engellemez.

---

## ▶️ `Main` Metodundan Çağırma

Artık bir asenkron metodumuz olduğuna göre, bir sonraki adım bu metodu **Main** metodundan çağırmaktır. Programın, indirme işleminin bitmesini beklemeden başka görevlere geçebildiğini gözlemleyeceğiz.

Bir asenkron metodu çağırırken, devam etmeden önce metodun tamamlanmasını beklemesini programa söylemek için başına **await** koyarız. Ancak metot asenkron olduğu için bu, programın diğer bölümlerinin çalışmasını engellemez.

Bu, indirme işlemi tamamlanırken siz başka kodlar çalıştırabildiğiniz anlamına gelir.

Asıl güç burada ortaya çıkar; uygulamanın duyarlı kalmasını sağlar.

---

## 🔀 Birden Fazla Asenkron Metodu Paralel Çalıştırma

Sonraki adımda, birden fazla asenkron metodu paralel çalıştırmayı göreceğiz; böylece birbirlerinin tamamlanmasını beklemeden aynı anda çalışabilirler. Bu, birden fazla dosya indirmek gibi bağımsız yapılabilecek görevler için faydalıdır.

Birden fazla asenkron metodunuz olduğunda, bunları **Task.EhenAll** kullanarak paralel çağırabilirsiniz. Bu metot, tüm görevlerin tamamlanmasını bekler; ancak onların aynı anda çalışmasına izin verir.

Bu, özellikle tamamlanması uzun süren görevlerle uğraşırken programınızın verimliliğini önemli ölçüde artırabilir. Görevleri eşzamanlı çalıştırarak zaman kazanabilir ve sistem kaynaklarını daha iyi kullanabilirsiniz.

---

## 🧯 Asenkron Metotlara Hata Yönetimi Eklemek

Son olarak, asenkron metotlarımıza hata yönetimi ekleyelim. **Async** kodla çalışırken, görevlerin yürütülmesi sırasında oluşabilecek istisnaları yakalamak ve uygulamanın beklenmedik şekilde çökmesini önlemek önemlidir.

Asenkron metotlarda da, senkron kodda olduğu gibi istisnaları ele almak için **try-catch** bloklarını kullanabilirsiniz. Ancak **Async** metotlar bir **Task** döndürdüğü için, bir istisna fırlatıldığında bu istisna **Task** nesnesinin içinde saklanır.

Bu istisnaları yakalamak için **await** çağrılarının etrafında bir **try-catch** bloğu kullanırız. Bu, hataları zarif bir şekilde ele almamıza ve uygulamanın çökmesi veya yanıt veremez hâle gelmesi yerine kullanıcıya anlamlı geri bildirim sağlamamıza olanak tanır.
