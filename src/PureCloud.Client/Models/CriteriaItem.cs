using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CriteriaItem
{
    /// <summary>
    /// The id of the criteria to be checked.
    /// </summary>
    /// <value>The id of the criteria to be checked.</value>
    public CriteriaItemKeyEnum? Key { get; set; }
    /// <summary>
    /// The operator used to check on the criteria id.
    /// </summary>
    /// <value>The operator used to check on the criteria id.</value>
    public CriteriaItemOperatorEnum? Operator { get; set; }

    /// <summary>
    /// The target value used to query on.
    /// </summary>
    /// <value>The target value used to query on.</value>
    public string Value { get; set; }
}
