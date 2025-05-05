using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmActivityPlanJobCompleteTopicActivityPlanJobException
/// </summary>

public partial class WfmActivityPlanJobCompleteTopicActivityPlanJobException : IEquatable<WfmActivityPlanJobCompleteTopicActivityPlanJobException>
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
    /// Initializes a new instance of the <see cref="WfmActivityPlanJobCompleteTopicActivityPlanJobException" /> class.
    /// </summary>
    /// <param name="ExceptionType">ExceptionType.</param>
    /// <param name="Occurrences">Occurrences.</param>
    public WfmActivityPlanJobCompleteTopicActivityPlanJobException(ExceptionTypeEnum? ExceptionType = null, List<WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference> Occurrences = null)
    {
        this.ExceptionType = ExceptionType;
        this.Occurrences = Occurrences;

    }





    /// <summary>
    /// Gets or Sets Occurrences
    /// </summary>
    [JsonPropertyName("occurrences")]
    public List<WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference> Occurrences { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmActivityPlanJobCompleteTopicActivityPlanJobException {\n");

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
        return Equals(obj as WfmActivityPlanJobCompleteTopicActivityPlanJobException);
    }

    /// <summary>
    /// Returns true if WfmActivityPlanJobCompleteTopicActivityPlanJobException instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmActivityPlanJobCompleteTopicActivityPlanJobException to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmActivityPlanJobCompleteTopicActivityPlanJobException other)
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
