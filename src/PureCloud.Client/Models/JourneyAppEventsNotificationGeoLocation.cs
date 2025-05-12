using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyAppEventsNotificationGeoLocation
{
    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets CountryName
    /// </summary>
    public string CountryName { get; set; }

    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    public double? Longitude { get; set; }

    /// <summary>
    /// Gets or Sets Locality
    /// </summary>
    public string Locality { get; set; }

    /// <summary>
    /// Gets or Sets PostalCode
    /// </summary>
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    public string Region { get; set; }

    /// <summary>
    /// Gets or Sets RegionName
    /// </summary>
    public string RegionName { get; set; }

    /// <summary>
    /// Gets or Sets Timezone
    /// </summary>
    public string Timezone { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    public string Source { get; set; }
}
