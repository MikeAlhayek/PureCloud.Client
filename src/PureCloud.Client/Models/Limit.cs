namespace PureCloud.Client.Models;

public sealed class Limit
{
    /// <summary>
    /// Gets or Sets Namespace
    /// </summary>
    public LimitNamespace? Namespace { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    public long? Value { get; set; }
}
