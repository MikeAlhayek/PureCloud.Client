namespace PureCloud.Client.Models;

public sealed class Ring
{
    /// <summary>
    /// The conditions that will trigger conversations to move to the next bullseye ring.
    /// </summary>
    /// <value>The conditions that will trigger conversations to move to the next bullseye ring.</value>
    public IEnumerable<ExpansionCriterium> ExpansionCriteria { get; set; }

    /// <summary>
    /// The actions that will be performed just before moving conversations to the next bullseye ring.
    /// </summary>
    /// <value>The actions that will be performed just before moving conversations to the next bullseye ring.</value>
    public Actions Actions { get; set; }

    /// <summary>
    /// The groups of agents associated with the ring, if any.  Ring membership will update to match group membership changes.
    /// </summary>
    /// <value>The groups of agents associated with the ring, if any.  Ring membership will update to match group membership changes.</value>
    public IEnumerable<MemberGroup> MemberGroups { get; set; }
}
