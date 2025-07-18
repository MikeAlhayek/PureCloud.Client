using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AcceleratorInput
{
    /// <summary>
    /// Set this true to test the job without making any changes. Defaults to false.
    /// </summary>
    public bool? DryRun { get; set; }

    /// <summary>
    /// Accelerator ID
    /// </summary>
    public string AcceleratorId { get; set; }

    /// <summary>
    /// Parameters required for this accelerator
    /// </summary>
    public IEnumerable<AcceleratorParameter> Parameters { get; set; }
}
