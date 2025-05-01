using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentThumbnail
/// </summary>
[DataContract]
public partial class DocumentThumbnail : IEquatable<DocumentThumbnail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentThumbnail" /> class.
    /// </summary>
    /// <param name="Resolution">Resolution.</param>
    /// <param name="ImageUri">ImageUri.</param>
    /// <param name="Height">Height.</param>
    /// <param name="Width">Width.</param>
    public DocumentThumbnail(string Resolution = null, string ImageUri = null, int? Height = null, int? Width = null)
    {
        this.Resolution = Resolution;
        this.ImageUri = ImageUri;
        this.Height = Height;
        this.Width = Width;

    }



    /// <summary>
    /// Gets or Sets Resolution
    /// </summary>
    [DataMember(Name = "resolution", EmitDefaultValue = false)]
    public string Resolution { get; set; }



    /// <summary>
    /// Gets or Sets ImageUri
    /// </summary>
    [DataMember(Name = "imageUri", EmitDefaultValue = false)]
    public string ImageUri { get; set; }



    /// <summary>
    /// Gets or Sets Height
    /// </summary>
    [DataMember(Name = "height", EmitDefaultValue = false)]
    public int? Height { get; set; }



    /// <summary>
    /// Gets or Sets Width
    /// </summary>
    [DataMember(Name = "width", EmitDefaultValue = false)]
    public int? Width { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentThumbnail {\n");

        sb.Append("  Resolution: ").Append(Resolution).Append("\n");
        sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
        sb.Append("  Height: ").Append(Height).Append("\n");
        sb.Append("  Width: ").Append(Width).Append("\n");
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
        return Equals(obj as DocumentThumbnail);
    }

    /// <summary>
    /// Returns true if DocumentThumbnail instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentThumbnail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentThumbnail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Resolution == other.Resolution ||
                Resolution != null &&
                Resolution.Equals(other.Resolution)
            ) &&
            (
                ImageUri == other.ImageUri ||
                ImageUri != null &&
                ImageUri.Equals(other.ImageUri)
            ) &&
            (
                Height == other.Height ||
                Height != null &&
                Height.Equals(other.Height)
            ) &&
            (
                Width == other.Width ||
                Width != null &&
                Width.Equals(other.Width)
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
            if (Resolution != null)
            {
                hash = hash * 59 + Resolution.GetHashCode();
            }

            if (ImageUri != null)
            {
                hash = hash * 59 + ImageUri.GetHashCode();
            }

            if (Height != null)
            {
                hash = hash * 59 + Height.GetHashCode();
            }

            if (Width != null)
            {
                hash = hash * 59 + Width.GetHashCode();
            }

            return hash;
        }
    }
}
