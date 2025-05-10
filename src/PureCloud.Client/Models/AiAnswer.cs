namespace PureCloud.Client.Models;

public sealed class AiAnswer
{
    /// <summary>
    /// Describes the type of error associated with the AI answer.
    /// </summary>
    /// <value>Describes the type of error associated with the AI answer.</value>
    public AiAnswerFailureType? FailureType { get; set; }

    /// <summary>
    /// The unique identifier of the suggested AI answer.
    /// </summary>
    /// <value>The unique identifier of the suggested AI answer.</value>
    public string AnswerId { get; set; }

    /// <summary>
    /// An explanation providing the reasoning behind the suggested answer.
    /// </summary>
    /// <value>An explanation providing the reasoning behind the suggested answer.</value>
    public string Explanation { get; set; }
}
