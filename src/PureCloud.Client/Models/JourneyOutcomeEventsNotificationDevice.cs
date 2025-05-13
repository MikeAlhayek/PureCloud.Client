using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;
public sealed class JourneyOutcomeEventsNotificationDevice
{
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    public JourneyOutcomeEventsNotificationDeviceCategoryEnum? Category { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets IsMobile
    /// </summary>
    public bool? IsMobile { get; set; }

    /// <summary>
    /// Gets or Sets ScreenHeight
    /// </summary>
    public long? ScreenHeight { get; set; }

    /// <summary>
    /// Gets or Sets ScreenWidth
    /// </summary>
    public long? ScreenWidth { get; set; }

    /// <summary>
    /// Gets or Sets ScreenDensity
    /// </summary>
    public long? ScreenDensity { get; set; }

    /// <summary>
    /// Gets or Sets Fingerprint
    /// </summary>
    public string Fingerprint { get; set; }

    /// <summary>
    /// Gets or Sets OsFamily
    /// </summary>
    public string OsFamily { get; set; }

    /// <summary>
    /// Gets or Sets OsVersion
    /// </summary>
    public string OsVersion { get; set; }

    /// <summary>
    /// Gets or Sets Manufacturer
    /// </summary>
    public string Manufacturer { get; set; }
}
