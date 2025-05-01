using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeIntegrationDefaultSettings
/// </summary>
[DataContract]
public partial class KnowledgeIntegrationDefaultSettings : IEquatable<KnowledgeIntegrationDefaultSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeIntegrationDefaultSettings" /> class.
    /// </summary>
    /// <param name="BaseUrl">The default base URL setting for the integration..</param>
    public KnowledgeIntegrationDefaultSettings(string BaseUrl = null)
    {
        this.BaseUrl = BaseUrl;

    }



    /// <summary>
    /// The default base URL setting for the integration.
    /// </summary>
    /// <value>The default base URL setting for the integration.</value>
    [DataMember(Name = "baseUrl", EmitDefaultValue = false)]
    public string BaseUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeIntegrationDefaultSettings {\n");

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
        return Equals(obj as KnowledgeIntegrationDefaultSettings);
    }

    /// <summary>
    /// Returns true if KnowledgeIntegrationDefaultSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeIntegrationDefaultSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeIntegrationDefaultSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (BaseUrl != null)
            {
                hash = hash * 59 + BaseUrl.GetHashCode();
            }

            return hash;
        }
    }
}
