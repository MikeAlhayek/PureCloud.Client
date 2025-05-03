using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestScoresAgentTrendList
/// </summary>

public partial class ContestScoresAgentTrendList : IEquatable<ContestScoresAgentTrendList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestScoresAgentTrendList" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="User">The Contest Scores Leaderboard user.</param>
    public ContestScoresAgentTrendList(List<ContestScoresAgentTrend> Entities = null, UserReference User = null)
    {
        this.Entities = Entities;
        this.User = User;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<ContestScoresAgentTrend> Entities { get; set; }



    /// <summary>
    /// The Contest Scores Leaderboard user
    /// </summary>
    /// <value>The Contest Scores Leaderboard user</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestScoresAgentTrendList {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as ContestScoresAgentTrendList);
    }

    /// <summary>
    /// Returns true if ContestScoresAgentTrendList instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestScoresAgentTrendList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestScoresAgentTrendList other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
