using System.Collections.Generic;

namespace PureCloud.Client.Models;

public sealed class LimitChangeRequestsEntityListing
{
    public IEnumerable<LimitChangeRequestDetails> Entities { get; set; }
    public string NextUri { get; set; }
    public string SelfUri { get; set; }
    public string PreviousUri { get; set; }
}
