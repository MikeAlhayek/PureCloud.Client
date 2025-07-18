using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MetadataProperty
{
    /// <summary>
    /// the data type of the input property
    /// </summary>
    /// <value>the data type of the input property</value>
    public string Type { get; set; }

    /// <summary>
    /// user-friendly name of the input property
    /// </summary>
    /// <value>user-friendly name of the input property</value>
    public string Displayname { get; set; }

    /// <summary>
    /// brief description of the input property
    /// </summary>
    /// <value>brief description of the input property</value>
    public string Description { get; set; }

    /// <summary>
    /// whether the property&#39;s value should be hidden from display
    /// </summary>
    /// <value>whether the property&#39;s value should be hidden from display</value>
    public string Sensitive { get; set; }

    /// <summary>
    /// optional URL with addition information about the input property
    /// </summary>
    /// <value>optional URL with addition information about the input property</value>
    public string Help { get; set; }

    /// <summary>
    /// optional default value of the input property
    /// </summary>
    /// <value>optional default value of the input property</value>
    public string Default { get; set; }

    /// <summary>
    /// set of possible values if the input property is an enumeration
    /// </summary>
    /// <value>set of possible values if the input property is an enumeration</value>
    public IEnumerable<string> Enum { get; set; }
}
