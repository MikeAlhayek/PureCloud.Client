using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CopilotNluDomain
/// </summary>

public partial class CopilotNluDomain : IEquatable<CopilotNluDomain>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CopilotNluDomain" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CopilotNluDomain() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CopilotNluDomain" /> class.
    /// </summary>
    /// <param name="Id">Id of the NLU domain. (required).</param>
    /// <param name="UseLatestVersion">Use the latest version of the NLU domain. If false, version is required. (required).</param>
    /// <param name="Version">NLU domain version..</param>
    public CopilotNluDomain(string Id = null, bool? UseLatestVersion = null, CopilotNluDomainVersion Version = null)
    {
        this.Id = Id;
        this.UseLatestVersion = UseLatestVersion;
        this.Version = Version;

    }



    /// <summary>
    /// Id of the NLU domain.
    /// </summary>
    /// <value>Id of the NLU domain.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Use the latest version of the NLU domain. If false, version is required.
    /// </summary>
    /// <value>Use the latest version of the NLU domain. If false, version is required.</value>
    [JsonPropertyName("useLatestVersion")]
    public bool? UseLatestVersion { get; set; }



    /// <summary>
    /// NLU domain version.
    /// </summary>
    /// <value>NLU domain version.</value>
    [JsonPropertyName("version")]
    public CopilotNluDomainVersion Version { get; set; }



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
        sb.Append("class CopilotNluDomain {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  UseLatestVersion: ").Append(UseLatestVersion).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as CopilotNluDomain);
    }

    /// <summary>
    /// Returns true if CopilotNluDomain instances are equal
    /// </summary>
    /// <param name="other">Instance of CopilotNluDomain to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CopilotNluDomain other)
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
                UseLatestVersion == other.UseLatestVersion ||
                UseLatestVersion != null &&
                UseLatestVersion.Equals(other.UseLatestVersion)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (UseLatestVersion != null)
            {
                hash = hash * 59 + UseLatestVersion.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
