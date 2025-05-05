namespace PureCloud.Client.Models.Users;

public sealed class UserSearchRequest : SearchRequest
{
    /// <summary>
    /// This property only applies to api/v2/user/search; when set to true add additional search criteria to filter users by: directory:user:view
    /// </summary>
    /// <value>This property only applies to api/v2/user/search; when set to true add additional search criteria to filter users by: directory:user:view</value>
    public bool? EnforcePermissions { get; set; }
}
