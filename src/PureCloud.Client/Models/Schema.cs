using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Schema
{
    /// <summary>
    /// A core type&#39;s title
    /// </summary>
    /// <value>A core type&#39;s title</value>
    public string Title { get; set; }

    /// <summary>
    /// A core type&#39;s description
    /// </summary>
    /// <value>A core type&#39;s description</value>
    public string Description { get; set; }

    /// <summary>
    /// An array of fundamental JSON Schema primitive types on which the core type is based
    /// </summary>
    /// <value>An array of fundamental JSON Schema primitive types on which the core type is based</value>
    public IEnumerable<string> Type { get; set; }

    /// <summary>
    /// Denotes the type and pattern of the items in an enum core type
    /// </summary>
    /// <value>Denotes the type and pattern of the items in an enum core type</value>
    public Items Items { get; set; }

    /// <summary>
    /// For the \&quot;date\&quot; and \&quot;datetime\&quot; core types, denotes the regex prescribing the allowable date/datetime format
    /// </summary>
    /// <value>For the \&quot;date\&quot; and \&quot;datetime\&quot; core types, denotes the regex prescribing the allowable date/datetime format</value>
    public string Pattern { get; set; }
}
