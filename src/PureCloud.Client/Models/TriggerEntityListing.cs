namespace PureCloud.Client.Models;

public sealed class TriggerEntityListing
{
    public IEnumerable<Trigger> Entities { get; set; }
    public string NextUri { get; set; }
    public string SelfUri { get; set; }
    public string PreviousUri { get; set; }
}
