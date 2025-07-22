using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialogflowAgent
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The project this Dialogflow agent belongs to
    /// </summary>
    /// <value>The project this Dialogflow agent belongs to</value>
    public DialogflowProject Project { get; set; }

    /// <summary>
    /// The supported languages of the Dialogflow agent
    /// </summary>
    /// <value>The supported languages of the Dialogflow agent</value>
    public IEnumerable<string> Languages { get; set; }

    /// <summary>
    /// An array of Intents associated with this agent
    /// </summary>
    /// <value>An array of Intents associated with this agent</value>
    public IEnumerable<DialogflowIntent> Intents { get; set; }

    /// <summary>
    /// Available environments for this agent
    /// </summary>
    /// <value>Available environments for this agent</value>
    public IEnumerable<string> Environments { get; set; }

    /// <summary>
    /// The Integration this Dialogflow agent was referenced from.
    /// </summary>
    /// <value>The Integration this Dialogflow agent was referenced from.</value>
    public DomainEntityRef Integration { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
