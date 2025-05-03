using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PingIdentity
/// </summary>

public partial class PingIdentity : IEquatable<PingIdentity>
{
    /// <summary>
    /// Gets or Sets NameIdentifierFormat
    /// </summary>
    
    public enum NameIdentifierFormatEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum _11nameidformatunspecified for "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified")]
        _11nameidformatunspecified,

        /// <summary>
        /// Enum _11nameidformatemailaddress for "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress")]
        _11nameidformatemailaddress,

        /// <summary>
        /// Enum _11nameidformatx509subjectname for "urn:oasis:names:tc:SAML:1.1:nameid-format:X509SubjectName"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:X509SubjectName")]
        _11nameidformatx509subjectname,

        /// <summary>
        /// Enum _11nameidformatwindowsdomainqualifiedname for "urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName")]
        _11nameidformatwindowsdomainqualifiedname,

        /// <summary>
        /// Enum _20nameidformatkerberos for "urn:oasis:names:tc:SAML:2.0:nameid-format:kerberos"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:kerberos")]
        _20nameidformatkerberos,

        /// <summary>
        /// Enum _20nameidformatentity for "urn:oasis:names:tc:SAML:2.0:nameid-format:entity"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:entity")]
        _20nameidformatentity,

        /// <summary>
        /// Enum _20nameidformatpersistent for "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent")]
        _20nameidformatpersistent,

        /// <summary>
        /// Enum _20nameidformattransient for "urn:oasis:names:tc:SAML:2.0:nameid-format:transient"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:transient")]
        _20nameidformattransient
    }
    /// <summary>
    /// Gets or Sets SsoBinding
    /// </summary>
    
    public enum SsoBindingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Post for "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST")]
        Post,

        /// <summary>
        /// Enum Redirect for "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"
        /// </summary>
        [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect")]
        Redirect
    }
    /// <summary>
    /// Gets or Sets NameIdentifierFormat
    /// </summary>
    [JsonPropertyName("nameIdentifierFormat")]
    public NameIdentifierFormatEnum? NameIdentifierFormat { get; set; }
    /// <summary>
    /// Gets or Sets SsoBinding
    /// </summary>
    [JsonPropertyName("ssoBinding")]
    public SsoBindingEnum? SsoBinding { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PingIdentity" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Disabled">Disabled.</param>
    /// <param name="IssuerURI">IssuerURI.</param>
    /// <param name="SsoTargetURI">SsoTargetURI.</param>
    /// <param name="SloURI">SloURI.</param>
    /// <param name="SloBinding">SloBinding.</param>
    /// <param name="RelyingPartyIdentifier">RelyingPartyIdentifier.</param>
    /// <param name="Certificate">Certificate.</param>
    /// <param name="Certificates">Certificates.</param>
    /// <param name="LogoImageData">LogoImageData.</param>
    /// <param name="NameIdentifierFormat">NameIdentifierFormat.</param>
    /// <param name="SsoBinding">SsoBinding.</param>
    /// <param name="SignAuthnRequests">SignAuthnRequests.</param>
    /// <param name="ProviderName">ProviderName.</param>
    /// <param name="DisplayOnLogin">DisplayOnLogin.</param>
    public PingIdentity(string Name = null, bool? Disabled = null, string IssuerURI = null, string SsoTargetURI = null, string SloURI = null, string SloBinding = null, string RelyingPartyIdentifier = null, string Certificate = null, List<string> Certificates = null, string LogoImageData = null, NameIdentifierFormatEnum? NameIdentifierFormat = null, SsoBindingEnum? SsoBinding = null, bool? SignAuthnRequests = null, string ProviderName = null, bool? DisplayOnLogin = null)
    {
        this.Name = Name;
        this.Disabled = Disabled;
        this.IssuerURI = IssuerURI;
        this.SsoTargetURI = SsoTargetURI;
        this.SloURI = SloURI;
        this.SloBinding = SloBinding;
        this.RelyingPartyIdentifier = RelyingPartyIdentifier;
        this.Certificate = Certificate;
        this.Certificates = Certificates;
        this.LogoImageData = LogoImageData;
        this.NameIdentifierFormat = NameIdentifierFormat;
        this.SsoBinding = SsoBinding;
        this.SignAuthnRequests = SignAuthnRequests;
        this.ProviderName = ProviderName;
        this.DisplayOnLogin = DisplayOnLogin;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Disabled
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }



    /// <summary>
    /// Gets or Sets IssuerURI
    /// </summary>
    [JsonPropertyName("issuerURI")]
    public string IssuerURI { get; set; }



    /// <summary>
    /// Gets or Sets SsoTargetURI
    /// </summary>
    [JsonPropertyName("ssoTargetURI")]
    public string SsoTargetURI { get; set; }



    /// <summary>
    /// Gets or Sets SloURI
    /// </summary>
    [JsonPropertyName("sloURI")]
    public string SloURI { get; set; }



    /// <summary>
    /// Gets or Sets SloBinding
    /// </summary>
    [JsonPropertyName("sloBinding")]
    public string SloBinding { get; set; }



    /// <summary>
    /// Gets or Sets RelyingPartyIdentifier
    /// </summary>
    [JsonPropertyName("relyingPartyIdentifier")]
    public string RelyingPartyIdentifier { get; set; }



    /// <summary>
    /// Gets or Sets Certificate
    /// </summary>
    [JsonPropertyName("certificate")]
    public string Certificate { get; set; }



    /// <summary>
    /// Gets or Sets Certificates
    /// </summary>
    [JsonPropertyName("certificates")]
    public List<string> Certificates { get; set; }



    /// <summary>
    /// Gets or Sets LogoImageData
    /// </summary>
    [JsonPropertyName("logoImageData")]
    public string LogoImageData { get; set; }







    /// <summary>
    /// Gets or Sets SignAuthnRequests
    /// </summary>
    [JsonPropertyName("signAuthnRequests")]
    public bool? SignAuthnRequests { get; set; }



    /// <summary>
    /// Gets or Sets ProviderName
    /// </summary>
    [JsonPropertyName("providerName")]
    public string ProviderName { get; set; }



    /// <summary>
    /// Gets or Sets DisplayOnLogin
    /// </summary>
    [JsonPropertyName("displayOnLogin")]
    public bool? DisplayOnLogin { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PingIdentity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Disabled: ").Append(Disabled).Append("\n");
        sb.Append("  IssuerURI: ").Append(IssuerURI).Append("\n");
        sb.Append("  SsoTargetURI: ").Append(SsoTargetURI).Append("\n");
        sb.Append("  SloURI: ").Append(SloURI).Append("\n");
        sb.Append("  SloBinding: ").Append(SloBinding).Append("\n");
        sb.Append("  RelyingPartyIdentifier: ").Append(RelyingPartyIdentifier).Append("\n");
        sb.Append("  Certificate: ").Append(Certificate).Append("\n");
        sb.Append("  Certificates: ").Append(Certificates).Append("\n");
        sb.Append("  LogoImageData: ").Append(LogoImageData).Append("\n");
        sb.Append("  NameIdentifierFormat: ").Append(NameIdentifierFormat).Append("\n");
        sb.Append("  SsoBinding: ").Append(SsoBinding).Append("\n");
        sb.Append("  SignAuthnRequests: ").Append(SignAuthnRequests).Append("\n");
        sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
        sb.Append("  DisplayOnLogin: ").Append(DisplayOnLogin).Append("\n");
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
        return Equals(obj as PingIdentity);
    }

    /// <summary>
    /// Returns true if PingIdentity instances are equal
    /// </summary>
    /// <param name="other">Instance of PingIdentity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PingIdentity other)
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
                Disabled == other.Disabled ||
                Disabled != null &&
                Disabled.Equals(other.Disabled)
            ) &&
            (
                IssuerURI == other.IssuerURI ||
                IssuerURI != null &&
                IssuerURI.Equals(other.IssuerURI)
            ) &&
            (
                SsoTargetURI == other.SsoTargetURI ||
                SsoTargetURI != null &&
                SsoTargetURI.Equals(other.SsoTargetURI)
            ) &&
            (
                SloURI == other.SloURI ||
                SloURI != null &&
                SloURI.Equals(other.SloURI)
            ) &&
            (
                SloBinding == other.SloBinding ||
                SloBinding != null &&
                SloBinding.Equals(other.SloBinding)
            ) &&
            (
                RelyingPartyIdentifier == other.RelyingPartyIdentifier ||
                RelyingPartyIdentifier != null &&
                RelyingPartyIdentifier.Equals(other.RelyingPartyIdentifier)
            ) &&
            (
                Certificate == other.Certificate ||
                Certificate != null &&
                Certificate.Equals(other.Certificate)
            ) &&
            (
                Certificates == other.Certificates ||
                Certificates != null &&
                Certificates.SequenceEqual(other.Certificates)
            ) &&
            (
                LogoImageData == other.LogoImageData ||
                LogoImageData != null &&
                LogoImageData.Equals(other.LogoImageData)
            ) &&
            (
                NameIdentifierFormat == other.NameIdentifierFormat ||
                NameIdentifierFormat != null &&
                NameIdentifierFormat.Equals(other.NameIdentifierFormat)
            ) &&
            (
                SsoBinding == other.SsoBinding ||
                SsoBinding != null &&
                SsoBinding.Equals(other.SsoBinding)
            ) &&
            (
                SignAuthnRequests == other.SignAuthnRequests ||
                SignAuthnRequests != null &&
                SignAuthnRequests.Equals(other.SignAuthnRequests)
            ) &&
            (
                ProviderName == other.ProviderName ||
                ProviderName != null &&
                ProviderName.Equals(other.ProviderName)
            ) &&
            (
                DisplayOnLogin == other.DisplayOnLogin ||
                DisplayOnLogin != null &&
                DisplayOnLogin.Equals(other.DisplayOnLogin)
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

            if (Disabled != null)
            {
                hash = hash * 59 + Disabled.GetHashCode();
            }

            if (IssuerURI != null)
            {
                hash = hash * 59 + IssuerURI.GetHashCode();
            }

            if (SsoTargetURI != null)
            {
                hash = hash * 59 + SsoTargetURI.GetHashCode();
            }

            if (SloURI != null)
            {
                hash = hash * 59 + SloURI.GetHashCode();
            }

            if (SloBinding != null)
            {
                hash = hash * 59 + SloBinding.GetHashCode();
            }

            if (RelyingPartyIdentifier != null)
            {
                hash = hash * 59 + RelyingPartyIdentifier.GetHashCode();
            }

            if (Certificate != null)
            {
                hash = hash * 59 + Certificate.GetHashCode();
            }

            if (Certificates != null)
            {
                hash = hash * 59 + Certificates.GetHashCode();
            }

            if (LogoImageData != null)
            {
                hash = hash * 59 + LogoImageData.GetHashCode();
            }

            if (NameIdentifierFormat != null)
            {
                hash = hash * 59 + NameIdentifierFormat.GetHashCode();
            }

            if (SsoBinding != null)
            {
                hash = hash * 59 + SsoBinding.GetHashCode();
            }

            if (SignAuthnRequests != null)
            {
                hash = hash * 59 + SignAuthnRequests.GetHashCode();
            }

            if (ProviderName != null)
            {
                hash = hash * 59 + ProviderName.GetHashCode();
            }

            if (DisplayOnLogin != null)
            {
                hash = hash * 59 + DisplayOnLogin.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
