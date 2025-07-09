using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GrammarFileUploadRequest
{
    /// <summary>
    /// Gets or Sets FileType
    /// </summary>
    public GrammarFileUploadRequestFileTypeEnum? FileType { get; set; }
}
