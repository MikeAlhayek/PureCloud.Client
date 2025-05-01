using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserPresence
/// </summary>
[DataContract]
public partial class UserPresence : IEquatable<UserPresence>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserPresence" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Source">Deprecated - The sourceID field should be used as a replacement..</param>
    /// <param name="SourceId">Represents the ID of a registered source.</param>
    /// <param name="Primary">A boolean used to tell whether or not to set this presence source as the primary on a PATCH.</param>
    /// <param name="PresenceDefinition">PresenceDefinition.</param>
    /// <param name="Message">Message.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public UserPresence(string Name = null, string Source = null, string SourceId = null, bool? Primary = null, PresenceDefinition PresenceDefinition = null, string Message = null, DateTime? ModifiedDate = null)
    {
        this.Name = Name;
        this.Source = Source;
        this.SourceId = SourceId;
        this.Primary = Primary;
        this.PresenceDefinition = PresenceDefinition;
        this.Message = Message;
        this.ModifiedDate = ModifiedDate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Deprecated - The sourceID field should be used as a replacement.
    /// </summary>
    /// <value>Deprecated - The sourceID field should be used as a replacement.</value>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public string Source { get; set; }



    /// <summary>
    /// Represents the ID of a registered source
    /// </summary>
    /// <value>Represents the ID of a registered source</value>
    [DataMember(Name = "sourceId", EmitDefaultValue = false)]
    public string SourceId { get; set; }



    /// <summary>
    /// A boolean used to tell whether or not to set this presence source as the primary on a PATCH
    /// </summary>
    /// <value>A boolean used to tell whether or not to set this presence source as the primary on a PATCH</value>
    [DataMember(Name = "primary", EmitDefaultValue = false)]
    public bool? Primary { get; set; }



    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    [DataMember(Name = "presenceDefinition", EmitDefaultValue = false)]
    public PresenceDefinition PresenceDefinition { get; set; }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserPresence {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  SourceId: ").Append(SourceId).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
        sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as UserPresence);
    }

    /// <summary>
    /// Returns true if UserPresence instances are equal
    /// </summary>
    /// <param name="other">Instance of UserPresence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserPresence other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                SourceId == other.SourceId ||
                SourceId != null &&
                SourceId.Equals(other.SourceId)
            ) &&
            (
                Primary == other.Primary ||
                Primary != null &&
                Primary.Equals(other.Primary)
            ) &&
            (
                PresenceDefinition == other.PresenceDefinition ||
                PresenceDefinition != null &&
                PresenceDefinition.Equals(other.PresenceDefinition)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (SourceId != null)
            {
                hash = hash * 59 + SourceId.GetHashCode();
            }

            if (Primary != null)
            {
                hash = hash * 59 + Primary.GetHashCode();
            }

            if (PresenceDefinition != null)
            {
                hash = hash * 59 + PresenceDefinition.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
