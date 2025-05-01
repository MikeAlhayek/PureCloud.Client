using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchContentOffer
/// </summary>
[DataContract]
public partial class PatchContentOffer : IEquatable<PatchContentOffer>
{
    /// <summary>
    /// The display mode of Genesys Widgets when displaying content offer.
    /// </summary>
    /// <value>The display mode of Genesys Widgets when displaying content offer.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DisplayModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Modal for "Modal"
        /// </summary>
        [EnumMember(Value = "Modal")]
        Modal,

        /// <summary>
        /// Enum Overlay for "Overlay"
        /// </summary>
        [EnumMember(Value = "Overlay")]
        Overlay,

        /// <summary>
        /// Enum Toast for "Toast"
        /// </summary>
        [EnumMember(Value = "Toast")]
        Toast
    }
    /// <summary>
    /// The layout mode of the text shown to the user when displaying content offer.
    /// </summary>
    /// <value>The layout mode of the text shown to the user when displaying content offer.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LayoutModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Textonly for "TextOnly"
        /// </summary>
        [EnumMember(Value = "TextOnly")]
        Textonly,

        /// <summary>
        /// Enum Imageonly for "ImageOnly"
        /// </summary>
        [EnumMember(Value = "ImageOnly")]
        Imageonly,

        /// <summary>
        /// Enum Lefttext for "LeftText"
        /// </summary>
        [EnumMember(Value = "LeftText")]
        Lefttext,

        /// <summary>
        /// Enum Righttext for "RightText"
        /// </summary>
        [EnumMember(Value = "RightText")]
        Righttext,

        /// <summary>
        /// Enum Toptext for "TopText"
        /// </summary>
        [EnumMember(Value = "TopText")]
        Toptext,

        /// <summary>
        /// Enum Bottomtext for "BottomText"
        /// </summary>
        [EnumMember(Value = "BottomText")]
        Bottomtext
    }
    /// <summary>
    /// The display mode of Genesys Widgets when displaying content offer.
    /// </summary>
    /// <value>The display mode of Genesys Widgets when displaying content offer.</value>
    [DataMember(Name = "displayMode", EmitDefaultValue = false)]
    public DisplayModeEnum? DisplayMode { get; set; }
    /// <summary>
    /// The layout mode of the text shown to the user when displaying content offer.
    /// </summary>
    /// <value>The layout mode of the text shown to the user when displaying content offer.</value>
    [DataMember(Name = "layoutMode", EmitDefaultValue = false)]
    public LayoutModeEnum? LayoutMode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchContentOffer" /> class.
    /// </summary>
    /// <param name="ImageUrl">URL for image displayed to the customer when displaying content offer..</param>
    /// <param name="DisplayMode">The display mode of Genesys Widgets when displaying content offer..</param>
    /// <param name="LayoutMode">The layout mode of the text shown to the user when displaying content offer..</param>
    /// <param name="Title">Title used in the header of the content offer..</param>
    /// <param name="Headline">Headline displayed above the body text of the content offer..</param>
    /// <param name="Body">Body text of the content offer..</param>
    /// <param name="CallToAction">Properties customizing the call to action button on the content offer..</param>
    /// <param name="Style">Properties customizing the styling of the content offer..</param>
    public PatchContentOffer(string ImageUrl = null, DisplayModeEnum? DisplayMode = null, LayoutModeEnum? LayoutMode = null, string Title = null, string Headline = null, string Body = null, PatchCallToAction CallToAction = null, PatchContentOfferStylingConfiguration Style = null)
    {
        this.ImageUrl = ImageUrl;
        this.DisplayMode = DisplayMode;
        this.LayoutMode = LayoutMode;
        this.Title = Title;
        this.Headline = Headline;
        this.Body = Body;
        this.CallToAction = CallToAction;
        this.Style = Style;

    }



    /// <summary>
    /// URL for image displayed to the customer when displaying content offer.
    /// </summary>
    /// <value>URL for image displayed to the customer when displaying content offer.</value>
    [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
    public string ImageUrl { get; set; }







    /// <summary>
    /// Title used in the header of the content offer.
    /// </summary>
    /// <value>Title used in the header of the content offer.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// Headline displayed above the body text of the content offer.
    /// </summary>
    /// <value>Headline displayed above the body text of the content offer.</value>
    [DataMember(Name = "headline", EmitDefaultValue = false)]
    public string Headline { get; set; }



    /// <summary>
    /// Body text of the content offer.
    /// </summary>
    /// <value>Body text of the content offer.</value>
    [DataMember(Name = "body", EmitDefaultValue = false)]
    public string Body { get; set; }



    /// <summary>
    /// Properties customizing the call to action button on the content offer.
    /// </summary>
    /// <value>Properties customizing the call to action button on the content offer.</value>
    [DataMember(Name = "callToAction", EmitDefaultValue = false)]
    public PatchCallToAction CallToAction { get; set; }



    /// <summary>
    /// Properties customizing the styling of the content offer.
    /// </summary>
    /// <value>Properties customizing the styling of the content offer.</value>
    [DataMember(Name = "style", EmitDefaultValue = false)]
    public PatchContentOfferStylingConfiguration Style { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchContentOffer {\n");

        sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
        sb.Append("  DisplayMode: ").Append(DisplayMode).Append("\n");
        sb.Append("  LayoutMode: ").Append(LayoutMode).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Headline: ").Append(Headline).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
        sb.Append("  CallToAction: ").Append(CallToAction).Append("\n");
        sb.Append("  Style: ").Append(Style).Append("\n");
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
        return Equals(obj as PatchContentOffer);
    }

    /// <summary>
    /// Returns true if PatchContentOffer instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchContentOffer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchContentOffer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ImageUrl == other.ImageUrl ||
                ImageUrl != null &&
                ImageUrl.Equals(other.ImageUrl)
            ) &&
            (
                DisplayMode == other.DisplayMode ||
                DisplayMode != null &&
                DisplayMode.Equals(other.DisplayMode)
            ) &&
            (
                LayoutMode == other.LayoutMode ||
                LayoutMode != null &&
                LayoutMode.Equals(other.LayoutMode)
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
            ) &&
            (
                CallToAction == other.CallToAction ||
                CallToAction != null &&
                CallToAction.Equals(other.CallToAction)
            ) &&
            (
                Style == other.Style ||
                Style != null &&
                Style.Equals(other.Style)
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
            if (ImageUrl != null)
            {
                hash = hash * 59 + ImageUrl.GetHashCode();
            }

            if (DisplayMode != null)
            {
                hash = hash * 59 + DisplayMode.GetHashCode();
            }

            if (LayoutMode != null)
            {
                hash = hash * 59 + LayoutMode.GetHashCode();
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

            if (CallToAction != null)
            {
                hash = hash * 59 + CallToAction.GetHashCode();
            }

            if (Style != null)
            {
                hash = hash * 59 + Style.GetHashCode();
            }

            return hash;
        }
    }
}
