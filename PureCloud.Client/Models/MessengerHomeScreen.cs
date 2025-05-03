using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessengerHomeScreen
/// </summary>

public partial class MessengerHomeScreen : IEquatable<MessengerHomeScreen>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessengerHomeScreen" /> class.
    /// </summary>
    /// <param name="Enabled">whether or not homescreen is enabled.</param>
    /// <param name="LogoUrl">to capture uploaded company logoUrl.</param>
    public MessengerHomeScreen(bool? Enabled = null, string LogoUrl = null)
    {
        this.Enabled = Enabled;
        this.LogoUrl = LogoUrl;

    }



    /// <summary>
    /// whether or not homescreen is enabled
    /// </summary>
    /// <value>whether or not homescreen is enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// to capture uploaded company logoUrl
    /// </summary>
    /// <value>to capture uploaded company logoUrl</value>
    [JsonPropertyName("logoUrl")]
    public string LogoUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessengerHomeScreen {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
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
        return Equals(obj as MessengerHomeScreen);
    }

    /// <summary>
    /// Returns true if MessengerHomeScreen instances are equal
    /// </summary>
    /// <param name="other">Instance of MessengerHomeScreen to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessengerHomeScreen other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                LogoUrl == other.LogoUrl ||
                LogoUrl != null &&
                LogoUrl.Equals(other.LogoUrl)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (LogoUrl != null)
            {
                hash = hash * 59 + LogoUrl.GetHashCode();
            }

            return hash;
        }
    }
}
