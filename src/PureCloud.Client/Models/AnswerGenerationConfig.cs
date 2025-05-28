using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnswerGenerationConfig
{
    /// <summary>
    /// Answer generation is enabled.
    /// </summary>
    /// <value>Answer generation is enabled.</value>
    public bool? Enabled { get; set; }
}
