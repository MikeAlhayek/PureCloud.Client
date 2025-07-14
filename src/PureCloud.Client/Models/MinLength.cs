using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MinLength
{
    /// <summary>
    /// A non-negative integer for a text-based schema field denoting the minimum smallest length a string field can contain for a schema instance.
    /// </summary>
    /// <value>A non-negative integer for a text-based schema field denoting the minimum smallest length a string field can contain for a schema instance.</value>
    public long? Min { get; set; }

    /// <summary>
    /// A non-negative integer for a text-based schema field denoting the maximum smallest length string the field can contain for a schema instance.
    /// </summary>
    /// <value>A non-negative integer for a text-based schema field denoting the maximum smallest length string the field can contain for a schema instance.</value>
    public long? Max { get; set; }
}
