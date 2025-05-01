using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SipDownloadResponse
/// </summary>
[DataContract]
public partial class SipDownloadResponse : IEquatable<SipDownloadResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SipDownloadResponse" /> class.
    /// </summary>
    /// <param name="DownloadId">unique id of the downloaded file.</param>
    /// <param name="DocumentId">Document id of pcap file.</param>
    public SipDownloadResponse(string DownloadId = null, string DocumentId = null)
    {
        this.DownloadId = DownloadId;
        this.DocumentId = DocumentId;

    }



    /// <summary>
    /// unique id of the downloaded file
    /// </summary>
    /// <value>unique id of the downloaded file</value>
    [DataMember(Name = "downloadId", EmitDefaultValue = false)]
    public string DownloadId { get; set; }



    /// <summary>
    /// Document id of pcap file
    /// </summary>
    /// <value>Document id of pcap file</value>
    [DataMember(Name = "documentId", EmitDefaultValue = false)]
    public string DocumentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SipDownloadResponse {\n");

        sb.Append("  DownloadId: ").Append(DownloadId).Append("\n");
        sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
        return Equals(obj as SipDownloadResponse);
    }

    /// <summary>
    /// Returns true if SipDownloadResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SipDownloadResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SipDownloadResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DownloadId == other.DownloadId ||
                DownloadId != null &&
                DownloadId.Equals(other.DownloadId)
            ) &&
            (
                DocumentId == other.DocumentId ||
                DocumentId != null &&
                DocumentId.Equals(other.DocumentId)
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
            if (DownloadId != null)
            {
                hash = hash * 59 + DownloadId.GetHashCode();
            }

            if (DocumentId != null)
            {
                hash = hash * 59 + DocumentId.GetHashCode();
            }

            return hash;
        }
    }
}
