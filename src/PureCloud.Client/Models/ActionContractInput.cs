using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ActionContractInput
{
    /// <summary>
    /// Execution input contract
    /// </summary>
    /// <value>Execution input contract</value>
    public PostInputContract Input { get; set; }

    /// <summary>
    /// Execution output contract
    /// </summary>
    /// <value>Execution output contract</value>
    public PostOutputContract Output { get; set; }
}
