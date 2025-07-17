using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Member
{
    /// <summary>
    /// The user&#39;s id
    /// </summary>
    /// <value>The user&#39;s id</value>
    public string Id { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
