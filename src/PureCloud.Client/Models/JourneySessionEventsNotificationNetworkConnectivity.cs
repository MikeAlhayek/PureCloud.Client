using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySessionEventsNotificationNetworkConnectivity
/// </summary>

public partial class JourneySessionEventsNotificationNetworkConnectivity : IEquatable<JourneySessionEventsNotificationNetworkConnectivity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationNetworkConnectivity" /> class.
    /// </summary>
    /// <param name="Carrier">Carrier.</param>
    /// <param name="BluetoothEnabled">BluetoothEnabled.</param>
    /// <param name="CellularEnabled">CellularEnabled.</param>
    /// <param name="WifiEnabled">WifiEnabled.</param>
    public JourneySessionEventsNotificationNetworkConnectivity(string Carrier = null, bool? BluetoothEnabled = null, bool? CellularEnabled = null, bool? WifiEnabled = null)
    {
        this.Carrier = Carrier;
        this.BluetoothEnabled = BluetoothEnabled;
        this.CellularEnabled = CellularEnabled;
        this.WifiEnabled = WifiEnabled;

    }



    /// <summary>
    /// Gets or Sets Carrier
    /// </summary>
    [JsonPropertyName("carrier")]
    public string Carrier { get; set; }



    /// <summary>
    /// Gets or Sets BluetoothEnabled
    /// </summary>
    [JsonPropertyName("bluetoothEnabled")]
    public bool? BluetoothEnabled { get; set; }



    /// <summary>
    /// Gets or Sets CellularEnabled
    /// </summary>
    [JsonPropertyName("cellularEnabled")]
    public bool? CellularEnabled { get; set; }



    /// <summary>
    /// Gets or Sets WifiEnabled
    /// </summary>
    [JsonPropertyName("wifiEnabled")]
    public bool? WifiEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySessionEventsNotificationNetworkConnectivity {\n");

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
        return Equals(obj as JourneySessionEventsNotificationNetworkConnectivity);
    }

    /// <summary>
    /// Returns true if JourneySessionEventsNotificationNetworkConnectivity instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySessionEventsNotificationNetworkConnectivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySessionEventsNotificationNetworkConnectivity other)
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
