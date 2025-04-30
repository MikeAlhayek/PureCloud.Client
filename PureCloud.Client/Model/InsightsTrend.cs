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
    /// InsightsTrend
    /// </summary>
    [DataContract]
    public partial class InsightsTrend :  IEquatable<InsightsTrend>
    {
        /// <summary>
        /// Granularity
        /// </summary>
        /// <value>Granularity</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum GranularityEnum
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
            Weekly,
            
            /// <summary>
            /// Enum Monthly for "Monthly"
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly
        }
        /// <summary>
        /// Granularity
        /// </summary>
        /// <value>Granularity</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsTrend" /> class.
        /// </summary>
        /// <param name="PerformanceProfile">The performance profile.</param>
        /// <param name="Division">The division.</param>
        /// <param name="Granularity">Granularity.</param>
        /// <param name="ComparativePeriod">The comparative period work day date range.</param>
        /// <param name="PrimaryPeriod">The primary period work day date range.</param>
        /// <param name="Entities">The list of insights trend for each metric.</param>
        /// <param name="Total">The insights trend in total.</param>
        public InsightsTrend(AddressableEntityRef PerformanceProfile = null, DivisionReference Division = null, GranularityEnum? Granularity = null, WorkdayPeriod ComparativePeriod = null, WorkdayPeriod PrimaryPeriod = null, List<InsightsTrendMetricItem> Entities = null, InsightsTrendTotalItem Total = null)
        {
            this.PerformanceProfile = PerformanceProfile;
            this.Division = Division;
            this.Granularity = Granularity;
            this.ComparativePeriod = ComparativePeriod;
            this.PrimaryPeriod = PrimaryPeriod;
            this.Entities = Entities;
            this.Total = Total;
            
        }
        


        /// <summary>
        /// The performance profile
        /// </summary>
        /// <value>The performance profile</value>
        [DataMember(Name="performanceProfile", EmitDefaultValue=false)]
        public AddressableEntityRef PerformanceProfile { get; set; }



        /// <summary>
        /// The division
        /// </summary>
        /// <value>The division</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public DivisionReference Division { get; set; }





        /// <summary>
        /// The comparative period work day date range
        /// </summary>
        /// <value>The comparative period work day date range</value>
        [DataMember(Name="comparativePeriod", EmitDefaultValue=false)]
        public WorkdayPeriod ComparativePeriod { get; set; }



        /// <summary>
        /// The primary period work day date range
        /// </summary>
        /// <value>The primary period work day date range</value>
        [DataMember(Name="primaryPeriod", EmitDefaultValue=false)]
        public WorkdayPeriod PrimaryPeriod { get; set; }



        /// <summary>
        /// The list of insights trend for each metric
        /// </summary>
        /// <value>The list of insights trend for each metric</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<InsightsTrendMetricItem> Entities { get; set; }



        /// <summary>
        /// The insights trend in total
        /// </summary>
        /// <value>The insights trend in total</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public InsightsTrendTotalItem Total { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsightsTrend {\n");

            sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
            sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(obj as InsightsTrend);
        }

        /// <summary>
        /// Returns true if InsightsTrend instances are equal
        /// </summary>
        /// <param name="other">Instance of InsightsTrend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsTrend other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PerformanceProfile == other.PerformanceProfile ||
                    this.PerformanceProfile != null &&
                    this.PerformanceProfile.Equals(other.PerformanceProfile)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.ComparativePeriod == other.ComparativePeriod ||
                    this.ComparativePeriod != null &&
                    this.ComparativePeriod.Equals(other.ComparativePeriod)
                ) &&
                (
                    this.PrimaryPeriod == other.PrimaryPeriod ||
                    this.PrimaryPeriod != null &&
                    this.PrimaryPeriod.Equals(other.PrimaryPeriod)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                if (this.PerformanceProfile != null)
                    hash = hash * 59 + this.PerformanceProfile.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.ComparativePeriod != null)
                    hash = hash * 59 + this.ComparativePeriod.GetHashCode();

                if (this.PrimaryPeriod != null)
                    hash = hash * 59 + this.PrimaryPeriod.GetHashCode();

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();

                return hash;
            }
        }
    }

}
