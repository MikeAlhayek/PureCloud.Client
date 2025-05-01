using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateScheduleUploadSchema
/// </summary>
[DataContract]
public partial class UpdateScheduleUploadSchema : IEquatable<UpdateScheduleUploadSchema>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateScheduleUploadSchema" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateScheduleUploadSchema() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateScheduleUploadSchema" /> class.
    /// </summary>
    /// <param name="Description">The description to set for the schedule.</param>
    /// <param name="Published">Whether to publish the schedule. Note: a schedule cannot be un-published unless another schedule is published over it.</param>
    /// <param name="ShortTermForecast">The short term forecast to associate with the schedule.</param>
    /// <param name="HeadcountForecast">The headcount forecast to associate with the schedule.</param>
    /// <param name="AgentSchedules">Individual agent schedules.</param>
    /// <param name="Metadata">Version metadata for this schedule (required).</param>
    public UpdateScheduleUploadSchema(string Description = null, bool? Published = null, BuShortTermForecastReference ShortTermForecast = null, BuHeadcountForecast HeadcountForecast = null, List<BuUpdateAgentScheduleUploadSchema> AgentSchedules = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Description = Description;
        this.Published = Published;
        this.ShortTermForecast = ShortTermForecast;
        this.HeadcountForecast = HeadcountForecast;
        this.AgentSchedules = AgentSchedules;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The description to set for the schedule
    /// </summary>
    /// <value>The description to set for the schedule</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Whether to publish the schedule. Note: a schedule cannot be un-published unless another schedule is published over it
    /// </summary>
    /// <value>Whether to publish the schedule. Note: a schedule cannot be un-published unless another schedule is published over it</value>
    [DataMember(Name = "published", EmitDefaultValue = false)]
    public bool? Published { get; set; }



    /// <summary>
    /// The short term forecast to associate with the schedule
    /// </summary>
    /// <value>The short term forecast to associate with the schedule</value>
    [DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
    public BuShortTermForecastReference ShortTermForecast { get; set; }



    /// <summary>
    /// The headcount forecast to associate with the schedule
    /// </summary>
    /// <value>The headcount forecast to associate with the schedule</value>
    [DataMember(Name = "headcountForecast", EmitDefaultValue = false)]
    public BuHeadcountForecast HeadcountForecast { get; set; }



    /// <summary>
    /// Individual agent schedules
    /// </summary>
    /// <value>Individual agent schedules</value>
    [DataMember(Name = "agentSchedules", EmitDefaultValue = false)]
    public List<BuUpdateAgentScheduleUploadSchema> AgentSchedules { get; set; }



    /// <summary>
    /// Version metadata for this schedule
    /// </summary>
    /// <value>Version metadata for this schedule</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateScheduleUploadSchema {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
        sb.Append("  HeadcountForecast: ").Append(HeadcountForecast).Append("\n");
        sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
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
        return Equals(obj as UpdateScheduleUploadSchema);
    }

    /// <summary>
    /// Returns true if UpdateScheduleUploadSchema instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateScheduleUploadSchema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateScheduleUploadSchema other)
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

            if (HeadcountForecast != null)
            {
                hash = hash * 59 + HeadcountForecast.GetHashCode();
            }

            if (AgentSchedules != null)
            {
                hash = hash * 59 + AgentSchedules.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
