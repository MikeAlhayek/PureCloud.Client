using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SessionEndDetails
{
    /// <summary>
    /// The type of termination handling that resulted in the session end. It can be either Exit or Disconnect
    /// </summary>
    /// <value>The type of termination handling that resulted in the session end. It can be either Exit or Disconnect</value>
    public SessionEndDetailsTypeEnum? Type { get; set; }

    /// <summary>
    /// The reason for termination action. It can be due to an error or normal flow execution
    /// </summary>
    /// <value>The reason for termination action. It can be due to an error or normal flow execution</value>
    public string Reason { get; set; }
}
