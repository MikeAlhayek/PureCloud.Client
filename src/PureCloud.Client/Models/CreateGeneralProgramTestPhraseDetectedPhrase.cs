using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateGeneralProgramTestPhraseDetectedPhrase
{
    /// <summary>
    /// Gets or Sets FoundPhrase
    /// </summary>
    public string FoundPhrase { get; set; }

    /// <summary>
    /// Gets or Sets Snippet
    /// </summary>
    public string Snippet { get; set; }

    /// <summary>
    /// Gets or Sets Confidence
    /// </summary>
    public long? Confidence { get; set; }
}
