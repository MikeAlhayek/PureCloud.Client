using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CommonRuleBulkUpdateNotificationsRequest
{
    /// <summary>
    /// The user supplied rules ids to be updated
    /// </summary>
    /// <value>The user supplied rules ids to be updated</value>
    public IEnumerable<string> RuleIds { get; set; }

    /// <summary>
    /// The rule properties to be updated
    /// </summary>
    /// <value>The rule properties to be updated</value>
    public ModifiableRuleProperties Properties { get; set; }

    /// <summary>
    /// Collection of alerting notification types to add for all entities in the rules
    /// </summary>
    /// <value>Collection of alerting notification types to add for all entities in the rules</value>
    public IEnumerable<CommonRuleBulkUpdateNotificationsRequestTypesToAddEnum> TypesToAdd { get; set; }

    /// <summary>
    /// Collection of alerting notification types to remove for all entities in the rules
    /// </summary>
    /// <value>Collection of alerting notification types to remove for all entities in the rules</value>
    public IEnumerable<CommonRuleBulkUpdateNotificationsRequestTypesToRemoveEnum> TypesToRemove { get; set; }
}
