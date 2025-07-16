using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyGeolocation
{
    /// <summary>
    /// Geolocation&#39;s ISO 3166-1 alpha-2 country code.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Geolocation&#39;s country name.
    /// </summary>
    /// <value>Geolocation&#39;s country name.</value>
    public string CountryName { get; set; }

    /// <summary>
    /// Geolocation&#39;s latitude.
    /// </summary>
    /// <value>Geolocation&#39;s latitude.</value>
    public double? Latitude { get; set; }

    /// <summary>
    /// Geolocation&#39;s longitude.
    /// </summary>
    /// <value>Geolocation&#39;s longitude.</value>
    public double? Longitude { get; set; }

    /// <summary>
    /// Geolocation&#39;s locality or city.
    /// </summary>
    /// <value>Geolocation&#39;s locality or city.</value>
    public string Locality { get; set; }

    /// <summary>
    /// Geolocation&#39;s postal code or ZIP code.
    /// </summary>
    /// <value>Geolocation&#39;s postal code or ZIP code.</value>
    public string PostalCode { get; set; }

    /// <summary>
    /// Geolocation&#39;s ISO-3166-2 region code.
    /// </summary>
    /// <value>Geolocation&#39;s ISO-3166-2 region code.</value>
    public string Region { get; set; }

    /// <summary>
    /// Geolocation&#39;s region name.
    /// </summary>
    /// <value>Geolocation&#39;s region name.</value>
    public string RegionName { get; set; }

    /// <summary>
    /// The source that was used to determine the geolocation information.
    /// </summary>
    /// <value>The source that was used to determine the geolocation information.</value>
    public string Source { get; set; }

    /// <summary>
    /// Geolocation&#39;s timezone.
    /// </summary>
    /// <value>Geolocation&#39;s timezone.</value>
    public string Timezone { get; set; }
}
