using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

public sealed class ConversationMessageContent 
{
    // Type of this content element.
    public ContentType? ContentType { get; set; }

    // Location content.
    public ConversationContentLocation Location { get; set; }

    // Attachment content.
    public ConversationContentAttachment Attachment { get; set; }

    // Quick reply content.
    public ConversationContentQuickReply QuickReply { get; set; }

    // Button response content.
    public ConversationContentButtonResponse ButtonResponse { get; set; }

    // Template notification content.
    public ConversationContentNotificationTemplate Template { get; set; }

    // Ephemeral story content.
    public ConversationContentStory Story { get; set; }

    // Card content.
    public ConversationContentCard Card { get; set; }

    // Carousel content.
    public ConversationContentCarousel Carousel { get; set; }

    // Text content.
    public ConversationContentText Text { get; set; }

    // Quick reply V2 content.
    public ConversationContentQuickReplyV2 QuickReplyV2 { get; set; }
}
