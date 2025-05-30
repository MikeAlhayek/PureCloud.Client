using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkConnectedStatus
/// </summary>

public partial class TrunkConnectedStatus : IEquatable<TrunkConnectedStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkConnectedStatus" /> class.
    /// </summary>
    /// <param name="Connected">Connected.</param>
    /// <param name="ConnectedStateTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public TrunkConnectedStatus(bool? Connected = null, DateTime? ConnectedStateTime = null)
    {
        this.Connected = Connected;
        this.ConnectedStateTime = ConnectedStateTime;

    }



    /// <summary>
    /// Gets or Sets Connected
    /// </summary>
    [JsonPropertyName("connected")]
    public bool? Connected { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("connectedStateTime")]
    public DateTime? ConnectedStateTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkConnectedStatus {\n");

        sb.Append("  Connected: ").Append(Connected).Append("\n");
        sb.Append("  ConnectedStateTime: ").Append(ConnectedStateTime).Append("\n");
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
        return Equals(obj as TrunkConnectedStatus);
    }

    /// <summary>
    /// Returns true if TrunkConnectedStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkConnectedStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkConnectedStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Connected == other.Connected ||
                Connected != null &&
                Connected.Equals(other.Connected)
            ) &&
            (
                ConnectedStateTime == other.ConnectedStateTime ||
                ConnectedStateTime != null &&
                ConnectedStateTime.Equals(other.ConnectedStateTime)
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
            if (Connected != null)
            {
                hash = hash * 59 + Connected.GetHashCode();
            }

            if (ConnectedStateTime != null)
            {
                hash = hash * 59 + ConnectedStateTime.GetHashCode();
            }

            return hash;
        }
    }
}
