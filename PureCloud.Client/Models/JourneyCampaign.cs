using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyCampaign
/// </summary>

public partial class JourneyCampaign : IEquatable<JourneyCampaign>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyCampaign" /> class.
    /// </summary>
    /// <param name="Content">Differentiate ads or links that point to the same URL (e.g. textlink)..</param>
    /// <param name="Medium">Identify a medium such as email or cost-per-click (e.g. CPC)..</param>
    /// <param name="Name">Identify a specific product promotion or strategic campaign (e.g. 320banner)..</param>
    /// <param name="Source">Identify a search engine, newsletter name, or other source (e.g. Google)..</param>
    /// <param name="Term">Note the keywords for this ad (e.g. running+shoes)..</param>
    /// <param name="ClickId">The click ID (unique number that is generated when a potential customer clicks on an affiliate link)..</param>
    /// <param name="Network">The ad network to which the click ID belongs..</param>
    public JourneyCampaign(string Content = null, string Medium = null, string Name = null, string Source = null, string Term = null, string ClickId = null, string Network = null)
    {
        this.Content = Content;
        this.Medium = Medium;
        this.Name = Name;
        this.Source = Source;
        this.Term = Term;
        this.ClickId = ClickId;
        this.Network = Network;

    }



    /// <summary>
    /// Differentiate ads or links that point to the same URL (e.g. textlink).
    /// </summary>
    /// <value>Differentiate ads or links that point to the same URL (e.g. textlink).</value>
    [JsonPropertyName("content")]
    public string Content { get; set; }



    /// <summary>
    /// Identify a medium such as email or cost-per-click (e.g. CPC).
    /// </summary>
    /// <value>Identify a medium such as email or cost-per-click (e.g. CPC).</value>
    [JsonPropertyName("medium")]
    public string Medium { get; set; }



    /// <summary>
    /// Identify a specific product promotion or strategic campaign (e.g. 320banner).
    /// </summary>
    /// <value>Identify a specific product promotion or strategic campaign (e.g. 320banner).</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Identify a search engine, newsletter name, or other source (e.g. Google).
    /// </summary>
    /// <value>Identify a search engine, newsletter name, or other source (e.g. Google).</value>
    [JsonPropertyName("source")]
    public string Source { get; set; }



    /// <summary>
    /// Note the keywords for this ad (e.g. running+shoes).
    /// </summary>
    /// <value>Note the keywords for this ad (e.g. running+shoes).</value>
    [JsonPropertyName("term")]
    public string Term { get; set; }



    /// <summary>
    /// The click ID (unique number that is generated when a potential customer clicks on an affiliate link).
    /// </summary>
    /// <value>The click ID (unique number that is generated when a potential customer clicks on an affiliate link).</value>
    [JsonPropertyName("clickId")]
    public string ClickId { get; set; }



    /// <summary>
    /// The ad network to which the click ID belongs.
    /// </summary>
    /// <value>The ad network to which the click ID belongs.</value>
    [JsonPropertyName("network")]
    public string Network { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyCampaign {\n");

        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Medium: ").Append(Medium).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  Term: ").Append(Term).Append("\n");
        sb.Append("  ClickId: ").Append(ClickId).Append("\n");
        sb.Append("  Network: ").Append(Network).Append("\n");
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
        return Equals(obj as JourneyCampaign);
    }

    /// <summary>
    /// Returns true if JourneyCampaign instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyCampaign to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyCampaign other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Content == other.Content ||
                Content != null &&
                Content.Equals(other.Content)
            ) &&
            (
                Medium == other.Medium ||
                Medium != null &&
                Medium.Equals(other.Medium)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                Term == other.Term ||
                Term != null &&
                Term.Equals(other.Term)
            ) &&
            (
                ClickId == other.ClickId ||
                ClickId != null &&
                ClickId.Equals(other.ClickId)
            ) &&
            (
                Network == other.Network ||
                Network != null &&
                Network.Equals(other.Network)
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
            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (Medium != null)
            {
                hash = hash * 59 + Medium.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (Term != null)
            {
                hash = hash * 59 + Term.GetHashCode();
            }

            if (ClickId != null)
            {
                hash = hash * 59 + ClickId.GetHashCode();
            }

            if (Network != null)
            {
                hash = hash * 59 + Network.GetHashCode();
            }

            return hash;
        }
    }
}
