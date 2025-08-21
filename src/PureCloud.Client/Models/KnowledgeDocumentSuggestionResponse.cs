namespace PureCloud.Client.Models;

/// <summary>
/// Knowledge Document Suggestion Response
/// </summary>
public sealed class KnowledgeDocumentSuggestionResponse
{
    /// <summary>
    /// Query
    /// </summary>
    public string Query { get; set; }

    /// <summary>
    /// Suggestions
    /// </summary>
    public IEnumerable<KnowledgeDocumentSuggestion> Suggestions { get; set; }

    /// <summary>
    /// Session ID for guest users
    /// </summary>
    public string SessionId { get; set; }
}