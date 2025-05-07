using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DefaultGreetingList
/// </summary>

public partial class DefaultGreetingList : IEquatable<DefaultGreetingList>
{
    /// <summary>
    /// Gets or Sets OwnerType
    /// </summary>
    
    public enum OwnerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum User for "USER"
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Enum Organization for "ORGANIZATION"
        /// </summary>
        [EnumMember(Value = "ORGANIZATION")]
        Organization,

        /// <summary>
        /// Enum Group for "GROUP"
        /// </summary>
        [EnumMember(Value = "GROUP")]
        Group
    }
    /// <summary>
    /// Gets or Sets OwnerType
    /// </summary>
    [JsonPropertyName("ownerType")]
    public OwnerTypeEnum? OwnerType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DefaultGreetingList" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Owner">Owner.</param>
    /// <param name="OwnerType">OwnerType.</param>
    /// <param name="Greetings">Greetings.</param>
    /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    public DefaultGreetingList(string Name = null, GreetingOwner Owner = null, OwnerTypeEnum? OwnerType = null, Dictionary<string, Greeting> Greetings = null, DateTime? CreatedDate = null, string CreatedBy = null, DateTime? ModifiedDate = null, string ModifiedBy = null)
    {
        this.Name = Name;
        this.Owner = Owner;
        this.OwnerType = OwnerType;
        this.Greetings = Greetings;
        this.CreatedDate = CreatedDate;
        this.CreatedBy = CreatedBy;
        this.ModifiedDate = ModifiedDate;
        this.ModifiedBy = ModifiedBy;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [JsonPropertyName("owner")]
    public GreetingOwner Owner { get; set; }





    /// <summary>
    /// Gets or Sets Greetings
    /// </summary>
    [JsonPropertyName("greetings")]
    public Dictionary<string, Greeting> Greetings { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set; }



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
        sb.Append("class DefaultGreetingList {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Owner: ").Append(Owner).Append("\n");
        sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
        sb.Append("  Greetings: ").Append(Greetings).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
        return Equals(obj as DefaultGreetingList);
    }

    /// <summary>
    /// Returns true if DefaultGreetingList instances are equal
    /// </summary>
    /// <param name="other">Instance of DefaultGreetingList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DefaultGreetingList other)
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
                Owner == other.Owner ||
                Owner != null &&
                Owner.Equals(other.Owner)
            ) &&
            (
                OwnerType == other.OwnerType ||
                OwnerType != null &&
                OwnerType.Equals(other.OwnerType)
            ) &&
            (
                Greetings == other.Greetings ||
                Greetings != null &&
                Greetings.SequenceEqual(other.Greetings)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
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

            if (Owner != null)
            {
                hash = hash * 59 + Owner.GetHashCode();
            }

            if (OwnerType != null)
            {
                hash = hash * 59 + OwnerType.GetHashCode();
            }

            if (Greetings != null)
            {
                hash = hash * 59 + Greetings.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
