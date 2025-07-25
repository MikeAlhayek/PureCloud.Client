using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Carousel content object.
/// </summary>

public sealed class ContentCarousel
{
    /// <summary>
    /// An array of card objects.
    /// </summary>
    /// <value>An array of card objects.</value>
    public IEnumerable<ContentCard> Cards { get; set; }
}
