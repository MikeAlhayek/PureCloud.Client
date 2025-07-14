using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MaxLength
{
    /// <summary>
    /// A non-negative integer for a text-based schema field denoting the minimum largest length string the field can contain for a schema instance.
    /// </summary>
    /// <value>A non-negative integer for a text-based schema field denoting the minimum largest length string the field can contain for a schema instance.</value>
    public long? Min { get; set; }

    /// <summary>
    /// A non-negative integer for a text-based schema field denoting the maximum largest string the field can contain for a schema instance.
    /// </summary>
    /// <value>A non-negative integer for a text-based schema field denoting the maximum largest string the field can contain for a schema instance.</value>
    public long? Max { get; set; }
}
