using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateSecureSession
/// </summary>

public partial class CreateSecureSession : IEquatable<CreateSecureSession>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSecureSession" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateSecureSession() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSecureSession" /> class.
    /// </summary>
    /// <param name="SourceParticipantId">requesting participant.</param>
    /// <param name="FlowId">the flow id to execute in the secure session (required).</param>
    /// <param name="UserData">user data for the secure session (required).</param>
    /// <param name="Disconnect">if true, disconnect the agent after creating the session.</param>
    public CreateSecureSession(string SourceParticipantId = null, string FlowId = null, string UserData = null, bool? Disconnect = null)
    {
        this.SourceParticipantId = SourceParticipantId;
        this.FlowId = FlowId;
        this.UserData = UserData;
        this.Disconnect = Disconnect;

    }



    /// <summary>
    /// requesting participant
    /// </summary>
    /// <value>requesting participant</value>
    [JsonPropertyName("sourceParticipantId")]
    public string SourceParticipantId { get; set; }



    /// <summary>
    /// the flow id to execute in the secure session
    /// </summary>
    /// <value>the flow id to execute in the secure session</value>
    [JsonPropertyName("flowId")]
    public string FlowId { get; set; }



    /// <summary>
    /// user data for the secure session
    /// </summary>
    /// <value>user data for the secure session</value>
    [JsonPropertyName("userData")]
    public string UserData { get; set; }



    /// <summary>
    /// if true, disconnect the agent after creating the session
    /// </summary>
    /// <value>if true, disconnect the agent after creating the session</value>
    [JsonPropertyName("disconnect")]
    public bool? Disconnect { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateSecureSession {\n");

        sb.Append("  SourceParticipantId: ").Append(SourceParticipantId).Append("\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  UserData: ").Append(UserData).Append("\n");
        sb.Append("  Disconnect: ").Append(Disconnect).Append("\n");
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
        return Equals(obj as CreateSecureSession);
    }

    /// <summary>
    /// Returns true if CreateSecureSession instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateSecureSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateSecureSession other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SourceParticipantId == other.SourceParticipantId ||
                SourceParticipantId != null &&
                SourceParticipantId.Equals(other.SourceParticipantId)
            ) &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                UserData == other.UserData ||
                UserData != null &&
                UserData.Equals(other.UserData)
            ) &&
            (
                Disconnect == other.Disconnect ||
                Disconnect != null &&
                Disconnect.Equals(other.Disconnect)
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
            if (SourceParticipantId != null)
            {
                hash = hash * 59 + SourceParticipantId.GetHashCode();
            }

            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (UserData != null)
            {
                hash = hash * 59 + UserData.GetHashCode();
            }

            if (Disconnect != null)
            {
                hash = hash * 59 + Disconnect.GetHashCode();
            }

            return hash;
        }
    }
}
