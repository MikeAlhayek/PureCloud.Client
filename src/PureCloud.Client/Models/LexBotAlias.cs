using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LexBotAlias
{
    /// <summary>
    /// The status of the Lex bot alias
    /// </summary>
    /// <value>The status of the Lex bot alias</value>
    public LexBotAliasStatusEnum? Status { get; set; }

    /// <summary>
    /// The target language of the Lex bot
    /// </summary>
    /// <value>The target language of the Lex bot</value>
    public LexBotAliasLanguageEnum? Language { get; set; }

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
    /// The Lex bot this is an alias for
    /// </summary>
    /// <value>The Lex bot this is an alias for</value>
    public LexBot Bot { get; set; }

    /// <summary>
    /// The version of the Lex bot this alias points at
    /// </summary>
    /// <value>The version of the Lex bot this alias points at</value>
    public string BotVersion { get; set; }

    /// <summary>
    /// If the status is FAILED, Amazon Lex explains why it failed to build the bot
    /// </summary>
    /// <value>If the status is FAILED, Amazon Lex explains why it failed to build the bot</value>
    public string FailureReason { get; set; }

    /// <summary>
    /// An array of Intents associated with this bot alias
    /// </summary>
    /// <value>An array of Intents associated with this bot alias</value>
    public IEnumerable<LexIntent> Intents { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
