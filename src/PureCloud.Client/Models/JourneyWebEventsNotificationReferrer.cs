using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyWebEventsNotificationReferrer
{
    /// <summary>
    /// Gets or Sets Medium
    /// </summary>
    public JourneyWebEventsNotificationReferrerMediumEnum? Medium { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    public string Domain { get; set; }

    /// <summary>
    /// Gets or Sets Hostname
    /// </summary>
    public string Hostname { get; set; }

    /// <summary>
    /// Gets or Sets Keywords
    /// </summary>
    public string Keywords { get; set; }

    /// <summary>
    /// Gets or Sets Pathname
    /// </summary>
    public string Pathname { get; set; }

    /// <summary>
    /// Gets or Sets QueryString
    /// </summary>
    public string QueryString { get; set; }

    /// <summary>
    /// Gets or Sets Fragment
    /// </summary>
    public string Fragment { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }
}
