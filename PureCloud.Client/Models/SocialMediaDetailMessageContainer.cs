using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SocialMediaDetailMessageContainer
/// </summary>
[DataContract]
public partial class SocialMediaDetailMessageContainer : IEquatable<SocialMediaDetailMessageContainer>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SocialMediaDetailMessageContainer" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="NormalizedMessage">NormalizedMessage.</param>
    /// <param name="EscalationInfo">EscalationInfo.</param>
    public SocialMediaDetailMessageContainer(string Id = null, ConversationNormalizedMessage NormalizedMessage = null, SocialMediaMessageEscalationInfo EscalationInfo = null)
    {
        this.Id = Id;
        this.NormalizedMessage = NormalizedMessage;
        this.EscalationInfo = EscalationInfo;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets NormalizedMessage
    /// </summary>
    [DataMember(Name = "normalizedMessage", EmitDefaultValue = false)]
    public ConversationNormalizedMessage NormalizedMessage { get; set; }



    /// <summary>
    /// Gets or Sets EscalationInfo
    /// </summary>
    [DataMember(Name = "escalationInfo", EmitDefaultValue = false)]
    public SocialMediaMessageEscalationInfo EscalationInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SocialMediaDetailMessageContainer {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  NormalizedMessage: ").Append(NormalizedMessage).Append("\n");
        sb.Append("  EscalationInfo: ").Append(EscalationInfo).Append("\n");
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
        return Equals(obj as SocialMediaDetailMessageContainer);
    }

    /// <summary>
    /// Returns true if SocialMediaDetailMessageContainer instances are equal
    /// </summary>
    /// <param name="other">Instance of SocialMediaDetailMessageContainer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SocialMediaDetailMessageContainer other)
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
                NormalizedMessage == other.NormalizedMessage ||
                NormalizedMessage != null &&
                NormalizedMessage.Equals(other.NormalizedMessage)
            ) &&
            (
                EscalationInfo == other.EscalationInfo ||
                EscalationInfo != null &&
                EscalationInfo.Equals(other.EscalationInfo)
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

            if (NormalizedMessage != null)
            {
                hash = hash * 59 + NormalizedMessage.GetHashCode();
            }

            if (EscalationInfo != null)
            {
                hash = hash * 59 + EscalationInfo.GetHashCode();
            }

            return hash;
        }
    }
}
