using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LexSlot
{
    /// <summary>
    /// The slot name
    /// </summary>
    /// <value>The slot name</value>
    public string Name { get; set; }

    /// <summary>
    /// The slot description
    /// </summary>
    /// <value>The slot description</value>
    public string Description { get; set; }

    /// <summary>
    /// The slot type
    /// </summary>
    /// <value>The slot type</value>
    public string Type { get; set; }

    /// <summary>
    /// The priority of the slot
    /// </summary>
    /// <value>The priority of the slot</value>
    public int? Priority { get; set; }
}
