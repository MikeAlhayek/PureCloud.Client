using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CsvUploadRequest
{
    /// <summary>
    /// Name of the file to upload
    /// </summary>
    /// <value>Name of the file to upload</value>
    public string FileName { get; set; }

    /// <summary>
    /// The size of the upload file
    /// </summary>
    /// <value>The size of the upload file</value>
    public long? FileSize { get; set; }
}
