using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestCompleteData
{
    /// <summary>
    /// Anonymization of the contest
    /// </summary>
    /// <value>Anonymization of the contest</value>
    public ContestCompleteDataAnonymizationEnum? Anonymization { get; set; }

    /// <summary>
    /// End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEnd { get; set; }

    /// <summary>
    /// Metrics of the contest
    /// </summary>
    /// <value>Metrics of the contest</value>
    public IEnumerable<ContestDataMetrics> Metrics { get; set; }

    /// <summary>
    /// Prizes of the contest
    /// </summary>
    /// <value>Prizes of the contest</value>
    public IEnumerable<ContestDataPrizes> Prizes { get; set; }

    /// <summary>
    /// Winners of the contest
    /// </summary>
    /// <value>Winners of the contest</value>
    public IEnumerable<ContestDataWinners> Winners { get; set; }
}
