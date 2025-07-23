using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserDevice
/// </summary>
public sealed class UserDevice
{
    /// <summary>
    /// type of the device; ios or android
    /// </summary>
    [JsonPropertyName("type")]
    public UserDeviceType? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// device token sent by mobile clients.
    /// </summary>
    [JsonPropertyName("deviceToken")]
    public string DeviceToken { get; set; }

    /// <summary>
    /// notification id of the device.
    /// </summary>
    [JsonPropertyName("notificationId")]
    public string NotificationId { get; set; }

    /// <summary>
    /// make of the device.
    /// </summary>
    [JsonPropertyName("make")]
    public string Make { get; set; }

    /// <summary>
    /// Device model
    /// </summary>
    [JsonPropertyName("model")]
    public string Model { get; set; }

    /// <summary>
    /// if the device accepts notifications
    /// </summary>
    [JsonPropertyName("acceptNotifications")]
    public bool? AcceptNotifications { get; set; }

    /// <summary>
    /// Gets or Sets SessionHash
    /// </summary>
    [JsonPropertyName("sessionHash")]
    public string SessionHash { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }
}