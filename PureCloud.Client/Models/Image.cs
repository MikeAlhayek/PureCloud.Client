using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Image
/// </summary>
[DataContract]
public partial class Image : IEquatable<Image>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Image" /> class.
    /// </summary>
    /// <param name="Resolution">Height and/or width of image. ex: 640x480 or x128.</param>
    /// <param name="ImageUri">ImageUri.</param>
    public Image(string Resolution = null, string ImageUri = null)
    {
        this.Resolution = Resolution;
        this.ImageUri = ImageUri;

    }



    /// <summary>
    /// Height and/or width of image. ex: 640x480 or x128
    /// </summary>
    /// <value>Height and/or width of image. ex: 640x480 or x128</value>
    [DataMember(Name = "resolution", EmitDefaultValue = false)]
    public string Resolution { get; set; }



    /// <summary>
    /// Gets or Sets ImageUri
    /// </summary>
    [DataMember(Name = "imageUri", EmitDefaultValue = false)]
    public string ImageUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Image {\n");

        sb.Append("  Resolution: ").Append(Resolution).Append("\n");
        sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
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
        return Equals(obj as Image);
    }

    /// <summary>
    /// Returns true if Image instances are equal
    /// </summary>
    /// <param name="other">Instance of Image to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Image other)
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

            return hash;
        }
    }
}
