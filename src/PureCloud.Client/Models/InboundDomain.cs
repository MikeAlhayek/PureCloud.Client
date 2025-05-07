using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InboundDomain
/// </summary>

public partial class InboundDomain : IEquatable<InboundDomain>
{
    /// <summary>
    /// Mx Record Status
    /// </summary>
    /// <value>Mx Record Status</value>
    
    public enum MxRecordStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Valid for "VALID"
        /// </summary>
        [EnumMember(Value = "VALID")]
        Valid,

        /// <summary>
        /// Enum Invalid for "INVALID"
        /// </summary>
        [EnumMember(Value = "INVALID")]
        Invalid,

        /// <summary>
        /// Enum NotAvailable for "NOT_AVAILABLE"
        /// </summary>
        [EnumMember(Value = "NOT_AVAILABLE")]
        NotAvailable
    }
    /// <summary>
    /// Mx Record Status
    /// </summary>
    /// <value>Mx Record Status</value>
    [JsonPropertyName("mxRecordStatus")]
    public MxRecordStatusEnum? MxRecordStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="InboundDomain" /> class.
    /// </summary>
    /// <param name="Id">Unique Id of the domain such as: example.com.</param>
    /// <param name="Name">Name.</param>
    /// <param name="MxRecordStatus">Mx Record Status.</param>
    /// <param name="SubDomain">Indicates if this a PureCloudEnvironment sub-domain.  If true, then the appropriate DNS records are created for sending/receiving email..</param>
    /// <param name="MailFromSettings">The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false..</param>
    /// <param name="CustomSMTPServer">The custom SMTP server integration to use when sending outbound emails from this domain..</param>
    public InboundDomain(string Id = null, string Name = null, MxRecordStatusEnum? MxRecordStatus = null, bool? SubDomain = null, MailFromResult MailFromSettings = null, DomainEntityRef CustomSMTPServer = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.MxRecordStatus = MxRecordStatus;
        this.SubDomain = SubDomain;
        this.MailFromSettings = MailFromSettings;
        this.CustomSMTPServer = CustomSMTPServer;

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
    /// Indicates if this a PureCloudEnvironment sub-domain.  If true, then the appropriate DNS records are created for sending/receiving email.
    /// </summary>
    /// <value>Indicates if this a PureCloudEnvironment sub-domain.  If true, then the appropriate DNS records are created for sending/receiving email.</value>
    [JsonPropertyName("subDomain")]
    public bool? SubDomain { get; set; }



    /// <summary>
    /// The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false.
    /// </summary>
    /// <value>The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false.</value>
    [JsonPropertyName("mailFromSettings")]
    public MailFromResult MailFromSettings { get; set; }



    /// <summary>
    /// The custom SMTP server integration to use when sending outbound emails from this domain.
    /// </summary>
    /// <value>The custom SMTP server integration to use when sending outbound emails from this domain.</value>
    [JsonPropertyName("customSMTPServer")]
    public DomainEntityRef CustomSMTPServer { get; set; }



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
        sb.Append("class InboundDomain {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MxRecordStatus: ").Append(MxRecordStatus).Append("\n");
        sb.Append("  SubDomain: ").Append(SubDomain).Append("\n");
        sb.Append("  MailFromSettings: ").Append(MailFromSettings).Append("\n");
        sb.Append("  CustomSMTPServer: ").Append(CustomSMTPServer).Append("\n");
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
        return Equals(obj as InboundDomain);
    }

    /// <summary>
    /// Returns true if InboundDomain instances are equal
    /// </summary>
    /// <param name="other">Instance of InboundDomain to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InboundDomain other)
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
                MxRecordStatus == other.MxRecordStatus ||
                MxRecordStatus != null &&
                MxRecordStatus.Equals(other.MxRecordStatus)
            ) &&
            (
                SubDomain == other.SubDomain ||
                SubDomain != null &&
                SubDomain.Equals(other.SubDomain)
            ) &&
            (
                MailFromSettings == other.MailFromSettings ||
                MailFromSettings != null &&
                MailFromSettings.Equals(other.MailFromSettings)
            ) &&
            (
                CustomSMTPServer == other.CustomSMTPServer ||
                CustomSMTPServer != null &&
                CustomSMTPServer.Equals(other.CustomSMTPServer)
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

            if (MxRecordStatus != null)
            {
                hash = hash * 59 + MxRecordStatus.GetHashCode();
            }

            if (SubDomain != null)
            {
                hash = hash * 59 + SubDomain.GetHashCode();
            }

            if (MailFromSettings != null)
            {
                hash = hash * 59 + MailFromSettings.GetHashCode();
            }

            if (CustomSMTPServer != null)
            {
                hash = hash * 59 + CustomSMTPServer.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
