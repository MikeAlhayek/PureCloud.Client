using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UCIntegration
{
    /// <summary>
    /// integrationPresenceType
    /// </summary>
    /// <value>integrationPresenceType</value>
    public UCIntegrationIntegrationPresenceSourceEnum? IntegrationPresenceSource { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// ucIntegrationKey
    /// </summary>
    /// <value>ucIntegrationKey</value>
    public string UcIntegrationKey { get; set; }

    /// <summary>
    /// pbxPermission
    /// </summary>
    /// <value>pbxPermission</value>
    public string PbxPermission { get; set; }

    /// <summary>
    /// icon
    /// </summary>
    /// <value>icon</value>
    public UCIcon Icon { get; set; }

    /// <summary>
    /// badgeIcon
    /// </summary>
    /// <value>badgeIcon</value>
    public Dictionary<string, UCIcon> BadgeIcons { get; set; }

    /// <summary>
    /// i10n
    /// </summary>
    /// <value>i10n</value>
    public Dictionary<string, UCI10n> I10n { get; set; }

    /// <summary>
    /// polledPresence
    /// </summary>
    /// <value>polledPresence</value>
    public bool? PolledPresence { get; set; }

    /// <summary>
    /// userPermissions
    /// </summary>
    /// <value>userPermissions</value>
    public IEnumerable<string> UserPermissions { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
