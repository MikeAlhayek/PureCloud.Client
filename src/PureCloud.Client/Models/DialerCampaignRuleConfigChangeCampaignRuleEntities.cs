using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignRuleConfigChangeCampaignRuleEntities
{
    /// <summary>
    /// A list of campaignIds to act on
    /// </summary>
    /// <value>A list of campaignIds to act on</value>
    public IEnumerable<DialerCampaignRuleConfigChangeUriReference> Campaigns { get; set; }

    /// <summary>
    /// A list of sequenceIds to act on
    /// </summary>
    /// <value>A list of sequenceIds to act on</value>
    public IEnumerable<DialerCampaignRuleConfigChangeUriReference> Sequences { get; set; }
}
