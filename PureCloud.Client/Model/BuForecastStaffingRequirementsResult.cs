using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BuForecastStaffingRequirementsResult
    /// </summary>
    [DataContract]
    public partial class BuForecastStaffingRequirementsResult : IEquatable<BuForecastStaffingRequirementsResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuForecastStaffingRequirementsResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuForecastStaffingRequirementsResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuForecastStaffingRequirementsResult" /> class.
        /// </summary>
        /// <param name="WeekNumber">The week number represented by this response (required).</param>
        /// <param name="DownloadUrl">The url to get the requirements results for this week (required).</param>
        /// <param name="DownloadUrlExpirationDate">The expiration date of the download url, as an ISO-8601 string (required).</param>
        /// <param name="PlanningGroupStaffingRequirements">Results will always come via downloadUrl, however the schema is included for documentation.</param>
        public BuForecastStaffingRequirementsResult(int? WeekNumber = null, string DownloadUrl = null, DateTime? DownloadUrlExpirationDate = null, List<StaffingRequirementsPlanningGroupData> PlanningGroupStaffingRequirements = null)
        {
            this.WeekNumber = WeekNumber;
            this.DownloadUrl = DownloadUrl;
            this.DownloadUrlExpirationDate = DownloadUrlExpirationDate;
            this.PlanningGroupStaffingRequirements = PlanningGroupStaffingRequirements;

        }



        /// <summary>
        /// The week number represented by this response
        /// </summary>
        /// <value>The week number represented by this response</value>
        [DataMember(Name = "weekNumber", EmitDefaultValue = false)]
        public int? WeekNumber { get; set; }



        /// <summary>
        /// The url to get the requirements results for this week
        /// </summary>
        /// <value>The url to get the requirements results for this week</value>
        [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// The expiration date of the download url, as an ISO-8601 string
        /// </summary>
        /// <value>The expiration date of the download url, as an ISO-8601 string</value>
        [DataMember(Name = "downloadUrlExpirationDate", EmitDefaultValue = false)]
        public DateTime? DownloadUrlExpirationDate { get; set; }



        /// <summary>
        /// Results will always come via downloadUrl, however the schema is included for documentation
        /// </summary>
        /// <value>Results will always come via downloadUrl, however the schema is included for documentation</value>
        [DataMember(Name = "planningGroupStaffingRequirements", EmitDefaultValue = false)]
        public List<StaffingRequirementsPlanningGroupData> PlanningGroupStaffingRequirements { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuForecastStaffingRequirementsResult {\n");

            sb.Append("  WeekNumber: ").Append(WeekNumber).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  DownloadUrlExpirationDate: ").Append(DownloadUrlExpirationDate).Append("\n");
            sb.Append("  PlanningGroupStaffingRequirements: ").Append(PlanningGroupStaffingRequirements).Append("\n");
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
            return this.Equals(obj as BuForecastStaffingRequirementsResult);
        }

        /// <summary>
        /// Returns true if BuForecastStaffingRequirementsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BuForecastStaffingRequirementsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuForecastStaffingRequirementsResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekNumber == other.WeekNumber ||
                    this.WeekNumber != null &&
                    this.WeekNumber.Equals(other.WeekNumber)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.DownloadUrlExpirationDate == other.DownloadUrlExpirationDate ||
                    this.DownloadUrlExpirationDate != null &&
                    this.DownloadUrlExpirationDate.Equals(other.DownloadUrlExpirationDate)
                ) &&
                (
                    this.PlanningGroupStaffingRequirements == other.PlanningGroupStaffingRequirements ||
                    this.PlanningGroupStaffingRequirements != null &&
                    this.PlanningGroupStaffingRequirements.SequenceEqual(other.PlanningGroupStaffingRequirements)
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
                if (this.WeekNumber != null)
                    hash = hash * 59 + this.WeekNumber.GetHashCode();

                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();

                if (this.DownloadUrlExpirationDate != null)
                    hash = hash * 59 + this.DownloadUrlExpirationDate.GetHashCode();

                if (this.PlanningGroupStaffingRequirements != null)
                    hash = hash * 59 + this.PlanningGroupStaffingRequirements.GetHashCode();

                return hash;
            }
        }
    }

}
