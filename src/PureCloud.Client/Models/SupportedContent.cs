using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Supported content profile for inbound and outbound messages
/// </summary>

public partial class SupportedContent : IEquatable<SupportedContent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportedContent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportedContent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportedContent" /> class.
    /// </summary>
    /// <param name="Name">The name of the supported content profile (required).</param>
    /// <param name="MediaTypes">Defines the allowable media that may be accepted for an inbound message or to be sent in an outbound message. The following is an example of allowing all inbound media, and for outbound all images and only mpeg video: {   \&quot;mediaTypes\&quot;: {     \&quot;allow\&quot;: {       \&quot;inbound\&quot;: [{\&quot;type\&quot;: \&quot;*_/_*\&quot;}],       \&quot;outbound\&quot;: [{\&quot;type\&quot;: \&quot;image/_*\&quot;}, {\&quot;type\&quot;: \&quot;video/mpeg\&quot;}]     }   } }.</param>
    public SupportedContent(string Name = null, MediaTypes MediaTypes = null)
    {
        this.Name = Name;
        this.MediaTypes = MediaTypes;

    }



    /// <summary>
    /// A unique supported content Id.
    /// </summary>
    /// <value>A unique supported content Id.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the supported content profile
    /// </summary>
    /// <value>The name of the supported content profile</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Date this supported content profile was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this supported content profile was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Date this supported content profile was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this supported content profile was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// User reference that created this supported content profile
    /// </summary>
    /// <value>User reference that created this supported content profile</value>
    [JsonPropertyName("createdBy")]
    public DomainEntityRef CreatedBy { get; private set; }



    /// <summary>
    /// User reference that modified this supported content profile
    /// </summary>
    /// <value>User reference that modified this supported content profile</value>
    [JsonPropertyName("modifiedBy")]
    public DomainEntityRef ModifiedBy { get; private set; }



    /// <summary>
    /// Version number
    /// </summary>
    /// <value>Version number</value>
    [JsonPropertyName("version")]
    public int? Version { get; private set; }



    /// <summary>
    /// Defines the allowable media that may be accepted for an inbound message or to be sent in an outbound message. The following is an example of allowing all inbound media, and for outbound all images and only mpeg video: {   \&quot;mediaTypes\&quot;: {     \&quot;allow\&quot;: {       \&quot;inbound\&quot;: [{\&quot;type\&quot;: \&quot;*_/_*\&quot;}],       \&quot;outbound\&quot;: [{\&quot;type\&quot;: \&quot;image/_*\&quot;}, {\&quot;type\&quot;: \&quot;video/mpeg\&quot;}]     }   } }
    /// </summary>
    /// <value>Defines the allowable media that may be accepted for an inbound message or to be sent in an outbound message. The following is an example of allowing all inbound media, and for outbound all images and only mpeg video: {   \&quot;mediaTypes\&quot;: {     \&quot;allow\&quot;: {       \&quot;inbound\&quot;: [{\&quot;type\&quot;: \&quot;*_/_*\&quot;}],       \&quot;outbound\&quot;: [{\&quot;type\&quot;: \&quot;image/_*\&quot;}, {\&quot;type\&quot;: \&quot;video/mpeg\&quot;}]     }   } }</value>
    [JsonPropertyName("mediaTypes")]
    public MediaTypes MediaTypes { get; set; }



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
        sb.Append("class SupportedContent {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
        return Equals(obj as SupportedContent);
    }

    /// <summary>
    /// Returns true if SupportedContent instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportedContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportedContent other)
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
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.Equals(other.MediaTypes)
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

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
