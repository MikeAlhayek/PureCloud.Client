using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NetworkConnectivity
{
    /// <summary>
    /// The name of the network carrier.
    /// </summary>
    /// <value>The name of the network carrier.</value>
    public string Carrier { get; set; }

    /// <summary>
    /// Whether Bluetooth is enabled.
    /// </summary>
    /// <value>Whether Bluetooth is enabled.</value>
    public bool? BluetoothEnabled { get; set; }

    /// <summary>
    /// Whether Cellular is enabled.
    /// </summary>
    /// <value>Whether Cellular is enabled.</value>
    public bool? CellularEnabled { get; set; }

    /// <summary>
    /// Whether Wi-Fi is enabled.
    /// </summary>
    /// <value>Whether Wi-Fi is enabled.</value>
    public bool? WifiEnabled { get; set; }
}
