using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SessionEndDetails
/// </summary>

public partial class SessionEndDetails : IEquatable<SessionEndDetails>
{
    /// <summary>
    /// The type of termination handling that resulted in the session end. It can be either Exit or Disconnect
    /// </summary>
    /// <value>The type of termination handling that resulted in the session end. It can be either Exit or Disconnect</value>
    
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
        /// Enum Disconnect for "Disconnect"
        /// </summary>
        [EnumMember(Value = "Disconnect")]
        Disconnect,

        /// <summary>
        /// Enum Exit for "Exit"
        /// </summary>
        [EnumMember(Value = "Exit")]
        Exit
    }
    /// <summary>
    /// The type of termination handling that resulted in the session end. It can be either Exit or Disconnect
    /// </summary>
    /// <value>The type of termination handling that resulted in the session end. It can be either Exit or Disconnect</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SessionEndDetails" /> class.
    /// </summary>
    /// <param name="Type">The type of termination handling that resulted in the session end. It can be either Exit or Disconnect.</param>
    /// <param name="Reason">The reason for termination action. It can be due to an error or normal flow execution.</param>
    public SessionEndDetails(TypeEnum? Type = null, string Reason = null)
    {
        this.Type = Type;
        this.Reason = Reason;

    }





    /// <summary>
    /// The reason for termination action. It can be due to an error or normal flow execution
    /// </summary>
    /// <value>The reason for termination action. It can be due to an error or normal flow execution</value>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SessionEndDetails {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
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
        return Equals(obj as SessionEndDetails);
    }

    /// <summary>
    /// Returns true if SessionEndDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of SessionEndDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SessionEndDetails other)
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
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
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

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            return hash;
        }
    }
}
