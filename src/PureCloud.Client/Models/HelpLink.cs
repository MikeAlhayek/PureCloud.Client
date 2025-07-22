using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class HelpLink
{
    /// <summary>
    /// URI of the help resource
    /// </summary>
    /// <value>URI of the help resource</value>
    public string Uri { get; set; }

    /// <summary>
    /// Link text of the resource
    /// </summary>
    /// <value>Link text of the resource</value>
    public string Title { get; set; }

    /// <summary>
    /// Description of the document or resource
    /// </summary>
    /// <value>Description of the document or resource</value>
    public string Description { get; set; }
}
