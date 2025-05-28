using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class KnowledgeSuggestionConfig
{
    /// <summary>
    /// The name of vendor used for knowledge suggestions.
    /// </summary>
    /// <value>The name of vendor used for knowledge suggestions.</value>
    public KnowledgeSuggestionConfigVendorNameEnum? VendorName { get; set; }

    /// <summary>
    /// The ID of knowledge base to query when Genesys is the knowledge suggestions provider.
    /// </summary>
    /// <value>The ID of knowledge base to query when Genesys is the knowledge suggestions provider.</value>
    public KnowledgeBaseReference KnowledgeBase { get; set; }

    /// <summary>
    /// The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider.
    /// </summary>
    /// <value>The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider.</value>
    public IEnumerable<KnowledgeBaseWithDialectReference> KnowledgeBases { get; set; }
}
