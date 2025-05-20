using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PersistentConnectionChangeTopicErrorLocation
{
    /// <summary>
    /// Gets or Sets Function
    /// </summary>
    public string Function { get; set; }

    /// <summary>
    /// Gets or Sets FileID
    /// </summary>
    public string FileID { get; set; }

    /// <summary>
    /// Gets or Sets Line
    /// </summary>
    public long? Line { get; set; }
}
