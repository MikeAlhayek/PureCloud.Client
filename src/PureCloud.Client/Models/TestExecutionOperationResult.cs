using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TestExecutionOperationResult
{
    /// <summary>
    /// The step number to indicate the order in which the operation was performed
    /// </summary>
    /// <value>The step number to indicate the order in which the operation was performed</value>
    public int? Step { get; set; }

    /// <summary>
    /// Name of the operation performed
    /// </summary>
    /// <value>Name of the operation performed</value>
    public string Name { get; set; }

    /// <summary>
    /// Indicated whether or not the operation was successful
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// The result of the operation
    /// </summary>
    /// <value>The result of the operation</value>
    public object Result { get; set; }

    /// <summary>
    /// Error that occurred during the operation
    /// </summary>
    /// <value>Error that occurred during the operation</value>
    public ErrorBody Error { get; set; }
}
