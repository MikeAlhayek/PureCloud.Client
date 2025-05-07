using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserDevice
/// </summary>

public partial class UserDevice : IEquatable<UserDevice>
{
    /// <summary>
    /// type of the device; ios or android
    /// </summary>
    /// <value>type of the device; ios or android</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Android for "android"
        /// </summary>
        [EnumMember(Value = "android")]
        Android,

        /// <summary>
        /// Enum Ios for "ios"
        /// </summary>
        [EnumMember(Value = "ios")]
        Ios
    }
    /// <summary>
    /// type of the device; ios or android
    /// </summary>
    /// <value>type of the device; ios or android</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserDevice" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserDevice() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserDevice" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="DeviceToken">device token sent by mobile clients. (required).</param>
    /// <param name="NotificationId">notification id of the device. (required).</param>
    /// <param name="Make">make of the device. (required).</param>
    /// <param name="Model">Device model (required).</param>
    /// <param name="AcceptNotifications">if the device accepts notifications (required).</param>
    /// <param name="Type">type of the device; ios or android (required).</param>
    /// <param name="SessionHash">SessionHash.</param>
    public UserDevice(string Name = null, string DeviceToken = null, string NotificationId = null, string Make = null, string Model = null, bool? AcceptNotifications = null, TypeEnum? Type = null, string SessionHash = null)
    {
        this.Name = Name;
        this.DeviceToken = DeviceToken;
        this.NotificationId = NotificationId;
        this.Make = Make;
        this.Model = Model;
        this.AcceptNotifications = AcceptNotifications;
        this.Type = Type;
        this.SessionHash = SessionHash;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
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
    /// <value>device token sent by mobile clients.</value>
    [JsonPropertyName("deviceToken")]
    public string DeviceToken { get; set; }



    /// <summary>
    /// notification id of the device.
    /// </summary>
    /// <value>notification id of the device.</value>
    [JsonPropertyName("notificationId")]
    public string NotificationId { get; set; }



    /// <summary>
    /// make of the device.
    /// </summary>
    /// <value>make of the device.</value>
    [JsonPropertyName("make")]
    public string Make { get; set; }



    /// <summary>
    /// Device model
    /// </summary>
    /// <value>Device model</value>
    [JsonPropertyName("model")]
    public string Model { get; set; }



    /// <summary>
    /// if the device accepts notifications
    /// </summary>
    /// <value>if the device accepts notifications</value>
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
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserDevice {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DeviceToken: ").Append(DeviceToken).Append("\n");
        sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
        sb.Append("  Make: ").Append(Make).Append("\n");
        sb.Append("  Model: ").Append(Model).Append("\n");
        sb.Append("  AcceptNotifications: ").Append(AcceptNotifications).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  SessionHash: ").Append(SessionHash).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as UserDevice);
    }

    /// <summary>
    /// Returns true if UserDevice instances are equal
    /// </summary>
    /// <param name="other">Instance of UserDevice to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserDevice other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                DeviceToken == other.DeviceToken ||
                DeviceToken != null &&
                DeviceToken.Equals(other.DeviceToken)
            ) &&
            (
                NotificationId == other.NotificationId ||
                NotificationId != null &&
                NotificationId.Equals(other.NotificationId)
            ) &&
            (
                Make == other.Make ||
                Make != null &&
                Make.Equals(other.Make)
            ) &&
            (
                Model == other.Model ||
                Model != null &&
                Model.Equals(other.Model)
            ) &&
            (
                AcceptNotifications == other.AcceptNotifications ||
                AcceptNotifications != null &&
                AcceptNotifications.Equals(other.AcceptNotifications)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                SessionHash == other.SessionHash ||
                SessionHash != null &&
                SessionHash.Equals(other.SessionHash)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DeviceToken != null)
            {
                hash = hash * 59 + DeviceToken.GetHashCode();
            }

            if (NotificationId != null)
            {
                hash = hash * 59 + NotificationId.GetHashCode();
            }

            if (Make != null)
            {
                hash = hash * 59 + Make.GetHashCode();
            }

            if (Model != null)
            {
                hash = hash * 59 + Model.GetHashCode();
            }

            if (AcceptNotifications != null)
            {
                hash = hash * 59 + AcceptNotifications.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (SessionHash != null)
            {
                hash = hash * 59 + SessionHash.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
