using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ManagementUnitSettingsRequest
/// </summary>

public partial class ManagementUnitSettingsRequest : IEquatable<ManagementUnitSettingsRequest>
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
    [JsonPropertyName("adherence")]
    public AdherenceSettings Adherence { get; set; }



    /// <summary>
    /// Short term forecasting settings for this management unit.  Moving to Business Unit
    /// </summary>
    /// <value>Short term forecasting settings for this management unit.  Moving to Business Unit</value>
    [JsonPropertyName("shortTermForecasting")]
    public ShortTermForecastingSettings ShortTermForecasting { get; set; }



    /// <summary>
    /// Time off request settings for this management unit
    /// </summary>
    /// <value>Time off request settings for this management unit</value>
    [JsonPropertyName("timeOff")]
    public TimeOffSettingsRequest TimeOff { get; set; }



    /// <summary>
    /// Scheduling settings for this management unit
    /// </summary>
    /// <value>Scheduling settings for this management unit</value>
    [JsonPropertyName("scheduling")]
    public SchedulingSettingsRequest Scheduling { get; set; }



    /// <summary>
    /// Shift trade settings for this management unit
    /// </summary>
    /// <value>Shift trade settings for this management unit</value>
    [JsonPropertyName("shiftTrading")]
    public ShiftTradeSettings ShiftTrading { get; set; }



    /// <summary>
    /// Version info metadata for the associated management unit
    /// </summary>
    /// <value>Version info metadata for the associated management unit</value>
    [JsonPropertyName("metadata")]
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
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as ManagementUnitSettingsRequest);
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
        {
            return false;
        }

        return true &&
            (
                Adherence == other.Adherence ||
                Adherence != null &&
                Adherence.Equals(other.Adherence)
            ) &&
            (
                ShortTermForecasting == other.ShortTermForecasting ||
                ShortTermForecasting != null &&
                ShortTermForecasting.Equals(other.ShortTermForecasting)
            ) &&
            (
                TimeOff == other.TimeOff ||
                TimeOff != null &&
                TimeOff.Equals(other.TimeOff)
            ) &&
            (
                Scheduling == other.Scheduling ||
                Scheduling != null &&
                Scheduling.Equals(other.Scheduling)
            ) &&
            (
                ShiftTrading == other.ShiftTrading ||
                ShiftTrading != null &&
                ShiftTrading.Equals(other.ShiftTrading)
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
            if (Adherence != null)
            {
                hash = hash * 59 + Adherence.GetHashCode();
            }

            if (ShortTermForecasting != null)
            {
                hash = hash * 59 + ShortTermForecasting.GetHashCode();
            }

            if (TimeOff != null)
            {
                hash = hash * 59 + TimeOff.GetHashCode();
            }

            if (Scheduling != null)
            {
                hash = hash * 59 + Scheduling.GetHashCode();
            }

            if (ShiftTrading != null)
            {
                hash = hash * 59 + ShiftTrading.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
