namespace PureCloud.Client.Models;

/// <summary>
/// Station
/// </summary>
public sealed class Station
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public StationStatus? Status { get; set; }

    /// <summary>
    /// The Id of the user currently logged in and associated with the station.
    /// </summary>
    /// <value>The Id of the user currently logged in and associated with the station.</value>
    public string UserId { get; set; }

    /// <summary>
    /// The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone.
    /// </summary>
    /// <value>The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone.</value>
    public string WebRtcUserId { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryEdge
    /// </summary>
    public DomainEntityRef PrimaryEdge { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryEdge
    /// </summary>
    public DomainEntityRef SecondaryEdge { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets LineAppearanceId
    /// </summary>
    public string LineAppearanceId { get; set; }

    /// <summary>
    /// The default or configured value of media dscp for the station. Empty if station type is not inin_webrtc_softphone.
    /// </summary>
    /// <value>The default or configured value of media dscp for the station. Empty if station type is not inin_webrtc_softphone.</value>
    public int? WebRtcMediaDscp { get; set; }

    /// <summary>
    /// The default or configured value of persistent connection setting for the station. Empty if station type is not inin_webrtc_softphone.
    /// </summary>
    /// <value>The default or configured value of persistent connection setting for the station. Empty if station type is not inin_webrtc_softphone.</value>
    public bool? WebRtcPersistentEnabled { get; set; }

    /// <summary>
    /// Whether the station is configured to require TURN for routing WebRTC calls. Empty if station type is not inin_webrtc_softphone.
    /// </summary>
    /// <value>Whether the station is configured to require TURN for routing WebRTC calls. Empty if station type is not inin_webrtc_softphone.</value>
    public bool? WebRtcForceTurn { get; set; }

    /// <summary>
    /// The number of call appearances on the station.
    /// </summary>
    /// <value>The number of call appearances on the station.</value>
    public int? WebRtcCallAppearances { get; set; }

    /// <summary>
    /// True when the media helper required.
    /// </summary>
    /// <value>True when the media helper required.</value>
    public bool? WebRtcRequireMediaHelper { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}