using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class QueueMember
{
    public string Id { get; set; }
    public string Name { get; set; }
    public User User { get; set; }
    public int? RingNumber { get; set; }
    public bool? Joined { get; set; }
    public string MemberBy { get; set; }
    public RoutingStatus RoutingStatus { get; set; }
    public string SelfUri { get; set; }
}
