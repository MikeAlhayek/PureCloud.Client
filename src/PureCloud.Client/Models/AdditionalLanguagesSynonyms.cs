using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AdditionalLanguagesSynonyms
{
    /// <summary>
    /// Synonyms for additional language
    /// </summary>
    /// <value>Synonyms for additional language</value>
    public IEnumerable<string> Synonyms { get; set; }
}
