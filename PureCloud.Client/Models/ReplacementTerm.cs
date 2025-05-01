using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReplacementTerm
/// </summary>
[DataContract]
public partial class ReplacementTerm : IEquatable<ReplacementTerm>
{
    /// <summary>
    /// Social Handle Type
    /// </summary>
    /// <value>Social Handle Type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Name for "NAME"
        /// </summary>
        [EnumMember(Value = "NAME")]
        Name,

        /// <summary>
        /// Enum Address for "ADDRESS"
        /// </summary>
        [EnumMember(Value = "ADDRESS")]
        Address,

        /// <summary>
        /// Enum Phone for "PHONE"
        /// </summary>
        [EnumMember(Value = "PHONE")]
        Phone,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Twitter for "TWITTER"
        /// </summary>
        [EnumMember(Value = "TWITTER")]
        Twitter,

        /// <summary>
        /// Enum Facebook for "FACEBOOK"
        /// </summary>
        [EnumMember(Value = "FACEBOOK")]
        Facebook,

        /// <summary>
        /// Enum Instagram for "INSTAGRAM"
        /// </summary>
        [EnumMember(Value = "INSTAGRAM")]
        Instagram
    }
    /// <summary>
    /// Social Handle Type
    /// </summary>
    /// <value>Social Handle Type</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ReplacementTerm" /> class.
    /// </summary>
    /// <param name="Type">Social Handle Type.</param>
    /// <param name="ExistingValue">ExistingValue.</param>
    /// <param name="UpdatedValue">UpdatedValue.</param>
    public ReplacementTerm(TypeEnum? Type = null, string ExistingValue = null, string UpdatedValue = null)
    {
        this.Type = Type;
        this.ExistingValue = ExistingValue;
        this.UpdatedValue = UpdatedValue;

    }





    /// <summary>
    /// Gets or Sets ExistingValue
    /// </summary>
    [DataMember(Name = "existingValue", EmitDefaultValue = false)]
    public string ExistingValue { get; set; }



    /// <summary>
    /// Gets or Sets UpdatedValue
    /// </summary>
    [DataMember(Name = "updatedValue", EmitDefaultValue = false)]
    public string UpdatedValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReplacementTerm {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ExistingValue: ").Append(ExistingValue).Append("\n");
        sb.Append("  UpdatedValue: ").Append(UpdatedValue).Append("\n");
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
        return Equals(obj as ReplacementTerm);
    }

    /// <summary>
    /// Returns true if ReplacementTerm instances are equal
    /// </summary>
    /// <param name="other">Instance of ReplacementTerm to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReplacementTerm other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                ExistingValue == other.ExistingValue ||
                ExistingValue != null &&
                ExistingValue.Equals(other.ExistingValue)
            ) &&
            (
                UpdatedValue == other.UpdatedValue ||
                UpdatedValue != null &&
                UpdatedValue.Equals(other.UpdatedValue)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (ExistingValue != null)
            {
                hash = hash * 59 + ExistingValue.GetHashCode();
            }

            if (UpdatedValue != null)
            {
                hash = hash * 59 + UpdatedValue.GetHashCode();
            }

            return hash;
        }
    }
}
