using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NTPSettings
/// </summary>

public partial class NTPSettings : IEquatable<NTPSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NTPSettings" /> class.
    /// </summary>
    /// <param name="Servers">List of NTP servers, in priority order.</param>
    public NTPSettings(List<string> Servers = null)
    {
        this.Servers = Servers;

    }



    /// <summary>
    /// List of NTP servers, in priority order
    /// </summary>
    /// <value>List of NTP servers, in priority order</value>
    [JsonPropertyName("servers")]
    public List<string> Servers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NTPSettings {\n");

        sb.Append("  Servers: ").Append(Servers).Append("\n");
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
        return Equals(obj as NTPSettings);
    }

    /// <summary>
    /// Returns true if NTPSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of NTPSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NTPSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Servers == other.Servers ||
                Servers != null &&
                Servers.SequenceEqual(other.Servers)
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
            if (Servers != null)
            {
                hash = hash * 59 + Servers.GetHashCode();
            }

            return hash;
        }
    }
}
