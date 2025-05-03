using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AvailableMediaType
/// </summary>

public partial class AvailableMediaType : IEquatable<AvailableMediaType>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AvailableMediaType" /> class.
    /// </summary>
    /// <param name="MediaType">Name of the available media type.</param>
    /// <param name="AvailableSubTypes">List of available subtypes for this media type.</param>
    public AvailableMediaType(string MediaType = null, List<string> AvailableSubTypes = null)
    {
        this.MediaType = MediaType;
        this.AvailableSubTypes = AvailableSubTypes;

    }



    /// <summary>
    /// Name of the available media type
    /// </summary>
    /// <value>Name of the available media type</value>
    [JsonPropertyName("mediaType")]
    public string MediaType { get; set; }



    /// <summary>
    /// List of available subtypes for this media type
    /// </summary>
    /// <value>List of available subtypes for this media type</value>
    [JsonPropertyName("availableSubTypes")]
    public List<string> AvailableSubTypes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AvailableMediaType {\n");

        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  AvailableSubTypes: ").Append(AvailableSubTypes).Append("\n");
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
        return Equals(obj as AvailableMediaType);
    }

    /// <summary>
    /// Returns true if AvailableMediaType instances are equal
    /// </summary>
    /// <param name="other">Instance of AvailableMediaType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AvailableMediaType other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                AvailableSubTypes == other.AvailableSubTypes ||
                AvailableSubTypes != null &&
                AvailableSubTypes.SequenceEqual(other.AvailableSubTypes)
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
            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (AvailableSubTypes != null)
            {
                hash = hash * 59 + AvailableSubTypes.GetHashCode();
            }

            return hash;
        }
    }
}
