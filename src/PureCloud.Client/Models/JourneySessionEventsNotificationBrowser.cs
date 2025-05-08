using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneySessionEventsNotificationBrowser
{
    /// <summary>
    /// Gets or Sets Family
    /// </summary>
    public string Family { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets Lang
    /// </summary>
    public string Lang { get; set; }

    /// <summary>
    /// Gets or Sets Fingerprint
    /// </summary>
    public string Fingerprint { get; set; }

    /// <summary>
    /// Gets or Sets ViewHeight
    /// </summary>
    public long? ViewHeight { get; set; }

    /// <summary>
    /// Gets or Sets ViewWidth
    /// </summary>
    public long? ViewWidth { get; set; }

    /// <summary>
    /// Gets or Sets FeaturesFlash
    /// </summary>
    public bool? FeaturesFlash { get; set; }

    /// <summary>
    /// Gets or Sets FeaturesJava
    /// </summary>
    public bool? FeaturesJava { get; set; }

    /// <summary>
    /// Gets or Sets FeaturesPdf
    /// </summary>
    public bool? FeaturesPdf { get; set; }

    /// <summary>
    /// Gets or Sets FeaturesWebrtc
    /// </summary>
    public bool? FeaturesWebrtc { get; set; }
}
