using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SocialKeyword
{
    /// <summary>
    /// List of keywords that must be included
    /// </summary>
    /// <value>List of keywords that must be included</value>
    public IEnumerable<string> Includes { get; set; }

    /// <summary>
    /// List of keywords that must be excluded
    /// </summary>
    /// <value>List of keywords that must be excluded</value>
    public IEnumerable<string> Excludes { get; set; }
}
