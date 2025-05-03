using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailOutboundDomainResult
/// </summary>

public partial class EmailOutboundDomainResult : IEquatable<EmailOutboundDomainResult>
{
    /// <summary>
    /// Gets or Sets SenderStatus
    /// </summary>
    
    public enum SenderStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Requestreceived for "RequestReceived"
        /// </summary>
        [EnumMember(Value = "RequestReceived")]
        Requestreceived,

        /// <summary>
        /// Enum Provisionrequestsentvendor for "ProvisionRequestSentVendor"
        /// </summary>
        [EnumMember(Value = "ProvisionRequestSentVendor")]
        Provisionrequestsentvendor,

        /// <summary>
        /// Enum Provisioned for "Provisioned"
        /// </summary>
        [EnumMember(Value = "Provisioned")]
        Provisioned,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Deprovisioned for "Deprovisioned"
        /// </summary>
        [EnumMember(Value = "Deprovisioned")]
        Deprovisioned
    }
    /// <summary>
    /// Gets or Sets SenderType
    /// </summary>
    
    public enum SenderTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Emaildomain for "EmailDomain"
        /// </summary>
        [EnumMember(Value = "EmailDomain")]
        Emaildomain,

        /// <summary>
        /// Enum Mockemaildomain for "MockEmailDomain"
        /// </summary>
        [EnumMember(Value = "MockEmailDomain")]
        Mockemaildomain
    }
    /// <summary>
    /// Gets or Sets SenderStatus
    /// </summary>
    [JsonPropertyName("senderStatus")]
    public SenderStatusEnum? SenderStatus { get; set; }
    /// <summary>
    /// Gets or Sets SenderType
    /// </summary>
    [JsonPropertyName("senderType")]
    public SenderTypeEnum? SenderType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailOutboundDomainResult" /> class.
    /// </summary>
    /// <param name="DnsCnameBounceRecord">DnsCnameBounceRecord.</param>
    /// <param name="DnsTxtSendingRecord">DnsTxtSendingRecord.</param>
    /// <param name="DomainName">DomainName.</param>
    /// <param name="SenderStatus">SenderStatus.</param>
    /// <param name="SenderType">SenderType.</param>
    public EmailOutboundDomainResult(DnsRecordEntry DnsCnameBounceRecord = null, DnsRecordEntry DnsTxtSendingRecord = null, string DomainName = null, SenderStatusEnum? SenderStatus = null, SenderTypeEnum? SenderType = null)
    {
        this.DnsCnameBounceRecord = DnsCnameBounceRecord;
        this.DnsTxtSendingRecord = DnsTxtSendingRecord;
        this.DomainName = DomainName;
        this.SenderStatus = SenderStatus;
        this.SenderType = SenderType;

    }



    /// <summary>
    /// Gets or Sets DnsCnameBounceRecord
    /// </summary>
    [JsonPropertyName("dnsCnameBounceRecord")]
    public DnsRecordEntry DnsCnameBounceRecord { get; set; }



    /// <summary>
    /// Gets or Sets DnsTxtSendingRecord
    /// </summary>
    [JsonPropertyName("dnsTxtSendingRecord")]
    public DnsRecordEntry DnsTxtSendingRecord { get; set; }



    /// <summary>
    /// Gets or Sets DomainName
    /// </summary>
    [JsonPropertyName("domainName")]
    public string DomainName { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailOutboundDomainResult {\n");

        sb.Append("  DnsCnameBounceRecord: ").Append(DnsCnameBounceRecord).Append("\n");
        sb.Append("  DnsTxtSendingRecord: ").Append(DnsTxtSendingRecord).Append("\n");
        sb.Append("  DomainName: ").Append(DomainName).Append("\n");
        sb.Append("  SenderStatus: ").Append(SenderStatus).Append("\n");
        sb.Append("  SenderType: ").Append(SenderType).Append("\n");
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
        return Equals(obj as EmailOutboundDomainResult);
    }

    /// <summary>
    /// Returns true if EmailOutboundDomainResult instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailOutboundDomainResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailOutboundDomainResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DnsCnameBounceRecord == other.DnsCnameBounceRecord ||
                DnsCnameBounceRecord != null &&
                DnsCnameBounceRecord.Equals(other.DnsCnameBounceRecord)
            ) &&
            (
                DnsTxtSendingRecord == other.DnsTxtSendingRecord ||
                DnsTxtSendingRecord != null &&
                DnsTxtSendingRecord.Equals(other.DnsTxtSendingRecord)
            ) &&
            (
                DomainName == other.DomainName ||
                DomainName != null &&
                DomainName.Equals(other.DomainName)
            ) &&
            (
                SenderStatus == other.SenderStatus ||
                SenderStatus != null &&
                SenderStatus.Equals(other.SenderStatus)
            ) &&
            (
                SenderType == other.SenderType ||
                SenderType != null &&
                SenderType.Equals(other.SenderType)
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
            if (DnsCnameBounceRecord != null)
            {
                hash = hash * 59 + DnsCnameBounceRecord.GetHashCode();
            }

            if (DnsTxtSendingRecord != null)
            {
                hash = hash * 59 + DnsTxtSendingRecord.GetHashCode();
            }

            if (DomainName != null)
            {
                hash = hash * 59 + DomainName.GetHashCode();
            }

            if (SenderStatus != null)
            {
                hash = hash * 59 + SenderStatus.GetHashCode();
            }

            if (SenderType != null)
            {
                hash = hash * 59 + SenderType.GetHashCode();
            }

            return hash;
        }
    }
}
