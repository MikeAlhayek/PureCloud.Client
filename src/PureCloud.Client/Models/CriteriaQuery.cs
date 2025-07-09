using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CriteriaQuery
{
    /// <summary>
    /// A list of CriteriaGroups which will be AND&#39;d together to generate a result set.
    /// </summary>
    /// <value>A list of CriteriaGroups which will be AND&#39;d together to generate a result set.</value>
    public IEnumerable<CriteriaGroup> Query { get; set; }
}
