using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Location object.
/// </summary>
public sealed class ConversationContentLocation
{
    // URL of the Location.
    public string Url { get; set; }

    // Location postal address.
    public string Address { get; set; }

    // Location name.
    public string Text { get; set; }

    // Latitude of the location.
    public double? Latitude { get; set; }

    // Longitude of the location.
    public double? Longitude { get; set; }
}
