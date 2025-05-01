using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAppEventsNotificationAssociatedValue
/// </summary>
[DataContract]
public partial class JourneyAppEventsNotificationAssociatedValue : IEquatable<JourneyAppEventsNotificationAssociatedValue>
{
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "dataType", EmitDefaultValue = false)]
    public DataTypeEnum? DataType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationAssociatedValue" /> class.
    /// </summary>
    /// <param name="DataType">DataType.</param>
    /// <param name="Value">Value.</param>
    public JourneyAppEventsNotificationAssociatedValue(DataTypeEnum? DataType = null, double? Value = null)
    {
        this.DataType = DataType;
        this.Value = Value;

    }





    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public double? Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAppEventsNotificationAssociatedValue {\n");

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
        return this.Equals(obj as JourneyAppEventsNotificationAssociatedValue);
    }

    /// <summary>
    /// Returns true if JourneyAppEventsNotificationAssociatedValue instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAppEventsNotificationAssociatedValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAppEventsNotificationAssociatedValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.DataType == other.DataType ||
                this.DataType != null &&
                this.DataType.Equals(other.DataType)
            ) &&
            (
                this.Value == other.Value ||
                this.Value != null &&
                this.Value.Equals(other.Value)
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
            if (this.DataType != null)
            {
                hash = hash * 59 + this.DataType.GetHashCode();
            }

            if (this.Value != null)
            {
                hash = hash * 59 + this.Value.GetHashCode();
            }

            return hash;
        }
    }
}
