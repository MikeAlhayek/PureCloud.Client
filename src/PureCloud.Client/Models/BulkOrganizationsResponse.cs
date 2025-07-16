using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkOrganizationsResponse
{
    /// <summary>
    /// A list of results for all of the Bulk operations specified in the request. Includes both successes and failures. Ordering is NOT guaranteed - may be in a different order from the request.
    /// </summary>
    /// <value>A list of results for all of the Bulk operations specified in the request. Includes both successes and failures. Ordering is NOT guaranteed - may be in a different order from the request.</value>
    public IEnumerable<BulkResponseResultExternalOrganizationExternalOrganizationBulkEntityErrorExternalOrganization> Results { get; set; }

    /// <summary>
    /// The number of failed operations in the results.
    /// </summary>
    /// <value>The number of failed operations in the results.</value>
    public int? ErrorCount { get; set; }

    /// <summary>
    /// The indexes of all failed operations in the results field.
    /// </summary>
    /// <value>The indexes of all failed operations in the results field.</value>
    public IEnumerable<int?> ErrorIndexes { get; set; }
}
