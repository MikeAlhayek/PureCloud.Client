namespace PureCloud.Client.Models;

public sealed class VisibilityCondition
{
    /// <summary>
    /// Gets or Sets CombiningOperation
    /// </summary>
    public VisibilityConditionCombiningOperation? CombiningOperation { get; set; }

    /// <summary>
    /// A list of strings, each representing the location in the form of the Answer Option to depend on. In the format of \&quot;/form/questionGroup/{questionGroupIndex}/question/{questionIndex}/answer/{answerIndex}\&quot; or, to assume the current question group, \&quot;../question/{questionIndex}/answer/{answerIndex}\&quot;. Note: Indexes are zero-based
    /// </summary>
    /// <value>A list of strings, each representing the location in the form of the Answer Option to depend on. In the format of \&quot;/form/questionGroup/{questionGroupIndex}/question/{questionIndex}/answer/{answerIndex}\&quot; or, to assume the current question group, \&quot;../question/{questionIndex}/answer/{answerIndex}\&quot;. Note: Indexes are zero-based</value>
    public IEnumerable<object> Predicates { get; set; }
}
