using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NetworkConnectivity
/// </summary>

public partial class NetworkConnectivity : IEquatable<NetworkConnectivity>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkConnectivity" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NetworkConnectivity() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkConnectivity" /> class.
    /// </summary>
    /// <param name="Carrier">The name of the network carrier..</param>
    /// <param name="BluetoothEnabled">Whether Bluetooth is enabled. (required).</param>
    /// <param name="CellularEnabled">Whether Cellular is enabled. (required).</param>
    /// <param name="WifiEnabled">Whether Wi-Fi is enabled. (required).</param>
    public NetworkConnectivity(string Carrier = null, bool? BluetoothEnabled = null, bool? CellularEnabled = null, bool? WifiEnabled = null)
    {
        this.Carrier = Carrier;
        this.BluetoothEnabled = BluetoothEnabled;
        this.CellularEnabled = CellularEnabled;
        this.WifiEnabled = WifiEnabled;

    }



    /// <summary>
    /// The name of the network carrier.
    /// </summary>
    /// <value>The name of the network carrier.</value>
    [JsonPropertyName("carrier")]
    public string Carrier { get; set; }



    /// <summary>
    /// Whether Bluetooth is enabled.
    /// </summary>
    /// <value>Whether Bluetooth is enabled.</value>
    [JsonPropertyName("bluetoothEnabled")]
    public bool? BluetoothEnabled { get; set; }



    /// <summary>
    /// Whether Cellular is enabled.
    /// </summary>
    /// <value>Whether Cellular is enabled.</value>
    [JsonPropertyName("cellularEnabled")]
    public bool? CellularEnabled { get; set; }



    /// <summary>
    /// Whether Wi-Fi is enabled.
    /// </summary>
    /// <value>Whether Wi-Fi is enabled.</value>
    [JsonPropertyName("wifiEnabled")]
    public bool? WifiEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NetworkConnectivity {\n");

        sb.Append("  Carrier: ").Append(Carrier).Append("\n");
        sb.Append("  BluetoothEnabled: ").Append(BluetoothEnabled).Append("\n");
        sb.Append("  CellularEnabled: ").Append(CellularEnabled).Append("\n");
        sb.Append("  WifiEnabled: ").Append(WifiEnabled).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as NetworkConnectivity);
    }

    /// <summary>
    /// Returns true if NetworkConnectivity instances are equal
    /// </summary>
    /// <param name="other">Instance of NetworkConnectivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NetworkConnectivity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Carrier == other.Carrier ||
                Carrier != null &&
                Carrier.Equals(other.Carrier)
            ) &&
            (
                BluetoothEnabled == other.BluetoothEnabled ||
                BluetoothEnabled != null &&
                BluetoothEnabled.Equals(other.BluetoothEnabled)
            ) &&
            (
                CellularEnabled == other.CellularEnabled ||
                CellularEnabled != null &&
                CellularEnabled.Equals(other.CellularEnabled)
            ) &&
            (
                WifiEnabled == other.WifiEnabled ||
                WifiEnabled != null &&
                WifiEnabled.Equals(other.WifiEnabled)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Carrier != null)
            {
                hash = hash * 59 + Carrier.GetHashCode();
            }

            if (BluetoothEnabled != null)
            {
                hash = hash * 59 + BluetoothEnabled.GetHashCode();
            }

            if (CellularEnabled != null)
            {
                hash = hash * 59 + CellularEnabled.GetHashCode();
            }

            if (WifiEnabled != null)
            {
                hash = hash * 59 + WifiEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
