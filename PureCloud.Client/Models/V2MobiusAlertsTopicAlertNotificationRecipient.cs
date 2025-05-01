using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusAlertsTopicAlertNotificationRecipient
/// </summary>
[DataContract]
public partial class V2MobiusAlertsTopicAlertNotificationRecipient : IEquatable<V2MobiusAlertsTopicAlertNotificationRecipient>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicAlertNotificationRecipient" /> class.
    /// </summary>
    /// <param name="UserId">UserId.</param>
    /// <param name="DisplayName">DisplayName.</param>
    /// <param name="ContactAddress">ContactAddress.</param>
    public V2MobiusAlertsTopicAlertNotificationRecipient(string UserId = null, string DisplayName = null, string ContactAddress = null)
    {
        this.UserId = UserId;
        this.DisplayName = DisplayName;
        this.ContactAddress = ContactAddress;

    }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }



    /// <summary>
    /// Gets or Sets ContactAddress
    /// </summary>
    [DataMember(Name = "contactAddress", EmitDefaultValue = false)]
    public string ContactAddress { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusAlertsTopicAlertNotificationRecipient {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  ContactAddress: ").Append(ContactAddress).Append("\n");
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
        return Equals(obj as V2MobiusAlertsTopicAlertNotificationRecipient);
    }

    /// <summary>
    /// Returns true if V2MobiusAlertsTopicAlertNotificationRecipient instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusAlertsTopicAlertNotificationRecipient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusAlertsTopicAlertNotificationRecipient other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                ContactAddress == other.ContactAddress ||
                ContactAddress != null &&
                ContactAddress.Equals(other.ContactAddress)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (ContactAddress != null)
            {
                hash = hash * 59 + ContactAddress.GetHashCode();
            }

            return hash;
        }
    }
}
