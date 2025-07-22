using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceBotVariable
{
    /// <summary>
    /// The variable ID
    /// </summary>
    /// <value>The variable ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The variable display name
    /// </summary>
    /// <value>The variable display name</value>
    public string Name { get; set; }

    /// <summary>
    /// The variable description
    /// </summary>
    /// <value>The variable description</value>
    public string Description { get; set; }

    /// <summary>
    /// True if the variable is a reserved variable
    /// </summary>
    /// <value>True if the variable is a reserved variable</value>
    public bool? Reserved { get; set; }

    /// <summary>
    /// The type information for this variable
    /// </summary>
    /// <value>The type information for this variable</value>
    public string SimpleVariableInfo { get; set; }

    /// <summary>
    /// The type information for this variable
    /// </summary>
    /// <value>The type information for this variable</value>
    public ComplexVariableInfo ComplexGenericVariableInfo { get; set; }
}
