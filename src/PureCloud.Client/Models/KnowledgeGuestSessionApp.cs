using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeGuestSessionApp
/// </summary>

public partial class KnowledgeGuestSessionApp : IEquatable<KnowledgeGuestSessionApp>
{
    /// <summary>
    /// App type.
    /// </summary>
    /// <value>App type.</value>
    
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
        /// Enum Messengerknowledgeapp for "MessengerKnowledgeApp"
        /// </summary>
        [EnumMember(Value = "MessengerKnowledgeApp")]
        Messengerknowledgeapp,

        /// <summary>
        /// Enum Supportcenter for "SupportCenter"
        /// </summary>
        [EnumMember(Value = "SupportCenter")]
        Supportcenter
    }
    /// <summary>
    /// App type.
    /// </summary>
    /// <value>App type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSessionApp" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeGuestSessionApp() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSessionApp" /> class.
    /// </summary>
    /// <param name="DeploymentId">App deployment ID. (required).</param>
    /// <param name="Type">App type. (required).</param>
    public KnowledgeGuestSessionApp(string DeploymentId = null, TypeEnum? Type = null)
    {
        this.DeploymentId = DeploymentId;
        this.Type = Type;

    }



    /// <summary>
    /// App deployment ID.
    /// </summary>
    /// <value>App deployment ID.</value>
    [JsonPropertyName("deploymentId")]
    public string DeploymentId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeGuestSessionApp {\n");

        sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as KnowledgeGuestSessionApp);
    }

    /// <summary>
    /// Returns true if KnowledgeGuestSessionApp instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeGuestSessionApp to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeGuestSessionApp other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DeploymentId == other.DeploymentId ||
                DeploymentId != null &&
                DeploymentId.Equals(other.DeploymentId)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (DeploymentId != null)
            {
                hash = hash * 59 + DeploymentId.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
