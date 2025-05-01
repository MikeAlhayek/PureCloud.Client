using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyOutcomeEventsNotificationMktCampaign
/// </summary>
[DataContract]
public partial class JourneyOutcomeEventsNotificationMktCampaign : IEquatable<JourneyOutcomeEventsNotificationMktCampaign>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationMktCampaign" /> class.
    /// </summary>
    /// <param name="Content">Content.</param>
    /// <param name="Medium">Medium.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Source">Source.</param>
    /// <param name="Term">Term.</param>
    /// <param name="ClickId">ClickId.</param>
    /// <param name="Network">Network.</param>
    public JourneyOutcomeEventsNotificationMktCampaign(string Content = null, string Medium = null, string Name = null, string Source = null, string Term = null, string ClickId = null, string Network = null)
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
    [DataMember(Name = "content", EmitDefaultValue = false)]
    public string Content { get; set; }



    /// <summary>
    /// Gets or Sets Medium
    /// </summary>
    [DataMember(Name = "medium", EmitDefaultValue = false)]
    public string Medium { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public string Source { get; set; }



    /// <summary>
    /// Gets or Sets Term
    /// </summary>
    [DataMember(Name = "term", EmitDefaultValue = false)]
    public string Term { get; set; }



    /// <summary>
    /// Gets or Sets ClickId
    /// </summary>
    [DataMember(Name = "clickId", EmitDefaultValue = false)]
    public string ClickId { get; set; }



    /// <summary>
    /// Gets or Sets Network
    /// </summary>
    [DataMember(Name = "network", EmitDefaultValue = false)]
    public string Network { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyOutcomeEventsNotificationMktCampaign {\n");

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
        return Equals(obj as JourneyOutcomeEventsNotificationMktCampaign);
    }

    /// <summary>
    /// Returns true if JourneyOutcomeEventsNotificationMktCampaign instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyOutcomeEventsNotificationMktCampaign to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyOutcomeEventsNotificationMktCampaign other)
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
