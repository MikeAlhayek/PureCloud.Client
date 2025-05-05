using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyImageProperties
/// </summary>

public partial class DocumentBodyImageProperties : IEquatable<DocumentBodyImageProperties>
{
    /// <summary>
    /// The align property for the image.
    /// </summary>
    /// <value>The align property for the image.</value>
    
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
    /// The align property for the image.
    /// </summary>
    /// <value>The align property for the image.</value>
    [JsonPropertyName("align")]
    public AlignEnum? Align { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyImageProperties" /> class.
    /// </summary>
    /// <param name="BackgroundColor">The background color property for the image. The valid values in hex color code representation. For example black color - #000000.</param>
    /// <param name="Align">The align property for the image..</param>
    /// <param name="Indentation">The indentation property for the image. The valid values in &#39;em&#39;..</param>
    /// <param name="Width">The width of the image converted to em unit..</param>
    /// <param name="WidthWithUnit">The width of the image in the specified unit..</param>
    /// <param name="AltText">Alternate text for the image for accessibility and when the image can&#39;t be loaded..</param>
    public DocumentBodyImageProperties(string BackgroundColor = null, AlignEnum? Align = null, float? Indentation = null, float? Width = null, DocumentElementLength WidthWithUnit = null, string AltText = null)
    {
        this.BackgroundColor = BackgroundColor;
        this.Align = Align;
        this.Indentation = Indentation;
        this.Width = Width;
        this.WidthWithUnit = WidthWithUnit;
        this.AltText = AltText;

    }



    /// <summary>
    /// The background color property for the image. The valid values in hex color code representation. For example black color - #000000
    /// </summary>
    /// <value>The background color property for the image. The valid values in hex color code representation. For example black color - #000000</value>
    [JsonPropertyName("backgroundColor")]
    public string BackgroundColor { get; set; }





    /// <summary>
    /// The indentation property for the image. The valid values in &#39;em&#39;.
    /// </summary>
    /// <value>The indentation property for the image. The valid values in &#39;em&#39;.</value>
    [JsonPropertyName("indentation")]
    public float? Indentation { get; set; }



    /// <summary>
    /// The width of the image converted to em unit.
    /// </summary>
    /// <value>The width of the image converted to em unit.</value>
    [JsonPropertyName("width")]
    public float? Width { get; set; }



    /// <summary>
    /// The width of the image in the specified unit.
    /// </summary>
    /// <value>The width of the image in the specified unit.</value>
    [JsonPropertyName("widthWithUnit")]
    public DocumentElementLength WidthWithUnit { get; set; }



    /// <summary>
    /// Alternate text for the image for accessibility and when the image can&#39;t be loaded.
    /// </summary>
    /// <value>Alternate text for the image for accessibility and when the image can&#39;t be loaded.</value>
    [JsonPropertyName("altText")]
    public string AltText { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyImageProperties {\n");

        sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
        sb.Append("  Align: ").Append(Align).Append("\n");
        sb.Append("  Indentation: ").Append(Indentation).Append("\n");
        sb.Append("  Width: ").Append(Width).Append("\n");
        sb.Append("  WidthWithUnit: ").Append(WidthWithUnit).Append("\n");
        sb.Append("  AltText: ").Append(AltText).Append("\n");
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
        return Equals(obj as DocumentBodyImageProperties);
    }

    /// <summary>
    /// Returns true if DocumentBodyImageProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyImageProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyImageProperties other)
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
                WidthWithUnit == other.WidthWithUnit ||
                WidthWithUnit != null &&
                WidthWithUnit.Equals(other.WidthWithUnit)
            ) &&
            (
                AltText == other.AltText ||
                AltText != null &&
                AltText.Equals(other.AltText)
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

            if (WidthWithUnit != null)
            {
                hash = hash * 59 + WidthWithUnit.GetHashCode();
            }

            if (AltText != null)
            {
                hash = hash * 59 + AltText.GetHashCode();
            }

            return hash;
        }
    }
}
