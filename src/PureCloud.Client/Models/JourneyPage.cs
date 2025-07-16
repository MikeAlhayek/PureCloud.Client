using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyPage
{
    /// <summary>
    /// The page URL.
    /// </summary>
    /// <value>The page URL.</value>
    public string Url { get; set; }

    /// <summary>
    /// Title of the page.
    /// </summary>
    /// <value>Title of the page.</value>
    public string Title { get; set; }

    /// <summary>
    /// Domain of the page&#39;s URL.
    /// </summary>
    /// <value>Domain of the page&#39;s URL.</value>
    public string Domain { get; set; }

    /// <summary>
    /// Fragment or hash of the page&#39;s URL.
    /// </summary>
    /// <value>Fragment or hash of the page&#39;s URL.</value>
    public string Fragment { get; set; }

    /// <summary>
    /// Hostname of the page&#39;s URL.
    /// </summary>
    /// <value>Hostname of the page&#39;s URL.</value>
    public string Hostname { get; set; }

    /// <summary>
    /// Keywords from the HTML {@code &lt;meta&gt;} tag of the page.
    /// </summary>
    /// <value>Keywords from the HTML {@code &lt;meta&gt;} tag of the page.</value>
    public string Keywords { get; set; }

    /// <summary>
    /// ISO 639-1 language code for the page as defined in the {@code &lt;html&gt;} tag.
    /// </summary>
    /// <value>ISO 639-1 language code for the page as defined in the {@code &lt;html&gt;} tag.</value>
    public string Lang { get; set; }

    /// <summary>
    /// Path name of the page for the event.
    /// </summary>
    /// <value>Path name of the page for the event.</value>
    public string Pathname { get; set; }

    /// <summary>
    /// Query string that is passed to the page in the current event.
    /// </summary>
    /// <value>Query string that is passed to the page in the current event.</value>
    public string QueryString { get; set; }

    /// <summary>
    /// Hierarchy of the current page in relation to the website&#39;s structure.
    /// </summary>
    /// <value>Hierarchy of the current page in relation to the website&#39;s structure.</value>
    public IEnumerable<string> Breadcrumb { get; set; }
}
