using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// V2WemEngagementCelebrationUpdatesTopicContestMetrics
/// </summary>
[DataContract]
public partial class V2WemEngagementCelebrationUpdatesTopicContestMetrics : IEquatable<V2WemEngagementCelebrationUpdatesTopicContestMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestMetrics" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    public V2WemEngagementCelebrationUpdatesTopicContestMetrics(Guid? Id = null, string Name = null)
    {
        this.Id = Id;
        this.Name = Name;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestMetrics {\n");

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
        return Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestMetrics);
    }

    /// <summary>
    /// Returns true if V2WemEngagementCelebrationUpdatesTopicContestMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestMetrics other)
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
