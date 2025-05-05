namespace PureCloud.Client.Models;

/// <summary>
/// Address and name data for a call endpoint.
/// </summary>

public sealed class ConversationEventTopicAddress
{
    /// <summary>
    /// This will be nameRaw if present, or a locality lookup of the address field otherwise.
    /// </summary>
    /// <value>This will be nameRaw if present, or a locality lookup of the address field otherwise.</value>
    public string Name { get; set; }

    /// <summary>
    /// The name as close to the bits on the wire as possible.
    /// </summary>
    /// <value>The name as close to the bits on the wire as possible.</value>
    public string NameRaw { get; set; }

    /// <summary>
    /// The normalized address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table.
    /// </summary>
    /// <value>The normalized address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table.</value>
    public string AddressNormalized { get; set; }

    /// <summary>
    /// The address as close to the bits on the wire as possible.
    /// </summary>
    /// <value>The address as close to the bits on the wire as possible.</value>
    public string AddressRaw { get; set; }

    /// <summary>
    /// The displayable address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table.
    /// </summary>
    /// <value>The displayable address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table.</value>
    public string AddressDisplayable { get; set; }
}
