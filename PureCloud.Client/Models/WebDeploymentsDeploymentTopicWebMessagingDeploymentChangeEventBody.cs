using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody
/// </summary>
[DataContract]
public partial class WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody : IEquatable<WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Deleting for "Deleting"
        /// </summary>
        [EnumMember(Value = "Deleting")]
        Deleting
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Configuration">Configuration.</param>
    /// <param name="Status">Status.</param>
    public WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody(string Id = null, WebDeploymentsDeploymentTopicWebMessagingConfigChangeEventBody Configuration = null, StatusEnum? Status = null)
    {
        this.Id = Id;
        this.Configuration = Configuration;
        this.Status = Status;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    [DataMember(Name = "configuration", EmitDefaultValue = false)]
    public WebDeploymentsDeploymentTopicWebMessagingConfigChangeEventBody Configuration { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Configuration: ").Append(Configuration).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody);
    }

    /// <summary>
    /// Returns true if WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody other)
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
                Configuration == other.Configuration ||
                Configuration != null &&
                Configuration.Equals(other.Configuration)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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

            if (Configuration != null)
            {
                hash = hash * 59 + Configuration.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
