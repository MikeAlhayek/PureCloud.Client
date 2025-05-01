using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings concerning position
/// </summary>
[DataContract]
public partial class PositionSettings : IEquatable<PositionSettings>
{
    /// <summary>
    /// The alignment for position
    /// </summary>
    /// <value>The alignment for position</value>
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
        /// Enum Auto for "Auto"
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto,

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
    /// The alignment for position
    /// </summary>
    /// <value>The alignment for position</value>
    [DataMember(Name = "alignment", EmitDefaultValue = false)]
    public AlignmentEnum? Alignment { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PositionSettings" /> class.
    /// </summary>
    /// <param name="Alignment">The alignment for position.</param>
    /// <param name="SideSpace">The sidespace value for position.</param>
    /// <param name="BottomSpace">The bottomspace value for position.</param>
    public PositionSettings(AlignmentEnum? Alignment = null, int? SideSpace = null, int? BottomSpace = null)
    {
        this.Alignment = Alignment;
        this.SideSpace = SideSpace;
        this.BottomSpace = BottomSpace;

    }





    /// <summary>
    /// The sidespace value for position
    /// </summary>
    /// <value>The sidespace value for position</value>
    [DataMember(Name = "sideSpace", EmitDefaultValue = false)]
    public int? SideSpace { get; set; }



    /// <summary>
    /// The bottomspace value for position
    /// </summary>
    /// <value>The bottomspace value for position</value>
    [DataMember(Name = "bottomSpace", EmitDefaultValue = false)]
    public int? BottomSpace { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PositionSettings {\n");

        sb.Append("  Alignment: ").Append(Alignment).Append("\n");
        sb.Append("  SideSpace: ").Append(SideSpace).Append("\n");
        sb.Append("  BottomSpace: ").Append(BottomSpace).Append("\n");
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
        return Equals(obj as PositionSettings);
    }

    /// <summary>
    /// Returns true if PositionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of PositionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PositionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Alignment == other.Alignment ||
                Alignment != null &&
                Alignment.Equals(other.Alignment)
            ) &&
            (
                SideSpace == other.SideSpace ||
                SideSpace != null &&
                SideSpace.Equals(other.SideSpace)
            ) &&
            (
                BottomSpace == other.BottomSpace ||
                BottomSpace != null &&
                BottomSpace.Equals(other.BottomSpace)
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
            if (Alignment != null)
            {
                hash = hash * 59 + Alignment.GetHashCode();
            }

            if (SideSpace != null)
            {
                hash = hash * 59 + SideSpace.GetHashCode();
            }

            if (BottomSpace != null)
            {
                hash = hash * 59 + BottomSpace.GetHashCode();
            }

            return hash;
        }
    }
}
