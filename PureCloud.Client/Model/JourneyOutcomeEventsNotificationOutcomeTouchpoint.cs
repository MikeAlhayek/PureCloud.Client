using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// JourneyOutcomeEventsNotificationOutcomeTouchpoint
    /// </summary>
    [DataContract]
    public partial class JourneyOutcomeEventsNotificationOutcomeTouchpoint :  IEquatable<JourneyOutcomeEventsNotificationOutcomeTouchpoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationOutcomeTouchpoint" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Channels">Channels.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="ActionMap">ActionMap.</param>
        public JourneyOutcomeEventsNotificationOutcomeTouchpoint(string Id = null, List<JourneyOutcomeEventsNotificationOutcomeTouchpointChannel> Channels = null, DateTime? CreatedDate = null, JourneyOutcomeEventsNotificationActionMap ActionMap = null)
        {
            this.Id = Id;
            this.Channels = Channels;
            this.CreatedDate = CreatedDate;
            this.ActionMap = ActionMap;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public List<JourneyOutcomeEventsNotificationOutcomeTouchpointChannel> Channels { get; set; }



        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }



        /// <summary>
        /// Gets or Sets ActionMap
        /// </summary>
        [DataMember(Name="actionMap", EmitDefaultValue=false)]
        public JourneyOutcomeEventsNotificationActionMap ActionMap { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyOutcomeEventsNotificationOutcomeTouchpoint {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
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
            return this.Equals(obj as JourneyOutcomeEventsNotificationOutcomeTouchpoint);
        }

        /// <summary>
        /// Returns true if JourneyOutcomeEventsNotificationOutcomeTouchpoint instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyOutcomeEventsNotificationOutcomeTouchpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyOutcomeEventsNotificationOutcomeTouchpoint other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Channels == other.Channels ||
                    this.Channels != null &&
                    this.Channels.SequenceEqual(other.Channels)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ActionMap == other.ActionMap ||
                    this.ActionMap != null &&
                    this.ActionMap.Equals(other.ActionMap)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Channels != null)
                    hash = hash * 59 + this.Channels.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                if (this.ActionMap != null)
                    hash = hash * 59 + this.ActionMap.GetHashCode();

                return hash;
            }
        }
    }

}
