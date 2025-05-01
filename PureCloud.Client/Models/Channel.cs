using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Channel
/// </summary>
[DataContract]
public partial class Channel : IEquatable<Channel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Channel" /> class.
    /// </summary>
    /// <param name="ConnectUri">ConnectUri.</param>
    /// <param name="Id">Id.</param>
    /// <param name="Expires">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public Channel(string ConnectUri = null, string Id = null, DateTime? Expires = null)
    {
        this.ConnectUri = ConnectUri;
        this.Id = Id;
        this.Expires = Expires;

    }



    /// <summary>
    /// Gets or Sets ConnectUri
    /// </summary>
    [DataMember(Name = "connectUri", EmitDefaultValue = false)]
    public string ConnectUri { get; set; }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "expires", EmitDefaultValue = false)]
    public DateTime? Expires { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Channel {\n");

        sb.Append("  ConnectUri: ").Append(ConnectUri).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Expires: ").Append(Expires).Append("\n");
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
        return Equals(obj as Channel);
    }

    /// <summary>
    /// Returns true if Channel instances are equal
    /// </summary>
    /// <param name="other">Instance of Channel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Channel other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConnectUri == other.ConnectUri ||
                ConnectUri != null &&
                ConnectUri.Equals(other.ConnectUri)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Expires == other.Expires ||
                Expires != null &&
                Expires.Equals(other.Expires)
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
            if (ConnectUri != null)
            {
                hash = hash * 59 + ConnectUri.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Expires != null)
            {
                hash = hash * 59 + Expires.GetHashCode();
            }

            return hash;
        }
    }
}
