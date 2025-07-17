using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserProfilesInDateRangeRequest
{
    /// <summary>
    /// Start work day in ISO-8601 format used in the date range.
    /// </summary>
    /// <value>Start work day in ISO-8601 format used in the date range.</value>
    public string StartWorkday { get; set; }

    /// <summary>
    /// End work day in ISO-8601 format used in the date range.
    /// </summary>
    /// <value>End work day in ISO-8601 format used in the date range.</value>
    public string EndWorkday { get; set; }
}
