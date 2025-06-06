using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CoachingAnnotationCreateRequest
/// </summary>

public partial class CoachingAnnotationCreateRequest : IEquatable<CoachingAnnotationCreateRequest>
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
    /// Initializes a new instance of the <see cref="CoachingAnnotationCreateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CoachingAnnotationCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingAnnotationCreateRequest" /> class.
    /// </summary>
    /// <param name="Text">The text of the annotation. (required).</param>
    /// <param name="AccessType">Determines the permissions required to view this item. (required).</param>
    public CoachingAnnotationCreateRequest(string Text = null, AccessTypeEnum? AccessType = null)
    {
        this.Text = Text;
        this.AccessType = AccessType;

    }



    /// <summary>
    /// The text of the annotation.
    /// </summary>
    /// <value>The text of the annotation.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CoachingAnnotationCreateRequest {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  AccessType: ").Append(AccessType).Append("\n");
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
        return Equals(obj as CoachingAnnotationCreateRequest);
    }

    /// <summary>
    /// Returns true if CoachingAnnotationCreateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CoachingAnnotationCreateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoachingAnnotationCreateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                AccessType == other.AccessType ||
                AccessType != null &&
                AccessType.Equals(other.AccessType)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (AccessType != null)
            {
                hash = hash * 59 + AccessType.GetHashCode();
            }

            return hash;
        }
    }
}
