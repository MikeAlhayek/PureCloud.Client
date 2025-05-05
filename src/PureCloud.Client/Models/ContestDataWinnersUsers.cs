using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestDataWinnersUsers
/// </summary>

public partial class ContestDataWinnersUsers : IEquatable<ContestDataWinnersUsers>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestDataWinnersUsers" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Rank">The Contest user&#39;s rank.</param>
    public ContestDataWinnersUsers(string Id = null, int? Rank = null)
    {
        this.Id = Id;
        this.Rank = Rank;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The Contest user&#39;s rank
    /// </summary>
    /// <value>The Contest user&#39;s rank</value>
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestDataWinnersUsers {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Rank: ").Append(Rank).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as ContestDataWinnersUsers);
    }

    /// <summary>
    /// Returns true if ContestDataWinnersUsers instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestDataWinnersUsers to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestDataWinnersUsers other)
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
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
