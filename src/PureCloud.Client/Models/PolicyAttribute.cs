using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PolicyAttribute
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public PolicyAttributeTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets FeatureToggle
    /// </summary>
    public string FeatureToggle { get; set; }
}
