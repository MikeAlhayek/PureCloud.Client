using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// StaCategory
/// </summary>
[DataContract]
public partial class StaCategory : IEquatable<StaCategory>
{
    /// <summary>
    /// The type of interaction the category will apply to
    /// </summary>
    /// <value>The type of interaction the category will apply to</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InteractionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice,

        /// <summary>
        /// Enum Digital for "Digital"
        /// </summary>
        [EnumMember(Value = "Digital")]
        Digital,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All
    }
    /// <summary>
    /// The type of interaction the category will apply to
    /// </summary>
    /// <value>The type of interaction the category will apply to</value>
    [DataMember(Name = "interactionType", EmitDefaultValue = false)]
    public InteractionTypeEnum? InteractionType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="StaCategory" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected StaCategory() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="StaCategory" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">The description of the category.</param>
    /// <param name="InteractionType">The type of interaction the category will apply to (required).</param>
    /// <param name="Criteria">A collection of conditions joined together by logical operation to provide more refined filtering of conversations (required).</param>
    /// <param name="CreatedBy">The user who created the record.</param>
    /// <param name="DateCreated">The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedBy">The user who last modified the record.</param>
    /// <param name="DateModified">The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public StaCategory(string Name = null, string Description = null, InteractionTypeEnum? InteractionType = null, Operand Criteria = null, AddressableEntityRef CreatedBy = null, DateTime? DateCreated = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.InteractionType = InteractionType;
        this.Criteria = Criteria;
        this.CreatedBy = CreatedBy;
        this.DateCreated = DateCreated;
        this.ModifiedBy = ModifiedBy;
        this.DateModified = DateModified;

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
    /// The description of the category
    /// </summary>
    /// <value>The description of the category</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }





    /// <summary>
    /// A collection of conditions joined together by logical operation to provide more refined filtering of conversations
    /// </summary>
    /// <value>A collection of conditions joined together by logical operation to provide more refined filtering of conversations</value>
    [DataMember(Name = "criteria", EmitDefaultValue = false)]
    public Operand Criteria { get; set; }



    /// <summary>
    /// The user who created the record
    /// </summary>
    /// <value>The user who created the record</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public AddressableEntityRef CreatedBy { get; set; }



    /// <summary>
    /// The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The user who last modified the record
    /// </summary>
    /// <value>The user who last modified the record</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public AddressableEntityRef ModifiedBy { get; set; }



    /// <summary>
    /// The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



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
        sb.Append("class StaCategory {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
        sb.Append("  Criteria: ").Append(Criteria).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as StaCategory);
    }

    /// <summary>
    /// Returns true if StaCategory instances are equal
    /// </summary>
    /// <param name="other">Instance of StaCategory to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StaCategory other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                InteractionType == other.InteractionType ||
                InteractionType != null &&
                InteractionType.Equals(other.InteractionType)
            ) &&
            (
                Criteria == other.Criteria ||
                Criteria != null &&
                Criteria.Equals(other.Criteria)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (InteractionType != null)
            {
                hash = hash * 59 + InteractionType.GetHashCode();
            }

            if (Criteria != null)
            {
                hash = hash * 59 + Criteria.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
