# PureCloud.Client

**PureCloud.Client** is a modernized and streamlined C# SDK originally forked from [platform-client-sdk-dotnet](https://github.com/MyPureCloud/platform-client-sdk-dotnet). It has since evolved into a cleaner, more idiomatic library tailored for contemporary .NET development.

## Key Improvements Over the Original Fork

- Fully asynchronous API to prevent thread blocking
- Built-in support for Dependency Injection
- Uses `System.Text.Json` for efficient JSON serialization/deserialization
- Targets modern .NET platforms, including .NET 8 and newer
- Cleaner and more maintainable codebase

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
