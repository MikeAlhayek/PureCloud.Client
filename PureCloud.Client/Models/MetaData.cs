using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MetaData
/// </summary>

public partial class MetaData : IEquatable<MetaData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MetaData" /> class.
    /// </summary>
    /// <param name="PairingToken">PairingToken.</param>
    /// <param name="PairingTrust">PairingTrust.</param>
    /// <param name="PairingUrl">PairingUrl.</param>
    public MetaData(string PairingToken = null, List<string> PairingTrust = null, string PairingUrl = null)
    {
        this.PairingToken = PairingToken;
        this.PairingTrust = PairingTrust;
        this.PairingUrl = PairingUrl;

    }



    /// <summary>
    /// Gets or Sets PairingToken
    /// </summary>
    [JsonPropertyName("pairing-token")]
    public string PairingToken { get; set; }



    /// <summary>
    /// Gets or Sets PairingTrust
    /// </summary>
    [JsonPropertyName("pairing-trust")]
    public List<string> PairingTrust { get; set; }



    /// <summary>
    /// Gets or Sets PairingUrl
    /// </summary>
    [JsonPropertyName("pairing-url")]
    public string PairingUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MetaData {\n");

        sb.Append("  PairingToken: ").Append(PairingToken).Append("\n");
        sb.Append("  PairingTrust: ").Append(PairingTrust).Append("\n");
        sb.Append("  PairingUrl: ").Append(PairingUrl).Append("\n");
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
        return Equals(obj as MetaData);
    }

    /// <summary>
    /// Returns true if MetaData instances are equal
    /// </summary>
    /// <param name="other">Instance of MetaData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MetaData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PairingToken == other.PairingToken ||
                PairingToken != null &&
                PairingToken.Equals(other.PairingToken)
            ) &&
            (
                PairingTrust == other.PairingTrust ||
                PairingTrust != null &&
                PairingTrust.SequenceEqual(other.PairingTrust)
            ) &&
            (
                PairingUrl == other.PairingUrl ||
                PairingUrl != null &&
                PairingUrl.Equals(other.PairingUrl)
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
            if (PairingToken != null)
            {
                hash = hash * 59 + PairingToken.GetHashCode();
            }

            if (PairingTrust != null)
            {
                hash = hash * 59 + PairingTrust.GetHashCode();
            }

            if (PairingUrl != null)
            {
                hash = hash * 59 + PairingUrl.GetHashCode();
            }

            return hash;
        }
    }
}
