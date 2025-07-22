using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Function
{
    /// <summary>
    /// Function identifier.
    /// </summary>
    /// <value>Function identifier.</value>
    public string Id { get; set; }

    /// <summary>
    /// Function name. This is automatically created based on the Action Id.
    /// </summary>
    /// <value>Function name. This is automatically created based on the Action Id.</value>
    public string Name { get; set; }

    /// <summary>
    /// Description of the function. Limit 255 characters.
    /// </summary>
    /// <value>Description of the function. Limit 255 characters.</value>
    public string Description { get; set; }

    /// <summary>
    /// Date and time function was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time function was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Zip file identifier.
    /// </summary>
    /// <value>Zip file identifier.</value>
    public string ZipId { get; set; }

    /// <summary>
    /// Handler entry point into zip file to execute function. Should be path within upload function package to the invocation module without language extension, followed by a period and then exported invocation method name. e.g. &#39;src/index.handler&#39;
    /// </summary>
    /// <value>Handler entry point into zip file to execute function. Should be path within upload function package to the invocation module without language extension, followed by a period and then exported invocation method name. e.g. &#39;src/index.handler&#39;</value>
    public string Handler { get; set; }

    /// <summary>
    /// Runtime required for execution. Valid runtimes change over time as versions are deprecated. Use /api/v2/integrations/actions/functions/runtimes for current list.
    /// </summary>
    /// <value>Runtime required for execution. Valid runtimes change over time as versions are deprecated. Use /api/v2/integrations/actions/functions/runtimes for current list.</value>
    public string Runtime { get; set; }

    /// <summary>
    /// Execution timeout to apply to function. Value is in seconds. Range allowed 1 to 15. Default value 15 seconds.
    /// </summary>
    /// <value>Execution timeout to apply to function. Value is in seconds. Range allowed 1 to 15. Default value 15 seconds.</value>
    public int? TimeoutSeconds { get; set; }
}
