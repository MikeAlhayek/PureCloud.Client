using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserAvailableTimes
{
    /// <summary>
    /// User reference
    /// </summary>
    /// <value>User reference</value>
    public UserReference User { get; set; }

    /// <summary>
    /// Periods of availability to schedule coaching appointment for an user
    /// </summary>
    /// <value>Periods of availability to schedule coaching appointment for an user</value>
    public IEnumerable<AvailableTime> AvailableTimes { get; set; }
}
