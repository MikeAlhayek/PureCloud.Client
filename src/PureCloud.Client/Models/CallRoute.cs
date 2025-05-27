using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CallRoute
{
    /// <summary>
    /// A list of CallTargets to be called when the CallRoute is executed
    /// </summary>
    /// <value>A list of CallTargets to be called when the CallRoute is executed</value>
    public List<CallTarget> Targets { get; set; }
}
