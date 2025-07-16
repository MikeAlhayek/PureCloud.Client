using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalOrganizationTrustorLink
{
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
    /// The id of a PureCloudEnvironment External Organization entity in the External Contacts system that will be used to represent the trustor org
    /// </summary>
    /// <value>The id of a PureCloudEnvironment External Organization entity in the External Contacts system that will be used to represent the trustor org</value>
    public string ExternalOrganizationId { get; set; }

    /// <summary>
    /// The id of a PureCloudEnvironment organization that has granted trust to this PureCloudEnvironment organization
    /// </summary>
    /// <value>The id of a PureCloudEnvironment organization that has granted trust to this PureCloudEnvironment organization</value>
    public string TrustorOrgId { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The URI for the External Organization that is linked to the trustor org
    /// </summary>
    /// <value>The URI for the External Organization that is linked to the trustor org</value>
    public string ExternalOrganizationUri { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
