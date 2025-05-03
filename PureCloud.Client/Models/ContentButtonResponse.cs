using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Button response object representing the click of a structured message button, such as a quick reply.
/// </summary>

public partial class ContentButtonResponse : IEquatable<ContentButtonResponse>
{
    /// <summary>
    /// Describes the button that resulted in the Button Response.
    /// </summary>
    /// <value>Describes the button that resulted in the Button Response.</value>
    
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
        /// Enum Button for "Button"
        /// </summary>
        [EnumMember(Value = "Button")]
        Button,

        /// <summary>
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Datepicker for "DatePicker"
        /// </summary>
        [EnumMember(Value = "DatePicker")]
        Datepicker
    }
    /// <summary>
    /// Describes the button that resulted in the Button Response.
    /// </summary>
    /// <value>Describes the button that resulted in the Button Response.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContentButtonResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContentButtonResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentButtonResponse" /> class.
    /// </summary>
    /// <param name="Id">An ID assigned to the button response (Deprecated)..</param>
    /// <param name="Type">Describes the button that resulted in the Button Response. (required).</param>
    /// <param name="Text">The response text from the button click. (required).</param>
    /// <param name="Payload">The response payload associated with the clicked button. (required).</param>
    public ContentButtonResponse(string Id = null, TypeEnum? Type = null, string Text = null, string Payload = null)
    {
        this.Id = Id;
        this.Type = Type;
        this.Text = Text;
        this.Payload = Payload;

    }



    /// <summary>
    /// An ID assigned to the button response (Deprecated).
    /// </summary>
    /// <value>An ID assigned to the button response (Deprecated).</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The response text from the button click.
    /// </summary>
    /// <value>The response text from the button click.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// The response payload associated with the clicked button.
    /// </summary>
    /// <value>The response payload associated with the clicked button.</value>
    [JsonPropertyName("payload")]
    public string Payload { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentButtonResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Payload: ").Append(Payload).Append("\n");
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
        return Equals(obj as ContentButtonResponse);
    }

    /// <summary>
    /// Returns true if ContentButtonResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentButtonResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentButtonResponse other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Payload == other.Payload ||
                Payload != null &&
                Payload.Equals(other.Payload)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Payload != null)
            {
                hash = hash * 59 + Payload.GetHashCode();
            }

            return hash;
        }
    }
}
