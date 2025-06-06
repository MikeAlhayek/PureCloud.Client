using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LicenseUpdateStatus
/// </summary>

public partial class LicenseUpdateStatus : IEquatable<LicenseUpdateStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseUpdateStatus" /> class.
    /// </summary>
    /// <param name="UserId">UserId.</param>
    /// <param name="LicenseId">LicenseId.</param>
    /// <param name="Result">Result.</param>
    public LicenseUpdateStatus(string UserId = null, string LicenseId = null, string Result = null)
    {
        this.UserId = UserId;
        this.LicenseId = LicenseId;
        this.Result = Result;

    }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets LicenseId
    /// </summary>
    [JsonPropertyName("licenseId")]
    public string LicenseId { get; set; }



    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [JsonPropertyName("result")]
    public string Result { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LicenseUpdateStatus {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
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
        return Equals(obj as LicenseUpdateStatus);
    }

    /// <summary>
    /// Returns true if LicenseUpdateStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of LicenseUpdateStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LicenseUpdateStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                LicenseId == other.LicenseId ||
                LicenseId != null &&
                LicenseId.Equals(other.LicenseId)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (LicenseId != null)
            {
                hash = hash * 59 + LicenseId.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            return hash;
        }
    }
}
