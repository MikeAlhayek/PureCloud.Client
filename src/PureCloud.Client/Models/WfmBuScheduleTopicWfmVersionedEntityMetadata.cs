using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuScheduleTopicWfmVersionedEntityMetadata
{
    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public long? Version { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public WfmBuScheduleTopicUserReference ModifiedBy { get; set; }

    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    public DateTime? DateModified { get; set; }
}
