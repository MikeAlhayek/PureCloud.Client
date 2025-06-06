using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkMetricsRegisters
/// </summary>

public partial class TrunkMetricsRegisters : IEquatable<TrunkMetricsRegisters>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkMetricsRegisters" /> class.
    /// </summary>
    /// <param name="ProxyAddress">Server proxy address that this registers array element represents..</param>
    /// <param name="RegisterState">True if last REGISTER message had positive response; false if error response or no response..</param>
    /// <param name="RegisterStateTime">ISO 8601 format UTC absolute date &amp; time of the last change of the register state..</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    public TrunkMetricsRegisters(string ProxyAddress = null, bool? RegisterState = null, DateTime? RegisterStateTime = null, TrunkErrorInfo ErrorInfo = null)
    {
        this.ProxyAddress = ProxyAddress;
        this.RegisterState = RegisterState;
        this.RegisterStateTime = RegisterStateTime;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// Server proxy address that this registers array element represents.
    /// </summary>
    /// <value>Server proxy address that this registers array element represents.</value>
    [JsonPropertyName("proxyAddress")]
    public string ProxyAddress { get; set; }



    /// <summary>
    /// True if last REGISTER message had positive response; false if error response or no response.
    /// </summary>
    /// <value>True if last REGISTER message had positive response; false if error response or no response.</value>
    [JsonPropertyName("registerState")]
    public bool? RegisterState { get; set; }



    /// <summary>
    /// ISO 8601 format UTC absolute date &amp; time of the last change of the register state.
    /// </summary>
    /// <value>ISO 8601 format UTC absolute date &amp; time of the last change of the register state.</value>
    [JsonPropertyName("registerStateTime")]
    public DateTime? RegisterStateTime { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [JsonPropertyName("errorInfo")]
    public TrunkErrorInfo ErrorInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkMetricsRegisters {\n");

        sb.Append("  ProxyAddress: ").Append(ProxyAddress).Append("\n");
        sb.Append("  RegisterState: ").Append(RegisterState).Append("\n");
        sb.Append("  RegisterStateTime: ").Append(RegisterStateTime).Append("\n");
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
        return Equals(obj as TrunkMetricsRegisters);
    }

    /// <summary>
    /// Returns true if TrunkMetricsRegisters instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkMetricsRegisters to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkMetricsRegisters other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ProxyAddress == other.ProxyAddress ||
                ProxyAddress != null &&
                ProxyAddress.Equals(other.ProxyAddress)
            ) &&
            (
                RegisterState == other.RegisterState ||
                RegisterState != null &&
                RegisterState.Equals(other.RegisterState)
            ) &&
            (
                RegisterStateTime == other.RegisterStateTime ||
                RegisterStateTime != null &&
                RegisterStateTime.Equals(other.RegisterStateTime)
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
            if (ProxyAddress != null)
            {
                hash = hash * 59 + ProxyAddress.GetHashCode();
            }

            if (RegisterState != null)
            {
                hash = hash * 59 + RegisterState.GetHashCode();
            }

            if (RegisterStateTime != null)
            {
                hash = hash * 59 + RegisterStateTime.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
