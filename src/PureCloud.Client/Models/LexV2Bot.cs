using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LexV2Bot
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
    /// Lex V2 bot Id
    /// </summary>
    /// <value>Lex V2 bot Id</value>
    public string BotId { get; set; }

    /// <summary>
    /// A region of the Lex V2 bot
    /// </summary>
    /// <value>A region of the Lex V2 bot</value>
    public string Region { get; set; }

    /// <summary>
    /// A description of the Lex V2 bot
    /// </summary>
    /// <value>A description of the Lex V2 bot</value>
    public string Description { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
