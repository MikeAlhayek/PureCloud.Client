using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PhoneChangeTopicLineStatus
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Reachable
    /// </summary>
    public bool? Reachable { get; set; }

    /// <summary>
    /// Gets or Sets AddressOfRecord
    /// </summary>
    public string AddressOfRecord { get; set; }

    /// <summary>
    /// Gets or Sets ContactAddresses
    /// </summary>
    public IEnumerable<string> ContactAddresses { get; set; }

    /// <summary>
    /// Gets or Sets ReachableStateTime
    /// </summary>
    public DateTime? ReachableStateTime { get; set; }
}
