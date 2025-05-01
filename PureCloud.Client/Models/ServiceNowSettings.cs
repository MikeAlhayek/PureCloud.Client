using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ServiceNowSettings
/// </summary>
[DataContract]
public partial class ServiceNowSettings : IEquatable<ServiceNowSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceNowSettings" /> class.
    /// </summary>
    /// <param name="KnowledgeBaseIds">Filter source by knowledge base ids..</param>
    /// <param name="Language">Filter source by language..</param>
    /// <param name="Categories">Filter source by categories..</param>
    /// <param name="BaseUrl">The base URL to resources..</param>
    public ServiceNowSettings(List<string> KnowledgeBaseIds = null, string Language = null, List<string> Categories = null, string BaseUrl = null)
    {
        this.KnowledgeBaseIds = KnowledgeBaseIds;
        this.Language = Language;
        this.Categories = Categories;
        this.BaseUrl = BaseUrl;

    }



    /// <summary>
    /// Filter source by knowledge base ids.
    /// </summary>
    /// <value>Filter source by knowledge base ids.</value>
    [DataMember(Name = "knowledgeBaseIds", EmitDefaultValue = false)]
    public List<string> KnowledgeBaseIds { get; set; }



    /// <summary>
    /// Filter source by language.
    /// </summary>
    /// <value>Filter source by language.</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }



    /// <summary>
    /// Filter source by categories.
    /// </summary>
    /// <value>Filter source by categories.</value>
    [DataMember(Name = "categories", EmitDefaultValue = false)]
    public List<string> Categories { get; set; }



    /// <summary>
    /// The base URL to resources.
    /// </summary>
    /// <value>The base URL to resources.</value>
    [DataMember(Name = "baseUrl", EmitDefaultValue = false)]
    public string BaseUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ServiceNowSettings {\n");

        sb.Append("  KnowledgeBaseIds: ").Append(KnowledgeBaseIds).Append("\n");
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
        return Equals(obj as ServiceNowSettings);
    }

    /// <summary>
    /// Returns true if ServiceNowSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ServiceNowSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ServiceNowSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                KnowledgeBaseIds == other.KnowledgeBaseIds ||
                KnowledgeBaseIds != null &&
                KnowledgeBaseIds.SequenceEqual(other.KnowledgeBaseIds)
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
            if (KnowledgeBaseIds != null)
            {
                hash = hash * 59 + KnowledgeBaseIds.GetHashCode();
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
