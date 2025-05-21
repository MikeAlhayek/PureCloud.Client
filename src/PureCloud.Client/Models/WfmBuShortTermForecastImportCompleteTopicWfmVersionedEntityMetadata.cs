using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata
{
    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public long? Version { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public WfmBuShortTermForecastImportCompleteTopicUserReference ModifiedBy { get; set; }

    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    public DateTime? DateModified { get; set; }
}
