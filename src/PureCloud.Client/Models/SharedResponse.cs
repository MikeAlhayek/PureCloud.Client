using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SharedResponse
/// </summary>

public partial class SharedResponse : IEquatable<SharedResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SharedResponse" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="DownloadUri">DownloadUri.</param>
    /// <param name="ViewUri">ViewUri.</param>
    /// <param name="Document">Document.</param>
    /// <param name="Share">Share.</param>
    public SharedResponse(string Id = null, string DownloadUri = null, string ViewUri = null, Document Document = null, Share Share = null)
    {
        this.Id = Id;
        this.DownloadUri = DownloadUri;
        this.ViewUri = ViewUri;
        this.Document = Document;
        this.Share = Share;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets DownloadUri
    /// </summary>
    [JsonPropertyName("downloadUri")]
    public string DownloadUri { get; set; }



    /// <summary>
    /// Gets or Sets ViewUri
    /// </summary>
    [JsonPropertyName("viewUri")]
    public string ViewUri { get; set; }



    /// <summary>
    /// Gets or Sets Document
    /// </summary>
    [JsonPropertyName("document")]
    public Document Document { get; set; }



    /// <summary>
    /// Gets or Sets Share
    /// </summary>
    [JsonPropertyName("share")]
    public Share Share { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SharedResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DownloadUri: ").Append(DownloadUri).Append("\n");
        sb.Append("  ViewUri: ").Append(ViewUri).Append("\n");
        sb.Append("  Document: ").Append(Document).Append("\n");
        sb.Append("  Share: ").Append(Share).Append("\n");
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
        return Equals(obj as SharedResponse);
    }

    /// <summary>
    /// Returns true if SharedResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SharedResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SharedResponse other)
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
                DownloadUri == other.DownloadUri ||
                DownloadUri != null &&
                DownloadUri.Equals(other.DownloadUri)
            ) &&
            (
                ViewUri == other.ViewUri ||
                ViewUri != null &&
                ViewUri.Equals(other.ViewUri)
            ) &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
            ) &&
            (
                Share == other.Share ||
                Share != null &&
                Share.Equals(other.Share)
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

            if (DownloadUri != null)
            {
                hash = hash * 59 + DownloadUri.GetHashCode();
            }

            if (ViewUri != null)
            {
                hash = hash * 59 + ViewUri.GetHashCode();
            }

            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            if (Share != null)
            {
                hash = hash * 59 + Share.GetHashCode();
            }

            return hash;
        }
    }
}
