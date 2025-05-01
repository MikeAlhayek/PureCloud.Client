using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateNotificationResponse
/// </summary>
[DataContract]
public partial class UpdateNotificationResponse : IEquatable<UpdateNotificationResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateNotificationResponse" /> class.
    /// </summary>
    /// <param name="MutableGroupId">The mutableGroupId of the notification.</param>
    /// <param name="Id">The id of the notification for mapping the potentially new mutableGroupId.</param>
    public UpdateNotificationResponse(string MutableGroupId = null, string Id = null)
    {
        this.MutableGroupId = MutableGroupId;
        this.Id = Id;

    }



    /// <summary>
    /// The mutableGroupId of the notification
    /// </summary>
    /// <value>The mutableGroupId of the notification</value>
    [DataMember(Name = "mutableGroupId", EmitDefaultValue = false)]
    public string MutableGroupId { get; set; }



    /// <summary>
    /// The id of the notification for mapping the potentially new mutableGroupId
    /// </summary>
    /// <value>The id of the notification for mapping the potentially new mutableGroupId</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateNotificationResponse {\n");

        sb.Append("  MutableGroupId: ").Append(MutableGroupId).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as UpdateNotificationResponse);
    }

    /// <summary>
    /// Returns true if UpdateNotificationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateNotificationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateNotificationResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MutableGroupId == other.MutableGroupId ||
                MutableGroupId != null &&
                MutableGroupId.Equals(other.MutableGroupId)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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
            if (MutableGroupId != null)
            {
                hash = hash * 59 + MutableGroupId.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
