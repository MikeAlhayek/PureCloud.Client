using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmMoveAgentsCompleteTopicWfmMoveAgentData
{
    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    public WfmMoveAgentsCompleteTopicWfmMoveAgentDataResultEnum? Result { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public WfmMoveAgentsCompleteTopicUserReference User { get; set; }
}
