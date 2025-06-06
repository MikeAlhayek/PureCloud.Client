using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserBestPoints
/// </summary>

public partial class UserBestPoints : IEquatable<UserBestPoints>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserBestPoints" /> class.
    /// </summary>
    public UserBestPoints()
    {

    }



    /// <summary>
    /// The requested user for the best points
    /// </summary>
    /// <value>The requested user for the best points</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// List of best point for the requested user
    /// </summary>
    /// <value>List of best point for the requested user</value>
    [JsonPropertyName("bestPoints")]
    public List<UserBestPointsItem> BestPoints { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserBestPoints {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  BestPoints: ").Append(BestPoints).Append("\n");
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
        return Equals(obj as UserBestPoints);
    }

    /// <summary>
    /// Returns true if UserBestPoints instances are equal
    /// </summary>
    /// <param name="other">Instance of UserBestPoints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserBestPoints other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                BestPoints == other.BestPoints ||
                BestPoints != null &&
                BestPoints.SequenceEqual(other.BestPoints)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (BestPoints != null)
            {
                hash = hash * 59 + BestPoints.GetHashCode();
            }

            return hash;
        }
    }
}
