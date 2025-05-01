using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Organization
/// </summary>
[DataContract]
public partial class Organization : IEquatable<Organization>
{
    /// <summary>
    /// The current state. Examples are active, inactive, deleted.
    /// </summary>
    /// <value>The current state. Examples are active, inactive, deleted.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Inactive for "inactive"
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// Enum Deleted for "deleted"
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
    /// <summary>
    /// Organizations Originating Platform.
    /// </summary>
    /// <value>Organizations Originating Platform.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProductPlatformEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Genesyscloud for "GenesysCloud"
        /// </summary>
        [EnumMember(Value = "GenesysCloud")]
        Genesyscloud,

        /// <summary>
        /// Enum PureCloudEnvironment for "PureCloud"
        /// </summary>
        [EnumMember(Value = "PureCloud")]
        Purecloud,

        /// <summary>
        /// Enum Pureengage for "PureEngage"
        /// </summary>
        [EnumMember(Value = "PureEngage")]
        Pureengage,

        /// <summary>
        /// Enum Pureengagecloud for "PureEngageCloud"
        /// </summary>
        [EnumMember(Value = "PureEngageCloud")]
        Pureengagecloud,

        /// <summary>
        /// Enum Pureconnect for "PureConnect"
        /// </summary>
        [EnumMember(Value = "PureConnect")]
        Pureconnect,

        /// <summary>
        /// Enum Pureconnectcloud for "PureConnectCloud"
        /// </summary>
        [EnumMember(Value = "PureConnectCloud")]
        Pureconnectcloud,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The current state. Examples are active, inactive, deleted.
    /// </summary>
    /// <value>The current state. Examples are active, inactive, deleted.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Organizations Originating Platform.
    /// </summary>
    /// <value>Organizations Originating Platform.</value>
    [DataMember(Name = "productPlatform", EmitDefaultValue = false)]
    public ProductPlatformEnum? ProductPlatform { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Organization" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Organization() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Organization" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="DefaultLanguage">The default language for this organization. Example: &#39;en&#39;.</param>
    /// <param name="DefaultCountryCode">The default country code for this organization. Example: &#39;US&#39;.</param>
    /// <param name="ThirdPartyURI">ThirdPartyURI.</param>
    /// <param name="Domain">Domain.</param>
    /// <param name="Version">The current version of the organization. (required).</param>
    /// <param name="State">The current state. Examples are active, inactive, deleted..</param>
    /// <param name="DefaultSiteId">DefaultSiteId.</param>
    /// <param name="SupportURI">Email address where support tickets are sent to..</param>
    /// <param name="VoicemailEnabled">VoicemailEnabled.</param>
    public Organization(string Name = null, string DefaultLanguage = null, string DefaultCountryCode = null, string ThirdPartyURI = null, string Domain = null, int? Version = null, StateEnum? State = null, string DefaultSiteId = null, string SupportURI = null, bool? VoicemailEnabled = null)
    {
        this.Name = Name;
        this.DefaultLanguage = DefaultLanguage;
        this.DefaultCountryCode = DefaultCountryCode;
        this.ThirdPartyURI = ThirdPartyURI;
        this.Domain = Domain;
        this.Version = Version;
        this.State = State;
        this.DefaultSiteId = DefaultSiteId;
        this.SupportURI = SupportURI;
        this.VoicemailEnabled = VoicemailEnabled;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The default language for this organization. Example: &#39;en&#39;
    /// </summary>
    /// <value>The default language for this organization. Example: &#39;en&#39;</value>
    [DataMember(Name = "defaultLanguage", EmitDefaultValue = false)]
    public string DefaultLanguage { get; set; }



    /// <summary>
    /// The default country code for this organization. Example: &#39;US&#39;
    /// </summary>
    /// <value>The default country code for this organization. Example: &#39;US&#39;</value>
    [DataMember(Name = "defaultCountryCode", EmitDefaultValue = false)]
    public string DefaultCountryCode { get; set; }



    /// <summary>
    /// The short name for the organization. This field is globally unique and cannot be changed.
    /// </summary>
    /// <value>The short name for the organization. This field is globally unique and cannot be changed.</value>
    [DataMember(Name = "thirdPartyOrgName", EmitDefaultValue = false)]
    public string ThirdPartyOrgName { get; private set; }



    /// <summary>
    /// Gets or Sets ThirdPartyURI
    /// </summary>
    [DataMember(Name = "thirdPartyURI", EmitDefaultValue = false)]
    public string ThirdPartyURI { get; set; }



    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name = "domain", EmitDefaultValue = false)]
    public string Domain { get; set; }



