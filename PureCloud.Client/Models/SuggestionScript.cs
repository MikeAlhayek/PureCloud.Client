using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestionScript
/// </summary>
[DataContract]
public partial class SuggestionScript : IEquatable<SuggestionScript>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionScript" /> class.
    /// </summary>
    public SuggestionScript()
    {

    }



    /// <summary>
    /// The suggested script.
    /// </summary>
    /// <value>The suggested script.</value>
    [DataMember(Name = "script", EmitDefaultValue = false)]
    public AddressableEntityRef Script { get; private set; }



    /// <summary>
    /// The page of the script.
    /// </summary>
    /// <value>The page of the script.</value>
    [DataMember(Name = "page", EmitDefaultValue = false)]
    public AddressableEntityRef Page { get; private set; }



    /// <summary>
    /// The payload for the script.
    /// </summary>
    /// <value>The payload for the script.</value>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public Dictionary<string, string> Data { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestionScript {\n");

        sb.Append("  Script: ").Append(Script).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
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
        return Equals(obj as SuggestionScript);
    }

    /// <summary>
    /// Returns true if SuggestionScript instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestionScript to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestionScript other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Script == other.Script ||
                Script != null &&
                Script.Equals(other.Script)
            ) &&
            (
                Page == other.Page ||
                Page != null &&
                Page.Equals(other.Page)
            ) &&
            (
                Data == other.Data ||
                Data != null &&
                Data.SequenceEqual(other.Data)
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
            if (Script != null)
            {
                hash = hash * 59 + Script.GetHashCode();
            }

            if (Page != null)
            {
                hash = hash * 59 + Page.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            return hash;
        }
    }
}
