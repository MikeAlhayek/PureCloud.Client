using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotChannel
{
    /// <summary>
    /// The name of the channel.
    /// </summary>
    /// <value>The name of the channel.</value>
    public BotChannelNameEnum? Name { get; set; }

    /// <summary>
    /// The input modes for the channel.
    /// </summary>
    /// <value>The input modes for the channel.</value>
    public IEnumerable<BotChannelInputModesEnum> InputModes { get; set; }

    /// <summary>
    /// The output modes for the channel.
    /// </summary>
    /// <value>The output modes for the channel.</value>
    public IEnumerable<BotChannelOutputModesEnum> OutputModes { get; set; }

    /// <summary>
    /// Information about the end user agent calling the bot flow.
    /// </summary>
    /// <value>Information about the end user agent calling the bot flow.</value>
    public TextBotUserAgent UserAgent { get; set; }
}
