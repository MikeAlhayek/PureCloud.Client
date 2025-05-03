using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingTemplateButton
/// </summary>

public partial class RecordingTemplateButton : IEquatable<RecordingTemplateButton>
{
    /// <summary>
    /// Specifies the type of the button.
    /// </summary>
    /// <value>Specifies the type of the button.</value>
    
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
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Phonenumber for "PhoneNumber"
        /// </summary>
        [EnumMember(Value = "PhoneNumber")]
        Phonenumber,

        /// <summary>
        /// Enum Url for "Url"
        /// </summary>
        [EnumMember(Value = "Url")]
        Url
    }
    /// <summary>
    /// Specifies the type of the button.
    /// </summary>
    /// <value>Specifies the type of the button.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingTemplateButton" /> class.
    /// </summary>
    /// <param name="Type">Specifies the type of the button..</param>
    /// <param name="Text">Button text message..</param>
    /// <param name="Index">Index of the button in the list..</param>
    /// <param name="PhoneNumber">Button phone number..</param>
    /// <param name="Url">Button URL link..</param>
    /// <param name="IsSelected">Indicates if the button is selected by end customer..</param>
    public RecordingTemplateButton(TypeEnum? Type = null, string Text = null, long? Index = null, string PhoneNumber = null, string Url = null, bool? IsSelected = null)
    {
        this.Type = Type;
        this.Text = Text;
        this.Index = Index;
        this.PhoneNumber = PhoneNumber;
        this.Url = Url;
        this.IsSelected = IsSelected;

    }





    /// <summary>
    /// Button text message.
    /// </summary>
    /// <value>Button text message.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Index of the button in the list.
    /// </summary>
    /// <value>Index of the button in the list.</value>
    [JsonPropertyName("index")]
    public long? Index { get; set; }



    /// <summary>
    /// Button phone number.
    /// </summary>
    /// <value>Button phone number.</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// Button URL link.
    /// </summary>
    /// <value>Button URL link.</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Indicates if the button is selected by end customer.
    /// </summary>
    /// <value>Indicates if the button is selected by end customer.</value>
    [JsonPropertyName("isSelected")]
    public bool? IsSelected { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingTemplateButton {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Index: ").Append(Index).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  IsSelected: ").Append(IsSelected).Append("\n");
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
        return Equals(obj as RecordingTemplateButton);
    }

    /// <summary>
    /// Returns true if RecordingTemplateButton instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingTemplateButton to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingTemplateButton other)
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
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Index == other.Index ||
                Index != null &&
                Index.Equals(other.Index)
            ) &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                IsSelected == other.IsSelected ||
                IsSelected != null &&
                IsSelected.Equals(other.IsSelected)
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

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Index != null)
            {
                hash = hash * 59 + Index.GetHashCode();
            }

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (IsSelected != null)
            {
                hash = hash * 59 + IsSelected.GetHashCode();
            }

            return hash;
        }
    }
}
