using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Output definition of Action.
/// </summary>
[DataContract]
public partial class ActionOutput : IEquatable<ActionOutput>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionOutput" /> class.
    /// </summary>
    /// <param name="SuccessSchema">JSON schema that defines the transformed, successful result that will be sent back to the caller. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either successSchema or successSchemaFlattened will be returned, not both..</param>
    /// <param name="SuccessSchemaUri">URI to retrieve success schema.</param>
    /// <param name="ErrorSchema">JSON schema that defines the body of response when request is not successful. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either errorSchema or errorSchemaFlattened will be returned, not both..</param>
    /// <param name="ErrorSchemaUri">URI to retrieve error schema.</param>
    /// <param name="SuccessSchemaFlattened">JSON schema that defines the transformed, successful result that will be sent back to the caller. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either successSchema or successSchemaFlattened will be returned, not both..</param>
    /// <param name="ErrorSchemaFlattened">JSON schema that defines the body of response when request is not successful. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either errorSchema or errorSchemaFlattened will be returned, not both..</param>
    public ActionOutput(JsonSchemaDocument SuccessSchema = null, string SuccessSchemaUri = null, JsonSchemaDocument ErrorSchema = null, string ErrorSchemaUri = null, FlattenedJsonSchemaDocument SuccessSchemaFlattened = null, FlattenedJsonSchemaDocument ErrorSchemaFlattened = null)
    {
        this.SuccessSchema = SuccessSchema;
        this.SuccessSchemaUri = SuccessSchemaUri;
        this.ErrorSchema = ErrorSchema;
        this.ErrorSchemaUri = ErrorSchemaUri;
        this.SuccessSchemaFlattened = SuccessSchemaFlattened;
        this.ErrorSchemaFlattened = ErrorSchemaFlattened;

    }



    /// <summary>
    /// JSON schema that defines the transformed, successful result that will be sent back to the caller. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either successSchema or successSchemaFlattened will be returned, not both.
    /// </summary>
    /// <value>JSON schema that defines the transformed, successful result that will be sent back to the caller. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either successSchema or successSchemaFlattened will be returned, not both.</value>
    [DataMember(Name = "successSchema", EmitDefaultValue = false)]
    public JsonSchemaDocument SuccessSchema { get; set; }



    /// <summary>
    /// URI to retrieve success schema
    /// </summary>
    /// <value>URI to retrieve success schema</value>
    [DataMember(Name = "successSchemaUri", EmitDefaultValue = false)]
    public string SuccessSchemaUri { get; set; }



    /// <summary>
    /// JSON schema that defines the body of response when request is not successful. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either errorSchema or errorSchemaFlattened will be returned, not both.
    /// </summary>
    /// <value>JSON schema that defines the body of response when request is not successful. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either errorSchema or errorSchemaFlattened will be returned, not both.</value>
    [DataMember(Name = "errorSchema", EmitDefaultValue = false)]
    public JsonSchemaDocument ErrorSchema { get; set; }



    /// <summary>
    /// URI to retrieve error schema
    /// </summary>
    /// <value>URI to retrieve error schema</value>
    [DataMember(Name = "errorSchemaUri", EmitDefaultValue = false)]
    public string ErrorSchemaUri { get; set; }



    /// <summary>
    /// JSON schema that defines the transformed, successful result that will be sent back to the caller. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either successSchema or successSchemaFlattened will be returned, not both.
    /// </summary>
    /// <value>JSON schema that defines the transformed, successful result that will be sent back to the caller. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either successSchema or successSchemaFlattened will be returned, not both.</value>
    [DataMember(Name = "successSchemaFlattened", EmitDefaultValue = false)]
    public FlattenedJsonSchemaDocument SuccessSchemaFlattened { get; set; }



    /// <summary>
    /// JSON schema that defines the body of response when request is not successful. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either errorSchema or errorSchemaFlattened will be returned, not both.
    /// </summary>
    /// <value>JSON schema that defines the body of response when request is not successful. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either errorSchema or errorSchemaFlattened will be returned, not both.</value>
    [DataMember(Name = "errorSchemaFlattened", EmitDefaultValue = false)]
    public FlattenedJsonSchemaDocument ErrorSchemaFlattened { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionOutput {\n");

        sb.Append("  SuccessSchema: ").Append(SuccessSchema).Append("\n");
        sb.Append("  SuccessSchemaUri: ").Append(SuccessSchemaUri).Append("\n");
        sb.Append("  ErrorSchema: ").Append(ErrorSchema).Append("\n");
        sb.Append("  ErrorSchemaUri: ").Append(ErrorSchemaUri).Append("\n");
        sb.Append("  SuccessSchemaFlattened: ").Append(SuccessSchemaFlattened).Append("\n");
        sb.Append("  ErrorSchemaFlattened: ").Append(ErrorSchemaFlattened).Append("\n");
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
        return Equals(obj as ActionOutput);
    }

    /// <summary>
    /// Returns true if ActionOutput instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionOutput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionOutput other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SuccessSchema == other.SuccessSchema ||
                SuccessSchema != null &&
                SuccessSchema.Equals(other.SuccessSchema)
            ) &&
            (
                SuccessSchemaUri == other.SuccessSchemaUri ||
                SuccessSchemaUri != null &&
                SuccessSchemaUri.Equals(other.SuccessSchemaUri)
            ) &&
            (
                ErrorSchema == other.ErrorSchema ||
                ErrorSchema != null &&
                ErrorSchema.Equals(other.ErrorSchema)
            ) &&
            (
                ErrorSchemaUri == other.ErrorSchemaUri ||
                ErrorSchemaUri != null &&
                ErrorSchemaUri.Equals(other.ErrorSchemaUri)
            ) &&
            (
                SuccessSchemaFlattened == other.SuccessSchemaFlattened ||
                SuccessSchemaFlattened != null &&
                SuccessSchemaFlattened.Equals(other.SuccessSchemaFlattened)
            ) &&
            (
                ErrorSchemaFlattened == other.ErrorSchemaFlattened ||
                ErrorSchemaFlattened != null &&
                ErrorSchemaFlattened.Equals(other.ErrorSchemaFlattened)
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
            if (SuccessSchema != null)
            {
                hash = hash * 59 + SuccessSchema.GetHashCode();
            }

            if (SuccessSchemaUri != null)
            {
                hash = hash * 59 + SuccessSchemaUri.GetHashCode();
            }

            if (ErrorSchema != null)
            {
                hash = hash * 59 + ErrorSchema.GetHashCode();
            }

            if (ErrorSchemaUri != null)
            {
                hash = hash * 59 + ErrorSchemaUri.GetHashCode();
            }

            if (SuccessSchemaFlattened != null)
            {
                hash = hash * 59 + SuccessSchemaFlattened.GetHashCode();
            }

            if (ErrorSchemaFlattened != null)
            {
                hash = hash * 59 + ErrorSchemaFlattened.GetHashCode();
            }

            return hash;
        }
    }
}
