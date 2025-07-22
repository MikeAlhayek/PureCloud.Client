using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialogflowParameter
{
    /// <summary>
    /// The parameter name
    /// </summary>
    /// <value>The parameter name</value>
    public string Name { get; set; }

    /// <summary>
    /// The parameter type
    /// </summary>
    /// <value>The parameter type</value>
    public string Type { get; set; }
}
