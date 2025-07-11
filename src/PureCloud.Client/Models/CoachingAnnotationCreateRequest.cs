using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CoachingAnnotationCreateRequest
{
    /// <summary>
    /// Determines the permissions required to view this item.
    /// </summary>
    /// <value>Determines the permissions required to view this item.</value>
    public CoachingAnnotationCreateRequestAccessTypeEnum? AccessType { get; set; }

    /// <summary>
    /// The text of the annotation.
    /// </summary>
    /// <value>The text of the annotation.</value>
    public string Text { get; set; }
}
