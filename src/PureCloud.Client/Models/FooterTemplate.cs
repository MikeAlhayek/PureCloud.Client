using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The Footer template identifies the Footer type and its footerUsage
/// </summary>

public partial class FooterTemplate : IEquatable<FooterTemplate>
{
    /// <summary>
    /// Specifies the type represented by Footer.
    /// </summary>
    /// <value>Specifies the type represented by Footer.</value>
    
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
        /// Enum Signature for "Signature"
        /// </summary>
        [EnumMember(Value = "Signature")]
        Signature
    }
    /// <summary>
    /// Gets or Sets ApplicableResources
    /// </summary>
    
    public enum ApplicableResourcesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Campaign for "Campaign"
        /// </summary>
        [EnumMember(Value = "Campaign")]
        Campaign
    }
    /// <summary>
    /// Specifies the type represented by Footer.
    /// </summary>
    /// <value>Specifies the type represented by Footer.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FooterTemplate" /> class.
    /// </summary>
    /// <param name="Type">Specifies the type represented by Footer..</param>
    /// <param name="ApplicableResources">Specifies the canned response template where the footer can be used..</param>
    public FooterTemplate(TypeEnum? Type = null, List<ApplicableResourcesEnum> ApplicableResources = null)
    {
        this.Type = Type;
        this.ApplicableResources = ApplicableResources;

    }





    /// <summary>
    /// Specifies the canned response template where the footer can be used.
    /// </summary>
    /// <value>Specifies the canned response template where the footer can be used.</value>
    [JsonPropertyName("applicableResources")]
    public List<ApplicableResourcesEnum> ApplicableResources { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FooterTemplate {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ApplicableResources: ").Append(ApplicableResources).Append("\n");
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
        return Equals(obj as FooterTemplate);
    }

    /// <summary>
    /// Returns true if FooterTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of FooterTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FooterTemplate other)
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
                ApplicableResources == other.ApplicableResources ||
                ApplicableResources != null &&
                ApplicableResources.SequenceEqual(other.ApplicableResources)
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

            if (ApplicableResources != null)
            {
                hash = hash * 59 + ApplicableResources.GetHashCode();
            }

            return hash;
        }
    }
}
