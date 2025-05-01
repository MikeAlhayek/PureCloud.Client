using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FieldList
/// </summary>
[DataContract]
public partial class FieldList : IEquatable<FieldList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FieldList" /> class.
    /// </summary>
    /// <param name="CustomLabels">CustomLabels.</param>
    /// <param name="InstructionText">InstructionText.</param>
    /// <param name="Key">Key.</param>
    /// <param name="LabelKeys">LabelKeys.</param>
    /// <param name="Params">Params.</param>
    /// <param name="Repeatable">Repeatable.</param>
    /// <param name="State">State.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Required">Required.</param>
    /// <param name="Gdpr">Gdpr.</param>
    public FieldList(bool? CustomLabels = null, string InstructionText = null, string Key = null, List<string> LabelKeys = null, Dictionary<string, object> Params = null, bool? Repeatable = null, string State = null, string Type = null, bool? Required = null, bool? Gdpr = null)
    {
        this.CustomLabels = CustomLabels;
        this.InstructionText = InstructionText;
        this.Key = Key;
        this.LabelKeys = LabelKeys;
        this.Params = Params;
        this.Repeatable = Repeatable;
        this.State = State;
        this.Type = Type;
        this.Required = Required;
        this.Gdpr = Gdpr;

    }



    /// <summary>
    /// Gets or Sets CustomLabels
    /// </summary>
    [DataMember(Name = "customLabels", EmitDefaultValue = false)]
    public bool? CustomLabels { get; set; }



    /// <summary>
    /// Gets or Sets InstructionText
    /// </summary>
    [DataMember(Name = "instructionText", EmitDefaultValue = false)]
    public string InstructionText { get; set; }



    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name = "key", EmitDefaultValue = false)]
    public string Key { get; set; }



    /// <summary>
    /// Gets or Sets LabelKeys
    /// </summary>
    [DataMember(Name = "labelKeys", EmitDefaultValue = false)]
    public List<string> LabelKeys { get; set; }



    /// <summary>
    /// Gets or Sets Params
    /// </summary>
    [DataMember(Name = "params", EmitDefaultValue = false)]
    public Dictionary<string, object> Params { get; set; }



    /// <summary>
    /// Gets or Sets Repeatable
    /// </summary>
    [DataMember(Name = "repeatable", EmitDefaultValue = false)]
    public bool? Repeatable { get; set; }



    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public string State { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [DataMember(Name = "required", EmitDefaultValue = false)]
    public bool? Required { get; set; }



    /// <summary>
    /// Gets or Sets Gdpr
    /// </summary>
    [DataMember(Name = "gdpr", EmitDefaultValue = false)]
    public bool? Gdpr { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FieldList {\n");

        sb.Append("  CustomLabels: ").Append(CustomLabels).Append("\n");
        sb.Append("  InstructionText: ").Append(InstructionText).Append("\n");
        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  LabelKeys: ").Append(LabelKeys).Append("\n");
        sb.Append("  Params: ").Append(Params).Append("\n");
        sb.Append("  Repeatable: ").Append(Repeatable).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Required: ").Append(Required).Append("\n");
        sb.Append("  Gdpr: ").Append(Gdpr).Append("\n");
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
        return Equals(obj as FieldList);
    }

    /// <summary>
    /// Returns true if FieldList instances are equal
    /// </summary>
    /// <param name="other">Instance of FieldList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FieldList other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CustomLabels == other.CustomLabels ||
                CustomLabels != null &&
                CustomLabels.Equals(other.CustomLabels)
            ) &&
            (
                InstructionText == other.InstructionText ||
                InstructionText != null &&
                InstructionText.Equals(other.InstructionText)
            ) &&
            (
                Key == other.Key ||
                Key != null &&
                Key.Equals(other.Key)
            ) &&
            (
                LabelKeys == other.LabelKeys ||
                LabelKeys != null &&
                LabelKeys.SequenceEqual(other.LabelKeys)
            ) &&
            (
                Params == other.Params ||
                Params != null &&
                Params.SequenceEqual(other.Params)
            ) &&
            (
                Repeatable == other.Repeatable ||
                Repeatable != null &&
                Repeatable.Equals(other.Repeatable)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Required == other.Required ||
                Required != null &&
                Required.Equals(other.Required)
            ) &&
            (
                Gdpr == other.Gdpr ||
                Gdpr != null &&
                Gdpr.Equals(other.Gdpr)
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
            if (CustomLabels != null)
            {
                hash = hash * 59 + CustomLabels.GetHashCode();
            }

            if (InstructionText != null)
            {
                hash = hash * 59 + InstructionText.GetHashCode();
            }

            if (Key != null)
            {
                hash = hash * 59 + Key.GetHashCode();
            }

            if (LabelKeys != null)
            {
                hash = hash * 59 + LabelKeys.GetHashCode();
            }

            if (Params != null)
            {
                hash = hash * 59 + Params.GetHashCode();
            }

            if (Repeatable != null)
            {
                hash = hash * 59 + Repeatable.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Required != null)
            {
                hash = hash * 59 + Required.GetHashCode();
            }

            if (Gdpr != null)
            {
                hash = hash * 59 + Gdpr.GetHashCode();
            }

            return hash;
        }
    }
}
