using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines an external media that has been ingested and cached by Genesys Cloud for conversation messaging
/// </summary>

public partial class CachedMediaItem : IEquatable<CachedMediaItem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CachedMediaItem" /> class.
    /// </summary>
    public CachedMediaItem()
    {

    }



    /// <summary>
    /// The unique identifier for the cached media.
    /// </summary>
    /// <value>The unique identifier for the cached media.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The URL that represents the external media that has been cached
    /// </summary>
    /// <value>The URL that represents the external media that has been cached</value>
    [JsonPropertyName("url")]
    public string Url { get; private set; }



    /// <summary>
    /// A URL to fetch the cached media
    /// </summary>
    /// <value>A URL to fetch the cached media</value>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; private set; }



    /// <summary>
    /// The media type for the URL
    /// </summary>
    /// <value>The media type for the URL</value>
    [JsonPropertyName("mediaType")]
    public string MediaType { get; private set; }



    /// <summary>
    /// The content length of the media represented by the URL, in bytes.
    /// </summary>
    /// <value>The content length of the media represented by the URL, in bytes.</value>
    [JsonPropertyName("contentLengthBytes")]
    public int? ContentLengthBytes { get; private set; }



    /// <summary>
    /// The date the cached item was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the cached item was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The date the cached item expires and will be removed from the cache. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the cached item expires and will be removed from the cache. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateExpires")]
    public DateTime? DateExpires { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CachedMediaItem {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ContentLengthBytes: ").Append(ContentLengthBytes).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
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
        return Equals(obj as CachedMediaItem);
    }

    /// <summary>
    /// Returns true if CachedMediaItem instances are equal
    /// </summary>
    /// <param name="other">Instance of CachedMediaItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CachedMediaItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                ContentLengthBytes == other.ContentLengthBytes ||
                ContentLengthBytes != null &&
                ContentLengthBytes.Equals(other.ContentLengthBytes)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateExpires == other.DateExpires ||
                DateExpires != null &&
                DateExpires.Equals(other.DateExpires)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (ContentLengthBytes != null)
            {
                hash = hash * 59 + ContentLengthBytes.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateExpires != null)
            {
                hash = hash * 59 + DateExpires.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
