using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CelebrationStateParam
{
    /// <summary>
    /// The state of the celebration
    /// </summary>
    /// <value>The state of the celebration</value>
    public CelebrationStateParamStateEnum? State { get; set; }
}
