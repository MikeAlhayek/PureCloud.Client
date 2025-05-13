using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerContactlistConfigChangeContactList
{
    /// <summary>
    /// the contact column names
    /// </summary>
    /// <value>the contact column names</value>
    public IEnumerable<string> ColumnNames { get; set; }

    /// <summary>
    /// the columns containing phone numbers
    /// </summary>
    /// <value>the columns containing phone numbers</value>
    public IEnumerable<DialerContactlistConfigChangeContactPhoneNumberColumn> PhoneColumns { get; set; }

    /// <summary>
    /// the columns containing email addresses
    /// </summary>
    /// <value>the columns containing email addresses</value>
    public IEnumerable<DialerContactlistConfigChangeEmailColumn> EmailColumns { get; set; }

    /// <summary>
    /// Gets or Sets ImportStatus
    /// </summary>
    public DialerContactlistConfigChangeImportStatus ImportStatus { get; set; }

    /// <summary>
    /// the name of the column that holds the indicators for contacts that are to be dialed in preview mode only
    /// </summary>
    /// <value>the name of the column that holds the indicators for contacts that are to be dialed in preview mode only</value>
    public string PreviewModeColumnName { get; set; }

    /// <summary>
    /// list of user-defined values indicating the contact is to be dialed in preview mode only
    /// </summary>
    /// <value>list of user-defined values indicating the contact is to be dialed in preview mode only</value>
    public IEnumerable<string> PreviewModeAcceptedValues { get; set; }

    /// <summary>
    /// the number of contacts in the contact list
    /// </summary>
    /// <value>the number of contacts in the contact list</value>
    public long? Size { get; set; }

    /// <summary>
    /// Gets or Sets AttemptLimits
    /// </summary>
    public DialerContactlistConfigChangeUriReference AttemptLimits { get; set; }

    /// <summary>
    /// whether or not automatic time zone mapping is enabled on the list
    /// </summary>
    /// <value>whether or not automatic time zone mapping is enabled on the list</value>
    public bool? AutomaticTimeZoneMapping { get; set; }

    /// <summary>
    /// zip code column from the contact list to be used optionally with automatic time zone mapping
    /// </summary>
    /// <value>zip code column from the contact list to be used optionally with automatic time zone mapping</value>
    public string ZipCodeColumnName { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerContactlistConfigChangeUriReference Division { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public long? Version { get; set; }
}
