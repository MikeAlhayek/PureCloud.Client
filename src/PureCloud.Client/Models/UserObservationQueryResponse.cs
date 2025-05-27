using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserObservationQueryResponse
{
    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public IEnumerable<UserObservationDataContainer> Results { get; set; }
}
