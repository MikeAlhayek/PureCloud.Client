using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuScheduleTopicBuScheduleMetadata
/// </summary>
[DataContract]
public partial class WfmBuScheduleTopicBuScheduleMetadata : IEquatable<WfmBuScheduleTopicBuScheduleMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuScheduleTopicBuScheduleMetadata" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="WeekDate">WeekDate.</param>
    /// <param name="WeekCount">WeekCount.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Published">Published.</param>
    /// <param name="ShortTermForecast">ShortTermForecast.</param>
    /// <param name="ManagementUnits">ManagementUnits.</param>
    /// <param name="GenerationResults">GenerationResults.</param>
    /// <param name="Metadata">Metadata.</param>
    public WfmBuScheduleTopicBuScheduleMetadata(string Id = null, DateTime? WeekDate = null, long? WeekCount = null, string Description = null, bool? Published = null, WfmBuScheduleTopicBuShortTermForecastReference ShortTermForecast = null, List<WfmBuScheduleTopicBuManagementUnitScheduleSummary> ManagementUnits = null, WfmBuScheduleTopicBuScheduleGenerationResultSummary GenerationResults = null, WfmBuScheduleTopicWfmVersionedEntityMetadata Metadata = null)
    {
        this.Id = Id;
        this.WeekDate = WeekDate;
        this.WeekCount = WeekCount;
        this.Description = Description;
        this.Published = Published;
        this.ShortTermForecast = ShortTermForecast;
        this.ManagementUnits = ManagementUnits;
        this.GenerationResults = GenerationResults;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    [DataMember(Name = "weekDate", EmitDefaultValue = false)]
    public DateTime? WeekDate { get; set; }



    /// <summary>
    /// Gets or Sets WeekCount
    /// </summary>
    [DataMember(Name = "weekCount", EmitDefaultValue = false)]
    public long? WeekCount { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    [DataMember(Name = "published", EmitDefaultValue = false)]
    public bool? Published { get; set; }



    /// <summary>
    /// Gets or Sets ShortTermForecast
    /// </summary>
    [DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
    public WfmBuScheduleTopicBuShortTermForecastReference ShortTermForecast { get; set; }



    /// <summary>
    /// Gets or Sets ManagementUnits
    /// </summary>
    [DataMember(Name = "managementUnits", EmitDefaultValue = false)]
    public List<WfmBuScheduleTopicBuManagementUnitScheduleSummary> ManagementUnits { get; set; }



    /// <summary>
    /// Gets or Sets GenerationResults
    /// </summary>
    [DataMember(Name = "generationResults", EmitDefaultValue = false)]
    public WfmBuScheduleTopicBuScheduleGenerationResultSummary GenerationResults { get; set; }



    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmBuScheduleTopicWfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuScheduleTopicBuScheduleMetadata {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
        sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
        sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as WfmBuScheduleTopicBuScheduleMetadata);
    }

    /// <summary>
    /// Returns true if WfmBuScheduleTopicBuScheduleMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuScheduleTopicBuScheduleMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuScheduleTopicBuScheduleMetadata other)
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
                ManagementUnits == other.ManagementUnits ||
                ManagementUnits != null &&
                ManagementUnits.SequenceEqual(other.ManagementUnits)
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

            if (ManagementUnits != null)
            {
                hash = hash * 59 + ManagementUnits.GetHashCode();
            }

            if (GenerationResults != null)
            {
                hash = hash * 59 + GenerationResults.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
