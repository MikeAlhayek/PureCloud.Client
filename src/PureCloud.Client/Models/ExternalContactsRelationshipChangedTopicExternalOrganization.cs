using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsRelationshipChangedTopicExternalOrganization
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ExternalContactsRelationshipChangedTopicDivision Division { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets CompanyType
    /// </summary>
    public string CompanyType { get; set; }

    /// <summary>
    /// Gets or Sets Industry
    /// </summary>
    public string Industry { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryContactId
    /// </summary>
    public string PrimaryContactId { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public ExternalContactsRelationshipChangedTopicContactAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    public ExternalContactsRelationshipChangedTopicPhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets FaxNumber
    /// </summary>
    public ExternalContactsRelationshipChangedTopicPhoneNumber FaxNumber { get; set; }

    /// <summary>
    /// Gets or Sets EmployeeCount
    /// </summary>
    public long? EmployeeCount { get; set; }

    /// <summary>
    /// Gets or Sets Revenue
    /// </summary>
    public long? Revenue { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    public IEnumerable<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets Websites
    /// </summary>
    public IEnumerable<string> Websites { get; set; }

    /// <summary>
    /// Gets or Sets Tickers
    /// </summary>
    public IEnumerable<ExternalContactsRelationshipChangedTopicTicker> Tickers { get; set; }

    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    public ExternalContactsRelationshipChangedTopicTwitterId TwitterId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalSystemUrl
    /// </summary>
    public string ExternalSystemUrl { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    public Dictionary<string, object> CustomFields { get; set; }

    /// <summary>
    /// Gets or Sets CreateDate
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    public DateTime? ModifyDate { get; set; }
}
