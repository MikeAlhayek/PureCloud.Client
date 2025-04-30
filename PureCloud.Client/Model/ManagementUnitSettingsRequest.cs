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
    /// ManagementUnitSettingsRequest
    /// </summary>
    [DataContract]
    public partial class ManagementUnitSettingsRequest :  IEquatable<ManagementUnitSettingsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUnitSettingsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManagementUnitSettingsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUnitSettingsRequest" /> class.
        /// </summary>
        /// <param name="Adherence">Adherence settings for this management unit.</param>
        /// <param name="ShortTermForecasting">Short term forecasting settings for this management unit.  Moving to Business Unit.</param>
        /// <param name="TimeOff">Time off request settings for this management unit.</param>
        /// <param name="Scheduling">Scheduling settings for this management unit.</param>
        /// <param name="ShiftTrading">Shift trade settings for this management unit.</param>
        /// <param name="Metadata">Version info metadata for the associated management unit (required).</param>
        public ManagementUnitSettingsRequest(AdherenceSettings Adherence = null, ShortTermForecastingSettings ShortTermForecasting = null, TimeOffSettingsRequest TimeOff = null, SchedulingSettingsRequest Scheduling = null, ShiftTradeSettings ShiftTrading = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Adherence = Adherence;
            this.ShortTermForecasting = ShortTermForecasting;
            this.TimeOff = TimeOff;
            this.Scheduling = Scheduling;
            this.ShiftTrading = ShiftTrading;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Adherence settings for this management unit
        /// </summary>
        /// <value>Adherence settings for this management unit</value>
        [DataMember(Name="adherence", EmitDefaultValue=false)]
        public AdherenceSettings Adherence { get; set; }



        /// <summary>
        /// Short term forecasting settings for this management unit.  Moving to Business Unit
        /// </summary>
        /// <value>Short term forecasting settings for this management unit.  Moving to Business Unit</value>
        [DataMember(Name="shortTermForecasting", EmitDefaultValue=false)]
        public ShortTermForecastingSettings ShortTermForecasting { get; set; }



        /// <summary>
        /// Time off request settings for this management unit
        /// </summary>
        /// <value>Time off request settings for this management unit</value>
        [DataMember(Name="timeOff", EmitDefaultValue=false)]
        public TimeOffSettingsRequest TimeOff { get; set; }



        /// <summary>
        /// Scheduling settings for this management unit
        /// </summary>
        /// <value>Scheduling settings for this management unit</value>
        [DataMember(Name="scheduling", EmitDefaultValue=false)]
        public SchedulingSettingsRequest Scheduling { get; set; }



        /// <summary>
        /// Shift trade settings for this management unit
        /// </summary>
        /// <value>Shift trade settings for this management unit</value>
        [DataMember(Name="shiftTrading", EmitDefaultValue=false)]
        public ShiftTradeSettings ShiftTrading { get; set; }



        /// <summary>
        /// Version info metadata for the associated management unit
        /// </summary>
        /// <value>Version info metadata for the associated management unit</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagementUnitSettingsRequest {\n");

            sb.Append("  Adherence: ").Append(Adherence).Append("\n");
            sb.Append("  ShortTermForecasting: ").Append(ShortTermForecasting).Append("\n");
            sb.Append("  TimeOff: ").Append(TimeOff).Append("\n");
            sb.Append("  Scheduling: ").Append(Scheduling).Append("\n");
            sb.Append("  ShiftTrading: ").Append(ShiftTrading).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as ManagementUnitSettingsRequest);
        }

        /// <summary>
        /// Returns true if ManagementUnitSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ManagementUnitSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagementUnitSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Adherence == other.Adherence ||
                    this.Adherence != null &&
                    this.Adherence.Equals(other.Adherence)
                ) &&
                (
                    this.ShortTermForecasting == other.ShortTermForecasting ||
                    this.ShortTermForecasting != null &&
                    this.ShortTermForecasting.Equals(other.ShortTermForecasting)
                ) &&
                (
                    this.TimeOff == other.TimeOff ||
                    this.TimeOff != null &&
                    this.TimeOff.Equals(other.TimeOff)
                ) &&
                (
                    this.Scheduling == other.Scheduling ||
                    this.Scheduling != null &&
                    this.Scheduling.Equals(other.Scheduling)
                ) &&
                (
                    this.ShiftTrading == other.ShiftTrading ||
                    this.ShiftTrading != null &&
                    this.ShiftTrading.Equals(other.ShiftTrading)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Adherence != null)
                    hash = hash * 59 + this.Adherence.GetHashCode();

                if (this.ShortTermForecasting != null)
                    hash = hash * 59 + this.ShortTermForecasting.GetHashCode();

                if (this.TimeOff != null)
                    hash = hash * 59 + this.TimeOff.GetHashCode();

                if (this.Scheduling != null)
                    hash = hash * 59 + this.Scheduling.GetHashCode();

                if (this.ShiftTrading != null)
                    hash = hash * 59 + this.ShiftTrading.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
