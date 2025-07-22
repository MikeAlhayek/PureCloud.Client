using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DraftValidationResult
{
    /// <summary>
    /// Indicates if configuration is valid
    /// </summary>
    /// <value>Indicates if configuration is valid</value>
    public bool? Valid { get; set; }

    /// <summary>
    /// List of errors causing validation failure
    /// </summary>
    /// <value>List of errors causing validation failure</value>
    public IEnumerable<ErrorBody> Errors { get; set; }
}
