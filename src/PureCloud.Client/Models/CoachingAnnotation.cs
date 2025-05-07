using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CoachingAnnotation
/// </summary>

public partial class CoachingAnnotation : IEquatable<CoachingAnnotation>
{
    /// <summary>
    /// Determines the permissions required to view this item.
    /// </summary>
    /// <value>Determines the permissions required to view this item.</value>
    
    public enum AccessTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Public for "Public"
        /// </summary>
        [EnumMember(Value = "Public")]
        Public,

        /// <summary>
        /// Enum Private for "Private"
        /// </summary>
        [EnumMember(Value = "Private")]
        Private
    }
    /// <summary>
    /// Determines the permissions required to view this item.
    /// </summary>
    /// <value>Determines the permissions required to view this item.</value>
    [JsonPropertyName("accessType")]
    public AccessTypeEnum? AccessType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingAnnotation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CoachingAnnotation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingAnnotation" /> class.
    /// </summary>
    /// <param name="Text">The text of the annotation. (required).</param>
    public CoachingAnnotation(string Text = null)
    {
        this.Text = Text;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The user who created the annotation.
    /// </summary>
    /// <value>The user who created the annotation.</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The date/time the annotation was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the annotation was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The last user to modify the annotation.
    /// </summary>
    /// <value>The last user to modify the annotation.</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The date/time the annotation was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the annotation was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The text of the annotation.
    /// </summary>
    /// <value>The text of the annotation.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Flag indicating whether the annotation is deleted.
    /// </summary>
    /// <value>Flag indicating whether the annotation is deleted.</value>
    [JsonPropertyName("isDeleted")]
    public bool? IsDeleted { get; set; }





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
        sb.Append("class CoachingAnnotation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
        sb.Append("  AccessType: ").Append(AccessType).Append("\n");
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
        return Equals(obj as CoachingAnnotation);
    }

    /// <summary>
    /// Returns true if CoachingAnnotation instances are equal
    /// </summary>
    /// <param name="other">Instance of CoachingAnnotation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoachingAnnotation other)
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
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                IsDeleted == other.IsDeleted ||
                IsDeleted != null &&
                IsDeleted.Equals(other.IsDeleted)
            ) &&
            (
                AccessType == other.AccessType ||
                AccessType != null &&
                AccessType.Equals(other.AccessType)
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

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (IsDeleted != null)
            {
                hash = hash * 59 + IsDeleted.GetHashCode();
            }

            if (AccessType != null)
            {
                hash = hash * 59 + AccessType.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
