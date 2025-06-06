using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VerificationResult
/// </summary>

public partial class VerificationResult : IEquatable<VerificationResult>
{
    /// <summary>
    /// The verification status.
    /// </summary>
    /// <value>The verification status.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        /// Enum Pending for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Enum Verified for "VERIFIED"
        /// </summary>
        [EnumMember(Value = "VERIFIED")]
        Verified,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown
    }
    /// <summary>
    /// The verification status.
    /// </summary>
    /// <value>The verification status.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="VerificationResult" /> class.
    /// </summary>
    /// <param name="Status">The verification status..</param>
    /// <param name="Records">The list of DNS records that pertain that need to exist for verification..</param>
    public VerificationResult(StatusEnum? Status = null, List<Record> Records = null)
    {
        this.Status = Status;
        this.Records = Records;

    }





    /// <summary>
    /// The list of DNS records that pertain that need to exist for verification.
    /// </summary>
    /// <value>The list of DNS records that pertain that need to exist for verification.</value>
    [JsonPropertyName("records")]
    public List<Record> Records { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VerificationResult {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Records: ").Append(Records).Append("\n");
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
        return Equals(obj as VerificationResult);
    }

    /// <summary>
    /// Returns true if VerificationResult instances are equal
    /// </summary>
    /// <param name="other">Instance of VerificationResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VerificationResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Records == other.Records ||
                Records != null &&
                Records.SequenceEqual(other.Records)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Records != null)
            {
                hash = hash * 59 + Records.GetHashCode();
            }

            return hash;
        }
    }
}
