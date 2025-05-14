using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerSequenceConfigChangeCampaignSequence
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public DialerSequenceConfigChangeCampaignSequenceStatusEnum? Status { get; set; }

    /// <summary>
    /// the ordered list of campaign identifiers
    /// </summary>
    /// <value>the ordered list of campaign identifiers</value>
    public IEnumerable<DialerSequenceConfigChangeUriReference> Campaigns { get; set; }

    /// <summary>
    /// the zero-based index of the current campaign in the campaigns list
    /// </summary>
    /// <value>the zero-based index of the current campaign in the campaigns list</value>
    public long? CurrentCampaign { get; set; }

    /// <summary>
    /// if a sequence has unexpectedly stopped, this message provides the reason
    /// </summary>
    /// <value>if a sequence has unexpectedly stopped, this message provides the reason</value>
    public string StopMessage { get; set; }

    /// <summary>
    /// indicates if a sequence is to repeat from the beginning after the last campaign completes; default is false
    /// </summary>
    /// <value>indicates if a sequence is to repeat from the beginning after the last campaign completes; default is false</value>
    public bool? Repeat { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public long? Version { get; set; }
}
