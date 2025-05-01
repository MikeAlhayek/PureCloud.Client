using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuScheduleMetadata
/// </summary>
[DataContract]
public partial class BuScheduleMetadata : IEquatable<BuScheduleMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuScheduleMetadata" /> class.
    /// </summary>
    /// <param name="WeekDate">The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="WeekCount">The number of weeks spanned by this schedule.</param>
    /// <param name="Description">The description of this schedule.</param>
    /// <param name="Published">Whether this schedule is published.</param>
    /// <param name="ShortTermForecast">The forecast used for this schedule, if applicable.</param>
    /// <param name="GenerationResults">Generation result summary for this schedule, if applicable.</param>
    /// <param name="Metadata">Version metadata for this schedule.</param>
    /// <param name="ManagementUnits">High level per-management unit schedule metadata.</param>
    public BuScheduleMetadata(string WeekDate = null, int? WeekCount = null, string Description = null, bool? Published = null, BuShortTermForecastReference ShortTermForecast = null, ScheduleGenerationResultSummary GenerationResults = null, WfmVersionedEntityMetadata Metadata = null, List<BuManagementUnitScheduleSummary> ManagementUnits = null)
    {
        this.WeekDate = WeekDate;
        this.WeekCount = WeekCount;
        this.Description = Description;
        this.Published = Published;
        this.ShortTermForecast = ShortTermForecast;
        this.GenerationResults = GenerationResults;
        this.Metadata = Metadata;
        this.ManagementUnits = ManagementUnits;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "weekDate", EmitDefaultValue = false)]
    public string WeekDate { get; set; }



    /// <summary>
    /// The number of weeks spanned by this schedule
    /// </summary>
    /// <value>The number of weeks spanned by this schedule</value>
    [DataMember(Name = "weekCount", EmitDefaultValue = false)]
    public int? WeekCount { get; set; }



    /// <summary>
    /// The description of this schedule
    /// </summary>
    /// <value>The description of this schedule</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Whether this schedule is published
    /// </summary>
    /// <value>Whether this schedule is published</value>
    [DataMember(Name = "published", EmitDefaultValue = false)]
    public bool? Published { get; set; }



    /// <summary>
    /// The forecast used for this schedule, if applicable
    /// </summary>
    /// <value>The forecast used for this schedule, if applicable</value>
    [DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
    public BuShortTermForecastReference ShortTermForecast { get; set; }



    /// <summary>
    /// Generation result summary for this schedule, if applicable
    /// </summary>
    /// <value>Generation result summary for this schedule, if applicable</value>
    [DataMember(Name = "generationResults", EmitDefaultValue = false)]
    public ScheduleGenerationResultSummary GenerationResults { get; set; }



    /// <summary>
    /// Version metadata for this schedule
    /// </summary>
    /// <value>Version metadata for this schedule</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// High level per-management unit schedule metadata
    /// </summary>
    /// <value>High level per-management unit schedule metadata</value>
    [DataMember(Name = "managementUnits", EmitDefaultValue = false)]
    public List<BuManagementUnitScheduleSummary> ManagementUnits { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuScheduleMetadata {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
        sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
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
        return Equals(obj as BuScheduleMetadata);
    }

    /// <summary>
    /// Returns true if BuScheduleMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of BuScheduleMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuScheduleMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                ShortTermForecast == other.ShortTermForecast ||
                ShortTermForecast != null &&
                ShortTermForecast.Equals(other.ShortTermForecast)
            ) &&
            (
                GenerationResults == other.GenerationResults ||
                GenerationResults != null &&
                GenerationResults.Equals(other.GenerationResults)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                ManagementUnits == other.ManagementUnits ||
                ManagementUnits != null &&
                ManagementUnits.SequenceEqual(other.ManagementUnits)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (ShortTermForecast != null)
            {
                hash = hash * 59 + ShortTermForecast.GetHashCode();
            }

            if (GenerationResults != null)
            {
                hash = hash * 59 + GenerationResults.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (ManagementUnits != null)
            {
                hash = hash * 59 + ManagementUnits.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
