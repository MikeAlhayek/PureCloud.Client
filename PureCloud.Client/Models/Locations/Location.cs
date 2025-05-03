namespace PureCloud.Client.Models.Locations;

public sealed class Location
{
    /// <summary>
    /// Unique identifier for the location
    /// </summary>
    /// <value>Unique identifier for the location</value>
    public string Id { get; set; }

    /// <summary>
    /// Unique identifier for the location floorplan image
    /// </summary>
    /// <value>Unique identifier for the location floorplan image</value>
    public string FloorplanId { get; set; }

    /// <summary>
    /// Users coordinates on the floorplan. Only used when floorplanImage is set
    /// </summary>
    /// <value>Users coordinates on the floorplan. Only used when floorplanImage is set</value>
    public Dictionary<string, double?> Coordinates { get; set; }

    /// <summary>
    /// Optional description on the users location
    /// </summary>
    /// <value>Optional description on the users location</value>
    public string Notes { get; set; }

    /// <summary>
    /// Gets or Sets LocationDefinition
    /// </summary>
    public LocationDefinition LocationDefinition { get; set; }
}
