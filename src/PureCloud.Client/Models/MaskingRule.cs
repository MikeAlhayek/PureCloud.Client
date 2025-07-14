using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MaskingRule
{
    /// <summary>
    /// Masking rule type
    /// </summary>
    /// <value>Masking rule type</value>
    public MaskingRuleTypeEnum? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Masking rule name.
    /// </summary>
    /// <value>Masking rule name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Description about masking rule.
    /// </summary>
    /// <value>Description about masking rule.</value>
    public string Description { get; set; }

    /// <summary>
    /// Replacement character for masked text character.
    /// </summary>
    /// <value>Replacement character for masked text character.</value>
    public string SubstituteCharacter { get; set; }

    /// <summary>
    /// Definition of masking rule (a valid regex or builtin AI based mask name).
    /// </summary>
    /// <value>Definition of masking rule (a valid regex or builtin AI based mask name).</value>
    public string Definition { get; set; }

    /// <summary>
    /// True/False
    /// </summary>
    /// <value>True/False</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Associated integration channels
    /// </summary>
    /// <value>Associated integration channels</value>
    public IEnumerable<string> Integrations { get; set; }

    /// <summary>
    /// Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date when the rule was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the rule was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }
}
