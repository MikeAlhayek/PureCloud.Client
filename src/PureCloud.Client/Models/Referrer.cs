using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Referrer
{
    /// <summary>
    /// Type of referrer (e.g. search, social).
    /// </summary>
    /// <value>Type of referrer (e.g. search, social).</value>
    public ReferrerMediumEnum? Medium { get; set; }

    /// <summary>
    /// Referrer URL.
    /// </summary>
    /// <value>Referrer URL.</value>
    public string Url { get; set; }

    /// <summary>
    /// Referrer URL domain.
    /// </summary>
    /// <value>Referrer URL domain.</value>
    public string Domain { get; set; }

    /// <summary>
    /// Referrer URL hostname.
    /// </summary>
    /// <value>Referrer URL hostname.</value>
    public string Hostname { get; set; }

    /// <summary>
    /// Referrer keywords.
    /// </summary>
    /// <value>Referrer keywords.</value>
    public string Keywords { get; set; }

    /// <summary>
    /// Referrer URL pathname.
    /// </summary>
    /// <value>Referrer URL pathname.</value>
    public string Pathname { get; set; }

    /// <summary>
    /// Referrer URL querystring.
    /// </summary>
    /// <value>Referrer URL querystring.</value>
    public string QueryString { get; set; }

    /// <summary>
    /// Referrer URL fragment.
    /// </summary>
    /// <value>Referrer URL fragment.</value>
    public string Fragment { get; set; }

    /// <summary>
    /// Name of referrer (e.g. Yahoo!, Google, InfoSpace).
    /// </summary>
    /// <value>Name of referrer (e.g. Yahoo!, Google, InfoSpace).</value>
    public string Name { get; set; }
}
