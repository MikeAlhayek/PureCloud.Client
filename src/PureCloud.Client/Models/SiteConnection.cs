using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SiteConnection
{
    /// <summary>
    /// Connection method from site to site (Direct, Indirect, CloudProxy
    /// </summary>
    /// <value>Connection method from site to site (Direct, Indirect, CloudProxy</value>
    public SiteConnectionTypeEnum? Type { get; set; }

    /// <summary>
    /// Media model for the current site.
    /// </summary>
    /// <value>Media model for the current site.</value>
    public SiteConnectionMediaModelEnum? MediaModel { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets Managed
    /// </summary>
    public bool? Managed { get; set; }

    /// <summary>
    /// Indicates if the current site is linked
    /// </summary>
    /// <value>Indicates if the current site is linked</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// All of the edges to which the site connects
    /// </summary>
    /// <value>All of the edges to which the site connects</value>
    public IEnumerable<ConnectedEdge> EdgeList { get; set; }

    /// <summary>
    /// The core site
    /// </summary>
    /// <value>The core site</value>
    public bool? CoreSite { get; set; }

    /// <summary>
    /// List of site ids names and selfUris for the primary core sites
    /// </summary>
    /// <value>List of site ids names and selfUris for the primary core sites</value>
    public IEnumerable<DomainEntityRef> PrimaryCoreSites { get; set; }

    /// <summary>
    /// List of site ids names and selfUris for the secondary core sites
    /// </summary>
    /// <value>List of site ids names and selfUris for the secondary core sites</value>
    public IEnumerable<DomainEntityRef> SecondaryCoreSites { get; set; }
}
