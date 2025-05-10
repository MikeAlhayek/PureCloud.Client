namespace PureCloud.Client.Models;

public sealed class Wrapup
{
    /// <summary>
    /// The user configured wrap up code id.
    /// </summary>
    /// <value>The user configured wrap up code id.</value>
    public string Code { get; set; }

    /// <summary>
    /// The user configured wrap up code name.
    /// </summary>
    /// <value>The user configured wrap up code name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Text entered by the agent to describe the call or disposition.
    /// </summary>
    /// <value>Text entered by the agent to describe the call or disposition.</value>
    public string Notes { get; set; }

    /// <summary>
    /// List of tags selected by the agent to describe the call or disposition.
    /// </summary>
    /// <value>List of tags selected by the agent to describe the call or disposition.</value>
    public IEnumerable<string> Tags { get; set; }

    /// <summary>
    /// The length of time in seconds that the agent spent doing after call work.
    /// </summary>
    /// <value>The length of time in seconds that the agent spent doing after call work.</value>
    public int? DurationSeconds { get; set; }

    /// <summary>
    /// The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when the wrapup was finished. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later.
    /// </summary>
    /// <value>Indicates if this is a pending save and should not require a code to be specified.  This allows someone to save some temporary wrapup that will be used later.</value>
    public bool? Provisional { get; set; }
}
