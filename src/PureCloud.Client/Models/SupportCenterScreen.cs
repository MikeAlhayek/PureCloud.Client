using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportCenterScreen
/// </summary>

public partial class SupportCenterScreen : IEquatable<SupportCenterScreen>
{
    /// <summary>
    /// The type of the screen
    /// </summary>
    /// <value>The type of the screen</value>
    
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
        /// Enum Home for "Home"
        /// </summary>
        [EnumMember(Value = "Home")]
        Home,

        /// <summary>
        /// Enum Category for "Category"
        /// </summary>
        [EnumMember(Value = "Category")]
        Category,

        /// <summary>
        /// Enum Searchresults for "SearchResults"
        /// </summary>
        [EnumMember(Value = "SearchResults")]
        Searchresults,

        /// <summary>
        /// Enum Article for "Article"
        /// </summary>
        [EnumMember(Value = "Article")]
        Article
    }
    /// <summary>
    /// The type of the screen
    /// </summary>
    /// <value>The type of the screen</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterScreen" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportCenterScreen() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterScreen" /> class.
    /// </summary>
    /// <param name="Type">The type of the screen (required).</param>
    /// <param name="ModuleSettings">Module settings for the screen, valid modules for each screenType: Home: Search, Categories, TopViewedArticles; Category: Search, Categories; SearchResults: Search, Results; Article: Search, Article; (required).</param>
    public SupportCenterScreen(TypeEnum? Type = null, List<SupportCenterModuleSetting> ModuleSettings = null)
    {
        this.Type = Type;
        this.ModuleSettings = ModuleSettings;

    }





    /// <summary>
    /// Module settings for the screen, valid modules for each screenType: Home: Search, Categories, TopViewedArticles; Category: Search, Categories; SearchResults: Search, Results; Article: Search, Article;
    /// </summary>
    /// <value>Module settings for the screen, valid modules for each screenType: Home: Search, Categories, TopViewedArticles; Category: Search, Categories; SearchResults: Search, Results; Article: Search, Article;</value>
    [JsonPropertyName("moduleSettings")]
    public List<SupportCenterModuleSetting> ModuleSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterScreen {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ModuleSettings: ").Append(ModuleSettings).Append("\n");
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
        return Equals(obj as SupportCenterScreen);
    }

    /// <summary>
    /// Returns true if SupportCenterScreen instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterScreen to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterScreen other)
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
                ModuleSettings == other.ModuleSettings ||
                ModuleSettings != null &&
                ModuleSettings.SequenceEqual(other.ModuleSettings)
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

            if (ModuleSettings != null)
            {
                hash = hash * 59 + ModuleSettings.GetHashCode();
            }

            return hash;
        }
    }
}
