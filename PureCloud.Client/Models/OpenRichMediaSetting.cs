using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// OpenRichMediaSetting
/// </summary>
[DataContract]
public partial class OpenRichMediaSetting : IEquatable<OpenRichMediaSetting>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenRichMediaSetting" /> class.
    /// </summary>
    /// <param name="QuickReply">Setting relating to quick replies.</param>
    /// <param name="Cards">Setting relating to cards.</param>
    public OpenRichMediaSetting(OutboundOnlySetting QuickReply = null, OutboundOnlySetting Cards = null)
    {
        this.QuickReply = QuickReply;
        this.Cards = Cards;

    }



    /// <summary>
    /// Setting relating to quick replies
    /// </summary>
    /// <value>Setting relating to quick replies</value>
    [DataMember(Name = "quickReply", EmitDefaultValue = false)]
    public OutboundOnlySetting QuickReply { get; set; }



    /// <summary>
    /// Setting relating to cards
    /// </summary>
    /// <value>Setting relating to cards</value>
    [DataMember(Name = "cards", EmitDefaultValue = false)]
    public OutboundOnlySetting Cards { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenRichMediaSetting {\n");

        sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
        sb.Append("  Cards: ").Append(Cards).Append("\n");
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
        return Equals(obj as OpenRichMediaSetting);
    }

    /// <summary>
    /// Returns true if OpenRichMediaSetting instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenRichMediaSetting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenRichMediaSetting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QuickReply == other.QuickReply ||
                QuickReply != null &&
                QuickReply.Equals(other.QuickReply)
            ) &&
            (
                Cards == other.Cards ||
                Cards != null &&
                Cards.Equals(other.Cards)
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
            if (QuickReply != null)
            {
                hash = hash * 59 + QuickReply.GetHashCode();
            }

            if (Cards != null)
            {
                hash = hash * 59 + Cards.GetHashCode();
            }

            return hash;
        }
    }
}
