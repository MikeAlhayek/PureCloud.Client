using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast
/// </summary>
[DataContract]
public partial class WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast : IEquatable<WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast>
{
    /// <summary>
    /// Gets or Sets CreationMethod
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CreationMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Import for "Import"
        /// </summary>
        [EnumMember(Value = "Import")]
        Import,

        /// <summary>
        /// Enum Importedhistoricalweightedaverage for "ImportedHistoricalWeightedAverage"
        /// </summary>
        [EnumMember(Value = "ImportedHistoricalWeightedAverage")]
        Importedhistoricalweightedaverage,

        /// <summary>
        /// Enum Historicalweightedaverage for "HistoricalWeightedAverage"
        /// </summary>
        [EnumMember(Value = "HistoricalWeightedAverage")]
        Historicalweightedaverage,

        /// <summary>
        /// Enum Advanced for "Advanced"
        /// </summary>
        [EnumMember(Value = "Advanced")]
        Advanced
    }
    /// <summary>
    /// Gets or Sets CreationMethod
    /// </summary>
    [DataMember(Name = "creationMethod", EmitDefaultValue = false)]
    public CreationMethodEnum? CreationMethod { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="WeekDate">WeekDate.</param>
    /// <param name="CreationMethod">CreationMethod.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Legacy">Legacy.</param>
    /// <param name="ReferenceStartDate">ReferenceStartDate.</param>
    /// <param name="SourceDays">SourceDays.</param>
    /// <param name="Modifications">Modifications.</param>
    /// <param name="TimeZone">TimeZone.</param>
    /// <param name="PlanningGroupsVersion">PlanningGroupsVersion.</param>
    /// <param name="WeekCount">WeekCount.</param>
    /// <param name="Metadata">Metadata.</param>
    /// <param name="CanUseForScheduling">CanUseForScheduling.</param>
    public WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast(string Id = null, string WeekDate = null, CreationMethodEnum? CreationMethod = null, string Description = null, bool? Legacy = null, DateTime? ReferenceStartDate = null, List<WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer> SourceDays = null, List<WfmBuShortTermForecastUpdateCompleteTopicBuForecastModification> Modifications = null, string TimeZone = null, long? PlanningGroupsVersion = null, long? WeekCount = null, WfmBuShortTermForecastUpdateCompleteTopicWfmVersionedEntityMetadata Metadata = null, bool? CanUseForScheduling = null)
    {
        this.Id = Id;
        this.WeekDate = WeekDate;
        this.CreationMethod = CreationMethod;
        this.Description = Description;
        this.Legacy = Legacy;
        this.ReferenceStartDate = ReferenceStartDate;
        this.SourceDays = SourceDays;
        this.Modifications = Modifications;
        this.TimeZone = TimeZone;
        this.PlanningGroupsVersion = PlanningGroupsVersion;
        this.WeekCount = WeekCount;
        this.Metadata = Metadata;
        this.CanUseForScheduling = CanUseForScheduling;

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
    public string WeekDate { get; set; }





    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Legacy
    /// </summary>
    [DataMember(Name = "legacy", EmitDefaultValue = false)]
    public bool? Legacy { get; set; }



    /// <summary>
    /// Gets or Sets ReferenceStartDate
    /// </summary>
    [DataMember(Name = "referenceStartDate", EmitDefaultValue = false)]
    public DateTime? ReferenceStartDate { get; set; }



    /// <summary>
    /// Gets or Sets SourceDays
    /// </summary>
    [DataMember(Name = "sourceDays", EmitDefaultValue = false)]
    public List<WfmBuShortTermForecastUpdateCompleteTopicForecastSourceDayPointer> SourceDays { get; set; }



    /// <summary>
    /// Gets or Sets Modifications
    /// </summary>
    [DataMember(Name = "modifications", EmitDefaultValue = false)]
    public List<WfmBuShortTermForecastUpdateCompleteTopicBuForecastModification> Modifications { get; set; }



    /// <summary>
    /// Gets or Sets TimeZone
    /// </summary>
    [DataMember(Name = "timeZone", EmitDefaultValue = false)]
    public string TimeZone { get; set; }



    /// <summary>
    /// Gets or Sets PlanningGroupsVersion
    /// </summary>
    [DataMember(Name = "planningGroupsVersion", EmitDefaultValue = false)]
    public long? PlanningGroupsVersion { get; set; }



    /// <summary>
    /// Gets or Sets WeekCount
    /// </summary>
    [DataMember(Name = "weekCount", EmitDefaultValue = false)]
    public long? WeekCount { get; set; }



    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmBuShortTermForecastUpdateCompleteTopicWfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// Gets or Sets CanUseForScheduling
    /// </summary>
    [DataMember(Name = "canUseForScheduling", EmitDefaultValue = false)]
    public bool? CanUseForScheduling { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  CreationMethod: ").Append(CreationMethod).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Legacy: ").Append(Legacy).Append("\n");
        sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
        sb.Append("  SourceDays: ").Append(SourceDays).Append("\n");
        sb.Append("  Modifications: ").Append(Modifications).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  PlanningGroupsVersion: ").Append(PlanningGroupsVersion).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  CanUseForScheduling: ").Append(CanUseForScheduling).Append("\n");
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
        return Equals(obj as WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast);
    }

    /// <summary>
    /// Returns true if WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecast other)
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
                CreationMethod == other.CreationMethod ||
                CreationMethod != null &&
                CreationMethod.Equals(other.CreationMethod)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Legacy == other.Legacy ||
                Legacy != null &&
                Legacy.Equals(other.Legacy)
            ) &&
            (
                ReferenceStartDate == other.ReferenceStartDate ||
                ReferenceStartDate != null &&
                ReferenceStartDate.Equals(other.ReferenceStartDate)
            ) &&
            (
                SourceDays == other.SourceDays ||
                SourceDays != null &&
                SourceDays.SequenceEqual(other.SourceDays)
            ) &&
            (
                Modifications == other.Modifications ||
                Modifications != null &&
                Modifications.SequenceEqual(other.Modifications)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                PlanningGroupsVersion == other.PlanningGroupsVersion ||
                PlanningGroupsVersion != null &&
                PlanningGroupsVersion.Equals(other.PlanningGroupsVersion)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                CanUseForScheduling == other.CanUseForScheduling ||
                CanUseForScheduling != null &&
                CanUseForScheduling.Equals(other.CanUseForScheduling)
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

            if (CreationMethod != null)
            {
                hash = hash * 59 + CreationMethod.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Legacy != null)
            {
                hash = hash * 59 + Legacy.GetHashCode();
            }

            if (ReferenceStartDate != null)
            {
                hash = hash * 59 + ReferenceStartDate.GetHashCode();
            }

            if (SourceDays != null)
            {
                hash = hash * 59 + SourceDays.GetHashCode();
            }

            if (Modifications != null)
            {
                hash = hash * 59 + Modifications.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (PlanningGroupsVersion != null)
            {
                hash = hash * 59 + PlanningGroupsVersion.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (CanUseForScheduling != null)
            {
                hash = hash * 59 + CanUseForScheduling.GetHashCode();
            }

            return hash;
        }
    }
}
