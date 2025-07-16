using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactImportJobStatusUpdateResponse
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public ContactImportJobStatusUpdateResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets JobId
    /// </summary>
    public string JobId { get; set; }
}
