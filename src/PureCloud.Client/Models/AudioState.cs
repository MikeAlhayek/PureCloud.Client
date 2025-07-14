using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AudioState
{
    /// <summary>
    /// Indicates that this communication&#39;s audio allows its participant to hear others.
    /// </summary>
    /// <value>Indicates that this communication&#39;s audio allows its participant to hear others.</value>
    public bool? CanHear { get; set; }

    /// <summary>
    /// Indicates that this communication&#39;s audio allows others to hear this participant.
    /// </summary>
    /// <value>Indicates that this communication&#39;s audio allows others to hear this participant.</value>
    public bool? CanSpeak { get; set; }
}
