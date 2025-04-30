using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// TimeAllowed
    /// </summary>
    [DataContract]
    public partial class TimeAllowed :  IEquatable<TimeAllowed>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAllowed" /> class.
        /// </summary>
        /// <param name="TimeSlots">TimeSlots.</param>
        /// <param name="TimeZoneId">TimeZoneId.</param>
        /// <param name="Empty">Empty.</param>
        public TimeAllowed(List<TimeSlot> TimeSlots = null, string TimeZoneId = null, bool? Empty = null)
        {
            this.TimeSlots = TimeSlots;
            this.TimeZoneId = TimeZoneId;
            this.Empty = Empty;
            
        }
        


        /// <summary>
        /// Gets or Sets TimeSlots
        /// </summary>
        [DataMember(Name="timeSlots", EmitDefaultValue=false)]
        public List<TimeSlot> TimeSlots { get; set; }



        /// <summary>
        /// Gets or Sets TimeZoneId
        /// </summary>
        [DataMember(Name="timeZoneId", EmitDefaultValue=false)]
        public string TimeZoneId { get; set; }



        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name="empty", EmitDefaultValue=false)]
        public bool? Empty { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeAllowed {\n");

            sb.Append("  TimeSlots: ").Append(TimeSlots).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TimeAllowed);
        }

        /// <summary>
        /// Returns true if TimeAllowed instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeAllowed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeAllowed other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeSlots == other.TimeSlots ||
                    this.TimeSlots != null &&
                    this.TimeSlots.SequenceEqual(other.TimeSlots)
                ) &&
                (
                    this.TimeZoneId == other.TimeZoneId ||
                    this.TimeZoneId != null &&
                    this.TimeZoneId.Equals(other.TimeZoneId)
                ) &&
                (
                    this.Empty == other.Empty ||
                    this.Empty != null &&
                    this.Empty.Equals(other.Empty)
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
                if (this.TimeSlots != null)
                    hash = hash * 59 + this.TimeSlots.GetHashCode();

                if (this.TimeZoneId != null)
                    hash = hash * 59 + this.TimeZoneId.GetHashCode();

                if (this.Empty != null)
                    hash = hash * 59 + this.Empty.GetHashCode();

                return hash;
            }
        }
    }

}
