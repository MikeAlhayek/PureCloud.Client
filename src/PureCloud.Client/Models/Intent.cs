using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Intent
{
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }
}
