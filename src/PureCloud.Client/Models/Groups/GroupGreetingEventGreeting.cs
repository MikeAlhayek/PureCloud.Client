using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GroupGreetingEventGreeting
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets OwnerType
    /// </summary>
    public string OwnerType { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    public GroupGreetingEventGreetingOwner Owner { get; set; }

    /// <summary>
    /// Gets or Sets GreetingAudioFile
    /// </summary>
    public GroupGreetingEventGreetingAudioFile GreetingAudioFile { get; set; }

    /// <summary>
    /// Gets or Sets AudioTTS
    /// </summary>
    public string AudioTTS { get; set; }
}
