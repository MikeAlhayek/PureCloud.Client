using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Ticker
{
    /// <summary>
    /// The ticker symbol for this organization. Example: ININ, AAPL, MSFT, etc.
    /// </summary>
    /// <value>The ticker symbol for this organization. Example: ININ, AAPL, MSFT, etc.</value>
    public string Symbol { get; set; }

    /// <summary>
    /// The exchange for this ticker symbol. Examples: NYSE, FTSE, NASDAQ, etc.
    /// </summary>
    /// <value>The exchange for this ticker symbol. Examples: NYSE, FTSE, NASDAQ, etc.</value>
    public string Exchange { get; set; }
}
