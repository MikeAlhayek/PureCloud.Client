using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsContactChangedTopicLineId
/// </summary>
[DataContract]
public partial class ExternalContactsContactChangedTopicLineId : IEquatable<ExternalContactsContactChangedTopicLineId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicLineId" /> class.
    /// </summary>
    /// <param name="Ids">Ids.</param>
    /// <param name="DisplayName">DisplayName.</param>
    public ExternalContactsContactChangedTopicLineId(List<ExternalContactsContactChangedTopicLineUserId> Ids = null, string DisplayName = null)
    {
        this.Ids = Ids;
        this.DisplayName = DisplayName;

    }



    /// <summary>
    /// Gets or Sets Ids
    /// </summary>
    [DataMember(Name = "ids", EmitDefaultValue = false)]
    public List<ExternalContactsContactChangedTopicLineUserId> Ids { get; set; }



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
        sb.Append("class ExternalContactsContactChangedTopicLineId {\n");

        sb.Append("  Ids: ").Append(Ids).Append("\n");
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
        return Equals(obj as ExternalContactsContactChangedTopicLineId);
    }

    /// <summary>
    /// Returns true if ExternalContactsContactChangedTopicLineId instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsContactChangedTopicLineId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsContactChangedTopicLineId other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Ids == other.Ids ||
                Ids != null &&
                Ids.SequenceEqual(other.Ids)
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
            if (Ids != null)
            {
                hash = hash * 59 + Ids.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            return hash;
        }
    }
}
