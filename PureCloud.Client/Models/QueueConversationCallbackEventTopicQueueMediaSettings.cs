using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCallbackEventTopicQueueMediaSettings
/// </summary>
[DataContract]
public partial class QueueConversationCallbackEventTopicQueueMediaSettings : IEquatable<QueueConversationCallbackEventTopicQueueMediaSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCallbackEventTopicQueueMediaSettings" /> class.
    /// </summary>
    /// <param name="AlertingTimeoutSeconds">Specifies how long the agent has to answer an interaction before being marked as not responding..</param>
    /// <param name="AutoAnswerAlertToneSeconds">Specifies the duration of the alerting sound to be played for auto answered interactions..</param>
    /// <param name="ManualAnswerAlertToneSeconds">Specifies the duration of the alerting sound to be played for manually answered interactions.</param>
    /// <param name="EnableAutoAnswer">Flag to indicate if auto answer is enabled for the given media type or media subtype..</param>
    public QueueConversationCallbackEventTopicQueueMediaSettings(long? AlertingTimeoutSeconds = null, double? AutoAnswerAlertToneSeconds = null, double? ManualAnswerAlertToneSeconds = null, bool? EnableAutoAnswer = null)
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
        sb.Append("class QueueConversationCallbackEventTopicQueueMediaSettings {\n");

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
        return Equals(obj as QueueConversationCallbackEventTopicQueueMediaSettings);
    }

    /// <summary>
    /// Returns true if QueueConversationCallbackEventTopicQueueMediaSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCallbackEventTopicQueueMediaSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCallbackEventTopicQueueMediaSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AlertingTimeoutSeconds == other.AlertingTimeoutSeconds ||
                AlertingTimeoutSeconds != null &&
                AlertingTimeoutSeconds.Equals(other.AlertingTimeoutSeconds)
            ) &&
            (
                AutoAnswerAlertToneSeconds == other.AutoAnswerAlertToneSeconds ||
                AutoAnswerAlertToneSeconds != null &&
                AutoAnswerAlertToneSeconds.Equals(other.AutoAnswerAlertToneSeconds)
            ) &&
            (
                ManualAnswerAlertToneSeconds == other.ManualAnswerAlertToneSeconds ||
                ManualAnswerAlertToneSeconds != null &&
                ManualAnswerAlertToneSeconds.Equals(other.ManualAnswerAlertToneSeconds)
            ) &&
            (
                EnableAutoAnswer == other.EnableAutoAnswer ||
                EnableAutoAnswer != null &&
                EnableAutoAnswer.Equals(other.EnableAutoAnswer)
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
            if (AlertingTimeoutSeconds != null)
            {
                hash = hash * 59 + AlertingTimeoutSeconds.GetHashCode();
            }

            if (AutoAnswerAlertToneSeconds != null)
            {
                hash = hash * 59 + AutoAnswerAlertToneSeconds.GetHashCode();
            }

            if (ManualAnswerAlertToneSeconds != null)
            {
                hash = hash * 59 + ManualAnswerAlertToneSeconds.GetHashCode();
            }

            if (EnableAutoAnswer != null)
            {
                hash = hash * 59 + EnableAutoAnswer.GetHashCode();
            }

            return hash;
        }
    }
}
