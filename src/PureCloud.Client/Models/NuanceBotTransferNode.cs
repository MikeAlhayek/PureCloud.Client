using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NuanceBotTransferNode
{
    /// <summary>
    /// The transfer node type
    /// </summary>
    /// <value>The transfer node type</value>
    public NuanceBotTransferNodeTypeEnum? Type { get; set; }

    /// <summary>
    /// The transfer node ID
    /// </summary>
    /// <value>The transfer node ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The transfer node name
    /// </summary>
    /// <value>The transfer node name</value>
    public string Name { get; set; }

    /// <summary>
    /// The transfer node description
    /// </summary>
    /// <value>The transfer node description</value>
    public string Description { get; set; }

    /// <summary>
    /// List of variables associated with this transfer node
    /// </summary>
    /// <value>List of variables associated with this transfer node</value>
    public IEnumerable<NuanceBotVariable> RequestVariables { get; set; }
}
