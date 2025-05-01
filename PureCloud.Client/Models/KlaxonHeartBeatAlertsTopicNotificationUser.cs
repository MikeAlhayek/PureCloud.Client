using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// KlaxonHeartBeatAlertsTopicNotificationUser
/// </summary>
[DataContract]
public partial class KlaxonHeartBeatAlertsTopicNotificationUser : IEquatable<KlaxonHeartBeatAlertsTopicNotificationUser>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KlaxonHeartBeatAlertsTopicNotificationUser" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="DisplayName">DisplayName.</param>
    public KlaxonHeartBeatAlertsTopicNotificationUser(string Id = null, string DisplayName = null)
    {
        this.Id = Id;
        this.DisplayName = DisplayName;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KlaxonHeartBeatAlertsTopicNotificationUser {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
        return Equals(obj as KlaxonHeartBeatAlertsTopicNotificationUser);
    }

    /// <summary>
    /// Returns true if KlaxonHeartBeatAlertsTopicNotificationUser instances are equal
    /// </summary>
    /// <param name="other">Instance of KlaxonHeartBeatAlertsTopicNotificationUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KlaxonHeartBeatAlertsTopicNotificationUser other)
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
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
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

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            return hash;
        }
    }
}
