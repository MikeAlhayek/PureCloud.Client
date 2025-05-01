using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DisconnectReason
/// </summary>
[DataContract]
public partial class DisconnectReason : IEquatable<DisconnectReason>
{
    /// <summary>
    /// Disconnect reason protocol type.
    /// </summary>
    /// <value>Disconnect reason protocol type.</value>
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
        /// Enum Q850 for "q850"
        /// </summary>
        [EnumMember(Value = "q850")]
        Q850,

        /// <summary>
        /// Enum Sip for "sip"
        /// </summary>
        [EnumMember(Value = "sip")]
        Sip
    }
    /// <summary>
    /// Disconnect reason protocol type.
    /// </summary>
    /// <value>Disconnect reason protocol type.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DisconnectReason" /> class.
    /// </summary>
    /// <param name="Type">Disconnect reason protocol type..</param>
    /// <param name="Code">Protocol specific reason code. See the Q.850 and SIP specs..</param>
    /// <param name="Phrase">Human readable English description of the disconnect reason..</param>
    public DisconnectReason(TypeEnum? Type = null, int? Code = null, string Phrase = null)
    {
        this.Type = Type;
        this.Code = Code;
        this.Phrase = Phrase;

    }





    /// <summary>
    /// Protocol specific reason code. See the Q.850 and SIP specs.
    /// </summary>
    /// <value>Protocol specific reason code. See the Q.850 and SIP specs.</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public int? Code { get; set; }



    /// <summary>
    /// Human readable English description of the disconnect reason.
    /// </summary>
    /// <value>Human readable English description of the disconnect reason.</value>
    [DataMember(Name = "phrase", EmitDefaultValue = false)]
    public string Phrase { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DisconnectReason {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Phrase: ").Append(Phrase).Append("\n");
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
        return this.Equals(obj as DisconnectReason);
    }

    /// <summary>
    /// Returns true if DisconnectReason instances are equal
    /// </summary>
    /// <param name="other">Instance of DisconnectReason to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DisconnectReason other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Code == other.Code ||
                this.Code != null &&
                this.Code.Equals(other.Code)
            ) &&
            (
                this.Phrase == other.Phrase ||
                this.Phrase != null &&
                this.Phrase.Equals(other.Phrase)
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
            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.Code != null)
            {
                hash = hash * 59 + this.Code.GetHashCode();
            }

            if (this.Phrase != null)
            {
                hash = hash * 59 + this.Phrase.GetHashCode();
            }

            return hash;
        }
    }
}
