using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LexV2Intent
{
    /// <summary>
    /// The intent name
    /// </summary>
    /// <value>The intent name</value>
    public string IntentName { get; set; }

    /// <summary>
    /// A description of the intent
    /// </summary>
    /// <value>A description of the intent</value>
    public string Description { get; set; }

    /// <summary>
    /// An object mapping slot names to Slot objects
    /// </summary>
    /// <value>An object mapping slot names to Slot objects</value>
    public Dictionary<string, LexV2Slot> Slots { get; set; }

    /// <summary>
    /// The intent id
    /// </summary>
    /// <value>The intent id</value>
    public string IntentId { get; set; }
}
