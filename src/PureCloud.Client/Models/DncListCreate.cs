using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DncListCreate
/// </summary>

public partial class DncListCreate : IEquatable<DncListCreate>
{
    /// <summary>
    /// The type of the DncList.
    /// </summary>
    /// <value>The type of the DncList.</value>
    
    public enum DncSourceTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Rds for "rds"
        /// </summary>
        [EnumMember(Value = "rds")]
        Rds,

        /// <summary>
        /// Enum RdsCustom for "rds_custom"
        /// </summary>
        [EnumMember(Value = "rds_custom")]
        RdsCustom,

        /// <summary>
        /// Enum Dnccom for "dnc.com"
        /// </summary>
        [EnumMember(Value = "dnc.com")]
        Dnccom,

        /// <summary>
        /// Enum Gryphon for "gryphon"
        /// </summary>
        [EnumMember(Value = "gryphon")]
        Gryphon
    }
    /// <summary>
    /// The contact method. Required if dncSourceType is rds.
    /// </summary>
    /// <value>The contact method. Required if dncSourceType is rds.</value>
    
    public enum ContactMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Phone for "Phone"
        /// </summary>
        [EnumMember(Value = "Phone")]
        Phone,

        /// <summary>
        /// Enum Any for "Any"
        /// </summary>
        [EnumMember(Value = "Any")]
        Any,

        /// <summary>
        /// Enum Whatsapp for "WhatsApp"
        /// </summary>
        [EnumMember(Value = "WhatsApp")]
        Whatsapp
    }
    /// <summary>
    /// The type of the DncList.
    /// </summary>
    /// <value>The type of the DncList.</value>
    [JsonPropertyName("dncSourceType")]
    public DncSourceTypeEnum? DncSourceType { get; set; }
    /// <summary>
    /// The contact method. Required if dncSourceType is rds.
    /// </summary>
    /// <value>The contact method. Required if dncSourceType is rds.</value>
    [JsonPropertyName("contactMethod")]
    public ContactMethodEnum? ContactMethod { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DncListCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DncListCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DncListCreate" /> class.
    /// </summary>
    /// <param name="Name">The name of the DncList. (required).</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="DncSourceType">The type of the DncList. (required).</param>
    /// <param name="ContactMethod">The contact method. Required if dncSourceType is rds..</param>
    /// <param name="LoginId">A dnc.com loginId. Required if the dncSourceType is dnc.com..</param>
    /// <param name="CampaignId">A dnc.com campaignId. Optional if the dncSourceType is dnc.com..</param>
    /// <param name="DncCodes">The list of dnc.com codes to be treated as DNC. Required if the dncSourceType is dnc.com..</param>
    /// <param name="LicenseId">A gryphon license number. Required if the dncSourceType is gryphon..</param>
    /// <param name="Division">The division this DncList belongs to..</param>
    /// <param name="CustomExclusionColumn">The column to evaluate exclusion against. Required if the dncSourceType is rds_custom..</param>
    public DncListCreate(string Name = null, int? Version = null, DncSourceTypeEnum? DncSourceType = null, ContactMethodEnum? ContactMethod = null, string LoginId = null, string CampaignId = null, List<string> DncCodes = null, string LicenseId = null, DomainEntityRef Division = null, string CustomExclusionColumn = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.DncSourceType = DncSourceType;
        this.ContactMethod = ContactMethod;
        this.LoginId = LoginId;
        this.CampaignId = CampaignId;
        this.DncCodes = DncCodes;
        this.LicenseId = LicenseId;
        this.Division = Division;
        this.CustomExclusionColumn = CustomExclusionColumn;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the DncList.
    /// </summary>
    /// <value>The name of the DncList.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The status of the import process
    /// </summary>
    /// <value>The status of the import process</value>
    [JsonPropertyName("importStatus")]
    public ImportStatus ImportStatus { get; private set; }



    /// <summary>
    /// The total number of phone numbers in the DncList.
    /// </summary>
    /// <value>The total number of phone numbers in the DncList.</value>
    [JsonPropertyName("size")]
    public long? Size { get; private set; }







    /// <summary>
    /// A dnc.com loginId. Required if the dncSourceType is dnc.com.
    /// </summary>
    /// <value>A dnc.com loginId. Required if the dncSourceType is dnc.com.</value>
    [JsonPropertyName("loginId")]
    public string LoginId { get; set; }



    /// <summary>
    /// A dnc.com campaignId. Optional if the dncSourceType is dnc.com.
    /// </summary>
    /// <value>A dnc.com campaignId. Optional if the dncSourceType is dnc.com.</value>
    [JsonPropertyName("campaignId")]
    public string CampaignId { get; set; }



    /// <summary>
    /// The list of dnc.com codes to be treated as DNC. Required if the dncSourceType is dnc.com.
    /// </summary>
    /// <value>The list of dnc.com codes to be treated as DNC. Required if the dncSourceType is dnc.com.</value>
    [JsonPropertyName("dncCodes")]
    public List<string> DncCodes { get; set; }



    /// <summary>
    /// A gryphon license number. Required if the dncSourceType is gryphon.
    /// </summary>
    /// <value>A gryphon license number. Required if the dncSourceType is gryphon.</value>
    [JsonPropertyName("licenseId")]
    public string LicenseId { get; set; }



    /// <summary>
    /// The division this DncList belongs to.
    /// </summary>
    /// <value>The division this DncList belongs to.</value>
    [JsonPropertyName("division")]
    public DomainEntityRef Division { get; set; }



    /// <summary>
    /// The column to evaluate exclusion against. Required if the dncSourceType is rds_custom.
    /// </summary>
    /// <value>The column to evaluate exclusion against. Required if the dncSourceType is rds_custom.</value>
    [JsonPropertyName("customExclusionColumn")]
    public string CustomExclusionColumn { get; set; }



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
        sb.Append("class DncListCreate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  DncSourceType: ").Append(DncSourceType).Append("\n");
        sb.Append("  ContactMethod: ").Append(ContactMethod).Append("\n");
        sb.Append("  LoginId: ").Append(LoginId).Append("\n");
        sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
        sb.Append("  DncCodes: ").Append(DncCodes).Append("\n");
        sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  CustomExclusionColumn: ").Append(CustomExclusionColumn).Append("\n");
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
        return Equals(obj as DncListCreate);
    }

    /// <summary>
    /// Returns true if DncListCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of DncListCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DncListCreate other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                ImportStatus == other.ImportStatus ||
                ImportStatus != null &&
                ImportStatus.Equals(other.ImportStatus)
            ) &&
            (
                Size == other.Size ||
                Size != null &&
                Size.Equals(other.Size)
            ) &&
            (
                DncSourceType == other.DncSourceType ||
                DncSourceType != null &&
                DncSourceType.Equals(other.DncSourceType)
            ) &&
            (
                ContactMethod == other.ContactMethod ||
                ContactMethod != null &&
                ContactMethod.Equals(other.ContactMethod)
            ) &&
            (
                LoginId == other.LoginId ||
                LoginId != null &&
                LoginId.Equals(other.LoginId)
            ) &&
            (
                CampaignId == other.CampaignId ||
                CampaignId != null &&
                CampaignId.Equals(other.CampaignId)
            ) &&
            (
                DncCodes == other.DncCodes ||
                DncCodes != null &&
                DncCodes.SequenceEqual(other.DncCodes)
            ) &&
            (
                LicenseId == other.LicenseId ||
                LicenseId != null &&
                LicenseId.Equals(other.LicenseId)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                CustomExclusionColumn == other.CustomExclusionColumn ||
                CustomExclusionColumn != null &&
                CustomExclusionColumn.Equals(other.CustomExclusionColumn)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (ImportStatus != null)
            {
                hash = hash * 59 + ImportStatus.GetHashCode();
            }

            if (Size != null)
            {
                hash = hash * 59 + Size.GetHashCode();
            }

            if (DncSourceType != null)
            {
                hash = hash * 59 + DncSourceType.GetHashCode();
            }

            if (ContactMethod != null)
            {
                hash = hash * 59 + ContactMethod.GetHashCode();
            }

            if (LoginId != null)
            {
                hash = hash * 59 + LoginId.GetHashCode();
            }

            if (CampaignId != null)
            {
                hash = hash * 59 + CampaignId.GetHashCode();
            }

            if (DncCodes != null)
            {
                hash = hash * 59 + DncCodes.GetHashCode();
            }

            if (LicenseId != null)
            {
                hash = hash * 59 + LicenseId.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (CustomExclusionColumn != null)
            {
                hash = hash * 59 + CustomExclusionColumn.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
