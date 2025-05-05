using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeNetworkDiagnosticRequest
/// </summary>

public partial class EdgeNetworkDiagnosticRequest : IEquatable<EdgeNetworkDiagnosticRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeNetworkDiagnosticRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EdgeNetworkDiagnosticRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeNetworkDiagnosticRequest" /> class.
    /// </summary>
    /// <param name="Host">IPv4/6 address or host to be probed for connectivity. No port allowed. (required).</param>
    public EdgeNetworkDiagnosticRequest(string Host = null)
    {
        this.Host = Host;

    }



    /// <summary>
    /// IPv4/6 address or host to be probed for connectivity. No port allowed.
    /// </summary>
    /// <value>IPv4/6 address or host to be probed for connectivity. No port allowed.</value>
    [JsonPropertyName("host")]
    public string Host { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeNetworkDiagnosticRequest {\n");

        sb.Append("  Host: ").Append(Host).Append("\n");
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
        return Equals(obj as EdgeNetworkDiagnosticRequest);
    }

    /// <summary>
    /// Returns true if EdgeNetworkDiagnosticRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeNetworkDiagnosticRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeNetworkDiagnosticRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Host == other.Host ||
                Host != null &&
                Host.Equals(other.Host)
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
            if (Host != null)
            {
                hash = hash * 59 + Host.GetHashCode();
            }

            return hash;
        }
    }
}
