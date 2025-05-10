namespace PureCloud.Client.Models;

public sealed class QuestionGroupSettings
{
    /// <summary>
    /// The context id of the question group in the form.
    /// </summary>
    /// <value>The context id of the question group in the form.</value>
    public string QuestionGroupContextId { get; set; }

    /// <summary>
    /// Gets or Sets QuestionSettings
    /// </summary>
    public IEnumerable<QuestionSettings> QuestionSettings { get; set; }
}
