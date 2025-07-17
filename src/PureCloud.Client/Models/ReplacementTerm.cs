using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReplacementTerm
{
    /// <summary>
    /// Social Handle Type
    /// </summary>
    /// <value>Social Handle Type</value>
    public ReplacementTermTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets ExistingValue
    /// </summary>
    public string ExistingValue { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedValue
    /// </summary>
    public string UpdatedValue { get; set; }
}
