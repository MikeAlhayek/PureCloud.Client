using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TtsVoiceEntity
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
    /// The gender of the TTS voice
    /// </summary>
    /// <value>The gender of the TTS voice</value>
    public string Gender { get; set; }

    /// <summary>
    /// The language supported by the TTS voice
    /// </summary>
    /// <value>The language supported by the TTS voice</value>
    public string Language { get; set; }

    /// <summary>
    /// Ths TTS engine this voice belongs to
    /// </summary>
    /// <value>Ths TTS engine this voice belongs to</value>
    public TtsEngineEntity Engine { get; set; }

    /// <summary>
    /// The voice is the default voice for its language
    /// </summary>
    /// <value>The voice is the default voice for its language</value>
    public bool? IsDefault { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
