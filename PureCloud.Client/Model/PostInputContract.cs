using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// The schemas defining all of the expected requests/inputs.
/// </summary>
[DataContract]
public partial class PostInputContract : IEquatable<PostInputContract>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PostInputContract" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PostInputContract() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PostInputContract" /> class.
    /// </summary>
    /// <param name="InputSchema">JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path. (required).</param>
    public PostInputContract(JsonSchemaDocument InputSchema = null)
    {
        this.InputSchema = InputSchema;

    }



    /// <summary>
    /// JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path.
    /// </summary>
    /// <value>JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path.</value>
    [DataMember(Name = "inputSchema", EmitDefaultValue = false)]
    public JsonSchemaDocument InputSchema { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PostInputContract {\n");

        sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
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
        return this.Equals(obj as PostInputContract);
    }

    /// <summary>
    /// Returns true if PostInputContract instances are equal
    /// </summary>
    /// <param name="other">Instance of PostInputContract to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PostInputContract other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.InputSchema == other.InputSchema ||
                this.InputSchema != null &&
                this.InputSchema.Equals(other.InputSchema)
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
            if (this.InputSchema != null)
            {
                hash = hash * 59 + this.InputSchema.GetHashCode();
            }

            return hash;
        }
    }
}
