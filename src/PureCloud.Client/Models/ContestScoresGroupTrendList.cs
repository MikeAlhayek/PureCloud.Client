using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestScoresGroupTrendList
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ContestScoresGroupTrend> Entities { get; set; }
}
