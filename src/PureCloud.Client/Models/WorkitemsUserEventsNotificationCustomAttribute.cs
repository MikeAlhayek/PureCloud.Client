using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemsUserEventsNotificationCustomAttribute
/// </summary>

public partial class WorkitemsUserEventsNotificationCustomAttribute : IEquatable<WorkitemsUserEventsNotificationCustomAttribute>
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
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum String for "string"
        /// </summary>
        [EnumMember(Value = "string")]
        String,

        /// <summary>
        /// Enum Number for "number"
        /// </summary>
        [EnumMember(Value = "number")]
        Number,

        /// <summary>
        /// Enum Boolean for "boolean$"
        /// </summary>
        [EnumMember(Value = "boolean$")]
        Boolean,

        /// <summary>
        /// Enum Integer for "integer"
        /// </summary>
        [EnumMember(Value = "integer")]
        Integer
    }
    /// <summary>
    /// Gets or Sets DataType
    /// </summary>
    [JsonPropertyName("dataType")]
    public DataTypeEnum? DataType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemsUserEventsNotificationCustomAttribute" /> class.
    /// </summary>
    /// <param name="DataType">DataType.</param>
    /// <param name="Value">Value.</param>
    public WorkitemsUserEventsNotificationCustomAttribute(DataTypeEnum? DataType = null, string Value = null)
    {
        this.DataType = DataType;
        this.Value = Value;

    }





    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemsUserEventsNotificationCustomAttribute {\n");

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
        return Equals(obj as WorkitemsUserEventsNotificationCustomAttribute);
    }

    /// <summary>
    /// Returns true if WorkitemsUserEventsNotificationCustomAttribute instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemsUserEventsNotificationCustomAttribute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemsUserEventsNotificationCustomAttribute other)
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
