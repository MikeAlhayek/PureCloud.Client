using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CelebrationStateParam
/// </summary>

public partial class CelebrationStateParam : IEquatable<CelebrationStateParam>
{
    /// <summary>
    /// The state of the celebration
    /// </summary>
    /// <value>The state of the celebration</value>
    
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
        /// Enum Displayed for "Displayed"
        /// </summary>
        [EnumMember(Value = "Displayed")]
        Displayed
    }
    /// <summary>
    /// The state of the celebration
    /// </summary>
    /// <value>The state of the celebration</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CelebrationStateParam" /> class.
    /// </summary>
    /// <param name="State">The state of the celebration.</param>
    public CelebrationStateParam(StateEnum? State = null)
    {
        this.State = State;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CelebrationStateParam {\n");

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
        return Equals(obj as CelebrationStateParam);
    }

    /// <summary>
    /// Returns true if CelebrationStateParam instances are equal
    /// </summary>
    /// <param name="other">Instance of CelebrationStateParam to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CelebrationStateParam other)
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
