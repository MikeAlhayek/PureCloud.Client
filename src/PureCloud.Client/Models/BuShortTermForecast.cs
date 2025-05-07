using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuShortTermForecast
/// </summary>

public partial class BuShortTermForecast : IEquatable<BuShortTermForecast>
{
    /// <summary>
    /// The method by which this forecast was created
    /// </summary>
    /// <value>The method by which this forecast was created</value>
    
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
    /// The method by which this forecast was created
    /// </summary>
    /// <value>The method by which this forecast was created</value>
    [JsonPropertyName("creationMethod")]
    public CreationMethodEnum? CreationMethod { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuShortTermForecast" /> class.
    /// </summary>
    /// <param name="WeekDate">The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="WeekCount">The number of weeks this forecast covers.</param>
    /// <param name="CreationMethod">The method by which this forecast was created.</param>
    /// <param name="Description">The description of this forecast.</param>
    /// <param name="Metadata">Metadata for this forecast.</param>
    /// <param name="CanUseForScheduling">Whether this forecast can be used for scheduling.</param>
    /// <param name="ReferenceStartDate">The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SourceDays">The source day pointers for this forecast.</param>
    /// <param name="Modifications">Any manual modifications applied to this forecast.</param>
    /// <param name="GenerationResults">Generation result metadata.</param>
    /// <param name="TimeZone">The time zone for this forecast.</param>
    /// <param name="PlanningGroupsVersion">The version of the planning groups that was used for this forecast.</param>
    /// <param name="PlanningGroups">A snapshot of the planning groups used for this forecast as of the version number indicated.</param>
    public BuShortTermForecast(string WeekDate = null, int? WeekCount = null, CreationMethodEnum? CreationMethod = null, string Description = null, WfmVersionedEntityMetadata Metadata = null, bool? CanUseForScheduling = null, DateTime? ReferenceStartDate = null, List<ForecastSourceDayPointer> SourceDays = null, List<BuForecastModificationResponse> Modifications = null, BuForecastGenerationResult GenerationResults = null, string TimeZone = null, int? PlanningGroupsVersion = null, ForecastPlanningGroupsResponse PlanningGroups = null)
    {
        this.WeekDate = WeekDate;
        this.WeekCount = WeekCount;
        this.CreationMethod = CreationMethod;
        this.Description = Description;
        this.Metadata = Metadata;
        this.CanUseForScheduling = CanUseForScheduling;
        this.ReferenceStartDate = ReferenceStartDate;
        this.SourceDays = SourceDays;
        this.Modifications = Modifications;
        this.GenerationResults = GenerationResults;
        this.TimeZone = TimeZone;
        this.PlanningGroupsVersion = PlanningGroupsVersion;
        this.PlanningGroups = PlanningGroups;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start week date of this forecast in yyyy-MM-dd.  Must fall on the start day of week for the associated business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }



    /// <summary>
    /// The number of weeks this forecast covers
    /// </summary>
    /// <value>The number of weeks this forecast covers</value>
    [JsonPropertyName("weekCount")]
    public int? WeekCount { get; set; }





    /// <summary>
    /// The description of this forecast
    /// </summary>
    /// <value>The description of this forecast</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Whether this forecast contains modifications on legacy metrics
    /// </summary>
    /// <value>Whether this forecast contains modifications on legacy metrics</value>
    [JsonPropertyName("legacy")]
    public bool? Legacy { get; set; }



    /// <summary>
    /// Metadata for this forecast
    /// </summary>
    /// <value>Metadata for this forecast</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// Whether this forecast can be used for scheduling
    /// </summary>
    /// <value>Whether this forecast can be used for scheduling</value>
    [JsonPropertyName("canUseForScheduling")]
    public bool? CanUseForScheduling { get; set; }



    /// <summary>
    /// The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The reference start date for interval-based data for this forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("referenceStartDate")]
    public DateTime? ReferenceStartDate { get; set; }



    /// <summary>
    /// The source day pointers for this forecast
    /// </summary>
    /// <value>The source day pointers for this forecast</value>
    [JsonPropertyName("sourceDays")]
    public List<ForecastSourceDayPointer> SourceDays { get; set; }



    /// <summary>
    /// Any manual modifications applied to this forecast
    /// </summary>
    /// <value>Any manual modifications applied to this forecast</value>
    [JsonPropertyName("modifications")]
    public List<BuForecastModificationResponse> Modifications { get; set; }



    /// <summary>
    /// Generation result metadata
    /// </summary>
    /// <value>Generation result metadata</value>
    [JsonPropertyName("generationResults")]
    public BuForecastGenerationResult GenerationResults { get; set; }



    /// <summary>
    /// The time zone for this forecast
    /// </summary>
    /// <value>The time zone for this forecast</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }



    /// <summary>
    /// The version of the planning groups that was used for this forecast
    /// </summary>
    /// <value>The version of the planning groups that was used for this forecast</value>
    [JsonPropertyName("planningGroupsVersion")]
    public int? PlanningGroupsVersion { get; set; }



    /// <summary>
    /// A snapshot of the planning groups used for this forecast as of the version number indicated
    /// </summary>
    /// <value>A snapshot of the planning groups used for this forecast as of the version number indicated</value>
    [JsonPropertyName("planningGroups")]
    public ForecastPlanningGroupsResponse PlanningGroups { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuShortTermForecast {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  CreationMethod: ").Append(CreationMethod).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Legacy: ").Append(Legacy).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  CanUseForScheduling: ").Append(CanUseForScheduling).Append("\n");
        sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
        sb.Append("  SourceDays: ").Append(SourceDays).Append("\n");
        sb.Append("  Modifications: ").Append(Modifications).Append("\n");
        sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  PlanningGroupsVersion: ").Append(PlanningGroupsVersion).Append("\n");
        sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
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
        return Equals(obj as BuShortTermForecast);
    }

    /// <summary>
    /// Returns true if BuShortTermForecast instances are equal
    /// </summary>
    /// <param name="other">Instance of BuShortTermForecast to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuShortTermForecast other)
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
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                CanUseForScheduling == other.CanUseForScheduling ||
                CanUseForScheduling != null &&
                CanUseForScheduling.Equals(other.CanUseForScheduling)
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
                GenerationResults == other.GenerationResults ||
                GenerationResults != null &&
                GenerationResults.Equals(other.GenerationResults)
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
                PlanningGroups == other.PlanningGroups ||
                PlanningGroups != null &&
                PlanningGroups.Equals(other.PlanningGroups)
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

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (CanUseForScheduling != null)
            {
                hash = hash * 59 + CanUseForScheduling.GetHashCode();
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

            if (GenerationResults != null)
            {
                hash = hash * 59 + GenerationResults.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (PlanningGroupsVersion != null)
            {
                hash = hash * 59 + PlanningGroupsVersion.GetHashCode();
            }

            if (PlanningGroups != null)
            {
                hash = hash * 59 + PlanningGroups.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
