using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalOrganizationIdentifierListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ExternalOrganizationIdentifier> Entities { get; set; }
}
