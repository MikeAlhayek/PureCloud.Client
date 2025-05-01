using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OperandPosition
/// </summary>
[DataContract]
public partial class OperandPosition : IEquatable<OperandPosition>
{
    /// <summary>
    /// Dictates starting position directionality
    /// </summary>
    /// <value>Dictates starting position directionality</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StartingPositionDirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Fromstart for "FromStart"
        /// </summary>
        [EnumMember(Value = "FromStart")]
        Fromstart,

        /// <summary>
        /// Enum Fromend for "FromEnd"
        /// </summary>
        [EnumMember(Value = "FromEnd")]
        Fromend
    }
    /// <summary>
    /// Dictates ending position directionality
    /// </summary>
    /// <value>Dictates ending position directionality</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EndingPositionDirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Fromstart for "FromStart"
        /// </summary>
        [EnumMember(Value = "FromStart")]
        Fromstart,

        /// <summary>
        /// Enum Fromend for "FromEnd"
        /// </summary>
        [EnumMember(Value = "FromEnd")]
        Fromend
    }
    /// <summary>
    /// Dictates starting position directionality
    /// </summary>
    /// <value>Dictates starting position directionality</value>
    [DataMember(Name = "startingPositionDirection", EmitDefaultValue = false)]
    public StartingPositionDirectionEnum? StartingPositionDirection { get; set; }
    /// <summary>
    /// Dictates ending position directionality
    /// </summary>
    /// <value>Dictates ending position directionality</value>
    [DataMember(Name = "endingPositionDirection", EmitDefaultValue = false)]
    public EndingPositionDirectionEnum? EndingPositionDirection { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OperandPosition" /> class.
    /// </summary>
    /// <param name="StartingPositionValue">Defines starting point of a position range - number of seconds or words from the start or from the end of the interaction.</param>
    /// <param name="StartingPositionDirection">Dictates starting position directionality.</param>
    /// <param name="EndingPositionValue">Defines ending point of a position range - number of seconds or words from the start or from the end of the interaction.</param>
    /// <param name="EndingPositionDirection">Dictates ending position directionality.</param>
    public OperandPosition(int? StartingPositionValue = null, StartingPositionDirectionEnum? StartingPositionDirection = null, int? EndingPositionValue = null, EndingPositionDirectionEnum? EndingPositionDirection = null)
    {
        this.StartingPositionValue = StartingPositionValue;
        this.StartingPositionDirection = StartingPositionDirection;
        this.EndingPositionValue = EndingPositionValue;
        this.EndingPositionDirection = EndingPositionDirection;

    }



    /// <summary>
    /// Defines starting point of a position range - number of seconds or words from the start or from the end of the interaction
    /// </summary>
    /// <value>Defines starting point of a position range - number of seconds or words from the start or from the end of the interaction</value>
    [DataMember(Name = "startingPositionValue", EmitDefaultValue = false)]
    public int? StartingPositionValue { get; set; }





    /// <summary>
    /// Defines ending point of a position range - number of seconds or words from the start or from the end of the interaction
    /// </summary>
    /// <value>Defines ending point of a position range - number of seconds or words from the start or from the end of the interaction</value>
    [DataMember(Name = "endingPositionValue", EmitDefaultValue = false)]
    public int? EndingPositionValue { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OperandPosition {\n");

        sb.Append("  StartingPositionValue: ").Append(StartingPositionValue).Append("\n");
        sb.Append("  StartingPositionDirection: ").Append(StartingPositionDirection).Append("\n");
        sb.Append("  EndingPositionValue: ").Append(EndingPositionValue).Append("\n");
        sb.Append("  EndingPositionDirection: ").Append(EndingPositionDirection).Append("\n");
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
        return Equals(obj as OperandPosition);
    }

    /// <summary>
    /// Returns true if OperandPosition instances are equal
    /// </summary>
    /// <param name="other">Instance of OperandPosition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OperandPosition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartingPositionValue == other.StartingPositionValue ||
                StartingPositionValue != null &&
                StartingPositionValue.Equals(other.StartingPositionValue)
            ) &&
            (
                StartingPositionDirection == other.StartingPositionDirection ||
                StartingPositionDirection != null &&
                StartingPositionDirection.Equals(other.StartingPositionDirection)
            ) &&
            (
                EndingPositionValue == other.EndingPositionValue ||
                EndingPositionValue != null &&
                EndingPositionValue.Equals(other.EndingPositionValue)
            ) &&
            (
                EndingPositionDirection == other.EndingPositionDirection ||
                EndingPositionDirection != null &&
                EndingPositionDirection.Equals(other.EndingPositionDirection)
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
            if (StartingPositionValue != null)
            {
                hash = hash * 59 + StartingPositionValue.GetHashCode();
            }

            if (StartingPositionDirection != null)
            {
                hash = hash * 59 + StartingPositionDirection.GetHashCode();
            }

            if (EndingPositionValue != null)
            {
                hash = hash * 59 + EndingPositionValue.GetHashCode();
            }

            if (EndingPositionDirection != null)
            {
                hash = hash * 59 + EndingPositionDirection.GetHashCode();
            }

            return hash;
        }
    }
}
