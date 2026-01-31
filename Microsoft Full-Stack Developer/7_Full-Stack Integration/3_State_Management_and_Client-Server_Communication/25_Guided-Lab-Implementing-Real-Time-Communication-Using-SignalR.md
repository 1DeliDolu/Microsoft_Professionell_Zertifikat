## 📡 `ChatHub.cs`

```csharp
using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
```

---

## 🧩 `Program.cs`

```csharp
builder.Services.AddSignalR();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();
app.UseRouting();
app.MapHub<ChatHub>("/chatHub");

app.Run();
```

---

## 💬 `Chat.razor`

```razor
@page "/chat"
@inject NavigationManager Navigation
@code {
    @using Microsoft.AspNetCore.SignalR.Client;

    private HubConnection hubConnection;
    private string UserName;
    private string Message;
    private List<string> Messages = new();

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(Navigation.ToAbsoluteUri("/chatHub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            Messages.Add($"{user}: {message}");
            StateHasChanged();
        });

        hubConnection.Closed += async (error) =>
        {
            await Task.Delay(5000);
            await hubConnection.StartAsync();
        };

        await hubConnection.StartAsync();
    }
}
```
