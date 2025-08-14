namespace PureCloud.Client.Models;

/// <summary>
/// EventDefinitionAggregates
/// </summary>
public sealed class EventDefinitionAggregates
{
    /// <summary>
    /// Event definition.
    /// </summary>
    public AddressableEntityRef EventDefinition { get; set; }

    /// <summary>
    /// How many events have occurred.
    /// </summary>
    public int? EventCount { get; set; }
}
