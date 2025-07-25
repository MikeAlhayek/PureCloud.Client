using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentFlowEntityRef
/// </summary>

public partial class WebDeploymentFlowEntityRef : IEquatable<WebDeploymentFlowEntityRef>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentFlowEntityRef" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebDeploymentFlowEntityRef() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentFlowEntityRef" /> class.
    /// </summary>
    /// <param name="Id">The Flow ID (required).</param>
    /// <param name="Name">The Flow name.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="FlowDescription">The flow description for the webdeployment.</param>
    /// <param name="PublishVersion">The published config version for the associated deployment.</param>
    public WebDeploymentFlowEntityRef(string Id = null, string Name = null, string SelfUri = null, string FlowDescription = null, FlowVersion PublishVersion = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SelfUri = SelfUri;
        this.FlowDescription = FlowDescription;
        this.PublishVersion = PublishVersion;

    }



    /// <summary>
    /// The Flow ID
    /// </summary>
    /// <value>The Flow ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The Flow name
    /// </summary>
    /// <value>The Flow name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// The flow description for the webdeployment
    /// </summary>
    /// <value>The flow description for the webdeployment</value>
    [JsonPropertyName("flowDescription")]
    public string FlowDescription { get; set; }



    /// <summary>
    /// The published config version for the associated deployment
    /// </summary>
    /// <value>The published config version for the associated deployment</value>
    [JsonPropertyName("publishVersion")]
    public FlowVersion PublishVersion { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentFlowEntityRef {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  FlowDescription: ").Append(FlowDescription).Append("\n");
        sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
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
        return Equals(obj as WebDeploymentFlowEntityRef);
    }

    /// <summary>
    /// Returns true if WebDeploymentFlowEntityRef instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentFlowEntityRef to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentFlowEntityRef other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                FlowDescription == other.FlowDescription ||
                FlowDescription != null &&
                FlowDescription.Equals(other.FlowDescription)
            ) &&
            (
                PublishVersion == other.PublishVersion ||
                PublishVersion != null &&
                PublishVersion.Equals(other.PublishVersion)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (FlowDescription != null)
            {
                hash = hash * 59 + FlowDescription.GetHashCode();
            }

            if (PublishVersion != null)
            {
                hash = hash * 59 + PublishVersion.GetHashCode();
            }

            return hash;
        }
    }
}
