using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReportingTurnAction
{
    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    public ReportingTurnActionActionTypeEnum? ActionType { get; set; }

    /// <summary>
    /// The ID of the action in the bot flow.
    /// </summary>
    /// <value>The ID of the action in the bot flow.</value>
    public string ActionId { get; set; }

    /// <summary>
    /// The name of the action in the bot flow.
    /// </summary>
    /// <value>The name of the action in the bot flow.</value>
    public string ActionName { get; set; }

    /// <summary>
    /// The number of the action in the bot flow.
    /// </summary>
    /// <value>The number of the action in the bot flow.</value>
    public int? ActionNumber { get; set; }
}
