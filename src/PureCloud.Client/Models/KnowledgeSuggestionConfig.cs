using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeSuggestionConfig
/// </summary>

public partial class KnowledgeSuggestionConfig : IEquatable<KnowledgeSuggestionConfig>
{
    /// <summary>
    /// The name of vendor used for knowledge suggestions.
    /// </summary>
    /// <value>The name of vendor used for knowledge suggestions.</value>
    
    public enum VendorNameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Googledialogflow for "GoogleDialogflow"
        /// </summary>
        [EnumMember(Value = "GoogleDialogflow")]
        Googledialogflow,

        /// <summary>
        /// Enum Genesysknowledge for "GenesysKnowledge"
        /// </summary>
        [EnumMember(Value = "GenesysKnowledge")]
        Genesysknowledge,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The name of vendor used for knowledge suggestions.
    /// </summary>
    /// <value>The name of vendor used for knowledge suggestions.</value>
    [JsonPropertyName("vendorName")]
    public VendorNameEnum? VendorName { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSuggestionConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeSuggestionConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSuggestionConfig" /> class.
    /// </summary>
    /// <param name="VendorName">The name of vendor used for knowledge suggestions. (required).</param>
    /// <param name="KnowledgeBase">The ID of knowledge base to query when Genesys is the knowledge suggestions provider..</param>
    /// <param name="KnowledgeBases">The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider..</param>
    public KnowledgeSuggestionConfig(VendorNameEnum? VendorName = null, KnowledgeBaseReference KnowledgeBase = null, List<KnowledgeBaseWithDialectReference> KnowledgeBases = null)
    {
        this.VendorName = VendorName;
        this.KnowledgeBase = KnowledgeBase;
        this.KnowledgeBases = KnowledgeBases;

    }





    /// <summary>
    /// The ID of knowledge base to query when Genesys is the knowledge suggestions provider.
    /// </summary>
    /// <value>The ID of knowledge base to query when Genesys is the knowledge suggestions provider.</value>
    [JsonPropertyName("knowledgeBase")]
    public KnowledgeBaseReference KnowledgeBase { get; set; }



    /// <summary>
    /// The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider.
    /// </summary>
    /// <value>The knowledge bases to query based on dialect, when Genesys is the knowledge suggestions provider.</value>
    [JsonPropertyName("knowledgeBases")]
    public List<KnowledgeBaseWithDialectReference> KnowledgeBases { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeSuggestionConfig {\n");

        sb.Append("  VendorName: ").Append(VendorName).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
        sb.Append("  KnowledgeBases: ").Append(KnowledgeBases).Append("\n");
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
        return Equals(obj as KnowledgeSuggestionConfig);
    }

    /// <summary>
    /// Returns true if KnowledgeSuggestionConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeSuggestionConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeSuggestionConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                VendorName == other.VendorName ||
                VendorName != null &&
                VendorName.Equals(other.VendorName)
            ) &&
            (
                KnowledgeBase == other.KnowledgeBase ||
                KnowledgeBase != null &&
                KnowledgeBase.Equals(other.KnowledgeBase)
            ) &&
            (
                KnowledgeBases == other.KnowledgeBases ||
                KnowledgeBases != null &&
                KnowledgeBases.SequenceEqual(other.KnowledgeBases)
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
            if (VendorName != null)
            {
                hash = hash * 59 + VendorName.GetHashCode();
            }

            if (KnowledgeBase != null)
            {
                hash = hash * 59 + KnowledgeBase.GetHashCode();
            }

            if (KnowledgeBases != null)
            {
                hash = hash * 59 + KnowledgeBases.GetHashCode();
            }

            return hash;
        }
    }
}
