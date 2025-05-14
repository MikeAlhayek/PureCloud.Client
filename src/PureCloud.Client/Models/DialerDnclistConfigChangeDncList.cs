using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerDnclistConfigChangeDncList
{
    /// <summary>
    /// the type of dnc list being created, rds (csv file), gryphon, or dnc.com
    /// </summary>
    /// <value>the type of dnc list being created, rds (csv file), gryphon, or dnc.com</value>
    public DialerDnclistConfigChangeDncListDncSourceTypeEnum? DncSourceType { get; set; }

    /// <summary>
    /// Gets or Sets ContactMethod
    /// </summary>
    public DialerDnclistConfigChangeDncListContactMethodEnum? ContactMethod { get; set; }

    /// <summary>
    /// Gets or Sets ImportStatus
    /// </summary>
    public DialerDnclistConfigChangeImportStatus ImportStatus { get; set; }

    /// <summary>
    /// the number of phone numbers in the do not call list
    /// </summary>
    /// <value>the number of phone numbers in the do not call list</value>
    public long? Size { get; set; }

    /// <summary>
    /// the loginId if the dncSourceType is dnc.com
    /// </summary>
    /// <value>the loginId if the dncSourceType is dnc.com</value>
    public string LoginId { get; set; }

    /// <summary>
    /// the list of dnc.com codes to be treated as DNC
    /// </summary>
    /// <value>the list of dnc.com codes to be treated as DNC</value>
    public IEnumerable<string> DncCodes { get; set; }

    /// <summary>
    /// the license number if the dncSourceType is gryphon
    /// </summary>
    /// <value>the license number if the dncSourceType is gryphon</value>
    public string LicenseId { get; set; }

    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public DialerDnclistConfigChangeUriReference Division { get; set; }

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
