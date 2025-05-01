using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestWinnersRequest
/// </summary>
[DataContract]
public partial class ContestWinnersRequest : IEquatable<ContestWinnersRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestWinnersRequest" /> class.
    /// </summary>
    /// <param name="Tier">The Contest Winner tier.</param>
    /// <param name="UserIds">The Contest Winner users at the tier.</param>
    public ContestWinnersRequest(int? Tier = null, List<string> UserIds = null)
    {
        this.Tier = Tier;
        this.UserIds = UserIds;

    }



    /// <summary>
    /// The Contest Winner tier
    /// </summary>
    /// <value>The Contest Winner tier</value>
    [DataMember(Name = "tier", EmitDefaultValue = false)]
    public int? Tier { get; set; }



    /// <summary>
    /// The Contest Winner users at the tier
    /// </summary>
    /// <value>The Contest Winner users at the tier</value>
    [DataMember(Name = "userIds", EmitDefaultValue = false)]
    public List<string> UserIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestWinnersRequest {\n");

        sb.Append("  Tier: ").Append(Tier).Append("\n");
        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
        return Equals(obj as ContestWinnersRequest);
    }

    /// <summary>
    /// Returns true if ContestWinnersRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestWinnersRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestWinnersRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Tier == other.Tier ||
                Tier != null &&
                Tier.Equals(other.Tier)
            ) &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.SequenceEqual(other.UserIds)
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
            if (Tier != null)
            {
                hash = hash * 59 + Tier.GetHashCode();
            }

            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            return hash;
        }
    }
}
