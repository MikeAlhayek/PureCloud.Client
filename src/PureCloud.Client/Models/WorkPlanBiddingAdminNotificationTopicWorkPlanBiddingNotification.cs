using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets AgentRankingType
    /// </summary>
    public WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotificationAgentRankingTypeEnum? AgentRankingType { get; set; }

    /// <summary>
    /// Gets or Sets RankingTiebreakerType
    /// </summary>
    public WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotificationRankingTiebreakerTypeEnum? RankingTiebreakerType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets BuId
    /// </summary>
    public string BuId { get; set; }

    /// <summary>
    /// Gets or Sets BidWindowStartDate
    /// </summary>
    public string BidWindowStartDate { get; set; }

    /// <summary>
    /// Gets or Sets BidWindowEndDate
    /// </summary>
    public string BidWindowEndDate { get; set; }

    /// <summary>
    /// Gets or Sets EffectiveDate
    /// </summary>
    public string EffectiveDate { get; set; }

    /// <summary>
    /// Gets or Sets WorkPlanFieldsVisibleToAgents
    /// </summary>
    public IEnumerable<WorkPlanBiddingAdminNotificationTopicWorkPlanBiddingNotificationWorkPlanFieldsVisibleToAgents> WorkPlanFieldsVisibleToAgents { get; set; }

}
