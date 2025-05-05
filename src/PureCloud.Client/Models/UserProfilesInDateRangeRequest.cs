using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserProfilesInDateRangeRequest
/// </summary>

public partial class UserProfilesInDateRangeRequest : IEquatable<UserProfilesInDateRangeRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UserProfilesInDateRangeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserProfilesInDateRangeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserProfilesInDateRangeRequest" /> class.
    /// </summary>
    /// <param name="StartWorkday">Start work day in ISO-8601 format used in the date range. (required).</param>
    /// <param name="EndWorkday">End work day in ISO-8601 format used in the date range. (required).</param>
    public UserProfilesInDateRangeRequest(string StartWorkday = null, string EndWorkday = null)
    {
        this.StartWorkday = StartWorkday;
        this.EndWorkday = EndWorkday;

    }



    /// <summary>
    /// Start work day in ISO-8601 format used in the date range.
    /// </summary>
    /// <value>Start work day in ISO-8601 format used in the date range.</value>
    [JsonPropertyName("startWorkday")]
    public string StartWorkday { get; set; }



    /// <summary>
    /// End work day in ISO-8601 format used in the date range.
    /// </summary>
    /// <value>End work day in ISO-8601 format used in the date range.</value>
    [JsonPropertyName("endWorkday")]
    public string EndWorkday { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserProfilesInDateRangeRequest {\n");

        sb.Append("  StartWorkday: ").Append(StartWorkday).Append("\n");
        sb.Append("  EndWorkday: ").Append(EndWorkday).Append("\n");
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
        return Equals(obj as UserProfilesInDateRangeRequest);
    }

    /// <summary>
    /// Returns true if UserProfilesInDateRangeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UserProfilesInDateRangeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserProfilesInDateRangeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartWorkday == other.StartWorkday ||
                StartWorkday != null &&
                StartWorkday.Equals(other.StartWorkday)
            ) &&
            (
                EndWorkday == other.EndWorkday ||
                EndWorkday != null &&
                EndWorkday.Equals(other.EndWorkday)
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
            if (StartWorkday != null)
            {
                hash = hash * 59 + StartWorkday.GetHashCode();
            }

            if (EndWorkday != null)
            {
                hash = hash * 59 + EndWorkday.GetHashCode();
            }

            return hash;
        }
    }
}
