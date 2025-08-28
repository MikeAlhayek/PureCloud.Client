using System.ComponentModel.DataAnnotations;

namespace PureCloud.Client.Models;

/// <summary>
/// Synchronize Job
/// </summary>
public sealed class SynchronizeJob
{
    /// <summary>
    /// The job ID
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Job status
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Source configuration
    /// </summary>
    public object Source { get; set; }

    /// <summary>
    /// Date created
    /// </summary>
    public DateTimeOffset? DateCreated { get; set; }

    /// <summary>
    /// Date modified
    /// </summary>
    public DateTimeOffset? DateModified { get; set; }

    /// <summary>
    /// Error information
    /// </summary>
    public ErrorBody ErrorInformation { get; set; }

    /// <summary>
    /// Knowledge base ID
    /// </summary>
    public string KnowledgeBaseId { get; set; }
}