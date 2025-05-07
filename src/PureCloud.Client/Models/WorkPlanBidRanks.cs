namespace PureCloud.Client.Models;

public sealed class WorkPlanBidRanks
{
    /// <summary>
    /// The globally unique identifier for the user.
    /// </summary>
    /// <value>The globally unique identifier for the user.</value>
    public string Id { get; set; }

    /// <summary>
    /// Work plan bidding agent performance ranking. The range of values is between 0 and 9999.
    /// </summary>
    /// <value>Work plan bidding agent performance ranking. The range of values is between 0 and 9999.</value>
    public int? WorkPlanBiddingPerformance { get; set; }

    /// <summary>
    /// Custom agent ranking metric that some customers can use.
    /// </summary>
    /// <value>Custom agent ranking metric that some customers can use.</value>
    public string BiddingTieBreaker { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
