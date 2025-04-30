using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// A datetimepicker available time that a user can take.
    /// </summary>
    [DataContract]
    public partial class ConversationContentDatePickerAvailableTime :  IEquatable<ConversationContentDatePickerAvailableTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentDatePickerAvailableTime" /> class.
        /// </summary>
        /// <param name="Duration">The duration of the scheduling event in seconds..</param>
        /// <param name="DateTime">The date and time of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public ConversationContentDatePickerAvailableTime(long? Duration = null, DateTime? DateTime = null)
        {
            this.Duration = Duration;
            this.DateTime = DateTime;
            
        }
        


        /// <summary>
        /// The duration of the scheduling event in seconds.
        /// </summary>
        /// <value>The duration of the scheduling event in seconds.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public long? Duration { get; set; }



        /// <summary>
        /// The date and time of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date and time of the event being scheduled. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentDatePickerAvailableTime {\n");

            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
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
            return this.Equals(obj as ConversationContentDatePickerAvailableTime);
        }

        /// <summary>
        /// Returns true if ConversationContentDatePickerAvailableTime instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentDatePickerAvailableTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentDatePickerAvailableTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) &&
                (
                    this.DateTime == other.DateTime ||
                    this.DateTime != null &&
                    this.DateTime.Equals(other.DateTime)
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
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();

                if (this.DateTime != null)
                    hash = hash * 59 + this.DateTime.GetHashCode();

                return hash;
            }
        }
    }

}
