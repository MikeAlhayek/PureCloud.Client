using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySurveyQuestion
/// </summary>
[DataContract]
public partial class JourneySurveyQuestion : IEquatable<JourneySurveyQuestion>
{
    /// <summary>
    /// Type of survey question.
    /// </summary>
    /// <value>Type of survey question.</value>
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
        /// Enum Text for "text"
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Enum Hidden for "hidden"
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden,

        /// <summary>
        /// Enum Select for "select"
        /// </summary>
        [EnumMember(Value = "select")]
        Select,

        /// <summary>
        /// Enum Checkbox for "checkbox"
        /// </summary>
        [EnumMember(Value = "checkbox")]
        Checkbox,

        /// <summary>
        /// Enum Textarea for "textarea"
        /// </summary>
        [EnumMember(Value = "textarea")]
        Textarea
    }
    /// <summary>
    /// The customer property that the answer maps to.
    /// </summary>
    /// <value>The customer property that the answer maps to.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CustomerPropertyEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Givenname for "givenName"
        /// </summary>
        [EnumMember(Value = "givenName")]
        Givenname,

        /// <summary>
        /// Enum Familyname for "familyName"
        /// </summary>
        [EnumMember(Value = "familyName")]
        Familyname,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Phone for "phone"
        /// </summary>
        [EnumMember(Value = "phone")]
        Phone,

        /// <summary>
        /// Enum Gender for "gender"
        /// </summary>
        [EnumMember(Value = "gender")]
        Gender,

        /// <summary>
        /// Enum Companyname for "companyName"
        /// </summary>
        [EnumMember(Value = "companyName")]
        Companyname
    }
    /// <summary>
    /// Type of survey question.
    /// </summary>
    /// <value>Type of survey question.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The customer property that the answer maps to.
    /// </summary>
    /// <value>The customer property that the answer maps to.</value>
    [DataMember(Name = "customerProperty", EmitDefaultValue = false)]
    public CustomerPropertyEnum? CustomerProperty { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySurveyQuestion" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneySurveyQuestion() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySurveyQuestion" /> class.
    /// </summary>
    /// <param name="Type">Type of survey question..</param>
    /// <param name="Label">Label of question. (required).</param>
    /// <param name="CustomerProperty">The customer property that the answer maps to..</param>
    /// <param name="Choices">Choices available to user..</param>
    /// <param name="IsMandatory">Whether answering this question is mandatory..</param>
    public JourneySurveyQuestion(TypeEnum? Type = null, string Label = null, CustomerPropertyEnum? CustomerProperty = null, List<string> Choices = null, bool? IsMandatory = null)
    {
        this.Type = Type;
        this.Label = Label;
        this.CustomerProperty = CustomerProperty;
        this.Choices = Choices;
        this.IsMandatory = IsMandatory;

    }





    /// <summary>
    /// Label of question.
    /// </summary>
    /// <value>Label of question.</value>
    [DataMember(Name = "label", EmitDefaultValue = false)]
    public string Label { get; set; }





    /// <summary>
    /// Choices available to user.
    /// </summary>
    /// <value>Choices available to user.</value>
    [DataMember(Name = "choices", EmitDefaultValue = false)]
    public List<string> Choices { get; set; }



    /// <summary>
    /// Whether answering this question is mandatory.
    /// </summary>
    /// <value>Whether answering this question is mandatory.</value>
    [DataMember(Name = "isMandatory", EmitDefaultValue = false)]
    public bool? IsMandatory { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySurveyQuestion {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
        sb.Append("  CustomerProperty: ").Append(CustomerProperty).Append("\n");
        sb.Append("  Choices: ").Append(Choices).Append("\n");
        sb.Append("  IsMandatory: ").Append(IsMandatory).Append("\n");
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
        return Equals(obj as JourneySurveyQuestion);
    }

    /// <summary>
    /// Returns true if JourneySurveyQuestion instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySurveyQuestion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySurveyQuestion other)
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
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
            ) &&
            (
                CustomerProperty == other.CustomerProperty ||
                CustomerProperty != null &&
                CustomerProperty.Equals(other.CustomerProperty)
            ) &&
            (
                Choices == other.Choices ||
                Choices != null &&
                Choices.SequenceEqual(other.Choices)
            ) &&
            (
                IsMandatory == other.IsMandatory ||
                IsMandatory != null &&
                IsMandatory.Equals(other.IsMandatory)
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

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            if (CustomerProperty != null)
            {
                hash = hash * 59 + CustomerProperty.GetHashCode();
            }

            if (Choices != null)
            {
                hash = hash * 59 + Choices.GetHashCode();
            }

            if (IsMandatory != null)
            {
                hash = hash * 59 + IsMandatory.GetHashCode();
            }

            return hash;
        }
    }
}
