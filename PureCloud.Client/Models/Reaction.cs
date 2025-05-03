using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Reaction
/// </summary>

public partial class Reaction : IEquatable<Reaction>
{
    /// <summary>
    /// The reaction to take for a given call analysis result.
    /// </summary>
    /// <value>The reaction to take for a given call analysis result.</value>
    
    public enum ReactionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Hangup for "hangup"
        /// </summary>
        [EnumMember(Value = "hangup")]
        Hangup,

        /// <summary>
        /// Enum Transfer for "transfer"
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer,

        /// <summary>
        /// Enum TransferFlow for "transfer_flow"
        /// </summary>
        [EnumMember(Value = "transfer_flow")]
        TransferFlow,

        /// <summary>
        /// Enum PlayFile for "play_file"
        /// </summary>
        [EnumMember(Value = "play_file")]
        PlayFile
    }
    /// <summary>
    /// The reaction to take for a given call analysis result.
    /// </summary>
    /// <value>The reaction to take for a given call analysis result.</value>
    [JsonPropertyName("reactionType")]
    public ReactionTypeEnum? ReactionType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Reaction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Reaction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Reaction" /> class.
    /// </summary>
    /// <param name="Data">Parameter for this reaction. For transfer_flow, this would be the outbound flow id..</param>
    /// <param name="Name">Name of the parameter for this reaction. For transfer_flow, this would be the outbound flow name..</param>
    /// <param name="ReactionType">The reaction to take for a given call analysis result. (required).</param>
    public Reaction(string Data = null, string Name = null, ReactionTypeEnum? ReactionType = null)
    {
        this.Data = Data;
        this.Name = Name;
        this.ReactionType = ReactionType;

    }



    /// <summary>
    /// Parameter for this reaction. For transfer_flow, this would be the outbound flow id.
    /// </summary>
    /// <value>Parameter for this reaction. For transfer_flow, this would be the outbound flow id.</value>
    [JsonPropertyName("data")]
    public string Data { get; set; }



    /// <summary>
    /// Name of the parameter for this reaction. For transfer_flow, this would be the outbound flow name.
    /// </summary>
    /// <value>Name of the parameter for this reaction. For transfer_flow, this would be the outbound flow name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Reaction {\n");

        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ReactionType: ").Append(ReactionType).Append("\n");
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
        return Equals(obj as Reaction);
    }

    /// <summary>
    /// Returns true if Reaction instances are equal
    /// </summary>
    /// <param name="other">Instance of Reaction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Reaction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Data == other.Data ||
                Data != null &&
                Data.Equals(other.Data)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ReactionType == other.ReactionType ||
                ReactionType != null &&
                ReactionType.Equals(other.ReactionType)
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
            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ReactionType != null)
            {
                hash = hash * 59 + ReactionType.GetHashCode();
            }

            return hash;
        }
    }
}
