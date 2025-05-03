using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkInstanceTopicTrunkMetricsOptions
/// </summary>

public partial class TrunkInstanceTopicTrunkMetricsOptions : IEquatable<TrunkInstanceTopicTrunkMetricsOptions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkInstanceTopicTrunkMetricsOptions" /> class.
    /// </summary>
    /// <param name="ProxyAddress">ProxyAddress.</param>
    /// <param name="OptionState">OptionState.</param>
    /// <param name="OptionStateTime">OptionStateTime.</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    public TrunkInstanceTopicTrunkMetricsOptions(string ProxyAddress = null, bool? OptionState = null, DateTime? OptionStateTime = null, TrunkInstanceTopicTrunkErrorInfo ErrorInfo = null)
    {
        this.ProxyAddress = ProxyAddress;
        this.OptionState = OptionState;
        this.OptionStateTime = OptionStateTime;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// Gets or Sets ProxyAddress
    /// </summary>
    [JsonPropertyName("proxyAddress")]
    public string ProxyAddress { get; set; }



    /// <summary>
    /// Gets or Sets OptionState
    /// </summary>
    [JsonPropertyName("optionState")]
    public bool? OptionState { get; set; }



    /// <summary>
    /// Gets or Sets OptionStateTime
    /// </summary>
    [JsonPropertyName("optionStateTime")]
    public DateTime? OptionStateTime { get; set; }



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
        sb.Append("class TrunkInstanceTopicTrunkMetricsOptions {\n");

        sb.Append("  ProxyAddress: ").Append(ProxyAddress).Append("\n");
        sb.Append("  OptionState: ").Append(OptionState).Append("\n");
        sb.Append("  OptionStateTime: ").Append(OptionStateTime).Append("\n");
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
        return Equals(obj as TrunkInstanceTopicTrunkMetricsOptions);
    }

    /// <summary>
    /// Returns true if TrunkInstanceTopicTrunkMetricsOptions instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkInstanceTopicTrunkMetricsOptions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkInstanceTopicTrunkMetricsOptions other)
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
                OptionState == other.OptionState ||
                OptionState != null &&
                OptionState.Equals(other.OptionState)
            ) &&
            (
                OptionStateTime == other.OptionStateTime ||
                OptionStateTime != null &&
                OptionStateTime.Equals(other.OptionStateTime)
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

            if (OptionState != null)
            {
                hash = hash * 59 + OptionState.GetHashCode();
            }

            if (OptionStateTime != null)
            {
                hash = hash * 59 + OptionStateTime.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
