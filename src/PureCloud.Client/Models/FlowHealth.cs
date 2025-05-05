using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowHealth
/// </summary>

public partial class FlowHealth : IEquatable<FlowHealth>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowHealth" /> class.
    /// </summary>
    /// <param name="FlowVersionInfo">Info about given flow version..</param>
    /// <param name="LanguageInfo">Each language&#39;s status about its health computation..</param>
    /// <param name="Intents">Health metrics information for the intents..</param>
    public FlowHealth(FlowHealthVersionInfo FlowVersionInfo = null, Dictionary<string, LocaleInfo> LanguageInfo = null, List<FlowHealthIntentInfo> Intents = null)
    {
        this.FlowVersionInfo = FlowVersionInfo;
        this.LanguageInfo = LanguageInfo;
        this.Intents = Intents;

    }



    /// <summary>
    /// Info about given flow version.
    /// </summary>
    /// <value>Info about given flow version.</value>
    [JsonPropertyName("flowVersionInfo")]
    public FlowHealthVersionInfo FlowVersionInfo { get; set; }



    /// <summary>
    /// Each language&#39;s status about its health computation.
    /// </summary>
    /// <value>Each language&#39;s status about its health computation.</value>
    [JsonPropertyName("languageInfo")]
    public Dictionary<string, LocaleInfo> LanguageInfo { get; set; }



    /// <summary>
    /// Health metrics information for the intents.
    /// </summary>
    /// <value>Health metrics information for the intents.</value>
    [JsonPropertyName("intents")]
    public List<FlowHealthIntentInfo> Intents { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowHealth {\n");

        sb.Append("  FlowVersionInfo: ").Append(FlowVersionInfo).Append("\n");
        sb.Append("  LanguageInfo: ").Append(LanguageInfo).Append("\n");
        sb.Append("  Intents: ").Append(Intents).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as FlowHealth);
    }

    /// <summary>
    /// Returns true if FlowHealth instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowHealth to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowHealth other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FlowVersionInfo == other.FlowVersionInfo ||
                FlowVersionInfo != null &&
                FlowVersionInfo.Equals(other.FlowVersionInfo)
            ) &&
            (
                LanguageInfo == other.LanguageInfo ||
                LanguageInfo != null &&
                LanguageInfo.SequenceEqual(other.LanguageInfo)
            ) &&
            (
                Intents == other.Intents ||
                Intents != null &&
                Intents.SequenceEqual(other.Intents)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (FlowVersionInfo != null)
            {
                hash = hash * 59 + FlowVersionInfo.GetHashCode();
            }

            if (LanguageInfo != null)
            {
                hash = hash * 59 + LanguageInfo.GetHashCode();
            }

            if (Intents != null)
            {
                hash = hash * 59 + Intents.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
