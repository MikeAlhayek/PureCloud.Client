using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CriteriaGroup
{
    /// <summary>
    /// These criteriaItems will be AND&#39;d together to find a match.
    /// </summary>
    /// <value>These criteriaItems will be AND&#39;d together to find a match.</value>
    public IEnumerable<CriteriaItem> And { get; set; }

    /// <summary>
    /// These criteriaItems will be OR&#39;d together to find a match.
    /// </summary>
    /// <value>These criteriaItems will be OR&#39;d together to find a match.</value>
    public IEnumerable<CriteriaItem> Or { get; set; }

    /// <summary>
    /// These criteriaItems must all be false to find a match.
    /// </summary>
    /// <value>These criteriaItems must all be false to find a match.</value>
    public IEnumerable<CriteriaItem> Not { get; set; }

    /// <summary>
    /// A singular critieriaItem to match.
    /// </summary>
    /// <value>A singular critieriaItem to match.</value>
    public CriteriaItem Criteria { get; set; }
}
