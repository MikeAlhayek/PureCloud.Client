using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebChatGuestMediaRequestEntityList
/// </summary>
public sealed class WebChatGuestMediaRequestEntityList
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatGuestMediaRequestEntityList" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    public WebChatGuestMediaRequestEntityList(List<WebChatGuestMediaRequest> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<WebChatGuestMediaRequest> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebChatGuestMediaRequestEntityList {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}
