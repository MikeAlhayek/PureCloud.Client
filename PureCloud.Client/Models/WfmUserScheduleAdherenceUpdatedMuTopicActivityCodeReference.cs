using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference
/// </summary>
[DataContract]
public partial class WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference : IEquatable<WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="SecondaryPresences">SecondaryPresences.</param>
    public WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference(string Id = null, List<WfmUserScheduleAdherenceUpdatedMuTopicSecondaryPresenceReference> SecondaryPresences = null)
    {
        this.Id = Id;
        this.SecondaryPresences = SecondaryPresences;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets SecondaryPresences
    /// </summary>
    [DataMember(Name = "secondaryPresences", EmitDefaultValue = false)]
    public List<WfmUserScheduleAdherenceUpdatedMuTopicSecondaryPresenceReference> SecondaryPresences { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SecondaryPresences: ").Append(SecondaryPresences).Append("\n");
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
        return Equals(obj as WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference);
    }

    /// <summary>
    /// Returns true if WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference other)
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
                SecondaryPresences == other.SecondaryPresences ||
                SecondaryPresences != null &&
                SecondaryPresences.SequenceEqual(other.SecondaryPresences)
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

            if (SecondaryPresences != null)
            {
                hash = hash * 59 + SecondaryPresences.GetHashCode();
            }

            return hash;
        }
    }
}
