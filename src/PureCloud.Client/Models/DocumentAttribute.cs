using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DocumentAttribute
{
    /// <summary>  
    /// Gets or Sets Attribute  
    /// </summary>  
    public object Attribute { get; set; }

    /// <summary>  
    /// Gets or Sets Values  
    /// </summary>  
    public IEnumerable<string> Values { get; set; }
}
