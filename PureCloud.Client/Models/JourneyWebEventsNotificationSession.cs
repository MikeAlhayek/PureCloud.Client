using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyWebEventsNotificationSession
/// </summary>
[DataContract]
public partial class JourneyWebEventsNotificationSession : IEquatable<JourneyWebEventsNotificationSession>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationSession" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="Type">Type.</param>
    public JourneyWebEventsNotificationSession(string Id = null, string SelfUri = null, string Type = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;
        this.Type = Type;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebEventsNotificationSession {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as JourneyWebEventsNotificationSession);
    }

    /// <summary>
    /// Returns true if JourneyWebEventsNotificationSession instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebEventsNotificationSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebEventsNotificationSession other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
