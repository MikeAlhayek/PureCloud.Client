namespace PureCloud.Client.Models.Locations;

public sealed class LocationDefinition
{
    /// <summary>
    /// Current state of the location entity
    /// </summary>
    /// <value>Current state of the location entity</value>
    public LocationDefinitionStateEnum? State { get; set; }

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
    /// Site contact for the location entity
    /// </summary>
    /// <value>Site contact for the location entity</value>
    public AddressableEntityRef ContactUser { get; set; }

    /// <summary>
    /// Emergency number for the location entity
    /// </summary>
    /// <value>Emergency number for the location entity</value>
    public LocationEmergencyNumber EmergencyNumber { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public LocationAddress Address { get; set; }

    /// <summary>
    /// Notes for the location entity
    /// </summary>
    /// <value>Notes for the location entity</value>
    public string Notes { get; set; }

    /// <summary>
    /// Current version of the location entity, value to be supplied should be retrieved by a GET or on create/update response
    /// </summary>
    /// <value>Current version of the location entity, value to be supplied should be retrieved by a GET or on create/update response</value>
    public int? Version { get; set; }

    /// <summary>
    /// A list of ancestor IDs in order
    /// </summary>
    /// <value>A list of ancestor IDs in order</value>
    public IEnumerable<string> Path { get; set; }

    /// <summary>
    /// Profile image of the location entity, retrieved with ?expand&#x3D;images query parameter
    /// </summary>
    /// <value>Profile image of the location entity, retrieved with ?expand&#x3D;images query parameter</value>
    public IEnumerable<LocationImage> ProfileImage { get; set; }

    /// <summary>
    /// Floorplan images of the location entity, retrieved with ?expand&#x3D;images query parameter
    /// </summary>
    /// <value>Floorplan images of the location entity, retrieved with ?expand&#x3D;images query parameter</value>
    public List<LocationImage> FloorplanImage { get; set; }

    /// <summary>
    /// Address verification information, retrieve dwith the ?expand&#x3D;addressVerificationDetails query parameter
    /// </summary>
    /// <value>Address verification information, retrieve dwith the ?expand&#x3D;addressVerificationDetails query parameter</value>
    public LocationAddressVerificationDetails AddressVerificationDetails { get; set; }

    /// <summary>
    /// Boolean field which states if the address has been verified as an actual address
    /// </summary>
    /// <value>Boolean field which states if the address has been verified as an actual address</value>
    public bool? AddressVerified { get; set; }

    /// <summary>
    /// Boolean field which states if the address has been stored for E911
    /// </summary>
    /// <value>Boolean field which states if the address has been stored for E911</value>
    public bool? AddressStored { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    public string Images { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
