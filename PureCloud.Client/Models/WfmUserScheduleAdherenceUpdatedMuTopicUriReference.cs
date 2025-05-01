using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserScheduleAdherenceUpdatedMuTopicUriReference
/// </summary>
[DataContract]
public partial class WfmUserScheduleAdherenceUpdatedMuTopicUriReference : IEquatable<WfmUserScheduleAdherenceUpdatedMuTopicUriReference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserScheduleAdherenceUpdatedMuTopicUriReference" /> class.
    /// </summary>
    /// <param name="Id">The ID of the resource.</param>
    /// <param name="Name">The name of the resource.</param>
    public WfmUserScheduleAdherenceUpdatedMuTopicUriReference(string Id = null, string Name = null)
    {
        this.Id = Id;
        this.Name = Name;

    }



    /// <summary>
    /// The ID of the resource
    /// </summary>
    /// <value>The ID of the resource</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The name of the resource
    /// </summary>
    /// <value>The name of the resource</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserScheduleAdherenceUpdatedMuTopicUriReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as WfmUserScheduleAdherenceUpdatedMuTopicUriReference);
    }

    /// <summary>
    /// Returns true if WfmUserScheduleAdherenceUpdatedMuTopicUriReference instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserScheduleAdherenceUpdatedMuTopicUriReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserScheduleAdherenceUpdatedMuTopicUriReference other)
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

            return hash;
        }
    }
}
