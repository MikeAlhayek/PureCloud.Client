using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CsvUploadPreviewResponse
{
    /// <summary>
    /// Id for the upload
    /// </summary>
    /// <value>Id for the upload</value>
    public string UploadId { get; set; }

    /// <summary>
    /// List of headers in the CSV
    /// </summary>
    /// <value>List of headers in the CSV</value>
    public IEnumerable<string> Headers { get; set; }

    /// <summary>
    /// List of entries in the CSV
    /// </summary>
    /// <value>List of entries in the CSV</value>
    public IEnumerable<IEnumerable<string>> Entries { get; set; }
}
