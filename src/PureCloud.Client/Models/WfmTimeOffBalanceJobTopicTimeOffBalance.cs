using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmTimeOffBalanceJobTopicTimeOffBalance
{
    /// <summary>
    /// Gets or Sets ActivityCodeId
    /// </summary>
    public string ActivityCodeId { get; set; }

    /// <summary>
    /// Gets or Sets HrisTimeOffTypeId
    /// </summary>
    public string HrisTimeOffTypeId { get; set; }

    /// <summary>
    /// Gets or Sets HrisTimeOffTypeSecondaryId
    /// </summary>
    public string HrisTimeOffTypeSecondaryId { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets BalanceMinutesPerDay
    /// </summary>
    public IEnumerable<long?> BalanceMinutesPerDay { get; set; }
}
