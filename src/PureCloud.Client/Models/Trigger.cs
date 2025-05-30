using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a process automation trigger.
/// </summary>

public partial class Trigger : IEquatable<Trigger>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Trigger" /> class.
    /// </summary>
    /// <param name="Name">The name of the trigger.</param>
    /// <param name="TopicName">The topic that will cause the trigger to be invoked.</param>
    /// <param name="Target">The target to invoke when a matching event is received.</param>
    /// <param name="Version">Version of this trigger.</param>
    /// <param name="Enabled">Whether or not the trigger is enabled.</param>
    /// <param name="MatchCriteria">The configuration for when a trigger is considered to be a match for an event.</param>
    /// <param name="EventTTLSeconds">Optional length of time that events are meaningful after origination. Events older than this threshold may be dropped if the platform is delayed in processing events. Unset means events are valid indefinitely, otherwise must be set to at least 10 seconds. Only one of eventTTLSeconds or delayBySeconds can be set..</param>
    /// <param name="DelayBySeconds">Optional delay invoking target after trigger fires. Must be in the range of 60 to 900 seconds. Only one of eventTTLSeconds or delayBySeconds can be set..</param>
    /// <param name="Description">Description of the trigger. Can be up to 512 characters in length..</param>
    public Trigger(string Name = null, string TopicName = null, TriggerTarget Target = null, long? Version = null, bool? Enabled = null, List<MatchCriteria> MatchCriteria = null, int? EventTTLSeconds = null, int? DelayBySeconds = null, string Description = null)
    {
        this.Name = Name;
        this.TopicName = TopicName;
        this.Target = Target;
        this.Version = Version;
        this.Enabled = Enabled;
        this.MatchCriteria = MatchCriteria;
        this.EventTTLSeconds = EventTTLSeconds;
        this.DelayBySeconds = DelayBySeconds;
        this.Description = Description;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the trigger
    /// </summary>
    /// <value>The name of the trigger</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The topic that will cause the trigger to be invoked
    /// </summary>
    /// <value>The topic that will cause the trigger to be invoked</value>
    [JsonPropertyName("topicName")]
    public string TopicName { get; set; }



    /// <summary>
    /// The target to invoke when a matching event is received
    /// </summary>
    /// <value>The target to invoke when a matching event is received</value>
    [JsonPropertyName("target")]
    public TriggerTarget Target { get; set; }



    /// <summary>
    /// Version of this trigger
    /// </summary>
    /// <value>Version of this trigger</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }



    /// <summary>
    /// Whether or not the trigger is enabled
    /// </summary>
    /// <value>Whether or not the trigger is enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The configuration for when a trigger is considered to be a match for an event
    /// </summary>
    /// <value>The configuration for when a trigger is considered to be a match for an event</value>
    [JsonPropertyName("matchCriteria")]
    public List<MatchCriteria> MatchCriteria { get; set; }



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
        sb.Append("class Trigger {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TopicName: ").Append(TopicName).Append("\n");
        sb.Append("  Target: ").Append(Target).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  MatchCriteria: ").Append(MatchCriteria).Append("\n");
        sb.Append("  EventTTLSeconds: ").Append(EventTTLSeconds).Append("\n");
        sb.Append("  DelayBySeconds: ").Append(DelayBySeconds).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as Trigger);
    }

    /// <summary>
    /// Returns true if Trigger instances are equal
    /// </summary>
    /// <param name="other">Instance of Trigger to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Trigger other)
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
                Target == other.Target ||
                Target != null &&
                Target.Equals(other.Target)
            ) &&
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
                MatchCriteria == other.MatchCriteria ||
                MatchCriteria != null &&
                MatchCriteria.SequenceEqual(other.MatchCriteria)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (TopicName != null)
            {
                hash = hash * 59 + TopicName.GetHashCode();
            }

            if (Target != null)
            {
                hash = hash * 59 + Target.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (MatchCriteria != null)
            {
                hash = hash * 59 + MatchCriteria.GetHashCode();
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
