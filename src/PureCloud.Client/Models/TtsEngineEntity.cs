using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TtsEngineEntity
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
    /// The set of languages the TTS engine supports
    /// </summary>
    /// <value>The set of languages the TTS engine supports</value>
    public IEnumerable<string> Languages { get; set; }

    /// <summary>
    /// The set of output formats the TTS engine can produce
    /// </summary>
    /// <value>The set of output formats the TTS engine can produce</value>
    public IEnumerable<string> OutputFormats { get; set; }

    /// <summary>
    /// The set of voices the TTS engine supports
    /// </summary>
    /// <value>The set of voices the TTS engine supports</value>
    public IEnumerable<TtsVoiceEntity> Voices { get; set; }

    /// <summary>
    /// The TTS engine is the global default engine
    /// </summary>
    /// <value>The TTS engine is the global default engine</value>
    public bool? IsDefault { get; set; }

    /// <summary>
    /// The TTS engine can be used in a secure call flow
    /// </summary>
    /// <value>The TTS engine can be used in a secure call flow</value>
    public bool? IsSecure { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
