using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyTableProperties
/// </summary>

public partial class DocumentBodyTableProperties : IEquatable<DocumentBodyTableProperties>
{
    /// <summary>
    /// The alignment for the table.
    /// </summary>
    /// <value>The alignment for the table.</value>
    
    public enum AlignmentEnum
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
        Right
    }
    /// <summary>
    /// The border style for the table.
    /// </summary>
    /// <value>The border style for the table.</value>
    
    public enum BorderStyleEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Solid for "Solid"
        /// </summary>
        [EnumMember(Value = "Solid")]
        Solid,

        /// <summary>
        /// Enum Dotted for "Dotted"
        /// </summary>
        [EnumMember(Value = "Dotted")]
        Dotted,

        /// <summary>
        /// Enum Dashed for "Dashed"
        /// </summary>
        [EnumMember(Value = "Dashed")]
        Dashed,

        /// <summary>
        /// Enum Double for "Double"
        /// </summary>
        [EnumMember(Value = "Double")]
        Double,

        /// <summary>
        /// Enum Groove for "Groove"
        /// </summary>
        [EnumMember(Value = "Groove")]
        Groove,

        /// <summary>
        /// Enum Ridge for "Ridge"
        /// </summary>
        [EnumMember(Value = "Ridge")]
        Ridge,

        /// <summary>
        /// Enum Inset for "Inset"
        /// </summary>
        [EnumMember(Value = "Inset")]
        Inset,

        /// <summary>
        /// Enum Outset for "Outset"
        /// </summary>
        [EnumMember(Value = "Outset")]
        Outset,

        /// <summary>
        /// Enum Hidden for "Hidden"
        /// </summary>
        [EnumMember(Value = "Hidden")]
        Hidden,

        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None
    }
    /// <summary>
    /// The alignment for the table.
    /// </summary>
    /// <value>The alignment for the table.</value>
    [JsonPropertyName("alignment")]
    public AlignmentEnum? Alignment { get; set; }
    /// <summary>
    /// The border style for the table.
    /// </summary>
    /// <value>The border style for the table.</value>
    [JsonPropertyName("borderStyle")]
    public BorderStyleEnum? BorderStyle { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableProperties" /> class.
    /// </summary>
    /// <param name="Width">The width of the table converted to em unit..</param>
    /// <param name="WidthWithUnit">The width of the table in the specified unit..</param>
    /// <param name="Height">The height for the table..</param>
    /// <param name="CellSpacing">The cell spacing for the table. The valid values in &#39;em&#39;..</param>
    /// <param name="CellPadding">The cell padding for the table. The valid values in &#39;em&#39;..</param>
    /// <param name="BorderWidth">The border width for the table. The valid values in &#39;em&#39;.</param>
    /// <param name="Alignment">The alignment for the table..</param>
    /// <param name="BorderStyle">The border style for the table..</param>
    /// <param name="BorderColor">The border color for the table. The valid values in hex color code representation. For example black color - #000000.</param>
    /// <param name="BackgroundColor">The background color for the table. The valid values in hex color code representation. For example black color - #000000.</param>
    /// <param name="Caption">The caption for the table. The valid values in hex color code representation. For example black color - #000000.</param>
    public DocumentBodyTableProperties(float? Width = null, DocumentElementLength WidthWithUnit = null, float? Height = null, float? CellSpacing = null, float? CellPadding = null, float? BorderWidth = null, AlignmentEnum? Alignment = null, BorderStyleEnum? BorderStyle = null, string BorderColor = null, string BackgroundColor = null, DocumentBodyTableCaptionBlock Caption = null)
    {
        this.Width = Width;
        this.WidthWithUnit = WidthWithUnit;
        this.Height = Height;
        this.CellSpacing = CellSpacing;
        this.CellPadding = CellPadding;
        this.BorderWidth = BorderWidth;
        this.Alignment = Alignment;
        this.BorderStyle = BorderStyle;
        this.BorderColor = BorderColor;
        this.BackgroundColor = BackgroundColor;
        this.Caption = Caption;

    }



    /// <summary>
    /// The width of the table converted to em unit.
    /// </summary>
    /// <value>The width of the table converted to em unit.</value>
    [JsonPropertyName("width")]
    public float? Width { get; set; }



    /// <summary>
    /// The width of the table in the specified unit.
    /// </summary>
    /// <value>The width of the table in the specified unit.</value>
    [JsonPropertyName("widthWithUnit")]
    public DocumentElementLength WidthWithUnit { get; set; }



    /// <summary>
    /// The height for the table.
    /// </summary>
    /// <value>The height for the table.</value>
    [JsonPropertyName("height")]
    public float? Height { get; set; }



    /// <summary>
    /// The cell spacing for the table. The valid values in &#39;em&#39;.
    /// </summary>
    /// <value>The cell spacing for the table. The valid values in &#39;em&#39;.</value>
    [JsonPropertyName("cellSpacing")]
    public float? CellSpacing { get; set; }



    /// <summary>
    /// The cell padding for the table. The valid values in &#39;em&#39;.
    /// </summary>
    /// <value>The cell padding for the table. The valid values in &#39;em&#39;.</value>
    [JsonPropertyName("cellPadding")]
    public float? CellPadding { get; set; }



    /// <summary>
    /// The border width for the table. The valid values in &#39;em&#39;
    /// </summary>
    /// <value>The border width for the table. The valid values in &#39;em&#39;</value>
    [JsonPropertyName("borderWidth")]
    public float? BorderWidth { get; set; }







    /// <summary>
    /// The border color for the table. The valid values in hex color code representation. For example black color - #000000
    /// </summary>
    /// <value>The border color for the table. The valid values in hex color code representation. For example black color - #000000</value>
    [JsonPropertyName("borderColor")]
    public string BorderColor { get; set; }



    /// <summary>
    /// The background color for the table. The valid values in hex color code representation. For example black color - #000000
    /// </summary>
    /// <value>The background color for the table. The valid values in hex color code representation. For example black color - #000000</value>
    [JsonPropertyName("backgroundColor")]
    public string BackgroundColor { get; set; }



    /// <summary>
    /// The caption for the table. The valid values in hex color code representation. For example black color - #000000
    /// </summary>
    /// <value>The caption for the table. The valid values in hex color code representation. For example black color - #000000</value>
    [JsonPropertyName("caption")]
    public DocumentBodyTableCaptionBlock Caption { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyTableProperties {\n");

        sb.Append("  Width: ").Append(Width).Append("\n");
        sb.Append("  WidthWithUnit: ").Append(WidthWithUnit).Append("\n");
        sb.Append("  Height: ").Append(Height).Append("\n");
        sb.Append("  CellSpacing: ").Append(CellSpacing).Append("\n");
        sb.Append("  CellPadding: ").Append(CellPadding).Append("\n");
        sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
        sb.Append("  Alignment: ").Append(Alignment).Append("\n");
        sb.Append("  BorderStyle: ").Append(BorderStyle).Append("\n");
        sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
        sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
        sb.Append("  Caption: ").Append(Caption).Append("\n");
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
        return Equals(obj as DocumentBodyTableProperties);
    }

    /// <summary>
    /// Returns true if DocumentBodyTableProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyTableProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyTableProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Height == other.Height ||
                Height != null &&
                Height.Equals(other.Height)
            ) &&
            (
                CellSpacing == other.CellSpacing ||
                CellSpacing != null &&
                CellSpacing.Equals(other.CellSpacing)
            ) &&
            (
                CellPadding == other.CellPadding ||
                CellPadding != null &&
                CellPadding.Equals(other.CellPadding)
            ) &&
            (
                BorderWidth == other.BorderWidth ||
                BorderWidth != null &&
                BorderWidth.Equals(other.BorderWidth)
            ) &&
            (
                Alignment == other.Alignment ||
                Alignment != null &&
                Alignment.Equals(other.Alignment)
            ) &&
            (
                BorderStyle == other.BorderStyle ||
                BorderStyle != null &&
                BorderStyle.Equals(other.BorderStyle)
            ) &&
            (
                BorderColor == other.BorderColor ||
                BorderColor != null &&
                BorderColor.Equals(other.BorderColor)
            ) &&
            (
                BackgroundColor == other.BackgroundColor ||
                BackgroundColor != null &&
                BackgroundColor.Equals(other.BackgroundColor)
            ) &&
            (
                Caption == other.Caption ||
                Caption != null &&
                Caption.Equals(other.Caption)
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
            if (Width != null)
            {
                hash = hash * 59 + Width.GetHashCode();
            }

            if (WidthWithUnit != null)
            {
                hash = hash * 59 + WidthWithUnit.GetHashCode();
            }

            if (Height != null)
            {
                hash = hash * 59 + Height.GetHashCode();
            }

            if (CellSpacing != null)
            {
                hash = hash * 59 + CellSpacing.GetHashCode();
            }

            if (CellPadding != null)
            {
                hash = hash * 59 + CellPadding.GetHashCode();
            }

            if (BorderWidth != null)
            {
                hash = hash * 59 + BorderWidth.GetHashCode();
            }

            if (Alignment != null)
            {
                hash = hash * 59 + Alignment.GetHashCode();
            }

            if (BorderStyle != null)
            {
                hash = hash * 59 + BorderStyle.GetHashCode();
            }

            if (BorderColor != null)
            {
                hash = hash * 59 + BorderColor.GetHashCode();
            }

            if (BackgroundColor != null)
            {
                hash = hash * 59 + BackgroundColor.GetHashCode();
            }

            if (Caption != null)
            {
                hash = hash * 59 + Caption.GetHashCode();
            }

            return hash;
        }
    }
}
