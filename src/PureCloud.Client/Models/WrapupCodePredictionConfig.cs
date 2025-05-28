using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WrapupCodePredictionConfig
{
    /// <summary>
    /// Copilot generated wrapup code prediction is enabled.
    /// </summary>
    /// <value>Copilot generated wrapup code prediction is enabled.</value>
    public bool? Enabled { get; set; }
}
