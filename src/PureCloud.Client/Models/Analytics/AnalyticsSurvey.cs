namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsSurvey
{
    /// <summary>
    /// The type of the survey
    /// </summary>
    /// <value>The type of the survey</value>
    public AnalyticsSurveySurveyType? SurveyType { get; set; }

    /// <summary>
    /// Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EventTime { get; set; }

    /// <summary>
    /// The ID of the associated queue
    /// </summary>
    /// <value>The ID of the associated queue</value>
    public string QueueId { get; set; }

    /// <summary>
    /// Completion datetime of the survey in ISO 8601 format
    /// </summary>
    /// <value>Completion datetime of the survey in ISO 8601 format</value>
    public DateTime? SurveyCompletedDate { get; set; }

    /// <summary>
    /// Unique identifier for the survey form, regardless of version
    /// </summary>
    /// <value>Unique identifier for the survey form, regardless of version</value>
    public string SurveyFormContextId { get; set; }

    /// <summary>
    /// ID of the survey form used
    /// </summary>
    /// <value>ID of the survey form used</value>
    public string SurveyFormId { get; set; }

    /// <summary>
    /// Name of the survey form used
    /// </summary>
    /// <value>Name of the survey form used</value>
    public string SurveyFormName { get; set; }

    /// <summary>
    /// ID of the survey
    /// </summary>
    /// <value>ID of the survey</value>
    public string SurveyId { get; set; }

    /// <summary>
    /// Whether the survey was completed with any required questions unanswered.
    /// </summary>
    /// <value>Whether the survey was completed with any required questions unanswered.</value>
    public bool? SurveyPartialResponse { get; set; }

    /// <summary>
    /// Score of the survey used with NPS
    /// </summary>
    /// <value>Score of the survey used with NPS</value>
    public int? SurveyPromoterScore { get; set; }

    /// <summary>
    /// The status of the survey
    /// </summary>
    /// <value>The status of the survey</value>
    public string SurveyStatus { get; set; }

    /// <summary>
    /// ID of the agent the survey was performed against
    /// </summary>
    /// <value>ID of the agent the survey was performed against</value>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets OSurveyTotalScore
    /// </summary>
    public long? OSurveyTotalScore { get; set; }
}
