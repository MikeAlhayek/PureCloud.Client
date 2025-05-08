# PureCloud.Client

**PureCloud.Client** is a modern, lightweight C# SDK designed for integrating with the Genesys Cloud API. Originally forked from [platform-client-sdk-dotnet](https://github.com/MyPureCloud/platform-client-sdk-dotnet), this library has been significantly improved and refactored for better maintainability, performance, and developer experience.

## Key Improvements

- Fully asynchronous API to avoid thread blocking
- First-class support for Dependency Injection
- Uses `System.Text.Json` for efficient JSON (de)serialization
- Targets modern .NET platforms, including .NET 8 and above
- Clean, maintainable codebase with minimal dependencies
- Lightweight and optimized for modern server applications

---

## Setup

Install the `PureCloud.Client` NuGet package.

Then, register the required services in your DI container:

```csharp
services
    .AddPureCloudCore()
    .AddPureCloudRepositories();
```

### ASP.NET Core Integration

If you're working with **ASP.NET Core**, you can integrate an identity token store or a simple in-memory token store by installing the `PureCloud.Client.AspNetCore.Http` package.

#### Option 1: Identity Token Store (Recommended for Production)

Use the identity-based token store when you want to persist tokens securely using your existing identity system:

```csharp
services
    .AddPureCloudCore()
    .AddPureCloudRepositories()
    .AddIdentityTokenStore<IUser>();
```

#### Option 2: In-Memory Token Store (For Development Only)

For development or debugging purposes, you can use an in-memory token store:

```csharp
services
    .AddPureCloudCore()
    .AddPureCloudRepositories()
    .AddInMemoryTokenStore();
```

> **Note:** `AddInMemoryTokenStore` is not suitable for production environments. For production use, it is strongly recommended to implement a custom token store tailored to your application's needs.

---

## Example Usage

```csharp
public class Example
{
    private readonly IUserRepository _userRepository;
    private readonly INotificationClientFactory _notificationClientFactory;

    public Example(INotificationClientFactory notificationClientFactory, IUserRepository userRepository)
    {
        _notificationClientFactory = notificationClientFactory;
        _userRepository = userRepository;
    }

    public async Task HandleNotificationsAsync(CancellationToken cancellationToken)
    {
        // Get a new instance ot the notification client from the 'INotificationClientFactory'
        await using var notificationClient = _notificationClientFactory.Create();

        // Get the current user
        var user = await _userRepository.GetMeAsync(null, null, cancellationToken);

        // You can use the builder or use other AddSubscription methods to add subscriptions.
        await notificationClient.AddSubscriptionsAsync(builder => builder
            .Add("v2.users.{0}.presence", user.Id)
            .Add("v2.users.{0}.conversations", user.Id)
            .Add("v2.users.{0}.conversations.calls", user.Id)
        );

        // Register a functions to call when a notification is received from the server.
        _notificationClient.NotificationHandlers.Add(EventsHandlerAsync);

        // Process notifications for 60 seconds
        await Task.Delay(TimeSpan.FromSeconds(60), cancellationToken);
    }

    private Task EventsHandlerAsync(INotificationData data)
    {
        switch (data)
        {
            case NotificationData<PresenceEventUserPresence> presence:
                // Handle presence event
                break;

            case NotificationData<ConversationEventTopicConversation> conversation:
                // Handle conversation event
                break;

            case NotificationData<ConversationCallEventTopicCallConversation> callConversation:
                // Handle call conversation event
                break;
        }

        return Task.CompletedTask;
    }
}
```
