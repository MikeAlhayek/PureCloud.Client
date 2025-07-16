using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ValidationResult
{
    /// <summary>
    /// Separator valid in the upload
    /// </summary>
    /// <value>Separator valid in the upload</value>
    public bool? SeparatorValid { get; set; }

    /// <summary>
    /// File encoding valid for the upload
    /// </summary>
    /// <value>File encoding valid for the upload</value>
    public bool? FileEncodingValid { get; set; }

    /// <summary>
    /// List of errors for the upload
    /// </summary>
    /// <value>List of errors for the upload</value>
    public IEnumerable<ValidationError> Errors { get; set; }
}
