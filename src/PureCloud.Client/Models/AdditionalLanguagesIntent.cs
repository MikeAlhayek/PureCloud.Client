using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AdditionalLanguagesIntent
{
    /// <summary>
    /// ID of the intent for respective additional language
    /// </summary>
    /// <value>ID of the intent for respective additional language</value>
    public string Id { get; set; }

    /// <summary>
    /// Utterances list for additional language
    /// </summary>
    public IEnumerable<NluUtterance> Utterances { get; set; }
}
