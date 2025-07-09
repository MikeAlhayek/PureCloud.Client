using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConfusionDetails
{
    /// <summary>
    /// Confusion details between this utterance and other intents.
    /// </summary>
    /// <value>Confusion details between this utterance and other intents.</value>
    public IEnumerable<ConfusionIntentDetails> Intents { get; set; }
}
