using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialogflowIntent
/// </summary>

public partial class DialogflowIntent : IEquatable<DialogflowIntent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DialogflowIntent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DialogflowIntent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialogflowIntent" /> class.
    /// </summary>
    /// <param name="Name">The intent name (required).</param>
    /// <param name="Parameters">An object mapping parameter names to Parameter objects (required).</param>
    public DialogflowIntent(string Name = null, Dictionary<string, DialogflowParameter> Parameters = null)
    {
        this.Name = Name;
        this.Parameters = Parameters;

    }



    /// <summary>
    /// The intent name
    /// </summary>
    /// <value>The intent name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// An object mapping parameter names to Parameter objects
    /// </summary>
    /// <value>An object mapping parameter names to Parameter objects</value>
    [JsonPropertyName("parameters")]
    public Dictionary<string, DialogflowParameter> Parameters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialogflowIntent {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
        return Equals(obj as DialogflowIntent);
    }

    /// <summary>
    /// Returns true if DialogflowIntent instances are equal
    /// </summary>
    /// <param name="other">Instance of DialogflowIntent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialogflowIntent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Parameters == other.Parameters ||
                Parameters != null &&
                Parameters.SequenceEqual(other.Parameters)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Parameters != null)
            {
                hash = hash * 59 + Parameters.GetHashCode();
            }

            return hash;
        }
    }
}
