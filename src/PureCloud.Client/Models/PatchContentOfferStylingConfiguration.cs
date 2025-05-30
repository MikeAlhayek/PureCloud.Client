using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchContentOfferStylingConfiguration
/// </summary>

public partial class PatchContentOfferStylingConfiguration : IEquatable<PatchContentOfferStylingConfiguration>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchContentOfferStylingConfiguration" /> class.
    /// </summary>
    /// <param name="Position">Properties for customizing the positioning of the content offer..</param>
    /// <param name="Offer">Properties for customizing the appearance of the content offer..</param>
    /// <param name="CloseButton">Properties for customizing the appearance of the close button..</param>
    /// <param name="CtaButton">Properties for customizing the appearance of the CTA button..</param>
    /// <param name="Title">Properties for customizing the appearance of the title text..</param>
    /// <param name="Headline">Properties for customizing the appearance of the headline text..</param>
    /// <param name="Body">Properties for customizing the appearance of the body text..</param>
    public PatchContentOfferStylingConfiguration(PatchContentPositionProperties Position = null, PatchContentOfferStyleProperties Offer = null, PatchCloseButtonStyleProperties CloseButton = null, PatchCtaButtonStyleProperties CtaButton = null, PatchTextStyleProperties Title = null, PatchTextStyleProperties Headline = null, PatchTextStyleProperties Body = null)
    {
        this.Position = Position;
        this.Offer = Offer;
        this.CloseButton = CloseButton;
        this.CtaButton = CtaButton;
        this.Title = Title;
        this.Headline = Headline;
        this.Body = Body;

    }



    /// <summary>
    /// Properties for customizing the positioning of the content offer.
    /// </summary>
    /// <value>Properties for customizing the positioning of the content offer.</value>
    [JsonPropertyName("position")]
    public PatchContentPositionProperties Position { get; set; }



    /// <summary>
    /// Properties for customizing the appearance of the content offer.
    /// </summary>
    /// <value>Properties for customizing the appearance of the content offer.</value>
    [JsonPropertyName("offer")]
    public PatchContentOfferStyleProperties Offer { get; set; }



    /// <summary>
    /// Properties for customizing the appearance of the close button.
    /// </summary>
    /// <value>Properties for customizing the appearance of the close button.</value>
    [JsonPropertyName("closeButton")]
    public PatchCloseButtonStyleProperties CloseButton { get; set; }



    /// <summary>
    /// Properties for customizing the appearance of the CTA button.
    /// </summary>
    /// <value>Properties for customizing the appearance of the CTA button.</value>
    [JsonPropertyName("ctaButton")]
    public PatchCtaButtonStyleProperties CtaButton { get; set; }



    /// <summary>
    /// Properties for customizing the appearance of the title text.
    /// </summary>
    /// <value>Properties for customizing the appearance of the title text.</value>
    [JsonPropertyName("title")]
    public PatchTextStyleProperties Title { get; set; }



    /// <summary>
    /// Properties for customizing the appearance of the headline text.
    /// </summary>
    /// <value>Properties for customizing the appearance of the headline text.</value>
    [JsonPropertyName("headline")]
    public PatchTextStyleProperties Headline { get; set; }



    /// <summary>
    /// Properties for customizing the appearance of the body text.
    /// </summary>
    /// <value>Properties for customizing the appearance of the body text.</value>
    [JsonPropertyName("body")]
    public PatchTextStyleProperties Body { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchContentOfferStylingConfiguration {\n");

        sb.Append("  Position: ").Append(Position).Append("\n");
        sb.Append("  Offer: ").Append(Offer).Append("\n");
        sb.Append("  CloseButton: ").Append(CloseButton).Append("\n");
        sb.Append("  CtaButton: ").Append(CtaButton).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Headline: ").Append(Headline).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
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
        return Equals(obj as PatchContentOfferStylingConfiguration);
    }

    /// <summary>
    /// Returns true if PatchContentOfferStylingConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchContentOfferStylingConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchContentOfferStylingConfiguration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Position == other.Position ||
                Position != null &&
                Position.Equals(other.Position)
            ) &&
            (
                Offer == other.Offer ||
                Offer != null &&
                Offer.Equals(other.Offer)
            ) &&
            (
                CloseButton == other.CloseButton ||
                CloseButton != null &&
                CloseButton.Equals(other.CloseButton)
            ) &&
            (
                CtaButton == other.CtaButton ||
                CtaButton != null &&
                CtaButton.Equals(other.CtaButton)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Headline == other.Headline ||
                Headline != null &&
                Headline.Equals(other.Headline)
            ) &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
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
            if (Position != null)
            {
                hash = hash * 59 + Position.GetHashCode();
            }

            if (Offer != null)
            {
                hash = hash * 59 + Offer.GetHashCode();
            }

            if (CloseButton != null)
            {
                hash = hash * 59 + CloseButton.GetHashCode();
            }

            if (CtaButton != null)
            {
                hash = hash * 59 + CtaButton.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Headline != null)
            {
                hash = hash * 59 + Headline.GetHashCode();
            }

            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            return hash;
        }
    }
}