    /// <summary>
    /// The current version of the organization.
    /// </summary>
    /// <value>The current version of the organization.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }





    /// <summary>
    /// Gets or Sets DefaultSiteId
    /// </summary>
    [DataMember(Name = "defaultSiteId", EmitDefaultValue = false)]
    public string DefaultSiteId { get; set; }



    /// <summary>
    /// Email address where support tickets are sent to.
    /// </summary>
    /// <value>Email address where support tickets are sent to.</value>
    [DataMember(Name = "supportURI", EmitDefaultValue = false)]
    public string SupportURI { get; set; }



    /// <summary>
    /// Gets or Sets VoicemailEnabled
    /// </summary>
    [DataMember(Name = "voicemailEnabled", EmitDefaultValue = false)]
    public bool? VoicemailEnabled { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }



    /// <summary>
    /// The state of features available for the organization.
    /// </summary>
    /// <value>The state of features available for the organization.</value>
    [DataMember(Name = "features", EmitDefaultValue = false)]
    public Dictionary<string, bool?> Features { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Organization {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
        sb.Append("  DefaultCountryCode: ").Append(DefaultCountryCode).Append("\n");
        sb.Append("  ThirdPartyOrgName: ").Append(ThirdPartyOrgName).Append("\n");
        sb.Append("  ThirdPartyURI: ").Append(ThirdPartyURI).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DefaultSiteId: ").Append(DefaultSiteId).Append("\n");
        sb.Append("  SupportURI: ").Append(SupportURI).Append("\n");
        sb.Append("  VoicemailEnabled: ").Append(VoicemailEnabled).Append("\n");
        sb.Append("  ProductPlatform: ").Append(ProductPlatform).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Features: ").Append(Features).Append("\n");
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
        return Equals(obj as Organization);
    }

    /// <summary>
    /// Returns true if Organization instances are equal
    /// </summary>
    /// <param name="other">Instance of Organization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Organization other)
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
                DefaultLanguage == other.DefaultLanguage ||
                DefaultLanguage != null &&
                DefaultLanguage.Equals(other.DefaultLanguage)
            ) &&
            (
                DefaultCountryCode == other.DefaultCountryCode ||
                DefaultCountryCode != null &&
                DefaultCountryCode.Equals(other.DefaultCountryCode)
            ) &&
            (
                ThirdPartyOrgName == other.ThirdPartyOrgName ||
                ThirdPartyOrgName != null &&
                ThirdPartyOrgName.Equals(other.ThirdPartyOrgName)
            ) &&
            (
                ThirdPartyURI == other.ThirdPartyURI ||
                ThirdPartyURI != null &&
                ThirdPartyURI.Equals(other.ThirdPartyURI)
            ) &&
            (
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DefaultSiteId == other.DefaultSiteId ||
                DefaultSiteId != null &&
                DefaultSiteId.Equals(other.DefaultSiteId)
            ) &&
            (
                SupportURI == other.SupportURI ||
                SupportURI != null &&
                SupportURI.Equals(other.SupportURI)
            ) &&
            (
                VoicemailEnabled == other.VoicemailEnabled ||
                VoicemailEnabled != null &&
                VoicemailEnabled.Equals(other.VoicemailEnabled)
            ) &&
            (
                ProductPlatform == other.ProductPlatform ||
                ProductPlatform != null &&
                ProductPlatform.Equals(other.ProductPlatform)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Features == other.Features ||
                Features != null &&
                Features.SequenceEqual(other.Features)
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

            if (DefaultLanguage != null)
            {
                hash = hash * 59 + DefaultLanguage.GetHashCode();
            }

            if (DefaultCountryCode != null)
            {
                hash = hash * 59 + DefaultCountryCode.GetHashCode();
            }

            if (ThirdPartyOrgName != null)
            {
                hash = hash * 59 + ThirdPartyOrgName.GetHashCode();
            }

            if (ThirdPartyURI != null)
            {
                hash = hash * 59 + ThirdPartyURI.GetHashCode();
            }

            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DefaultSiteId != null)
            {
                hash = hash * 59 + DefaultSiteId.GetHashCode();
            }

            if (SupportURI != null)
            {
                hash = hash * 59 + SupportURI.GetHashCode();
            }

            if (VoicemailEnabled != null)
            {
                hash = hash * 59 + VoicemailEnabled.GetHashCode();
            }

            if (ProductPlatform != null)
            {
                hash = hash * 59 + ProductPlatform.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Features != null)
            {
                hash = hash * 59 + Features.GetHashCode();
            }

            return hash;
        }
    }
}
