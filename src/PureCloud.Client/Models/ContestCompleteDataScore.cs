using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContestCompleteDataScore
{
    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    public double? Score { get; set; }
}
