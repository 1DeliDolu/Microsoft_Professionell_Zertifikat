## 🗝️ Etkinlik: ASP.NET Core’da RBAC Mimarisi – Cevap Anahtarı

## 🎓 Görev 1: LMS RBAC Tasarımı için Cevap Anahtarı

### 👤 Rol ve İzinler

| Rol        | İzinler                                                                                       |
| ---------- | ---------------------------------------------------------------------------------------------- |
| Admin      | Kullanıcıları yönetme, kursları yönetme, ayarları yapılandırma.                       |
| Instructor | Kendi kurslarını yönetme, ödevleri notlandırma, kayıtlı öğrencileri görüntüleme.   |
| Student    | Kayıtlı olduğu kursları görüntüleme, ödevleri görüntüleme, notları görüntüleme. |
| Guest      | Yalnızca genel kurs bilgilerini görüntüleme.                                               |

### 🧠 Açıklama

**Roller Nasıl Tanımlandı?**
Roller, bir LMS’nin hiyerarşisini ve işlevlerini yansıtır. Admin’ler genel yönetimi üstlenir, eğitmenler ders sunumuna odaklanır, öğrenciler öğrenme kaynaklarına erişir ve misafirler yalnızca herkese açık bilgilerle sınırlandırılır.

**İzinler Neden Bu Şekilde Atandı?**
Her rolün izinleri kendi sorumluluklarıyla eşleşir. Örneğin, eğitmenler yalnızca kendi kurslarını yönetir; bu da veri korumasını ve net hesap verebilirliği sağlar.

**Bu Sistem Veriyi Nasıl Korur?**
Rollere göre izin atamak, öğrencilerin ve misafirlerin notlar veya kayıtlı olmadıkları kurslar gibi özel verilere erişmesini engeller.

---

## 🏦 Görev 2: Perakende Banka RBAC Tasarımı için Cevap Anahtarı

### 👤 Rol ve İzinler

| Rol      | İzinler                                                                                |
| -------- | --------------------------------------------------------------------------------------- |
| Admin    | Hesapları yönetme, işlemleri yönetme, müşteri verilerini görüntüleme.          |
| Teller   | İşlemleri gerçekleştirme, hesap bakiyelerini görüntüleme (sınırlı kapsam).    |
| Auditor  | Sistem günlüklerini inceleme, işlemleri inceleme (müşteri ayrıntıları olmadan). |
| Customer | Kendi hesap ayrıntılarını görüntüleme, işlem geçmişini görüntüleme.        |

### 🧠 Açıklama

**Roller Nasıl Tanımlandı?**
Roller, bankacılıktaki temel işlevlere karşılık gelir. Admin’ler operasyonları denetler, veznedarlar müşteri odaklı işlemleri yürütür, denetçiler uyumluluğu sağlar ve müşteriler yalnızca kendi verileriyle etkileşime girer.

**İzinler Neden Bu Şekilde Atandı?**
İzinler, her rolün görevlerini tamamlamasını sağlayacak şekilde uyarlanırken hassas bilgilere erişim en aza indirilir. Örneğin, denetçiler kişisel müşteri verilerini görmez; bu da gizliliği korur.

**Bu Sistem Veriyi Nasıl Korur?**
Her rolün erişimini kendi sorumluluklarıyla sınırlamak, müşteri verilerini yetkisiz görüntüleme veya değiştirmeye karşı korur.
