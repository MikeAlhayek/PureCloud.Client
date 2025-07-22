using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialogflowIntent
{
    /// <summary>
    /// The intent name
    /// </summary>
    /// <value>The intent name</value>
    public string Name { get; set; }

    /// <summary>
    /// An object mapping parameter names to Parameter objects
    /// </summary>
    /// <value>An object mapping parameter names to Parameter objects</value>
    public Dictionary<string, DialogflowParameter> Parameters { get; set; }
}
