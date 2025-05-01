using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerDnclistConfigChangeDncList
/// </summary>
[DataContract]
public partial class DialerDnclistConfigChangeDncList : IEquatable<DialerDnclistConfigChangeDncList>
{
    /// <summary>
    /// the type of dnc list being created, rds (csv file), gryphon, or dnc.com
    /// </summary>
    /// <value>the type of dnc list being created, rds (csv file), gryphon, or dnc.com</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Gets or Sets ContactMethod
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Phone for "PHONE"
        /// </summary>
        [EnumMember(Value = "PHONE")]
        Phone
    }
    /// <summary>
    /// the type of dnc list being created, rds (csv file), gryphon, or dnc.com
    /// </summary>
    /// <value>the type of dnc list being created, rds (csv file), gryphon, or dnc.com</value>
    [DataMember(Name = "dncSourceType", EmitDefaultValue = false)]
    public DncSourceTypeEnum? DncSourceType { get; set; }
    /// <summary>
    /// Gets or Sets ContactMethod
    /// </summary>
    [DataMember(Name = "contactMethod", EmitDefaultValue = false)]
    public ContactMethodEnum? ContactMethod { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerDnclistConfigChangeDncList" /> class.
    /// </summary>
    /// <param name="ImportStatus">ImportStatus.</param>
    /// <param name="Size">the number of phone numbers in the do not call list.</param>
    /// <param name="DncSourceType">the type of dnc list being created, rds (csv file), gryphon, or dnc.com.</param>
    /// <param name="LoginId">the loginId if the dncSourceType is dnc.com.</param>
    /// <param name="DncCodes">the list of dnc.com codes to be treated as DNC.</param>
    /// <param name="LicenseId">the license number if the dncSourceType is gryphon.</param>
    /// <param name="ContactMethod">ContactMethod.</param>
    /// <param name="Division">Division.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerDnclistConfigChangeDncList(DialerDnclistConfigChangeImportStatus ImportStatus = null, long? Size = null, DncSourceTypeEnum? DncSourceType = null, string LoginId = null, List<string> DncCodes = null, string LicenseId = null, ContactMethodEnum? ContactMethod = null, DialerDnclistConfigChangeUriReference Division = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
        this.ImportStatus = ImportStatus;
        this.Size = Size;
        this.DncSourceType = DncSourceType;
        this.LoginId = LoginId;
        this.DncCodes = DncCodes;
        this.LicenseId = LicenseId;
        this.ContactMethod = ContactMethod;
        this.Division = Division;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets ImportStatus
    /// </summary>
    [DataMember(Name = "importStatus", EmitDefaultValue = false)]
    public DialerDnclistConfigChangeImportStatus ImportStatus { get; set; }



    /// <summary>
    /// the number of phone numbers in the do not call list
    /// </summary>
    /// <value>the number of phone numbers in the do not call list</value>
    [DataMember(Name = "size", EmitDefaultValue = false)]
    public long? Size { get; set; }





    /// <summary>
    /// the loginId if the dncSourceType is dnc.com
    /// </summary>
    /// <value>the loginId if the dncSourceType is dnc.com</value>
    [DataMember(Name = "loginId", EmitDefaultValue = false)]
    public string LoginId { get; set; }



    /// <summary>
    /// the list of dnc.com codes to be treated as DNC
    /// </summary>
    /// <value>the list of dnc.com codes to be treated as DNC</value>
    [DataMember(Name = "dncCodes", EmitDefaultValue = false)]
    public List<string> DncCodes { get; set; }



    /// <summary>
    /// the license number if the dncSourceType is gryphon
    /// </summary>
    /// <value>the license number if the dncSourceType is gryphon</value>
    [DataMember(Name = "licenseId", EmitDefaultValue = false)]
    public string LicenseId { get; set; }





    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public DialerDnclistConfigChangeUriReference Division { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerDnclistConfigChangeDncList {\n");

        sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  DncSourceType: ").Append(DncSourceType).Append("\n");
        sb.Append("  LoginId: ").Append(LoginId).Append("\n");
        sb.Append("  DncCodes: ").Append(DncCodes).Append("\n");
        sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
        sb.Append("  ContactMethod: ").Append(ContactMethod).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerDnclistConfigChangeDncList);
    }

    /// <summary>
    /// Returns true if DialerDnclistConfigChangeDncList instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerDnclistConfigChangeDncList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerDnclistConfigChangeDncList other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                LoginId == other.LoginId ||
                LoginId != null &&
                LoginId.Equals(other.LoginId)
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
                ContactMethod == other.ContactMethod ||
                ContactMethod != null &&
                ContactMethod.Equals(other.ContactMethod)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
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

            if (LoginId != null)
            {
                hash = hash * 59 + LoginId.GetHashCode();
            }

            if (DncCodes != null)
            {
                hash = hash * 59 + DncCodes.GetHashCode();
            }

            if (LicenseId != null)
            {
                hash = hash * 59 + LicenseId.GetHashCode();
            }

            if (ContactMethod != null)
            {
                hash = hash * 59 + ContactMethod.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

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

            return hash;
        }
    }
}
