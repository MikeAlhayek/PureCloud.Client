using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotIntent
{
    /// <summary>
    /// The name of this intent.  This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace
    /// </summary>
    /// <value>The name of this intent.  This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
    public string Name { get; set; }

    /// <summary>
    /// Optional returned data values associated with this intent, limit of 50.
    /// </summary>
    /// <value>Optional returned data values associated with this intent, limit of 50.</value>
    public Dictionary<string, BotSlot> Slots { get; set; }
}
