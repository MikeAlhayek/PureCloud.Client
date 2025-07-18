using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MetadataPresentation
{
    /// <summary>
    /// title for a set of data to be gathered
    /// </summary>
    /// <value>title for a set of data to be gathered</value>
    public string Title { get; set; }

    /// <summary>
    /// description of the contents of the data gathering interface
    /// </summary>
    /// <value>description of the contents of the data gathering interface</value>
    public MetadataSchema Schema { get; set; }
}
