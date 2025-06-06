using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchWebMessagingOfferFields
/// </summary>

public partial class PatchWebMessagingOfferFields : IEquatable<PatchWebMessagingOfferFields>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchWebMessagingOfferFields" /> class.
    /// </summary>
    /// <param name="OfferText">Text value to be used when inviting a visitor to engage with a web messaging offer..</param>
    /// <param name="ArchitectFlow">Flow to be invoked, overrides default flow when specified..</param>
    public PatchWebMessagingOfferFields(string OfferText = null, AddressableEntityRef ArchitectFlow = null)
    {
        this.OfferText = OfferText;
        this.ArchitectFlow = ArchitectFlow;

    }



    /// <summary>
    /// Text value to be used when inviting a visitor to engage with a web messaging offer.
    /// </summary>
    /// <value>Text value to be used when inviting a visitor to engage with a web messaging offer.</value>
    [JsonPropertyName("offerText")]
    public string OfferText { get; set; }



    /// <summary>
    /// Flow to be invoked, overrides default flow when specified.
    /// </summary>
    /// <value>Flow to be invoked, overrides default flow when specified.</value>
    [JsonPropertyName("architectFlow")]
    public AddressableEntityRef ArchitectFlow { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchWebMessagingOfferFields {\n");

        sb.Append("  OfferText: ").Append(OfferText).Append("\n");
        sb.Append("  ArchitectFlow: ").Append(ArchitectFlow).Append("\n");
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
        return Equals(obj as PatchWebMessagingOfferFields);
    }

    /// <summary>
    /// Returns true if PatchWebMessagingOfferFields instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchWebMessagingOfferFields to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchWebMessagingOfferFields other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OfferText == other.OfferText ||
                OfferText != null &&
                OfferText.Equals(other.OfferText)
            ) &&
            (
                ArchitectFlow == other.ArchitectFlow ||
                ArchitectFlow != null &&
                ArchitectFlow.Equals(other.ArchitectFlow)
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
            if (OfferText != null)
            {
                hash = hash * 59 + OfferText.GetHashCode();
            }

            if (ArchitectFlow != null)
            {
                hash = hash * 59 + ArchitectFlow.GetHashCode();
            }

            return hash;
        }
    }
}
