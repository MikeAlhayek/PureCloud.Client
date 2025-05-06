using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuditTopicPropertyChange
{
    /// <summary>
    /// Gets or Sets Property
    /// </summary>
    public string Property { get; set; }


    /// <summary>
    /// Gets or Sets OldValues
    /// </summary>
    public IEnumerable<string> OldValues { get; set; }


    /// <summary>
    /// Gets or Sets NewValues
    /// </summary>
    public IEnumerable<string> NewValues { get; set; }
}
