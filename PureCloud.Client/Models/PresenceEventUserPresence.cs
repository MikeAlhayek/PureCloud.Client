using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// PresenceEventUserPresence
/// </summary>
[DataContract]
public partial class PresenceEventUserPresence : IEquatable<PresenceEventUserPresence>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PresenceEventUserPresence" /> class.
    /// </summary>
    /// <param name="Source">Source.</param>
    /// <param name="PresenceDefinition">PresenceDefinition.</param>
    /// <param name="Primary">Primary.</param>
    /// <param name="Message">Message.</param>
    /// <param name="ModifiedDate">ModifiedDate.</param>
    public PresenceEventUserPresence(string Source = null, PresenceEventOrganizationPresence PresenceDefinition = null, bool? Primary = null, string Message = null, DateTime? ModifiedDate = null)
    {
        this.Source = Source;
        this.PresenceDefinition = PresenceDefinition;
        this.Primary = Primary;
        this.Message = Message;
        this.ModifiedDate = ModifiedDate;

    }



    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public string Source { get; set; }



    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    [DataMember(Name = "presenceDefinition", EmitDefaultValue = false)]
    public PresenceEventOrganizationPresence PresenceDefinition { get; set; }



    /// <summary>
    /// Gets or Sets Primary
    /// </summary>
    [DataMember(Name = "primary", EmitDefaultValue = false)]
    public bool? Primary { get; set; }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PresenceEventUserPresence {\n");

        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as PresenceEventUserPresence);
    }

    /// <summary>
    /// Returns true if PresenceEventUserPresence instances are equal
    /// </summary>
    /// <param name="other">Instance of PresenceEventUserPresence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PresenceEventUserPresence other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                PresenceDefinition == other.PresenceDefinition ||
                PresenceDefinition != null &&
                PresenceDefinition.Equals(other.PresenceDefinition)
            ) &&
            (
                Primary == other.Primary ||
                Primary != null &&
                Primary.Equals(other.Primary)
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
            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (PresenceDefinition != null)
            {
                hash = hash * 59 + PresenceDefinition.GetHashCode();
            }

            if (Primary != null)
            {
                hash = hash * 59 + Primary.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            return hash;
        }
    }
}
