using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SalesforceSettings
/// </summary>

public partial class SalesforceSettings : IEquatable<SalesforceSettings>
{
    /// <summary>
    /// Filter source by channel.
    /// </summary>
    /// <value>Filter source by channel.</value>
    
    public enum ChannelEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum App for "App"
        /// </summary>
        [EnumMember(Value = "App")]
        App,

        /// <summary>
        /// Enum Pkb for "Pkb"
        /// </summary>
        [EnumMember(Value = "Pkb")]
        Pkb,

        /// <summary>
        /// Enum Csp for "Csp"
        /// </summary>
        [EnumMember(Value = "Csp")]
        Csp,

        /// <summary>
        /// Enum Prm for "Prm"
        /// </summary>
        [EnumMember(Value = "Prm")]
        Prm
    }
    /// <summary>
    /// Filter source by channel.
    /// </summary>
    /// <value>Filter source by channel.</value>
    [JsonPropertyName("channel")]
    public ChannelEnum? Channel { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesforceSettings" /> class.
    /// </summary>
    /// <param name="Channel">Filter source by channel..</param>
    /// <param name="Language">Filter source by language..</param>
    /// <param name="Categories">Filter source by categories..</param>
    /// <param name="BaseUrl">The base URL to resources..</param>
    public SalesforceSettings(ChannelEnum? Channel = null, string Language = null, List<string> Categories = null, string BaseUrl = null)
    {
        this.Channel = Channel;
        this.Language = Language;
        this.Categories = Categories;
        this.BaseUrl = BaseUrl;

    }





    /// <summary>
    /// Filter source by language.
    /// </summary>
    /// <value>Filter source by language.</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// Filter source by categories.
    /// </summary>
    /// <value>Filter source by categories.</value>
    [JsonPropertyName("categories")]
    public List<string> Categories { get; set; }



    /// <summary>
    /// The base URL to resources.
    /// </summary>
    /// <value>The base URL to resources.</value>
    [JsonPropertyName("baseUrl")]
    public string BaseUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SalesforceSettings {\n");

        sb.Append("  Channel: ").Append(Channel).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
        sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
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
        return Equals(obj as SalesforceSettings);
    }

    /// <summary>
    /// Returns true if SalesforceSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of SalesforceSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SalesforceSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Channel == other.Channel ||
                Channel != null &&
                Channel.Equals(other.Channel)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Categories == other.Categories ||
                Categories != null &&
                Categories.SequenceEqual(other.Categories)
            ) &&
            (
                BaseUrl == other.BaseUrl ||
                BaseUrl != null &&
                BaseUrl.Equals(other.BaseUrl)
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
            if (Channel != null)
            {
                hash = hash * 59 + Channel.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Categories != null)
            {
                hash = hash * 59 + Categories.GetHashCode();
            }

            if (BaseUrl != null)
            {
                hash = hash * 59 + BaseUrl.GetHashCode();
            }

            return hash;
        }
    }
}
