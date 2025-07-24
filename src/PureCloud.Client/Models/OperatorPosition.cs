using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class OperatorPosition
{
    /// <summary>
    /// The range interval for the operator position
    /// </summary>
    /// <value>The range interval for the operator position</value>
    public NumericRange Range { get; set; }
}
