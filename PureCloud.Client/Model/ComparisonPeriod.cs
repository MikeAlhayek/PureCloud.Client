using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ComparisonPeriod
    /// </summary>
    [DataContract]
    public partial class ComparisonPeriod :  IEquatable<ComparisonPeriod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComparisonPeriod" /> class.
        /// </summary>
        public ComparisonPeriod()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Key Performance Indicator optimised during the comparison period.
        /// </summary>
        /// <value>Key Performance Indicator optimised during the comparison period.</value>
        [DataMember(Name="kpi", EmitDefaultValue=false)]
        public string Kpi { get; private set; }



        /// <summary>
        /// Start date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStarted", EmitDefaultValue=false)]
        public DateTime? DateStarted { get; private set; }



        /// <summary>
        /// End date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>End date of the comparison period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnded", EmitDefaultValue=false)]
        public DateTime? DateEnded { get; private set; }



        /// <summary>
        /// The percentage benefit on this queue for the duration of the comparison period
        /// </summary>
        /// <value>The percentage benefit on this queue for the duration of the comparison period</value>
        [DataMember(Name="percentageBenefit", EmitDefaultValue=false)]
        public double? PercentageBenefit { get; private set; }



        /// <summary>
        /// KPI results for each metric
        /// </summary>
        /// <value>KPI results for each metric</value>
        [DataMember(Name="kpiResults", EmitDefaultValue=false)]
        public List<KpiResult> KpiResults { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComparisonPeriod {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Kpi: ").Append(Kpi).Append("\n");
            sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
            sb.Append("  DateEnded: ").Append(DateEnded).Append("\n");
            sb.Append("  PercentageBenefit: ").Append(PercentageBenefit).Append("\n");
            sb.Append("  KpiResults: ").Append(KpiResults).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ComparisonPeriod);
        }

        /// <summary>
        /// Returns true if ComparisonPeriod instances are equal
        /// </summary>
        /// <param name="other">Instance of ComparisonPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComparisonPeriod other)
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
                    this.Kpi == other.Kpi ||
                    this.Kpi != null &&
                    this.Kpi.Equals(other.Kpi)
                ) &&
                (
                    this.DateStarted == other.DateStarted ||
                    this.DateStarted != null &&
                    this.DateStarted.Equals(other.DateStarted)
                ) &&
                (
                    this.DateEnded == other.DateEnded ||
                    this.DateEnded != null &&
                    this.DateEnded.Equals(other.DateEnded)
                ) &&
                (
                    this.PercentageBenefit == other.PercentageBenefit ||
                    this.PercentageBenefit != null &&
                    this.PercentageBenefit.Equals(other.PercentageBenefit)
                ) &&
                (
                    this.KpiResults == other.KpiResults ||
                    this.KpiResults != null &&
                    this.KpiResults.SequenceEqual(other.KpiResults)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Kpi != null)
                    hash = hash * 59 + this.Kpi.GetHashCode();

                if (this.DateStarted != null)
                    hash = hash * 59 + this.DateStarted.GetHashCode();

                if (this.DateEnded != null)
                    hash = hash * 59 + this.DateEnded.GetHashCode();

                if (this.PercentageBenefit != null)
                    hash = hash * 59 + this.PercentageBenefit.GetHashCode();

                if (this.KpiResults != null)
                    hash = hash * 59 + this.KpiResults.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
