using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PropertyChange
{
    /// <summary>
    /// The property that was changed
    /// </summary>
    /// <value>The property that was changed</value>
    public string Property { get; set; }

    /// <summary>
    /// Previous values for the property.
    /// </summary>
    public IEnumerable<string> OldValues { get; set; }

    /// <summary>
    /// New values for the property.
    /// </summary>
    /// <value>New values for the property.</value>
    public IEnumerable<string> NewValues { get; set; }
}
