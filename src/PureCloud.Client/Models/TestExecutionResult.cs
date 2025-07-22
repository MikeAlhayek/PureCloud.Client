using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TestExecutionResult
{
    /// <summary>
    /// Execution operations performed as part of the test
    /// </summary>
    /// <value>Execution operations performed as part of the test</value>
    public IEnumerable<TestExecutionOperationResult> Operations { get; set; }

    /// <summary>
    /// The final error encountered during the test that resulted in test failure
    /// </summary>
    /// <value>The final error encountered during the test that resulted in test failure</value>
    public ErrorBody Error { get; set; }

    /// <summary>
    /// The final result of the test. This is the response that would be returned during normal action execution
    /// </summary>
    /// <value>The final result of the test. This is the response that would be returned during normal action execution</value>
    public object FinalResult { get; set; }

    /// <summary>
    /// Indicates whether or not the test was a success
    /// </summary>
    /// <value>Indicates whether or not the test was a success</value>
    public bool? Success { get; set; }
}
