using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SecureSession
/// </summary>

public partial class SecureSession : IEquatable<SecureSession>
{
    /// <summary>
    /// The current state of a secure session
    /// </summary>
    /// <value>The current state of a secure session</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Enum Completed for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed
    }
    /// <summary>
    /// The current state of a secure session
    /// </summary>
    /// <value>The current state of a secure session</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SecureSession" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SecureSession() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SecureSession" /> class.
    /// </summary>
    /// <param name="Flow">The flow to execute securely (required).</param>
    /// <param name="UserData">Customer-provided data.</param>
    /// <param name="State">The current state of a secure session (required).</param>
    /// <param name="SourceParticipantId">Unique identifier for the participant initiating the secure session..</param>
    /// <param name="Disconnect">If true, disconnect the agent after creating the session.</param>
    public SecureSession(DomainEntityRef Flow = null, string UserData = null, StateEnum? State = null, string SourceParticipantId = null, bool? Disconnect = null)
    {
        this.Flow = Flow;
        this.UserData = UserData;
        this.State = State;
        this.SourceParticipantId = SourceParticipantId;
        this.Disconnect = Disconnect;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The flow to execute securely
    /// </summary>
    /// <value>The flow to execute securely</value>
    [JsonPropertyName("flow")]
    public DomainEntityRef Flow { get; set; }



    /// <summary>
    /// Customer-provided data
    /// </summary>
    /// <value>Customer-provided data</value>
    [JsonPropertyName("userData")]
    public string UserData { get; set; }





    /// <summary>
    /// Unique identifier for the participant initiating the secure session.
    /// </summary>
    /// <value>Unique identifier for the participant initiating the secure session.</value>
    [JsonPropertyName("sourceParticipantId")]
    public string SourceParticipantId { get; set; }



    /// <summary>
    /// If true, disconnect the agent after creating the session
    /// </summary>
    /// <value>If true, disconnect the agent after creating the session</value>
    [JsonPropertyName("disconnect")]
    public bool? Disconnect { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SecureSession {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  UserData: ").Append(UserData).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  SourceParticipantId: ").Append(SourceParticipantId).Append("\n");
        sb.Append("  Disconnect: ").Append(Disconnect).Append("\n");
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
        return Equals(obj as SecureSession);
    }

    /// <summary>
    /// Returns true if SecureSession instances are equal
    /// </summary>
    /// <param name="other">Instance of SecureSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SecureSession other)
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
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                UserData == other.UserData ||
                UserData != null &&
                UserData.Equals(other.UserData)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                SourceParticipantId == other.SourceParticipantId ||
                SourceParticipantId != null &&
                SourceParticipantId.Equals(other.SourceParticipantId)
            ) &&
            (
                Disconnect == other.Disconnect ||
                Disconnect != null &&
                Disconnect.Equals(other.Disconnect)
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

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (UserData != null)
            {
                hash = hash * 59 + UserData.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (SourceParticipantId != null)
            {
                hash = hash * 59 + SourceParticipantId.GetHashCode();
            }

            if (Disconnect != null)
            {
                hash = hash * 59 + Disconnect.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
