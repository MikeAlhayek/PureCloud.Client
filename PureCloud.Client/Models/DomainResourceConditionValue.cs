using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainResourceConditionValue
/// </summary>
[DataContract]
public partial class DomainResourceConditionValue : IEquatable<DomainResourceConditionValue>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Scalar for "SCALAR"
        /// </summary>
        [EnumMember(Value = "SCALAR")]
        Scalar,

        /// <summary>
        /// Enum Variable for "VARIABLE"
        /// </summary>
        [EnumMember(Value = "VARIABLE")]
        Variable,

        /// <summary>
        /// Enum User for "USER"
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Enum Team for "TEAM"
        /// </summary>
        [EnumMember(Value = "TEAM")]
        Team,

        /// <summary>
        /// Enum Queue for "QUEUE"
        /// </summary>
        [EnumMember(Value = "QUEUE")]
        Queue
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainResourceConditionValue" /> class.
    /// </summary>
    /// <param name="User">User.</param>
    /// <param name="Queue">Queue.</param>
    /// <param name="Team">Team.</param>
    /// <param name="Value">Value.</param>
    /// <param name="Type">Type.</param>
    public DomainResourceConditionValue(User User = null, Queue Queue = null, Team Team = null, string Value = null, TypeEnum? Type = null)
    {
        this.User = User;
        this.Queue = Queue;
        this.Team = Team;
        this.Value = Value;
        this.Type = Type;

    }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public User User { get; set; }



    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public Queue Queue { get; set; }



    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    [DataMember(Name = "team", EmitDefaultValue = false)]
    public Team Team { get; set; }



    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainResourceConditionValue {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Team: ").Append(Team).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as DomainResourceConditionValue);
    }

    /// <summary>
    /// Returns true if DomainResourceConditionValue instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainResourceConditionValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainResourceConditionValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Team == other.Team ||
                Team != null &&
                Team.Equals(other.Team)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Team != null)
            {
                hash = hash * 59 + Team.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
