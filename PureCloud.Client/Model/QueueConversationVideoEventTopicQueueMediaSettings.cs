using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Represents the queue setting for this media.
/// </summary>
[DataContract]
public partial class QueueConversationVideoEventTopicQueueMediaSettings : IEquatable<QueueConversationVideoEventTopicQueueMediaSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicQueueMediaSettings" /> class.
    /// </summary>
    /// <param name="AlertingTimeoutSeconds">Specifies how long the agent has to answer an interaction before being marked as not responding..</param>
    /// <param name="AutoAnswerAlertToneSeconds">Specifies the duration of the alerting sound to be played for auto answered interactions..</param>
    /// <param name="ManualAnswerAlertToneSeconds">Specifies the duration of the alerting sound to be played for manually answered interactions.</param>
    /// <param name="EnableAutoAnswer">Flag to indicate if auto answer is enabled for the given media type or media subtype..</param>
    public QueueConversationVideoEventTopicQueueMediaSettings(long? AlertingTimeoutSeconds = null, double? AutoAnswerAlertToneSeconds = null, double? ManualAnswerAlertToneSeconds = null, bool? EnableAutoAnswer = null)
    {
        this.AlertingTimeoutSeconds = AlertingTimeoutSeconds;
        this.AutoAnswerAlertToneSeconds = AutoAnswerAlertToneSeconds;
        this.ManualAnswerAlertToneSeconds = ManualAnswerAlertToneSeconds;
        this.EnableAutoAnswer = EnableAutoAnswer;

    }



    /// <summary>
    /// Specifies how long the agent has to answer an interaction before being marked as not responding.
    /// </summary>
    /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
    [DataMember(Name = "alertingTimeoutSeconds", EmitDefaultValue = false)]
    public long? AlertingTimeoutSeconds { get; set; }



    /// <summary>
    /// Specifies the duration of the alerting sound to be played for auto answered interactions.
    /// </summary>
    /// <value>Specifies the duration of the alerting sound to be played for auto answered interactions.</value>
    [DataMember(Name = "autoAnswerAlertToneSeconds", EmitDefaultValue = false)]
    public double? AutoAnswerAlertToneSeconds { get; set; }



    /// <summary>
    /// Specifies the duration of the alerting sound to be played for manually answered interactions
    /// </summary>
    /// <value>Specifies the duration of the alerting sound to be played for manually answered interactions</value>
    [DataMember(Name = "manualAnswerAlertToneSeconds", EmitDefaultValue = false)]
    public double? ManualAnswerAlertToneSeconds { get; set; }



    /// <summary>
    /// Flag to indicate if auto answer is enabled for the given media type or media subtype.
    /// </summary>
    /// <value>Flag to indicate if auto answer is enabled for the given media type or media subtype.</value>
    [DataMember(Name = "enableAutoAnswer", EmitDefaultValue = false)]
    public bool? EnableAutoAnswer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicQueueMediaSettings {\n");

        sb.Append("  AlertingTimeoutSeconds: ").Append(AlertingTimeoutSeconds).Append("\n");
        sb.Append("  AutoAnswerAlertToneSeconds: ").Append(AutoAnswerAlertToneSeconds).Append("\n");
        sb.Append("  ManualAnswerAlertToneSeconds: ").Append(ManualAnswerAlertToneSeconds).Append("\n");
        sb.Append("  EnableAutoAnswer: ").Append(EnableAutoAnswer).Append("\n");
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
        return this.Equals(obj as QueueConversationVideoEventTopicQueueMediaSettings);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicQueueMediaSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicQueueMediaSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicQueueMediaSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.AlertingTimeoutSeconds == other.AlertingTimeoutSeconds ||
                this.AlertingTimeoutSeconds != null &&
                this.AlertingTimeoutSeconds.Equals(other.AlertingTimeoutSeconds)
            ) &&
            (
                this.AutoAnswerAlertToneSeconds == other.AutoAnswerAlertToneSeconds ||
                this.AutoAnswerAlertToneSeconds != null &&
                this.AutoAnswerAlertToneSeconds.Equals(other.AutoAnswerAlertToneSeconds)
            ) &&
            (
                this.ManualAnswerAlertToneSeconds == other.ManualAnswerAlertToneSeconds ||
                this.ManualAnswerAlertToneSeconds != null &&
                this.ManualAnswerAlertToneSeconds.Equals(other.ManualAnswerAlertToneSeconds)
            ) &&
            (
                this.EnableAutoAnswer == other.EnableAutoAnswer ||
                this.EnableAutoAnswer != null &&
                this.EnableAutoAnswer.Equals(other.EnableAutoAnswer)
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
            if (this.AlertingTimeoutSeconds != null)
            {
                hash = hash * 59 + this.AlertingTimeoutSeconds.GetHashCode();
            }

            if (this.AutoAnswerAlertToneSeconds != null)
            {
                hash = hash * 59 + this.AutoAnswerAlertToneSeconds.GetHashCode();
            }

            if (this.ManualAnswerAlertToneSeconds != null)
            {
                hash = hash * 59 + this.ManualAnswerAlertToneSeconds.GetHashCode();
            }

            if (this.EnableAutoAnswer != null)
            {
                hash = hash * 59 + this.EnableAutoAnswer.GetHashCode();
            }

            return hash;
        }
    }
}
