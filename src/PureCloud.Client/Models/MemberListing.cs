using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MemberListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<Member> Entities { get; set; }
}
