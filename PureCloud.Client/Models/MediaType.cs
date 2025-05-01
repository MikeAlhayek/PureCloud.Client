using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Media type definition
/// </summary>
[DataContract]
public partial class MediaType : IEquatable<MediaType>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaType" /> class.
    /// </summary>
    /// <param name="Type">The media type string as defined by RFC 2046. You can define specific types such as &#39;image/jpeg&#39;, &#39;video/mpeg&#39;, or specify wild cards for a range of types, &#39;image/_*&#39;, or all types &#39;*_/_*&#39;. See https://www.iana.org/assignments/media-types/media-types.xhtml for a list of registered media types..</param>
    public MediaType(string Type = null)
    {
        this.Type = Type;

    }



    /// <summary>
    /// The media type string as defined by RFC 2046. You can define specific types such as &#39;image/jpeg&#39;, &#39;video/mpeg&#39;, or specify wild cards for a range of types, &#39;image/_*&#39;, or all types &#39;*_/_*&#39;. See https://www.iana.org/assignments/media-types/media-types.xhtml for a list of registered media types.
    /// </summary>
    /// <value>The media type string as defined by RFC 2046. You can define specific types such as &#39;image/jpeg&#39;, &#39;video/mpeg&#39;, or specify wild cards for a range of types, &#39;image/_*&#39;, or all types &#39;*_/_*&#39;. See https://www.iana.org/assignments/media-types/media-types.xhtml for a list of registered media types.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaType {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as MediaType);
    }

    /// <summary>
    /// Returns true if MediaType instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaType other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
