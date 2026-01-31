## 🧪 Deneyin! SignalR Kullanarak Gerçek Zamanlı İletişimi Uygulamak - Cevap Anahtarı

## 🧾 Adım 2: Paylaşılan Modeli Uygulama

```csharp
namespace Shared.Models
{
    public class ChatMessage
    {
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
```

---

## 🧩 Adım 3: SignalR Hub Oluşturma

```csharp
using Microsoft.AspNetCore.SignalR;
using Shared.Models;

public class ChatHub : Hub
{
    public async Task SendMessage(ChatMessage chatMessage)
    {
        chatMessage.Timestamp = DateTime.UtcNow;
        await Clients.All.SendAsync("ReceiveMessage", chatMessage);
    }
}
```

---

## 🛠️ Adım 4: Sunucuyu Yapılandırma

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors();
app.MapBlazorHub();
app.MapHub<ChatHub>("/chathub");
app.Run();
```

---

## 💬 Adım 5: İstemci Arayüzünü Oluşturma

### `Program.cs`

```csharp
using Client;
using Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register the ChatService
builder.Services.AddSingleton<ChatService>();

await builder.Build().RunAsync();
```

---

### `Chat.razor`

```razor
@page "/chat"
@using Shared.Models
@inject ChatService ChatService

<h3>Chat</h3>
<input @bind="user" placeholder="Your name" />
<input @bind="message" placeholder="Your message" />
<button @onclick="SendMessage">Send</button>

<ul>
    @foreach (var chat in chats)
    {
        <li><strong>@chat.User</strong>: @chat.Message (@chat.Timestamp)</li>
    }
</ul>

@code {
    private string user;
    private string message;
    private List<ChatMessage> chats = new();

    protected override async Task OnInitializedAsync()
    {
        ChatService.OnMessageReceived += (chat) =>
        {
            chats.Add(chat);
            InvokeAsync(StateHasChanged);
        };

        await ChatService.StartAsync();
    }

    private async Task SendMessage()
    {
        if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(message))
        {
            var chatMessage = new ChatMessage
            {
                User = user,
                Message = message,
                Timestamp = DateTime.Now
            };

            await ChatService.SendMessage(chatMessage);
            message = string.Empty;
        }
    }
}
```

---

### `ChatService.cs`

```csharp
using Microsoft.AspNetCore.SignalR.Client;
using Shared.Models;

public class ChatService
{
    private HubConnection _hubConnection;

    public event Action<ChatMessage> OnMessageReceived;

    public ChatService()
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5000/chathub")
            .WithAutomaticReconnect()
            .Build();

        _hubConnection.On<ChatMessage>("ReceiveMessage", (message) =>
        {
            OnMessageReceived?.Invoke(message);
        });
    }

    public async Task StartAsync() => await _hubConnection.StartAsync();

    public async Task SendMessage(ChatMessage message) => await _hubConnection.SendAsync("SendMessage", message);
}
```
