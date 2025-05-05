using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainEdgeSoftwareVersionDto
/// </summary>

public partial class DomainEdgeSoftwareVersionDto : IEquatable<DomainEdgeSoftwareVersionDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainEdgeSoftwareVersionDto" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="EdgeVersion">EdgeVersion.</param>
    /// <param name="PublishDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EdgeUri">EdgeUri.</param>
    /// <param name="LatestRelease">LatestRelease.</param>
    /// <param name="Current">Current.</param>
    public DomainEdgeSoftwareVersionDto(string Name = null, string EdgeVersion = null, DateTime? PublishDate = null, string EdgeUri = null, bool? LatestRelease = null, bool? Current = null)
    {
        this.Name = Name;
        this.EdgeVersion = EdgeVersion;
        this.PublishDate = PublishDate;
        this.EdgeUri = EdgeUri;
        this.LatestRelease = LatestRelease;
        this.Current = Current;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets EdgeVersion
    /// </summary>
    [JsonPropertyName("edgeVersion")]
    public string EdgeVersion { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("publishDate")]
    public DateTime? PublishDate { get; set; }



    /// <summary>
    /// Gets or Sets EdgeUri
    /// </summary>
    [JsonPropertyName("edgeUri")]
    public string EdgeUri { get; set; }



    /// <summary>
    /// Gets or Sets LatestRelease
    /// </summary>
    [JsonPropertyName("latestRelease")]
    public bool? LatestRelease { get; set; }



    /// <summary>
    /// Gets or Sets Current
    /// </summary>
    [JsonPropertyName("current")]
    public bool? Current { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainEdgeSoftwareVersionDto {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  EdgeVersion: ").Append(EdgeVersion).Append("\n");
        sb.Append("  PublishDate: ").Append(PublishDate).Append("\n");
        sb.Append("  EdgeUri: ").Append(EdgeUri).Append("\n");
        sb.Append("  LatestRelease: ").Append(LatestRelease).Append("\n");
        sb.Append("  Current: ").Append(Current).Append("\n");
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
        return Equals(obj as DomainEdgeSoftwareVersionDto);
    }

    /// <summary>
    /// Returns true if DomainEdgeSoftwareVersionDto instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainEdgeSoftwareVersionDto to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainEdgeSoftwareVersionDto other)
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
                EdgeVersion == other.EdgeVersion ||
                EdgeVersion != null &&
                EdgeVersion.Equals(other.EdgeVersion)
            ) &&
            (
                PublishDate == other.PublishDate ||
                PublishDate != null &&
                PublishDate.Equals(other.PublishDate)
            ) &&
            (
                EdgeUri == other.EdgeUri ||
                EdgeUri != null &&
                EdgeUri.Equals(other.EdgeUri)
            ) &&
            (
                LatestRelease == other.LatestRelease ||
                LatestRelease != null &&
                LatestRelease.Equals(other.LatestRelease)
            ) &&
            (
                Current == other.Current ||
                Current != null &&
                Current.Equals(other.Current)
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

            if (EdgeVersion != null)
            {
                hash = hash * 59 + EdgeVersion.GetHashCode();
            }

            if (PublishDate != null)
            {
                hash = hash * 59 + PublishDate.GetHashCode();
            }

            if (EdgeUri != null)
            {
                hash = hash * 59 + EdgeUri.GetHashCode();
            }

            if (LatestRelease != null)
            {
                hash = hash * 59 + LatestRelease.GetHashCode();
            }

            if (Current != null)
            {
                hash = hash * 59 + Current.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
