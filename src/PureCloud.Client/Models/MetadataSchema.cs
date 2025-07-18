using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MetadataSchema
{
    /// <summary>
    /// title for the data gathering page
    /// </summary>
    /// <value>title for the data gathering page</value>
    public string Title { get; set; }

    /// <summary>
    /// description of the data being gathered on this page
    /// </summary>
    /// <value>description of the data being gathered on this page</value>
    public string Description { get; set; }

    /// <summary>
    /// type of data being gathered
    /// </summary>
    /// <value>type of data being gathered</value>
    public string Type { get; set; }

    /// <summary>
    /// list of properties for which input is to be gathered, bother required and optional
    /// </summary>
    /// <value>list of properties for which input is to be gathered, bother required and optional</value>
    public IEnumerable<Dictionary<string, MetadataProperty>> Properties { get; set; }

    /// <summary>
    /// list of required properties
    /// </summary>
    /// <value>list of required properties</value>
    public IEnumerable<string> Required { get; set; }
}
