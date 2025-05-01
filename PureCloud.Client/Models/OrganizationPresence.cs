using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OrganizationPresence
/// </summary>
[DataContract]
public partial class OrganizationPresence : IEquatable<OrganizationPresence>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationPresence" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OrganizationPresence() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationPresence" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="LanguageLabels">The label used for the system presence in each specified language (required).</param>
    /// <param name="SystemPresence">SystemPresence.</param>
    /// <param name="Deactivated">Deactivated.</param>
    /// <param name="Primary">Primary.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public OrganizationPresence(string Name = null, Dictionary<string, string> LanguageLabels = null, string SystemPresence = null, bool? Deactivated = null, bool? Primary = null, User CreatedBy = null, DateTime? CreatedDate = null, User ModifiedBy = null, DateTime? ModifiedDate = null)
    {
        this.Name = Name;
        this.LanguageLabels = LanguageLabels;
        this.SystemPresence = SystemPresence;
        this.Deactivated = Deactivated;
        this.Primary = Primary;
        this.CreatedBy = CreatedBy;
        this.CreatedDate = CreatedDate;
        this.ModifiedBy = ModifiedBy;
        this.ModifiedDate = ModifiedDate;

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
    /// The label used for the system presence in each specified language
    /// </summary>
    /// <value>The label used for the system presence in each specified language</value>
    [DataMember(Name = "languageLabels", EmitDefaultValue = false)]
    public Dictionary<string, string> LanguageLabels { get; set; }



    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    [DataMember(Name = "systemPresence", EmitDefaultValue = false)]
    public string SystemPresence { get; set; }



    /// <summary>
    /// Gets or Sets Deactivated
    /// </summary>
    [DataMember(Name = "deactivated", EmitDefaultValue = false)]
    public bool? Deactivated { get; set; }



    /// <summary>
    /// Gets or Sets Primary
    /// </summary>
    [DataMember(Name = "primary", EmitDefaultValue = false)]
    public bool? Primary { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public User CreatedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public User ModifiedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OrganizationPresence {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  LanguageLabels: ").Append(LanguageLabels).Append("\n");
        sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
        sb.Append("  Deactivated: ").Append(Deactivated).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as OrganizationPresence);
    }

    /// <summary>
    /// Returns true if OrganizationPresence instances are equal
    /// </summary>
    /// <param name="other">Instance of OrganizationPresence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OrganizationPresence other)
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
                LanguageLabels == other.LanguageLabels ||
                LanguageLabels != null &&
                LanguageLabels.SequenceEqual(other.LanguageLabels)
            ) &&
            (
                SystemPresence == other.SystemPresence ||
                SystemPresence != null &&
                SystemPresence.Equals(other.SystemPresence)
            ) &&
            (
                Deactivated == other.Deactivated ||
                Deactivated != null &&
                Deactivated.Equals(other.Deactivated)
            ) &&
            (
                Primary == other.Primary ||
                Primary != null &&
                Primary.Equals(other.Primary)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
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

            if (LanguageLabels != null)
            {
                hash = hash * 59 + LanguageLabels.GetHashCode();
            }

            if (SystemPresence != null)
            {
                hash = hash * 59 + SystemPresence.GetHashCode();
            }

            if (Deactivated != null)
            {
                hash = hash * 59 + Deactivated.GetHashCode();
            }

            if (Primary != null)
            {
                hash = hash * 59 + Primary.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
