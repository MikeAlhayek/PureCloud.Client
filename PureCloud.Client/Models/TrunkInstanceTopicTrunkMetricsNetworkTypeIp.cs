using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkInstanceTopicTrunkMetricsNetworkTypeIp
/// </summary>

public partial class TrunkInstanceTopicTrunkMetricsNetworkTypeIp : IEquatable<TrunkInstanceTopicTrunkMetricsNetworkTypeIp>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunkMetricsNetworkTypeIp" /> class.
    /// </summary>
    /// <param name="Address">Address.</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    public TrunkInstanceTopicTrunkMetricsNetworkTypeIp(string Address = null, TrunkInstanceTopicTrunkErrorInfo ErrorInfo = null)
    {
        this.Address = Address;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [JsonPropertyName("errorInfo")]
    public TrunkInstanceTopicTrunkErrorInfo ErrorInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkInstanceTopicTrunkMetricsNetworkTypeIp {\n");

        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
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
        return Equals(obj as TrunkInstanceTopicTrunkMetricsNetworkTypeIp);
    }

    /// <summary>
    /// Returns true if TrunkInstanceTopicTrunkMetricsNetworkTypeIp instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkInstanceTopicTrunkMetricsNetworkTypeIp to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkInstanceTopicTrunkMetricsNetworkTypeIp other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
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
            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
