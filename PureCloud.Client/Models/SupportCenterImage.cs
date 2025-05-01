using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportCenterImage
/// </summary>
[DataContract]
public partial class SupportCenterImage : IEquatable<SupportCenterImage>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterImage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportCenterImage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterImage" /> class.
    /// </summary>
    /// <param name="Source">Source URLs for image (required).</param>
    public SupportCenterImage(SupportCenterImageSource Source = null)
    {
        this.Source = Source;

    }



    /// <summary>
    /// Source URLs for image
    /// </summary>
    /// <value>Source URLs for image</value>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public SupportCenterImageSource Source { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterImage {\n");

        sb.Append("  Source: ").Append(Source).Append("\n");
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
        return Equals(obj as SupportCenterImage);
    }

    /// <summary>
    /// Returns true if SupportCenterImage instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterImage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterImage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
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
            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            return hash;
        }
    }
}
