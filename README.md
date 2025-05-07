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

If you're using **ASP.NET Core**, you can add identity token support by installing the `PureCloud.Client.AspNetCore.Http` package:

```csharp
services
    .AddPureCloudCore()
    .AddPureCloudRepositories()
    .AddIdentityTokenStore<IUser>();
```

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
        var user = await _userRepository.GetMeAsync(null, null, cancellationToken);

        await using var notificationClient = _notificationClientFactory.Create();

        await notificationClient.AddSubscriptionsAsync(builder => builder
            .Add("v2.users.{0}.presence", user.Id)
            .Add("v2.users.{0}.conversations", user.Id)
            .Add("v2.users.{0}.conversations.calls", user.Id)
        );

        notificationClient.NotificationReceived += HandleNotification;

        // Process notifications for 60 seconds
        await Task.Delay(TimeSpan.FromSeconds(60), cancellationToken);

        notificationClient.NotificationReceived -= HandleNotification;
    }

    private void HandleNotification(INotificationData data)
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
    }
}
```
