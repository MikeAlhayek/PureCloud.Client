using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDomain
/// </summary>

public partial class NluDomain : IEquatable<NluDomain>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomain" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluDomain() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomain" /> class.
    /// </summary>
    /// <param name="Name">The name of the NLU domain. (required).</param>
    /// <param name="Language">The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;..</param>
    /// <param name="EngineVersion">The version of the NLU engine to use..</param>
    public NluDomain(string Name = null, string Language = null, string EngineVersion = null)
    {
        this.Name = Name;
        this.Language = Language;
        this.EngineVersion = EngineVersion;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the NLU domain.
    /// </summary>
    /// <value>The name of the NLU domain.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.
    /// </summary>
    /// <value>The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// The draft version of that NLU domain.
    /// </summary>
    /// <value>The draft version of that NLU domain.</value>
    [JsonPropertyName("draftVersion")]
    public NluDomainVersion DraftVersion { get; set; }



    /// <summary>
    /// The last published version of that NLU domain.
    /// </summary>
    /// <value>The last published version of that NLU domain.</value>
    [JsonPropertyName("lastPublishedVersion")]
    public NluDomainVersion LastPublishedVersion { get; set; }



    /// <summary>
    /// The date when the NLU domain was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The date when the NLU domain was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The version of the NLU engine to use.
    /// </summary>
    /// <value>The version of the NLU engine to use.</value>
    [JsonPropertyName("engineVersion")]
    public string EngineVersion { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluDomain {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  DraftVersion: ").Append(DraftVersion).Append("\n");
        sb.Append("  LastPublishedVersion: ").Append(LastPublishedVersion).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  EngineVersion: ").Append(EngineVersion).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as NluDomain);
    }

    /// <summary>
    /// Returns true if NluDomain instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDomain to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluDomain other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                DraftVersion == other.DraftVersion ||
                DraftVersion != null &&
                DraftVersion.Equals(other.DraftVersion)
            ) &&
            (
                LastPublishedVersion == other.LastPublishedVersion ||
                LastPublishedVersion != null &&
                LastPublishedVersion.Equals(other.LastPublishedVersion)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                EngineVersion == other.EngineVersion ||
                EngineVersion != null &&
                EngineVersion.Equals(other.EngineVersion)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (DraftVersion != null)
            {
                hash = hash * 59 + DraftVersion.GetHashCode();
            }

            if (LastPublishedVersion != null)
            {
                hash = hash * 59 + LastPublishedVersion.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (EngineVersion != null)
            {
                hash = hash * 59 + EngineVersion.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
