using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AutomaticTimeZoneMappingSettings
/// </summary>

public partial class AutomaticTimeZoneMappingSettings : IEquatable<AutomaticTimeZoneMappingSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutomaticTimeZoneMappingSettings" /> class.
    /// </summary>
    /// <param name="CallableWindows">The time intervals to use for automatic time zone mapping..</param>
    /// <param name="SupportedCountries">The countries that are supported for automatic time zone mapping..</param>
    public AutomaticTimeZoneMappingSettings(List<CallableWindow> CallableWindows = null, List<string> SupportedCountries = null)
    {
        this.CallableWindows = CallableWindows;
        this.SupportedCountries = SupportedCountries;

    }



    /// <summary>
    /// The time intervals to use for automatic time zone mapping.
    /// </summary>
    /// <value>The time intervals to use for automatic time zone mapping.</value>
    [JsonPropertyName("callableWindows")]
    public List<CallableWindow> CallableWindows { get; set; }



    /// <summary>
    /// The countries that are supported for automatic time zone mapping.
    /// </summary>
    /// <value>The countries that are supported for automatic time zone mapping.</value>
    [JsonPropertyName("supportedCountries")]
    public List<string> SupportedCountries { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AutomaticTimeZoneMappingSettings {\n");

        sb.Append("  CallableWindows: ").Append(CallableWindows).Append("\n");
        sb.Append("  SupportedCountries: ").Append(SupportedCountries).Append("\n");
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
        return Equals(obj as AutomaticTimeZoneMappingSettings);
    }

    /// <summary>
    /// Returns true if AutomaticTimeZoneMappingSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AutomaticTimeZoneMappingSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AutomaticTimeZoneMappingSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CallableWindows == other.CallableWindows ||
                CallableWindows != null &&
                CallableWindows.SequenceEqual(other.CallableWindows)
            ) &&
            (
                SupportedCountries == other.SupportedCountries ||
                SupportedCountries != null &&
                SupportedCountries.SequenceEqual(other.SupportedCountries)
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
            if (CallableWindows != null)
            {
                hash = hash * 59 + CallableWindows.GetHashCode();
            }

            if (SupportedCountries != null)
            {
                hash = hash * 59 + SupportedCountries.GetHashCode();
            }

            return hash;
        }
    }
}
