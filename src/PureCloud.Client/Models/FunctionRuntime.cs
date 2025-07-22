using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FunctionRuntime
{
    /// <summary>
    /// Availability status of runtime
    /// </summary>
    /// <value>Availability status of runtime</value>
    public FunctionRuntimeStatusEnum? Status { get; set; }

    /// <summary>
    /// Name of the function runtime.
    /// </summary>
    /// <value>Name of the function runtime.</value>
    public string Name { get; set; }

    /// <summary>
    /// Description of function runtime.
    /// </summary>
    /// <value>Description of function runtime.</value>
    public string Description { get; set; }

    /// <summary>
    /// Optional end of life date. Present if the status is Deprecated. Date represents when support for runtime can no longer be guaranteed. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Optional end of life date. Present if the status is Deprecated. Date represents when support for runtime can no longer be guaranteed. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEndOfLife { get; set; }
}
