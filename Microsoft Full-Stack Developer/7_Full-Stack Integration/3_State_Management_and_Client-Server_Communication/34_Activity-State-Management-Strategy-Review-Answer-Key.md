## 📝 Etkinlik: Durum Yönetimi Stratejisi İncelemesi - Cevap Anahtarı

## 📱 İstemci Tarafı Durum Yönetimi

**Session Tokens:** Kullanıcı oturumları `localStorage` içinde saklanır; böylece yeniden kimlik doğrulama gerekmeksizin sayfa yeniden yüklemeleri sorunsuz şekilde gerçekleşir.

**Local State:** Gönderilmemiş gönderiler veya yorumlar için metin gibi geçici veriler, anında UI tepkisi sağlamak amacıyla Blazor bileşenlerinde yerel olarak saklanır.

---

## 🖥️ Sunucu Tarafı Durum Yönetimi

**Persistent State:** Gönderiler ve yorumlar SQL Server içinde saklanır; bu da dayanıklılık ve tutarlılık sağlar.

**Real-Time Updates:** SignalR, beğeni ve yorumlar için bildirimleri bağlı kullanıcılara iletmek ( *push* ) amacıyla kullanılır.

---

## 🚀 İyileştirmeler

**SignalR Bant Genişliğini Azaltma:** Güncellemeleri gruplayarak optimize edin (ör. her olay için tek bir bildirim göndermek yerine yeni bildirimlerin özetini gönderin).

**Lazy Loading:** İlk yükleme süresini azaltmak ve ölçeklenebilirliği artırmak için gönderi akışlarında *lazy loading* uygulayın.
