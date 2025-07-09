using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConfusionInfo
{
    /// <summary>
    /// Confusion details between this utterance and other intents.
    /// </summary>
    /// <value>Confusion details between this utterance and other intents.</value>
    public IEnumerable<ConfusionIntentInfo> Intents { get; set; }
}
