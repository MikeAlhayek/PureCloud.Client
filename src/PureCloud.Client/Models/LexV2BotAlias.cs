using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LexV2BotAlias
{
    /// <summary>
    /// The status of the Lex V2 bot alias
    /// </summary>
    /// <value>The status of the Lex V2 bot alias</value>
    public LexV2BotAliasStatusEnum? Status { get; set; }

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
    /// The Lex V2 bot region
    /// </summary>
    /// <value>The Lex V2 bot region</value>
    public string Region { get; set; }

    /// <summary>
    /// The Lex V2 bot alias Id
    /// </summary>
    /// <value>The Lex V2 bot alias Id</value>
    public string AliasId { get; set; }

    /// <summary>
    /// The Lex V2 bot this is an alias for
    /// </summary>
    /// <value>The Lex V2 bot this is an alias for</value>
    public LexV2Bot Bot { get; set; }

    /// <summary>
    /// The version of the Lex V2 bot this alias points at
    /// </summary>
    /// <value>The version of the Lex V2 bot this alias points at</value>
    public string BotVersion { get; set; }

    /// <summary>
    /// The target language of the Lex V2 bot
    /// </summary>
    /// <value>The target language of the Lex V2 bot</value>
    public string Language { get; set; }

    /// <summary>
    /// An array of Intents associated with this bot alias
    /// </summary>
    /// <value>An array of Intents associated with this bot alias</value>
    public IEnumerable<LexV2Intent> Intents { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
