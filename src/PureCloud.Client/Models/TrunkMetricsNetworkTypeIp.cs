using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkMetricsNetworkTypeIp
/// </summary>

public partial class TrunkMetricsNetworkTypeIp : IEquatable<TrunkMetricsNetworkTypeIp>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkMetricsNetworkTypeIp" /> class.
    /// </summary>
    /// <param name="Address">Assigned IP Address for the interface.</param>
    /// <param name="ErrorInfo">Information about the error..</param>
    public TrunkMetricsNetworkTypeIp(string Address = null, TrunkErrorInfo ErrorInfo = null)
    {
        this.Address = Address;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// Assigned IP Address for the interface
    /// </summary>
    /// <value>Assigned IP Address for the interface</value>
    [JsonPropertyName("address")]
    public string Address { get; set; }



    /// <summary>
    /// Information about the error.
    /// </summary>
    /// <value>Information about the error.</value>
    [JsonPropertyName("errorInfo")]
    public TrunkErrorInfo ErrorInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkMetricsNetworkTypeIp {\n");

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
        return Equals(obj as TrunkMetricsNetworkTypeIp);
    }

    /// <summary>
    /// Returns true if TrunkMetricsNetworkTypeIp instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkMetricsNetworkTypeIp to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkMetricsNetworkTypeIp other)
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
