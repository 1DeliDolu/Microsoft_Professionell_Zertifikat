## 🧩 Introduction to Methods

### 🎵 [MUSIC]

Fonksiyonların yeniden kullanılabilir kod parçaları olduğunu zaten öğrendiniz. Metotlar, fonksiyonlara çok benzer. Aslında metotlar bir tür fonksiyondur. Ancak metotlar fonksiyon olsa da, tüm fonksiyonlar metot değildir.

Bu videoda, metotları tanımlayacağız ve fonksiyonlardan nasıl farklı olduklarını açıklayacağız. Bir metodun ne olduğuna dair genel bir bakış sunarak başlayalım.

---

## 🔗 Metot Nedir?

Metotlar, tıpkı fonksiyonlar gibi yeniden kullanılabilir kod parçalarıdır; ancak metotları fonksiyonlardan ayıran şey, nesnelerle olan bağlantılarıdır.

Nesne Yönelimli Programlama (*Object Oriented Programming* veya  *OOP* ) kullanıldığında, bir metot bir fonksiyon gibi çalışır. Ancak bir metot, birlikte tek bir birim olarak çalışacak diğer kodlarla gruplanır.

Metotlar, gruplanmış oldukları kodu kullanarak işlemler gerçekleştirir. Geliştiriciler bu kod birimine *class* (sınıf) adını verir.

---

## 🔁 Fonksiyon Kavramını Hatırlama

Metotları sınıflar bağlamında tanımladığımıza göre, bir adım geri atıp fonksiyon kavramını yeniden hatırlayalım. Fonksiyonları anlamak, metotlar ile fonksiyonlar arasındaki farkları ve onları nasıl kullandığımızı anlamamıza yardımcı olur.

Nesne Yönelimli Programlama’da fonksiyonlar, belirli bir görevi yerine getirmek için tasarlanmış yeniden kullanılabilir kod bloklarıdır. Kod içinde istediğimiz zaman çağırabiliriz.

Bir fonksiyonu, ihtiyaç duyduğunuz her yerde kullanabileceğiniz bağımsız bir araç gibi düşünün; örneğin bir tornavida gibi.

---

## ⚖️ Metot ile Fonksiyon Arasındaki Fark Nedir?

Şimdi “Metot ile fonksiyon arasındaki fark nedir?” diye merak ediyor olabilirsiniz. Bu, özellikle öğrenme aşamasında geliştiricileri sıkça zorlayan ve kafa karıştıran bir sorudur.

Metotlar ve fonksiyonlar benzerdir, ancak özellikle *OOP* bağlamında belirgin farklılıkları vardır.

Bir metot, bir fonksiyona benzer, ancak her zaman bir *class* ile ilişkilidir. Metotlar, sınıfın içindeki verilere erişebilir ve onları değiştirebilir.

Şöyle düşünün: Tüm metotlar fonksiyondur, ancak tüm fonksiyonlar metot değildir.

Bir fonksiyon, herhangi bir sınıftan bağımsız olarak tek başına var olabilir. Örneğin, bir sayının karesini hesaplayan bir fonksiyon, belirli bir sınıfa bağlı olmadan kodunuzun herhangi bir yerinde kullanılabilir.

Öte yandan, bir metot her zaman bir sınıfın parçasıdır.

---

## 🏗️ Bir Sınıf İçinde Metot Tanımlama

Metotlar ile fonksiyonlar arasındaki ayrımı gördüğümüze göre, şimdi bir sınıf içinde bir metodun nasıl tanımlanacağını ve oluşturulacağını inceleyelim.

Bir sınıf içinde bir metot tanımlamak için, sınıf tanımının içine bir fonksiyon yazmanız gerekir.

Örneğin, **MyClass** adlı bir sınıf oluşturabilir ve bu sınıf içinde **MyFunction** adlı bir metot tanımlayabilirsiniz; bu metot **a** ve **b** olmak üzere iki *property* alır.

Bu, fonksiyonu sınıf içinde gruplanmış diğer tüm kodlarla ilişkilendirir.

Ayrıca, **MyFunction** metodu uygulamadaki diğer kodlarda yalnızca sınıfın bir parçası olarak çağrılabilir. Sınıftan bağımsız şekilde çağrılamaz.

---

## 🍽️ Benzetme: Takeout Food ve Dine-in Meal

Bir fonksiyonu *paket servis* (takeout) yemek gibi, bir metodu ise *restoranda yenilen* (dine-in) bir yemek gibi düşünün.

Bir dükkândan paket bir sandviç sipariş edip onu her yere götürebilirsiniz; ancak yalnızca sandviçi alırsınız.

Belirli bir yemeği restoranda yemek isterseniz, restoranın bulunduğu yere gitmeniz gerekir; ancak bunun yanında restoranın tüm imkânlarını ve hizmetlerini de kullanabilirsiniz.

---

## 🧰 Fonksiyonlar ve Metotlar Nerede Kullanılır?

Fonksiyonlar, bir programın herhangi bir yerinde kullanabileceği genel, yeniden kullanılabilir kod blokları oluşturmamızı sağlar.

Örneğin, bir geliştirici alışveriş sepetindeki ürünlerin toplam fiyatını hesaplamak için bir fonksiyon oluşturabilir. Daha sonra bu fonksiyonu uygulamanın herhangi bir yerinde kullanabilir.

Buna karşılık, metotları parçası oldukları sınıftaki veri ve davranışlara özgü işlemler için kullanabiliriz.

Örneğin, bir **product** sınıfı oluşturabilir ve bu sınıfta ürünün stok sayısını güncelleyen bir metot tanımlayabilirsiniz. Bu metot **product** sınıfına özeldir ve sınıfın verisini değiştirir.

---

## 🧠 Özet

Fonksiyonlar ve metotlar çalışma biçimleri açısından çok benzerdir; aralarındaki fark, kod içinde nasıl yazıldıklarıyla ilgilidir.

Fonksiyonlar işlerini bağımsız olarak yapar; metotlar ise işlerini sınıflar içinde yapar.

Bu videoda, metotları tanımladık ve fonksiyonlardan nasıl farklı olduklarını ele aldık. Metotlar,  *OOP* ’de sınıflarla ilişkilendirilmiş fonksiyonlardır; fonksiyonlar ise genel amaçlı yeniden kullanılabilir kod bloklarıdır.

Bu kavramları anlamak, verimli programlama için temeldir ve bizi nesne yönelimli programlamayı daha derinlemesine incelemeye hazırlar.
