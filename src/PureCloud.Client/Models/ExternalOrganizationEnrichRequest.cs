using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalOrganizationEnrichRequest
{
    /// <summary>
    /// The action that should be taken based on any External Organization found by `matchingIdentifiers`.
    /// </summary>
    /// <value>The action that should be taken based on any External Organization found by `matchingIdentifiers`.</value>
    public ExternalOrganizationEnrichRequestActionEnum? Action { get; set; }

    /// <summary>
    /// A user-specified tracker string, only useful in the Bulk-Enrich API. If one Bulk-Enrich operation in a request fails, the requested operation will be repeated in the Bulk API response, including this id field, allowing associating request and response operations.
    /// </summary>
    /// <value>A user-specified tracker string, only useful in the Bulk-Enrich API. If one Bulk-Enrich operation in a request fails, the requested operation will be repeated in the Bulk API response, including this id field, allowing associating request and response operations.</value>
    public string Id { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableStarrableDivision Division { get; set; }

    /// <summary>
    /// An ordered list of one or more Identifiers which might each be claimed by an External Organization. &#x60;action&#x60; describes what to do with any possibly matching External Organization. Identifier lookups will occur in the order specified here.
    /// </summary>
    /// <value>An ordered list of one or more Identifiers which might each be claimed by an External Organization. &#x60;action&#x60; describes what to do with any possibly matching External Organization. Identifier lookups will occur in the order specified here.</value>
    public IEnumerable<ExternalOrganizationIdentifier> MatchingIdentifiers { get; set; }

    /// <summary>
    /// Data to be added, either as an update to an existing External Organization or the body of a new External Organization. Omitting a field in this contract means that it will be treated as null in the &#x60;fieldRules&#x60; logic.
    /// </summary>
    /// <value>Data to be added, either as an update to an existing External Organization or the body of a new External Organization. Omitting a field in this contract means that it will be treated as null in the &#x60;fieldRules&#x60; logic.</value>
    public ExternalOrganization ExternalOrganization { get; set; }

    /// <summary>
    /// Logic describing how to combine data from the submitted request with data found in the database.
    /// </summary>
    /// <value>Logic describing how to combine data from the submitted request with data found in the database.</value>
    public EnrichFieldRules FieldRules { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
