using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UpdateActionInput
{
    /// <summary>
    /// Category of action, Can be up to 256 characters long
    /// </summary>
    /// <value>Category of action, Can be up to 256 characters long</value>
    public string Category { get; set; }

    /// <summary>
    /// Name of action, Can be up to 256 characters long
    /// </summary>
    /// <value>Name of action, Can be up to 256 characters long</value>
    public string Name { get; set; }

    /// <summary>
    /// Configuration to support request and response processing
    /// </summary>
    /// <value>Configuration to support request and response processing</value>
    public ActionConfig Config { get; set; }

    /// <summary>
    /// Version of this action
    /// </summary>
    /// <value>Version of this action</value>
    public int? Version { get; set; }
}
