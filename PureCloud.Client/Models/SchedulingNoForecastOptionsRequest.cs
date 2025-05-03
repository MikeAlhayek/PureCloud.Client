using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchedulingNoForecastOptionsRequest
/// </summary>

public partial class SchedulingNoForecastOptionsRequest : IEquatable<SchedulingNoForecastOptionsRequest>
{
    /// <summary>
    /// The shift length option to apply if no forecast is supplied
    /// </summary>
    /// <value>The shift length option to apply if no forecast is supplied</value>
    
    public enum ShiftLengthEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Shortest for "Shortest"
        /// </summary>
        [EnumMember(Value = "Shortest")]
        Shortest,

        /// <summary>
        /// Enum Median for "Median"
        /// </summary>
        [EnumMember(Value = "Median")]
        Median,

        /// <summary>
        /// Enum Longest for "Longest"
        /// </summary>
        [EnumMember(Value = "Longest")]
        Longest,

        /// <summary>
        /// Enum Random for "Random"
        /// </summary>
        [EnumMember(Value = "Random")]
        Random
    }
    /// <summary>
    /// The shift start option to apply if no forecast is supplied
    /// </summary>
    /// <value>The shift start option to apply if no forecast is supplied</value>
    
    public enum ShiftStartEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Earliest for "Earliest"
        /// </summary>
        [EnumMember(Value = "Earliest")]
        Earliest,

        /// <summary>
        /// Enum Median for "Median"
        /// </summary>
        [EnumMember(Value = "Median")]
        Median,

        /// <summary>
        /// Enum Latest for "Latest"
        /// </summary>
        [EnumMember(Value = "Latest")]
        Latest,

        /// <summary>
        /// Enum Random for "Random"
        /// </summary>
        [EnumMember(Value = "Random")]
        Random
    }
    /// <summary>
    /// The shift length option to apply if no forecast is supplied
    /// </summary>
    /// <value>The shift length option to apply if no forecast is supplied</value>
    [JsonPropertyName("shiftLength")]
    public ShiftLengthEnum? ShiftLength { get; set; }
    /// <summary>
    /// The shift start option to apply if no forecast is supplied
    /// </summary>
    /// <value>The shift start option to apply if no forecast is supplied</value>
    [JsonPropertyName("shiftStart")]
    public ShiftStartEnum? ShiftStart { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulingNoForecastOptionsRequest" /> class.
    /// </summary>
    /// <param name="ShiftLength">The shift length option to apply if no forecast is supplied.</param>
    /// <param name="ShiftStart">The shift start option to apply if no forecast is supplied.</param>
    public SchedulingNoForecastOptionsRequest(ShiftLengthEnum? ShiftLength = null, ShiftStartEnum? ShiftStart = null)
    {
        this.ShiftLength = ShiftLength;
        this.ShiftStart = ShiftStart;

    }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SchedulingNoForecastOptionsRequest {\n");

        sb.Append("  ShiftLength: ").Append(ShiftLength).Append("\n");
        sb.Append("  ShiftStart: ").Append(ShiftStart).Append("\n");
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
        return Equals(obj as SchedulingNoForecastOptionsRequest);
    }

    /// <summary>
    /// Returns true if SchedulingNoForecastOptionsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SchedulingNoForecastOptionsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchedulingNoForecastOptionsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ShiftLength == other.ShiftLength ||
                ShiftLength != null &&
                ShiftLength.Equals(other.ShiftLength)
            ) &&
            (
                ShiftStart == other.ShiftStart ||
                ShiftStart != null &&
                ShiftStart.Equals(other.ShiftStart)
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
            if (ShiftLength != null)
            {
                hash = hash * 59 + ShiftLength.GetHashCode();
            }

            if (ShiftStart != null)
            {
                hash = hash * 59 + ShiftStart.GetHashCode();
            }

            return hash;
        }
    }
}
