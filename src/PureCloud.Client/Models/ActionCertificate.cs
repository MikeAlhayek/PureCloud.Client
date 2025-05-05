using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details for an mTLS certificate
/// </summary>

public partial class ActionCertificate : IEquatable<ActionCertificate>
{
    /// <summary>
    /// The Signing Authority for the certificate
    /// </summary>
    /// <value>The Signing Authority for the certificate</value>
    
    public enum SigningAuthorityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Digicert for "DigiCert"
        /// </summary>
        [EnumMember(Value = "DigiCert")]
        Digicert,

        /// <summary>
        /// Enum Genesys for "Genesys"
        /// </summary>
        [EnumMember(Value = "Genesys")]
        Genesys
    }
    /// <summary>
    /// The certificate status
    /// </summary>
    /// <value>The certificate status</value>
    
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
        /// Enum Current for "Current"
        /// </summary>
        [EnumMember(Value = "Current")]
        Current,

        /// <summary>
        /// Enum Upcoming for "Upcoming"
        /// </summary>
        [EnumMember(Value = "Upcoming")]
        Upcoming
    }
    /// <summary>
    /// The certificate type
    /// </summary>
    /// <value>The certificate type</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Client for "Client"
        /// </summary>
        [EnumMember(Value = "Client")]
        Client
    }
    /// <summary>
    /// The Signing Authority for the certificate
    /// </summary>
    /// <value>The Signing Authority for the certificate</value>
    [JsonPropertyName("signingAuthority")]
    public SigningAuthorityEnum? SigningAuthority { get; set; }
    /// <summary>
    /// The certificate status
    /// </summary>
    /// <value>The certificate status</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The certificate type
    /// </summary>
    /// <value>The certificate type</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionCertificate" /> class.
    /// </summary>
    /// <param name="SigningAuthority">The Signing Authority for the certificate.</param>
    /// <param name="Certificate">The certificate string.</param>
    /// <param name="Status">The certificate status.</param>
    /// <param name="Type">The certificate type.</param>
    public ActionCertificate(SigningAuthorityEnum? SigningAuthority = null, string Certificate = null, StatusEnum? Status = null, TypeEnum? Type = null)
    {
        this.SigningAuthority = SigningAuthority;
        this.Certificate = Certificate;
        this.Status = Status;
        this.Type = Type;

    }





    /// <summary>
    /// The certificate string
    /// </summary>
    /// <value>The certificate string</value>
    [JsonPropertyName("certificate")]
    public string Certificate { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionCertificate {\n");

        sb.Append("  SigningAuthority: ").Append(SigningAuthority).Append("\n");
        sb.Append("  Certificate: ").Append(Certificate).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as ActionCertificate);
    }

    /// <summary>
    /// Returns true if ActionCertificate instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionCertificate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionCertificate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SigningAuthority == other.SigningAuthority ||
                SigningAuthority != null &&
                SigningAuthority.Equals(other.SigningAuthority)
            ) &&
            (
                Certificate == other.Certificate ||
                Certificate != null &&
                Certificate.Equals(other.Certificate)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (SigningAuthority != null)
            {
                hash = hash * 59 + SigningAuthority.GetHashCode();
            }

            if (Certificate != null)
            {
                hash = hash * 59 + Certificate.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
