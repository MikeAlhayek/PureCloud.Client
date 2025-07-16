using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CsvUploadResponse
{
    /// <summary>
    /// Id of the upload
    /// </summary>
    /// <value>Id of the upload</value>
    public string UploadId { get; set; }

    /// <summary>
    /// Url for the upload
    /// </summary>
    /// <value>Url for the upload</value>
    public string UploadUrl { get; set; }

    /// <summary>
    /// Required headers for the upload
    /// </summary>
    /// <value>Required headers for the upload</value>
    public IEnumerable<Header> UploadHeaders { get; set; }
}
