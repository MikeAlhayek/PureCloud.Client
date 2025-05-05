using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OpenActionProperties
/// </summary>

public partial class OpenActionProperties : IEquatable<OpenActionProperties>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenActionProperties" /> class.
    /// </summary>
    /// <param name="OpenActionName">The specific type of the open action..</param>
    /// <param name="ConfigurationFields">Custom fields defined in the schema referenced by the open action type selected..</param>
    public OpenActionProperties(string OpenActionName = null, Dictionary<string, object> ConfigurationFields = null)
    {
        this.OpenActionName = OpenActionName;
        this.ConfigurationFields = ConfigurationFields;

    }



    /// <summary>
    /// The specific type of the open action.
    /// </summary>
    /// <value>The specific type of the open action.</value>
    [JsonPropertyName("openActionName")]
    public string OpenActionName { get; set; }



    /// <summary>
    /// Custom fields defined in the schema referenced by the open action type selected.
    /// </summary>
    /// <value>Custom fields defined in the schema referenced by the open action type selected.</value>
    [JsonPropertyName("configurationFields")]
    public Dictionary<string, object> ConfigurationFields { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OpenActionProperties {\n");

        sb.Append("  OpenActionName: ").Append(OpenActionName).Append("\n");
        sb.Append("  ConfigurationFields: ").Append(ConfigurationFields).Append("\n");
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
        return Equals(obj as OpenActionProperties);
    }

    /// <summary>
    /// Returns true if OpenActionProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenActionProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenActionProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OpenActionName == other.OpenActionName ||
                OpenActionName != null &&
                OpenActionName.Equals(other.OpenActionName)
            ) &&
            (
                ConfigurationFields == other.ConfigurationFields ||
                ConfigurationFields != null &&
                ConfigurationFields.SequenceEqual(other.ConfigurationFields)
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
            if (OpenActionName != null)
            {
                hash = hash * 59 + OpenActionName.GetHashCode();
            }

            if (ConfigurationFields != null)
            {
                hash = hash * 59 + ConfigurationFields.GetHashCode();
            }

            return hash;
        }
    }
}
