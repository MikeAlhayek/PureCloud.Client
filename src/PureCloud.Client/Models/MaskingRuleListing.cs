using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MaskingRuleListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<MaskingRule> Entities { get; set; }
}
