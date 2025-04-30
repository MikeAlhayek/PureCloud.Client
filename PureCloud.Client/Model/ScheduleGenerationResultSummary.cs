using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ScheduleGenerationResultSummary
    /// </summary>
    [DataContract]
    public partial class ScheduleGenerationResultSummary :  IEquatable<ScheduleGenerationResultSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleGenerationResultSummary" /> class.
        /// </summary>
        /// <param name="Failed">Whether the schedule generation run failed.</param>
        /// <param name="RunId">The ID of the schedule generation run. Reference this when requesting support.</param>
        /// <param name="MessageCount">The number of schedule generation messages for this schedule generation run.</param>
        /// <param name="MessageSeverityCounts">The list of schedule generation message counts by severity for this schedule generation run.</param>
        public ScheduleGenerationResultSummary(bool? Failed = null, string RunId = null, int? MessageCount = null, List<SchedulerMessageSeverityCount> MessageSeverityCounts = null)
        {
            this.Failed = Failed;
            this.RunId = RunId;
            this.MessageCount = MessageCount;
            this.MessageSeverityCounts = MessageSeverityCounts;
            
        }
        


        /// <summary>
        /// Whether the schedule generation run failed
        /// </summary>
        /// <value>Whether the schedule generation run failed</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public bool? Failed { get; set; }



        /// <summary>
        /// The ID of the schedule generation run. Reference this when requesting support
        /// </summary>
        /// <value>The ID of the schedule generation run. Reference this when requesting support</value>
        [DataMember(Name="runId", EmitDefaultValue=false)]
        public string RunId { get; set; }



        /// <summary>
        /// The number of schedule generation messages for this schedule generation run
        /// </summary>
        /// <value>The number of schedule generation messages for this schedule generation run</value>
        [DataMember(Name="messageCount", EmitDefaultValue=false)]
        public int? MessageCount { get; set; }



        /// <summary>
        /// The list of schedule generation message counts by severity for this schedule generation run
        /// </summary>
        /// <value>The list of schedule generation message counts by severity for this schedule generation run</value>
        [DataMember(Name="messageSeverityCounts", EmitDefaultValue=false)]
        public List<SchedulerMessageSeverityCount> MessageSeverityCounts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleGenerationResultSummary {\n");

            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  MessageSeverityCounts: ").Append(MessageSeverityCounts).Append("\n");
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
            return this.Equals(obj as ScheduleGenerationResultSummary);
        }

        /// <summary>
        /// Returns true if ScheduleGenerationResultSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleGenerationResultSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleGenerationResultSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Failed == other.Failed ||
                    this.Failed != null &&
                    this.Failed.Equals(other.Failed)
                ) &&
                (
                    this.RunId == other.RunId ||
                    this.RunId != null &&
                    this.RunId.Equals(other.RunId)
                ) &&
                (
                    this.MessageCount == other.MessageCount ||
                    this.MessageCount != null &&
                    this.MessageCount.Equals(other.MessageCount)
                ) &&
                (
                    this.MessageSeverityCounts == other.MessageSeverityCounts ||
                    this.MessageSeverityCounts != null &&
                    this.MessageSeverityCounts.SequenceEqual(other.MessageSeverityCounts)
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
                if (this.Failed != null)
                    hash = hash * 59 + this.Failed.GetHashCode();

                if (this.RunId != null)
                    hash = hash * 59 + this.RunId.GetHashCode();

                if (this.MessageCount != null)
                    hash = hash * 59 + this.MessageCount.GetHashCode();

                if (this.MessageSeverityCounts != null)
                    hash = hash * 59 + this.MessageSeverityCounts.GetHashCode();

                return hash;
            }
        }
    }

}
