using System.Text;
using System.Collections.Generic;

namespace PureCloud.Client.Models;

/// <summary>
/// Card content object.
/// </summary>
public sealed class ConversationContentCard
{
    // Text to show in the title.
    public string Title { get; set; }

    // Text to show in the description.
    public string Description { get; set; }

    // URL of an image.
    public string Image { get; set; }

    // URL of a video.
    public string Video { get; set; }

    // The default button action.
    public ConversationContentCardAction DefaultAction { get; set; }

    // An array of action objects.
    public IEnumerable<ConversationContentCardAction> Actions { get; set; }
}
