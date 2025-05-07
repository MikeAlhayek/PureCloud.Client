using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingEncryptionConfiguration
/// </summary>

public partial class RecordingEncryptionConfiguration : IEquatable<RecordingEncryptionConfiguration>
{
    /// <summary>
    /// Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; 'Native' for disabling configuration.
    /// </summary>
    /// <value>Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; 'Native' for disabling configuration.</value>
    
    public enum KeyConfigurationTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Kmssymmetric for "KmsSymmetric"
        /// </summary>
        [EnumMember(Value = "KmsSymmetric")]
        Kmssymmetric,

        /// <summary>
        /// Enum Localkeymanager for "LocalKeyManager"
        /// </summary>
        [EnumMember(Value = "LocalKeyManager")]
        Localkeymanager,

        /// <summary>
        /// Enum Native for "Native"
        /// </summary>
        [EnumMember(Value = "Native")]
        Native,

        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None
    }
    /// <summary>
    /// Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; 'Native' for disabling configuration.
    /// </summary>
    /// <value>Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; 'Native' for disabling configuration.</value>
    [JsonPropertyName("keyConfigurationType")]
    public KeyConfigurationTypeEnum? KeyConfigurationType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingEncryptionConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RecordingEncryptionConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingEncryptionConfiguration" /> class.
    /// </summary>
    /// <param name="Url">When keyConfigurationType is LocalKeyManager, this should be the url for decryption and must specify the path to where GenesysCloud can requests decryption. When keyConfigurationType is KmsSymmetric, this should be the arn to the key alias for the master key (required).</param>
    /// <param name="ApiId">The api id for Hawk Authentication. Null if keyConfigurationType is KmsSymmetric.</param>
    /// <param name="ApiKey">The api shared symmetric key used for hawk authentication. Null if keyConfigurationType is KmsSymmetric.</param>
    /// <param name="KeyConfigurationType">Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; &#39;Native&#39; for disabling configuration. (required).</param>
    /// <param name="LastError">The error message related to the configuration.</param>
    public RecordingEncryptionConfiguration(string Url = null, string ApiId = null, string ApiKey = null, KeyConfigurationTypeEnum? KeyConfigurationType = null, ErrorBody LastError = null)
    {
        this.Url = Url;
        this.ApiId = ApiId;
        this.ApiKey = ApiKey;
        this.KeyConfigurationType = KeyConfigurationType;
        this.LastError = LastError;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// When keyConfigurationType is LocalKeyManager, this should be the url for decryption and must specify the path to where GenesysCloud can requests decryption. When keyConfigurationType is KmsSymmetric, this should be the arn to the key alias for the master key
    /// </summary>
    /// <value>When keyConfigurationType is LocalKeyManager, this should be the url for decryption and must specify the path to where GenesysCloud can requests decryption. When keyConfigurationType is KmsSymmetric, this should be the arn to the key alias for the master key</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// The api id for Hawk Authentication. Null if keyConfigurationType is KmsSymmetric
    /// </summary>
    /// <value>The api id for Hawk Authentication. Null if keyConfigurationType is KmsSymmetric</value>
    [JsonPropertyName("apiId")]
    public string ApiId { get; set; }



    /// <summary>
    /// The api shared symmetric key used for hawk authentication. Null if keyConfigurationType is KmsSymmetric
    /// </summary>
    /// <value>The api shared symmetric key used for hawk authentication. Null if keyConfigurationType is KmsSymmetric</value>
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; set; }





    /// <summary>
    /// The error message related to the configuration
    /// </summary>
    /// <value>The error message related to the configuration</value>
    [JsonPropertyName("lastError")]
    public ErrorBody LastError { get; set; }



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
        sb.Append("class RecordingEncryptionConfiguration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  ApiId: ").Append(ApiId).Append("\n");
        sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
        sb.Append("  KeyConfigurationType: ").Append(KeyConfigurationType).Append("\n");
        sb.Append("  LastError: ").Append(LastError).Append("\n");
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
        return Equals(obj as RecordingEncryptionConfiguration);
    }

    /// <summary>
    /// Returns true if RecordingEncryptionConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingEncryptionConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingEncryptionConfiguration other)
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
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                ApiId == other.ApiId ||
                ApiId != null &&
                ApiId.Equals(other.ApiId)
            ) &&
            (
                ApiKey == other.ApiKey ||
                ApiKey != null &&
                ApiKey.Equals(other.ApiKey)
            ) &&
            (
                KeyConfigurationType == other.KeyConfigurationType ||
                KeyConfigurationType != null &&
                KeyConfigurationType.Equals(other.KeyConfigurationType)
            ) &&
            (
                LastError == other.LastError ||
                LastError != null &&
                LastError.Equals(other.LastError)
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

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (ApiId != null)
            {
                hash = hash * 59 + ApiId.GetHashCode();
            }

            if (ApiKey != null)
            {
                hash = hash * 59 + ApiKey.GetHashCode();
            }

            if (KeyConfigurationType != null)
            {
                hash = hash * 59 + KeyConfigurationType.GetHashCode();
            }

            if (LastError != null)
            {
                hash = hash * 59 + LastError.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
