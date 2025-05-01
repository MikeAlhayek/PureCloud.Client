using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallbackIdentifier
/// </summary>
[DataContract]
public partial class CallbackIdentifier : IEquatable<CallbackIdentifier>
{
    /// <summary>
    /// The type of the associated callback participant
    /// </summary>
    /// <value>The type of the associated callback participant</value>
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
        /// Enum Acd for "ACD"
        /// </summary>
        [EnumMember(Value = "ACD")]
        Acd,

        /// <summary>
        /// Enum External for "EXTERNAL"
        /// </summary>
        [EnumMember(Value = "EXTERNAL")]
        External
    }
    /// <summary>
    /// The type of the associated callback participant
    /// </summary>
    /// <value>The type of the associated callback participant</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CallbackIdentifier" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CallbackIdentifier() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallbackIdentifier" /> class.
    /// </summary>
    /// <param name="Type">The type of the associated callback participant (required).</param>
    /// <param name="Id">The identifier of the callback (required).</param>
    public CallbackIdentifier(TypeEnum? Type = null, string Id = null)
    {
        this.Type = Type;
        this.Id = Id;

    }





    /// <summary>
    /// The identifier of the callback
    /// </summary>
    /// <value>The identifier of the callback</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallbackIdentifier {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as CallbackIdentifier);
    }

    /// <summary>
    /// Returns true if CallbackIdentifier instances are equal
    /// </summary>
    /// <param name="other">Instance of CallbackIdentifier to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallbackIdentifier other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
