using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserBestPointsItem
/// </summary>

public partial class UserBestPointsItem : IEquatable<UserBestPointsItem>
{
    /// <summary>
    /// Best points aggregation interval granularity
    /// </summary>
    /// <value>Best points aggregation interval granularity</value>
    
    public enum GranularityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Daily for "Daily"
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily,

        /// <summary>
        /// Enum Weekly for "Weekly"
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly,

        /// <summary>
        /// Enum Monthly for "Monthly"
        /// </summary>
        [EnumMember(Value = "Monthly")]
        Monthly
    }
    /// <summary>
    /// Best points aggregation interval granularity
    /// </summary>
    /// <value>Best points aggregation interval granularity</value>
    [JsonPropertyName("granularityType")]
    public GranularityTypeEnum? GranularityType { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserBestPointsItem" /> class.
    /// </summary>
    public UserBestPointsItem()
    {

    }





    /// <summary>
    /// Gamification points
    /// </summary>
    /// <value>Gamification points</value>
    [JsonPropertyName("points")]
    public int? Points { get; private set; }



    /// <summary>
    /// Start workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStartWorkday")]
    public string DateStartWorkday { get; private set; }



    /// <summary>
    /// End workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday of the best points aggregation interval. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndWorkday")]
    public string DateEndWorkday { get; private set; }



    /// <summary>
    /// The rank of this user
    /// </summary>
    /// <value>The rank of this user</value>
    [JsonPropertyName("rank")]
    public int? Rank { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserBestPointsItem {\n");

        sb.Append("  GranularityType: ").Append(GranularityType).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
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
        return Equals(obj as UserBestPointsItem);
    }

    /// <summary>
    /// Returns true if UserBestPointsItem instances are equal
    /// </summary>
    /// <param name="other">Instance of UserBestPointsItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserBestPointsItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                GranularityType == other.GranularityType ||
                GranularityType != null &&
                GranularityType.Equals(other.GranularityType)
            ) &&
            (
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
            ) &&
            (
                DateStartWorkday == other.DateStartWorkday ||
                DateStartWorkday != null &&
                DateStartWorkday.Equals(other.DateStartWorkday)
            ) &&
            (
                DateEndWorkday == other.DateEndWorkday ||
                DateEndWorkday != null &&
                DateEndWorkday.Equals(other.DateEndWorkday)
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
            if (GranularityType != null)
            {
                hash = hash * 59 + GranularityType.GetHashCode();
            }

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            if (DateStartWorkday != null)
            {
                hash = hash * 59 + DateStartWorkday.GetHashCode();
            }

            if (DateEndWorkday != null)
            {
                hash = hash * 59 + DateEndWorkday.GetHashCode();
            }

            if (Rank != null)
            {
                hash = hash * 59 + Rank.GetHashCode();
            }

            return hash;
        }
    }
}
