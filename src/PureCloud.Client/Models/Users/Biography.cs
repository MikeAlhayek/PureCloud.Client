using System.Text.Json.Serialization;

namespace PureCloud.Client.Models.Users;

public partial class Biography
{
    /// <summary>
    /// Personal detailed description
    /// </summary>
    /// <value>Personal detailed description</value>
    [JsonPropertyName("biography")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets Interests
    /// </summary>
    public IEnumerable<string> Interests { get; set; }

    /// <summary>
    /// Gets or Sets Hobbies
    /// </summary>
    public IEnumerable<string> Hobbies { get; set; }

    /// <summary>
    /// Gets or Sets Spouse
    /// </summary>
    public string Spouse { get; set; }

    /// <summary>
    /// User education details
    /// </summary>
    /// <value>User education details</value>
    public IEnumerable<Education> Education { get; set; }
}
