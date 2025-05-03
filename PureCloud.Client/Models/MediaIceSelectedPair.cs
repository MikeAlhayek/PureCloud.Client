using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaIceSelectedPair
/// </summary>

public partial class MediaIceSelectedPair : IEquatable<MediaIceSelectedPair>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaIceSelectedPair" /> class.
    /// </summary>
    /// <param name="Client">The remote candidate that was chosen.</param>
    /// <param name="Server">The local candidate that was chosen.</param>
    /// <param name="CandidatePairSelectedMilliseconds">Relative milliseconds since creation of endpoint when this ICE candidate pair has been selected.</param>
    public MediaIceSelectedPair(MediaIceSelectedCandidate Client = null, MediaIceSelectedCandidate Server = null, long? CandidatePairSelectedMilliseconds = null)
    {
        this.Client = Client;
        this.Server = Server;
        this.CandidatePairSelectedMilliseconds = CandidatePairSelectedMilliseconds;

    }



    /// <summary>
    /// The remote candidate that was chosen
    /// </summary>
    /// <value>The remote candidate that was chosen</value>
    [JsonPropertyName("client")]
    public MediaIceSelectedCandidate Client { get; set; }



    /// <summary>
    /// The local candidate that was chosen
    /// </summary>
    /// <value>The local candidate that was chosen</value>
    [JsonPropertyName("server")]
    public MediaIceSelectedCandidate Server { get; set; }



    /// <summary>
    /// Relative milliseconds since creation of endpoint when this ICE candidate pair has been selected
    /// </summary>
    /// <value>Relative milliseconds since creation of endpoint when this ICE candidate pair has been selected</value>
    [JsonPropertyName("candidatePairSelectedMilliseconds")]
    public long? CandidatePairSelectedMilliseconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaIceSelectedPair {\n");

        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  Server: ").Append(Server).Append("\n");
        sb.Append("  CandidatePairSelectedMilliseconds: ").Append(CandidatePairSelectedMilliseconds).Append("\n");
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
        return Equals(obj as MediaIceSelectedPair);
    }

    /// <summary>
    /// Returns true if MediaIceSelectedPair instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaIceSelectedPair to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaIceSelectedPair other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Client == other.Client ||
                Client != null &&
                Client.Equals(other.Client)
            ) &&
            (
                Server == other.Server ||
                Server != null &&
                Server.Equals(other.Server)
            ) &&
            (
                CandidatePairSelectedMilliseconds == other.CandidatePairSelectedMilliseconds ||
                CandidatePairSelectedMilliseconds != null &&
                CandidatePairSelectedMilliseconds.Equals(other.CandidatePairSelectedMilliseconds)
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
            if (Client != null)
            {
                hash = hash * 59 + Client.GetHashCode();
            }

            if (Server != null)
            {
                hash = hash * 59 + Server.GetHashCode();
            }

            if (CandidatePairSelectedMilliseconds != null)
            {
                hash = hash * 59 + CandidatePairSelectedMilliseconds.GetHashCode();
            }

            return hash;
        }
    }
}
