using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutlierInfo
{
    /// <summary>
    /// Boolean to identify if an outlier or not.
    /// </summary>
    /// <value>Boolean to identify if an outlier or not.</value>
    public bool? Outlier { get; set; }

    /// <summary>
    /// Outlier score for this utterance. The score is always 0 or greater and higher the score, the more outlier.
    /// </summary>
    /// <value>Outlier score for this utterance. The score is always 0 or greater and higher the score, the more outlier.</value>
    public float? Score { get; set; }
}
