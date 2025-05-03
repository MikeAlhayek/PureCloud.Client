using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeNetworkDiagnosticResponse
/// </summary>

public partial class EdgeNetworkDiagnosticResponse : IEquatable<EdgeNetworkDiagnosticResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeNetworkDiagnosticResponse" /> class.
    /// </summary>
    /// <param name="CommandCorrelationId">UUID of each executed command on edge.</param>
    /// <param name="Diagnostics">Response string of executed command from edge.</param>
    public EdgeNetworkDiagnosticResponse(string CommandCorrelationId = null, string Diagnostics = null)
    {
        this.CommandCorrelationId = CommandCorrelationId;
        this.Diagnostics = Diagnostics;

    }



    /// <summary>
    /// UUID of each executed command on edge
    /// </summary>
    /// <value>UUID of each executed command on edge</value>
    [JsonPropertyName("commandCorrelationId")]
    public string CommandCorrelationId { get; set; }



    /// <summary>
    /// Response string of executed command from edge
    /// </summary>
    /// <value>Response string of executed command from edge</value>
    [JsonPropertyName("diagnostics")]
    public string Diagnostics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeNetworkDiagnosticResponse {\n");

        sb.Append("  CommandCorrelationId: ").Append(CommandCorrelationId).Append("\n");
        sb.Append("  Diagnostics: ").Append(Diagnostics).Append("\n");
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
        return Equals(obj as EdgeNetworkDiagnosticResponse);
    }

    /// <summary>
    /// Returns true if EdgeNetworkDiagnosticResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeNetworkDiagnosticResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeNetworkDiagnosticResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CommandCorrelationId == other.CommandCorrelationId ||
                CommandCorrelationId != null &&
                CommandCorrelationId.Equals(other.CommandCorrelationId)
            ) &&
            (
                Diagnostics == other.Diagnostics ||
                Diagnostics != null &&
                Diagnostics.Equals(other.Diagnostics)
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
            if (CommandCorrelationId != null)
            {
                hash = hash * 59 + CommandCorrelationId.GetHashCode();
            }

            if (Diagnostics != null)
            {
                hash = hash * 59 + Diagnostics.GetHashCode();
            }

            return hash;
        }
    }
}
