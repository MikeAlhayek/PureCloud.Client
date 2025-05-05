using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchedulerMessageSeverityCount
/// </summary>

public partial class SchedulerMessageSeverityCount : IEquatable<SchedulerMessageSeverityCount>
{
    /// <summary>
    /// The schedule message severity
    /// </summary>
    /// <value>The schedule message severity</value>
    
    public enum SeverityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ignore for "Ignore"
        /// </summary>
        [EnumMember(Value = "Ignore")]
        Ignore,

        /// <summary>
        /// Enum Information for "Information"
        /// </summary>
        [EnumMember(Value = "Information")]
        Information,

        /// <summary>
        /// Enum Warning for "Warning"
        /// </summary>
        [EnumMember(Value = "Warning")]
        Warning,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// The schedule message severity
    /// </summary>
    /// <value>The schedule message severity</value>
    [JsonPropertyName("severity")]
    public SeverityEnum? Severity { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulerMessageSeverityCount" /> class.
    /// </summary>
    /// <param name="Severity">The schedule message severity.</param>
    /// <param name="Count">The number of schedule messages with the given severity.</param>
    public SchedulerMessageSeverityCount(SeverityEnum? Severity = null, int? Count = null)
    {
        this.Severity = Severity;
        this.Count = Count;

    }





    /// <summary>
    /// The number of schedule messages with the given severity
    /// </summary>
    /// <value>The number of schedule messages with the given severity</value>
    [JsonPropertyName("count")]
    public int? Count { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SchedulerMessageSeverityCount {\n");

        sb.Append("  Severity: ").Append(Severity).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as SchedulerMessageSeverityCount);
    }

    /// <summary>
    /// Returns true if SchedulerMessageSeverityCount instances are equal
    /// </summary>
    /// <param name="other">Instance of SchedulerMessageSeverityCount to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchedulerMessageSeverityCount other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Severity == other.Severity ||
                Severity != null &&
                Severity.Equals(other.Severity)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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
            if (Severity != null)
            {
                hash = hash * 59 + Severity.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            return hash;
        }
    }
}
