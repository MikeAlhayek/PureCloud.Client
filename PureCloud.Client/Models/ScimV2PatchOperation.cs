using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM PATCH operation. The path and value follow very specific rules based on operation types. See section 3.5.2 \&quot;Modifying with PATCH\&quot; in RFC 7644 for details.
/// </summary>
[DataContract]
public partial class ScimV2PatchOperation : IEquatable<ScimV2PatchOperation>
{
    /// <summary>
    /// The PATCH operation to perform.
    /// </summary>
    /// <value>The PATCH operation to perform.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OpEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Add for "add"
        /// </summary>
        [EnumMember(Value = "add")]
        Add,

        /// <summary>
        /// Enum Replace for "replace"
        /// </summary>
        [EnumMember(Value = "replace")]
        Replace,

        /// <summary>
        /// Enum Remove for "remove"
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove
    }
    /// <summary>
    /// The PATCH operation to perform.
    /// </summary>
    /// <value>The PATCH operation to perform.</value>
    [DataMember(Name = "op", EmitDefaultValue = false)]
    public OpEnum? Op { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2PatchOperation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScimV2PatchOperation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2PatchOperation" /> class.
    /// </summary>
    /// <param name="Op">The PATCH operation to perform. (required).</param>
    /// <param name="Path">The attribute path that describes the target of the operation. Required for a \&quot;remove\&quot; operation..</param>
    /// <param name="Value">The value to set in the path..</param>
    public ScimV2PatchOperation(OpEnum? Op = null, string Path = null, object Value = null)
    {
        this.Op = Op;
        this.Path = Path;
        this.Value = Value;

    }





    /// <summary>
    /// The attribute path that describes the target of the operation. Required for a \&quot;remove\&quot; operation.
    /// </summary>
    /// <value>The attribute path that describes the target of the operation. Required for a \&quot;remove\&quot; operation.</value>
    [DataMember(Name = "path", EmitDefaultValue = false)]
    public string Path { get; set; }



    /// <summary>
    /// The value to set in the path.
    /// </summary>
    /// <value>The value to set in the path.</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public object Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimV2PatchOperation {\n");

        sb.Append("  Op: ").Append(Op).Append("\n");
        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as ScimV2PatchOperation);
    }

    /// <summary>
    /// Returns true if ScimV2PatchOperation instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2PatchOperation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimV2PatchOperation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Op == other.Op ||
                Op != null &&
                Op.Equals(other.Op)
            ) &&
            (
                Path == other.Path ||
                Path != null &&
                Path.Equals(other.Path)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (Op != null)
            {
                hash = hash * 59 + Op.GetHashCode();
            }

            if (Path != null)
            {
                hash = hash * 59 + Path.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
