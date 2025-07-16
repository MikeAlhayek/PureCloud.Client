using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class Relationship
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
    /// The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note.
    /// </summary>
    /// <value>The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note.</value>
    public User User { get; set; }

    /// <summary>
    /// The external organization this relationship is attached to
    /// </summary>
    /// <value>The external organization this relationship is attached to</value>
    public ExternalOrganization ExternalOrganization { get; set; }

    /// <summary>
    /// The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant
    /// </summary>
    /// <value>The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant</value>
    public string _Relationship { get; set; }

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
