using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UnreadFields
/// </summary>
[DataContract]
public partial class UnreadFields : IEquatable<UnreadFields>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UnreadFields" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UnreadFields() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UnreadFields" /> class.
    /// </summary>
    /// <param name="State">The new unread state of the alert (required).</param>
    public UnreadFields(bool? State = null)
    {
        this.State = State;

    }



    /// <summary>
    /// The new unread state of the alert
    /// </summary>
    /// <value>The new unread state of the alert</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public bool? State { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UnreadFields {\n");

        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as UnreadFields);
    }

    /// <summary>
    /// Returns true if UnreadFields instances are equal
    /// </summary>
    /// <param name="other">Instance of UnreadFields to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UnreadFields other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            return hash;
        }
    }
}
