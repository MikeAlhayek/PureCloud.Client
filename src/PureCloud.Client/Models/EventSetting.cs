using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EventSetting
/// </summary>
public sealed class EventSetting
{
    /// <summary>
    /// Settings regarding typing events
    /// </summary>
    /// <value>Settings regarding typing events</value>
    public TypingSetting Typing { get; set; }
}
