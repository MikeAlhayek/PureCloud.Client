using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentLocation
{
    /// <summary>
    /// URL of the Location.
    /// </summary>
    /// <value>URL of the Location.</value>
    public string Url { get; set; }

    /// <summary>
    /// Location postal address.
    /// </summary>
    /// <value>Location postal address.</value>
    public string Address { get; set; }

    /// <summary>
    /// Location name.
    /// </summary>
    /// <value>Location name.</value>
    public string Text { get; set; }

    /// <summary>
    /// Latitude of the location.
    /// </summary>
    /// <value>Latitude of the location.</value>
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude of the location.
    /// </summary>
    /// <value>Longitude of the location.</value>
    public double? Longitude { get; set; }
}
