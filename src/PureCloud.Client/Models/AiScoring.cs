namespace PureCloud.Client.Models;

public partial class AiScoring
{
    /// <summary>
    /// The type of error that occurred while processing AI scores. It is null where there is no error.
    /// </summary>
    /// <value>The type of error that occurred while processing AI scores. It is null where there is no error.</value>
    public AiScoringFailureType? FailureType { get; set; }

    /// <summary>
    /// Indicates whether AI scoring is currently processing the evaluation.
    /// </summary>
    /// <value>Indicates whether AI scoring is currently processing the evaluation.</value>
    public bool? Pending { get; set; }

    /// <summary>
    /// The date when the AI scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the AI scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateLastChanged { get; set; }
}
