using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CsvJobRequest
{
    /// <summary>
    /// Upload for the csv job
    /// </summary>
    /// <value>Upload for the csv job</value>
    public string UploadId { get; set; }

    /// <summary>
    /// Settings for the csv job
    /// </summary>
    /// <value>Settings for the csv job</value>
    public string SettingsId { get; set; }
}
