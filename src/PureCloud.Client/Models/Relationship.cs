using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Relationship
/// </summary>

public partial class Relationship : IEquatable<Relationship>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Relationship" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Relationship() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Relationship" /> class.
    /// </summary>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="User">The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note. (required).</param>
    /// <param name="ExternalOrganization">The external organization this relationship is attached to (required).</param>
    /// <param name="_Relationship">The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant (required).</param>
    public Relationship(WritableStarrableDivision Division = null, User User = null, ExternalOrganization ExternalOrganization = null, string _Relationship = null)
    {
        this.Division = Division;
        this.User = User;
        this.ExternalOrganization = ExternalOrganization;
        this._Relationship = _Relationship;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableStarrableDivision Division { get; set; }



    /// <summary>
    /// The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note.
    /// </summary>
    /// <value>The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note.</value>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// The external organization this relationship is attached to
    /// </summary>
    /// <value>The external organization this relationship is attached to</value>
    [JsonPropertyName("externalOrganization")]
    public ExternalOrganization ExternalOrganization { get; set; }



    /// <summary>
    /// The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant
    /// </summary>
    /// <value>The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant</value>
    [JsonPropertyName("relationship")]
    public string _Relationship { get; set; }



    /// <summary>
    /// Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.
    /// </summary>
    /// <value>Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.</value>
    [JsonPropertyName("externalDataSources")]
    public List<ExternalDataSource> ExternalDataSources { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Relationship {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
        sb.Append("  _Relationship: ").Append(_Relationship).Append("\n");
        sb.Append("  ExternalDataSources: ").Append(ExternalDataSources).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as Relationship);
    }

    /// <summary>
    /// Returns true if Relationship instances are equal
    /// </summary>
    /// <param name="other">Instance of Relationship to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Relationship other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                ExternalOrganization == other.ExternalOrganization ||
                ExternalOrganization != null &&
                ExternalOrganization.Equals(other.ExternalOrganization)
            ) &&
            (
                _Relationship == other._Relationship ||
                _Relationship != null &&
                _Relationship.Equals(other._Relationship)
            ) &&
            (
                ExternalDataSources == other.ExternalDataSources ||
                ExternalDataSources != null &&
                ExternalDataSources.SequenceEqual(other.ExternalDataSources)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (ExternalOrganization != null)
            {
                hash = hash * 59 + ExternalOrganization.GetHashCode();
            }

            if (_Relationship != null)
            {
                hash = hash * 59 + _Relationship.GetHashCode();
            }

            if (ExternalDataSources != null)
            {
                hash = hash * 59 + ExternalDataSources.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
