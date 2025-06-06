using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleUpdate
/// </summary>

public partial class BuAgentScheduleUpdate : IEquatable<BuAgentScheduleUpdate>
{
    /// <summary>
    /// The type of update
    /// </summary>
    /// <value>The type of update</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Added for "Added"
        /// </summary>
        [EnumMember(Value = "Added")]
        Added,

        /// <summary>
        /// Enum Edited for "Edited"
        /// </summary>
        [EnumMember(Value = "Edited")]
        Edited,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    /// <summary>
    /// The type of update
    /// </summary>
    /// <value>The type of update</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleUpdate" /> class.
    /// </summary>
    /// <param name="Type">The type of update.</param>
    /// <param name="ShiftStartDates">The start date for the affected shifts.</param>
    public BuAgentScheduleUpdate(TypeEnum? Type = null, List<DateTime?> ShiftStartDates = null)
    {
        this.Type = Type;
        this.ShiftStartDates = ShiftStartDates;

    }





    /// <summary>
    /// The start date for the affected shifts
    /// </summary>
    /// <value>The start date for the affected shifts</value>
    [JsonPropertyName("shiftStartDates")]
    public List<DateTime?> ShiftStartDates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleUpdate {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ShiftStartDates: ").Append(ShiftStartDates).Append("\n");
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
        return Equals(obj as BuAgentScheduleUpdate);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                ShiftStartDates == other.ShiftStartDates ||
                ShiftStartDates != null &&
                ShiftStartDates.SequenceEqual(other.ShiftStartDates)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (ShiftStartDates != null)
            {
                hash = hash * 59 + ShiftStartDates.GetHashCode();
            }

            return hash;
        }
    }
}
