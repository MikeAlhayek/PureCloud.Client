using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Reasons for a failed message receipt.
/// </summary>
[DataContract]
public partial class Reason : IEquatable<Reason>
{
    /// <summary>
    /// The reason code for the failed message receipt.
    /// </summary>
    /// <value>The reason code for the failed message receipt.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Messageexpired for "MessageExpired"
        /// </summary>
        [EnumMember(Value = "MessageExpired")]
        Messageexpired,

        /// <summary>
        /// Enum Ratelimited for "RateLimited"
        /// </summary>
        [EnumMember(Value = "RateLimited")]
        Ratelimited,

        /// <summary>
        /// Enum Messagenotallowed for "MessageNotAllowed"
        /// </summary>
        [EnumMember(Value = "MessageNotAllowed")]
        Messagenotallowed,

        /// <summary>
        /// Enum Generalerror for "GeneralError"
        /// </summary>
        [EnumMember(Value = "GeneralError")]
        Generalerror,

        /// <summary>
        /// Enum Unsupportedmessage for "UnsupportedMessage"
        /// </summary>
        [EnumMember(Value = "UnsupportedMessage")]
        Unsupportedmessage,

        /// <summary>
        /// Enum Unknownmessage for "UnknownMessage"
        /// </summary>
        [EnumMember(Value = "UnknownMessage")]
        Unknownmessage,

        /// <summary>
        /// Enum Invalidmessagestructure for "InvalidMessageStructure"
        /// </summary>
        [EnumMember(Value = "InvalidMessageStructure")]
        Invalidmessagestructure,

        /// <summary>
        /// Enum Invaliddestination for "InvalidDestination"
        /// </summary>
        [EnumMember(Value = "InvalidDestination")]
        Invaliddestination,

        /// <summary>
        /// Enum Servererror for "ServerError"
        /// </summary>
        [EnumMember(Value = "ServerError")]
        Servererror,

        /// <summary>
        /// Enum Mediatypenotallowed for "MediaTypeNotAllowed"
        /// </summary>
        [EnumMember(Value = "MediaTypeNotAllowed")]
        Mediatypenotallowed,

        /// <summary>
        /// Enum Invalidmediacontentlength for "InvalidMediaContentLength"
        /// </summary>
        [EnumMember(Value = "InvalidMediaContentLength")]
        Invalidmediacontentlength,

        /// <summary>
        /// Enum Recipientoptedout for "RecipientOptedOut"
        /// </summary>
        [EnumMember(Value = "RecipientOptedOut")]
        Recipientoptedout
    }
    /// <summary>
    /// The reason code for the failed message receipt.
    /// </summary>
    /// <value>The reason code for the failed message receipt.</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public CodeEnum? Code { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Reason" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Reason() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Reason" /> class.
    /// </summary>
    /// <param name="Code">The reason code for the failed message receipt..</param>
    /// <param name="Message">Description of the reason for the failed message receipt. (required).</param>
    public Reason(CodeEnum? Code = null, string Message = null)
    {
        this.Code = Code;
        this.Message = Message;

    }





    /// <summary>
    /// Description of the reason for the failed message receipt.
    /// </summary>
    /// <value>Description of the reason for the failed message receipt.</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Reason {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
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
        return this.Equals(obj as Reason);
    }

    /// <summary>
    /// Returns true if Reason instances are equal
    /// </summary>
    /// <param name="other">Instance of Reason to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Reason other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Code == other.Code ||
                this.Code != null &&
                this.Code.Equals(other.Code)
            ) &&
            (
                this.Message == other.Message ||
                this.Message != null &&
                this.Message.Equals(other.Message)
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
            if (this.Code != null)
            {
                hash = hash * 59 + this.Code.GetHashCode();
            }

            if (this.Message != null)
            {
                hash = hash * 59 + this.Message.GetHashCode();
            }

            return hash;
        }
    }
}
