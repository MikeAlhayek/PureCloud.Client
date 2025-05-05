using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message content element.
/// </summary>

public partial class WebMessagingContent : IEquatable<WebMessagingContent>
{
    /// <summary>
    /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
    /// </summary>
    /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
    
    public enum ContentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attachment for "Attachment"
        /// </summary>
        [EnumMember(Value = "Attachment")]
        Attachment,

        /// <summary>
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Buttonresponse for "ButtonResponse"
        /// </summary>
        [EnumMember(Value = "ButtonResponse")]
        Buttonresponse,

        /// <summary>
        /// Enum Generictemplate for "GenericTemplate"
        /// </summary>
        [EnumMember(Value = "GenericTemplate")]
        Generictemplate,

        /// <summary>
        /// Enum Card for "Card"
        /// </summary>
        [EnumMember(Value = "Card")]
        Card,

        /// <summary>
        /// Enum Carousel for "Carousel"
        /// </summary>
        [EnumMember(Value = "Carousel")]
        Carousel
    }
    /// <summary>
    /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
    /// </summary>
    /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebMessagingContent" /> class.
    /// </summary>
    /// <param name="QuickReply">Quick reply content..</param>
    /// <param name="ButtonResponse">Button response content..</param>
    /// <param name="Generic">Generic content (Deprecated)..</param>
    /// <param name="Card">Card content.</param>
    /// <param name="Carousel">Carousel content.</param>
    public WebMessagingContent(WebMessagingQuickReply QuickReply = null, WebMessagingButtonResponse ButtonResponse = null, WebMessagingGeneric Generic = null, ContentCard Card = null, ContentCarousel Carousel = null)
    {
        this.QuickReply = QuickReply;
        this.ButtonResponse = ButtonResponse;
        this.Generic = Generic;
        this.Card = Card;
        this.Carousel = Carousel;

    }





    /// <summary>
    /// Attachment content.
    /// </summary>
    /// <value>Attachment content.</value>
    [JsonPropertyName("attachment")]
    public WebMessagingAttachment Attachment { get; private set; }



    /// <summary>
    /// Quick reply content.
    /// </summary>
    /// <value>Quick reply content.</value>
    [JsonPropertyName("quickReply")]
    public WebMessagingQuickReply QuickReply { get; set; }



    /// <summary>
    /// Button response content.
    /// </summary>
    /// <value>Button response content.</value>
    [JsonPropertyName("buttonResponse")]
    public WebMessagingButtonResponse ButtonResponse { get; set; }



    /// <summary>
    /// Generic content (Deprecated).
    /// </summary>
    /// <value>Generic content (Deprecated).</value>
    [JsonPropertyName("generic")]
    public WebMessagingGeneric Generic { get; set; }



    /// <summary>
    /// Card content
    /// </summary>
    /// <value>Card content</value>
    [JsonPropertyName("card")]
    public ContentCard Card { get; set; }



    /// <summary>
    /// Carousel content
    /// </summary>
    /// <value>Carousel content</value>
    [JsonPropertyName("carousel")]
    public ContentCarousel Carousel { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebMessagingContent {\n");

        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Attachment: ").Append(Attachment).Append("\n");
        sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
        sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
        sb.Append("  Generic: ").Append(Generic).Append("\n");
        sb.Append("  Card: ").Append(Card).Append("\n");
        sb.Append("  Carousel: ").Append(Carousel).Append("\n");
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
        return Equals(obj as WebMessagingContent);
    }

    /// <summary>
    /// Returns true if WebMessagingContent instances are equal
    /// </summary>
    /// <param name="other">Instance of WebMessagingContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebMessagingContent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                Attachment == other.Attachment ||
                Attachment != null &&
                Attachment.Equals(other.Attachment)
            ) &&
            (
                QuickReply == other.QuickReply ||
                QuickReply != null &&
                QuickReply.Equals(other.QuickReply)
            ) &&
            (
                ButtonResponse == other.ButtonResponse ||
                ButtonResponse != null &&
                ButtonResponse.Equals(other.ButtonResponse)
            ) &&
            (
                Generic == other.Generic ||
                Generic != null &&
                Generic.Equals(other.Generic)
            ) &&
            (
                Card == other.Card ||
                Card != null &&
                Card.Equals(other.Card)
            ) &&
            (
                Carousel == other.Carousel ||
                Carousel != null &&
                Carousel.Equals(other.Carousel)
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
            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (Attachment != null)
            {
                hash = hash * 59 + Attachment.GetHashCode();
            }

            if (QuickReply != null)
            {
                hash = hash * 59 + QuickReply.GetHashCode();
            }

            if (ButtonResponse != null)
            {
                hash = hash * 59 + ButtonResponse.GetHashCode();
            }

            if (Generic != null)
            {
                hash = hash * 59 + Generic.GetHashCode();
            }

            if (Card != null)
            {
                hash = hash * 59 + Card.GetHashCode();
            }

            if (Carousel != null)
            {
                hash = hash * 59 + Carousel.GetHashCode();
            }

            return hash;
        }
    }
}
