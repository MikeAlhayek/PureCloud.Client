using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationMetrics
/// </summary>

public partial class ConversationMetrics : IEquatable<ConversationMetrics>
{
    /// <summary>
    /// The Sentiment Trend Class
    /// </summary>
    /// <value>The Sentiment Trend Class</value>
    
    public enum SentimentTrendClassEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Notcalculated for "NotCalculated"
        /// </summary>
        [EnumMember(Value = "NotCalculated")]
        Notcalculated,

        /// <summary>
        /// Enum Declining for "Declining"
        /// </summary>
        [EnumMember(Value = "Declining")]
        Declining,

        /// <summary>
        /// Enum Slightlydeclining for "SlightlyDeclining"
        /// </summary>
        [EnumMember(Value = "SlightlyDeclining")]
        Slightlydeclining,

        /// <summary>
        /// Enum Nochange for "NoChange"
        /// </summary>
        [EnumMember(Value = "NoChange")]
        Nochange,

        /// <summary>
        /// Enum Slightlyimproving for "SlightlyImproving"
        /// </summary>
        [EnumMember(Value = "SlightlyImproving")]
        Slightlyimproving,

        /// <summary>
        /// Enum Improving for "Improving"
        /// </summary>
        [EnumMember(Value = "Improving")]
        Improving
    }
    /// <summary>
    /// The Sentiment Trend Class
    /// </summary>
    /// <value>The Sentiment Trend Class</value>
    [JsonPropertyName("sentimentTrendClass")]
    public SentimentTrendClassEnum? SentimentTrendClass { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMetrics" /> class.
    /// </summary>
    /// <param name="Conversation">The Conversation Reference.</param>
    /// <param name="SentimentScore">The Sentiment Score.</param>
    /// <param name="SentimentTrend">The Sentiment Trend.</param>
    /// <param name="SentimentTrendClass">The Sentiment Trend Class.</param>
    /// <param name="EmpathyScores">The Empathy Scores.</param>
    /// <param name="ParticipantMetrics">The Participant Metrics.</param>
    public ConversationMetrics(AddressableEntityRef Conversation = null, double? SentimentScore = null, double? SentimentTrend = null, SentimentTrendClassEnum? SentimentTrendClass = null, List<EmpathyScore> EmpathyScores = null, ParticipantMetrics ParticipantMetrics = null)
    {
        this.Conversation = Conversation;
        this.SentimentScore = SentimentScore;
        this.SentimentTrend = SentimentTrend;
        this.SentimentTrendClass = SentimentTrendClass;
        this.EmpathyScores = EmpathyScores;
        this.ParticipantMetrics = ParticipantMetrics;

    }



    /// <summary>
    /// The Conversation Reference
    /// </summary>
    /// <value>The Conversation Reference</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; set; }



    /// <summary>
    /// The Sentiment Score
    /// </summary>
    /// <value>The Sentiment Score</value>
    [JsonPropertyName("sentimentScore")]
    public double? SentimentScore { get; set; }



    /// <summary>
    /// The Sentiment Trend
    /// </summary>
    /// <value>The Sentiment Trend</value>
    [JsonPropertyName("sentimentTrend")]
    public double? SentimentTrend { get; set; }





    /// <summary>
    /// The Empathy Scores
    /// </summary>
    /// <value>The Empathy Scores</value>
    [JsonPropertyName("empathyScores")]
    public List<EmpathyScore> EmpathyScores { get; set; }



    /// <summary>
    /// The Participant Metrics
    /// </summary>
    /// <value>The Participant Metrics</value>
    [JsonPropertyName("participantMetrics")]
    public ParticipantMetrics ParticipantMetrics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationMetrics {\n");

        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  SentimentScore: ").Append(SentimentScore).Append("\n");
        sb.Append("  SentimentTrend: ").Append(SentimentTrend).Append("\n");
        sb.Append("  SentimentTrendClass: ").Append(SentimentTrendClass).Append("\n");
        sb.Append("  EmpathyScores: ").Append(EmpathyScores).Append("\n");
        sb.Append("  ParticipantMetrics: ").Append(ParticipantMetrics).Append("\n");
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
        return Equals(obj as ConversationMetrics);
    }

    /// <summary>
    /// Returns true if ConversationMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                SentimentScore == other.SentimentScore ||
                SentimentScore != null &&
                SentimentScore.Equals(other.SentimentScore)
            ) &&
            (
                SentimentTrend == other.SentimentTrend ||
                SentimentTrend != null &&
                SentimentTrend.Equals(other.SentimentTrend)
            ) &&
            (
                SentimentTrendClass == other.SentimentTrendClass ||
                SentimentTrendClass != null &&
                SentimentTrendClass.Equals(other.SentimentTrendClass)
            ) &&
            (
                EmpathyScores == other.EmpathyScores ||
                EmpathyScores != null &&
                EmpathyScores.SequenceEqual(other.EmpathyScores)
            ) &&
            (
                ParticipantMetrics == other.ParticipantMetrics ||
                ParticipantMetrics != null &&
                ParticipantMetrics.Equals(other.ParticipantMetrics)
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
            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (SentimentScore != null)
            {
                hash = hash * 59 + SentimentScore.GetHashCode();
            }

            if (SentimentTrend != null)
            {
                hash = hash * 59 + SentimentTrend.GetHashCode();
            }

            if (SentimentTrendClass != null)
            {
                hash = hash * 59 + SentimentTrendClass.GetHashCode();
            }

            if (EmpathyScores != null)
            {
                hash = hash * 59 + EmpathyScores.GetHashCode();
            }

            if (ParticipantMetrics != null)
            {
                hash = hash * 59 + ParticipantMetrics.GetHashCode();
            }

            return hash;
        }
    }
}
