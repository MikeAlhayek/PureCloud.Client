using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TranscriptTopics
{
    /// <summary>
    /// List of topics which need to be included in exact match criteria. This field is not mutually exclusive with excludes topic list.
    /// </summary>
    /// <value>List of topics which need to be included in exact match criteria. This field is not mutually exclusive with excludes topic list.</value>
    public IEnumerable<string> Includes { get; set; }

    /// <summary>
    /// List of topics which need to be excluded in exact match criteria. This field is not mutually exclusive with includes topic list.
    /// </summary>
    /// <value>List of topics which need to be excluded in exact match criteria. This field is not mutually exclusive with includes topic list.</value>
    public IEnumerable<string> Excludes { get; set; }
}
