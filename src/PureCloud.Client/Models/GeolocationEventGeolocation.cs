using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GeolocationEventGeolocation
{
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    public string Region { get; set; }

    /// <summary>
    /// Gets or Sets City
    /// </summary>
    public string City { get; set; }
}
