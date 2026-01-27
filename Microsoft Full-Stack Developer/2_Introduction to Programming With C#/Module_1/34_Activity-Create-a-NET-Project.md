## 🧑‍💻 .NET Projesi Oluşturma ve Çalıştırma

### 🎯 Amaç

Visual Studio Code ve .NET Command Line Interface (CLI) kullanarak yeni bir .NET projesi oluşturun, projeyi derleyin ve çalıştığını doğrulamak için uygulamayı çalıştırın.

---

## 🧾 Talimatlar

### 🖥️ Visual Studio Code’u açın

---

## 🆕 Yeni Bir .NET Projesi Oluşturun

### ⌨️ CLI kullanarak

Dosya Gezgini’nde bir klasöre sağ tıklayın ve  **Open in Integrated Terminal** ’a tıklayın.

Alternatif olarak, **Terminal > New Terminal** ile Terminal’i açın ve `cd` komutunu kullanarak istediğiniz dizine gidin.

Terminale aşağıdaki komutu yazın:

```bash
dotnet new console -o MyFirstConsoleApp
```

Projeyi oluşturmak için  **Enter** ’a basın.

---

### 🧰 UI kullanarak

Komut Paleti’ni açın ( **Ctrl + Shift + P** ) ve **.NET: New Project...** yazıp seçin.

Alternatif olarak, **File Explorer** panelini açın ve  **Create .NET Project** ’e tıklayın.

Menüden **Console App** seçin.

Projenizin kaydedileceği bir çıktı klasörü seçin.

Projeniz için bir ad girin, ör.  **MyFirstConsoleApp** .

 **Create Project** ’e tıklayın.

---

## ▶️ Projeyi Çalıştırın

### ⌨️ CLI kullanarak

Terminalde proje klasörünüze gidin (zaten orada değilseniz) ve şunu yazın:

```bash
dotnet run
```

Projeyi çalıştırmak için  **Enter** ’a basın.

---

### 🧭 UI kullanarak

Sol menüden  **Run and Debug** ’a tıklayarak  **Run and Debug Panel** ’ini açın.

**Run and Debug** butonuna tıklayın.

Ortam olarak **C#** seçin.

Uygulamanız için uygun  **launch configuration** ’ı seçin.

Alternatif olarak, üst menüden  **Run > Start Debugging** ’e tıklayın veya **F5** kullanın.

---

## ✅ Doğrulama

Projenin başarıyla çalıştığını doğrulamak için terminalde **"Hello, World!"** (veya uygulamanızdan gelen başka bir çıktı) metnini arayın.
