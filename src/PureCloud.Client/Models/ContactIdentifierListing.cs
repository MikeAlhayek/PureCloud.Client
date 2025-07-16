using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactIdentifierListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<ContactIdentifier> Entities { get; set; }
}
