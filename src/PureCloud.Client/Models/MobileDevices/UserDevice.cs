namespace PureCloud.Client.Models.MobileDevices;

public sealed class UserDevice
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string DeviceToken { get; set; }
    public string NotificationId { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool? AcceptNotifications { get; set; }
    public string SessionHash { get; set; }
    public string SelfUri { get; set; }
}
