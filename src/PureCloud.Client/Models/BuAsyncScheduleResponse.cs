using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BuAsyncScheduleResponse
{
    /// <summary>
    /// The status of the operation
    /// </summary>
    /// <value>The status of the operation</value>
    public BuAsyncScheduleResponseStatus? Status { get; set; }

    /// <summary>
    /// The ID for the operation
    /// </summary>
    /// <value>The ID for the operation</value>
    public string OperationId { get; set; }

    /// <summary>
    /// The result of the operation.  Null unless status == Complete
    /// </summary>
    /// <value>The result of the operation.  Null unless status == Complete</value>
    public BuScheduleMetadata Result { get; set; }
}
