using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AcceleratorParameter
{
    /// <summary>
    /// Parameter Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Parameter Value
    /// </summary>
    public string Value { get; set; }
}
