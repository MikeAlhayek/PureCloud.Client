using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EncryptionKey
/// </summary>
[DataContract]
public partial class EncryptionKey : IEquatable<EncryptionKey>
{
    /// <summary>
    /// Key type used in this configuration
    /// </summary>
    /// <value>Key type used in this configuration</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Key type used in this configuration
    /// </summary>
    /// <value>Key type used in this configuration</value>
    [DataMember(Name = "keyConfigurationType", EmitDefaultValue = false)]
    public KeyConfigurationTypeEnum? KeyConfigurationType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EncryptionKey" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="CreateDate">create date of the key pair. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="KeydataSummary">key data summary (base 64 encoded public key).</param>
    /// <param name="User">user that requested generation of public key.</param>
    /// <param name="LocalEncryptionConfiguration">Local configuration.</param>
    /// <param name="KeyConfigurationType">Key type used in this configuration.</param>
    /// <param name="KmsKeyArn">ARN of internal key to be wrapped by AWS KMS Symmetric key.</param>
    public EncryptionKey(string Name = null, DateTime? CreateDate = null, string KeydataSummary = null, User User = null, LocalEncryptionConfiguration LocalEncryptionConfiguration = null, KeyConfigurationTypeEnum? KeyConfigurationType = null, string KmsKeyArn = null)
    {
        this.Name = Name;
        this.CreateDate = CreateDate;
        this.KeydataSummary = KeydataSummary;
        this.User = User;
        this.LocalEncryptionConfiguration = LocalEncryptionConfiguration;
        this.KeyConfigurationType = KeyConfigurationType;
        this.KmsKeyArn = KmsKeyArn;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// create date of the key pair. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>create date of the key pair. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createDate", EmitDefaultValue = false)]
    public DateTime? CreateDate { get; set; }



    /// <summary>
    /// key data summary (base 64 encoded public key)
    /// </summary>
    /// <value>key data summary (base 64 encoded public key)</value>
    [DataMember(Name = "keydataSummary", EmitDefaultValue = false)]
    public string KeydataSummary { get; set; }



    /// <summary>
    /// user that requested generation of public key
    /// </summary>
    /// <value>user that requested generation of public key</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public User User { get; set; }



    /// <summary>
    /// Local configuration
    /// </summary>
    /// <value>Local configuration</value>
    [DataMember(Name = "localEncryptionConfiguration", EmitDefaultValue = false)]
    public LocalEncryptionConfiguration LocalEncryptionConfiguration { get; set; }





    /// <summary>
    /// ARN of internal key to be wrapped by AWS KMS Symmetric key
    /// </summary>
    /// <value>ARN of internal key to be wrapped by AWS KMS Symmetric key</value>
    [DataMember(Name = "kmsKeyArn", EmitDefaultValue = false)]
    public string KmsKeyArn { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EncryptionKey {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        sb.Append("  KeydataSummary: ").Append(KeydataSummary).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  LocalEncryptionConfiguration: ").Append(LocalEncryptionConfiguration).Append("\n");
        sb.Append("  KeyConfigurationType: ").Append(KeyConfigurationType).Append("\n");
        sb.Append("  KmsKeyArn: ").Append(KmsKeyArn).Append("\n");
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
        return Equals(obj as EncryptionKey);
    }

    /// <summary>
    /// Returns true if EncryptionKey instances are equal
    /// </summary>
    /// <param name="other">Instance of EncryptionKey to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EncryptionKey other)
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
                CreateDate == other.CreateDate ||
                CreateDate != null &&
                CreateDate.Equals(other.CreateDate)
            ) &&
            (
                KeydataSummary == other.KeydataSummary ||
                KeydataSummary != null &&
                KeydataSummary.Equals(other.KeydataSummary)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                LocalEncryptionConfiguration == other.LocalEncryptionConfiguration ||
                LocalEncryptionConfiguration != null &&
                LocalEncryptionConfiguration.Equals(other.LocalEncryptionConfiguration)
            ) &&
            (
                KeyConfigurationType == other.KeyConfigurationType ||
                KeyConfigurationType != null &&
                KeyConfigurationType.Equals(other.KeyConfigurationType)
            ) &&
            (
                KmsKeyArn == other.KmsKeyArn ||
                KmsKeyArn != null &&
                KmsKeyArn.Equals(other.KmsKeyArn)
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

            if (CreateDate != null)
            {
                hash = hash * 59 + CreateDate.GetHashCode();
            }

            if (KeydataSummary != null)
            {
                hash = hash * 59 + KeydataSummary.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (LocalEncryptionConfiguration != null)
            {
                hash = hash * 59 + LocalEncryptionConfiguration.GetHashCode();
            }

            if (KeyConfigurationType != null)
            {
                hash = hash * 59 + KeyConfigurationType.GetHashCode();
            }

            if (KmsKeyArn != null)
            {
                hash = hash * 59 + KmsKeyArn.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
