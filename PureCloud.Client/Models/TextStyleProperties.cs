using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TextStyleProperties
/// </summary>

public partial class TextStyleProperties : IEquatable<TextStyleProperties>
{
    /// <summary>
    /// Text alignment.
    /// </summary>
    /// <value>Text alignment.</value>
    
    public enum TextAlignEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

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
        /// Enum Center for "Center"
        /// </summary>
        [EnumMember(Value = "Center")]
        Center
    }
    /// <summary>
    /// Text alignment.
    /// </summary>
    /// <value>Text alignment.</value>
    [JsonPropertyName("textAlign")]
    public TextAlignEnum? TextAlign { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextStyleProperties" /> class.
    /// </summary>
    /// <param name="Color">Color of the text. (eg. #FFFFFF).</param>
    /// <param name="Font">Font of the text. (eg. Helvetica).</param>
    /// <param name="FontSize">Font size of the text. (eg. &#39;12&#39;).</param>
    /// <param name="TextAlign">Text alignment..</param>
    public TextStyleProperties(string Color = null, string Font = null, string FontSize = null, TextAlignEnum? TextAlign = null)
    {
        this.Color = Color;
        this.Font = Font;
        this.FontSize = FontSize;
        this.TextAlign = TextAlign;

    }



    /// <summary>
    /// Color of the text. (eg. #FFFFFF)
    /// </summary>
    /// <value>Color of the text. (eg. #FFFFFF)</value>
    [JsonPropertyName("color")]
    public string Color { get; set; }



    /// <summary>
    /// Font of the text. (eg. Helvetica)
    /// </summary>
    /// <value>Font of the text. (eg. Helvetica)</value>
    [JsonPropertyName("font")]
    public string Font { get; set; }



    /// <summary>
    /// Font size of the text. (eg. &#39;12&#39;)
    /// </summary>
    /// <value>Font size of the text. (eg. &#39;12&#39;)</value>
    [JsonPropertyName("fontSize")]
    public string FontSize { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextStyleProperties {\n");

        sb.Append("  Color: ").Append(Color).Append("\n");
        sb.Append("  Font: ").Append(Font).Append("\n");
        sb.Append("  FontSize: ").Append(FontSize).Append("\n");
        sb.Append("  TextAlign: ").Append(TextAlign).Append("\n");
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
        return Equals(obj as TextStyleProperties);
    }

    /// <summary>
    /// Returns true if TextStyleProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of TextStyleProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextStyleProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Color == other.Color ||
                Color != null &&
                Color.Equals(other.Color)
            ) &&
            (
                Font == other.Font ||
                Font != null &&
                Font.Equals(other.Font)
            ) &&
            (
                FontSize == other.FontSize ||
                FontSize != null &&
                FontSize.Equals(other.FontSize)
            ) &&
            (
                TextAlign == other.TextAlign ||
                TextAlign != null &&
                TextAlign.Equals(other.TextAlign)
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
            if (Color != null)
            {
                hash = hash * 59 + Color.GetHashCode();
            }

            if (Font != null)
            {
                hash = hash * 59 + Font.GetHashCode();
            }

            if (FontSize != null)
            {
                hash = hash * 59 + FontSize.GetHashCode();
            }

            if (TextAlign != null)
            {
                hash = hash * 59 + TextAlign.GetHashCode();
            }

            return hash;
        }
    }
}
