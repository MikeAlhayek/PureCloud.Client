using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ImportScheduleUploadSchema
/// </summary>

public partial class ImportScheduleUploadSchema : IEquatable<ImportScheduleUploadSchema>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ImportScheduleUploadSchema" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ImportScheduleUploadSchema() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ImportScheduleUploadSchema" /> class.
    /// </summary>
    /// <param name="Description">The description for the imported schedule (required).</param>
    /// <param name="WeekCount">The number of weeks the imported schedule will cover (required).</param>
    /// <param name="Published">Whether the imported schedule should be immediately published.</param>
    /// <param name="ShortTermForecast">The short term forecast to associate with the imported schedule.</param>
    /// <param name="HeadcountForecast">The headcount forecast to associate with the imported schedule.</param>
    /// <param name="AgentSchedules">Individual agent schedules.</param>
    public ImportScheduleUploadSchema(string Description = null, int? WeekCount = null, bool? Published = null, BuShortTermForecastReference ShortTermForecast = null, BuHeadcountForecast HeadcountForecast = null, List<BuImportAgentScheduleUploadSchema> AgentSchedules = null)
    {
        this.Description = Description;
        this.WeekCount = WeekCount;
        this.Published = Published;
        this.ShortTermForecast = ShortTermForecast;
        this.HeadcountForecast = HeadcountForecast;
        this.AgentSchedules = AgentSchedules;

    }



    /// <summary>
    /// The description for the imported schedule
    /// </summary>
    /// <value>The description for the imported schedule</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The number of weeks the imported schedule will cover
    /// </summary>
    /// <value>The number of weeks the imported schedule will cover</value>
    [JsonPropertyName("weekCount")]
    public int? WeekCount { get; set; }



    /// <summary>
    /// Whether the imported schedule should be immediately published
    /// </summary>
    /// <value>Whether the imported schedule should be immediately published</value>
    [JsonPropertyName("published")]
    public bool? Published { get; set; }



    /// <summary>
    /// The short term forecast to associate with the imported schedule
    /// </summary>
    /// <value>The short term forecast to associate with the imported schedule</value>
    [JsonPropertyName("shortTermForecast")]
    public BuShortTermForecastReference ShortTermForecast { get; set; }



    /// <summary>
    /// The headcount forecast to associate with the imported schedule
    /// </summary>
    /// <value>The headcount forecast to associate with the imported schedule</value>
    [JsonPropertyName("headcountForecast")]
    public BuHeadcountForecast HeadcountForecast { get; set; }



    /// <summary>
    /// Individual agent schedules
    /// </summary>
    /// <value>Individual agent schedules</value>
    [JsonPropertyName("agentSchedules")]
    public List<BuImportAgentScheduleUploadSchema> AgentSchedules { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ImportScheduleUploadSchema {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
        sb.Append("  HeadcountForecast: ").Append(HeadcountForecast).Append("\n");
        sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
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
        return Equals(obj as ImportScheduleUploadSchema);
    }

    /// <summary>
    /// Returns true if ImportScheduleUploadSchema instances are equal
    /// </summary>
    /// <param name="other">Instance of ImportScheduleUploadSchema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ImportScheduleUploadSchema other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
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
                HeadcountForecast == other.HeadcountForecast ||
                HeadcountForecast != null &&
                HeadcountForecast.Equals(other.HeadcountForecast)
            ) &&
            (
                AgentSchedules == other.AgentSchedules ||
                AgentSchedules != null &&
                AgentSchedules.SequenceEqual(other.AgentSchedules)
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
            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (ShortTermForecast != null)
            {
                hash = hash * 59 + ShortTermForecast.GetHashCode();
            }

            if (HeadcountForecast != null)
            {
                hash = hash * 59 + HeadcountForecast.GetHashCode();
            }

            if (AgentSchedules != null)
            {
                hash = hash * 59 + AgentSchedules.GetHashCode();
            }

            return hash;
        }
    }
}
