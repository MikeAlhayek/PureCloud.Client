using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about the active configuration on a deployment
/// </summary>

public sealed class WebDeploymentActiveConfigurationOnDeployment : IEquatable<WebDeploymentActiveConfigurationOnDeployment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentActiveConfigurationOnDeployment" /> class.
    /// </summary>
    /// <param name="ConfigurationVersion">The active configuration on a deployment.</param>
    /// <param name="Deployment">The web deployment associated with the active configuration.</param>
    public WebDeploymentActiveConfigurationOnDeployment(WebDeploymentConfigurationVersion ConfigurationVersion = null, WebDeployment Deployment = null)
    {
        this.ConfigurationVersion = ConfigurationVersion;
        this.Deployment = Deployment;

    }



    /// <summary>
    /// The active configuration on a deployment
    /// </summary>
    /// <value>The active configuration on a deployment</value>
    [JsonPropertyName("configurationVersion")]
    public WebDeploymentConfigurationVersion ConfigurationVersion { get; set; }



    /// <summary>
    /// The web deployment associated with the active configuration
    /// </summary>
    /// <value>The web deployment associated with the active configuration</value>
    [JsonPropertyName("deployment")]
    public WebDeployment Deployment { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentActiveConfigurationOnDeployment {\n");

        sb.Append("  ConfigurationVersion: ").Append(ConfigurationVersion).Append("\n");
        sb.Append("  Deployment: ").Append(Deployment).Append("\n");
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
        return Equals(obj as WebDeploymentActiveConfigurationOnDeployment);
    }

    /// <summary>
    /// Returns true if WebDeploymentActiveConfigurationOnDeployment instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentActiveConfigurationOnDeployment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentActiveConfigurationOnDeployment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConfigurationVersion == other.ConfigurationVersion ||
                ConfigurationVersion != null &&
                ConfigurationVersion.Equals(other.ConfigurationVersion)
            ) &&
            (
                Deployment == other.Deployment ||
                Deployment != null &&
                Deployment.Equals(other.Deployment)
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
            if (ConfigurationVersion != null)
            {
                hash = hash * 59 + ConfigurationVersion.GetHashCode();
            }

            if (Deployment != null)
            {
                hash = hash * 59 + Deployment.GetHashCode();
            }

            return hash;
        }
    }
}
