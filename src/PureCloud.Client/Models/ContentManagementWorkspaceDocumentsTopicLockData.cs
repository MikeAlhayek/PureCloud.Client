using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentManagementWorkspaceDocumentsTopicLockData
{
    /// <summary>
    /// Gets or Sets LockedBy
    /// </summary>
    public ContentManagementWorkspaceDocumentsTopicUserData LockedBy { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateExpires
    /// </summary>
    public DateTime? DateExpires { get; set; }
}
