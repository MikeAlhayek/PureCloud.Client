using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateRoomResponse
/// </summary>
[DataContract]
public partial class CreateRoomResponse : IEquatable<CreateRoomResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateRoomResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateRoomResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateRoomResponse" /> class.
    /// </summary>
    /// <param name="Jid">The jid of the room (required).</param>
    public CreateRoomResponse(string Jid = null)
    {
        this.Jid = Jid;

    }



    /// <summary>
    /// The jid of the room
    /// </summary>
    /// <value>The jid of the room</value>
    [DataMember(Name = "jid", EmitDefaultValue = false)]
    public string Jid { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateRoomResponse {\n");

        sb.Append("  Jid: ").Append(Jid).Append("\n");
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
        return Equals(obj as CreateRoomResponse);
    }

    /// <summary>
    /// Returns true if CreateRoomResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateRoomResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateRoomResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Jid == other.Jid ||
                Jid != null &&
                Jid.Equals(other.Jid)
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
            if (Jid != null)
            {
                hash = hash * 59 + Jid.GetHashCode();
            }

            return hash;
        }
    }
}
