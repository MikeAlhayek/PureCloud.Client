using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReplaceResponse
{
    /// <summary>
    /// Gets or Sets UploadMethod
    /// </summary>
    public ReplaceResponseUploadMethodEnum? UploadMethod { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ChangeNumber
    /// </summary>
    public int? ChangeNumber { get; set; }

    /// <summary>
    /// Gets or Sets UploadStatus
    /// </summary>
    public DomainEntityRef UploadStatus { get; set; }

    /// <summary>
    /// Gets or Sets UploadDestinationUri
    /// </summary>
    public string UploadDestinationUri { get; set; }
}
