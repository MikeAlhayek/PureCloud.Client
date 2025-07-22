using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BotSlot
{
    /// <summary>
    /// The name of the slot. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace
    /// </summary>
    /// <value>The name of the slot. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
    public string Name { get; set; }

    /// <summary>
    /// The data type of the slot string, integer, decimal, duration, boolean, currency, datetime or the xxxCollection versions of those types
    /// </summary>
    /// <value>The data type of the slot string, integer, decimal, duration, boolean, currency, datetime or the xxxCollection versions of those types</value>
    public string Type { get; set; }
}
