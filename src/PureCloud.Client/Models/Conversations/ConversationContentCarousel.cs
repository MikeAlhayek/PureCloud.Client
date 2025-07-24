using System.Text;
using System.Collections.Generic;

namespace PureCloud.Client.Models;

/// <summary>
/// Carousel content object.
/// </summary>
public sealed class ConversationContentCarousel
{
    // An array of card objects.
    public IEnumerable<ConversationContentCard> Cards { get; set; }
}
