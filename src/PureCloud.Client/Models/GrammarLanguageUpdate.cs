using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GrammarLanguageUpdate
{
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
}
