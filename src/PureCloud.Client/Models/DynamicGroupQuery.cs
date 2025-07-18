using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DynamicGroupQuery
{
    /// <summary>
    /// The skill conditions that need to be used for this dynamic group
    /// </summary>
    /// <value>The skill conditions that need to be used for this dynamic group</value>
    public IEnumerable<DynamicGroupSkillCondition> SkillConditions { get; set; }
}
