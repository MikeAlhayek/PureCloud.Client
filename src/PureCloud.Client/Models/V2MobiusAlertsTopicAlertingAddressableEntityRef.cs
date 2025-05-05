using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusAlertsTopicAlertingAddressableEntityRef
/// </summary>

public partial class V2MobiusAlertsTopicAlertingAddressableEntityRef : IEquatable<V2MobiusAlertsTopicAlertingAddressableEntityRef>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicAlertingAddressableEntityRef" /> class.
    /// </summary>
    /// <param name="Id">The ID of the resource.</param>
    /// <param name="DisplayName">DisplayName.</param>
    public V2MobiusAlertsTopicAlertingAddressableEntityRef(string Id = null, string DisplayName = null)
    {
        this.Id = Id;
        this.DisplayName = DisplayName;

    }



    /// <summary>
    /// The ID of the resource
    /// </summary>
    /// <value>The ID of the resource</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusAlertsTopicAlertingAddressableEntityRef {\n");

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
        return Equals(obj as V2MobiusAlertsTopicAlertingAddressableEntityRef);
    }

    /// <summary>
    /// Returns true if V2MobiusAlertsTopicAlertingAddressableEntityRef instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusAlertsTopicAlertingAddressableEntityRef to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusAlertsTopicAlertingAddressableEntityRef other)
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
