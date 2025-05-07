using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Models;

public sealed class Geolocation
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A string used to describe the type of client the geolocation is being updated from e.g. ios, android, web, etc.
    /// </summary>
    /// <value>A string used to describe the type of client the geolocation is being updated from e.g. ios, android, web, etc.</value>
    public string Type { get; set; }

    /// <summary>
    /// A boolean used to tell whether or not to set this geolocation client as the primary on a PATCH
    /// </summary>
    /// <value>A boolean used to tell whether or not to set this geolocation client as the primary on a PATCH</value>
    public bool? Primary { get; set; }

    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    public double? Longitude { get; set; }

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

    /// <summary>
    /// Gets or Sets Locations
    /// </summary>
    public IEnumerable<LocationDefinition> Locations { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
