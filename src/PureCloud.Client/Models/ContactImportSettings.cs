using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactImportSettings
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Display name for the settings
    /// </summary>
    /// <value>Display name for the settings</value>
    public string Name { get; set; }

    /// <summary>
    /// Which fields you want to identity resolution based on. (e.g.: Email, Phone). It can be empty, populated only one of them or it can be both for now. The order of the items is important for identity resolution
    /// </summary>
    /// <value>Which fields you want to identity resolution based on. (e.g.: Email, Phone). It can be empty, populated only one of them or it can be both for now. The order of the items is important for identity resolution</value>
    public IEnumerable<ContactImportSettingsMatchingCriteriaEnum> MatchingCriteria { get; set; }

    /// <summary>
    /// Decides what happens when a record already found in the system. Action will be Upsert or Merge
    /// </summary>
    /// <value>Decides what happens when a record already found in the system. Action will be Upsert or Merge</value>
    public bool? MergeContacts { get; set; }

    /// <summary>
    /// Define the corresponding source system by the customer, the customer can have different externalId source, they can collect this id from contact service
    /// </summary>
    /// <value>Define the corresponding source system by the customer, the customer can have different externalId source, they can collect this id from contact service</value>
    public string ExternalSourceId { get; set; }

    /// <summary>
    /// Decides which field we need to send towards contact service
    /// </summary>
    /// <value>Decides which field we need to send towards contact service</value>
    public IEnumerable<ContactImportField> ImportFields { get; set; }

    /// <summary>
    /// Creation date for the settings. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation date for the settings. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
