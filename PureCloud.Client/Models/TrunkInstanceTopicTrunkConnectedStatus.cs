using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkInstanceTopicTrunkConnectedStatus
/// </summary>
[DataContract]
public partial class TrunkInstanceTopicTrunkConnectedStatus : IEquatable<TrunkInstanceTopicTrunkConnectedStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunkConnectedStatus" /> class.
    /// </summary>
    /// <param name="Connected">Connected.</param>
    /// <param name="ConnectedStateTime">ConnectedStateTime.</param>
    public TrunkInstanceTopicTrunkConnectedStatus(bool? Connected = null, DateTime? ConnectedStateTime = null)
    {
        this.Connected = Connected;
        this.ConnectedStateTime = ConnectedStateTime;

    }



    /// <summary>
    /// Gets or Sets Connected
    /// </summary>
    [DataMember(Name = "connected", EmitDefaultValue = false)]
    public bool? Connected { get; set; }



    /// <summary>
    /// Gets or Sets ConnectedStateTime
    /// </summary>
    [DataMember(Name = "connectedStateTime", EmitDefaultValue = false)]
    public DateTime? ConnectedStateTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkInstanceTopicTrunkConnectedStatus {\n");

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
        return this.Equals(obj as TrunkInstanceTopicTrunkConnectedStatus);
    }

    /// <summary>
    /// Returns true if TrunkInstanceTopicTrunkConnectedStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkInstanceTopicTrunkConnectedStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkInstanceTopicTrunkConnectedStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Connected == other.Connected ||
                this.Connected != null &&
                this.Connected.Equals(other.Connected)
            ) &&
            (
                this.ConnectedStateTime == other.ConnectedStateTime ||
                this.ConnectedStateTime != null &&
                this.ConnectedStateTime.Equals(other.ConnectedStateTime)
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
            if (this.Connected != null)
            {
                hash = hash * 59 + this.Connected.GetHashCode();
            }

            if (this.ConnectedStateTime != null)
            {
                hash = hash * 59 + this.ConnectedStateTime.GetHashCode();
            }

            return hash;
        }
    }
}
