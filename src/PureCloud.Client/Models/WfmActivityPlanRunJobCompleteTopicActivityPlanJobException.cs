using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmActivityPlanRunJobCompleteTopicActivityPlanJobException
/// </summary>

public partial class WfmActivityPlanRunJobCompleteTopicActivityPlanJobException : IEquatable<WfmActivityPlanRunJobCompleteTopicActivityPlanJobException>
{
    /// <summary>
    /// Gets or Sets ExceptionType
    /// </summary>
    
    public enum ExceptionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unscheduledattendees for "UnscheduledAttendees"
        /// </summary>
        [EnumMember(Value = "UnscheduledAttendees")]
        Unscheduledattendees,

        /// <summary>
        /// Enum Sessionsnotdeleted for "SessionsNotDeleted"
        /// </summary>
        [EnumMember(Value = "SessionsNotDeleted")]
        Sessionsnotdeleted
    }
    /// <summary>
    /// Gets or Sets ExceptionType
    /// </summary>
    [JsonPropertyName("exceptionType")]
    public ExceptionTypeEnum? ExceptionType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmActivityPlanRunJobCompleteTopicActivityPlanJobException" /> class.
    /// </summary>
    /// <param name="ExceptionType">ExceptionType.</param>
    /// <param name="Occurrences">Occurrences.</param>
    public WfmActivityPlanRunJobCompleteTopicActivityPlanJobException(ExceptionTypeEnum? ExceptionType = null, List<WfmActivityPlanRunJobCompleteTopicActivityPlanOccurrenceReference> Occurrences = null)
    {
        this.ExceptionType = ExceptionType;
        this.Occurrences = Occurrences;

    }





    /// <summary>
    /// Gets or Sets Occurrences
    /// </summary>
    [JsonPropertyName("occurrences")]
    public List<WfmActivityPlanRunJobCompleteTopicActivityPlanOccurrenceReference> Occurrences { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmActivityPlanRunJobCompleteTopicActivityPlanJobException {\n");

        sb.Append("  ExceptionType: ").Append(ExceptionType).Append("\n");
        sb.Append("  Occurrences: ").Append(Occurrences).Append("\n");
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
        return Equals(obj as WfmActivityPlanRunJobCompleteTopicActivityPlanJobException);
    }

    /// <summary>
    /// Returns true if WfmActivityPlanRunJobCompleteTopicActivityPlanJobException instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmActivityPlanRunJobCompleteTopicActivityPlanJobException to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmActivityPlanRunJobCompleteTopicActivityPlanJobException other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExceptionType == other.ExceptionType ||
                ExceptionType != null &&
                ExceptionType.Equals(other.ExceptionType)
            ) &&
            (
                Occurrences == other.Occurrences ||
                Occurrences != null &&
                Occurrences.SequenceEqual(other.Occurrences)
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
            if (ExceptionType != null)
            {
                hash = hash * 59 + ExceptionType.GetHashCode();
            }

            if (Occurrences != null)
            {
                hash = hash * 59 + Occurrences.GetHashCode();
            }

            return hash;
        }
    }
}
