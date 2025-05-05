using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySessionEventsNotificationMktCampaign
/// </summary>

public partial class JourneySessionEventsNotificationMktCampaign : IEquatable<JourneySessionEventsNotificationMktCampaign>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationMktCampaign" /> class.
    /// </summary>
    /// <param name="Content">Content.</param>
    /// <param name="Medium">Medium.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Source">Source.</param>
    /// <param name="Term">Term.</param>
    /// <param name="ClickId">ClickId.</param>
    /// <param name="Network">Network.</param>
    public JourneySessionEventsNotificationMktCampaign(string Content = null, string Medium = null, string Name = null, string Source = null, string Term = null, string ClickId = null, string Network = null)
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
    /// Gets or Sets Content
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; }



    /// <summary>
    /// Gets or Sets Medium
    /// </summary>
    [JsonPropertyName("medium")]
    public string Medium { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }



    /// <summary>
    /// Gets or Sets Term
    /// </summary>
    [JsonPropertyName("term")]
    public string Term { get; set; }



    /// <summary>
    /// Gets or Sets ClickId
    /// </summary>
    [JsonPropertyName("clickId")]
    public string ClickId { get; set; }



    /// <summary>
    /// Gets or Sets Network
    /// </summary>
    [JsonPropertyName("network")]
    public string Network { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySessionEventsNotificationMktCampaign {\n");

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
        return Equals(obj as JourneySessionEventsNotificationMktCampaign);
    }

    /// <summary>
    /// Returns true if JourneySessionEventsNotificationMktCampaign instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySessionEventsNotificationMktCampaign to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySessionEventsNotificationMktCampaign other)
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
