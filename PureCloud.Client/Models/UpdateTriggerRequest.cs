using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateTriggerRequest
/// </summary>

public partial class UpdateTriggerRequest : IEquatable<UpdateTriggerRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateTriggerRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateTriggerRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateTriggerRequest" /> class.
    /// </summary>
    /// <param name="Version">Version of this trigger (required).</param>
    /// <param name="Enabled">Boolean indicating if Trigger is enabled (required).</param>
    /// <param name="Target">The target to invoke when a matching event is received (required).</param>
    /// <param name="MatchCriteria">The configuration for when a trigger is considered to be a match for an event.</param>
    /// <param name="Name">The name of the trigger (required).</param>
    /// <param name="TopicName">The topic that will cause the trigger to be invoked. Must match existing trigger topicName. (required).</param>
    /// <param name="EventTTLSeconds">Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set..</param>
    /// <param name="DelayBySeconds">Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set..</param>
    /// <param name="Description">Description of the trigger. Can be up to 512 characters in length..</param>
    public UpdateTriggerRequest(long? Version = null, bool? Enabled = null, TriggerTarget Target = null, List<MatchCriteria> MatchCriteria = null, string Name = null, string TopicName = null, int? EventTTLSeconds = null, int? DelayBySeconds = null, string Description = null)
    {
        this.Version = Version;
        this.Enabled = Enabled;
        this.Target = Target;
        this.MatchCriteria = MatchCriteria;
        this.Name = Name;
        this.TopicName = TopicName;
        this.EventTTLSeconds = EventTTLSeconds;
        this.DelayBySeconds = DelayBySeconds;
        this.Description = Description;

    }



    /// <summary>
    /// Version of this trigger
    /// </summary>
    /// <value>Version of this trigger</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }



    /// <summary>
    /// Boolean indicating if Trigger is enabled
    /// </summary>
    /// <value>Boolean indicating if Trigger is enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The target to invoke when a matching event is received
    /// </summary>
    /// <value>The target to invoke when a matching event is received</value>
    [JsonPropertyName("target")]
    public TriggerTarget Target { get; set; }



    /// <summary>
    /// The configuration for when a trigger is considered to be a match for an event
    /// </summary>
    /// <value>The configuration for when a trigger is considered to be a match for an event</value>
    [JsonPropertyName("matchCriteria")]
    public List<MatchCriteria> MatchCriteria { get; set; }



    /// <summary>
    /// The name of the trigger
    /// </summary>
    /// <value>The name of the trigger</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The topic that will cause the trigger to be invoked. Must match existing trigger topicName.
    /// </summary>
    /// <value>The topic that will cause the trigger to be invoked. Must match existing trigger topicName.</value>
    [JsonPropertyName("topicName")]
    public string TopicName { get; set; }



    /// <summary>
    /// Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set.
    /// </summary>
    /// <value>Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set.</value>
    [JsonPropertyName("eventTTLSeconds")]
    public int? EventTTLSeconds { get; set; }



    /// <summary>
    /// Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set.
    /// </summary>
    /// <value>Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set.</value>
    [JsonPropertyName("delayBySeconds")]
    public int? DelayBySeconds { get; set; }



    /// <summary>
    /// Description of the trigger. Can be up to 512 characters in length.
    /// </summary>
    /// <value>Description of the trigger. Can be up to 512 characters in length.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateTriggerRequest {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Target: ").Append(Target).Append("\n");
        sb.Append("  MatchCriteria: ").Append(MatchCriteria).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TopicName: ").Append(TopicName).Append("\n");
        sb.Append("  EventTTLSeconds: ").Append(EventTTLSeconds).Append("\n");
        sb.Append("  DelayBySeconds: ").Append(DelayBySeconds).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as UpdateTriggerRequest);
    }

    /// <summary>
    /// Returns true if UpdateTriggerRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateTriggerRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateTriggerRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Target == other.Target ||
                Target != null &&
                Target.Equals(other.Target)
            ) &&
            (
                MatchCriteria == other.MatchCriteria ||
                MatchCriteria != null &&
                MatchCriteria.SequenceEqual(other.MatchCriteria)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                TopicName == other.TopicName ||
                TopicName != null &&
                TopicName.Equals(other.TopicName)
            ) &&
            (
                EventTTLSeconds == other.EventTTLSeconds ||
                EventTTLSeconds != null &&
                EventTTLSeconds.Equals(other.EventTTLSeconds)
            ) &&
            (
                DelayBySeconds == other.DelayBySeconds ||
                DelayBySeconds != null &&
                DelayBySeconds.Equals(other.DelayBySeconds)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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
            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Target != null)
            {
                hash = hash * 59 + Target.GetHashCode();
            }

            if (MatchCriteria != null)
            {
                hash = hash * 59 + MatchCriteria.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (TopicName != null)
            {
                hash = hash * 59 + TopicName.GetHashCode();
            }

            if (EventTTLSeconds != null)
            {
                hash = hash * 59 + EventTTLSeconds.GetHashCode();
            }

            if (DelayBySeconds != null)
            {
                hash = hash * 59 + DelayBySeconds.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            return hash;
        }
    }
}
