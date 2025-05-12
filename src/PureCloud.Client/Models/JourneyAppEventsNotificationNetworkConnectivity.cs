using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyAppEventsNotificationNetworkConnectivity
{
    /// <summary>
    /// Gets or Sets Carrier
    /// </summary>
    public string Carrier { get; set; }

    /// <summary>
    /// Gets or Sets BluetoothEnabled
    /// </summary>
    public bool? BluetoothEnabled { get; set; }

    /// <summary>
    /// Gets or Sets CellularEnabled
    /// </summary>
    public bool? CellularEnabled { get; set; }

    /// <summary>
    /// Gets or Sets WifiEnabled
    /// </summary>
    public bool? WifiEnabled { get; set; }
}
