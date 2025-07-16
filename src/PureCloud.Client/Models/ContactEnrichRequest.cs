using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactEnrichRequest
{
    /// <summary>
    /// The action that should be taken based on any Contacts found by `matchingIdentifiers`.
    /// </summary>
    /// <value>The action that should be taken based on any Contacts found by `matchingIdentifiers`.</value>
    public ContactEnrichRequestActionEnum? Action { get; set; }

    /// <summary>
    /// A user-specified tracker string, only useful in the Bulk-Enrich API. If one Bulk-Enrich operation in a request fails, the requested operation will be repeated in the Bulk API response, including this id field, allowing associating of request and response operations.
    /// </summary>
    /// <value>A user-specified tracker string, only useful in the Bulk-Enrich API. If one Bulk-Enrich operation in a request fails, the requested operation will be repeated in the Bulk API response, including this id field, allowing associating of request and response operations.</value>
    public string Id { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableStarrableDivision Division { get; set; }

    /// <summary>
    /// An ordered list of one or more Identifiers which might each be claimed by a Contact. &#x60;action&#x60; describes what to do with any possibly matching Contacts. Identifier lookups will occur in the order specified here.
    /// </summary>
    /// <value>An ordered list of one or more Identifiers which might each be claimed by a Contact. &#x60;action&#x60; describes what to do with any possibly matching Contacts. Identifier lookups will occur in the order specified here.</value>
    public IEnumerable<ContactIdentifier> MatchingIdentifiers { get; set; }

    /// <summary>
    /// Data to be added, either as an update to an existing Contact or the body of a new Contact. Omitting a field in this contract means that it will be treated as null in the &#x60;fieldRules&#x60; logic.
    /// </summary>
    /// <value>Data to be added, either as an update to an existing Contact or the body of a new Contact. Omitting a field in this contract means that it will be treated as null in the &#x60;fieldRules&#x60; logic.</value>
    public ExternalContact Contact { get; set; }

    /// <summary>
    /// Logic describing how to combine data from the submitted request with data found in the database.
    /// </summary>
    /// <value>Logic describing how to combine data from the submitted request with data found in the database.</value>
    public EnrichFieldRules FieldRules { get; set; }

    /// <summary>
    /// Additional options modifying the behavior of the API operation.
    /// </summary>
    public ContactEnrichOptions Options { get; set; }
}
