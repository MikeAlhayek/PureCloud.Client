using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentQueryPredicate
/// </summary>

public partial class DocumentQueryPredicate : IEquatable<DocumentQueryPredicate>
{
    /// <summary>
    /// Gets or Sets Fields
    /// </summary>
    
    public enum FieldsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alternatives for "alternatives"
        /// </summary>
        [EnumMember(Value = "alternatives")]
        Alternatives,

        /// <summary>
        /// Enum Categoryid for "categoryId"
        /// </summary>
        [EnumMember(Value = "categoryId")]
        Categoryid,

        /// <summary>
        /// Enum Categoryname for "categoryName"
        /// </summary>
        [EnumMember(Value = "categoryName")]
        Categoryname,

        /// <summary>
        /// Enum Contextid for "contextId"
        /// </summary>
        [EnumMember(Value = "contextId")]
        Contextid,

        /// <summary>
        /// Enum Contextname for "contextName"
        /// </summary>
        [EnumMember(Value = "contextName")]
        Contextname,

        /// <summary>
        /// Enum Contextvalueid for "contextValueId"
        /// </summary>
        [EnumMember(Value = "contextValueId")]
        Contextvalueid,

        /// <summary>
        /// Enum Contextvaluename for "contextValueName"
        /// </summary>
        [EnumMember(Value = "contextValueName")]
        Contextvaluename,

        /// <summary>
        /// Enum Documentid for "documentId"
        /// </summary>
        [EnumMember(Value = "documentId")]
        Documentid,

        /// <summary>
        /// Enum Labelid for "labelId"
        /// </summary>
        [EnumMember(Value = "labelId")]
        Labelid,

        /// <summary>
        /// Enum Labelname for "labelName"
        /// </summary>
        [EnumMember(Value = "labelName")]
        Labelname,

        /// <summary>
        /// Enum Title for "title"
        /// </summary>
        [EnumMember(Value = "title")]
        Title,

        /// <summary>
        /// Enum Variationid for "variationId"
        /// </summary>
        [EnumMember(Value = "variationId")]
        Variationid,

        /// <summary>
        /// Enum Visible for "visible"
        /// </summary>
        [EnumMember(Value = "visible")]
        Visible,

        /// <summary>
        /// Enum State for "state"
        /// </summary>
        [EnumMember(Value = "state")]
        State
    }
    /// <summary>
    /// Specifies the matching criteria between the fields and values.
    /// </summary>
    /// <value>Specifies the matching criteria between the fields and values.</value>
    
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
        /// Enum Equals for "Equals"
        /// </summary>
        [EnumMember(Value = "Equals")]
        Equals,

        /// <summary>
        /// Enum Notequals for "NotEquals"
        /// </summary>
        [EnumMember(Value = "NotEquals")]
        Notequals,

        /// <summary>
        /// Enum Contains for "Contains"
        /// </summary>
        [EnumMember(Value = "Contains")]
        Contains,

        /// <summary>
        /// Enum Matchall for "MatchAll"
        /// </summary>
        [EnumMember(Value = "MatchAll")]
        Matchall,

        /// <summary>
        /// Enum Matchany for "MatchAny"
        /// </summary>
        [EnumMember(Value = "MatchAny")]
        Matchany
    }
    /// <summary>
    /// Specifies the matching criteria between the fields and values.
    /// </summary>
    /// <value>Specifies the matching criteria between the fields and values.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentQueryPredicate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentQueryPredicate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentQueryPredicate" /> class.
    /// </summary>
    /// <param name="Fields">Specifies the document fields to be matched against. (required).</param>
    /// <param name="Values">Specifies the values of the fields to be matched against. (required).</param>
    /// <param name="Type">Specifies the matching criteria between the fields and values. (required).</param>
    public DocumentQueryPredicate(List<FieldsEnum> Fields = null, List<string> Values = null, TypeEnum? Type = null)
    {
        this.Fields = Fields;
        this.Values = Values;
        this.Type = Type;

    }



    /// <summary>
    /// Specifies the document fields to be matched against.
    /// </summary>
    /// <value>Specifies the document fields to be matched against.</value>
    [JsonPropertyName("fields")]
    public List<FieldsEnum> Fields { get; set; }



    /// <summary>
    /// Specifies the values of the fields to be matched against.
    /// </summary>
    /// <value>Specifies the values of the fields to be matched against.</value>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentQueryPredicate {\n");

        sb.Append("  Fields: ").Append(Fields).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as DocumentQueryPredicate);
    }

    /// <summary>
    /// Returns true if DocumentQueryPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentQueryPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentQueryPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Fields == other.Fields ||
                Fields != null &&
                Fields.SequenceEqual(other.Fields)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (Fields != null)
            {
                hash = hash * 59 + Fields.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
