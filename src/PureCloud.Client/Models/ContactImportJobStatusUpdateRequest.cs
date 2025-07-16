using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactImportJobStatusUpdateRequest
{
    /// <summary>
    /// Workflow status
    /// </summary>
    /// <value>Workflow status</value>
    public ContactImportJobStatusUpdateRequestStatusEnum? Status { get; set; }

    /// <summary>
    /// Job Id
    /// </summary>
    /// <value>Job Id</value>
    public string JobId { get; set; }
}
