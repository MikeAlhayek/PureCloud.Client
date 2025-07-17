using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestsFinalizeRequest
{
    /// <summary>
    /// The Contest finalization status
    /// </summary>
    /// <value>The Contest finalization status</value>
    public ContestsFinalizeRequestStatusEnum? Status { get; set; }

    /// <summary>
    /// The Contest finalization winners
    /// </summary>
    /// <value>The Contest finalization winners</value>
    public IEnumerable<ContestWinnersRequest> Winners { get; set; }

    /// <summary>
    /// The Contest finalization disqualified agents
    /// </summary>
    /// <value>The Contest finalization disqualified agents</value>
    public IEnumerable<ContestDisqualifiedAgents> DisqualifiedAgents { get; set; }
}
