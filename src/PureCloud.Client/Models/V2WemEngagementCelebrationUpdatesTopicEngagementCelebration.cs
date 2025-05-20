using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2WemEngagementCelebrationUpdatesTopicEngagementCelebration
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public V2WemEngagementCelebrationUpdatesTopicEngagementCelebrationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Recipient
    /// </summary>
    public V2WemEngagementCelebrationUpdatesTopicUserId Recipient { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public V2WemEngagementCelebrationUpdatesTopicUserId CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public string DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Note
    public string Note { get; set; }

    /// <summary>
    /// Gets or Sets SourceEntity
    /// </summary>
    public V2WemEngagementCelebrationUpdatesTopicSourceEntity SourceEntity { get; set; }
}
