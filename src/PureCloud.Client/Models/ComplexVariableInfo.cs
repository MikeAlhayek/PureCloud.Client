using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ComplexVariableInfo
{
    /// <summary>
    /// The variable type ID
    /// </summary>
    /// <value>The variable type ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The variable type display name
    /// </summary>
    /// <value>The variable type display name</value>
    public string Name { get; set; }
}
