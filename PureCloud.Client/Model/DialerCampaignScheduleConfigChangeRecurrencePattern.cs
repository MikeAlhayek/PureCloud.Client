using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// the schedule pattern
    /// </summary>
    [DataContract]
    public partial class DialerCampaignScheduleConfigChangeRecurrencePattern :  IEquatable<DialerCampaignScheduleConfigChangeRecurrencePattern>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
            /// Enum Daily for "Daily"
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily,
            
            /// <summary>
            /// Enum Weekly for "Weekly"
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignScheduleConfigChangeRecurrencePattern" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Interval">the amount of time in between occurrences.</param>
        /// <param name="DaysOfWeek">the day(s) of the week the occurrence happens.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerCampaignScheduleConfigChangeRecurrencePattern(TypeEnum? Type = null, long? Interval = null, List<string> DaysOfWeek = null, Dictionary<string, Object> AdditionalProperties = null)
        {
            this.Type = Type;
            this.Interval = Interval;
            this.DaysOfWeek = DaysOfWeek;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        




        /// <summary>
        /// the amount of time in between occurrences
        /// </summary>
        /// <value>the amount of time in between occurrences</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public long? Interval { get; set; }



        /// <summary>
        /// the day(s) of the week the occurrence happens
        /// </summary>
        /// <value>the day(s) of the week the occurrence happens</value>
        [DataMember(Name="daysOfWeek", EmitDefaultValue=false)]
        public List<string> DaysOfWeek { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignScheduleConfigChangeRecurrencePattern {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerCampaignScheduleConfigChangeRecurrencePattern);
        }

        /// <summary>
        /// Returns true if DialerCampaignScheduleConfigChangeRecurrencePattern instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignScheduleConfigChangeRecurrencePattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignScheduleConfigChangeRecurrencePattern other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.DaysOfWeek == other.DaysOfWeek ||
                    this.DaysOfWeek != null &&
                    this.DaysOfWeek.SequenceEqual(other.DaysOfWeek)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.DaysOfWeek != null)
                    hash = hash * 59 + this.DaysOfWeek.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                return hash;
            }
        }
    }

}
