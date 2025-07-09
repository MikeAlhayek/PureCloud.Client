using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AuthorizationSettings
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Boolean showing if organization is opted in or not to unused role/perm analysis
    /// </summary>
    /// <value>Boolean showing if organization is opted in or not to unused role/perm analysis</value>
    public bool? AnalysisEnabled { get; set; }

    /// <summary>
    /// Integer number of days to analyze user usage
    /// </summary>
    /// <value>Integer number of days to analyze user usage</value>
    public int? AnalysisDays { get; set; }

    /// <summary>
    /// The date and time of the most recent unused role calculation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time of the most recent unused role calculation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateLastCalculated { get; set; }

    /// <summary>
    /// The date of the most recent org activity used for analysis. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date of the most recent org activity used for analysis. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateLastActive { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
