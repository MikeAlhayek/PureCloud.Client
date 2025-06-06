using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UsageItem
/// </summary>

public partial class UsageItem : IEquatable<UsageItem>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
        /// Enum Recording for "RECORDING"
        /// </summary>
        [EnumMember(Value = "RECORDING")]
        Recording,

        /// <summary>
        /// Enum Fax for "FAX"
        /// </summary>
        [EnumMember(Value = "FAX")]
        Fax,

        /// <summary>
        /// Enum Document for "DOCUMENT"
        /// </summary>
        [EnumMember(Value = "DOCUMENT")]
        Document,

        /// <summary>
        /// Enum All for "ALL"
        /// </summary>
        [EnumMember(Value = "ALL")]
        All
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UsageItem" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="TotalDocumentByteCount">TotalDocumentByteCount.</param>
    /// <param name="TotalDocumentCount">TotalDocumentCount.</param>
    public UsageItem(TypeEnum? Type = null, long? TotalDocumentByteCount = null, long? TotalDocumentCount = null)
    {
        this.Type = Type;
        this.TotalDocumentByteCount = TotalDocumentByteCount;
        this.TotalDocumentCount = TotalDocumentCount;

    }





    /// <summary>
    /// Gets or Sets TotalDocumentByteCount
    /// </summary>
    [JsonPropertyName("totalDocumentByteCount")]
    public long? TotalDocumentByteCount { get; set; }



    /// <summary>
    /// Gets or Sets TotalDocumentCount
    /// </summary>
    [JsonPropertyName("totalDocumentCount")]
    public long? TotalDocumentCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UsageItem {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  TotalDocumentByteCount: ").Append(TotalDocumentByteCount).Append("\n");
        sb.Append("  TotalDocumentCount: ").Append(TotalDocumentCount).Append("\n");
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
        return Equals(obj as UsageItem);
    }

    /// <summary>
    /// Returns true if UsageItem instances are equal
    /// </summary>
    /// <param name="other">Instance of UsageItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UsageItem other)
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
                TotalDocumentByteCount == other.TotalDocumentByteCount ||
                TotalDocumentByteCount != null &&
                TotalDocumentByteCount.Equals(other.TotalDocumentByteCount)
            ) &&
            (
                TotalDocumentCount == other.TotalDocumentCount ||
                TotalDocumentCount != null &&
                TotalDocumentCount.Equals(other.TotalDocumentCount)
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

            if (TotalDocumentByteCount != null)
            {
                hash = hash * 59 + TotalDocumentByteCount.GetHashCode();
            }

            if (TotalDocumentCount != null)
            {
                hash = hash * 59 + TotalDocumentCount.GetHashCode();
            }

            return hash;
        }
    }
}
