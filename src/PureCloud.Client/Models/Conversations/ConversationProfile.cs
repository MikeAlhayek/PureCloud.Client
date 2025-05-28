using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationProfile
{
    /// <summary>
    /// The language code supported by the conversation profile belonging to a particular project for Dialogflow.
    /// </summary>
    /// <value>The language code supported by the conversation profile belonging to a particular project for Dialogflow.</value>
    public ConversationProfileLanguageCodeEnum? LanguageCode { get; set; }

    /// <summary>
    /// The name of the conversation profile belonging to a particular project for Dialogflow
    /// </summary>
    /// <value>The name of the conversation profile belonging to a particular project for Dialogflow</value>
    public string Name { get; set; }
}
