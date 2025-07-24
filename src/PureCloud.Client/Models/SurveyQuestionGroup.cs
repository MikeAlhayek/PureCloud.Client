using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyQuestionGroup
/// </summary>
public sealed class SurveyQuestionGroup
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets NaEnabled
    /// </summary>
    public bool? NaEnabled { get; set; }

    /// <summary>
    /// Gets or Sets Questions
    /// </summary>
    public IEnumerable<SurveyQuestion> Questions { get; set; }

    /// <summary>
    /// Gets or Sets VisibilityCondition
    /// </summary>
    public VisibilityCondition VisibilityCondition { get; set; }
}
