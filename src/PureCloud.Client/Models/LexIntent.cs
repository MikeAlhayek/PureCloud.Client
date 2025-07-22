using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LexIntent
{
    /// <summary>
    /// The intent name
    /// </summary>
    /// <value>The intent name</value>
    public string Name { get; set; }

    /// <summary>
    /// A description of the intent
    /// </summary>
    /// <value>A description of the intent</value>
    public string Description { get; set; }

    /// <summary>
    /// An object mapping slot names to Slot objects
    /// </summary>
    /// <value>An object mapping slot names to Slot objects</value>
    public Dictionary<string, LexSlot> Slots { get; set; }

    /// <summary>
    /// The intent version
    /// </summary>
    /// <value>The intent version</value>
    public string Version { get; set; }
}
