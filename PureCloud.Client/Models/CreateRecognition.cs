using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateRecognition
/// </summary>

public partial class CreateRecognition : IEquatable<CreateRecognition>
{
    /// <summary>
    /// The type of the recognition
    /// </summary>
    /// <value>The type of the recognition</value>
    
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
        /// Enum Thankyou for "ThankYou"
        /// </summary>
        [EnumMember(Value = "ThankYou")]
        Thankyou,

        /// <summary>
        /// Enum Congratulations for "Congratulations"
        /// </summary>
        [EnumMember(Value = "Congratulations")]
        Congratulations,

        /// <summary>
        /// Enum Highperformance for "HighPerformance"
        /// </summary>
        [EnumMember(Value = "HighPerformance")]
        Highperformance,

        /// <summary>
        /// Enum Companyvalues for "CompanyValues"
        /// </summary>
        [EnumMember(Value = "CompanyValues")]
        Companyvalues
    }
    /// <summary>
    /// The context type (optional)
    /// </summary>
    /// <value>The context type (optional)</value>
    
    public enum ContextTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Interaction for "Interaction"
        /// </summary>
        [EnumMember(Value = "Interaction")]
        Interaction,

        /// <summary>
        /// Enum Insights for "Insights"
        /// </summary>
        [EnumMember(Value = "Insights")]
        Insights,

        /// <summary>
        /// Enum Development for "Development"
        /// </summary>
        [EnumMember(Value = "Development")]
        Development,

        /// <summary>
        /// Enum Scorecard for "Scorecard"
        /// </summary>
        [EnumMember(Value = "Scorecard")]
        Scorecard
    }
    /// <summary>
    /// The type of the recognition
    /// </summary>
    /// <value>The type of the recognition</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The context type (optional)
    /// </summary>
    /// <value>The context type (optional)</value>
    [JsonPropertyName("contextType")]
    public ContextTypeEnum? ContextType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateRecognition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateRecognition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateRecognition" /> class.
    /// </summary>
    /// <param name="RecipientId">The recipient of the recognition (required).</param>
    /// <param name="Type">The type of the recognition (required).</param>
    /// <param name="Title">The title of the recognition. Max length of 100 characters (optional).</param>
    /// <param name="Note">The note of the recognition. Max length of 800 characters (optional).</param>
    /// <param name="ContextType">The context type (optional).</param>
    /// <param name="ContextId">The context id (optional).</param>
    public CreateRecognition(string RecipientId = null, TypeEnum? Type = null, string Title = null, string Note = null, ContextTypeEnum? ContextType = null, string ContextId = null)
    {
        this.RecipientId = RecipientId;
        this.Type = Type;
        this.Title = Title;
        this.Note = Note;
        this.ContextType = ContextType;
        this.ContextId = ContextId;

    }



    /// <summary>
    /// The recipient of the recognition
    /// </summary>
    /// <value>The recipient of the recognition</value>
    [JsonPropertyName("recipientId")]
    public string RecipientId { get; set; }





    /// <summary>
    /// The title of the recognition. Max length of 100 characters (optional)
    /// </summary>
    /// <value>The title of the recognition. Max length of 100 characters (optional)</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// The note of the recognition. Max length of 800 characters (optional)
    /// </summary>
    /// <value>The note of the recognition. Max length of 800 characters (optional)</value>
    [JsonPropertyName("note")]
    public string Note { get; set; }





    /// <summary>
    /// The context id (optional)
    /// </summary>
    /// <value>The context id (optional)</value>
    [JsonPropertyName("contextId")]
    public string ContextId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateRecognition {\n");

        sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  ContextType: ").Append(ContextType).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
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
        return Equals(obj as CreateRecognition);
    }

    /// <summary>
    /// Returns true if CreateRecognition instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateRecognition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateRecognition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RecipientId == other.RecipientId ||
                RecipientId != null &&
                RecipientId.Equals(other.RecipientId)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Note == other.Note ||
                Note != null &&
                Note.Equals(other.Note)
            ) &&
            (
                ContextType == other.ContextType ||
                ContextType != null &&
                ContextType.Equals(other.ContextType)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
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
            if (RecipientId != null)
            {
                hash = hash * 59 + RecipientId.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Note != null)
            {
                hash = hash * 59 + Note.GetHashCode();
            }

            if (ContextType != null)
            {
                hash = hash * 59 + ContextType.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            return hash;
        }
    }
}
