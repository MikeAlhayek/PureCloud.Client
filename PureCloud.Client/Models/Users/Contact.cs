namespace PureCloud.Client.Models.Users;

public sealed class Contact
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public MediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public ContactTypeEnum? Type { get; set; }

    /// <summary>
    /// Email address or phone number for this contact type
    /// </summary>
    /// <value>Email address or phone number for this contact type</value>
    public string Address { get; set; }

    /// <summary>
    /// Formatted version of the address property
    /// </summary>
    /// <value>Formatted version of the address property</value>
    public string Display { get; private set; }

    /// <summary>
    /// Use internal extension instead of address. Mutually exclusive with the address field.
    /// </summary>
    /// <value>Use internal extension instead of address. Mutually exclusive with the address field.</value>
    public string Extension { get; set; }

    /// <summary>
    /// Gets or Sets CountryCode
    /// </summary>
    public string CountryCode { get; set; }

    /// <summary>
    /// Integration tag value if this number is associated with an external integration.
    /// </summary>
    /// <value>Integration tag value if this number is associated with an external integration.</value>
    public string Integration { get; set; }
}
