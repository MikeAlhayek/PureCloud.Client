using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainNetworkCommandResponse
/// </summary>

public partial class DomainNetworkCommandResponse : IEquatable<DomainNetworkCommandResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainNetworkCommandResponse" /> class.
    /// </summary>
    /// <param name="CorrelationId">CorrelationId.</param>
    /// <param name="CommandName">CommandName.</param>
    /// <param name="Acknowledged">Acknowledged.</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    public DomainNetworkCommandResponse(string CorrelationId = null, string CommandName = null, bool? Acknowledged = null, ErrorDetails ErrorInfo = null)
    {
        this.CorrelationId = CorrelationId;
        this.CommandName = CommandName;
        this.Acknowledged = Acknowledged;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// Gets or Sets CorrelationId
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string CorrelationId { get; set; }



    /// <summary>
    /// Gets or Sets CommandName
    /// </summary>
    [JsonPropertyName("commandName")]
    public string CommandName { get; set; }



    /// <summary>
    /// Gets or Sets Acknowledged
    /// </summary>
    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [JsonPropertyName("errorInfo")]
    public ErrorDetails ErrorInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainNetworkCommandResponse {\n");

        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  CommandName: ").Append(CommandName).Append("\n");
        sb.Append("  Acknowledged: ").Append(Acknowledged).Append("\n");
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
        return Equals(obj as DomainNetworkCommandResponse);
    }

    /// <summary>
    /// Returns true if DomainNetworkCommandResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainNetworkCommandResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainNetworkCommandResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CorrelationId == other.CorrelationId ||
                CorrelationId != null &&
                CorrelationId.Equals(other.CorrelationId)
            ) &&
            (
                CommandName == other.CommandName ||
                CommandName != null &&
                CommandName.Equals(other.CommandName)
            ) &&
            (
                Acknowledged == other.Acknowledged ||
                Acknowledged != null &&
                Acknowledged.Equals(other.Acknowledged)
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
            if (CorrelationId != null)
            {
                hash = hash * 59 + CorrelationId.GetHashCode();
            }

            if (CommandName != null)
            {
                hash = hash * 59 + CommandName.GetHashCode();
            }

            if (Acknowledged != null)
            {
                hash = hash * 59 + Acknowledged.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
