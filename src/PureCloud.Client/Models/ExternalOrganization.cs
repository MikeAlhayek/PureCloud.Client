using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalOrganization
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the company.
    /// </summary>
    /// <value>The name of the company.</value>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableStarrableDivision Division { get; set; }

    /// <summary>
    /// Gets or Sets CompanyType
    /// </summary>
    public string CompanyType { get; set; }

    /// <summary>
    /// Gets or Sets Industry
    /// </summary>
    public string Industry { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public ContactAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    public PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets FaxNumber
    /// </summary>
    public PhoneNumber FaxNumber { get; set; }

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
    public IEnumerable<Ticker> Tickers { get; set; }

    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    public TwitterId TwitterId { get; set; }

    /// <summary>
    /// A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.
    /// </summary>
    /// <value>A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.</value>
    public string ExternalSystemUrl { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifyDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Gets or Sets Trustor
    /// </summary>
    public Trustor Trustor { get; set; }

    /// <summary>
    /// The schema defining custom fields for this contact
    /// </summary>
    /// <value>The schema defining custom fields for this contact</value>
    public DataSchema Schema { get; set; }

    /// <summary>
    /// Custom fields defined in the schema referenced by schemaId and schemaVersion.
    /// </summary>
    /// <value>Custom fields defined in the schema referenced by schemaId and schemaVersion.</value>
    public Dictionary<string, object> CustomFields { get; set; }

    /// <summary>
    /// Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.
    /// </summary>
    /// <value>Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.</value>
    public IEnumerable<ExternalDataSource> ExternalDataSources { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
