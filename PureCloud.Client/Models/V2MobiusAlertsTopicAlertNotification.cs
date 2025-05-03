using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusAlertsTopicAlertNotification
/// </summary>

public partial class V2MobiusAlertsTopicAlertNotification : IEquatable<V2MobiusAlertsTopicAlertNotification>
{
    /// <summary>
    /// Gets or Sets NotificationTypes
    /// </summary>
    
    public enum NotificationTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Device for "Device"
        /// </summary>
        [EnumMember(Value = "Device")]
        Device,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Sms for "Sms"
        /// </summary>
        [EnumMember(Value = "Sms")]
        Sms,

        /// <summary>
        /// Enum Push for "Push"
        /// </summary>
        [EnumMember(Value = "Push")]
        Push,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicAlertNotification" /> class.
    /// </summary>
    /// <param name="Recipient">Recipient.</param>
    /// <param name="NotificationTypes">NotificationTypes.</param>
    /// <param name="Locale">Locale.</param>
    public V2MobiusAlertsTopicAlertNotification(V2MobiusAlertsTopicAlertNotificationRecipient Recipient = null, List<NotificationTypesEnum> NotificationTypes = null, string Locale = null)
    {
        this.Recipient = Recipient;
        this.NotificationTypes = NotificationTypes;
        this.Locale = Locale;

    }



    /// <summary>
    /// Gets or Sets Recipient
    /// </summary>
    [JsonPropertyName("recipient")]
    public V2MobiusAlertsTopicAlertNotificationRecipient Recipient { get; set; }



    /// <summary>
    /// Gets or Sets NotificationTypes
    /// </summary>
    [JsonPropertyName("notificationTypes")]
    public List<NotificationTypesEnum> NotificationTypes { get; set; }



    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [JsonPropertyName("locale")]
    public string Locale { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusAlertsTopicAlertNotification {\n");

        sb.Append("  Recipient: ").Append(Recipient).Append("\n");
        sb.Append("  NotificationTypes: ").Append(NotificationTypes).Append("\n");
        sb.Append("  Locale: ").Append(Locale).Append("\n");
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
        return Equals(obj as V2MobiusAlertsTopicAlertNotification);
    }

    /// <summary>
    /// Returns true if V2MobiusAlertsTopicAlertNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusAlertsTopicAlertNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusAlertsTopicAlertNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Recipient == other.Recipient ||
                Recipient != null &&
                Recipient.Equals(other.Recipient)
            ) &&
            (
                NotificationTypes == other.NotificationTypes ||
                NotificationTypes != null &&
                NotificationTypes.SequenceEqual(other.NotificationTypes)
            ) &&
            (
                Locale == other.Locale ||
                Locale != null &&
                Locale.Equals(other.Locale)
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
            if (Recipient != null)
            {
                hash = hash * 59 + Recipient.GetHashCode();
            }

            if (NotificationTypes != null)
            {
                hash = hash * 59 + NotificationTypes.GetHashCode();
            }

            if (Locale != null)
            {
                hash = hash * 59 + Locale.GetHashCode();
            }

            return hash;
        }
    }
}
