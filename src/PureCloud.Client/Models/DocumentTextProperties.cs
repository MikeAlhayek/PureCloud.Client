using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentTextProperties
/// </summary>

public partial class DocumentTextProperties : IEquatable<DocumentTextProperties>
{
    /// <summary>
    /// The font size for the text. The valid values in 'em'.
    /// </summary>
    /// <value>The font size for the text. The valid values in 'em'.</value>
    
    public enum FontSizeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Xxsmall for "XxSmall"
        /// </summary>
        [EnumMember(Value = "XxSmall")]
        Xxsmall,

        /// <summary>
        /// Enum Xsmall for "XSmall"
        /// </summary>
        [EnumMember(Value = "XSmall")]
        Xsmall,

        /// <summary>
        /// Enum Small for "Small"
        /// </summary>
        [EnumMember(Value = "Small")]
        Small,

        /// <summary>
        /// Enum Medium for "Medium"
        /// </summary>
        [EnumMember(Value = "Medium")]
        Medium,

        /// <summary>
        /// Enum Large for "Large"
        /// </summary>
        [EnumMember(Value = "Large")]
        Large,

        /// <summary>
        /// Enum Xlarge for "XLarge"
        /// </summary>
        [EnumMember(Value = "XLarge")]
        Xlarge,

        /// <summary>
        /// Enum Xxlarge for "XxLarge"
        /// </summary>
        [EnumMember(Value = "XxLarge")]
        Xxlarge,

        /// <summary>
        /// Enum Xxxlarge for "XxxLarge"
        /// </summary>
        [EnumMember(Value = "XxxLarge")]
        Xxxlarge
    }
    /// <summary>
    /// The font size for the text. The valid values in 'em'.
    /// </summary>
    /// <value>The font size for the text. The valid values in 'em'.</value>
    [JsonPropertyName("fontSize")]
    public FontSizeEnum? FontSize { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentTextProperties" /> class.
    /// </summary>
    /// <param name="FontSize">The font size for the text. The valid values in &#39;em&#39;..</param>
    /// <param name="TextColor">The text color for the text. The valid values in hex color code representation. For example black color - #000000.</param>
    /// <param name="BackgroundColor">The background color for the text. The valid values in hex color code representation. For example black color - #000000.</param>
    public DocumentTextProperties(FontSizeEnum? FontSize = null, string TextColor = null, string BackgroundColor = null)
    {
        this.FontSize = FontSize;
        this.TextColor = TextColor;
        this.BackgroundColor = BackgroundColor;

    }





    /// <summary>
    /// The text color for the text. The valid values in hex color code representation. For example black color - #000000
    /// </summary>
    /// <value>The text color for the text. The valid values in hex color code representation. For example black color - #000000</value>
    [JsonPropertyName("textColor")]
    public string TextColor { get; set; }



    /// <summary>
    /// The background color for the text. The valid values in hex color code representation. For example black color - #000000
    /// </summary>
    /// <value>The background color for the text. The valid values in hex color code representation. For example black color - #000000</value>
    [JsonPropertyName("backgroundColor")]
    public string BackgroundColor { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentTextProperties {\n");

        sb.Append("  FontSize: ").Append(FontSize).Append("\n");
        sb.Append("  TextColor: ").Append(TextColor).Append("\n");
        sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
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
        return Equals(obj as DocumentTextProperties);
    }

    /// <summary>
    /// Returns true if DocumentTextProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentTextProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentTextProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FontSize == other.FontSize ||
                FontSize != null &&
                FontSize.Equals(other.FontSize)
            ) &&
            (
                TextColor == other.TextColor ||
                TextColor != null &&
                TextColor.Equals(other.TextColor)
            ) &&
            (
                BackgroundColor == other.BackgroundColor ||
                BackgroundColor != null &&
                BackgroundColor.Equals(other.BackgroundColor)
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
            if (FontSize != null)
            {
                hash = hash * 59 + FontSize.GetHashCode();
            }

            if (TextColor != null)
            {
                hash = hash * 59 + TextColor.GetHashCode();
            }

            if (BackgroundColor != null)
            {
                hash = hash * 59 + BackgroundColor.GetHashCode();
            }

            return hash;
        }
    }
}
