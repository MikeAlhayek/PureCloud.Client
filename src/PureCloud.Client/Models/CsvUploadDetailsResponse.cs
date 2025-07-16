using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CsvUploadDetailsResponse
{
    /// <summary>
    /// Id for the upload
    /// </summary>
    /// <value>Id for the upload</value>
    public string UploadId { get; set; }

    /// <summary>
    /// File name for the upload
    /// </summary>
    /// <value>File name for the upload</value>
    public string FileName { get; set; }

    /// <summary>
    /// Validation for the upload
    /// </summary>
    /// <value>Validation for the upload</value>
    public ValidationResult ValidationResult { get; set; }
}
