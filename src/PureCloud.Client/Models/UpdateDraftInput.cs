using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UpdateDraftInput
{
    /// <summary>
    /// Category of action, Can be up to 256 characters long
    /// </summary>
    /// <value>Category of action, Can be up to 256 characters long</value>
    public string Category { get; set; }

    /// <summary>
    /// Name of action, Can be up to 256 characters long
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Configuration to support request and response processing
    /// </summary>
    /// <value>Configuration to support request and response processing</value>
    public ActionConfig Config { get; set; }

    /// <summary>
    /// Action contract
    /// </summary>
    public ActionContractInput Contract { get; set; }

    /// <summary>
    /// Indication of whether or not the action is designed to accept sensitive data
    /// </summary>
    /// <value>Indication of whether or not the action is designed to accept sensitive data</value>
    public bool? Secure { get; set; }

    /// <summary>
    /// Version of current Draft
    /// </summary>
    /// <value>Version of current Draft</value>
    public int? Version { get; set; }
}
