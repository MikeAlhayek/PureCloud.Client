using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceBot
{
    /// <summary>
    /// Nuance bot Id
    /// </summary>
    /// <value>Nuance bot Id</value>
    public string Id { get; set; }

    /// <summary>
    /// Nuance bot name
    /// </summary>
    /// <value>Nuance bot name</value>
    public string Name { get; set; }

    /// <summary>
    /// The Integration Id for this bot
    /// </summary>
    /// <value>The Integration Id for this bot</value>
    public string IntegrationId { get; set; }

    /// <summary>
    /// The Nuance Organization for this bot
    /// </summary>
    /// <value>The Nuance Organization for this bot</value>
    public NuanceOrganization NuanceOrganization { get; set; }

    /// <summary>
    /// The Application for this bot
    /// </summary>
    /// <value>The Application for this bot</value>
    public NuanceApplication Application { get; set; }

    /// <summary>
    /// The environment of the Nuance bot
    /// </summary>
    /// <value>The environment of the Nuance bot</value>
    public NuanceEnvironment NuanceEnvironment { get; set; }

    /// <summary>
    /// The Geography of the Nuance bot
    /// </summary>
    /// <value>The Geography of the Nuance bot</value>
    public NuanceGeography Geography { get; set; }

    /// <summary>
    /// client ID/Secret objects for the credentials that execute this Nuance bot
    /// </summary>
    /// <value>client ID/Secret objects for the credentials that execute this Nuance bot</value>
    public IEnumerable<NuanceBotCredentials> Credentials { get; set; }

    /// <summary>
    /// List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value
    /// </summary>
    /// <value>List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value</value>
    public IEnumerable<NuanceBotVariable> Variables { get; set; }

    /// <summary>
    /// List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value
    /// </summary>
    /// <value>List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value</value>
    public IEnumerable<NuanceBotTransferNode> TransferNodes { get; set; }

    /// <summary>
    /// List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39;
    /// </summary>
    /// <value>List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39;</value>
    public IEnumerable<string> Locales { get; set; }

    /// <summary>
    /// List of channels associated with this Nuance bot.
    /// </summary>
    /// <value>List of channels associated with this Nuance bot.</value>
    public IEnumerable<NuanceChannel> Channels { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
