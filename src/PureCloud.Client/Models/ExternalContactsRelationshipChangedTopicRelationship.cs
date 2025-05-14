using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsRelationshipChangedTopicRelationship
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
    /// Gets or Sets User
    /// </summary>
    public ExternalContactsRelationshipChangedTopicUser User { get; set; }

    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    public ExternalContactsRelationshipChangedTopicExternalOrganization ExternalOrganization { get; set; }

    /// <summary>
    /// Gets or Sets Relationship
    /// </summary>
    public string Relationship { get; set; }

    /// <summary>
    /// Gets or Sets CreateDate
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    public DateTime? ModifyDate { get; set; }
}
