using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GrammarLanguage
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The ID of the grammar associated with this grammar language
    /// </summary>
    /// <value>The ID of the grammar associated with this grammar language</value>
    public string GrammarId { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    public string Language { get; set; }

    /// <summary>
    /// The URL to the voice mode file associated with this grammar language
    /// </summary>
    /// <value>The URL to the voice mode file associated with this grammar language</value>
    public string VoiceFileUrl { get; set; }

    /// <summary>
    /// The URL to the DTMF mode file associated with this grammar language
    /// </summary>
    /// <value>The URL to the DTMF mode file associated with this grammar language</value>
    public string DtmfFileUrl { get; set; }

    /// <summary>
    /// Additional information about the associated voice file
    /// </summary>
    /// <value>Additional information about the associated voice file</value>
    public GrammarLanguageFileMetadata VoiceFileMetadata { get; set; }

    /// <summary>
    /// Additional information about the associated dtmf file
    /// </summary>
    /// <value>Additional information about the associated dtmf file</value>
    public GrammarLanguageFileMetadata DtmfFileMetadata { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
