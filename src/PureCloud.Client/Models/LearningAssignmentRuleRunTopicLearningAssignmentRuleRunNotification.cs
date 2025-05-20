using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<LearningAssignmentRuleRunTopicLearningAssignmentsCreated> Entities { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }
}
