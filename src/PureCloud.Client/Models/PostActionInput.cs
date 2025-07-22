using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PostActionInput
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
    /// The ID of the integration this action is associated to
    /// </summary>
    /// <value>The ID of the integration this action is associated to</value>
    public string IntegrationId { get; set; }

    /// <summary>
    /// Configuration to support request and response processing
    /// </summary>
    /// <value>Configuration to support request and response processing</value>
    public ActionConfig Config { get; set; }

    /// <summary>
    /// Action contract
    /// </summary>
    /// <value>Action contract</value>
    public ActionContractInput Contract { get; set; }

    /// <summary>
    /// Indication of whether or not the action is designed to accept sensitive data
    /// </summary>
    /// <value>Indication of whether or not the action is designed to accept sensitive data</value>
    public bool? Secure { get; set; }
}
