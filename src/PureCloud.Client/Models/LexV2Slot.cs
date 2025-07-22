using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LexV2Slot
{
    /// <summary>
    /// The slot name
    /// </summary>
    /// <value>The slot name</value>
    public string SlotName { get; set; }

    /// <summary>
    /// The slot description
    /// </summary>
    /// <value>The slot description</value>
    public string Description { get; set; }

    /// <summary>
    /// The slot id
    /// </summary>
    /// <value>The slot id</value>
    public string SlotId { get; set; }

    /// <summary>
    /// The slot type
    /// </summary>
    /// <value>The slot type</value>
    public string Type { get; set; }

    /// <summary>
    /// The slot type id
    /// </summary>
    /// <value>The slot type id</value>
    public string SlotTypeId { get; set; }
}
