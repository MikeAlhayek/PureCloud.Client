using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Input requirements of Action.
/// </summary>

public partial class ActionInput : IEquatable<ActionInput>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionInput" /> class.
    /// </summary>
    /// <param name="InputSchema">JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either inputSchema or inputSchemaFlattened will be returned, not both..</param>
    /// <param name="InputSchemaFlattened">JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either inputSchema or inputSchemaFlattened will be returned, not both..</param>
    /// <param name="InputSchemaUri">The URI of the input schema.</param>
    public ActionInput(JsonSchemaDocument InputSchema = null, JsonSchemaDocument InputSchemaFlattened = null, string InputSchemaUri = null)
    {
        this.InputSchema = InputSchema;
        this.InputSchemaFlattened = InputSchemaFlattened;
        this.InputSchemaUri = InputSchemaUri;

    }



    /// <summary>
    /// JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either inputSchema or inputSchemaFlattened will be returned, not both.
    /// </summary>
    /// <value>JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path. If the &#39;flatten&#39; query parameter is omitted or false, this field will be returned. Either inputSchema or inputSchemaFlattened will be returned, not both.</value>
    [JsonPropertyName("inputSchema")]
    public JsonSchemaDocument InputSchema { get; set; }



    /// <summary>
    /// JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either inputSchema or inputSchemaFlattened will be returned, not both.
    /// </summary>
    /// <value>JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path. The schema is transformed based on Architect&#39;s flattened format. If the &#39;flatten&#39; query parameter is supplied as true, this field will be returned. Either inputSchema or inputSchemaFlattened will be returned, not both.</value>
    [JsonPropertyName("inputSchemaFlattened")]
    public JsonSchemaDocument InputSchemaFlattened { get; set; }



    /// <summary>
    /// The URI of the input schema
    /// </summary>
    /// <value>The URI of the input schema</value>
    [JsonPropertyName("inputSchemaUri")]
    public string InputSchemaUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionInput {\n");

        sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
        sb.Append("  InputSchemaFlattened: ").Append(InputSchemaFlattened).Append("\n");
        sb.Append("  InputSchemaUri: ").Append(InputSchemaUri).Append("\n");
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
        return Equals(obj as ActionInput);
    }

    /// <summary>
    /// Returns true if ActionInput instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionInput other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                InputSchema == other.InputSchema ||
                InputSchema != null &&
                InputSchema.Equals(other.InputSchema)
            ) &&
            (
                InputSchemaFlattened == other.InputSchemaFlattened ||
                InputSchemaFlattened != null &&
                InputSchemaFlattened.Equals(other.InputSchemaFlattened)
            ) &&
            (
                InputSchemaUri == other.InputSchemaUri ||
                InputSchemaUri != null &&
                InputSchemaUri.Equals(other.InputSchemaUri)
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
            if (InputSchema != null)
            {
                hash = hash * 59 + InputSchema.GetHashCode();
            }

            if (InputSchemaFlattened != null)
            {
                hash = hash * 59 + InputSchemaFlattened.GetHashCode();
            }

            if (InputSchemaUri != null)
            {
                hash = hash * 59 + InputSchemaUri.GetHashCode();
            }

            return hash;
        }
    }
}
