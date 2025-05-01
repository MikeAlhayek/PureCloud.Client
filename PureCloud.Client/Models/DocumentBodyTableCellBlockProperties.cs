using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyTableCellBlockProperties
/// </summary>
[DataContract]
public partial class DocumentBodyTableCellBlockProperties : IEquatable<DocumentBodyTableCellBlockProperties>
{
    /// <summary>
    /// The type of the table cell.
    /// </summary>
    /// <value>The type of the table cell.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CellTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Cell for "Cell"
        /// </summary>
        [EnumMember(Value = "Cell")]
        Cell,

        /// <summary>
        /// Enum Headercell for "HeaderCell"
        /// </summary>
        [EnumMember(Value = "HeaderCell")]
        Headercell
    }
    /// <summary>
    /// The horizontal alignment for the table cell.
    /// </summary>
    /// <value>The horizontal alignment for the table cell.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HorizontalAlignEnum
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
    /// The vertical alignment for the table cell.
    /// </summary>
    /// <value>The vertical alignment for the table cell.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VerticalAlignEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Top for "Top"
        /// </summary>
        [EnumMember(Value = "Top")]
        Top,

        /// <summary>
        /// Enum Middle for "Middle"
        /// </summary>
        [EnumMember(Value = "Middle")]
        Middle,

        /// <summary>
        /// Enum Bottom for "Bottom"
        /// </summary>
        [EnumMember(Value = "Bottom")]
        Bottom
    }
    /// <summary>
    /// The border style for the table cell.
    /// </summary>
    /// <value>The border style for the table cell.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// The scope for the table cell.
    /// </summary>
    /// <value>The scope for the table cell.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ScopeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Row for "Row"
        /// </summary>
        [EnumMember(Value = "Row")]
        Row,

        /// <summary>
        /// Enum Column for "Column"
        /// </summary>
        [EnumMember(Value = "Column")]
        Column,

        /// <summary>
        /// Enum Rowgroup for "RowGroup"
        /// </summary>
        [EnumMember(Value = "RowGroup")]
        Rowgroup,

        /// <summary>
        /// Enum Columngroup for "ColumnGroup"
        /// </summary>
        [EnumMember(Value = "ColumnGroup")]
        Columngroup,

        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None
    }
    /// <summary>
    /// The type of the table cell.
    /// </summary>
    /// <value>The type of the table cell.</value>
    [DataMember(Name = "cellType", EmitDefaultValue = false)]
    public CellTypeEnum? CellType { get; set; }
    /// <summary>
    /// The horizontal alignment for the table cell.
    /// </summary>
    /// <value>The horizontal alignment for the table cell.</value>
    [DataMember(Name = "horizontalAlign", EmitDefaultValue = false)]
    public HorizontalAlignEnum? HorizontalAlign { get; set; }
    /// <summary>
    /// The vertical alignment for the table cell.
    /// </summary>
    /// <value>The vertical alignment for the table cell.</value>
    [DataMember(Name = "verticalAlign", EmitDefaultValue = false)]
    public VerticalAlignEnum? VerticalAlign { get; set; }
    /// <summary>
    /// The border style for the table cell.
    /// </summary>
    /// <value>The border style for the table cell.</value>
    [DataMember(Name = "borderStyle", EmitDefaultValue = false)]
    public BorderStyleEnum? BorderStyle { get; set; }
    /// <summary>
    /// The scope for the table cell.
    /// </summary>
    /// <value>The scope for the table cell.</value>
    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public ScopeEnum? Scope { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableCellBlockProperties" /> class.
    /// </summary>
    /// <param name="CellType">The type of the table cell..</param>
    /// <param name="Width">The width of the table cell converted to em unit..</param>
    /// <param name="WidthWithUnit">The width of the table cell in the specified unit..</param>
    /// <param name="Height">The height for the table cell..</param>
    /// <param name="HorizontalAlign">The horizontal alignment for the table cell..</param>
    /// <param name="VerticalAlign">The vertical alignment for the table cell..</param>
    /// <param name="BorderWidth">The border width for the table cell. The valid values in &#39;em&#39;.</param>
    /// <param name="BorderStyle">The border style for the table cell..</param>
    /// <param name="BorderColor">The border color for the table cell. For example black color - #000000.</param>
    /// <param name="BackgroundColor">The background color for the table cell. For example black color - #000000.</param>
    /// <param name="Scope">The scope for the table cell..</param>
    /// <param name="ColSpan">The colSpan for the table cell..</param>
    /// <param name="RowSpan">The rowSpan for the table cell..</param>
    public DocumentBodyTableCellBlockProperties(CellTypeEnum? CellType = null, float? Width = null, DocumentElementLength WidthWithUnit = null, float? Height = null, HorizontalAlignEnum? HorizontalAlign = null, VerticalAlignEnum? VerticalAlign = null, float? BorderWidth = null, BorderStyleEnum? BorderStyle = null, string BorderColor = null, string BackgroundColor = null, ScopeEnum? Scope = null, int? ColSpan = null, int? RowSpan = null)
    {
        this.CellType = CellType;
        this.Width = Width;
        this.WidthWithUnit = WidthWithUnit;
        this.Height = Height;
        this.HorizontalAlign = HorizontalAlign;
        this.VerticalAlign = VerticalAlign;
        this.BorderWidth = BorderWidth;
        this.BorderStyle = BorderStyle;
        this.BorderColor = BorderColor;
        this.BackgroundColor = BackgroundColor;
        this.Scope = Scope;
        this.ColSpan = ColSpan;
        this.RowSpan = RowSpan;

    }





    /// <summary>
    /// The width of the table cell converted to em unit.
    /// </summary>
    /// <value>The width of the table cell converted to em unit.</value>
    [DataMember(Name = "width", EmitDefaultValue = false)]
    public float? Width { get; set; }



    /// <summary>
    /// The width of the table cell in the specified unit.
    /// </summary>
    /// <value>The width of the table cell in the specified unit.</value>
    [DataMember(Name = "widthWithUnit", EmitDefaultValue = false)]
    public DocumentElementLength WidthWithUnit { get; set; }



    /// <summary>
    /// The height for the table cell.
    /// </summary>
    /// <value>The height for the table cell.</value>
    [DataMember(Name = "height", EmitDefaultValue = false)]
    public float? Height { get; set; }







    /// <summary>
    /// The border width for the table cell. The valid values in &#39;em&#39;
    /// </summary>
    /// <value>The border width for the table cell. The valid values in &#39;em&#39;</value>
    [DataMember(Name = "borderWidth", EmitDefaultValue = false)]
    public float? BorderWidth { get; set; }





    /// <summary>
    /// The border color for the table cell. For example black color - #000000
    /// </summary>
    /// <value>The border color for the table cell. For example black color - #000000</value>
    [DataMember(Name = "borderColor", EmitDefaultValue = false)]
    public string BorderColor { get; set; }



    /// <summary>
    /// The background color for the table cell. For example black color - #000000
    /// </summary>
    /// <value>The background color for the table cell. For example black color - #000000</value>
    [DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
    public string BackgroundColor { get; set; }





    /// <summary>
    /// The colSpan for the table cell.
    /// </summary>
    /// <value>The colSpan for the table cell.</value>
    [DataMember(Name = "colSpan", EmitDefaultValue = false)]
    public int? ColSpan { get; set; }



    /// <summary>
    /// The rowSpan for the table cell.
    /// </summary>
    /// <value>The rowSpan for the table cell.</value>
    [DataMember(Name = "rowSpan", EmitDefaultValue = false)]
    public int? RowSpan { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyTableCellBlockProperties {\n");

        sb.Append("  CellType: ").Append(CellType).Append("\n");
        sb.Append("  Width: ").Append(Width).Append("\n");
        sb.Append("  WidthWithUnit: ").Append(WidthWithUnit).Append("\n");
        sb.Append("  Height: ").Append(Height).Append("\n");
        sb.Append("  HorizontalAlign: ").Append(HorizontalAlign).Append("\n");
        sb.Append("  VerticalAlign: ").Append(VerticalAlign).Append("\n");
        sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
        sb.Append("  BorderStyle: ").Append(BorderStyle).Append("\n");
        sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
        sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
        sb.Append("  Scope: ").Append(Scope).Append("\n");
        sb.Append("  ColSpan: ").Append(ColSpan).Append("\n");
        sb.Append("  RowSpan: ").Append(RowSpan).Append("\n");
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
        return Equals(obj as DocumentBodyTableCellBlockProperties);
    }

    /// <summary>
    /// Returns true if DocumentBodyTableCellBlockProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyTableCellBlockProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyTableCellBlockProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CellType == other.CellType ||
                CellType != null &&
                CellType.Equals(other.CellType)
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
                Height == other.Height ||
                Height != null &&
                Height.Equals(other.Height)
            ) &&
            (
                HorizontalAlign == other.HorizontalAlign ||
                HorizontalAlign != null &&
                HorizontalAlign.Equals(other.HorizontalAlign)
            ) &&
            (
                VerticalAlign == other.VerticalAlign ||
                VerticalAlign != null &&
                VerticalAlign.Equals(other.VerticalAlign)
            ) &&
            (
                BorderWidth == other.BorderWidth ||
                BorderWidth != null &&
                BorderWidth.Equals(other.BorderWidth)
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
                Scope == other.Scope ||
                Scope != null &&
                Scope.Equals(other.Scope)
            ) &&
            (
                ColSpan == other.ColSpan ||
                ColSpan != null &&
                ColSpan.Equals(other.ColSpan)
            ) &&
            (
                RowSpan == other.RowSpan ||
                RowSpan != null &&
                RowSpan.Equals(other.RowSpan)
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
            if (CellType != null)
            {
                hash = hash * 59 + CellType.GetHashCode();
            }

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

            if (HorizontalAlign != null)
            {
                hash = hash * 59 + HorizontalAlign.GetHashCode();
            }

            if (VerticalAlign != null)
            {
                hash = hash * 59 + VerticalAlign.GetHashCode();
            }

            if (BorderWidth != null)
            {
                hash = hash * 59 + BorderWidth.GetHashCode();
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

            if (Scope != null)
            {
                hash = hash * 59 + Scope.GetHashCode();
            }

            if (ColSpan != null)
            {
                hash = hash * 59 + ColSpan.GetHashCode();
            }

            if (RowSpan != null)
            {
                hash = hash * 59 + RowSpan.GetHashCode();
            }

            return hash;
        }
    }
}
