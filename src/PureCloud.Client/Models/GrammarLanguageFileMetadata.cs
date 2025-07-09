using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GrammarLanguageFileMetadata
{
    /// <summary>
    /// The extension of the file
    /// </summary>
    /// <value>The extension of the file</value>
    public GrammarLanguageFileMetadataFileTypeEnum? FileType { get; set; }

    /// <summary>
    /// The name of the file as defined by the user
    /// </summary>
    /// <value>The name of the file as defined by the user</value>
    public string FileName { get; set; }

    /// <summary>
    /// The size of the file in bytes
    /// </summary>
    /// <value>The size of the file in bytes</value>
    public int? FileSizeBytes { get; set; }

    /// <summary>
    /// The date the file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateUploaded { get; set; }
}
