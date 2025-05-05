namespace PureCloud.Client.Models.Locations;

public sealed class LocationEmergencyNumber
{
    /// <summary>
    /// The type of emergency number.
    /// </summary>
    /// <value>The type of emergency number.</value>
    public LocationEmergencyNumberType? Type { get; set; }

    /// <summary>
    /// Gets or Sets E164
    /// </summary>
    public string E164 { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    public string Number { get; set; }
}
