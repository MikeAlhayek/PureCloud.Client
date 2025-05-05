using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Contains information about the substitutions associated with a response.
/// </summary>

public partial class ResponseSubstitution : IEquatable<ResponseSubstitution>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseSubstitution" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ResponseSubstitution() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseSubstitution" /> class.
    /// </summary>
    /// <param name="Id">Response substitution identifier. (required).</param>
    /// <param name="Description">Response substitution description..</param>
    /// <param name="DefaultValue">Response substitution default value..</param>
    public ResponseSubstitution(string Id = null, string Description = null, string DefaultValue = null)
    {
        this.Id = Id;
        this.Description = Description;
        this.DefaultValue = DefaultValue;

    }



    /// <summary>
    /// Response substitution identifier.
    /// </summary>
    /// <value>Response substitution identifier.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Response substitution description.
    /// </summary>
    /// <value>Response substitution description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Response substitution default value.
    /// </summary>
    /// <value>Response substitution default value.</value>
    [JsonPropertyName("defaultValue")]
    public string DefaultValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResponseSubstitution {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
        return Equals(obj as ResponseSubstitution);
    }

    /// <summary>
    /// Returns true if ResponseSubstitution instances are equal
    /// </summary>
    /// <param name="other">Instance of ResponseSubstitution to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResponseSubstitution other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DefaultValue == other.DefaultValue ||
                DefaultValue != null &&
                DefaultValue.Equals(other.DefaultValue)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DefaultValue != null)
            {
                hash = hash * 59 + DefaultValue.GetHashCode();
            }

            return hash;
        }
    }
}
