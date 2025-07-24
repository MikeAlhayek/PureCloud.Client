namespace PureCloud.Client.Models;

/// <summary>
/// ConversationMetrics
/// </summary>
public sealed class ConversationMetrics
{
    /// <summary>
    /// The Conversation Reference
    /// </summary>
    /// <value>The Conversation Reference</value>
    public AddressableEntityRef Conversation { get; set; }

    /// <summary>
    /// The Sentiment Score
    /// </summary>
    /// <value>The Sentiment Score</value>
    public double? SentimentScore { get; set; }

    /// <summary>
    /// The Sentiment Trend
    /// </summary>
    /// <value>The Sentiment Trend</value>
    public double? SentimentTrend { get; set; }

    /// <summary>
    /// The Sentiment Trend Class
    /// </summary>
    /// <value>The Sentiment Trend Class</value>
    public ConversationMetricsSentimentTrendClass? SentimentTrendClass { get; set; }

    /// <summary>
    /// The Empathy Scores
    /// </summary>
    /// <value>The Empathy Scores</value>
    public IEnumerable<EmpathyScore> EmpathyScores { get; set; }

    /// <summary>
    /// The Participant Metrics
    /// </summary>
    /// <value>The Participant Metrics</value>
    public ParticipantMetrics ParticipantMetrics { get; set; }
}