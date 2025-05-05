using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContactId
/// </summary>

public partial class DialerContactId : IEquatable<DialerContactId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContactId" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ContactListId">ContactListId.</param>
    public DialerContactId(string Id = null, string ContactListId = null)
    {
        this.Id = Id;
        this.ContactListId = ContactListId;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets ContactListId
    /// </summary>
    [JsonPropertyName("contactListId")]
    public string ContactListId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerContactId {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
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
        return Equals(obj as DialerContactId);
    }

    /// <summary>
    /// Returns true if DialerContactId instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerContactId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerContactId other)
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
                ContactListId == other.ContactListId ||
                ContactListId != null &&
                ContactListId.Equals(other.ContactListId)
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

            if (ContactListId != null)
            {
                hash = hash * 59 + ContactListId.GetHashCode();
            }

            return hash;
        }
    }
}
