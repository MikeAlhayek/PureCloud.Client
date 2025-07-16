using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyCampaign
{
    /// <summary>
    /// Differentiate ads or links that point to the same URL (e.g. textlink).
    /// </summary>
    /// <value>Differentiate ads or links that point to the same URL (e.g. textlink).</value>
    public string Content { get; set; }

    /// <summary>
    /// Identify a medium such as email or cost-per-click (e.g. CPC).
    /// </summary>
    /// <value>Identify a medium such as email or cost-per-click (e.g. CPC).</value>
    public string Medium { get; set; }

    /// <summary>
    /// Identify a specific product promotion or strategic campaign (e.g. 320banner).
    /// </summary>
    /// <value>Identify a specific product promotion or strategic campaign (e.g. 320banner).</value>
    public string Name { get; set; }

    /// <summary>
    /// Identify a search engine, newsletter name, or other source (e.g. Google).
    /// </summary>
    /// <value>Identify a search engine, newsletter name, or other source (e.g. Google).</value>
    public string Source { get; set; }

    /// <summary>
    /// Note the keywords for this ad (e.g. running+shoes).
    /// </summary>
    /// <value>Note the keywords for this ad (e.g. running+shoes).</value>
    public string Term { get; set; }

    /// <summary>
    /// The click ID (unique number that is generated when a potential customer clicks on an affiliate link).
    /// </summary>
    /// <value>The click ID (unique number that is generated when a potential customer clicks on an affiliate link).</value>
    public string ClickId { get; set; }

    /// <summary>
    /// The ad network to which the click ID belongs.
    /// </summary>
    /// <value>The ad network to which the click ID belongs.</value>
    public string Network { get; set; }
}
