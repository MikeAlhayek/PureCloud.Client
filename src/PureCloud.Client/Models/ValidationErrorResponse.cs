using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ValidationErrorResponse
{
    /// <summary>
    /// Message string of the validation error.
    /// </summary>
    /// <value>Message string of the validation error.</value>
    public string Message { get; set; }

    /// <summary>
    /// Type of validation errror.
    /// </summary>
    /// <value>Type of validation errror.</value>
    public string ErrorType { get; set; }

    /// <summary>
    /// Map of argument names to corresponding values. Used for localization.
    /// </summary>
    /// <value>Map of argument names to corresponding values. Used for localization.</value>
    public Dictionary<string, string> Arguments { get; set; }
}
