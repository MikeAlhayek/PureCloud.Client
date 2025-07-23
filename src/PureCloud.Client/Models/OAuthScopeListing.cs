using System.Collections.Generic;

namespace PureCloud.Client.Models;

public sealed class OAuthScopeListing
{
    public long? Total { get; set; }
    public IEnumerable<OAuthScope> Entities { get; set; }
    public string SelfUri { get; set; }
}
