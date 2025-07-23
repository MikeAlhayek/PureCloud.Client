namespace PureCloud.Client.Models;

public sealed class UserLicensesEntityListing
{
    public IEnumerable<UserLicenses> Entities { get; set; }
    public int? PageSize { get; set; }
    public int? PageNumber { get; set; }
    public long? Total { get; set; }
    public int? PageCount { get; set; }
}
