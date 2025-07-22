using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialogflowCXAgent
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
    /// The project this Dialogflow CX agent belongs to.
    /// </summary>
    /// <value>The project this Dialogflow CX agent belongs to.</value>
    public DialogflowCXProject Project { get; set; }

    /// <summary>
    /// The supported languages of the Dialogflow CX agent.  Each value will be a language code in the country-locale format. e.g. en-us, es-us, fr-ca, etc.
    /// </summary>
    /// <value>The supported languages of the Dialogflow CX agent.  Each value will be a language code in the country-locale format. e.g. en-us, es-us, fr-ca, etc.</value>
    public IEnumerable<string> Languages { get; set; }

    /// <summary>
    /// Available environments for this CX agent.
    /// </summary>
    public IEnumerable<DialogflowCXEnvironment> Environments { get; set; }

    /// <summary>
    /// The Integration this Dialogflow CX agent was referenced from.
    /// </summary>
    /// <value>The Integration this Dialogflow CX agent was referenced from.</value>
    public DomainEntityRef Integration { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
