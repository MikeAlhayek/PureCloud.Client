using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ValidationLimits
{
    /// <summary>
    /// Gets or Sets MinLength
    /// </summary>
    public MinLength MinLength { get; set; }

    /// <summary>
    /// Gets or Sets MaxLength
    /// </summary>
    public MaxLength MaxLength { get; set; }

    /// <summary>
    /// Gets or Sets MinItems
    /// </summary>
    public MinLength MinItems { get; set; }

    /// <summary>
    /// Gets or Sets MaxItems
    /// </summary>
    public MaxLength MaxItems { get; set; }

    /// <summary>
    /// Gets or Sets Minimum
    /// </summary>
    public MinLength Minimum { get; set; }

    /// <summary>
    /// Gets or Sets Maximum
    /// </summary>
    public MaxLength Maximum { get; set; }
}
