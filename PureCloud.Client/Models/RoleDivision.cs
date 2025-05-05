namespace PureCloud.Client.Models;

public sealed class RoleDivision
{
    /// <summary>
    /// Role to be associated with the given division which forms a grant
    /// </summary>
    /// <value>Role to be associated with the given division which forms a grant</value>
    public string RoleId { get; set; }

    /// <summary>
    /// Division associated with the given role which forms a grant
    /// </summary>
    /// <value>Division associated with the given role which forms a grant</value>
    public string DivisionId { get; set; }
}
