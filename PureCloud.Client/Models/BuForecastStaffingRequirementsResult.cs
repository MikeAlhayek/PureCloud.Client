using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

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
        return Equals(obj as BuForecastStaffingRequirementsResult);
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
        {
            return false;
        }

        return true &&
            (
                WeekNumber == other.WeekNumber ||
                WeekNumber != null &&
                WeekNumber.Equals(other.WeekNumber)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                DownloadUrlExpirationDate == other.DownloadUrlExpirationDate ||
                DownloadUrlExpirationDate != null &&
                DownloadUrlExpirationDate.Equals(other.DownloadUrlExpirationDate)
            ) &&
            (
                PlanningGroupStaffingRequirements == other.PlanningGroupStaffingRequirements ||
                PlanningGroupStaffingRequirements != null &&
                PlanningGroupStaffingRequirements.SequenceEqual(other.PlanningGroupStaffingRequirements)
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
            if (WeekNumber != null)
            {
                hash = hash * 59 + WeekNumber.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (DownloadUrlExpirationDate != null)
            {
                hash = hash * 59 + DownloadUrlExpirationDate.GetHashCode();
            }

            if (PlanningGroupStaffingRequirements != null)
            {
                hash = hash * 59 + PlanningGroupStaffingRequirements.GetHashCode();
            }

            return hash;
        }
    }
}
