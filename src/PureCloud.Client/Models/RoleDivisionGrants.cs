using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RoleDivisionGrants
{
    /// <summary>
    /// A list containing pairs of role and division IDs
    /// </summary>
    /// <value>A list containing pairs of role and division IDs</value>
    public IEnumerable<RoleDivisionPair> Grants { get; set; }
}
