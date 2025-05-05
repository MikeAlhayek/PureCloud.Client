using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebChatMessageEntityList
/// </summary>

public partial class WebChatMessageEntityList : IEquatable<WebChatMessageEntityList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatMessageEntityList" /> class.
    /// </summary>
    /// <param name="PageSize">PageSize.</param>
    /// <param name="Entities">Entities.</param>
    /// <param name="PreviousPage">PreviousPage.</param>
    /// <param name="Next">Next.</param>
    /// <param name="SelfUri">SelfUri.</param>
    public WebChatMessageEntityList(int? PageSize = null, List<WebChatMessage> Entities = null, string PreviousPage = null, string Next = null, string SelfUri = null)
    {
        this.PageSize = PageSize;
        this.Entities = Entities;
        this.PreviousPage = PreviousPage;
        this.Next = Next;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<WebChatMessage> Entities { get; set; }



    /// <summary>
    /// Gets or Sets PreviousPage
    /// </summary>
    [JsonPropertyName("previousPage")]
    public string PreviousPage { get; set; }



    /// <summary>
    /// Gets or Sets Next
    /// </summary>
    [JsonPropertyName("next")]
    public string Next { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebChatMessageEntityList {\n");

        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
        sb.Append("  Next: ").Append(Next).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as WebChatMessageEntityList);
    }

    /// <summary>
    /// Returns true if WebChatMessageEntityList instances are equal
    /// </summary>
    /// <param name="other">Instance of WebChatMessageEntityList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebChatMessageEntityList other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                PreviousPage == other.PreviousPage ||
                PreviousPage != null &&
                PreviousPage.Equals(other.PreviousPage)
            ) &&
            (
                Next == other.Next ||
                Next != null &&
                Next.Equals(other.Next)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (PreviousPage != null)
            {
                hash = hash * 59 + PreviousPage.GetHashCode();
            }

            if (Next != null)
            {
                hash = hash * 59 + Next.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
