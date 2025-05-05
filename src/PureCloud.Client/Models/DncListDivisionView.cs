using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DncListDivisionView
/// </summary>

public partial class DncListDivisionView : IEquatable<DncListDivisionView>
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
    public DncSourceTypeEnum? DncSourceType { get; private set; }
    /// <summary>
    /// The contact method. Required if dncSourceType is rds.
    /// </summary>
    /// <value>The contact method. Required if dncSourceType is rds.</value>
    [JsonPropertyName("contactMethod")]
    public ContactMethodEnum? ContactMethod { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DncListDivisionView" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="ContactMethod">The contact method. Required if dncSourceType is rds..</param>
    public DncListDivisionView(string Name = null, Division Division = null, ContactMethodEnum? ContactMethod = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.ContactMethod = ContactMethod;

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
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public Division Division { get; set; }



    /// <summary>
    /// The status of the import process.
    /// </summary>
    /// <value>The status of the import process.</value>
    [JsonPropertyName("importStatus")]
    public ImportStatus ImportStatus { get; private set; }



    /// <summary>
    /// The number of contacts in the DncList.
    /// </summary>
    /// <value>The number of contacts in the DncList.</value>
    [JsonPropertyName("size")]
    public long? Size { get; private set; }







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
        sb.Append("class DncListDivisionView {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  DncSourceType: ").Append(DncSourceType).Append("\n");
        sb.Append("  ContactMethod: ").Append(ContactMethod).Append("\n");
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
        return Equals(obj as DncListDivisionView);
    }

    /// <summary>
    /// Returns true if DncListDivisionView instances are equal
    /// </summary>
    /// <param name="other">Instance of DncListDivisionView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DncListDivisionView other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
