namespace PureCloud.Client.Models;

public sealed class Bullseye
{
    /// <summary>
    /// The bullseye rings configured for this queue.
    /// </summary>
    /// <value>The bullseye rings configured for this queue.</value>
    public IEnumerable<Ring> Rings { get; set; }
}
