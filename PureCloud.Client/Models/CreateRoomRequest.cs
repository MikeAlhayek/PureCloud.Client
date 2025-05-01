using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateRoomRequest
/// </summary>
[DataContract]
public partial class CreateRoomRequest : IEquatable<CreateRoomRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateRoomRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateRoomRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateRoomRequest" /> class.
    /// </summary>
    /// <param name="Description">Room&#39;s description.</param>
    /// <param name="Subject">Room&#39;s subject (required).</param>
    /// <param name="UserIds">Users to add to the room.</param>
    public CreateRoomRequest(string Description = null, string Subject = null, List<string> UserIds = null)
    {
        this.Description = Description;
        this.Subject = Subject;
        this.UserIds = UserIds;

    }



    /// <summary>
    /// Room&#39;s description
    /// </summary>
    /// <value>Room&#39;s description</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Room&#39;s subject
    /// </summary>
    /// <value>Room&#39;s subject</value>
    [DataMember(Name = "subject", EmitDefaultValue = false)]
    public string Subject { get; set; }



    /// <summary>
    /// Users to add to the room
    /// </summary>
    /// <value>Users to add to the room</value>
    [DataMember(Name = "userIds", EmitDefaultValue = false)]
    public List<string> UserIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateRoomRequest {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
        return Equals(obj as CreateRoomRequest);
    }

    /// <summary>
    /// Returns true if CreateRoomRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateRoomRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateRoomRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.SequenceEqual(other.UserIds)
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
            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            return hash;
        }
    }
}
