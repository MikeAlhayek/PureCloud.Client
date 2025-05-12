using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsOrganizationChangedTopicContactAddress
{
    /// <summary>
    /// Gets or Sets Address1
    /// </summary>
    public string Address1 { get; set; }

    /// <summary>
    /// Gets or Sets Address2
    /// </summary>
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or Sets City
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets PostalCode
    /// </summary>
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or Sets CountryCode
    /// </summary>
    public string CountryCode { get; set; }
}
