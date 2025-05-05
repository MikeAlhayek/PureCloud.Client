using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyWebEventsNotificationAssociatedValue
/// </summary>

public partial class JourneyWebEventsNotificationAssociatedValue : IEquatable<JourneyWebEventsNotificationAssociatedValue>
{
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    
    public enum DataTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Number for "Number"
        /// </summary>
        [EnumMember(Value = "Number")]
        Number,

        /// <summary>
        /// Enum Integer for "Integer"
        /// </summary>
        [EnumMember(Value = "Integer")]
        Integer
    }
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    [JsonPropertyName("dataType")]
    public DataTypeEnum? DataType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationAssociatedValue" /> class.
    /// </summary>
    /// <param name="DataType">DataType.</param>
    /// <param name="Value">Value.</param>
    public JourneyWebEventsNotificationAssociatedValue(DataTypeEnum? DataType = null, double? Value = null)
    {
        this.DataType = DataType;
        this.Value = Value;

    }





    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebEventsNotificationAssociatedValue {\n");

        sb.Append("  DataType: ").Append(DataType).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as JourneyWebEventsNotificationAssociatedValue);
    }

    /// <summary>
    /// Returns true if JourneyWebEventsNotificationAssociatedValue instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebEventsNotificationAssociatedValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebEventsNotificationAssociatedValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DataType == other.DataType ||
                DataType != null &&
                DataType.Equals(other.DataType)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (DataType != null)
            {
                hash = hash * 59 + DataType.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
