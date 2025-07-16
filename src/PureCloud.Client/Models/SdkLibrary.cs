using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SdkLibrary
{
    /// <summary>
    /// The name of the SDK.
    /// </summary>
    /// <value>The name of the SDK.</value>
    public string Name { get; set; }

    /// <summary>
    /// The version of the SDK.
    /// </summary>
    /// <value>The version of the SDK.</value>
    public string Version { get; set; }
}
