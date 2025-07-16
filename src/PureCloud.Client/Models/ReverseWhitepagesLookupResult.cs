using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ReverseWhitepagesLookupResult
{
    /// <summary>
    /// Gets or Sets Contacts
    /// </summary>
    public IEnumerable<ExternalContact> Contacts { get; set; }

    /// <summary>
    /// Gets or Sets ExternalOrganizations
    /// </summary>
    public IEnumerable<ExternalOrganization> ExternalOrganizations { get; set; }
}
