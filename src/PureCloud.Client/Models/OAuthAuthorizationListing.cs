using System.Collections.Generic;

namespace PureCloud.Client.Models;

public sealed class OAuthAuthorizationListing
{
    public long? Total { get; set; }
    public IEnumerable<OAuthAuthorization> Entities { get; set; }
    public string SelfUri { get; set; }
}
