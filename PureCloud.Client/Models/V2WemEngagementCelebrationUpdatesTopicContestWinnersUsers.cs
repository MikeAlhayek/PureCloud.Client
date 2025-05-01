using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers
/// </summary>
[DataContract]
public partial class V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers : IEquatable<V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Rank">Rank.</param>
    public V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers(Guid? Id = null, long? Rank = null)
    {
        this.Id = Id;
        this.Rank = Rank;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets Rank
    /// </summary>
    [DataMember(Name = "rank", EmitDefaultValue = false)]
    public long? Rank { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Rank: ").Append(Rank).Append("\n");
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
        return Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers);
    }

    /// <summary>
    /// Returns true if V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers instances are equal
    /// </summary>
    /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers other)
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
                Rank == other.Rank ||
                Rank != null &&
                Rank.Equals(other.Rank)
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

            if (Rank != null)
            {
                hash = hash * 59 + Rank.GetHashCode();
            }

            return hash;
        }
    }
}
