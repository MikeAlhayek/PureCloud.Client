using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ResponseConfig
{
    /// <summary>
    /// Map &#39;attribute name&#39; and &#39;JSON path&#39; pairs used to extract data from REST response.
    /// </summary>
    /// <value>Map &#39;attribute name&#39; and &#39;JSON path&#39; pairs used to extract data from REST response.</value>
    public Dictionary<string, string> TranslationMap { get; set; }

    /// <summary>
    /// Map &#39;attribute name&#39; and &#39;default value&#39; pairs used as fallback values if JSON path extraction fails for specified key.
    /// </summary>
    /// <value>Map &#39;attribute name&#39; and &#39;default value&#39; pairs used as fallback values if JSON path extraction fails for specified key.</value>
    public Dictionary<string, string> TranslationMapDefaults { get; set; }

    /// <summary>
    /// Velocity template to build response to return from Action.
    /// </summary>
    /// <value>Velocity template to build response to return from Action.</value>
    public string SuccessTemplate { get; set; }

    /// <summary>
    /// URI to retrieve success template.
    /// </summary>
    /// <value>URI to retrieve success template.</value>
    public string SuccessTemplateUri { get; set; }
}
