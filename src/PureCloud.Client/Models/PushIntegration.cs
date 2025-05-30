using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PushIntegration
/// </summary>

public partial class PushIntegration : IEquatable<PushIntegration>
{
    /// <summary>
    /// The integration provider associated with the deployment
    /// </summary>
    /// <value>The integration provider associated with the deployment</value>
    
    public enum ProviderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Apns for "APNS"
        /// </summary>
        [EnumMember(Value = "APNS")]
        Apns,

        /// <summary>
        /// Enum Fcm for "FCM"
        /// </summary>
        [EnumMember(Value = "FCM")]
        Fcm
    }
    /// <summary>
    /// The integration provider associated with the deployment
    /// </summary>
    /// <value>The integration provider associated with the deployment</value>
    [JsonPropertyName("provider")]
    public ProviderEnum? Provider { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PushIntegration" /> class.
    /// </summary>
    /// <param name="Provider">The integration provider associated with the deployment.</param>
    public PushIntegration(ProviderEnum? Provider = null)
    {
        this.Provider = Provider;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PushIntegration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
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
        return Equals(obj as PushIntegration);
    }

    /// <summary>
    /// Returns true if PushIntegration instances are equal
    /// </summary>
    /// <param name="other">Instance of PushIntegration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PushIntegration other)
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
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
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

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            return hash;
        }
    }
}
