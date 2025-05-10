using PureCloud.Client.Models.Queues;
using PureCloud.Client.Models.Teams;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public partial class DomainResourceConditionValue
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public DomainResourceConditionValueType? Type { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public Queue Queue { get; set; }

    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    public Team Team { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public string Value { get; set; }
}
