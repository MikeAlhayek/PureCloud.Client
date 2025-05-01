using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// PersistentConnectionChangeTopicErrorInfoDetails
/// </summary>
[DataContract]
public partial class PersistentConnectionChangeTopicErrorInfoDetails : IEquatable<PersistentConnectionChangeTopicErrorInfoDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersistentConnectionChangeTopicErrorInfoDetails" /> class.
    /// </summary>
    /// <param name="Code">Code.</param>
    /// <param name="UserMessage">UserMessage.</param>
    /// <param name="UserParams">UserParams.</param>
    /// <param name="Hostname">Hostname.</param>
    /// <param name="Location">Location.</param>
    public PersistentConnectionChangeTopicErrorInfoDetails(string Code = null, string UserMessage = null, Dictionary<string, string> UserParams = null, string Hostname = null, PersistentConnectionChangeTopicErrorLocation Location = null)
    {
        this.Code = Code;
        this.UserMessage = UserMessage;
        this.UserParams = UserParams;
        this.Hostname = Hostname;
        this.Location = Location;

    }



    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }



    /// <summary>
    /// Gets or Sets UserMessage
    /// </summary>
    [DataMember(Name = "userMessage", EmitDefaultValue = false)]
    public string UserMessage { get; set; }



    /// <summary>
    /// Gets or Sets UserParams
    /// </summary>
    [DataMember(Name = "userParams", EmitDefaultValue = false)]
    public Dictionary<string, string> UserParams { get; set; }



    /// <summary>
    /// Gets or Sets Hostname
    /// </summary>
    [DataMember(Name = "hostname", EmitDefaultValue = false)]
    public string Hostname { get; set; }



    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name = "location", EmitDefaultValue = false)]
    public PersistentConnectionChangeTopicErrorLocation Location { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PersistentConnectionChangeTopicErrorInfoDetails {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
        sb.Append("  UserParams: ").Append(UserParams).Append("\n");
        sb.Append("  Hostname: ").Append(Hostname).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
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
        return Equals(obj as PersistentConnectionChangeTopicErrorInfoDetails);
    }

    /// <summary>
    /// Returns true if PersistentConnectionChangeTopicErrorInfoDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of PersistentConnectionChangeTopicErrorInfoDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PersistentConnectionChangeTopicErrorInfoDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                UserMessage == other.UserMessage ||
                UserMessage != null &&
                UserMessage.Equals(other.UserMessage)
            ) &&
            (
                UserParams == other.UserParams ||
                UserParams != null &&
                UserParams.SequenceEqual(other.UserParams)
            ) &&
            (
                Hostname == other.Hostname ||
                Hostname != null &&
                Hostname.Equals(other.Hostname)
            ) &&
            (
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (UserMessage != null)
            {
                hash = hash * 59 + UserMessage.GetHashCode();
            }

            if (UserParams != null)
            {
                hash = hash * 59 + UserParams.GetHashCode();
            }

            if (Hostname != null)
            {
                hash = hash * 59 + Hostname.GetHashCode();
            }

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
            }

            return hash;
        }
    }
}
