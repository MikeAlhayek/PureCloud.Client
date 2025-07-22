namespace PureCloud.Client.Models;

/// <summary>
/// WidgetClientConfig
/// </summary>
public sealed class WidgetClientConfig
{
    /// <summary>
    /// Gets or Sets V1
    /// </summary>
    public WidgetClientConfigV1 V1 { get; set; }

    /// <summary>
    /// Gets or Sets V2
    /// </summary>
    public object V2 { get; set; }

    /// <summary>
    /// Gets or Sets V1Http
    /// </summary>
    public WidgetClientConfigV1Http V1Http { get; set; }

    /// <summary>
    /// Gets or Sets ThirdParty
    /// </summary>
    public object ThirdParty { get; set; }
}