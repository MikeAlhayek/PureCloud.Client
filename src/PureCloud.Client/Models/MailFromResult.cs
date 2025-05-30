using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MailFromResult
/// </summary>

public partial class MailFromResult : IEquatable<MailFromResult>
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
    /// Initializes a new instance of the <see cref="MailFromResult" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MailFromResult() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MailFromResult" /> class.
    /// </summary>
    /// <param name="Status">The verification status..</param>
    /// <param name="Records">The list of DNS records that pertain that need to exist for verification..</param>
    /// <param name="MailFromDomain">The custom MAIL FROM domain. (required).</param>
    public MailFromResult(StatusEnum? Status = null, List<Record> Records = null, string MailFromDomain = null)
    {
        this.Status = Status;
        this.Records = Records;
        this.MailFromDomain = MailFromDomain;

    }





    /// <summary>
    /// The list of DNS records that pertain that need to exist for verification.
    /// </summary>
    /// <value>The list of DNS records that pertain that need to exist for verification.</value>
    [JsonPropertyName("records")]
    public List<Record> Records { get; set; }



    /// <summary>
    /// The custom MAIL FROM domain.
    /// </summary>
    /// <value>The custom MAIL FROM domain.</value>
    [JsonPropertyName("mailFromDomain")]
    public string MailFromDomain { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MailFromResult {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Records: ").Append(Records).Append("\n");
        sb.Append("  MailFromDomain: ").Append(MailFromDomain).Append("\n");
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
        return Equals(obj as MailFromResult);
    }

    /// <summary>
    /// Returns true if MailFromResult instances are equal
    /// </summary>
    /// <param name="other">Instance of MailFromResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MailFromResult other)
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
            ) &&
            (
                MailFromDomain == other.MailFromDomain ||
                MailFromDomain != null &&
                MailFromDomain.Equals(other.MailFromDomain)
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

            if (MailFromDomain != null)
            {
                hash = hash * 59 + MailFromDomain.GetHashCode();
            }

            return hash;
        }
    }
}
