using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainOrganizationRoleUpdate
/// </summary>

public partial class DomainOrganizationRoleUpdate : IEquatable<DomainOrganizationRoleUpdate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DomainOrganizationRoleUpdate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DomainOrganizationRoleUpdate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainOrganizationRoleUpdate" /> class.
    /// </summary>
    /// <param name="Id">role id.</param>
    /// <param name="Name">The name of the role (required).</param>
    /// <param name="Description">Description.</param>
    /// <param name="DefaultRoleId">DefaultRoleId.</param>
    /// <param name="Permissions">Permissions.</param>
    /// <param name="PermissionPolicies">PermissionPolicies.</param>
    /// <param name="UserCount">UserCount.</param>
    /// <param name="RoleNeedsUpdate">Optional unless patch operation..</param>
    /// <param name="Base">Base.</param>
    /// <param name="Default">Default.</param>
    public DomainOrganizationRoleUpdate(string Id = null, string Name = null, string Description = null, string DefaultRoleId = null, List<string> Permissions = null, List<DomainPermissionPolicy> PermissionPolicies = null, int? UserCount = null, bool? RoleNeedsUpdate = null, bool? Base = null, bool? Default = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.DefaultRoleId = DefaultRoleId;
        this.Permissions = Permissions;
        this.PermissionPolicies = PermissionPolicies;
        this.UserCount = UserCount;
        this.RoleNeedsUpdate = RoleNeedsUpdate;
        this.Base = Base;
        this.Default = Default;

    }



    /// <summary>
    /// role id
    /// </summary>
    /// <value>role id</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the role
    /// </summary>
    /// <value>The name of the role</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets DefaultRoleId
    /// </summary>
    [JsonPropertyName("defaultRoleId")]
    public string DefaultRoleId { get; set; }



    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [JsonPropertyName("permissions")]
    public List<string> Permissions { get; set; }



    /// <summary>
    /// A collection of the permissions the role is not using
    /// </summary>
    /// <value>A collection of the permissions the role is not using</value>
    [JsonPropertyName("unusedPermissions")]
    public List<string> UnusedPermissions { get; private set; }



    /// <summary>
    /// Gets or Sets PermissionPolicies
    /// </summary>
    [JsonPropertyName("permissionPolicies")]
    public List<DomainPermissionPolicy> PermissionPolicies { get; set; }



    /// <summary>
    /// Gets or Sets UserCount
    /// </summary>
    [JsonPropertyName("userCount")]
    public int? UserCount { get; set; }



    /// <summary>
    /// Optional unless patch operation.
    /// </summary>
    /// <value>Optional unless patch operation.</value>
    [JsonPropertyName("roleNeedsUpdate")]
    public bool? RoleNeedsUpdate { get; set; }



    /// <summary>
    /// Gets or Sets Base
    /// </summary>
    [JsonPropertyName("base")]
    public bool? Base { get; set; }



    /// <summary>
    /// Gets or Sets Default
    /// </summary>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }



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
        sb.Append("class DomainOrganizationRoleUpdate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DefaultRoleId: ").Append(DefaultRoleId).Append("\n");
        sb.Append("  Permissions: ").Append(Permissions).Append("\n");
        sb.Append("  UnusedPermissions: ").Append(UnusedPermissions).Append("\n");
        sb.Append("  PermissionPolicies: ").Append(PermissionPolicies).Append("\n");
        sb.Append("  UserCount: ").Append(UserCount).Append("\n");
        sb.Append("  RoleNeedsUpdate: ").Append(RoleNeedsUpdate).Append("\n");
        sb.Append("  Base: ").Append(Base).Append("\n");
        sb.Append("  Default: ").Append(Default).Append("\n");
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
        return Equals(obj as DomainOrganizationRoleUpdate);
    }

    /// <summary>
    /// Returns true if DomainOrganizationRoleUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainOrganizationRoleUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainOrganizationRoleUpdate other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DefaultRoleId == other.DefaultRoleId ||
                DefaultRoleId != null &&
                DefaultRoleId.Equals(other.DefaultRoleId)
            ) &&
            (
                Permissions == other.Permissions ||
                Permissions != null &&
                Permissions.SequenceEqual(other.Permissions)
            ) &&
            (
                UnusedPermissions == other.UnusedPermissions ||
                UnusedPermissions != null &&
                UnusedPermissions.SequenceEqual(other.UnusedPermissions)
            ) &&
            (
                PermissionPolicies == other.PermissionPolicies ||
                PermissionPolicies != null &&
                PermissionPolicies.SequenceEqual(other.PermissionPolicies)
            ) &&
            (
                UserCount == other.UserCount ||
                UserCount != null &&
                UserCount.Equals(other.UserCount)
            ) &&
            (
                RoleNeedsUpdate == other.RoleNeedsUpdate ||
                RoleNeedsUpdate != null &&
                RoleNeedsUpdate.Equals(other.RoleNeedsUpdate)
            ) &&
            (
                Base == other.Base ||
                Base != null &&
                Base.Equals(other.Base)
            ) &&
            (
                Default == other.Default ||
                Default != null &&
                Default.Equals(other.Default)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DefaultRoleId != null)
            {
                hash = hash * 59 + DefaultRoleId.GetHashCode();
            }

            if (Permissions != null)
            {
                hash = hash * 59 + Permissions.GetHashCode();
            }

            if (UnusedPermissions != null)
            {
                hash = hash * 59 + UnusedPermissions.GetHashCode();
            }

            if (PermissionPolicies != null)
            {
                hash = hash * 59 + PermissionPolicies.GetHashCode();
            }

            if (UserCount != null)
            {
                hash = hash * 59 + UserCount.GetHashCode();
            }

            if (RoleNeedsUpdate != null)
            {
                hash = hash * 59 + RoleNeedsUpdate.GetHashCode();
            }

            if (Base != null)
            {
                hash = hash * 59 + Base.GetHashCode();
            }

            if (Default != null)
            {
                hash = hash * 59 + Default.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
