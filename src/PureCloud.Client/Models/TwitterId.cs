using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TwitterId
{
    /// <summary>
    /// twitter user.id_str
    /// </summary>
    /// <value>twitter user.id_str</value>
    public string Id { get; set; }

    /// <summary>
    /// twitter user.name
    /// </summary>
    /// <value>twitter user.name</value>
    public string Name { get; set; }

    /// <summary>
    /// twitter user.screen_name
    /// </summary>
    /// <value>twitter user.screen_name</value>
    public string ScreenName { get; set; }

    /// <summary>
    /// whether this data has been verified using the twitter API
    /// </summary>
    /// <value>whether this data has been verified using the twitter API</value>
    public bool? Verified { get; set; }

    /// <summary>
    /// url of user&#39;s twitter profile
    /// </summary>
    /// <value>url of user&#39;s twitter profile</value>
    public string ProfileUrl { get; set; }
}
