using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyTableRowBlockProperties
/// </summary>
[DataContract]
public partial class DocumentBodyTableRowBlockProperties : IEquatable<DocumentBodyTableRowBlockProperties>
{
    /// <summary>
    /// The type of the table row.
    /// </summary>
    /// <value>The type of the table row.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RowTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Header for "Header"
        /// </summary>
        [EnumMember(Value = "Header")]
        Header,

        /// <summary>
        /// Enum Footer for "Footer"
        /// </summary>
        [EnumMember(Value = "Footer")]
        Footer,

        /// <summary>
        /// Enum Body for "Body"
        /// </summary>
        [EnumMember(Value = "Body")]
        Body
    }
    /// <summary>
    /// The alignment for the table row.
    /// </summary>
    /// <value>The alignment for the table row.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// The border style for the table row.
    /// </summary>
    /// <value>The border style for the table row.</value>
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
    /// The type of the table row.
    /// </summary>
    /// <value>The type of the table row.</value>
    [DataMember(Name = "rowType", EmitDefaultValue = false)]
    public RowTypeEnum? RowType { get; set; }
    /// <summary>
    /// The alignment for the table row.
    /// </summary>
    /// <value>The alignment for the table row.</value>
    [DataMember(Name = "alignment", EmitDefaultValue = false)]
    public AlignmentEnum? Alignment { get; set; }
    /// <summary>
    /// The border style for the table row.
    /// </summary>
    /// <value>The border style for the table row.</value>
    [DataMember(Name = "borderStyle", EmitDefaultValue = false)]
    public BorderStyleEnum? BorderStyle { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableRowBlockProperties" /> class.
    /// </summary>
    /// <param name="RowType">The type of the table row..</param>
    /// <param name="Alignment">The alignment for the table row..</param>
    /// <param name="Height">The height for the table row..</param>
    /// <param name="BorderStyle">The border style for the table row..</param>
    /// <param name="BorderColor">The border color for the table row. For example black color - #000000.</param>
    /// <param name="BackgroundColor">The background color for the table row. For example black color - #000000.</param>
    public DocumentBodyTableRowBlockProperties(RowTypeEnum? RowType = null, AlignmentEnum? Alignment = null, float? Height = null, BorderStyleEnum? BorderStyle = null, string BorderColor = null, string BackgroundColor = null)
    {
        this.RowType = RowType;
        this.Alignment = Alignment;
        this.Height = Height;
        this.BorderStyle = BorderStyle;
        this.BorderColor = BorderColor;
        this.BackgroundColor = BackgroundColor;

    }







    /// <summary>
    /// The height for the table row.
    /// </summary>
    /// <value>The height for the table row.</value>
    [DataMember(Name = "height", EmitDefaultValue = false)]
    public float? Height { get; set; }





    /// <summary>
    /// The border color for the table row. For example black color - #000000
    /// </summary>
    /// <value>The border color for the table row. For example black color - #000000</value>
    [DataMember(Name = "borderColor", EmitDefaultValue = false)]
    public string BorderColor { get; set; }



    /// <summary>
    /// The background color for the table row. For example black color - #000000
    /// </summary>
    /// <value>The background color for the table row. For example black color - #000000</value>
    [DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
    public string BackgroundColor { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyTableRowBlockProperties {\n");

        sb.Append("  RowType: ").Append(RowType).Append("\n");
        sb.Append("  Alignment: ").Append(Alignment).Append("\n");
        sb.Append("  Height: ").Append(Height).Append("\n");
        sb.Append("  BorderStyle: ").Append(BorderStyle).Append("\n");
        sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
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
        return Equals(obj as DocumentBodyTableRowBlockProperties);
    }

    /// <summary>
    /// Returns true if DocumentBodyTableRowBlockProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyTableRowBlockProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyTableRowBlockProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RowType == other.RowType ||
                RowType != null &&
                RowType.Equals(other.RowType)
            ) &&
            (
                Alignment == other.Alignment ||
                Alignment != null &&
                Alignment.Equals(other.Alignment)
            ) &&
            (
                Height == other.Height ||
                Height != null &&
                Height.Equals(other.Height)
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
            if (RowType != null)
            {
                hash = hash * 59 + RowType.GetHashCode();
            }

            if (Alignment != null)
            {
                hash = hash * 59 + Alignment.GetHashCode();
            }

            if (Height != null)
            {
                hash = hash * 59 + Height.GetHashCode();
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

            return hash;
        }
    }
}
