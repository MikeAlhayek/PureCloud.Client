namespace PureCloud.Client.Models.Groups;

public sealed class GroupContact
{

    /// <summary>
    /// Contact type of the address
    /// </summary>
    /// <value>Contact type of the address</value>
    public GroupContactType? Type { get; set; }

    /// <summary>
    /// Media type of the address
    /// </summary>
    /// <value>Media type of the address</value>
    public GroupContactMediaType? MediaType { get; set; }

    /// <summary>
    /// Phone number for this contact type
    /// </summary>
    /// <value>Phone number for this contact type</value>
    public string Address { get; set; }

    /// <summary>
    /// Extension is set if the number is e164 valid
    /// </summary>
    /// <value>Extension is set if the number is e164 valid</value>
    public string Extension { get; set; }

    /// <summary>
    /// Formatted version of the address property
    /// </summary>
    /// <value>Formatted version of the address property</value>
    public string Display { get; set; }
}
