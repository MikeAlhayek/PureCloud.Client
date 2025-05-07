using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundDomain
/// </summary>

public partial class OutboundDomain : IEquatable<OutboundDomain>
{
    /// <summary>
    /// Sender Type
    /// </summary>
    /// <value>Sender Type</value>
    
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
    /// Sender Type
    /// </summary>
    /// <value>Sender Type</value>
    [JsonPropertyName("senderType")]
    public SenderTypeEnum? SenderType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundDomain" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OutboundDomain() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundDomain" /> class.
    /// </summary>
    /// <param name="Id">Unique Id of the domain such as: example.com (required).</param>
    /// <param name="Name">Name.</param>
    /// <param name="CnameVerificationResult">CNAME registration Status.</param>
    /// <param name="DkimVerificationResult">DKIM registration Status.</param>
    /// <param name="SenderType">Sender Type.</param>
    public OutboundDomain(string Id = null, string Name = null, VerificationResult CnameVerificationResult = null, VerificationResult DkimVerificationResult = null, SenderTypeEnum? SenderType = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.CnameVerificationResult = CnameVerificationResult;
        this.DkimVerificationResult = DkimVerificationResult;
        this.SenderType = SenderType;

    }



    /// <summary>
    /// Unique Id of the domain such as: example.com
    /// </summary>
    /// <value>Unique Id of the domain such as: example.com</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// CNAME registration Status
    /// </summary>
    /// <value>CNAME registration Status</value>
    [JsonPropertyName("cnameVerificationResult")]
    public VerificationResult CnameVerificationResult { get; set; }



    /// <summary>
    /// DKIM registration Status
    /// </summary>
    /// <value>DKIM registration Status</value>
    [JsonPropertyName("dkimVerificationResult")]
    public VerificationResult DkimVerificationResult { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundDomain {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CnameVerificationResult: ").Append(CnameVerificationResult).Append("\n");
        sb.Append("  DkimVerificationResult: ").Append(DkimVerificationResult).Append("\n");
        sb.Append("  SenderType: ").Append(SenderType).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as OutboundDomain);
    }

    /// <summary>
    /// Returns true if OutboundDomain instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundDomain to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundDomain other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                CnameVerificationResult == other.CnameVerificationResult ||
                CnameVerificationResult != null &&
                CnameVerificationResult.Equals(other.CnameVerificationResult)
            ) &&
            (
                DkimVerificationResult == other.DkimVerificationResult ||
                DkimVerificationResult != null &&
                DkimVerificationResult.Equals(other.DkimVerificationResult)
            ) &&
            (
                SenderType == other.SenderType ||
                SenderType != null &&
                SenderType.Equals(other.SenderType)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (CnameVerificationResult != null)
            {
                hash = hash * 59 + CnameVerificationResult.GetHashCode();
            }

            if (DkimVerificationResult != null)
            {
                hash = hash * 59 + DkimVerificationResult.GetHashCode();
            }

            if (SenderType != null)
            {
                hash = hash * 59 + SenderType.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
