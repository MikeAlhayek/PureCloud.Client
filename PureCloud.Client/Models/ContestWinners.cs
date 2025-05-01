using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestWinners
/// </summary>
[DataContract]
public partial class ContestWinners : IEquatable<ContestWinners>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestWinners" /> class.
    /// </summary>
    /// <param name="Tier">The Contest Winner tier.</param>
    /// <param name="Users">The Contest Winner users at the tier.</param>
    public ContestWinners(int? Tier = null, List<ContestUserRank> Users = null)
    {
        this.Tier = Tier;
        this.Users = Users;

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
    [DataMember(Name = "users", EmitDefaultValue = false)]
    public List<ContestUserRank> Users { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestWinners {\n");

        sb.Append("  Tier: ").Append(Tier).Append("\n");
        sb.Append("  Users: ").Append(Users).Append("\n");
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
        return this.Equals(obj as ContestWinners);
    }

    /// <summary>
    /// Returns true if ContestWinners instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestWinners to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestWinners other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Tier == other.Tier ||
                this.Tier != null &&
                this.Tier.Equals(other.Tier)
            ) &&
            (
                this.Users == other.Users ||
                this.Users != null &&
                this.Users.SequenceEqual(other.Users)
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
            if (this.Tier != null)
            {
                hash = hash * 59 + this.Tier.GetHashCode();
            }

            if (this.Users != null)
            {
                hash = hash * 59 + this.Users.GetHashCode();
            }

            return hash;
        }
    }
}
