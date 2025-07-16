using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContact
{
    /// <summary>
    /// The type of contact
    /// </summary>
    /// <value>The type of contact</value>
    public ExternalContactTypeEnum? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableStarrableDivision Division { get; set; }

    /// <summary>
    /// The first name of the contact.
    /// </summary>
    /// <value>The first name of the contact.</value>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets MiddleName
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// The last name of the contact.
    /// </summary>
    /// <value>The last name of the contact.</value>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Salutation
    /// </summary>
    public string Salutation { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets WorkPhone
    /// </summary>
    public PhoneNumber WorkPhone { get; set; }

    /// <summary>
    /// Gets or Sets CellPhone
    /// </summary>
    public PhoneNumber CellPhone { get; set; }

    /// <summary>
    /// Gets or Sets HomePhone
    /// </summary>
    public PhoneNumber HomePhone { get; set; }

    /// <summary>
    /// Gets or Sets OtherPhone
    /// </summary>
    public PhoneNumber OtherPhone { get; set; }

    /// <summary>
    /// Gets or Sets WorkEmail
    /// </summary>
    public string WorkEmail { get; set; }

    /// <summary>
    /// Gets or Sets PersonalEmail
    /// </summary>
    public string PersonalEmail { get; set; }

    /// <summary>
    /// Gets or Sets OtherEmail
    /// </summary>
    public string OtherEmail { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public ContactAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    public TwitterId TwitterId { get; set; }

    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    public LineId LineId { get; set; }

    /// <summary>
    /// Gets or Sets WhatsAppId
    /// </summary>
    public WhatsAppId WhatsAppId { get; set; }

    /// <summary>
    /// Gets or Sets FacebookId
    /// </summary>
    public FacebookId FacebookId { get; set; }

    /// <summary>
    /// A list of external identifiers that identify this contact in an external system
    /// </summary>
    /// <value>A list of external identifiers that identify this contact in an external system</value>
    public IEnumerable<ExternalId> ExternalIds { get; set; }

    /// <summary>
    /// Identifiers claimed by this contact
    /// </summary>
    /// <value>Identifiers claimed by this contact</value>
    public IEnumerable<ContactIdentifier> Identifiers { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifyDate { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    public ExternalOrganization ExternalOrganization { get; set; }

    /// <summary>
    /// Gets or Sets SurveyOptOut
    /// </summary>
    public bool? SurveyOptOut { get; set; }

    /// <summary>
    /// A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.
    /// </summary>
    /// <value>A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.</value>
    public string ExternalSystemUrl { get; set; }

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
    /// The contact at the head of the merge tree. If null, this contact is not a part of any merge.
    /// </summary>
    /// <value>The contact at the head of the merge tree. If null, this contact is not a part of any merge.</value>
    public ContactAddressableEntityRef CanonicalContact { get; set; }

    /// <summary>
    /// The set of all contacts that are a part of the merge tree. If null, this contact is not a part of any merge.
    /// </summary>
    /// <value>The set of all contacts that are a part of the merge tree. If null, this contact is not a part of any merge.</value>
    public IEnumerable<ContactAddressableEntityRef> MergeSet { get; set; }

    /// <summary>
    /// Information about the merge history of this contact. If null, this contact is not a part of any merge.
    /// </summary>
    /// <value>Information about the merge history of this contact. If null, this contact is not a part of any merge.</value>
    public MergeOperation MergeOperation { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
