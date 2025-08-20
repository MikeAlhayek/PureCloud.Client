namespace PureCloud.Client.Models;

/// <summary>
/// The Footer template identifies the Footer type and its footerUsage
/// </summary>
public sealed class FooterTemplate
{
    /// <summary>
    /// The Footer template identifies the Footer type and its footerUsage
    /// </summary>
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FooterTemplate" /> class.
    /// </summary>
    public IEnumerable<ApplicableResourcesEnum> ApplicableResources { get; set; }
}
