using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyVideoProperties
/// </summary>

public partial class DocumentBodyVideoProperties : IEquatable<DocumentBodyVideoProperties>
{
    /// <summary>
    /// The align type for the video.
    /// </summary>
    /// <value>The align type for the video.</value>
    
    public enum AlignEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Center for "Center"
        /// </summary>
        [EnumMember(Value = "Center")]
        Center,

        /// <summary>
        /// Enum Left for "Left"
        /// </summary>
        [EnumMember(Value = "Left")]
        Left,

        /// <summary>
        /// Enum Right for "Right"
        /// </summary>
        [EnumMember(Value = "Right")]
        Right,

        /// <summary>
        /// Enum Justify for "Justify"
        /// </summary>
        [EnumMember(Value = "Justify")]
        Justify
    }
    /// <summary>
    /// The align type for the video.
    /// </summary>
    /// <value>The align type for the video.</value>
    [JsonPropertyName("align")]
    public AlignEnum? Align { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyVideoProperties" /> class.
    /// </summary>
    /// <param name="BackgroundColor">The background color for the video. The valid values in hex color code representation. For example black color - #000000.</param>
    /// <param name="Align">The align type for the video..</param>
    /// <param name="Indentation">The indentation for the video. The valid values in &#39;em&#39;..</param>
    /// <param name="Width">The width of the video in the specified unit..</param>
    /// <param name="Height">The height of the video in the specified unit..</param>
    public DocumentBodyVideoProperties(string BackgroundColor = null, AlignEnum? Align = null, float? Indentation = null, DocumentElementLength Width = null, DocumentElementLength Height = null)
    {
        this.BackgroundColor = BackgroundColor;
        this.Align = Align;
        this.Indentation = Indentation;
        this.Width = Width;
        this.Height = Height;

    }



    /// <summary>
    /// The background color for the video. The valid values in hex color code representation. For example black color - #000000
    /// </summary>
    /// <value>The background color for the video. The valid values in hex color code representation. For example black color - #000000</value>
    [JsonPropertyName("backgroundColor")]
    public string BackgroundColor { get; set; }





    /// <summary>
    /// The indentation for the video. The valid values in &#39;em&#39;.
    /// </summary>
    /// <value>The indentation for the video. The valid values in &#39;em&#39;.</value>
    [JsonPropertyName("indentation")]
    public float? Indentation { get; set; }



    /// <summary>
    /// The width of the video in the specified unit.
    /// </summary>
    /// <value>The width of the video in the specified unit.</value>
    [JsonPropertyName("width")]
    public DocumentElementLength Width { get; set; }



    /// <summary>
    /// The height of the video in the specified unit.
    /// </summary>
    /// <value>The height of the video in the specified unit.</value>
    [JsonPropertyName("height")]
    public DocumentElementLength Height { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyVideoProperties {\n");

        sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
        sb.Append("  Align: ").Append(Align).Append("\n");
        sb.Append("  Indentation: ").Append(Indentation).Append("\n");
        sb.Append("  Width: ").Append(Width).Append("\n");
        sb.Append("  Height: ").Append(Height).Append("\n");
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
        return Equals(obj as DocumentBodyVideoProperties);
    }

    /// <summary>
    /// Returns true if DocumentBodyVideoProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyVideoProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyVideoProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BackgroundColor == other.BackgroundColor ||
                BackgroundColor != null &&
                BackgroundColor.Equals(other.BackgroundColor)
            ) &&
            (
                Align == other.Align ||
                Align != null &&
                Align.Equals(other.Align)
            ) &&
            (
                Indentation == other.Indentation ||
                Indentation != null &&
                Indentation.Equals(other.Indentation)
            ) &&
            (
                Width == other.Width ||
                Width != null &&
                Width.Equals(other.Width)
            ) &&
            (
                Height == other.Height ||
                Height != null &&
                Height.Equals(other.Height)
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
            if (BackgroundColor != null)
            {
                hash = hash * 59 + BackgroundColor.GetHashCode();
            }

            if (Align != null)
            {
                hash = hash * 59 + Align.GetHashCode();
            }

            if (Indentation != null)
            {
                hash = hash * 59 + Indentation.GetHashCode();
            }

            if (Width != null)
            {
                hash = hash * 59 + Width.GetHashCode();
            }

            if (Height != null)
            {
                hash = hash * 59 + Height.GetHashCode();
            }

            return hash;
        }
    }
}
