## 🧪 Deneyin! Blazor’da İstemci Tarafı Durum Yönetimini Uygulama - Cevap Anahtarı

### 🧱 Adım 1

**Komut:** `dotnet new blazorwasm -o ClientStateApp`

**Açılan klasör:** `ClientStateApp`

---

## 💾 Adım 2

```csharp
// Program.cs
using Blazored.LocalStorage;

builder.Services.AddBlazoredLocalStorage();
```

```razor
// Home.razor
<h3>Theme Selector</h3>
<button @onclick="ToggleTheme">Toggle Theme</button>
<p>Current Theme: @theme</p>

@inject Blazored.LocalStorage.ILocalStorageService localStorage

@code {
    private string theme = "light";
    private async Task ToggleTheme()
    {
        theme = theme == "light" ? "dark" : "light";
        await localStorage.SetItemAsync("user-theme", theme);
    }
    protected override async Task OnInitializedAsync()
    {
        theme = await localStorage.GetItemAsync<string>("user-theme") ?? "light";
    }
}
```

---

## 🕒 Adım 3

```csharp
// Program.cs
using Blazored.SessionStorage;

builder.Services.AddBlazoredSessionStorage();
```

```razor
// Cart.razor
@page "/cart"
<h3>Shopping Cart</h3>
<input @bind="newItem" placeholder="Add item" />
<button @onclick="AddItem">Add</button>
<ul>
    @foreach (var item in cartItems)
    {
        <li>@item</li>
    }
</ul>

@inject Blazored.SessionStorage.ISessionStorageService SessionStorage

@code {
    private string newItem = string.Empty;
    private List<string> cartItems = new();

    private async Task AddItem()
    {
        cartItems.Add(newItem);
        await SessionStorage.SetItemAsync("cart", cartItems);
        newItem = string.Empty;
    }

    protected override async Task OnInitializedAsync()
    {
        cartItems = await SessionStorage.GetItemAsync<List<string>>("cart") ?? new List<string>();
    }
}
```

---

## 🧹 Adım 4

```razor
// Home.razor
<button @onclick="ClearStorage">Clear All Storage</button>

@inject Blazored.LocalStorage.ILocalStorageService localStorage
@inject Blazored.SessionStorage.ISessionStorageService sessionStorage

@code {
    private async Task ClearStorage()
    {
        await localStorage.ClearAsync();
        await sessionStorage.ClearAsync();
    }
}
```
