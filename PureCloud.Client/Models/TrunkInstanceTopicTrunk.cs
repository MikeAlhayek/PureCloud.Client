using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkInstanceTopicTrunk
/// </summary>

public partial class TrunkInstanceTopicTrunk : IEquatable<TrunkInstanceTopicTrunk>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunk" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ConnectedStatus">ConnectedStatus.</param>
    /// <param name="OptionsStatus">OptionsStatus.</param>
    /// <param name="RegistersStatus">RegistersStatus.</param>
    /// <param name="IpStatus">IpStatus.</param>
    public TrunkInstanceTopicTrunk(string Id = null, TrunkInstanceTopicTrunkConnectedStatus ConnectedStatus = null, List<TrunkInstanceTopicTrunkMetricsOptions> OptionsStatus = null, List<TrunkInstanceTopicTrunkMetricsRegisters> RegistersStatus = null, TrunkInstanceTopicTrunkMetricsNetworkTypeIp IpStatus = null)
    {
        this.Id = Id;
        this.ConnectedStatus = ConnectedStatus;
        this.OptionsStatus = OptionsStatus;
        this.RegistersStatus = RegistersStatus;
        this.IpStatus = IpStatus;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets ConnectedStatus
    /// </summary>
    [JsonPropertyName("connectedStatus")]
    public TrunkInstanceTopicTrunkConnectedStatus ConnectedStatus { get; set; }



    /// <summary>
    /// Gets or Sets OptionsStatus
    /// </summary>
    [JsonPropertyName("optionsStatus")]
    public List<TrunkInstanceTopicTrunkMetricsOptions> OptionsStatus { get; set; }



    /// <summary>
    /// Gets or Sets RegistersStatus
    /// </summary>
    [JsonPropertyName("registersStatus")]
    public List<TrunkInstanceTopicTrunkMetricsRegisters> RegistersStatus { get; set; }



    /// <summary>
    /// Gets or Sets IpStatus
    /// </summary>
    [JsonPropertyName("ipStatus")]
    public TrunkInstanceTopicTrunkMetricsNetworkTypeIp IpStatus { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkInstanceTopicTrunk {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ConnectedStatus: ").Append(ConnectedStatus).Append("\n");
        sb.Append("  OptionsStatus: ").Append(OptionsStatus).Append("\n");
        sb.Append("  RegistersStatus: ").Append(RegistersStatus).Append("\n");
        sb.Append("  IpStatus: ").Append(IpStatus).Append("\n");
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
        return Equals(obj as TrunkInstanceTopicTrunk);
    }

    /// <summary>
    /// Returns true if TrunkInstanceTopicTrunk instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkInstanceTopicTrunk to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkInstanceTopicTrunk other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                ConnectedStatus == other.ConnectedStatus ||
                ConnectedStatus != null &&
                ConnectedStatus.Equals(other.ConnectedStatus)
            ) &&
            (
                OptionsStatus == other.OptionsStatus ||
                OptionsStatus != null &&
                OptionsStatus.SequenceEqual(other.OptionsStatus)
            ) &&
            (
                RegistersStatus == other.RegistersStatus ||
                RegistersStatus != null &&
                RegistersStatus.SequenceEqual(other.RegistersStatus)
            ) &&
            (
                IpStatus == other.IpStatus ||
                IpStatus != null &&
                IpStatus.Equals(other.IpStatus)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (ConnectedStatus != null)
            {
                hash = hash * 59 + ConnectedStatus.GetHashCode();
            }

            if (OptionsStatus != null)
            {
                hash = hash * 59 + OptionsStatus.GetHashCode();
            }

            if (RegistersStatus != null)
            {
                hash = hash * 59 + RegistersStatus.GetHashCode();
            }

            if (IpStatus != null)
            {
                hash = hash * 59 + IpStatus.GetHashCode();
            }

            return hash;
        }
    }
}
