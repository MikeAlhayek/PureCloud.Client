using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class Adjacents
{
    /// <summary>
    /// Gets or Sets Superiors
    /// </summary>
    public IEnumerable<User> Superiors { get; set; }

    /// <summary>
    /// Gets or Sets Siblings
    /// </summary>
    public IEnumerable<User> Siblings { get; set; }

    /// <summary>
    /// Gets or Sets DirectReports
    /// </summary>
    public IEnumerable<User> DirectReports { get; set; }
}
