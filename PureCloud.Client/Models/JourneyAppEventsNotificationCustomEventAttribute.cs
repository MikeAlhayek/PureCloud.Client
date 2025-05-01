using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAppEventsNotificationCustomEventAttribute
/// </summary>
[DataContract]
public partial class JourneyAppEventsNotificationCustomEventAttribute : IEquatable<JourneyAppEventsNotificationCustomEventAttribute>
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
        /// Enum String for "STRING"
        /// </summary>
        [EnumMember(Value = "STRING")]
        String,

        /// <summary>
        /// Enum Boolean for "BOOLEAN"
        /// </summary>
        [EnumMember(Value = "BOOLEAN")]
        Boolean,

        /// <summary>
        /// Enum Number for "NUMBER"
        /// </summary>
        [EnumMember(Value = "NUMBER")]
        Number
    }
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    [DataMember(Name = "dataType", EmitDefaultValue = false)]
    public DataTypeEnum? DataType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationCustomEventAttribute" /> class.
    /// </summary>
    /// <param name="Value">Value.</param>
    /// <param name="DataType">DataType.</param>
    public JourneyAppEventsNotificationCustomEventAttribute(string Value = null, DataTypeEnum? DataType = null)
    {
        this.Value = Value;
        this.DataType = DataType;

    }



    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAppEventsNotificationCustomEventAttribute {\n");

        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  DataType: ").Append(DataType).Append("\n");
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
        return Equals(obj as JourneyAppEventsNotificationCustomEventAttribute);
    }

    /// <summary>
    /// Returns true if JourneyAppEventsNotificationCustomEventAttribute instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAppEventsNotificationCustomEventAttribute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAppEventsNotificationCustomEventAttribute other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                DataType == other.DataType ||
                DataType != null &&
                DataType.Equals(other.DataType)
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
            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (DataType != null)
            {
                hash = hash * 59 + DataType.GetHashCode();
            }

            return hash;
        }
    }
}
