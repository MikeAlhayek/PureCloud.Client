using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyOutcomeEventsNotificationOutcome
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }
}
