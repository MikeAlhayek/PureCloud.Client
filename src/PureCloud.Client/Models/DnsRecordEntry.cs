using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DnsRecordEntry
/// </summary>

public partial class DnsRecordEntry : IEquatable<DnsRecordEntry>
{
    /// <summary>
    /// the current status of the related verification process
    /// </summary>
    /// <value>the current status of the related verification process</value>
    
    public enum VerificationStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Verified for "Verified"
        /// </summary>
        [EnumMember(Value = "Verified")]
        Verified,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// the current status of the related verification process
    /// </summary>
    /// <value>the current status of the related verification process</value>
    [JsonPropertyName("verificationStatus")]
    public VerificationStatusEnum? VerificationStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DnsRecordEntry" /> class.
    /// </summary>
    /// <param name="Host">the hostname of the DNS entry.</param>
    /// <param name="RecordContents">the payload of the DNS entry.</param>
    /// <param name="VerificationStatus">the current status of the related verification process.</param>
    public DnsRecordEntry(string Host = null, string RecordContents = null, VerificationStatusEnum? VerificationStatus = null)
    {
        this.Host = Host;
        this.RecordContents = RecordContents;
        this.VerificationStatus = VerificationStatus;

    }



    /// <summary>
    /// the hostname of the DNS entry
    /// </summary>
    /// <value>the hostname of the DNS entry</value>
    [JsonPropertyName("host")]
    public string Host { get; set; }



    /// <summary>
    /// the payload of the DNS entry
    /// </summary>
    /// <value>the payload of the DNS entry</value>
    [JsonPropertyName("recordContents")]
    public string RecordContents { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DnsRecordEntry {\n");

        sb.Append("  Host: ").Append(Host).Append("\n");
        sb.Append("  RecordContents: ").Append(RecordContents).Append("\n");
        sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
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
        return Equals(obj as DnsRecordEntry);
    }

    /// <summary>
    /// Returns true if DnsRecordEntry instances are equal
    /// </summary>
    /// <param name="other">Instance of DnsRecordEntry to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DnsRecordEntry other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Host == other.Host ||
                Host != null &&
                Host.Equals(other.Host)
            ) &&
            (
                RecordContents == other.RecordContents ||
                RecordContents != null &&
                RecordContents.Equals(other.RecordContents)
            ) &&
            (
                VerificationStatus == other.VerificationStatus ||
                VerificationStatus != null &&
                VerificationStatus.Equals(other.VerificationStatus)
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
            if (Host != null)
            {
                hash = hash * 59 + Host.GetHashCode();
            }

            if (RecordContents != null)
            {
                hash = hash * 59 + RecordContents.GetHashCode();
            }

            if (VerificationStatus != null)
            {
                hash = hash * 59 + VerificationStatus.GetHashCode();
            }

            return hash;
        }
    }
}
