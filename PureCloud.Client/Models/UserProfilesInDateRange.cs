using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserProfilesInDateRange
/// </summary>
[DataContract]
public partial class UserProfilesInDateRange : IEquatable<UserProfilesInDateRange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserProfilesInDateRange" /> class.
    /// </summary>
    /// <param name="User">The query agent.</param>
    /// <param name="DateStartWorkday">Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="DateEndWorkday">End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="Profiles">The list of profiles of the agent.</param>
    public UserProfilesInDateRange(UserReference User = null, string DateStartWorkday = null, string DateEndWorkday = null, List<ProfileWithDateRange> Profiles = null)
    {
        this.User = User;
        this.DateStartWorkday = DateStartWorkday;
        this.DateEndWorkday = DateEndWorkday;
        this.Profiles = Profiles;

    }



    /// <summary>
    /// The query agent
    /// </summary>
    /// <value>The query agent</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserReference User { get; set; }



    /// <summary>
    /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateStartWorkday", EmitDefaultValue = false)]
    public string DateStartWorkday { get; set; }



    /// <summary>
    /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateEndWorkday", EmitDefaultValue = false)]
    public string DateEndWorkday { get; set; }



    /// <summary>
    /// The list of profiles of the agent
    /// </summary>
    /// <value>The list of profiles of the agent</value>
    [DataMember(Name = "profiles", EmitDefaultValue = false)]
    public List<ProfileWithDateRange> Profiles { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserProfilesInDateRange {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
        sb.Append("  Profiles: ").Append(Profiles).Append("\n");
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
        return Equals(obj as UserProfilesInDateRange);
    }

    /// <summary>
    /// Returns true if UserProfilesInDateRange instances are equal
    /// </summary>
    /// <param name="other">Instance of UserProfilesInDateRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserProfilesInDateRange other)
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
                Profiles == other.Profiles ||
                Profiles != null &&
                Profiles.SequenceEqual(other.Profiles)
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

            if (DateStartWorkday != null)
            {
                hash = hash * 59 + DateStartWorkday.GetHashCode();
            }

            if (DateEndWorkday != null)
            {
                hash = hash * 59 + DateEndWorkday.GetHashCode();
            }

            if (Profiles != null)
            {
                hash = hash * 59 + Profiles.GetHashCode();
            }

            return hash;
        }
    }
}
