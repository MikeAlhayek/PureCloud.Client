using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AppendToDncActionSettings
/// </summary>
[DataContract]
public partial class AppendToDncActionSettings : IEquatable<AppendToDncActionSettings>
{
    /// <summary>
    /// The Dnc List Type to append entries to
    /// </summary>
    /// <value>The Dnc List Type to append entries to</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ListTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Rds for "Rds"
        /// </summary>
        [EnumMember(Value = "Rds")]
        Rds,

        /// <summary>
        /// Enum Rdscustom for "RdsCustom"
        /// </summary>
        [EnumMember(Value = "RdsCustom")]
        Rdscustom
    }
    /// <summary>
    /// The Dnc List Type to append entries to
    /// </summary>
    /// <value>The Dnc List Type to append entries to</value>
    [DataMember(Name = "listType", EmitDefaultValue = false)]
    public ListTypeEnum? ListType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AppendToDncActionSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AppendToDncActionSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AppendToDncActionSettings" /> class.
    /// </summary>
    /// <param name="Expire">Whether to expire the record appended to the DNC list. (required).</param>
    /// <param name="ExpirationDuration">If &#39;expire&#39; is set to true, how long to keep the record..</param>
    /// <param name="ListType">The Dnc List Type to append entries to.</param>
    public AppendToDncActionSettings(bool? Expire = null, string ExpirationDuration = null, ListTypeEnum? ListType = null)
    {
        this.Expire = Expire;
        this.ExpirationDuration = ExpirationDuration;
        this.ListType = ListType;

    }



    /// <summary>
    /// Whether to expire the record appended to the DNC list.
    /// </summary>
    /// <value>Whether to expire the record appended to the DNC list.</value>
    [DataMember(Name = "expire", EmitDefaultValue = false)]
    public bool? Expire { get; set; }



    /// <summary>
    /// If &#39;expire&#39; is set to true, how long to keep the record.
    /// </summary>
    /// <value>If &#39;expire&#39; is set to true, how long to keep the record.</value>
    [DataMember(Name = "expirationDuration", EmitDefaultValue = false)]
    public string ExpirationDuration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AppendToDncActionSettings {\n");

        sb.Append("  Expire: ").Append(Expire).Append("\n");
        sb.Append("  ExpirationDuration: ").Append(ExpirationDuration).Append("\n");
        sb.Append("  ListType: ").Append(ListType).Append("\n");
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
        return Equals(obj as AppendToDncActionSettings);
    }

    /// <summary>
    /// Returns true if AppendToDncActionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AppendToDncActionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AppendToDncActionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Expire == other.Expire ||
                Expire != null &&
                Expire.Equals(other.Expire)
            ) &&
            (
                ExpirationDuration == other.ExpirationDuration ||
                ExpirationDuration != null &&
                ExpirationDuration.Equals(other.ExpirationDuration)
            ) &&
            (
                ListType == other.ListType ||
                ListType != null &&
                ListType.Equals(other.ListType)
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
            if (Expire != null)
            {
                hash = hash * 59 + Expire.GetHashCode();
            }

            if (ExpirationDuration != null)
            {
                hash = hash * 59 + ExpirationDuration.GetHashCode();
            }

            if (ListType != null)
            {
                hash = hash * 59 + ListType.GetHashCode();
            }

            return hash;
        }
    }
}
