using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAppEventsNotificationNetworkConnectivity
/// </summary>
[DataContract]
public partial class JourneyAppEventsNotificationNetworkConnectivity : IEquatable<JourneyAppEventsNotificationNetworkConnectivity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationNetworkConnectivity" /> class.
    /// </summary>
    /// <param name="Carrier">Carrier.</param>
    /// <param name="BluetoothEnabled">BluetoothEnabled.</param>
    /// <param name="CellularEnabled">CellularEnabled.</param>
    /// <param name="WifiEnabled">WifiEnabled.</param>
    public JourneyAppEventsNotificationNetworkConnectivity(string Carrier = null, bool? BluetoothEnabled = null, bool? CellularEnabled = null, bool? WifiEnabled = null)
    {
        this.Carrier = Carrier;
        this.BluetoothEnabled = BluetoothEnabled;
        this.CellularEnabled = CellularEnabled;
        this.WifiEnabled = WifiEnabled;

    }



    /// <summary>
    /// Gets or Sets Carrier
    /// </summary>
    [DataMember(Name = "carrier", EmitDefaultValue = false)]
    public string Carrier { get; set; }



    /// <summary>
    /// Gets or Sets BluetoothEnabled
    /// </summary>
    [DataMember(Name = "bluetoothEnabled", EmitDefaultValue = false)]
    public bool? BluetoothEnabled { get; set; }



    /// <summary>
    /// Gets or Sets CellularEnabled
    /// </summary>
    [DataMember(Name = "cellularEnabled", EmitDefaultValue = false)]
    public bool? CellularEnabled { get; set; }



    /// <summary>
    /// Gets or Sets WifiEnabled
    /// </summary>
    [DataMember(Name = "wifiEnabled", EmitDefaultValue = false)]
    public bool? WifiEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAppEventsNotificationNetworkConnectivity {\n");

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
        return this.Equals(obj as JourneyAppEventsNotificationNetworkConnectivity);
    }

    /// <summary>
    /// Returns true if JourneyAppEventsNotificationNetworkConnectivity instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAppEventsNotificationNetworkConnectivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAppEventsNotificationNetworkConnectivity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Carrier == other.Carrier ||
                this.Carrier != null &&
                this.Carrier.Equals(other.Carrier)
            ) &&
            (
                this.BluetoothEnabled == other.BluetoothEnabled ||
                this.BluetoothEnabled != null &&
                this.BluetoothEnabled.Equals(other.BluetoothEnabled)
            ) &&
            (
                this.CellularEnabled == other.CellularEnabled ||
                this.CellularEnabled != null &&
                this.CellularEnabled.Equals(other.CellularEnabled)
            ) &&
            (
                this.WifiEnabled == other.WifiEnabled ||
                this.WifiEnabled != null &&
                this.WifiEnabled.Equals(other.WifiEnabled)
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
            if (this.Carrier != null)
            {
                hash = hash * 59 + this.Carrier.GetHashCode();
            }

            if (this.BluetoothEnabled != null)
            {
                hash = hash * 59 + this.BluetoothEnabled.GetHashCode();
            }

            if (this.CellularEnabled != null)
            {
                hash = hash * 59 + this.CellularEnabled.GetHashCode();
            }

            if (this.WifiEnabled != null)
            {
                hash = hash * 59 + this.WifiEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
